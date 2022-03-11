Public Class Form4

    Private Sub validar()
        If IsNumeric(primeiro.Text & Segundo.Text) Then
            divide12.Enabled = True
            Divide21.Enabled = True
            Diferença.Enabled = True
        Else
            Resultado.Text = "Não digitou um número"
            divide12.Enabled = False
            Divide21.Enabled = False
            Diferença.Enabled = False
        End If
    End Sub

    Private Sub primeiro_TextChanged(sender As Object, e As EventArgs) Handles primeiro.TextChanged
        validar()
    End Sub

    Private Sub Segundo_TextChanged(sender As Object, e As EventArgs) Handles Segundo.TextChanged
        validar()
    End Sub

    Private Sub divide12_Click(sender As Object, e As EventArgs) Handles divide12.Click
        Resultado.Text = primeiro.Text / Segundo.Text
        validar()

    End Sub

    Private Sub Divide21_Click(sender As Object, e As EventArgs) Handles Divide21.Click
        If IsNumeric(primeiro.Text & Segundo.Text) Then
            Resultado.Text = Segundo.Text / primeiro.Text
            validar()
        Else
            Resultado.Text = "Não digitou um número"
        End If
    End Sub
    Private Sub Diferença_Click(sender As Object, e As EventArgs) Handles Diferença.Click
        If IsNumeric(primeiro.Text & Segundo.Text) Then
            Resultado.Text = Convert.ToDecimal(primeiro.Text / Segundo.Text) - Convert.ToDecimal(Segundo.Text / primeiro.Text)
            validar()
        Else
            Resultado.Text = "Não digitou um número"
        End If
    End Sub

    Private Sub Limpar_Click(sender As Object, e As EventArgs) Handles Limpar.Click
        primeiro.Clear()
        Segundo.Clear()
        Resultado.Clear()
    End Sub

End Class