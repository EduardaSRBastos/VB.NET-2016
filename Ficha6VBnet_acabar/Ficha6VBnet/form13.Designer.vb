<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbPares = New System.Windows.Forms.RadioButton()
        Me.rtbSequencial = New System.Windows.Forms.RadioButton()
        Me.IstNumero = New System.Windows.Forms.ListBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Limite"
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(115, 62)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(100, 20)
        Me.txtLimite.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtbPares)
        Me.GroupBox1.Controls.Add(Me.rtbSequencial)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleção do tipo da Listagem"
        '
        'rtbPares
        '
        Me.rtbPares.AutoSize = True
        Me.rtbPares.Location = New System.Drawing.Point(104, 49)
        Me.rtbPares.Name = "rtbPares"
        Me.rtbPares.Size = New System.Drawing.Size(52, 17)
        Me.rtbPares.TabIndex = 1
        Me.rtbPares.TabStop = True
        Me.rtbPares.Text = "Pares"
        Me.rtbPares.UseVisualStyleBackColor = True
        '
        'rtbSequencial
        '
        Me.rtbSequencial.AutoSize = True
        Me.rtbSequencial.Location = New System.Drawing.Point(7, 49)
        Me.rtbSequencial.Name = "rtbSequencial"
        Me.rtbSequencial.Size = New System.Drawing.Size(78, 17)
        Me.rtbSequencial.TabIndex = 0
        Me.rtbSequencial.TabStop = True
        Me.rtbSequencial.Text = "Sequencial"
        Me.rtbSequencial.UseVisualStyleBackColor = True
        '
        'IstNumero
        '
        Me.IstNumero.FormattingEnabled = True
        Me.IstNumero.Location = New System.Drawing.Point(24, 240)
        Me.IstNumero.Name = "IstNumero"
        Me.IstNumero.Size = New System.Drawing.Size(146, 212)
        Me.IstNumero.TabIndex = 3
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(273, 240)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 4
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 457)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.IstNumero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtLimite)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Exercicio4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLimite As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtbPares As RadioButton
    Friend WithEvents rtbSequencial As RadioButton
    Friend WithEvents IstNumero As ListBox
    Friend WithEvents btnListar As Button
    Friend WithEvents Label2 As Label
End Class
