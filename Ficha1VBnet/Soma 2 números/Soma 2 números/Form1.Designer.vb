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
        Me.Somar = New System.Windows.Forms.Button()
        Me.soma1 = New System.Windows.Forms.TextBox()
        Me.soma2 = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Somar
        '
        Me.Somar.Location = New System.Drawing.Point(106, 89)
        Me.Somar.Name = "Somar"
        Me.Somar.Size = New System.Drawing.Size(75, 23)
        Me.Somar.TabIndex = 0
        Me.Somar.Text = "Somar"
        Me.Somar.UseVisualStyleBackColor = True
        '
        'soma1
        '
        Me.soma1.Location = New System.Drawing.Point(12, 35)
        Me.soma1.Name = "soma1"
        Me.soma1.Size = New System.Drawing.Size(100, 20)
        Me.soma1.TabIndex = 1
        Me.soma1.Text = "0"
        '
        'soma2
        '
        Me.soma2.Location = New System.Drawing.Point(172, 35)
        Me.soma2.Name = "soma2"
        Me.soma2.Size = New System.Drawing.Size(100, 20)
        Me.soma2.TabIndex = 2
        Me.soma2.Text = "0"
        '
        'Resultado
        '
        Me.Resultado.Location = New System.Drawing.Point(94, 137)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(100, 20)
        Me.Resultado.TabIndex = 3
        Me.Resultado.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "+"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.soma2)
        Me.Controls.Add(Me.soma1)
        Me.Controls.Add(Me.Somar)
        Me.Name = "Form1"
        Me.Text = "Soma 2 exercícios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Somar As Button
    Friend WithEvents soma1 As TextBox
    Friend WithEvents soma2 As TextBox
    Friend WithEvents Resultado As TextBox
    Friend WithEvents Label1 As Label
End Class
