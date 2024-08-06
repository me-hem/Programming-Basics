Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog.ShowDialog <> Windows Forms.DialogResult.Cancel Then
            PictureBox1.Image.FormFile(OpenDialog.FileName)

        End If
    End Sub
End Class
