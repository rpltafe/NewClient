Public Class frmSetPassword
    Private cancel As Boolean = False

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancel = True
        Me.Close()
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        If (pwd1.Text = pwd2.Text) Then
            If (pwd1.TextLength > 5) Then
                Me.Close()
            Else
                MessageBox.Show("Password length is less than 6 characters!", "Set Password Error")
            End If
        Else
            MessageBox.Show("Password do not match!", "Set Password Error")
        End If

    End Sub

    Public Function isCancel() As Boolean
        Return cancel
    End Function

    Public Function password() As String
        Return pwd1.Text
    End Function

End Class