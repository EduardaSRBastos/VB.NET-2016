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
        Me.GroupComponentes = New System.Windows.Forms.GroupBox()
        Me.CheckPlacaRede = New System.Windows.Forms.CheckBox()
        Me.CheckMemoria = New System.Windows.Forms.CheckBox()
        Me.CheckPlacaGrafica = New System.Windows.Forms.CheckBox()
        Me.GroupCor = New System.Windows.Forms.GroupBox()
        Me.RadioBtnCinzento = New System.Windows.Forms.RadioButton()
        Me.RadioBtnPreto = New System.Windows.Forms.RadioButton()
        Me.BtnReconfigurar = New System.Windows.Forms.Button()
        Me.BtnAceitar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupComponentes.SuspendLayout()
        Me.GroupCor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(43, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = """Modelo Base - ASUS Terminator 2"""
        '
        'GroupComponentes
        '
        Me.GroupComponentes.Controls.Add(Me.CheckPlacaRede)
        Me.GroupComponentes.Controls.Add(Me.CheckMemoria)
        Me.GroupComponentes.Controls.Add(Me.CheckPlacaGrafica)
        Me.GroupComponentes.Location = New System.Drawing.Point(271, 59)
        Me.GroupComponentes.Name = "GroupComponentes"
        Me.GroupComponentes.Size = New System.Drawing.Size(200, 88)
        Me.GroupComponentes.TabIndex = 1
        Me.GroupComponentes.TabStop = False
        Me.GroupComponentes.Text = "Componentes Adicionais"
        '
        'CheckPlacaRede
        '
        Me.CheckPlacaRede.AutoSize = True
        Me.CheckPlacaRede.Location = New System.Drawing.Point(7, 68)
        Me.CheckPlacaRede.Name = "CheckPlacaRede"
        Me.CheckPlacaRede.Size = New System.Drawing.Size(97, 17)
        Me.CheckPlacaRede.TabIndex = 2
        Me.CheckPlacaRede.Text = "Placa de Rede"
        Me.CheckPlacaRede.UseVisualStyleBackColor = True
        '
        'CheckMemoria
        '
        Me.CheckMemoria.AutoSize = True
        Me.CheckMemoria.Location = New System.Drawing.Point(7, 44)
        Me.CheckMemoria.Name = "CheckMemoria"
        Me.CheckMemoria.Size = New System.Drawing.Size(118, 17)
        Me.CheckMemoria.TabIndex = 1
        Me.CheckMemoria.Text = "Mais 1 GB Memória"
        Me.CheckMemoria.UseVisualStyleBackColor = True
        '
        'CheckPlacaGrafica
        '
        Me.CheckPlacaGrafica.AutoSize = True
        Me.CheckPlacaGrafica.Location = New System.Drawing.Point(7, 20)
        Me.CheckPlacaGrafica.Name = "CheckPlacaGrafica"
        Me.CheckPlacaGrafica.Size = New System.Drawing.Size(90, 17)
        Me.CheckPlacaGrafica.TabIndex = 0
        Me.CheckPlacaGrafica.Text = "Placa Gráfica"
        Me.CheckPlacaGrafica.UseVisualStyleBackColor = True
        '
        'GroupCor
        '
        Me.GroupCor.Controls.Add(Me.RadioBtnCinzento)
        Me.GroupCor.Controls.Add(Me.RadioBtnPreto)
        Me.GroupCor.Location = New System.Drawing.Point(271, 192)
        Me.GroupCor.Name = "GroupCor"
        Me.GroupCor.Size = New System.Drawing.Size(200, 69)
        Me.GroupCor.TabIndex = 2
        Me.GroupCor.TabStop = False
        Me.GroupCor.Text = "Cor"
        '
        'RadioBtnCinzento
        '
        Me.RadioBtnCinzento.AutoSize = True
        Me.RadioBtnCinzento.Location = New System.Drawing.Point(7, 43)
        Me.RadioBtnCinzento.Name = "RadioBtnCinzento"
        Me.RadioBtnCinzento.Size = New System.Drawing.Size(66, 17)
        Me.RadioBtnCinzento.TabIndex = 1
        Me.RadioBtnCinzento.TabStop = True
        Me.RadioBtnCinzento.Text = "Cinzento"
        Me.RadioBtnCinzento.UseVisualStyleBackColor = True
        '
        'RadioBtnPreto
        '
        Me.RadioBtnPreto.AutoSize = True
        Me.RadioBtnPreto.Location = New System.Drawing.Point(7, 20)
        Me.RadioBtnPreto.Name = "RadioBtnPreto"
        Me.RadioBtnPreto.Size = New System.Drawing.Size(50, 17)
        Me.RadioBtnPreto.TabIndex = 0
        Me.RadioBtnPreto.TabStop = True
        Me.RadioBtnPreto.Text = "Preto"
        Me.RadioBtnPreto.UseVisualStyleBackColor = True
        '
        'BtnReconfigurar
        '
        Me.BtnReconfigurar.Enabled = False
        Me.BtnReconfigurar.Location = New System.Drawing.Point(29, 333)
        Me.BtnReconfigurar.Name = "BtnReconfigurar"
        Me.BtnReconfigurar.Size = New System.Drawing.Size(100, 29)
        Me.BtnReconfigurar.TabIndex = 4
        Me.BtnReconfigurar.Text = "Reconfigurar"
        Me.BtnReconfigurar.UseVisualStyleBackColor = True
        '
        'BtnAceitar
        '
        Me.BtnAceitar.Enabled = False
        Me.BtnAceitar.Location = New System.Drawing.Point(199, 333)
        Me.BtnAceitar.Name = "BtnAceitar"
        Me.BtnAceitar.Size = New System.Drawing.Size(100, 29)
        Me.BtnAceitar.TabIndex = 5
        Me.BtnAceitar.Text = "Aceitar"
        Me.BtnAceitar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(370, 333)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(93, 29)
        Me.BtnSair.TabIndex = 6
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(46, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 374)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnAceitar)
        Me.Controls.Add(Me.BtnReconfigurar)
        Me.Controls.Add(Me.GroupCor)
        Me.Controls.Add(Me.GroupComponentes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Características do Computador"
        Me.GroupComponentes.ResumeLayout(False)
        Me.GroupComponentes.PerformLayout()
        Me.GroupCor.ResumeLayout(False)
        Me.GroupCor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupComponentes As GroupBox
    Friend WithEvents CheckPlacaRede As CheckBox
    Friend WithEvents CheckMemoria As CheckBox
    Friend WithEvents CheckPlacaGrafica As CheckBox
    Friend WithEvents GroupCor As GroupBox
    Friend WithEvents RadioBtnCinzento As RadioButton
    Friend WithEvents RadioBtnPreto As RadioButton
    Friend WithEvents BtnReconfigurar As Button
    Friend WithEvents BtnAceitar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
