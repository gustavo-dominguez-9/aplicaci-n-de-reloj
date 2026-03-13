Public Class Form1
    Dim contador As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm")

        Dim Time_mod = Time_o.Split(":")

        hora.Text = Time_mod(0)
        segundo.Text = Time_mod(1)
        dia.Text = Day_o
        fecha.Text = Date_o

    End Sub

    Private Sub segundo_Click(sender As Object, e As EventArgs) Handles segundo.Click

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
            segundo.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
            dia.ForeColor = Color.Red
            Button1.ForeColor = Color.Red
            Button3.ForeColor = Color.Red
        ElseIf contador = 2 Then
            hora.ForeColor = Color.Fuchsia
            Label3.ForeColor = Color.Fuchsia
            segundo.ForeColor = Color.Fuchsia
            fecha.ForeColor = Color.Fuchsia
            dia.ForeColor = Color.Fuchsia
            Button1.ForeColor = Color.Fuchsia
            Button3.ForeColor = Color.Fuchsia
        ElseIf contador = 3 Then
            hora.ForeColor = Color.Yellow
            Label3.ForeColor = Color.Yellow
            segundo.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
            dia.ForeColor = Color.Yellow
            Button1.ForeColor = Color.Yellow
            Button3.ForeColor = Color.Yellow
        ElseIf contador = 5 Then
            hora.ForeColor = Color.Lime
            Label3.ForeColor = Color.Lime
            segundo.ForeColor = Color.Lime
            fecha.ForeColor = Color.Lime
            dia.ForeColor = Color.Lime
            Button1.ForeColor = Color.Lime
            Button3.ForeColor = Color.Lime
        ElseIf contador = 4 Then
            hora.ForeColor = Color.Aqua
            Label3.ForeColor = Color.Aqua
            segundo.ForeColor = Color.Aqua
            fecha.ForeColor = Color.Aqua
            dia.ForeColor = Color.Aqua
            Button1.ForeColor = Color.Aqua
            Button3.ForeColor = Color.Aqua


        ElseIf contador = 6 Then
            contador = 0

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label3.Text = ":" Then
            Label3.Text = ""
        ElseIf label3.text = "" Then
            Label3.Text = ":"
        End If
    End Sub

    Private Sub fecha_Click(sender As Object, e As EventArgs) Handles fecha.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panel1.Visible = False Then
            panel1.Visible = True
        ElseIf panel1.visible = True Then
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
End Class
