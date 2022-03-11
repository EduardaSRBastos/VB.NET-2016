Public Class Form1
    Dim message, cor As String

    Private Sub CheckPlacaGrafica_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPlacaGrafica.CheckedChanged
        Dim i As Integer
        i = i + 1
        If i = 1 Then
            message = message & "Placa Gráfica -"
        End If

    End Sub
    Private Sub CheckMemoria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMemoria.CheckedChanged
        Dim i As Integer

        i = i + 1
        If i = 1 Then
            message = message & " Mais 1 Gb Memória -"
        End If
    End Sub
    Private Sub CheckPlacaRede_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPlacaRede.CheckedChanged
        Dim i As Integer

        i = i + 1
        If i = 1 Then
            message = message & " Placa de Rede -"
        End If
    End Sub

    Private Sub RadioBtnPreto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnPreto.CheckedChanged

        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacaRede.Checked = True) Then
            BtnAceitar.Enabled = True

            BtnReconfigurar.Enabled = True
        Else
            BtnAceitar.Enabled = False
            BtnReconfigurar.Enabled = False
        End If
        FotoEquipamento.Image = My.Resources.T2
        Label1.Text = "Modelo Base - ASUS Terminator 2"
        cor = "Preto"
    End Sub
    Private Sub RadioBtnCinzento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnCinzento.CheckedChanged

        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacaRede.Checked = True) Then
            BtnAceitar.Enabled = True

            BtnReconfigurar.Enabled = True
        Else
            BtnAceitar.Enabled = False
            BtnReconfigurar.Enabled = False
        End If
        FotoEquipamento.Image = My.Resources.T3
        Label1.Text = "Modelo Base - ASUS Terminator 3"
        cor = "Cinzento"
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub

    Private Sub BtnReconfigurar_Click(sender As Object, e As EventArgs) Handles BtnReconfigurar.Click
        CheckPlacaGrafica.Checked = False
        CheckMemoria.Checked = False
        CheckPlacaRede.Checked = False
        FotoEquipamento.Image = My.Resources.T2
        Label1.Text = "Modelo Base - ASUS Terminator 2"
        RadioBtnCinzento.Checked = False
        RadioBtnPreto.Checked = False

    End Sub
    Private Sub BtnAceitar_Click(sender As Object, e As EventArgs) Handles BtnAceitar.Click
        MsgBox("Modelo Escolhido: " & Label1.Text & "- Componentes adicionais: " & message & " Cor Do Modelo: " & cor)

    End Sub
End Class
