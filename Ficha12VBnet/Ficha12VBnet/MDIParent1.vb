Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub Exercício1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exercício1ToolStripMenuItem.Click
        Exercício1.MdiParent = Me
        Exercício1.Text = "Janela - Exercicio 1"
        Exercício1.Show()
    End Sub

    Private Sub Exercício2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exercício2ToolStripMenuItem.Click
        Exercício2.MdiParent = Me
        Exercício2.Text = "Janela - Exercicio 2"
        Exercício2.Show()
    End Sub

    Private Sub Exercício3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exercício3ToolStripMenuItem.Click
        Exercício3.MdiParent = Me
        Exercício3.Text = "Janela - Exercicio 3"
        Exercício3.Show()
    End Sub

    Private Sub Exercício4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exercício4ToolStripMenuItem.Click
        Exercício4.MdiParent = Me
        Exercício4.Text = "Janela - Exercicio 4"
        Exercício4.Show()
    End Sub

    Private Sub Exercício5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exercício5ToolStripMenuItem.Click
        Exercício5.MdiParent = Me
        Exercício5.Text = "Janela - Exercicio 5"
        Exercício5.Show()
    End Sub

    Private Sub Exercício6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exercício6ToolStripMenuItem.Click
        Exercício6.MdiParent = Me
        Exercício6.Text = "Janela - Exercicio 6"
        Exercício6.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CascataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascataToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub FecharJanelaVísivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharJanelaVísivelToolStripMenuItem.Click
        If (Not Me.ActiveMdiChild Is Nothing) Then
            Me.ActiveMdiChild.Close()
        Else
            MessageBox.Show("Nenhuma Janela Filha aberta")
        End If

    End Sub

    Private m_ChildFormNumber As Integer

End Class
