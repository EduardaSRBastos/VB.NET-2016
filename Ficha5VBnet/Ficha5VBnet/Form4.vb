Public Class Form4
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        TextBox1.Text = (Int(100 * Rnd()) + 1)
    End Sub


End Class