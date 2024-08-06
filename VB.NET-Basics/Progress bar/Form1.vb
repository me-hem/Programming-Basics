Public Class Form1
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim i As Integer
        pr.Minimum = 0
        pr.Maximum = 10000

        For i = 0 To 10000
            If pr.Value > pr.Maximum Then
                pr.Value = pr.Maximum
            End If
            pr.Value = i
        Next
    End Sub
End Class
