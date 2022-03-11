Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 15 Then
            Label1.Text = LSet(TextBox1.Text, 5)
            Label2.Text = Mid(TextBox1.Text, 11, 5)
            Label3.Text = Mid(TextBox1.Text, 6, 4)
        Else
            MsgBox("Tem que escrever 15 carateres.")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label4.Text = TextBox1.Text.Length
    End Sub
End Class