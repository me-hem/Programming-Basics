Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 1 To 31
            day.Items.Add(i)
        Next
        For i = 1990 To 2021
            year.Items.Add(i)
        Next

    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        MessageBox.Show("Today's date is " + day.Text + " " + month.Text + " " + year.Text)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class
