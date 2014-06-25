Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text

Public Class frmMain

#Region "User"
    Private _user As InternalUser
    Public bs As BiometricScanner.BiometricScanner
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
        bs = New BiometricScanner.BiometricScanner
        performLogin()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        performLogin()
        'If dlgLogin.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    LogIn(dlgLogin.User)
        'End If
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
        AdministrationToolStripMenuItem.Visible = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LogOut()
        performLogin()
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

    Private Sub performLogin()
        Dim login = New frmLogin(bs)
        login.ShowDialog()
        If Not login.isCancel Then
            Try
                Me._user = New InternalUser(login.getStaffID)
                MyDetailsToolStripMenuItem.Visible = True
                LogoutToolStripMenuItem.Visible = True
                AdministrationToolStripMenuItem.Visible = Me._user.isAdmin
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error during login!")
            End Try
        End If
    End Sub

    Private Sub MyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyDetailsToolStripMenuItem.Click
        Dim MySQLConn As MySqlConnection = New MySqlConnection(My.Resources.connectionString)
        Dim token As String = generateToken()
        Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO `token` (`token_id`,`staff_id`, `token`) VALUES (NULL,@staff_id, @token);", MySQLConn)
        cmd.Parameters.AddWithValue("@staff_id", Me._user.StaffId)
        cmd.Parameters.AddWithValue("@token", token)
        MySQLConn.Open()
        cmd.ExecuteNonQuery()
        MySQLConn.Close()

        Dim url As String = String.Format("http://localhost:8080/examples/login.jsp?token={0}&staff={1}", token, Me._user.StaffId)
        Dim pathToChrome As String = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
        If File.Exists(pathToChrome) Then
            Process.Start(pathToChrome, url) 'opens in chrome
        Else
            Process.Start(url) 'opens in default web browser
        End If

    End Sub

    Private Function generateToken() As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Randomize()
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 64
            sb.Append(s.Substring(r.Next(0, s.Length - 1), 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub AdministrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrationToolStripMenuItem.Click
        frmAdministration.bs = Me.bs
        frmAdministration.Show()
    End Sub

    Private Sub ViewShiftsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewShiftsToolStripMenuItem.Click
        Dim shift As frmViewTimecard = New frmViewTimecard(_user.StaffId)

        shift.MdiParent = Me
        shift.Show()
    End Sub
End Class
