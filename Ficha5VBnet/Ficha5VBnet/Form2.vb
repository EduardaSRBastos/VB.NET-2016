Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            If TextBox1.Text > 0 Then
                Label2.Text = ("Positivo")
            ElseIf TextBox1.Text < 0
                Label2.Text = ("Negativo")
            ElseIf TextBox1.Text = 0
                Label2.Text = ("Nulo")
            End If
        Else
            Label2.Text = ("Não digitou um número")
        End If
    End Sub
End Class