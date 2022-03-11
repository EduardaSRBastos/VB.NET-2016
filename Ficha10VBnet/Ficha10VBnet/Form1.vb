Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length > 1 Then
            MsgBox(TextBox1.Text.Length & " carateres")
        Else
            MsgBox(TextBox1.Text.Length & " carater")
        End If

    End Sub
End Class
