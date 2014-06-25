Imports MySql.Data.MySqlClient

Public Class frmAdminEditStaff
    Friend bs As BiometricScanner.BiometricScanner
    Private fingerprintBindingSource As BindingSource = New BindingSource()
    Private MySQL As MySqlConnection = New MySqlConnection(My.Resources.connectionString)

    Private staff_id As String = Nothing
    Private user_id As String = Nothing
    Private password As String = Nothing

    Public WriteOnly Property id As String
        Set(value As String)
            If value IsNot "" Then
                Me.staff_id = value
                updateFingerprints()
            End If
        End Set
    End Property

    Public WriteOnly Property firstName As String
        Set(value As String)
            Me.textFirstName.Text = value
        End Set
    End Property

    Public WriteOnly Property lastName As String
        Set(value As String)
            Me.textLastName.Text = value
        End Set
    End Property

    Public WriteOnly Property Gender As String
        Set(value As String)
            If (cbGender.Items.Contains(value)) Then
                cbGender.SelectedItem = value
            Else
                cbGender.Items.Add(value)
                cbGender.SelectedItem = value
            End If

            'TODO: Me.textStaffID.Text = value
        End Set
    End Property

    Public WriteOnly Property DOB As Date
        Set(value As Date)
            Me.dateDOB.Value = value
        End Set
    End Property

    Public WriteOnly Property address As String
        Set(value As String)
            Me.textAddress.Text = value
        End Set
    End Property

    Public WriteOnly Property phone As String
        Set(value As String)
            Me.textPhone.Text = value
        End Set
    End Property

    Public WriteOnly Property userID As String
        Set(value As String)
            Me.user_id = value
        End Set
    End Property

    Public WriteOnly Property username As String
        Set(value As String)
            Me.textUsername.Text = value
        End Set
    End Property

    Public WriteOnly Property email As String
        Set(value As String)
            Me.textEmail.Text = value
        End Set
    End Property

    Public WriteOnly Property admin As Boolean
        Set(value As Boolean)
            Me.chkbxAdmin.Checked = value
        End Set
    End Property

    Sub New()
        InitializeComponent()

    End Sub

    Private Sub updateFingerprints()
        Dim cmd As New MySqlCommand("SELECT `fingerprint_id`, `fingerprint` FROM `fingerprint` WHERE `staff_id` = " + Me.staff_id, MySQL)
        Dim da = New MySqlDataAdapter(cmd)
        Dim dt = New DataTable()
        da.Fill(dt)
        fingerprintBindingSource.DataSource = dt

        With Me.DataGridFingerprints
            .AutoGenerateColumns = True
            .DataSource = fingerprintBindingSource
        End With
    End Sub

    Private Sub btnAddFingerprint_Click(sender As Object, e As EventArgs) Handles btnAddFingerprint.Click
        If (Not staff_id Is Nothing) Then
            bs.RegisterFingerprint(textFirstName.Text & " " & textLastName.Text, staff_id)
            updateFingerprints()
        Else
            MessageBox.Show("Save staff record first")
        End If
    End Sub

    Private Sub btnSetPassword_Click(sender As Object, e As EventArgs) Handles btnSetPassword.Click
        Dim pwd As frmSetPassword = New frmSetPassword
        pwd.ShowDialog()

        If (Not pwd.isCancel) Then
            Me.textPassword.Text = pwd.password
        End If

    End Sub

    Private Sub btnDeleteFingerprint_Click(sender As Object, e As EventArgs) Handles btnDeleteFingerprint.Click
        If (DataGridFingerprints.SelectedRows.Count > 0) Then
            Dim fingerPrintsToDelete As String = ""
            For i As Integer = Me.DataGridFingerprints.SelectedRows.Count - 1 To 0 Step -1
                fingerPrintsToDelete += Me.DataGridFingerprints.SelectedRows(i).Cells("fingerprint_id").Value.ToString & If(i = 0, "", ",")
                Me.DataGridFingerprints.Rows.Remove(Me.DataGridFingerprints.SelectedRows(i))
            Next
            MySQL.Open()
            Try
                Dim cmd As New MySqlCommand("DELETE FROM `fingerprint` WHERE `fingerprint_id` IN (" + fingerPrintsToDelete + ") AND `staff_id` = " + Me.staff_id, MySQL)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Deleting Fingerprints")
            End Try

            MySQL.Close()

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbGender.SelectedItem Is Nothing Then
            MessageBox.Show("Select a gender first!")
            Return
        End If
        If (Not saveUsertoMySQL()) Then Return 'if critical error in saving of user stop save process
        MySQL.Open()
        'Save staff record
        Dim sql As String
        If (staff_id Is Nothing) Then
            'insert record
            sql = "INSERT INTO `staff` (`staff_id`, `user_id`, `first_name`, `last_name`, `gender`, `address`, `dob`, `phone`,`admin`) VALUES (NULL, @userId, @firstName, @lastName, @gender, @address, @dob, @phone, @admin); SELECT LAST_INSERT_ID()"
        Else
            'update record
            sql = "UPDATE `staff` SET `user_id`= @userId, `first_name` = @firstName, `last_name` = @lastName, `gender` = @gender, `address` = @address, `dob` = @dob , `phone` = @phone , `admin` = @admin WHERE `staff_id` = " + Me.staff_id
        End If

        Dim staffRecord As MySqlCommand = New MySqlCommand(Sql, MySQL)
        staffRecord.Parameters.AddWithValue("@userId", Me.user_id)
        staffRecord.Parameters.AddWithValue("@firstName", Me.textFirstName.Text)
        staffRecord.Parameters.AddWithValue("@lastName", Me.textLastName.Text)
        staffRecord.Parameters.AddWithValue("@gender", Me.cbGender.SelectedItem.ToString)
        staffRecord.Parameters.AddWithValue("@address", Me.textAddress.Text)
        staffRecord.Parameters.AddWithValue("@dob", Me.dateDOB.Value)
        staffRecord.Parameters.AddWithValue("@phone", Me.textPhone.Text)
        staffRecord.Parameters.AddWithValue("@admin", Me.chkbxAdmin.Checked)

        If (staff_id Is Nothing) Then
            Me.staff_id = staffRecord.ExecuteScalar()
        Else
            staffRecord.ExecuteNonQuery()
        End If

        MySQL.Close()
        MessageBox.Show("Staff record saved!")
    End Sub

    Private Sub btnSaveUser_Click(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        saveUsertoMySQL()
    End Sub

    Private Function saveUsertoMySQL() As Boolean
        If textUsername.Text IsNot "" Then
            If textPassword.Text IsNot "" Then
                If (user_id Is Nothing) Then
                    'insert
                    Dim userRecord As MySqlCommand = New MySqlCommand("INSERT INTO `user` (`user_id`, `email`, `username`, `password_hash`) VALUES (NULL, @email, @username, MD5(@password));SELECT LAST_INSERT_ID()", MySQL)
                    userRecord.Parameters.AddWithValue("@email", Me.textEmail.Text)
                    userRecord.Parameters.AddWithValue("@username", Me.textUsername.Text)
                    userRecord.Parameters.AddWithValue("@password", Me.textPassword.Text)
                    MySQL.Open()
                    Me.user_id = userRecord.ExecuteScalar()
                    MySQL.Close()
                Else
                    'update
                    Dim userRecord As MySqlCommand = New MySqlCommand("UPDATE `user` SET `email` = @email, `username` = @username, `password_hash` = MD5(@password) WHERE `user`.`user_id` = " + Me.user_id, MySQL)
                    userRecord.Parameters.AddWithValue("@email", Me.textEmail.Text)
                    userRecord.Parameters.AddWithValue("@username", Me.textUsername.Text)
                    userRecord.Parameters.AddWithValue("@password", Me.textPassword.Text)
                    MySQL.Open()
                    userRecord.ExecuteNonQuery()
                    MySQL.Close()
                End If
            Else
                If Me.user_id Is Nothing Then
                    MessageBox.Show("Please set a password for the user first!")
                    Return False
                Else
                    'updating user information without changing password
                    Dim userRecord As MySqlCommand = New MySqlCommand("UPDATE `user` SET `email` = @email, `username` = @username WHERE `user`.`user_id` = " + Me.user_id, MySQL)
                    userRecord.Parameters.AddWithValue("@email", Me.textEmail.Text)
                    userRecord.Parameters.AddWithValue("@username", Me.textUsername.Text)
                    MySQL.Open()
                    userRecord.ExecuteNonQuery()
                    MySQL.Close()
                End If

            End If
        Else
            MessageBox.Show("Skipping user record creation as no username entered")
        End If
        Return True
    End Function
End Class