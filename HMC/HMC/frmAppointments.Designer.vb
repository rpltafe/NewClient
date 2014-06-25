<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointments))
        Me.dgvAppointment = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPatientId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAppointmentId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.csAppointments = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsiStartConsultation = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.csAppointments.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAppointment
        '
        Me.dgvAppointment.AllowUserToAddRows = False
        Me.dgvAppointment.AllowUserToDeleteRows = False
        Me.dgvAppointment.AllowUserToOrderColumns = True
        Me.dgvAppointment.AllowUserToResizeRows = False
        Me.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointment.Location = New System.Drawing.Point(12, 92)
        Me.dgvAppointment.Name = "dgvAppointment"
        Me.dgvAppointment.Size = New System.Drawing.Size(800, 357)
        Me.dgvAppointment.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Id"
        '
        'tbPatientId
        '
        Me.tbPatientId.Location = New System.Drawing.Point(66, 19)
        Me.tbPatientId.Name = "tbPatientId"
        Me.tbPatientId.Size = New System.Drawing.Size(100, 20)
        Me.tbPatientId.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbLastName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbAppointmentId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbFirstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbPatientId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 74)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort"
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(261, 45)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbLastName.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Last Name"
        '
        'tbAppointmentId
        '
        Me.tbAppointmentId.Location = New System.Drawing.Point(261, 19)
        Me.tbAppointmentId.Name = "tbAppointmentId"
        Me.tbAppointmentId.Size = New System.Drawing.Size(100, 20)
        Me.tbAppointmentId.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Appointment Id"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(66, 45)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbFirstName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(402, 52)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'csAppointments
        '
        Me.csAppointments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiStartConsultation, Me.CancelAppointmentToolStripMenuItem})
        Me.csAppointments.Name = "csAppointments"
        Me.csAppointments.Size = New System.Drawing.Size(185, 70)
        '
        'tsiStartConsultation
        '
        Me.tsiStartConsultation.Name = "tsiStartConsultation"
        Me.tsiStartConsultation.Size = New System.Drawing.Size(184, 22)
        Me.tsiStartConsultation.Text = "Start Consultation"
        '
        'CancelAppointmentToolStripMenuItem
        '
        Me.CancelAppointmentToolStripMenuItem.Name = "CancelAppointmentToolStripMenuItem"
        Me.CancelAppointmentToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CancelAppointmentToolStripMenuItem.Text = "Cancel Appointment"
        '
        'frmAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 461)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvAppointment)
        Me.Name = "frmAppointments"
        Me.Text = "Appointments"
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.csAppointments.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAppointment As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPatientId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbAppointmentId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents csAppointments As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsiStartConsultation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelAppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
