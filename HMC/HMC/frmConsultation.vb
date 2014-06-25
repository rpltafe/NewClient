Imports MySql.Data.MySqlClient

Public Class frmConsultation

    Private appointmentId
    Private startTime, endTime As Date

    Private Sub frmConsultation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each c As Control In Me.Controls
            If c.GetType() Is GetType(TextBox) Then
                c.Text = String.Empty
            End If
        Next
        TryCast(Me.MdiParent, frmMain).ConsultationToolStripMenuItem.Checked = False
        TryCast(Me.MdiParent, frmMain).ConsultationToolStripMenuItem.Visible = False
    End Sub

    Private Sub frmConsultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startTime = Date.Now
        TryCast(Me.MdiParent, frmMain).ConsultationToolStripMenuItem.Checked = True
        TryCast(Me.MdiParent, frmMain).ConsultationToolStripMenuItem.Visible = True
    End Sub

    Public Sub setup(row As DataGridViewRow)
        appointmentId = row.Cells("appointment_id").Value
        tbPatientId.Text = row.Cells("patient_id").Value
        tbAppointmentId.Text = row.Cells("appointment_id").Value
        tbFirstName.Text = row.Cells("first_name").Value
        tbLastName.Text = row.Cells("last_name").Value
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As New dlgInvoice
        With dialog
            .tbPatientId.Text = tbPatientId.Text
            .tbPatientName.Text = tbFirstName.Text & " " & tbLastName.Text
        End With
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Save(dialog.medicareInvoiceId, dialog.coPayInvoiceId)
            Me.Close()
        End If
    End Sub

    Private Sub Save(ByVal medicareInvoiceId As Integer, ByVal coPayInvoiceId As Integer)
        endTime = Date.Now
        Dim sql As String = "INSERT INTO consultation(appointment_id, medicare_invoice_id, copay_invoice_id, practitioner_id, startTime, endTime, " & _
            "reason, symptoms, advice, notes, prescriptions) VALUES (@appid, @medid, @coid, @pracid, @srttme, @endtme, @rsn, @symp, " & _
            "@adv, @nts, @prscpt)"
        Using conn As New MySqlConnection(My.Resources.connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                With cmd
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@appid", appointmentId)
                    .Parameters.AddWithValue("@medid", medicareInvoiceId)
                    .Parameters.AddWithValue("@coid", coPayInvoiceId)
                    .Parameters.AddWithValue("@pracid", frmMain.User.PractitionerId)
                    .Parameters.AddWithValue("@srttme", startTime)
                    .Parameters.AddWithValue("@endtme", endTime)
                    .Parameters.AddWithValue("@rsn", tbReason.Text)
                    .Parameters.AddWithValue("@symp", tbSymptoms.Text)
                    .Parameters.AddWithValue("@adv", tbAdvice.Text)
                    .Parameters.AddWithValue("@nts", tbNotes.Text)
                    .Parameters.AddWithValue("@prscpt", tbPrescriptions.Text)
                End With

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim res = MessageBox.Show("Are you sure you want to quit the current consultation?" & vbCrLf & _
                "All work in this form will be lost.", "Sure you want to quit?", MessageBoxButtons.YesNo)
        If res = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class