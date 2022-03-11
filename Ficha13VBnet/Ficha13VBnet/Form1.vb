Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Não digitou o nome.")
        Else
            If ComboBox1.SelectedIndex >= 1 Then
                LstAlunos.Items.Add(TextBox1.Text)
                i = i + 1
            Else
                MsgBox("Não selecionou uma disciplina.")
            End If
        End If
        TextBox2.Text = (i)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LstAlunos.SelectedIndex >= 1 Then
            LstAlunos.SelectedItems.Clear()

        End If
        TextBox2.Text = i - 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LstDisciplinas.Items.Add(ComboBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If LstDisciplinas.SelectedItem Then
            LstDisciplinas.SelectedItems.Clear()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.Items.Add("Português")
        ComboBox1.Items.Add("Filosofia")
        ComboBox1.Items.Add("Inglês")
        ComboBox1.Items.Add("Matemática")
        ComboBox1.Items.Add("Física e Química")
        ComboBox1.Items.Add("Técnicas de Programação")
        ComboBox1.Items.Add("AI")
        ComboBox1.Items.Add("FAC")

    End Sub
End Class
