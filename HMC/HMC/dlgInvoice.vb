Imports MySql.Data.MySqlClient

Public Class dlgInvoice

    Public medicareInvoiceId As Integer = 0
    Public coPayInvoiceId As Integer = 0

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not IsNumeric(tbCoPay.Text) Or Not IsNumeric(tbMedicare.Text) Then
            MsgBox("Invalid decimal values for amounts")
            Return
        End If
        medicareInvoiceId = CreateInvoice(CInt(tbPatientId.Text), CDbl(tbMedicare.Text), True)
        If CDbl(tbCoPay.Text) > 0 Then
            coPayInvoiceId = CreateInvoice(CInt(tbPatientId.Text), CDbl(tbCoPay.Text), False)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ValidateNumeric(sender As Object, e As KeyPressEventArgs) Handles tbCoPay.KeyPress, tbMedicare.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Function CreateInvoice(ByVal patientId As Integer, ByVal amount As Double, ByVal medicare As Boolean)
        Dim sql As String = "INSERT INTO invoice (patient_id, total_amount, status) " & _
            "VALUES (@patid, @total, @stat); SELECT LAST_INSERT_ID()"
        Dim invoiceId As Integer

        Using conn As New MySqlConnection(My.Resources.connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                With cmd
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@patid", patientId)
                    .Parameters.AddWithValue("@total", amount)
                    If medicare Then
                        .Parameters.AddWithValue("@stat", "medicare")
                    Else
                        .Parameters.AddWithValue("@stat", "unpaid")
                    End If
                    invoiceId = .ExecuteScalar()
                End With
            End Using
        End Using

        Return invoiceId
    End Function
End Class