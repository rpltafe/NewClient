<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminEditStaff
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
        Me.Split = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitFingerprintTab = New System.Windows.Forms.SplitContainer()
        Me.DataGridFingerprints = New System.Windows.Forms.DataGridView()
        Me.btnDeleteFingerprint = New System.Windows.Forms.Button()
        Me.btnAddFingerprint = New System.Windows.Forms.Button()
        Me.GroupBoxUserLogin = New System.Windows.Forms.GroupBox()
        Me.btnSaveUser = New System.Windows.Forms.Button()
        Me.btnSetPassword = New System.Windows.Forms.Button()
        Me.textEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBoxDetails = New System.Windows.Forms.GroupBox()
        Me.chkbxAdmin = New System.Windows.Forms.CheckBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.dateDOB = New System.Windows.Forms.DateTimePicker()
        Me.textPhone = New System.Windows.Forms.TextBox()
        Me.textAddress = New System.Windows.Forms.TextBox()
        Me.textLastName = New System.Windows.Forms.TextBox()
        Me.textFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Split.Panel1.SuspendLayout()
        Me.Split.Panel2.SuspendLayout()
        Me.Split.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitFingerprintTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitFingerprintTab.Panel1.SuspendLayout()
        Me.SplitFingerprintTab.Panel2.SuspendLayout()
        Me.SplitFingerprintTab.SuspendLayout()
        CType(Me.DataGridFingerprints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxUserLogin.SuspendLayout()
        Me.GroupBoxDetails.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Split
        '
        Me.Split.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Split.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.Split.IsSplitterFixed = True
        Me.Split.Location = New System.Drawing.Point(0, 0)
        Me.Split.Name = "Split"
        Me.Split.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Split.Panel1
        '
        Me.Split.Panel1.AutoScroll = True
        Me.Split.Panel1.Controls.Add(Me.GroupBox1)
        Me.Split.Panel1.Controls.Add(Me.GroupBoxUserLogin)
        Me.Split.Panel1.Controls.Add(Me.GroupBoxDetails)
        '
        'Split.Panel2
        '
        Me.Split.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Split.Size = New System.Drawing.Size(455, 644)
        Me.Split.SplitterDistance = 603
        Me.Split.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SplitFingerprintTab)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 387)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(0, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 212)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Biometric Fingerprints"
        '
        'SplitFingerprintTab
        '
        Me.SplitFingerprintTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitFingerprintTab.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitFingerprintTab.IsSplitterFixed = True
        Me.SplitFingerprintTab.Location = New System.Drawing.Point(3, 16)
        Me.SplitFingerprintTab.Name = "SplitFingerprintTab"
        Me.SplitFingerprintTab.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitFingerprintTab.Panel1
        '
        Me.SplitFingerprintTab.Panel1.Controls.Add(Me.DataGridFingerprints)
        '
        'SplitFingerprintTab.Panel2
        '
        Me.SplitFingerprintTab.Panel2.Controls.Add(Me.btnDeleteFingerprint)
        Me.SplitFingerprintTab.Panel2.Controls.Add(Me.btnAddFingerprint)
        Me.SplitFingerprintTab.Size = New System.Drawing.Size(425, 193)
        Me.SplitFingerprintTab.SplitterDistance = 165
        Me.SplitFingerprintTab.SplitterWidth = 3
        Me.SplitFingerprintTab.TabIndex = 0
        '
        'DataGridFingerprints
        '
        Me.DataGridFingerprints.AllowUserToAddRows = False
        Me.DataGridFingerprints.AllowUserToDeleteRows = False
        Me.DataGridFingerprints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFingerprints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFingerprints.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridFingerprints.Location = New System.Drawing.Point(0, 0)
        Me.DataGridFingerprints.Name = "DataGridFingerprints"
        Me.DataGridFingerprints.ReadOnly = True
        Me.DataGridFingerprints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFingerprints.Size = New System.Drawing.Size(425, 165)
        Me.DataGridFingerprints.TabIndex = 0
        '
        'btnDeleteFingerprint
        '
        Me.btnDeleteFingerprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteFingerprint.Location = New System.Drawing.Point(123, 1)
        Me.btnDeleteFingerprint.Name = "btnDeleteFingerprint"
        Me.btnDeleteFingerprint.Size = New System.Drawing.Size(153, 23)
        Me.btnDeleteFingerprint.TabIndex = 0
        Me.btnDeleteFingerprint.Text = "Delete Selected Fingerprint"
        Me.btnDeleteFingerprint.UseVisualStyleBackColor = True
        '
        'btnAddFingerprint
        '
        Me.btnAddFingerprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddFingerprint.Location = New System.Drawing.Point(282, 1)
        Me.btnAddFingerprint.Name = "btnAddFingerprint"
        Me.btnAddFingerprint.Size = New System.Drawing.Size(139, 23)
        Me.btnAddFingerprint.TabIndex = 1
        Me.btnAddFingerprint.Text = "Add New Fingerprint"
        Me.btnAddFingerprint.UseVisualStyleBackColor = True
        '
        'GroupBoxUserLogin
        '
        Me.GroupBoxUserLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxUserLogin.Controls.Add(Me.btnSaveUser)
        Me.GroupBoxUserLogin.Controls.Add(Me.btnSetPassword)
        Me.GroupBoxUserLogin.Controls.Add(Me.textEmail)
        Me.GroupBoxUserLogin.Controls.Add(Me.Label11)
        Me.GroupBoxUserLogin.Controls.Add(Me.textPassword)
        Me.GroupBoxUserLogin.Controls.Add(Me.textUsername)
        Me.GroupBoxUserLogin.Controls.Add(Me.Label9)
        Me.GroupBoxUserLogin.Controls.Add(Me.Label10)
        Me.GroupBoxUserLogin.Location = New System.Drawing.Point(12, 248)
        Me.GroupBoxUserLogin.Name = "GroupBoxUserLogin"
        Me.GroupBoxUserLogin.Size = New System.Drawing.Size(431, 134)
        Me.GroupBoxUserLogin.TabIndex = 1
        Me.GroupBoxUserLogin.TabStop = False
        Me.GroupBoxUserLogin.Text = "User/Login"
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Location = New System.Drawing.Point(307, 103)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(118, 23)
        Me.btnSaveUser.TabIndex = 6
        Me.btnSaveUser.Text = "Save User Record"
        Me.btnSaveUser.UseVisualStyleBackColor = True
        '
        'btnSetPassword
        '
        Me.btnSetPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetPassword.Location = New System.Drawing.Point(307, 45)
        Me.btnSetPassword.Name = "btnSetPassword"
        Me.btnSetPassword.Size = New System.Drawing.Size(118, 23)
        Me.btnSetPassword.TabIndex = 1
        Me.btnSetPassword.Text = "Set New Password"
        Me.btnSetPassword.UseVisualStyleBackColor = True
        '
        'textEmail
        '
        Me.textEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textEmail.Location = New System.Drawing.Point(122, 73)
        Me.textEmail.Name = "textEmail"
        Me.textEmail.Size = New System.Drawing.Size(303, 24)
        Me.textEmail.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Email Address:"
        '
        'textPassword
        '
        Me.textPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.Location = New System.Drawing.Point(122, 44)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.ReadOnly = True
        Me.textPassword.Size = New System.Drawing.Size(179, 24)
        Me.textPassword.TabIndex = 16
        Me.textPassword.UseSystemPasswordChar = True
        '
        'textUsername
        '
        Me.textUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUsername.Location = New System.Drawing.Point(122, 16)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(303, 24)
        Me.textUsername.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Username:"
        '
        'GroupBoxDetails
        '
        Me.GroupBoxDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDetails.Controls.Add(Me.chkbxAdmin)
        Me.GroupBoxDetails.Controls.Add(Me.cbGender)
        Me.GroupBoxDetails.Controls.Add(Me.dateDOB)
        Me.GroupBoxDetails.Controls.Add(Me.textPhone)
        Me.GroupBoxDetails.Controls.Add(Me.textAddress)
        Me.GroupBoxDetails.Controls.Add(Me.textLastName)
        Me.GroupBoxDetails.Controls.Add(Me.textFirstName)
        Me.GroupBoxDetails.Controls.Add(Me.Label7)
        Me.GroupBoxDetails.Controls.Add(Me.Label6)
        Me.GroupBoxDetails.Controls.Add(Me.Label5)
        Me.GroupBoxDetails.Controls.Add(Me.Label4)
        Me.GroupBoxDetails.Controls.Add(Me.Label3)
        Me.GroupBoxDetails.Controls.Add(Me.Label2)
        Me.GroupBoxDetails.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxDetails.Name = "GroupBoxDetails"
        Me.GroupBoxDetails.Size = New System.Drawing.Size(431, 230)
        Me.GroupBoxDetails.TabIndex = 0
        Me.GroupBoxDetails.TabStop = False
        Me.GroupBoxDetails.Text = "Details"
        '
        'chkbxAdmin
        '
        Me.chkbxAdmin.AutoSize = True
        Me.chkbxAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxAdmin.Location = New System.Drawing.Point(83, 194)
        Me.chkbxAdmin.Name = "chkbxAdmin"
        Me.chkbxAdmin.Size = New System.Drawing.Size(287, 22)
        Me.chkbxAdmin.TabIndex = 17
        Me.chkbxAdmin.Text = "Staff Member has Administration Rights"
        Me.chkbxAdmin.UseVisualStyleBackColor = True
        '
        'cbGender
        '
        Me.cbGender.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(121, 74)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(302, 26)
        Me.cbGender.TabIndex = 2
        '
        'dateDOB
        '
        Me.dateDOB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDOB.Location = New System.Drawing.Point(121, 103)
        Me.dateDOB.Name = "dateDOB"
        Me.dateDOB.Size = New System.Drawing.Size(303, 24)
        Me.dateDOB.TabIndex = 3
        '
        'textPhone
        '
        Me.textPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPhone.Location = New System.Drawing.Point(121, 159)
        Me.textPhone.Name = "textPhone"
        Me.textPhone.Size = New System.Drawing.Size(303, 24)
        Me.textPhone.TabIndex = 5
        '
        'textAddress
        '
        Me.textAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textAddress.Location = New System.Drawing.Point(121, 131)
        Me.textAddress.Name = "textAddress"
        Me.textAddress.Size = New System.Drawing.Size(303, 24)
        Me.textAddress.TabIndex = 4
        '
        'textLastName
        '
        Me.textLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLastName.Location = New System.Drawing.Point(121, 47)
        Me.textLastName.Name = "textLastName"
        Me.textLastName.Size = New System.Drawing.Size(303, 24)
        Me.textLastName.TabIndex = 1
        '
        'textFirstName
        '
        Me.textFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textFirstName.Location = New System.Drawing.Point(121, 19)
        Me.textFirstName.Name = "textFirstName"
        Me.textFirstName.Size = New System.Drawing.Size(303, 24)
        Me.textFirstName.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Date of Birth:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10, 3, 5, 10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(455, 37)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(362, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(281, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAdminEditStaff
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(455, 644)
        Me.Controls.Add(Me.Split)
        Me.Name = "frmAdminEditStaff"
        Me.Text = "Edit Staff Member"
        Me.Split.Panel1.ResumeLayout(False)
        Me.Split.Panel2.ResumeLayout(False)
        CType(Me.Split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Split.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitFingerprintTab.Panel1.ResumeLayout(False)
        Me.SplitFingerprintTab.Panel2.ResumeLayout(False)
        CType(Me.SplitFingerprintTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitFingerprintTab.ResumeLayout(False)
        CType(Me.DataGridFingerprints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxUserLogin.ResumeLayout(False)
        Me.GroupBoxUserLogin.PerformLayout()
        Me.GroupBoxDetails.ResumeLayout(False)
        Me.GroupBoxDetails.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Split As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBoxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textPhone As System.Windows.Forms.TextBox
    Friend WithEvents textAddress As System.Windows.Forms.TextBox
    Friend WithEvents textLastName As System.Windows.Forms.TextBox
    Friend WithEvents textFirstName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitFingerprintTab As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridFingerprints As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteFingerprint As System.Windows.Forms.Button
    Friend WithEvents btnAddFingerprint As System.Windows.Forms.Button
    Friend WithEvents GroupBoxUserLogin As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetPassword As System.Windows.Forms.Button
    Friend WithEvents textEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents textPassword As System.Windows.Forms.TextBox
    Friend WithEvents textUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Friend WithEvents dateDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSaveUser As System.Windows.Forms.Button
    Friend WithEvents chkbxAdmin As System.Windows.Forms.CheckBox
End Class
