Public Class Exercício3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        While ListBox1.SelectedItems.Count > 0
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndices(0))
        End While

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer = 0
        For Each j As Integer In ListBox1.SelectedIndices
            If i = 0 Then
                Label4.Text &= ListBox1.SelectedItems(j)
                i = 1
            Else
                Label4.Text &= "+" & ListBox1.SelectedItems(j)
            End If
        Next
    End Sub
End Class