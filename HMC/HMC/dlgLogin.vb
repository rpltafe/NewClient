Imports MySql.Data.MySqlClient

Public Class dlgLogin

    Private _user As InternalUser

    Public ReadOnly Property User
        Get
            Return _user
        End Get
    End Property

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUsername.Text.Length < 4 Then
            tbUsername.BackColor = Color.LightCoral
            Return
        End If
        If tbPassword.Text.Length < 4 Then
            tbPassword.BackColor = Color.LightCoral
            Return
        End If
        Dim reader As MySqlDataReader
        Dim sql As String = "SELECT user.user_id, staff.staff_id, practitioner.practitioner_id, " & _
            "user.username, staff.first_name, staff.last_name FROM user LEFT JOIN staff ON staff.user_id " & _
            "= user.user_id LEFT JOIN practitioner ON practitioner.staff_id = staff.staff_id WHERE " & _
            "user.username = @usr AND user.password_hash = MD5(@pwd)"

        Using conn As New MySqlConnection(My.Resources.connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                With cmd
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@usr", tbUsername.Text)
                    .Parameters.AddWithValue("@pwd", tbPassword.Text)
                End With

                reader = cmd.ExecuteReader
                If reader.Read() Then
                    _user = New InternalUser
                    With _user
                        If reader.IsDBNull(1) Then
                            MsgBox("Can only log in as Staff from this application")
                            Return
                        Else
                            .StaffId = reader.GetInt32("staff_id")
                        End If
                        If reader.IsDBNull(2) Then
                            .PractitionerId = -1
                        Else
                            .PractitionerId = reader.GetInt32("practitioner_id")
                        End If
                        .UserId = reader.GetInt32("user_id")
                        .Username = reader.GetString("username")
                        .FirstName = reader.GetString("first_name")
                        .LastName = reader.GetString("last_name")
                    End With

                    tbPassword.Text = String.Empty
                    tbUsername.Text = String.Empty
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    tbUsername.BackColor = Color.LightCoral
                    tbPassword.BackColor = Color.LightCoral
                    Return
                End If
            End Using
        End Using
    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged, tbPassword.TextChanged
        tbUsername.BackColor = Color.White
        tbPassword.BackColor = Color.White
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tbPassword.Text = String.Empty
        tbUsername.Text = String.Empty
    End Sub
End Class