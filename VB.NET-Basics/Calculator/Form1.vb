Public Class Form1

    Dim num1, num2 As Integer
    Dim opr As String
    Private Sub btn_click(sender As Object, e As MouseEventArgs) Handles btndot.MouseClick, btn9.MouseClick, btn8.MouseClick, btn7.MouseClick, btn6.MouseClick, btn5.MouseClick, btn4.MouseClick, btn3.MouseClick, btn2.MouseClick, btn1.MouseClick, btn0.MouseClick
        Dim value As Button = sender
        If (display.Text = "0") Then
            display.Text = value.Text
        ElseIf (value.Text = ".") Then
            If (Not display.Text.Contains(".")) Then
                display.Text = display.Text + value.Text
            End If
        Else
            display.Text = display.Text + value.Text
        End If
    End Sub

    Private Sub backspace_click(sender As Object, e As EventArgs) Handles btnbackspace.Click
        If (display.Text.Length > 0) Then
            display.Text = display.Text.Remove(display.Text.Length - 1, 1)
        End If
        If (display.Text = "") Then
            display.Text = "0"
        End If
    End Sub

    Private Sub clear_click(sender As Object, e As MouseEventArgs) Handles btnce.MouseClick, btnc.MouseClick
        display.Text = "0"
    End Sub

    Private Sub equal_click(sender As Object, e As EventArgs) Handles btnequal.Click
        num2 = display.Text
        Select Case opr
            Case "+"
                display.Text = num1 + num2
            Case "-"
                display.Text = num1 - num2
            Case "*"
                display.Text = num1 * num2
            Case "/"
                display.Text = num1 / num2
        End Select
    End Sub

    Private Sub btnplusminus_Click(sender As Object, e As EventArgs) Handles btnplusminus.Click
        If (display.Text.Contains("-")) Then
            display.Text = display.Text.Remove(0, 1)
        Else
            display.Text = "-" + display.Text
        End If
    End Sub

    Private Sub opr_click(sender As Object, e As MouseEventArgs) Handles btnpro.MouseClick, btnplus.MouseClick, btnminus.MouseClick, btndiv.MouseClick
        Dim value As Button = sender
        num1 = display.Text
        opr = value.Text
        display.Text = ""
    End Sub
End Class
