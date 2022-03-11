Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, r As Integer

        For i = 0 To TextBox1.Text.Length - 1
            If IsNumeric(TextBox1.Text.ElementAt(i)) Then
                r = 1

            End If
        Next
        If r = 1 Then

            MsgBox("Contém algarismos")
        Else
            MsgBox("Não contém algarismos")
        End If


    End Sub
End Class