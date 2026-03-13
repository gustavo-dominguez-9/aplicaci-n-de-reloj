<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.hora = New System.Windows.Forms.Label()
        Me.segundo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dia = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.conf = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hora
        '
        Me.hora.AccessibleDescription = "group"
        Me.hora.AccessibleName = "group"
        Me.hora.AutoSize = True
        Me.hora.Font = New System.Drawing.Font("Proxy 9", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora.ForeColor = System.Drawing.Color.Lime
        Me.hora.Location = New System.Drawing.Point(139, 65)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(208, 146)
        Me.hora.TabIndex = 0
        Me.hora.Text = "00"
        '
        'segundo
        '
        Me.segundo.AccessibleDescription = "group"
        Me.segundo.AccessibleName = "group"
        Me.segundo.AutoSize = True
        Me.segundo.Font = New System.Drawing.Font("Proxy 9", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundo.ForeColor = System.Drawing.Color.Lime
        Me.segundo.Location = New System.Drawing.Point(394, 65)
        Me.segundo.Name = "segundo"
        Me.segundo.Size = New System.Drawing.Size(208, 146)
        Me.segundo.TabIndex = 1
        Me.segundo.Text = "00"
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = "group"
        Me.Label3.AccessibleName = "group"
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Proxy 9", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(338, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 146)
        Me.Label3.TabIndex = 2
        '
        'dia
        '
        Me.dia.AccessibleDescription = "group"
        Me.dia.AccessibleName = "group"
        Me.dia.AutoSize = True
        Me.dia.Font = New System.Drawing.Font("Proxy 9", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia.ForeColor = System.Drawing.Color.Lime
        Me.dia.Location = New System.Drawing.Point(50, 230)
        Me.dia.Name = "dia"
        Me.dia.Size = New System.Drawing.Size(205, 59)
        Me.dia.TabIndex = 3
        Me.dia.Text = "Lunes"
        '
        'fecha
        '
        Me.fecha.AccessibleDescription = "group"
        Me.fecha.AccessibleName = "group"
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Proxy 9", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.Lime
        Me.fecha.Location = New System.Drawing.Point(52, 289)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(510, 46)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 de marzo de 2026"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(60, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "💡"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.aplicacion_reloj.My.Resources.Resources.icon6
        Me.PictureBox1.Location = New System.Drawing.Point(577, 329)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel1.Controls.Add(Me.conf)
        Me.panel1.Controls.Add(Me.Button2)
        Me.panel1.Location = New System.Drawing.Point(25, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(243, 286)
        Me.panel1.TabIndex = 7
        Me.panel1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 56)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'conf
        '
        Me.conf.AutoSize = True
        Me.conf.BackColor = System.Drawing.SystemColors.Control
        Me.conf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf.Location = New System.Drawing.Point(45, 17)
        Me.conf.Name = "conf"
        Me.conf.Size = New System.Drawing.Size(144, 24)
        Me.conf.TabIndex = 4
        Me.conf.Text = "configuraciones"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(136, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 31)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "⚙"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(707, 395)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dia)
        Me.Controls.Add(Me.segundo)
        Me.Controls.Add(Me.hora)
        Me.Name = "Form1"
        Me.Text = "reloj digital"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hora As Label
    Friend WithEvents segundo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dia As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panel1 As Panel
    Friend WithEvents conf As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
