<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLogin
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
        Me.scLogin = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.scLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scLogin.Panel1.SuspendLayout()
        Me.scLogin.Panel2.SuspendLayout()
        Me.scLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'scLogin
        '
        Me.scLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scLogin.Location = New System.Drawing.Point(0, 0)
        Me.scLogin.Name = "scLogin"
        Me.scLogin.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scLogin.Panel1
        '
        Me.scLogin.Panel1.Controls.Add(Me.Label2)
        Me.scLogin.Panel1.Controls.Add(Me.tbPassword)
        Me.scLogin.Panel1.Controls.Add(Me.Label1)
        Me.scLogin.Panel1.Controls.Add(Me.tbUsername)
        '
        'scLogin.Panel2
        '
        Me.scLogin.Panel2.Controls.Add(Me.btnLogin)
        Me.scLogin.Panel2.Controls.Add(Me.btnCancel)
        Me.scLogin.Size = New System.Drawing.Size(183, 98)
        Me.scLogin.SplitterDistance = 63
        Me.scLogin.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(73, 35)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(73, 9)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(100, 20)
        Me.tbUsername.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(10, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(97, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dlgLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(183, 98)
        Me.Controls.Add(Me.scLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.scLogin.Panel1.ResumeLayout(False)
        Me.scLogin.Panel1.PerformLayout()
        Me.scLogin.Panel2.ResumeLayout(False)
        CType(Me.scLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents scLogin As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
