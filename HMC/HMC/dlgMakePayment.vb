Imports MySql.Data.MySqlClient

Public Class dlgMakePayment

    Private invoiceId As Integer
    Private total As Double, paid As Double, remaining As Double

    Private Sub dlgMakePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM payment WHERE invoice_id = @inid"
        Using conn As New MySqlConnection(My.Resources.connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@inid", invoiceId)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    paid += reader.GetDouble("amount")
                End While
                remaining = total - paid
            End Using
        End Using
        tbPaid.Text = paid
        tbRemaining.Text = remaining
    End Sub

    Public Sub setup(ByVal row As DataGridViewRow)
        invoiceId = row.Cells("invoice_id").Value
        total = row.Cells("total_amount").Value
        tbInvoiceId.Text = invoiceId
        tbPatientName.Text = row.Cells("first_name").Value & " " & row.Cells("last_name").Value
        tbTotal.Text = total
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If Not IsNumeric(tbNewPayment.Text) Then
            tbNewPayment.BackColor = Color.LightCoral
            Return
        End If
        If (paid + CDbl(tbNewPayment.Text)) > total Then
            If Not MessageBox.Show("Payment brings total paid to more than total amount listed on invoice. Proceed?", "Payment", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Return
            End If
        End If
        Dim sql As String = "INSERT INTO payment (invoice_id, amount, method, date) VALUES (@inid, @amt, @mth, @date)"

        Using conn As New MySqlConnection(My.Resources.connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                With cmd
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@inid", invoiceId)
                    .Parameters.AddWithValue("@amt", CDbl(tbNewPayment.Text))
                    .Parameters.AddWithValue("@mth", tbMethod.Text)
                    .Parameters.AddWithValue("@date", Date.Now.Date)
                    .ExecuteNonQuery()
                End With
            End Using

            If (remaining - CDbl(tbNewPayment.Text)) <= 0 Then
                sql = "UPDATE invoice SET status = 'paid' WHERE invoice_id = @inid"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@inid", invoiceId)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbNewPayment_TextChanged(sender As Object, e As EventArgs) Handles tbNewPayment.TextChanged
        tbNewPayment.BackColor = Color.White
    End Sub
End Class