Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, r As Integer
        Dim s As String

        For i = 0 To TextBox1.Text.Length - 1
            If IsNumeric(TextBox1.Text.ElementAt(i)) Then

                s = Replace(TextBox1.Text, IsNumeric(TextBox1.Text.ElementAt(i)), "*")
                r = 1
            End If
        Next
        If r = 1 Then
            MsgBox(s)
        Else
            MsgBox("Não contém algarismos.")
        End If
    End Sub
End Class