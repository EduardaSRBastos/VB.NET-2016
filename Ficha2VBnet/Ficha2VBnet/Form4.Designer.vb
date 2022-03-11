<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Limpar = New System.Windows.Forms.Button()
        Me.primeiro = New System.Windows.Forms.TextBox()
        Me.Segundo = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.divide12 = New System.Windows.Forms.Button()
        Me.Divide21 = New System.Windows.Forms.Button()
        Me.Diferença = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(75, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Operações sobre números"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Primeiro número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Segundo número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Resultado"
        '
        'Limpar
        '
        Me.Limpar.Location = New System.Drawing.Point(194, 248)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(96, 29)
        Me.Limpar.TabIndex = 4
        Me.Limpar.Text = "Limpar"
        Me.Limpar.UseVisualStyleBackColor = True
        '
        'primeiro
        '
        Me.primeiro.Location = New System.Drawing.Point(190, 78)
        Me.primeiro.Name = "primeiro"
        Me.primeiro.Size = New System.Drawing.Size(100, 20)
        Me.primeiro.TabIndex = 5
        Me.primeiro.Text = "0"
        '
        'Segundo
        '
        Me.Segundo.Location = New System.Drawing.Point(190, 139)
        Me.Segundo.Name = "Segundo"
        Me.Segundo.Size = New System.Drawing.Size(100, 20)
        Me.Segundo.TabIndex = 6
        Me.Segundo.Text = "0"
        '
        'Resultado
        '
        Me.Resultado.Enabled = False
        Me.Resultado.Location = New System.Drawing.Point(174, 201)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(124, 20)
        Me.Resultado.TabIndex = 7
        '
        'divide12
        '
        Me.divide12.Enabled = False
        Me.divide12.Location = New System.Drawing.Point(39, 62)
        Me.divide12.Name = "divide12"
        Me.divide12.Size = New System.Drawing.Size(123, 48)
        Me.divide12.TabIndex = 8
        Me.divide12.Text = "Divide o 1º número pelo 2º"
        Me.divide12.UseVisualStyleBackColor = True
        '
        'Divide21
        '
        Me.Divide21.Enabled = False
        Me.Divide21.Location = New System.Drawing.Point(39, 123)
        Me.Divide21.Name = "Divide21"
        Me.Divide21.Size = New System.Drawing.Size(123, 47)
        Me.Divide21.TabIndex = 9
        Me.Divide21.Text = "Divide o 2º número pelo 1º"
        Me.Divide21.UseVisualStyleBackColor = True
        '
        'Diferença
        '
        Me.Diferença.Enabled = False
        Me.Diferença.Location = New System.Drawing.Point(39, 183)
        Me.Diferença.Name = "Diferença"
        Me.Diferença.Size = New System.Drawing.Size(123, 38)
        Me.Diferença.TabIndex = 10
        Me.Diferença.Text = "Diferença entre os anteriores"
        Me.Diferença.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(174, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 48)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(174, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(124, 47)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(174, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 45)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 306)
        Me.Controls.Add(Me.Diferença)
        Me.Controls.Add(Me.Divide21)
        Me.Controls.Add(Me.divide12)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Segundo)
        Me.Controls.Add(Me.primeiro)
        Me.Controls.Add(Me.Limpar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form4"
        Me.Text = "Exercício 1_6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Limpar As Button
    Friend WithEvents primeiro As TextBox
    Friend WithEvents Segundo As TextBox
    Friend WithEvents Resultado As TextBox
    Friend WithEvents divide12 As Button
    Friend WithEvents Divide21 As Button
    Friend WithEvents Diferença As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
