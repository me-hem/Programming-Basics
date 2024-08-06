Public Class Form1
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        ListBox.Items.Add(input.Text)
        input.Text = ""
    End Sub

    Private Sub sort_Click(sender As Object, e As EventArgs) Handles sort.Click
        ListBox.Sorted = True
    End Sub

    Private Sub count_Click(sender As Object, e As EventArgs) Handles count.Click
        Label3.Text = "Count: " + CStr(ListBox.Items.Count)
    End Sub

    Private Sub _exit_Click(sender As Object, e As EventArgs) Handles _exit.Click
        Me.Close()
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        ListBox.Items.Remove(ListBox.SelectedItem)
    End Sub

End Class
