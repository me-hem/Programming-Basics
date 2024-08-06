Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            MessageBox.Show("I Love You " + CheckBox1.Text)
        ElseIf CheckBox2.Checked = True Then
            MessageBox.Show("I Love You " + CheckBox2.Text)
        ElseIf CheckBox3.Checked = True Then
            MessageBox.Show("I Love You " + CheckBox3.Text)
        ElseIf CheckBox4.Checked = True Then
            MessageBox.Show("I Love You " + CheckBox4.Text)
        ElseIf CheckBox5.Checked = True Then
            MessageBox.Show("I Love You " + CheckBox5.Text)
        End If
    End Sub
End Class
