Public Class Form1
    Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 1000

        For i = 0 To 1000
            ProgressBar.Value = i
            If ProgressBar.Value > ProgressBar.Maximum Then
                ProgressBar.Value = ProgressBar.Minimum
            End If
        Next
    End Sub
End Class
