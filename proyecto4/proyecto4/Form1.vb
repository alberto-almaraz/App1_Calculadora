Public Class Form1
    Dim activo


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Numero1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Suma.Click
        Dim Numero1 As Double = Double.Parse(textbox1.Text)
        Dim Numero2 As Double = Double.Parse(textbox2.Text)

        Dim Resultado As Double = Numero1 + Numero2

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Resta.Click
        Dim Numero1 As Double = Double.Parse(textbox1.Text)
        Dim Numero2 As Double = Double.Parse(textbox2.Text)

        Dim Resultado As Double = Numero1 - Numero2

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Multiplica.Click

        Dim Numero1 As Double = Double.Parse(textbox1.Text)
        Dim Numero2 As Double = Double.Parse(textbox2.Text)

        Dim Resultado As Double = Numero1 * Numero2

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Entre.Click

        Dim Resultado

        Dim Numero1 As Double = Double.Parse(textbox1.Text)
        Dim Numero2 As Double = Double.Parse(textbox2.Text)

        If Numero2 > 0 Then
            Resultado = Numero1 / Numero2
        Else
            Resultado = "No se puede"
        End If

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Cero_Click(sender As Object, e As EventArgs) Handles Cero.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub Uno_Click(sender As Object, e As EventArgs) Handles Uno.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub Dos_Click(sender As Object, e As EventArgs) Handles Dos.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles Tres.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub Cuatro_Click(sender As Object, e As EventArgs) Handles Cuatro.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles Cinco.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles Seis.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub Siete_Click(sender As Object, e As EventArgs) Handles Siete.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub Ocho_Click(sender As Object, e As EventArgs) Handles Ocho.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub Nueve_Click(sender As Object, e As EventArgs) Handles Nueve.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        activo.Text = " "
    End Sub

    Private Sub Resultado_Click(sender As Object, e As EventArgs) Handles Resultado.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Punto_Click(sender As Object, e As EventArgs) Handles Punto.Click
        activo.Text = activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = textbox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = textbox2


    End Sub

    Private Sub textbox1_TextChanged(sender As Object, e As EventArgs) Handles textbox1.TextChanged

    End Sub
End Class
