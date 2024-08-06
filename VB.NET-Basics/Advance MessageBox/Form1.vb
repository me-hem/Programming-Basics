Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to save the file?", "save file", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            MessageBox.Show("File Saved")
        Else
            Me.Close()
        End If
    End Sub
End Class
