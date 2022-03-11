Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim minutos, horas, segundos As Integer

        horas = TextBox1.Text \ 3600
        minutos = (TextBox1.Text - horas * 3600) \ 60
        segundos = TextBox1.Text - (horas * 3600) - (minutos * 60)
        TextBox2.Text = horas & " :" & minutos & ":" & segundos


    End Sub
End Class