Public Class Form1
    Dim message, cor As String

    Private Sub CheckPlacaGrafica_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPlacaGrafica.CheckedChanged
        message = message & "Placa Gráfica"
    End Sub
    Private Sub RadioBtnPreto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnPreto.CheckedChanged

        If (CheckPlacaGrafica.Checked = True Or CheckMemoria.Checked = True Or CheckPlacaRede.Checked = True) Then
            BtnAceitar.Enabled = True

            BtnReconfigurar.Enabled = True
        Else
            BtnAceitar.Enabled = False
            BtnReconfigurar.Enabled = False
        End If
        FotoEquipamento.Image = My.Resources.Terminator 3 P5G965A.jpg
        Label1.Text = "Modelo Base - ASUS Terminator 2"
    End Sub
    Private Sub BtnAceitar_Click(sender As Object, e As EventArgs) Handles BtnAceitar.Click
        MsgBox("Modelo Escolhido" & Label1.Text & "- Componentes adicionais" & message & "- Cor Do Modelo:" & cor)
    End Sub
End Class


