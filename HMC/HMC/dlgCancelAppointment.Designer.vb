<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCancelAppointment
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbFee = New System.Windows.Forms.GroupBox()
        Me.tbFeeAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbAppointment = New System.Windows.Forms.GroupBox()
        Me.tbDateTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPatientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAppointmentId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblFeeMsg = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbFee.SuspendLayout()
        Me.gbAppointment.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbFee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbAppointment)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDone)
        Me.SplitContainer1.Size = New System.Drawing.Size(223, 233)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 0
        '
        'gbFee
        '
        Me.gbFee.Controls.Add(Me.lblFeeMsg)
        Me.gbFee.Controls.Add(Me.tbFeeAmount)
        Me.gbFee.Controls.Add(Me.Label2)
        Me.gbFee.Location = New System.Drawing.Point(11, 113)
        Me.gbFee.Name = "gbFee"
        Me.gbFee.Size = New System.Drawing.Size(200, 73)
        Me.gbFee.TabIndex = 8
        Me.gbFee.TabStop = False
        Me.gbFee.Text = "Fee"
        '
        'tbFeeAmount
        '
        Me.tbFeeAmount.Enabled = False
        Me.tbFeeAmount.Location = New System.Drawing.Point(92, 45)
        Me.tbFeeAmount.Name = "tbFeeAmount"
        Me.tbFeeAmount.Size = New System.Drawing.Size(100, 20)
        Me.tbFeeAmount.TabIndex = 4
        Me.tbFeeAmount.Text = "10.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fee Amount"
        '
        'gbAppointment
        '
        Me.gbAppointment.Controls.Add(Me.tbDateTime)
        Me.gbAppointment.Controls.Add(Me.Label4)
        Me.gbAppointment.Controls.Add(Me.tbPatientName)
        Me.gbAppointment.Controls.Add(Me.Label3)
        Me.gbAppointment.Controls.Add(Me.tbAppointmentId)
        Me.gbAppointment.Controls.Add(Me.Label1)
        Me.gbAppointment.Location = New System.Drawing.Point(11, 7)
        Me.gbAppointment.Name = "gbAppointment"
        Me.gbAppointment.Size = New System.Drawing.Size(200, 100)
        Me.gbAppointment.TabIndex = 7
        Me.gbAppointment.TabStop = False
        Me.gbAppointment.Text = "Appointment"
        '
        'tbDateTime
        '
        Me.tbDateTime.Enabled = False
        Me.tbDateTime.Location = New System.Drawing.Point(92, 45)
        Me.tbDateTime.Name = "tbDateTime"
        Me.tbDateTime.Size = New System.Drawing.Size(100, 20)
        Me.tbDateTime.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date"
        '
        'tbPatientName
        '
        Me.tbPatientName.Enabled = False
        Me.tbPatientName.Location = New System.Drawing.Point(92, 19)
        Me.tbPatientName.Name = "tbPatientName"
        Me.tbPatientName.Size = New System.Drawing.Size(100, 20)
        Me.tbPatientName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Patient Name"
        '
        'tbAppointmentId
        '
        Me.tbAppointmentId.Enabled = False
        Me.tbAppointmentId.Location = New System.Drawing.Point(92, 71)
        Me.tbAppointmentId.Name = "tbAppointmentId"
        Me.tbAppointmentId.Size = New System.Drawing.Size(100, 20)
        Me.tbAppointmentId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Appointment Id"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(120, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(25, 8)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 9
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblFeeMsg
        '
        Me.lblFeeMsg.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFeeMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFeeMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeeMsg.ForeColor = System.Drawing.Color.Lime
        Me.lblFeeMsg.Location = New System.Drawing.Point(11, 16)
        Me.lblFeeMsg.Name = "lblFeeMsg"
        Me.lblFeeMsg.Size = New System.Drawing.Size(181, 20)
        Me.lblFeeMsg.TabIndex = 10
        Me.lblFeeMsg.Text = "No fee to be applied"
        Me.lblFeeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dlgCancelAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(223, 233)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgCancelAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cancellation"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbFee.ResumeLayout(False)
        Me.gbFee.PerformLayout()
        Me.gbAppointment.ResumeLayout(False)
        Me.gbAppointment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbFee As System.Windows.Forms.GroupBox
    Friend WithEvents tbFeeAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbAppointment As System.Windows.Forms.GroupBox
    Friend WithEvents tbDateTime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbAppointmentId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents lblFeeMsg As System.Windows.Forms.Label
End Class
