Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1, d2 As Date
        d1 = DateTimePicker1.Value
        d2 = DateTimePicker2.Value

        MessageBox.Show(d2.Subtract(d1).TotalDays)

    End Sub
End Class
