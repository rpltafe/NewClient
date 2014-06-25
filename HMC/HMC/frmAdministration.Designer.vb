<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministration
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
        Me.tabControlAdministration = New System.Windows.Forms.TabControl()
        Me.tabStaff = New System.Windows.Forms.TabPage()
        Me.splitStaff = New System.Windows.Forms.SplitContainer()
        Me.btnDeleteStaff = New System.Windows.Forms.Button()
        Me.btnEditStaff = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.dataGridStaff = New System.Windows.Forms.DataGridView()
        Me.tabUsers = New System.Windows.Forms.TabPage()
        Me.splitUsers = New System.Windows.Forms.SplitContainer()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnRefreshUsers = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.dataGridUsers = New System.Windows.Forms.DataGridView()
        Me.password_hash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabRostering = New System.Windows.Forms.TabPage()
        Me.splitRostering = New System.Windows.Forms.SplitContainer()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.btnUploadRoster = New System.Windows.Forms.Button()
        Me.dateAvailability = New System.Windows.Forms.DateTimePicker()
        Me.btnRefreshRoster = New System.Windows.Forms.Button()
        Me.dataGridRoster = New System.Windows.Forms.DataGridView()
        Me.Timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabShifts = New System.Windows.Forms.TabPage()
        Me.splitShifts = New System.Windows.Forms.SplitContainer()
        Me.btnRefreshShifts = New System.Windows.Forms.Button()
        Me.dataGridShifts = New System.Windows.Forms.DataGridView()
        Me.tabControlAdministration.SuspendLayout()
        Me.tabStaff.SuspendLayout()
        CType(Me.splitStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitStaff.Panel1.SuspendLayout()
        Me.splitStaff.Panel2.SuspendLayout()
        Me.splitStaff.SuspendLayout()
        CType(Me.dataGridStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUsers.SuspendLayout()
        CType(Me.splitUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitUsers.Panel1.SuspendLayout()
        Me.splitUsers.Panel2.SuspendLayout()
        Me.splitUsers.SuspendLayout()
        CType(Me.dataGridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRostering.SuspendLayout()
        CType(Me.splitRostering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitRostering.Panel1.SuspendLayout()
        Me.splitRostering.Panel2.SuspendLayout()
        Me.splitRostering.SuspendLayout()
        CType(Me.dataGridRoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabShifts.SuspendLayout()
        CType(Me.splitShifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitShifts.Panel1.SuspendLayout()
        Me.splitShifts.Panel2.SuspendLayout()
        Me.splitShifts.SuspendLayout()
        CType(Me.dataGridShifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControlAdministration
        '
        Me.tabControlAdministration.Controls.Add(Me.tabStaff)
        Me.tabControlAdministration.Controls.Add(Me.tabUsers)
        Me.tabControlAdministration.Controls.Add(Me.tabRostering)
        Me.tabControlAdministration.Controls.Add(Me.tabShifts)
        Me.tabControlAdministration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlAdministration.Location = New System.Drawing.Point(0, 0)
        Me.tabControlAdministration.Name = "tabControlAdministration"
        Me.tabControlAdministration.SelectedIndex = 0
        Me.tabControlAdministration.Size = New System.Drawing.Size(788, 486)
        Me.tabControlAdministration.TabIndex = 0
        '
        'tabStaff
        '
        Me.tabStaff.Controls.Add(Me.splitStaff)
        Me.tabStaff.Location = New System.Drawing.Point(4, 22)
        Me.tabStaff.Name = "tabStaff"
        Me.tabStaff.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStaff.Size = New System.Drawing.Size(780, 460)
        Me.tabStaff.TabIndex = 0
        Me.tabStaff.Text = "Staff"
        Me.tabStaff.UseVisualStyleBackColor = True
        '
        'splitStaff
        '
        Me.splitStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitStaff.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitStaff.IsSplitterFixed = True
        Me.splitStaff.Location = New System.Drawing.Point(3, 3)
        Me.splitStaff.Name = "splitStaff"
        Me.splitStaff.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitStaff.Panel1
        '
        Me.splitStaff.Panel1.Controls.Add(Me.btnDeleteStaff)
        Me.splitStaff.Panel1.Controls.Add(Me.btnEditStaff)
        Me.splitStaff.Panel1.Controls.Add(Me.btnRefresh)
        Me.splitStaff.Panel1.Controls.Add(Me.btnAddStaff)
        '
        'splitStaff.Panel2
        '
        Me.splitStaff.Panel2.Controls.Add(Me.dataGridStaff)
        Me.splitStaff.Size = New System.Drawing.Size(774, 454)
        Me.splitStaff.SplitterDistance = 30
        Me.splitStaff.TabIndex = 0
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.Location = New System.Drawing.Point(207, 3)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(92, 23)
        Me.btnDeleteStaff.TabIndex = 3
        Me.btnDeleteStaff.Text = "Delete Selected"
        Me.btnDeleteStaff.UseVisualStyleBackColor = True
        '
        'btnEditStaff
        '
        Me.btnEditStaff.Location = New System.Drawing.Point(115, 3)
        Me.btnEditStaff.Name = "btnEditStaff"
        Me.btnEditStaff.Size = New System.Drawing.Size(86, 23)
        Me.btnEditStaff.TabIndex = 2
        Me.btnEditStaff.Text = "Edit Selected"
        Me.btnEditStaff.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(696, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Location = New System.Drawing.Point(5, 3)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(104, 23)
        Me.btnAddStaff.TabIndex = 0
        Me.btnAddStaff.Text = "Add Staff Record"
        Me.btnAddStaff.UseVisualStyleBackColor = True
        '
        'dataGridStaff
        '
        Me.dataGridStaff.AllowUserToAddRows = False
        Me.dataGridStaff.AllowUserToDeleteRows = False
        Me.dataGridStaff.AllowUserToOrderColumns = True
        Me.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridStaff.Location = New System.Drawing.Point(0, 0)
        Me.dataGridStaff.MultiSelect = False
        Me.dataGridStaff.Name = "dataGridStaff"
        Me.dataGridStaff.ReadOnly = True
        Me.dataGridStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridStaff.Size = New System.Drawing.Size(774, 420)
        Me.dataGridStaff.TabIndex = 0
        '
        'tabUsers
        '
        Me.tabUsers.Controls.Add(Me.splitUsers)
        Me.tabUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUsers.Size = New System.Drawing.Size(780, 460)
        Me.tabUsers.TabIndex = 1
        Me.tabUsers.Text = "Users"
        Me.tabUsers.UseVisualStyleBackColor = True
        '
        'splitUsers
        '
        Me.splitUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitUsers.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitUsers.IsSplitterFixed = True
        Me.splitUsers.Location = New System.Drawing.Point(3, 3)
        Me.splitUsers.Name = "splitUsers"
        Me.splitUsers.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitUsers.Panel1
        '
        Me.splitUsers.Panel1.Controls.Add(Me.btnDeleteUser)
        Me.splitUsers.Panel1.Controls.Add(Me.btnEditUser)
        Me.splitUsers.Panel1.Controls.Add(Me.btnRefreshUsers)
        Me.splitUsers.Panel1.Controls.Add(Me.btnAddUser)
        '
        'splitUsers.Panel2
        '
        Me.splitUsers.Panel2.Controls.Add(Me.dataGridUsers)
        Me.splitUsers.Size = New System.Drawing.Size(774, 454)
        Me.splitUsers.SplitterDistance = 30
        Me.splitUsers.TabIndex = 1
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(207, 3)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(92, 23)
        Me.btnDeleteUser.TabIndex = 3
        Me.btnDeleteUser.Text = "Delete Selected"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnEditUser
        '
        Me.btnEditUser.Location = New System.Drawing.Point(115, 3)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(86, 23)
        Me.btnEditUser.TabIndex = 2
        Me.btnEditUser.Text = "Edit Selected"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnRefreshUsers
        '
        Me.btnRefreshUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshUsers.Location = New System.Drawing.Point(696, 3)
        Me.btnRefreshUsers.Name = "btnRefreshUsers"
        Me.btnRefreshUsers.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshUsers.TabIndex = 1
        Me.btnRefreshUsers.Text = "Refresh"
        Me.btnRefreshUsers.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(5, 3)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(104, 23)
        Me.btnAddUser.TabIndex = 0
        Me.btnAddUser.Text = "Add User Record"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'dataGridUsers
        '
        Me.dataGridUsers.AllowUserToAddRows = False
        Me.dataGridUsers.AllowUserToDeleteRows = False
        Me.dataGridUsers.AllowUserToOrderColumns = True
        Me.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.password_hash})
        Me.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridUsers.Location = New System.Drawing.Point(0, 0)
        Me.dataGridUsers.MultiSelect = False
        Me.dataGridUsers.Name = "dataGridUsers"
        Me.dataGridUsers.ReadOnly = True
        Me.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridUsers.Size = New System.Drawing.Size(774, 420)
        Me.dataGridUsers.TabIndex = 0
        '
        'password_hash
        '
        Me.password_hash.DataPropertyName = "password_hash"
        Me.password_hash.HeaderText = "password_hash"
        Me.password_hash.Name = "password_hash"
        Me.password_hash.ReadOnly = True
        Me.password_hash.Visible = False
        '
        'tabRostering
        '
        Me.tabRostering.Controls.Add(Me.splitRostering)
        Me.tabRostering.Location = New System.Drawing.Point(4, 22)
        Me.tabRostering.Name = "tabRostering"
        Me.tabRostering.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRostering.Size = New System.Drawing.Size(780, 460)
        Me.tabRostering.TabIndex = 2
        Me.tabRostering.Text = "Rostering"
        Me.tabRostering.UseVisualStyleBackColor = True
        '
        'splitRostering
        '
        Me.splitRostering.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitRostering.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitRostering.IsSplitterFixed = True
        Me.splitRostering.Location = New System.Drawing.Point(3, 3)
        Me.splitRostering.Name = "splitRostering"
        Me.splitRostering.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitRostering.Panel1
        '
        Me.splitRostering.Panel1.Controls.Add(Me.lblAvailability)
        Me.splitRostering.Panel1.Controls.Add(Me.btnUploadRoster)
        Me.splitRostering.Panel1.Controls.Add(Me.dateAvailability)
        Me.splitRostering.Panel1.Controls.Add(Me.btnRefreshRoster)
        '
        'splitRostering.Panel2
        '
        Me.splitRostering.Panel2.Controls.Add(Me.dataGridRoster)
        Me.splitRostering.Size = New System.Drawing.Size(774, 454)
        Me.splitRostering.SplitterDistance = 30
        Me.splitRostering.TabIndex = 1
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(5, 5)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(141, 18)
        Me.lblAvailability.TabIndex = 4
        Me.lblAvailability.Text = "Show availability for:"
        '
        'btnUploadRoster
        '
        Me.btnUploadRoster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUploadRoster.Location = New System.Drawing.Point(589, 3)
        Me.btnUploadRoster.Name = "btnUploadRoster"
        Me.btnUploadRoster.Size = New System.Drawing.Size(101, 23)
        Me.btnUploadRoster.TabIndex = 3
        Me.btnUploadRoster.Text = "Upload Roster"
        Me.btnUploadRoster.UseVisualStyleBackColor = True
        '
        'dateAvailability
        '
        Me.dateAvailability.Location = New System.Drawing.Point(146, 5)
        Me.dateAvailability.Name = "dateAvailability"
        Me.dateAvailability.Size = New System.Drawing.Size(176, 20)
        Me.dateAvailability.TabIndex = 2
        '
        'btnRefreshRoster
        '
        Me.btnRefreshRoster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshRoster.Location = New System.Drawing.Point(696, 3)
        Me.btnRefreshRoster.Name = "btnRefreshRoster"
        Me.btnRefreshRoster.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshRoster.TabIndex = 1
        Me.btnRefreshRoster.Text = "Refresh"
        Me.btnRefreshRoster.UseVisualStyleBackColor = True
        '
        'dataGridRoster
        '
        Me.dataGridRoster.AllowUserToAddRows = False
        Me.dataGridRoster.AllowUserToDeleteRows = False
        Me.dataGridRoster.AllowUserToOrderColumns = True
        Me.dataGridRoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridRoster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Timestamp})
        Me.dataGridRoster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridRoster.Location = New System.Drawing.Point(0, 0)
        Me.dataGridRoster.MultiSelect = False
        Me.dataGridRoster.Name = "dataGridRoster"
        Me.dataGridRoster.ReadOnly = True
        Me.dataGridRoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridRoster.Size = New System.Drawing.Size(774, 420)
        Me.dataGridRoster.TabIndex = 0
        '
        'Timestamp
        '
        Me.Timestamp.DataPropertyName = "Timestamp"
        Me.Timestamp.HeaderText = "Timestamp"
        Me.Timestamp.Name = "Timestamp"
        Me.Timestamp.ReadOnly = True
        Me.Timestamp.Visible = False
        '
        'tabShifts
        '
        Me.tabShifts.Controls.Add(Me.splitShifts)
        Me.tabShifts.Location = New System.Drawing.Point(4, 22)
        Me.tabShifts.Name = "tabShifts"
        Me.tabShifts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShifts.Size = New System.Drawing.Size(780, 460)
        Me.tabShifts.TabIndex = 3
        Me.tabShifts.Text = "Shifts Timecard"
        Me.tabShifts.UseVisualStyleBackColor = True
        '
        'splitShifts
        '
        Me.splitShifts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitShifts.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitShifts.IsSplitterFixed = True
        Me.splitShifts.Location = New System.Drawing.Point(3, 3)
        Me.splitShifts.Name = "splitShifts"
        Me.splitShifts.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitShifts.Panel1
        '
        Me.splitShifts.Panel1.Controls.Add(Me.btnRefreshShifts)
        '
        'splitShifts.Panel2
        '
        Me.splitShifts.Panel2.Controls.Add(Me.dataGridShifts)
        Me.splitShifts.Size = New System.Drawing.Size(774, 454)
        Me.splitShifts.SplitterDistance = 30
        Me.splitShifts.TabIndex = 2
        '
        'btnRefreshShifts
        '
        Me.btnRefreshShifts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshShifts.Location = New System.Drawing.Point(696, 3)
        Me.btnRefreshShifts.Name = "btnRefreshShifts"
        Me.btnRefreshShifts.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshShifts.TabIndex = 1
        Me.btnRefreshShifts.Text = "Refresh"
        Me.btnRefreshShifts.UseVisualStyleBackColor = True
        '
        'dataGridShifts
        '
        Me.dataGridShifts.AllowUserToAddRows = False
        Me.dataGridShifts.AllowUserToDeleteRows = False
        Me.dataGridShifts.AllowUserToOrderColumns = True
        Me.dataGridShifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridShifts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridShifts.Location = New System.Drawing.Point(0, 0)
        Me.dataGridShifts.MultiSelect = False
        Me.dataGridShifts.Name = "dataGridShifts"
        Me.dataGridShifts.ReadOnly = True
        Me.dataGridShifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridShifts.Size = New System.Drawing.Size(774, 420)
        Me.dataGridShifts.TabIndex = 0
        '
        'frmAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 486)
        Me.Controls.Add(Me.tabControlAdministration)
        Me.Name = "frmAdministration"
        Me.Text = "Holistic Medical Center Administration"
        Me.tabControlAdministration.ResumeLayout(False)
        Me.tabStaff.ResumeLayout(False)
        Me.splitStaff.Panel1.ResumeLayout(False)
        Me.splitStaff.Panel2.ResumeLayout(False)
        CType(Me.splitStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitStaff.ResumeLayout(False)
        CType(Me.dataGridStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUsers.ResumeLayout(False)
        Me.splitUsers.Panel1.ResumeLayout(False)
        Me.splitUsers.Panel2.ResumeLayout(False)
        CType(Me.splitUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitUsers.ResumeLayout(False)
        CType(Me.dataGridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRostering.ResumeLayout(False)
        Me.splitRostering.Panel1.ResumeLayout(False)
        Me.splitRostering.Panel1.PerformLayout()
        Me.splitRostering.Panel2.ResumeLayout(False)
        CType(Me.splitRostering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitRostering.ResumeLayout(False)
        CType(Me.dataGridRoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabShifts.ResumeLayout(False)
        Me.splitShifts.Panel1.ResumeLayout(False)
        Me.splitShifts.Panel2.ResumeLayout(False)
        CType(Me.splitShifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitShifts.ResumeLayout(False)
        CType(Me.dataGridShifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControlAdministration As System.Windows.Forms.TabControl
    Friend WithEvents tabStaff As System.Windows.Forms.TabPage
    Friend WithEvents tabUsers As System.Windows.Forms.TabPage
    Friend WithEvents splitStaff As System.Windows.Forms.SplitContainer
    Friend WithEvents btnAddStaff As System.Windows.Forms.Button
    Friend WithEvents dataGridStaff As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnEditStaff As System.Windows.Forms.Button
    Friend WithEvents btnDeleteStaff As System.Windows.Forms.Button
    Friend WithEvents splitUsers As System.Windows.Forms.SplitContainer
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents btnRefreshUsers As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents dataGridUsers As System.Windows.Forms.DataGridView
    Friend WithEvents password_hash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabRostering As System.Windows.Forms.TabPage
    Friend WithEvents splitRostering As System.Windows.Forms.SplitContainer
    Friend WithEvents btnUploadRoster As System.Windows.Forms.Button
    Friend WithEvents dateAvailability As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRefreshRoster As System.Windows.Forms.Button
    Friend WithEvents dataGridRoster As System.Windows.Forms.DataGridView
    Friend WithEvents lblAvailability As System.Windows.Forms.Label
    Friend WithEvents Timestamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabShifts As System.Windows.Forms.TabPage
    Friend WithEvents splitShifts As System.Windows.Forms.SplitContainer
    Friend WithEvents btnRefreshShifts As System.Windows.Forms.Button
    Friend WithEvents dataGridShifts As System.Windows.Forms.DataGridView
End Class
