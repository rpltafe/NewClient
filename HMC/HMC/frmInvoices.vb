Imports MySql.Data.MySqlClient

Public Class frmInvoices

    Private binder As BindingSource
    Private adapter As MySqlDataAdapter
    Private data As DataTable

    Private Sub frmInvoices_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each c As Control In Me.Controls
            If c.GetType() Is GetType(TextBox) Then
                c.Text = String.Empty
            End If
        Next
        frmMain.InvoicesToolStripMenuItem.Checked = False
    End Sub

    Private Sub frmInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "SELECT invoice.invoice_id, invoice.patient_id, patient.first_name, patient.last_name, " & _
            "invoice.total_amount, invoice.status FROM invoice INNER JOIN patient ON patient.patient_id = invoice.patient_id"
        binder = New BindingSource()
        adapter = New MySqlDataAdapter(sql, My.Resources.connectionString)

        data = New DataTable
        adapter.Fill(data)
        binder.DataSource = data
        dgvInvoice.DataSource = binder

        cbStatus.SelectedIndex = 0
    End Sub

    Private Sub UpdateFilter() Handles tbPatientId.TextChanged, tbFirstName.TextChanged, tbInvoiceId.TextChanged, _
        tbLastName.TextChanged, cbStatus.SelectedIndexChanged
        binder.Filter = "convert(patient_id, 'System.String') LIKE '%" & tbPatientId.Text & _
            "%' AND first_name LIKE '%" & tbFirstName.Text & "%' AND last_name LIKE '%" & tbLastName.Text & _
            "%' and convert(invoice_id, 'System.String') LIKE '%" & tbInvoiceId.Text & "%' and status = '" & _
            cbStatus.SelectedItem & "'"
    End Sub

    Private Sub EditInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditInvoiceToolStripMenuItem.Click
        
    End Sub

    Private Sub dgvInvoice_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInvoice.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If cbStatus.SelectedIndex = 1 Or cbStatus.SelectedIndex = 2 Then
                MakePaymentToolStripMenuItem.Visible = True
            Else
                MakePaymentToolStripMenuItem.Visible = False
            End If
            If cbStatus.SelectedIndex = 3 Then
                EditInvoiceToolStripMenuItem.Visible = True
            Else
                EditInvoiceToolStripMenuItem.Visible = False
            End If
            dgvInvoice.CurrentCell = dgvInvoice.Rows(e.RowIndex).Cells(e.ColumnIndex)
            cmsInvoice.Show(dgvInvoice, dgvInvoice.PointToClient(Windows.Forms.Cursor.Position))
        End If
    End Sub

    Private Sub MakePaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakePaymentToolStripMenuItem.Click
        Dim dialog As New dlgMakePayment
        dialog.setup(dgvInvoice.CurrentRow)
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmInvoices_Load(Me, New EventArgs)
        End If
    End Sub
End Class