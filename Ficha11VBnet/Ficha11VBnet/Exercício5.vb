Public Class Exercício5
    Dim i, j, k As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            i = i + 1
            CheckBox3.Checked = False
        End If
        If CheckBox2.Checked = True Then
            j = j + 1
            CheckBox3.Checked = False
        End If
        If CheckBox3.Checked = True Then
            Label1.Text = " Conta Prazo "
        End If
        If CheckBox4.Checked = True Then
            k = k + 1
            CheckBox3.Checked = False
        End If

        If i = 1 And j = 1 And k = 1 Then
            Label1.Text = " Conta Ordem + Cartão Débito + Cartão Crédito"

        ElseIf i = 1 And j = 1 Then
            Label1.Text = " Conta Ordem + Cartão Débito"

        ElseIf j = 1 And k = 1 Then
            Label1.Text = "Cartão Débito + Cartão Crédito"

        ElseIf i = 1 And k = 1 Then
            Label1.Text = " Conta Ordem + Cartão Crédito"

        ElseIf i = 1 Then
            Label1.Text = " Conta Ordem "

        ElseIf j = 1 Then
            Label1.Text = " Cartão Débito "

        ElseIf k = 1 Then
            Label1.Text = " Cartão Crédito "
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = False
    End Sub
End Class