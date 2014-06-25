Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmAdminUploadRoster
    Private MySQLConn As MySqlConnection = New MySqlConnection(My.Resources.connectionString)

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim open As OpenFileDialog = New OpenFileDialog()
        open.Title = "Upload Roster file"
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFilePath.Text = open.FileName
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If (File.Exists(txtFilePath.Text)) Then
            Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO `holistic`.`roster` (`roster_id`, `name`, `startDate`, `file`) VALUES (NULL, @filename, @startDate, @file);", MySQLConn)
            Dim filename As String = Path.GetFileName(txtFilePath.Text)
            Dim filebytes As Byte() = File.ReadAllBytes(txtFilePath.Text)
            cmd.Parameters.AddWithValue("@filename", filename)
            cmd.Parameters.AddWithValue("@startDate", Me.dateStart.Value)
            cmd.Parameters.AddWithValue("@file", filebytes)
            Try
                MySQLConn.Open()
                cmd.ExecuteNonQuery()
                MySQLConn.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Upload Roster Error")
            End Try

        Else
            MessageBox.Show("Cannot find file to upload!")
        End If



    End Sub
End Class