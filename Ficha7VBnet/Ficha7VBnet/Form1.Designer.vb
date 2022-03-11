<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.btnMaior = New System.Windows.Forms.Button()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.btnNovosNumeros = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resultado"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(77, 25)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(77, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'btnConfirma
        '
        Me.btnConfirma.Location = New System.Drawing.Point(191, 42)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(78, 27)
        Me.btnConfirma.TabIndex = 4
        Me.btnConfirma.Text = "Confirma"
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'btnMaior
        '
        Me.btnMaior.Location = New System.Drawing.Point(19, 117)
        Me.btnMaior.Name = "btnMaior"
        Me.btnMaior.Size = New System.Drawing.Size(75, 43)
        Me.btnMaior.TabIndex = 5
        Me.btnMaior.Text = "Maior"
        Me.btnMaior.UseVisualStyleBackColor = True
        '
        'btnMedia
        '
        Me.btnMedia.Location = New System.Drawing.Point(118, 117)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Size = New System.Drawing.Size(75, 43)
        Me.btnMedia.TabIndex = 6
        Me.btnMedia.Text = "Media"
        Me.btnMedia.UseVisualStyleBackColor = True
        '
        'btnNovosNumeros
        '
        Me.btnNovosNumeros.Location = New System.Drawing.Point(211, 117)
        Me.btnNovosNumeros.Name = "btnNovosNumeros"
        Me.btnNovosNumeros.Size = New System.Drawing.Size(75, 43)
        Me.btnNovosNumeros.TabIndex = 7
        Me.btnNovosNumeros.Text = "Novos Numeros"
        Me.btnNovosNumeros.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 165)
        Me.Controls.Add(Me.btnNovosNumeros)
        Me.Controls.Add(Me.btnMedia)
        Me.Controls.Add(Me.btnMaior)
        Me.Controls.Add(Me.btnConfirma)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnConfirma As Button
    Friend WithEvents btnMaior As Button
    Friend WithEvents btnMedia As Button
    Friend WithEvents btnNovosNumeros As Button
End Class
