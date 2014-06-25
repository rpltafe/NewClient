<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInvoice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPatientId = New System.Windows.Forms.TextBox()
        Me.gbPatient = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPatientName = New System.Windows.Forms.TextBox()
        Me.gbPayment = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCoPay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMedicare = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbPatient.SuspendLayout()
        Me.gbPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Id"
        '
        'tbPatientId
        '
        Me.tbPatientId.Enabled = False
        Me.tbPatientId.Location = New System.Drawing.Point(65, 19)
        Me.tbPatientId.Name = "tbPatientId"
        Me.tbPatientId.Size = New System.Drawing.Size(100, 20)
        Me.tbPatientId.TabIndex = 1
        '
        'gbPatient
        '
        Me.gbPatient.Controls.Add(Me.Label2)
        Me.gbPatient.Controls.Add(Me.tbPatientName)
        Me.gbPatient.Controls.Add(Me.Label1)
        Me.gbPatient.Controls.Add(Me.tbPatientId)
        Me.gbPatient.Location = New System.Drawing.Point(12, 12)
        Me.gbPatient.Name = "gbPatient"
        Me.gbPatient.Size = New System.Drawing.Size(178, 76)
        Me.gbPatient.TabIndex = 2
        Me.gbPatient.TabStop = False
        Me.gbPatient.Text = "Patient Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'tbPatientName
        '
        Me.tbPatientName.Enabled = False
        Me.tbPatientName.Location = New System.Drawing.Point(65, 45)
        Me.tbPatientName.Name = "tbPatientName"
        Me.tbPatientName.Size = New System.Drawing.Size(100, 20)
        Me.tbPatientName.TabIndex = 3
        '
        'gbPayment
        '
        Me.gbPayment.Controls.Add(Me.Label5)
        Me.gbPayment.Controls.Add(Me.tbCoPay)
        Me.gbPayment.Controls.Add(Me.Label3)
        Me.gbPayment.Controls.Add(Me.tbMedicare)
        Me.gbPayment.Location = New System.Drawing.Point(12, 94)
        Me.gbPayment.Name = "gbPayment"
        Me.gbPayment.Size = New System.Drawing.Size(178, 75)
        Me.gbPayment.TabIndex = 4
        Me.gbPayment.TabStop = False
        Me.gbPayment.Text = "Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Co-Pay"
        '
        'tbCoPay
        '
        Me.tbCoPay.Location = New System.Drawing.Point(65, 45)
        Me.tbCoPay.Name = "tbCoPay"
        Me.tbCoPay.Size = New System.Drawing.Size(100, 20)
        Me.tbCoPay.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medicare"
        '
        'tbMedicare
        '
        Me.tbMedicare.Location = New System.Drawing.Point(65, 19)
        Me.tbMedicare.Name = "tbMedicare"
        Me.tbMedicare.Size = New System.Drawing.Size(100, 20)
        Me.tbMedicare.TabIndex = 3
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 175)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(115, 175)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dlgInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(203, 206)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.gbPayment)
        Me.Controls.Add(Me.gbPatient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Invoice"
        Me.gbPatient.ResumeLayout(False)
        Me.gbPatient.PerformLayout()
        Me.gbPayment.ResumeLayout(False)
        Me.gbPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPatientId As System.Windows.Forms.TextBox
    Friend WithEvents gbPatient As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPatientName As System.Windows.Forms.TextBox
    Friend WithEvents gbPayment As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbCoPay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbMedicare As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
