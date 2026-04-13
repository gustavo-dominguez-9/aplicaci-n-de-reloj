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
        Me.minutos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dia = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.conf = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.start = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        'minutos
        '
        Me.minutos.AccessibleDescription = "group"
        Me.minutos.AccessibleName = "group"
        Me.minutos.AutoSize = True
        Me.minutos.Font = New System.Drawing.Font("Proxy 9", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.ForeColor = System.Drawing.Color.Lime
        Me.minutos.Location = New System.Drawing.Point(394, 65)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(208, 146)
        Me.minutos.TabIndex = 1
        Me.minutos.Text = "00"
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
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panel1.Controls.Add(Me.ComboBox1)
        Me.panel1.Controls.Add(Me.conf)
        Me.panel1.Controls.Add(Me.Button2)
        Me.panel1.Location = New System.Drawing.Point(6, 18)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(692, 332)
        Me.panel1.TabIndex = 7
        Me.panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(23, 141)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'conf
        '
        Me.conf.AutoSize = True
        Me.conf.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.conf.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf.ForeColor = System.Drawing.Color.Lime
        Me.conf.Location = New System.Drawing.Point(151, 7)
        Me.conf.Name = "conf"
        Me.conf.Size = New System.Drawing.Size(376, 55)
        Me.conf.TabIndex = 4
        Me.conf.Text = "configuraciones"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(16, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 56)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "24hr"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.tiempo)
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.start)
        Me.Panel2.Location = New System.Drawing.Point(9, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 332)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Visible = False
        '
        'tiempo
        '
        Me.tiempo.AccessibleDescription = "group"
        Me.tiempo.AccessibleName = "group"
        Me.tiempo.AutoSize = True
        Me.tiempo.Font = New System.Drawing.Font("Proxy 9", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.ForeColor = System.Drawing.Color.Lime
        Me.tiempo.Location = New System.Drawing.Point(37, 94)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(594, 117)
        Me.tiempo.TabIndex = 6
        Me.tiempo.Text = "00:00:00.00"
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.reset.ForeColor = System.Drawing.Color.Lime
        Me.reset.Location = New System.Drawing.Point(503, 246)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(90, 56)
        Me.reset.TabIndex = 5
        Me.reset.Text = "Restart"
        Me.reset.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(194, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cronometro"
        '
        'start
        '
        Me.start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.start.ForeColor = System.Drawing.Color.Lime
        Me.start.Location = New System.Drawing.Point(57, 246)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(90, 56)
        Me.start.TabIndex = 3
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(125, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 31)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "⚙"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'segundos
        '
        Me.segundos.AccessibleDescription = "group"
        Me.segundos.AccessibleName = "group"
        Me.segundos.Font = New System.Drawing.Font("Proxy 9", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.ForeColor = System.Drawing.Color.Lime
        Me.segundos.Location = New System.Drawing.Point(577, 9)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(118, 69)
        Me.segundos.TabIndex = 9
        Me.segundos.Text = "00"
        '
        'Timer3
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(190, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 31)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "⏱️"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.ForeColor = System.Drawing.Color.Lime
        Me.Button5.Location = New System.Drawing.Point(255, 356)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 31)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "⌛ "
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.aplicacion_reloj.My.Resources.Resources._10466199
        Me.PictureBox3.Location = New System.Drawing.Point(423, 356)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.aplicacion_reloj.My.Resources.Resources.Sin_título
        Me.PictureBox2.Location = New System.Drawing.Point(509, 356)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.aplicacion_reloj.My.Resources.Resources.icon6
        Me.PictureBox1.Location = New System.Drawing.Point(595, 356)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(22, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(674, 344)
        Me.Panel3.TabIndex = 15
        Me.Panel3.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button8.ForeColor = System.Drawing.Color.Lime
        Me.Button8.Location = New System.Drawing.Point(168, 252)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 56)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "1 min"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.ForeColor = System.Drawing.Color.Lime
        Me.Button7.Location = New System.Drawing.Point(60, 252)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 56)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "5 min"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = "group"
        Me.Label4.AccessibleName = "group"
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxy 9", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(186, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(310, 117)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "00:00"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.ForeColor = System.Drawing.Color.Lime
        Me.Button6.Location = New System.Drawing.Point(528, 252)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 56)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Start"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(189, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 55)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Temporizador"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button9.ForeColor = System.Drawing.Color.Lime
        Me.Button9.Location = New System.Drawing.Point(432, 252)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(90, 56)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "Reset"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(737, 422)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dia)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.segundos)
        Me.Name = "Form1"
        Me.Text = "reloj digital"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hora As Label
    Friend WithEvents minutos As Label
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents segundos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents start As Button
    Friend WithEvents reset As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents tiempo As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Button9 As Button
End Class
