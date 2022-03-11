Public Class Form2
    Dim vet1(7) As String
    Dim vet2(16, 10, 10, 15, 16, 12, 12) As Integer
    Dim i, j As Integer
    Dim min, espaco, esquerda As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vet1(0) = "Seg"
        vet1(1) = "Ter"
        vet1(2) = "Qua"
        vet1(3) = "Qui"
        vet1(4) = "Sex"
        vet1(5) = "Sab"
        vet1(6) = "Dom"

        For i = 0 To 6
            If vet1(i) Then
                TextBox3.Text = TextBox1.Text
            Else

            End If
        Next

    End Sub
    Private Sub tres()
        min = LCase(TextBox1.Text)
        espaco = Trim(TextBox1.Text)
        esquerda = (LSet(TextBox1.Text, 3))
    End Sub
End Class