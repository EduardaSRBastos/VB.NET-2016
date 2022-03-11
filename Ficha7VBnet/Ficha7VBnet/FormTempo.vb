Public Class FormTempo
    Dim a, b, c As String
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub rtbDiasSemana_CheckedChanged(sender As Object, e As EventArgs) Handles rtbDiasSemana.CheckedChanged
        lstResultados.Items.Clear()
        lstResultados.Items.Add("Segunda")
        lstResultados.Items.Add("Terça")
        lstResultados.Items.Add("Quarta")
        lstResultados.Items.Add("Quinta")
        lstResultados.Items.Add("Sexta")
        lstResultados.Items.Add("Sábado")
        lstResultados.Items.Add("Domingo")
    End Sub

    Private Sub rtbMeses_CheckedChanged(sender As Object, e As EventArgs) Handles rtbMeses.CheckedChanged
        lstResultados.Items.Clear()
        lstResultados.Items.Add("Janeiro")
        lstResultados.Items.Add("Fevereiro")
        lstResultados.Items.Add("Março")
        lstResultados.Items.Add("Abril")
        lstResultados.Items.Add("Maio")
        lstResultados.Items.Add("Junho")
        lstResultados.Items.Add("Julho")
        lstResultados.Items.Add("Agosto")
        lstResultados.Items.Add("Setembro")
        lstResultados.Items.Add("Outubro")
        lstResultados.Items.Add("Novembro")
        lstResultados.Items.Add("Dezembro")

    End Sub

    Private Sub rtbEstacoes_CheckedChanged(sender As Object, e As EventArgs) Handles rtbEstacoes.CheckedChanged
        lstResultados.Items.Clear()
        lstResultados.Items.Add("Primavera")
        lstResultados.Items.Add("Verão")
        lstResultados.Items.Add("Outono")
        lstResultados.Items.Add("Inverno")
    End Sub

End Class