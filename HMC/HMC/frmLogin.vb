Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private MySQL As MySqlConnection = New MySqlConnection(My.Resources.connectionString)
    Private _username As String
    Private _staffID
    Private _admin As Boolean
    Private _isCancel As Boolean = False
    Private bs As BiometricScanner.BiometricScanner

    Public Sub New(bs As BiometricScanner.BiometricScanner)
        InitializeComponent()
        Me.bs = bs
    End Sub
    ReadOnly Property getUsername As String
        Get
            Return _username
        End Get
    End Property


    ReadOnly Property isAdmin As Boolean
        Get
            Return _admin
        End Get
    End Property

    ReadOnly Property getStaffID As String
        Get
            Return Me._staffID
        End Get
    End Property

    ReadOnly Property isCancel As Boolean
        Get
            Return Me._isCancel
        End Get
    End Property


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim loginQuery = New MySqlCommand("SELECT CONCAT(`staff`.first_name, ' ', `staff`.last_name) as name, `staff`.`admin`, `staff`.`staff_id` FROM `user` INNER JOIN staff ON staff.user_id=user.user_id WHERE `user`.`username` = @username AND `user`.`password_hash` = MD5(@password)", MySQL)
        loginQuery.Parameters.AddWithValue("@password", PasswordTextBox.Text)
        loginQuery.Parameters.AddWithValue("@username", UsernameTextBox.Text)
        MySQL.Open()
        Dim loginResults As MySqlDataReader = loginQuery.ExecuteReader()
        If loginResults.HasRows Then
            loginResults.Read()
            Me._username = String.Format("{0} ({1})", UsernameTextBox.Text, loginResults.GetString("name"))
            Me._staffID = loginResults.GetString("staff_id")
            Me._admin = (loginResults.GetBoolean("admin"))
            Me.Close()
        Else
            MessageBox.Show("Incorrect Login information! Check username and password or contact administration", "Access Denied")
        End If
        MySQL.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me._isCancel = True
        Me.Close()
    End Sub

    Private Sub LoginWithAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginWithAdminToolStripMenuItem.Click
        Me._username = "Administrator"
        Me._admin = True
        Me._staffID = "1"
        Me.Close()
    End Sub

    Private Sub LoginWithoutAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginWithoutAdminToolStripMenuItem.Click
        Me._username = "Staff Member"
        Me._admin = False
        Me._staffID = "1"
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bs.loginWithFingerprint(Me._username, Me._admin, Me._staffID) Then
            Me.Close()
        End If
    End Sub

End Class
