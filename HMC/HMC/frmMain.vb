Imports System.Windows.Forms

Public Class frmMain

#Region "User"
    Private _user As InternalUser

    Public ReadOnly Property User As InternalUser
        Get
            Return _user
        End Get
    End Property
#End Region

#Region "View"
    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CloseAllChildren() Handles CloseAllToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
#End Region

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If dlgLogin.ShowDialog = Windows.Forms.DialogResult.OK Then
            LogIn(dlgLogin.User)
        End If
    End Sub

    Private Sub LogIn(user As InternalUser)
        Me._user = user
        MyDetailsToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = True
    End Sub

    Private Sub LogOut()
        Dim res As Integer = MessageBox.Show("Logging out will close any open windows. This " & vbCrLf & _
                "may result in a loss of data." & vbCrLf & "Would you like to continue?", "Log Out", MessageBoxButtons.YesNo)
        If Not res = vbYes Then
            Return
        End If
        _user = Nothing
        CloseAllChildren()
        MyDetailsToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LogOut()
    End Sub

    Private Sub AppointmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentsToolStripMenuItem.Click
        If User Is Nothing Then
            Return
        End If
        If Application.OpenForms().OfType(Of frmAppointments).Any Then
            frmAppointments.BringToFront()
        Else
            frmAppointments.MdiParent = Me
            frmAppointments.Show()
            AppointmentsToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub InvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicesToolStripMenuItem.Click
        If User Is Nothing Then
            Return
        End If
        If Application.OpenForms().OfType(Of frmInvoices).Any Then
            frmInvoices.BringToFront()
        Else
            frmInvoices.MdiParent = Me
            frmInvoices.Show()
            InvoicesToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub ConsultationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultationToolStripMenuItem.Click
        frmConsultation.BringToFront()
    End Sub
End Class
