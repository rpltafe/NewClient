<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTimecard
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
        Me.splitShifts = New System.Windows.Forms.SplitContainer()
        Me.btnRefreshShifts = New System.Windows.Forms.Button()
        Me.dataGridShifts = New System.Windows.Forms.DataGridView()
        CType(Me.splitShifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitShifts.Panel1.SuspendLayout()
        Me.splitShifts.Panel2.SuspendLayout()
        Me.splitShifts.SuspendLayout()
        CType(Me.dataGridShifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitShifts
        '
        Me.splitShifts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitShifts.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitShifts.IsSplitterFixed = True
        Me.splitShifts.Location = New System.Drawing.Point(0, 0)
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
        Me.splitShifts.Size = New System.Drawing.Size(826, 537)
        Me.splitShifts.SplitterDistance = 30
        Me.splitShifts.TabIndex = 3
        '
        'btnRefreshShifts
        '
        Me.btnRefreshShifts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshShifts.Location = New System.Drawing.Point(748, 3)
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
        Me.dataGridShifts.Size = New System.Drawing.Size(826, 503)
        Me.dataGridShifts.TabIndex = 0
        '
        'frmViewTimecard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 537)
        Me.Controls.Add(Me.splitShifts)
        Me.Name = "frmViewTimecard"
        Me.Text = "frmViewTimecard"
        Me.splitShifts.Panel1.ResumeLayout(False)
        Me.splitShifts.Panel2.ResumeLayout(False)
        CType(Me.splitShifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitShifts.ResumeLayout(False)
        CType(Me.dataGridShifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitShifts As System.Windows.Forms.SplitContainer
    Friend WithEvents btnRefreshShifts As System.Windows.Forms.Button
    Friend WithEvents dataGridShifts As System.Windows.Forms.DataGridView
End Class
