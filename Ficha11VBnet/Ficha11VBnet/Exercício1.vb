Imports System.ComponentModel

Public Class Exercício1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = Label2.Text + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = Label2.Text - 1
    End Sub

    Private Sub Exercício1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If Label2.Text = 0 Then
            Button2.Enabled = False
        ElseIf Label2.Text > 0
            Button2.Enabled = True
        End If
    End Sub
End Class