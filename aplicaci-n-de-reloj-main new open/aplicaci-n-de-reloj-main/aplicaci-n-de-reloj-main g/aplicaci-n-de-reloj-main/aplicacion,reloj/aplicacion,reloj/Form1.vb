Public Class Form1
    Dim contador As Integer = 0
    Dim formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'iniciar los timers
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'crea una variable y asigna un valor, el valor es la fecha del dia de hoy convertido a string en el formato de dia, mes y año 
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""


        ' este es el fromato de 24hrs 

        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        minutos.text = Time_mod(1)
        hora.Text = Time_mod(0)
        segundos.Text = Time_mod(2)
        dia.Text = Day_o
        fecha.Text = Date_o

    End Sub

    Private Sub segundo_Click(sender As Object, e As EventArgs) Handles minutos.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub hora_Click(sender As Object, e As EventArgs) Handles hora.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        contador += 1

        If contador = 1 Then
            hora.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
            dia.ForeColor = Color.Red
            Button1.ForeColor = Color.Red
            Button3.ForeColor = Color.Red
            conf.ForeColor = Color.Red
            Button2.ForeColor = Color.Red
            segundos.ForeColor = Color.Red
            reset.ForeColor = Color.Red
            start.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            tiempo.ForeColor = Color.Red
            Button4.ForeColor = Color.Red
        ElseIf contador = 2 Then
            hora.ForeColor = Color.Fuchsia
            Label3.ForeColor = Color.Fuchsia
            minutos.ForeColor = Color.Fuchsia
            fecha.ForeColor = Color.Fuchsia
            dia.ForeColor = Color.Fuchsia
            Button1.ForeColor = Color.Fuchsia
            Button3.ForeColor = Color.Fuchsia
            conf.ForeColor = Color.Fuchsia
            Button2.ForeColor = Color.Fuchsia
            segundos.ForeColor = Color.Fuchsia
            reset.ForeColor = Color.Fuchsia
            start.ForeColor = Color.Fuchsia
            Label1.ForeColor = Color.Fuchsia
            tiempo.ForeColor = Color.Fuchsia
            Button4.ForeColor = Color.Fuchsia
        ElseIf contador = 3 Then
            hora.ForeColor = Color.Yellow
            Label3.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
            dia.ForeColor = Color.Yellow
            Button1.ForeColor = Color.Yellow
            Button3.ForeColor = Color.Yellow
            conf.ForeColor = Color.Yellow
            Button2.ForeColor = Color.Yellow
            segundos.ForeColor = Color.Yellow
            reset.ForeColor = Color.Yellow
            start.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            tiempo.ForeColor = Color.Yellow
            Button4.ForeColor = Color.Yellow
        ElseIf contador = 5 Then
            hora.ForeColor = Color.Lime
            Label3.ForeColor = Color.Lime
            minutos.ForeColor = Color.Lime
            fecha.ForeColor = Color.Lime
            dia.ForeColor = Color.Lime
            Button1.ForeColor = Color.Lime
            Button3.ForeColor = Color.Lime
            conf.ForeColor = Color.Lime
            Button2.ForeColor = Color.Lime
            segundos.ForeColor = Color.Lime
            reset.ForeColor = Color.Lime
            start.ForeColor = Color.Lime
            Label1.ForeColor = Color.Lime
            tiempo.ForeColor = Color.Lime
            Button4.ForeColor = Color.Lime
        ElseIf contador = 4 Then
            hora.ForeColor = Color.Aqua
            Label3.ForeColor = Color.Aqua
            minutos.ForeColor = Color.Aqua
            fecha.ForeColor = Color.Aqua
            dia.ForeColor = Color.Aqua
            Button1.ForeColor = Color.Aqua
            Button3.ForeColor = Color.Aqua
            conf.ForeColor = Color.Aqua
            Button2.ForeColor = Color.Aqua
            segundos.ForeColor = Color.Aqua
            reset.ForeColor = Color.Aqua
            start.ForeColor = Color.Aqua
            Label1.ForeColor = Color.Aqua
            tiempo.ForeColor = Color.Aqua
            Button4.ForeColor = Color.Aqua

        ElseIf contador = 6 Then
            contador = 0

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label3.Text = ":" Then
            Label3.Text = ""
        ElseIf Label3.Text = "" Then
            Label3.Text = ":"
        End If
    End Sub

    Private Sub fecha_Click(sender As Object, e As EventArgs) Handles fecha.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panel1.Visible = False Then
            panel1.Visible = True
        ElseIf panel1.Visible = True Then
            panel1.Visible = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If panel1.Visible = False Then
            panel1.Visible = True
        ElseIf panel1.Visible = True Then
            panel1.Visible = False

        End If

    End Sub

    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            hora.ForeColor = Color.White
            Label3.ForeColor = Color.White
            minutos.ForeColor = Color.White
            fecha.ForeColor = Color.White
            dia.ForeColor = Color.White
            Button1.ForeColor = Color.White
            Button3.ForeColor = Color.White
            conf.ForeColor = Color.White
            Button2.ForeColor = Color.White
            segundos.ForeColor = Color.White
            reset.ForeColor = Color.White
            start.ForeColor = Color.White
            Label1.ForeColor = Color.White
            tiempo.ForeColor = Color.White
            Button4.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            hora.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
            dia.ForeColor = Color.Red
            Button1.ForeColor = Color.Red
            Button3.ForeColor = Color.Red
            conf.ForeColor = Color.Red
            Button2.ForeColor = Color.Red
            segundos.ForeColor = Color.Red
            reset.ForeColor = Color.Red
            start.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            tiempo.ForeColor = Color.Red
            Button4.ForeColor = Color.Red
        ElseIf color_texto = "Amarillo" Then
            hora.ForeColor = Color.Yellow
            Label3.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
            dia.ForeColor = Color.Yellow
            Button1.ForeColor = Color.Yellow
            Button3.ForeColor = Color.Yellow
            conf.ForeColor = Color.Yellow
            Button2.ForeColor = Color.Yellow
            segundos.ForeColor = Color.Yellow
            reset.ForeColor = Color.Yellow
            start.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            tiempo.ForeColor = Color.Yellow
            Button4.ForeColor = Color.Yellow
        ElseIf color_texto = "Verde" Then
            hora.ForeColor = Color.Lime
            Label3.ForeColor = Color.Lime
            minutos.ForeColor = Color.Lime
            fecha.ForeColor = Color.Lime
            dia.ForeColor = Color.Lime
            Button1.ForeColor = Color.Lime
            Button3.ForeColor = Color.Lime
            conf.ForeColor = Color.Lime
            Button2.ForeColor = Color.Lime
            segundos.ForeColor = Color.Lime
            reset.ForeColor = Color.Lime
            start.ForeColor = Color.Lime
            Label1.ForeColor = Color.Lime
            tiempo.ForeColor = Color.Lime
            Button4.ForeColor = Color.Lime
        ElseIf color_texto = "Azul" Then
            hora.ForeColor = Color.Aqua
            Label3.ForeColor = Color.Aqua
            minutos.ForeColor = Color.Aqua
            fecha.ForeColor = Color.Aqua
            dia.ForeColor = Color.Aqua
            Button1.ForeColor = Color.Aqua
            Button3.ForeColor = Color.Aqua
            conf.ForeColor = Color.Aqua
            Button2.ForeColor = Color.Aqua
            segundos.ForeColor = Color.Aqua
            reset.ForeColor = Color.Aqua
            start.ForeColor = Color.Aqua
            Label1.ForeColor = Color.Aqua
            tiempo.ForeColor = Color.Aqua
            Button4.ForeColor = Color.Aqua
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If formato = True Then
            Button2.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button2.Text = "24h"
            formato = True
        End If
    End Sub

    Private Sub segundos_Click(sender As Object, e As EventArgs) Handles segundos.Click

    End Sub

    Private Sub conf_Click(sender As Object, e As EventArgs) Handles conf.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    '=============================================
    'codigo para el cronometro////////////////

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles start.Click
        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            start.Text = "Stop"
            startTime = DateTime.Now
        ElseIf boton_start = True Then
        Timer3.Enabled = False
        boton_start = False
            start.Text = "Start"
            elapsede += DateTime.Now - startTime
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tiempo_crono = 0
        Timer3.Enabled = False
        tiempo.Text = "00"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tiempo_crono = tiempo_crono + 1
        tiempo.Text = tiempo_crono.ToString()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf panel2.Visible = True Then
            Panel2.Visible = False

        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False

        End If
    End Sub
End Class
