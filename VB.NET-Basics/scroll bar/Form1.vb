Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        Me.vb.Minimum = 0
        Me.vb.Maximum = 100
        Me.vb.Value = 0
        Me.vb.BackColor = Color.Blue

        Me.AutoScroll = True
        Me.hb.Minimum = 0
        Me.hb.Maximum = 100
        Me.hb.Value = 0
        Me.hb.BackColor = Color.Blue

    End Sub
End Class
