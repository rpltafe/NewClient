<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPassword
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pwd1 = New System.Windows.Forms.TextBox()
        Me.pwd2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(363, 118)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(262, 118)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(95, 23)
        Me.btnSet.TabIndex = 1
        Me.btnSet.Text = "Set Password"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'pwd1
        '
        Me.pwd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd1.Location = New System.Drawing.Point(12, 30)
        Me.pwd1.Name = "pwd1"
        Me.pwd1.Size = New System.Drawing.Size(426, 24)
        Me.pwd1.TabIndex = 3
        Me.pwd1.UseSystemPasswordChar = True
        '
        'pwd2
        '
        Me.pwd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd2.Location = New System.Drawing.Point(12, 78)
        Me.pwd2.Name = "pwd2"
        Me.pwd2.Size = New System.Drawing.Size(426, 24)
        Me.pwd2.TabIndex = 5
        Me.pwd2.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Repeat Password"
        '
        'frmSetPassword
        '
        Me.AcceptButton = Me.btnSet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(450, 153)
        Me.Controls.Add(Me.pwd2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pwd1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmSetPassword"
        Me.Text = "Set Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pwd1 As System.Windows.Forms.TextBox
    Friend WithEvents pwd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
