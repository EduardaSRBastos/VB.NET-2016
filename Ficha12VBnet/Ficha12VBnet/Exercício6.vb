Public Class Exercício6
    Dim nome As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            nome = RadioButton1.Text
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        ElseIf RadioButton2.Checked = True Then
            nome = RadioButton2.Text
            RadioButton1.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        ElseIf RadioButton3.Checked = True Then
            nome = RadioButton3.Text
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton4.Checked = False
        ElseIf RadioButton4.Checked = True Then
            nome = RadioButton4.Text
            RadioButton1.Checked = False
            RadioButton3.Checked = False
            RadioButton2.Checked = False
        End If
        MsgBox(nome)
    End Sub
End Class