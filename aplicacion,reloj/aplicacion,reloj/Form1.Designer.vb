<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.hora = New System.Windows.Forms.Label()
        Me.segundo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dia = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'hora
        '
        Me.hora.AccessibleDescription = "group"
        Me.hora.AccessibleName = "group"
        Me.hora.AutoSize = True
        Me.hora.Font = New System.Drawing.Font("Proxy 9", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora.ForeColor = System.Drawing.Color.Lime
        Me.hora.Location = New System.Drawing.Point(105, 65)
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
        Me.segundo.Location = New System.Drawing.Point(417, 65)
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
        Me.Label3.Font = New System.Drawing.Font("Proxy 9", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(319, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 146)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(707, 395)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.segundo)
        Me.Controls.Add(Me.hora)
        Me.Name = "Form1"
        Me.Text = "reloj digital"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hora As Label
    Friend WithEvents segundo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dia As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
End Class
