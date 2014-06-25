Imports MySql.Data.MySqlClient

Public Class frmAdminEditUser
    Private MySQL As MySqlConnection = New MySqlConnection(My.Resources.connectionString)
    Private user_id As String

    Public WriteOnly Property userId As String
        Set(value As String)
            Me.user_id = value
        End Set
    End Property

    Public WriteOnly Property username As String
        Set(value As String)
            textUsername.Text = value
        End Set
    End Property

    Public WriteOnly Property email As String
        Set(value As String)
            textEmail.Text = value
        End Set
    End Property

    Private Sub btnSaveUser_Click(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        If textUsername.Text IsNot "" Then
            If textPassword.Text IsNot "" Then
                If (user_id Is Nothing) Then
                    'insert
                    Dim userRecord As MySqlCommand = New MySqlCommand("INSERT INTO `user` (`user_id`, `email`, `username`, `password_hash`) VALUES (NULL, @email, @username, MD5(@password));SELECT LAST_INSERT_ID()", MySql)
                    userRecord.Parameters.AddWithValue("@email", Me.textEmail.Text)
                    userRecord.Parameters.AddWithValue("@username", Me.textUsername.Text)
                    userRecord.Parameters.AddWithValue("@password", Me.textPassword.Text)
                    MySql.Open()
                    Me.user_id = userRecord.ExecuteScalar()
                    MySql.Close()
                Else
                    'update
                    Dim userRecord As MySqlCommand = New MySqlCommand("UPDATE `user` SET `email` = @email, `username` = @username, `password_hash` = MD5(@password) WHERE `user`.`user_id` = " + Me.user_id, MySql)
                    userRecord.Parameters.AddWithValue("@email", Me.textEmail.Text)
                    userRecord.Parameters.AddWithValue("@username", Me.textUsername.Text)
                    userRecord.Parameters.AddWithValue("@password", Me.textPassword.Text)
                    MySql.Open()
                    userRecord.ExecuteNonQuery()
                    MySql.Close()
                End If
            Else
                If Me.user_id Is Nothing Then
                    MessageBox.Show("Please set a password for the user first!")
                    Return
                Else
                    'updating user information without changing password
                    Dim userRecord As MySqlCommand = New MySqlCommand("UPDATE `user` SET `email` = @email, `username` = @username WHERE `user`.`user_id` = " + Me.user_id, MySql)
                    userRecord.Parameters.AddWithValue("@email", Me.textEmail.Text)
                    userRecord.Parameters.AddWithValue("@username", Me.textUsername.Text)
                    MySql.Open()
                    userRecord.ExecuteNonQuery()
                    MySql.Close()
                End If

            End If
        Else
            MessageBox.Show("Enter a username!")
        End If
    End Sub

    Private Sub btnSetPassword_Click(sender As Object, e As EventArgs) Handles btnSetPassword.Click
        Dim pwd As frmSetPassword = New frmSetPassword
        pwd.ShowDialog()

        If (Not pwd.isCancel) Then
            Me.textPassword.Text = pwd.password
        End If
    End Sub
End Class