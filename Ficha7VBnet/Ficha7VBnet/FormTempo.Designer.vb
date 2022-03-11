<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTempo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbEstacoes = New System.Windows.Forms.RadioButton()
        Me.rtbMeses = New System.Windows.Forms.RadioButton()
        Me.rtbDiasSemana = New System.Windows.Forms.RadioButton()
        Me.lstResultados = New System.Windows.Forms.ListBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtbEstacoes)
        Me.GroupBox1.Controls.Add(Me.rtbMeses)
        Me.GroupBox1.Controls.Add(Me.rtbDiasSemana)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione lista a consultar"
        '
        'rtbEstacoes
        '
        Me.rtbEstacoes.AutoSize = True
        Me.rtbEstacoes.Location = New System.Drawing.Point(234, 40)
        Me.rtbEstacoes.Name = "rtbEstacoes"
        Me.rtbEstacoes.Size = New System.Drawing.Size(105, 17)
        Me.rtbEstacoes.TabIndex = 2
        Me.rtbEstacoes.TabStop = True
        Me.rtbEstacoes.Text = "Estações do ano"
        Me.rtbEstacoes.UseVisualStyleBackColor = True
        '
        'rtbMeses
        '
        Me.rtbMeses.AutoSize = True
        Me.rtbMeses.Location = New System.Drawing.Point(138, 40)
        Me.rtbMeses.Name = "rtbMeses"
        Me.rtbMeses.Size = New System.Drawing.Size(56, 17)
        Me.rtbMeses.TabIndex = 1
        Me.rtbMeses.TabStop = True
        Me.rtbMeses.Text = "Meses"
        Me.rtbMeses.UseVisualStyleBackColor = True
        '
        'rtbDiasSemana
        '
        Me.rtbDiasSemana.AutoSize = True
        Me.rtbDiasSemana.Location = New System.Drawing.Point(6, 40)
        Me.rtbDiasSemana.Name = "rtbDiasSemana"
        Me.rtbDiasSemana.Size = New System.Drawing.Size(103, 17)
        Me.rtbDiasSemana.TabIndex = 0
        Me.rtbDiasSemana.TabStop = True
        Me.rtbDiasSemana.Text = "Dias da Semana"
        Me.rtbDiasSemana.UseVisualStyleBackColor = True
        '
        'lstResultados
        '
        Me.lstResultados.FormattingEnabled = True
        Me.lstResultados.Location = New System.Drawing.Point(59, 92)
        Me.lstResultados.Name = "lstResultados"
        Me.lstResultados.Size = New System.Drawing.Size(217, 199)
        Me.lstResultados.TabIndex = 1
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(304, 267)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'FormTempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 305)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lstResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormTempo"
        Me.Text = "Tempo ao Longo do Ano"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtbEstacoes As RadioButton
    Friend WithEvents rtbMeses As RadioButton
    Friend WithEvents rtbDiasSemana As RadioButton
    Friend WithEvents lstResultados As ListBox
    Friend WithEvents btnSair As Button
End Class
