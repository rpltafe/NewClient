Imports MySql.Data.MySqlClient

Public Class frmAdministration
    Public bs As BiometricScanner.BiometricScanner
    Private staffBindingSource As BindingSource = New BindingSource()
    Private userBindingSource As BindingSource = New BindingSource()
    Private availabilityBindingSource As BindingSource = New BindingSource()
    Private MySQLConn As MySqlConnection = New MySqlConnection(My.Resources.connectionString)

    Private Sub frmAdministration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Populate Staff
        refreshStaff()
        refreshUsers()
        refreshRoster()
    End Sub

    Private Sub dataGridStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridStaff.CellDoubleClick
        If Not e.RowIndex = -1 Then
            editStaff(dataGridStaff.Rows(e.RowIndex))
        End If

    End Sub
    Private Sub DataGridUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridUsers.CellContentClick
        If Not e.RowIndex = -1 Then
            editUser(dataGridUsers.Rows(e.RowIndex))
        End If

    End Sub
    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        Dim newStaff As frmAdminEditStaff = New frmAdminEditStaff()
        newStaff.bs = bs
        newStaff.ShowDialog()
        refreshStaff()
    End Sub

    Private Sub btnEditStaff_Click(sender As Object, e As EventArgs) Handles btnEditStaff.Click
        If dataGridStaff.SelectedRows.Count = 1 Then
            editStaff(dataGridStaff.SelectedRows(0))
        End If
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        If dataGridUsers.SelectedRows.Count = 1 Then
            editUser(dataGridUsers.SelectedRows(0))
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If dataGridUsers.SelectedRows.Count = 1 Then
            Dim row = dataGridUsers.SelectedRows(0)
            If (MessageBox.Show("Are you sure you want to delete '" & row.Cells("username").Value.ToString & "' user record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Dim cmd = New MySqlCommand("DELETE FROM user WHERE user_id = " & row.Cells("user_id").Value.ToString & ";UPDATE `staff` SET `user_id` = NULL WHERE `user_id` = " & row.Cells("user_id").Value.ToString, MySQLConn)
                MySQLConn.Open()
                Try
                    cmd.ExecuteNonQuery()
                    dataGridUsers.Rows.Remove(row)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error Deleting user")
                End Try

                MySQLConn.Close()

            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        If dataGridStaff.SelectedRows.Count = 1 Then
            Dim row = dataGridStaff.SelectedRows(0)
            If (MessageBox.Show("Are you sure you want to delete '" & row.Cells("first_name").Value.ToString + " " & row.Cells("last_name").Value.ToString & "' staff member record (staff,user,fingerprints)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                'DELETE FROM staff,user,fingerprint USING staff INNER JOIN user ON staff.staff_id = user.staff_id INNER JOIN fingerprint ON staff.staff_id = fingerprint.staff_id WHERE staff.staff_id =
                Dim cmd = New MySqlCommand("DELETE FROM staff,user,fingerprint USING staff INNER JOIN user ON staff.user_id = user.user_id INNER JOIN fingerprint ON staff.staff_id = fingerprint.staff_id WHERE staff.staff_id = " & row.Cells("staff_id").Value.ToString, MySQLConn)
                MySQLConn.Open()
                Try
                    cmd.ExecuteNonQuery()
                    dataGridStaff.Rows.Remove(row)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error Deleting Staff Member")
                End Try

                MySQLConn.Close()

            End If
        End If
    End Sub
    Private Sub btnRefreshRoster_Click(sender As Object, e As EventArgs) Handles btnRefreshRoster.Click
        refreshRoster()
    End Sub
    Private Sub btnRefreshUsers_Click(sender As Object, e As EventArgs) Handles btnRefreshUsers.Click
        refreshUsers()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim newUser As frmAdminEditStaff = New frmAdminEditStaff()
        newUser.ShowDialog()
        refreshUsers()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshStaff()
    End Sub

    Private Sub uploadRoster_Click(sender As Object, e As EventArgs) Handles btnUploadRoster.Click
        Dim upload As New frmAdminUploadRoster
        upload.ShowDialog()
    End Sub

    Private Sub dateAvailability_ValueChanged(sender As Object, e As EventArgs) Handles dateAvailability.ValueChanged
        refreshRoster()
    End Sub

    Private Sub refreshStaff()
        Dim cmd As New MySqlCommand("SELECT `staff`.`staff_id`, `staff`.`first_name`, `staff`.`last_name`, `staff`.`gender`, `staff`.`address`, `staff`.`dob`, `staff`.`phone`, (CASE WHEN admin <> 0 THEN 'True' ELSE 'False' END) As Admin, `staff`.`user_id`, user.username, user.email FROM staff LEFT JOIN user ON user.user_id=staff.user_id", MySQLConn)
        Dim da = New MySqlDataAdapter(cmd)
        Dim dt = New DataTable()
        da.Fill(dt)
        staffBindingSource.DataSource = dt ' here assign the DataTable'

        With Me.dataGridStaff
            .AutoGenerateColumns = True
            .DataSource = staffBindingSource
        End With
    End Sub

    Private Sub refreshUsers()
        Dim cmd As New MySqlCommand("SELECT * FROM `user`", MySQLConn)
        Dim da = New MySqlDataAdapter(cmd)
        Dim dt = New DataTable()
        da.Fill(dt)
        userBindingSource.DataSource = dt ' here assign the DataTable'

        With Me.dataGridUsers
            .AutoGenerateColumns = True
            .DataSource = userBindingSource
        End With
    End Sub

    Private Sub refreshRoster()
        'SELECT `staff`.`staff_id`,CONCAT(`staff`.first_name, ' ', `staff`.last_name) As StaffMember,UNIX_TIMESTAMP(`start_time`) as Timestamp,DATE(`start_time`) as StartDate, DATE_FORMAT(`start_time`,'%r') as StartTime, DATE(`end_time`) as EndDate, DATE_FORMAT(`end_time`,'%r') as EndTime FROM `availability` LEFT JOIN staff ON `availability`.staff_id=staff.staff_id WHERE DATE(`start_time`) = @date
        Dim cmd As New MySqlCommand("SELECT `staff`.`staff_id`,CONCAT(`staff`.first_name, ' ', `staff`.last_name) As StaffMember,UNIX_TIMESTAMP(`start_time`) as Timestamp,DATE(`start_time`) as StartDate, DATE_FORMAT(`start_time`,'%r') as StartTime, DATE(`end_time`) as EndDate, DATE_FORMAT(`end_time`,'%r') as EndTime FROM `availability` LEFT JOIN staff ON `availability`.staff_id=staff.staff_id WHERE DATE(`start_time`) = STR_TO_DATE(@date, '%d/%m/%Y') OR DATE(`end_time`) = STR_TO_DATE(@date, '%d/%m/%Y')", MySQLConn)
        cmd.Parameters.AddWithValue("@date", dateAvailability.Value.ToShortDateString)
        Dim da = New MySqlDataAdapter(cmd)
        Dim dt = New DataTable()
        da.Fill(dt)
        availabilityBindingSource.DataSource = dt ' here assign the DataTable'

        With Me.dataGridRoster
            .AutoGenerateColumns = True
            .DataSource = availabilityBindingSource
            .Sort(dataGridRoster.Columns("Timestamp"), System.ComponentModel.ListSortDirection.Ascending)
        End With

    End Sub

    Private Sub editStaff(row As DataGridViewRow)
        Dim staff As frmAdminEditStaff = New frmAdminEditStaff()
        staff.id = row.Cells("staff_id").Value.ToString
        staff.firstName = row.Cells("first_name").Value.ToString
        staff.lastName = row.Cells("last_name").Value.ToString
        staff.Gender = row.Cells("gender").Value.ToString
        staff.DOB = row.Cells("dob").Value
        staff.address = row.Cells("address").Value.ToString
        staff.phone = row.Cells("phone").Value.ToString
        staff.userID = row.Cells("user_id").Value.ToString
        staff.username = row.Cells("username").Value.ToString
        staff.email = row.Cells("email").Value.ToString
        staff.admin = (row.Cells("admin").Value.ToString = "True")

        staff.bs = bs 'biometric Scanner for fingerprint registration
        staff.ShowDialog()
        refreshStaff()
    End Sub

    Private Sub editUser(row As DataGridViewRow)
        Dim user As frmAdminEditUser = New frmAdminEditUser()
        user.userID = row.Cells("user_id").Value.ToString
        user.username = row.Cells("username").Value.ToString
        user.email = row.Cells("email").Value.ToString
        user.ShowDialog()
        refreshUsers()
    End Sub
End Class