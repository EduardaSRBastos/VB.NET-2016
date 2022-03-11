Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cont, i As Integer

        cont = 0
        For i = 1 To TextBox1.Text
            If TextBox1.Text Mod i = 0 Then
                cont = cont + 1
            End If
        Next
        If cont = 2 Then
            TextBox2.Text = "Número primo"
        Else
            TextBox2.Text = "Número não é primo"
        End If

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox2.Clear()
    End Sub
End Class
