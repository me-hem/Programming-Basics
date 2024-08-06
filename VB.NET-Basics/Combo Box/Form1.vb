Public Class Form1
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        ComboBox.Items.Add(input.Text)
        input.Text = ""
    End Sub

    Private Sub Sort_Click(sender As Object, e As EventArgs) Handles Sort.Click
        ComboBox.Sorted = True
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        ComboBox.Items.Remove(ComboBox.SelectedItem)
    End Sub

    Private Sub count_Click(sender As Object, e As EventArgs) Handles count.Click
        Label2.Text = "Count: " + CStr(ComboBox.Items.Count)
    End Sub

    Private Sub _exit_Click(sender As Object, e As EventArgs) Handles _exit.Click
        Me.Close()
    End Sub
End Class
