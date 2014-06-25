Imports MySql.Data.MySqlClient

Public Class frmAppointments

    Private binder As BindingSource
    Private adapter As MySqlDataAdapter
    Private data As DataTable

    Private Sub frmAppointments_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each c As Control In Me.Controls
            If c.GetType() Is GetType(TextBox) Then
                c.Text = String.Empty
            End If
        Next
        frmMain.AppointmentsToolStripMenuItem.Checked = False
    End Sub

    Private Sub frmAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "SELECT patient.first_name, patient.last_name, appointment.time, " & _
            "appointment.patient_id, appointment.appointment_id FROM appointment INNER JOIN patient ON " & _
            "patient.patient_id = appointment.patient_id ORDER BY appointment.time"
        binder = New BindingSource()
        adapter = New MySqlDataAdapter(sql, My.Resources.connectionString)

        data = New DataTable
        adapter.Fill(data)
        binder.DataSource = data
        dgvAppointment.DataSource = binder
    End Sub

    Private Sub UpdateFilter() Handles tbAppointmentId.TextChanged, tbFirstName.TextChanged, _
        tbLastName.TextChanged, tbPatientId.TextChanged
        binder.Filter = "convert(patient_id, 'System.String') LIKE '%" & tbPatientId.Text & _
            "%' AND first_name LIKE '%" & tbFirstName.Text & "%' AND last_name LIKE '%" & _
            tbLastName.Text & "%' and convert(appointment_id, 'System.String') LIKE '%" & tbAppointmentId.Text & "%'"
    End Sub

    Private Sub dgvAppointment_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAppointment.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Not frmMain.User.IsPractitioner Then
                tsiStartConsultation.Visible = False
            End If
            dgvAppointment.CurrentCell = dgvAppointment.Rows(e.RowIndex).Cells(e.ColumnIndex)
            csAppointments.Show(dgvAppointment, dgvAppointment.PointToClient(Windows.Forms.Cursor.Position))
        End If
    End Sub

    Private Sub tsiStartConsultation_Click(sender As Object, e As EventArgs) Handles tsiStartConsultation.Click
        frmConsultation.MdiParent = Me.MdiParent
        frmConsultation.Show()
        frmConsultation.setup(dgvAppointment.CurrentRow)
    End Sub

    Private Sub CancelAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelAppointmentToolStripMenuItem.Click
        Dim dialog As New dlgCancelAppointment
        dialog.setup(dgvAppointment.CurrentRow)
        dialog.ShowDialog()
    End Sub
End Class
