Public Class Form2
    Dim ingrediente, massa, queijo As String

    Private Sub validar()

        If ((CheckBox1.Checked) Or (CheckBox2.Checked) Or (CheckBox3.Checked)) And ((RadioButton1.Checked) Or (RadioButton2.Checked)) And ((RadioButton3.Checked) Or (RadioButton4.Checked)) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        validar()
        ingrediente = ingrediente & " Pepperoni,"
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        validar()
        ingrediente = ingrediente & " Fiambre,"
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        validar()
        ingrediente = ingrediente & " Cogumelos,"
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        validar()
        massa = "Fina"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        validar()
        massa = "Normal"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        validar()
        queijo = "Mozzarela"
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        validar()
        queijo = "Parmesão"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("A sua encomenda tem ingrediente extra de:" & ingrediente & " massa " & massa & " e queijo " & queijo)
    End Sub
End Class