Public Class Form3
    Dim raiz As Double
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            raiz = Math.Sqrt(TextBox1.Text)
            raiz = FormatNumber(raiz, 2)
            MsgBox(raiz)

        Else
            Label2.Text = "Não digitou um número."

        End If

    End Sub
End Class