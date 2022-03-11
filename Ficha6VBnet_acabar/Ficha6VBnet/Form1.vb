Public Class Form1
    Dim limite, i As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        IstNumero.Items.Add("IstNumeros")
        If rtbSequencial.Checked = True Then
            IstNumero.Items.Clear()
            IsNumeric(IstNumero.Items)
            Do
                i = i + 1
                IstNumero.Items.Add(i)
            Loop Until i = limite
        End If
        If rtbPares.Checked = True Then
            IstNumero.Items.Clear()
            IsNumeric(IstNumero.Items)
            Do
                If i Mod 2 = 0 Then
                    i = i + 1
                    IstNumero.Items.Add(i)
                End If

            Loop Until i = limite
        End If
    End Sub
    Private Sub txtLimite_TextChanged(sender As Object, e As EventArgs) Handles txtLimite.TextChanged
        If IsNumeric(txtLimite.Text) Then
            limite = txtLimite.Text

        Else
            Label2.Text = "Não digitou um número"
        End If
    End Sub

End Class
