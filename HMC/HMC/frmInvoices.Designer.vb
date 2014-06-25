<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.tbInvoiceId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPatientId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmsInvoice = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MakePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsInvoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.tbInvoiceId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbLastName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbFirstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbPatientId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"paid", "unpaid", "medicare"})
        Me.cbStatus.Location = New System.Drawing.Point(386, 19)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(100, 21)
        Me.cbStatus.TabIndex = 15
        '
        'tbInvoiceId
        '
        Me.tbInvoiceId.Location = New System.Drawing.Point(237, 19)
        Me.tbInvoiceId.Name = "tbInvoiceId"
        Me.tbInvoiceId.Size = New System.Drawing.Size(100, 20)
        Me.tbInvoiceId.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Invoice Id"
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(237, 45)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbLastName.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Last Name"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(66, 45)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbFirstName.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "First Name"
        '
        'tbPatientId
        '
        Me.tbPatientId.Location = New System.Drawing.Point(66, 19)
        Me.tbPatientId.Name = "tbPatientId"
        Me.tbPatientId.Size = New System.Drawing.Size(100, 20)
        Me.tbPatientId.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Patient Id"
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToAddRows = False
        Me.dgvInvoice.AllowUserToDeleteRows = False
        Me.dgvInvoice.AllowUserToOrderColumns = True
        Me.dgvInvoice.AllowUserToResizeRows = False
        Me.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Location = New System.Drawing.Point(12, 92)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.Size = New System.Drawing.Size(800, 357)
        Me.dgvInvoice.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(513, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 39)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Use the fields on the left to sort through invoices. Fields " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "marked as pending h" & _
    "ave yet to have a price set." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right click any row to bring up options for that i" & _
    "nvoice"
        '
        'cmsInvoice
        '
        Me.cmsInvoice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakePaymentToolStripMenuItem, Me.EditInvoiceToolStripMenuItem})
        Me.cmsInvoice.Name = "ContextMenuStrip1"
        Me.cmsInvoice.Size = New System.Drawing.Size(154, 70)
        '
        'MakePaymentToolStripMenuItem
        '
        Me.MakePaymentToolStripMenuItem.Name = "MakePaymentToolStripMenuItem"
        Me.MakePaymentToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MakePaymentToolStripMenuItem.Text = "Make payment"
        '
        'EditInvoiceToolStripMenuItem
        '
        Me.EditInvoiceToolStripMenuItem.Name = "EditInvoiceToolStripMenuItem"
        Me.EditInvoiceToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EditInvoiceToolStripMenuItem.Text = "Edit Invoice"
        '
        'frmInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 461)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvInvoice)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmInvoices"
        Me.Text = "Invoices"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsInvoice.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPatientId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbInvoiceId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dgvInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmsInvoice As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MakePaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
