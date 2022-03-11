Public Class Form3
    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text.Length > 1 Then
            MsgBox("Só pode escrever um carater")
        Else
            Label1.Text = Asc(TextBox1.Text)

        End If
    End Sub
End Class