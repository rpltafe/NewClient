Imports MySql.Data.MySqlClient

Public Class frmViewTimecard
    Private bindingsource = New BindingSource()
    Private staffId As String

    Public Sub New(staffId As String)
        InitializeComponent()
        Me.staffId = staffId
    End Sub
    Private Sub frmViewTimecard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshShifts()
    End Sub

    Private Sub refreshShifts()
        Dim MySQLConn As MySqlConnection = New MySqlConnection(My.Resources.connectionString)
        Dim cmd As New MySqlCommand("SELECT CONCAT(`staff`.first_name, ' ', `staff`.last_name) As name, shift.start_time, shift.end_time , TIMEDIFF(`end_time`,`start_time`) as Total FROM `shift` INNER JOIN `staff` ON `staff`.`staff_id`=`shift`.`staff_id` WHERE `staff`.`staff_id` = @staffId", MySQLConn)
        cmd.Parameters.AddWithValue("@staffId", Me.staffId)
        Dim da = New MySqlDataAdapter(cmd)
        Dim dt = New DataTable()
        da.Fill(dt)
        bindingsource.DataSource = dt ' here assign the DataTable'

        With Me.dataGridShifts
            .AutoGenerateColumns = True
            .DataSource = bindingsource
        End With
    End Sub
End Class