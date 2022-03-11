Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        TextBox1.Text = CInt(Int((100 * Rnd()) + 1))
        TextBox2.Text = CInt(Int((100 * Rnd()) + 1))
        TextBox3.Text = CInt(Int((100 * Rnd()) + 1))
        TextBox4.Text = CInt(Int((100 * Rnd()) + 1))
        TextBox5.Text = CInt(Int((100 * Rnd()) + 1))
        TextBox6.Text = CInt(Int((10 * Rnd()) + 1))
        TextBox7.Text = CInt(Int((10 * Rnd()) + 1))

    End Sub

End Class
