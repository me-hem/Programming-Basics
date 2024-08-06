Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label1.ForeColor = FontDialog1.Color
            Label1.Font = FontDialog1.Font
        End If
    End Sub
End Class
