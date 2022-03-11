Public Class Form1
    Dim resultado As Double
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            Integer.Parse(TextBox1.Text)
        Else
            MsgBox("Não digitou um número inteiro.")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) Then
            Integer.Parse(TextBox2.Text)
        Else
            MsgBox("Não digitou um número inteiro.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resultado = Math.Ceiling(TextBox1.Text / TextBox2.Text)

        MsgBox(resultado)
    End Sub
End Class
