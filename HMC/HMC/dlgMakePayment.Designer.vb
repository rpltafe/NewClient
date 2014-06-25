<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMakePayment
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
        Me.gbInvoice = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPatientName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbInvoiceId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRemaining = New System.Windows.Forms.TextBox()
        Me.gbAmounts = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNewPayment = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tbMethod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbInvoice.SuspendLayout()
        Me.gbAmounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbInvoice
        '
        Me.gbInvoice.Controls.Add(Me.Label2)
        Me.gbInvoice.Controls.Add(Me.tbPatientName)
        Me.gbInvoice.Controls.Add(Me.Label1)
        Me.gbInvoice.Controls.Add(Me.tbInvoiceId)
        Me.gbInvoice.Location = New System.Drawing.Point(12, 12)
        Me.gbInvoice.Name = "gbInvoice"
        Me.gbInvoice.Size = New System.Drawing.Size(176, 80)
        Me.gbInvoice.TabIndex = 3
        Me.gbInvoice.TabStop = False
        Me.gbInvoice.Text = "Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient"
        '
        'tbPatientName
        '
        Me.tbPatientName.Enabled = False
        Me.tbPatientName.Location = New System.Drawing.Point(65, 45)
        Me.tbPatientName.Name = "tbPatientName"
        Me.tbPatientName.Size = New System.Drawing.Size(100, 20)
        Me.tbPatientName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Id"
        '
        'tbInvoiceId
        '
        Me.tbInvoiceId.Enabled = False
        Me.tbInvoiceId.Location = New System.Drawing.Point(65, 19)
        Me.tbInvoiceId.Name = "tbInvoiceId"
        Me.tbInvoiceId.Size = New System.Drawing.Size(100, 20)
        Me.tbInvoiceId.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total"
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Location = New System.Drawing.Point(65, 19)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbTotal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Paid"
        '
        'tbPaid
        '
        Me.tbPaid.Enabled = False
        Me.tbPaid.Location = New System.Drawing.Point(65, 45)
        Me.tbPaid.Name = "tbPaid"
        Me.tbPaid.Size = New System.Drawing.Size(100, 20)
        Me.tbPaid.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Remaining"
        '
        'tbRemaining
        '
        Me.tbRemaining.Enabled = False
        Me.tbRemaining.Location = New System.Drawing.Point(65, 71)
        Me.tbRemaining.Name = "tbRemaining"
        Me.tbRemaining.Size = New System.Drawing.Size(100, 20)
        Me.tbRemaining.TabIndex = 9
        '
        'gbAmounts
        '
        Me.gbAmounts.Controls.Add(Me.tbTotal)
        Me.gbAmounts.Controls.Add(Me.Label5)
        Me.gbAmounts.Controls.Add(Me.Label3)
        Me.gbAmounts.Controls.Add(Me.Label4)
        Me.gbAmounts.Controls.Add(Me.tbRemaining)
        Me.gbAmounts.Controls.Add(Me.tbPaid)
        Me.gbAmounts.Location = New System.Drawing.Point(12, 98)
        Me.gbAmounts.Name = "gbAmounts"
        Me.gbAmounts.Size = New System.Drawing.Size(176, 100)
        Me.gbAmounts.TabIndex = 10
        Me.gbAmounts.TabStop = False
        Me.gbAmounts.Text = "Amounts"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Amount"
        '
        'tbNewPayment
        '
        Me.tbNewPayment.Location = New System.Drawing.Point(77, 204)
        Me.tbNewPayment.Name = "tbNewPayment"
        Me.tbNewPayment.Size = New System.Drawing.Size(100, 20)
        Me.tbNewPayment.TabIndex = 10
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(16, 257)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 12
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(113, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tbMethod
        '
        Me.tbMethod.Location = New System.Drawing.Point(77, 230)
        Me.tbMethod.Name = "tbMethod"
        Me.tbMethod.Size = New System.Drawing.Size(100, 20)
        Me.tbMethod.TabIndex = 14
        Me.tbMethod.Text = "Card"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Method"
        '
        'dlgMakePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(200, 288)
        Me.Controls.Add(Me.tbMethod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.tbNewPayment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbAmounts)
        Me.Controls.Add(Me.gbInvoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgMakePayment"
        Me.Text = "Payment"
        Me.gbInvoice.ResumeLayout(False)
        Me.gbInvoice.PerformLayout()
        Me.gbAmounts.ResumeLayout(False)
        Me.gbAmounts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbInvoiceId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbRemaining As System.Windows.Forms.TextBox
    Friend WithEvents gbAmounts As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbNewPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tbMethod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
