<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminEditUser
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
        Me.GroupBoxUserLogin = New System.Windows.Forms.GroupBox()
        Me.btnSaveUser = New System.Windows.Forms.Button()
        Me.btnSetPassword = New System.Windows.Forms.Button()
        Me.textEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBoxUserLogin.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBoxUserLogin.Location = New System.Drawing.Point(5, 3)
        Me.GroupBoxUserLogin.Name = "GroupBoxUserLogin"
        Me.GroupBoxUserLogin.Size = New System.Drawing.Size(445, 134)
        Me.GroupBoxUserLogin.TabIndex = 2
        Me.GroupBoxUserLogin.TabStop = False
        Me.GroupBoxUserLogin.Text = "User/Login"
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Location = New System.Drawing.Point(321, 103)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(118, 23)
        Me.btnSaveUser.TabIndex = 6
        Me.btnSaveUser.Text = "Save User Record"
        Me.btnSaveUser.UseVisualStyleBackColor = True
        '
        'btnSetPassword
        '
        Me.btnSetPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetPassword.Location = New System.Drawing.Point(321, 45)
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
        Me.textEmail.Size = New System.Drawing.Size(317, 24)
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
        Me.textPassword.Size = New System.Drawing.Size(193, 24)
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
        Me.textUsername.Size = New System.Drawing.Size(317, 24)
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
        'frmAdminEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 142)
        Me.Controls.Add(Me.GroupBoxUserLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdminEditUser"
        Me.Text = "Edit User"
        Me.GroupBoxUserLogin.ResumeLayout(False)
        Me.GroupBoxUserLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxUserLogin As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveUser As System.Windows.Forms.Button
    Friend WithEvents btnSetPassword As System.Windows.Forms.Button
    Friend WithEvents textEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents textPassword As System.Windows.Forms.TextBox
    Friend WithEvents textUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
