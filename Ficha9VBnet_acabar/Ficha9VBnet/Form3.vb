Public Class Form3
    Dim numero As String
    Dim r, i, s As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = TextBox4.TextLength

        For i = 0 To Len(TextBox4.Text) - 1
            If IsNumeric(TextBox4.Text.ElementAt(i)) Then
                r = r + 1
            Else
                s = s + 1
            End If
        Next
        If r >= 1 Then
            TextBox3.Text = r
            espaco()
        Else
            TextBox2.Text = TextBox4.TextLength
            espaco()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Button1.Enabled = True
    End Sub
    Private Function espaco()
        espaco = Trim(TextBox4.Text)
        Return espaco
    End Function

End Class