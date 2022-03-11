Public Class Form1
    Dim numero(250), i, j, maior, media, soma As Double

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        maior = -99999
        numero(j) = txtNumero.Text
        For i = 0 To j
            txtNumero.Clear()
            If maior < numero(i) Then
                maior = numero(i)
            End If
        Next
        j = j + 1
    End Sub

    Private Sub btnMaior_Click(sender As Object, e As EventArgs) Handles btnMaior.Click
        TextBox2.Text = maior
    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        For i = 0 To j
            soma = soma + numero(i)
        Next
        TextBox2.Text = soma / j

    End Sub

    Private Sub btnNovosNumeros_Click(sender As Object, e As EventArgs) Handles btnNovosNumeros.Click
        ReDim numero(250)
        TextBox2.Clear()
        soma = 0
        j = 0
    End Sub
End Class
