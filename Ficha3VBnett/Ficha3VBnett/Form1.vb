Public Class Form1
    Private Sub btnconfirma_Click(sender As Object, e As EventArgs) Handles btnconfirma.Click
        If CheckBox1.Checked Then
            txtservico1.Text = “Lavagem"
        End If
        If CheckBox2.Checked Then
            txtservico2.Text = “Mudança de Óleo”
        End If
        If CheckBox3.Checked Then
            txtservico3.Text = “Troca de Pneus"
        End If
        If RtbPreton.Checked Then
            txtCor.Text = "Preto"
        ElseIf RtbBranco.Checked
            txtCor.Text = "Vermelho"
        End If

    End Sub
    Private Sub Limpar_Click(sender As Object, e As EventArgs) Handles Limpar.Click
        txtCor.Clear()
        txtservico1.Clear()
        txtservico2.Clear()
        txtservico3.Clear()
    End Sub
End Class
