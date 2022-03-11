Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) Then
            TextBox2.Text = TextBox1.Text.Max
        Else
            TextBox2.Text = "Não digitou um número"
        End If

    End Sub
End Class
