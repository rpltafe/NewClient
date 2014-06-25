Imports MySql.Data.MySqlClient

Public Class dlgCancelAppointment

    Private appDate As DateTime
    Private patientId As Integer
    Private dateFormat As String = "dd/MM/yyyyhh:mm:ss"

    Public Sub setup(ByVal row As DataGridViewRow)
        patientId = CInt(row.Cells("patient_id").Value)
        tbPatientName.Text = row.Cells("first_name").Value & " " & row.Cells("last_name").Value
        tbAppointmentId.Text = row.Cells("appointment_id").Value
        tbDateTime.Text = row.Cells("time").Value.ToString().Substring(0, 5) & " " & row.Cells("date").Value
        appDate = row.Cells("date").Value + row.Cells("time").Value
        Dim tomorrow As System.DateTime = Date.Now.Add(New TimeSpan(24, 0, 0))
        If appDate < Date.Now Then
            lblFeeMsg.Text = "Patient did not arrive?"
            lblFeeMsg.ForeColor = Color.Red
            tbFeeAmount.Enabled = True
        ElseIf appDate < tomorrow Then
            lblFeeMsg.Text = "Cancelled within 24 hours"
            lblFeeMsg.ForeColor = Color.Red
            tbFeeAmount.Enabled = True
        End If
    End Sub

    Private Sub tbFeeAmount_TextChanged(sender As Object, e As EventArgs) Handles tbFeeAmount.TextChanged
        tbFeeAmount.BackColor = Color.White
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If tbFeeAmount.Enabled Then
            If IsNumeric(tbFeeAmount.Text) Then
                dlgInvoice.CreateInvoice(patientId, CDbl(tbFeeAmount.Text), False)
            Else
                tbFeeAmount.BackColor = Color.LightCoral
                Return
            End If
        End If

        Dim sql As String = "CALL delete_appointment(@appid)"
        Using conn As New MySqlConnection(My.Resources.connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@appid", CInt(tbAppointmentId.Text))
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class