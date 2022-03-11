Public Class Form2
    Dim raiz, i As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do
            raiz = Math.Sqrt(TextBox1.Text)
            ListBox1.Items.Add(raiz)
            i = TextBox1.Text - 1
            raiz = i
        Loop Until i = 1
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            Button1.Enabled = True
        Else
            MsgBox("Não digitou um número.")
            Button1.Enabled = False
        End If
    End Sub

End Class