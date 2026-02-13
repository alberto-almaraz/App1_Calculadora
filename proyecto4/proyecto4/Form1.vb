Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Numero1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Suma.Click
        Dim Numero1 As Integer = Integer.Parse(txtbxnum1.Text)
        Dim Numero2 As Integer = Integer.Parse(txtbxnum2.Text)

        Dim Resultado As Integer = Numero1 + Numero2

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Resta.Click
        Dim Numero1 As Integer = Integer.Parse(txtbxnum1.Text)
        Dim Numero2 As Integer = Integer.Parse(txtbxnum2.Text)

        Dim Resultado As Integer = Numero1 - Numero2

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Multiplica.Click
        Dim Numero1 As Integer = Integer.Parse(txtbxnum1.Text)
        Dim Numero2 As Integer = Integer.Parse(txtbxnum2.Text)

        Dim Resultado As Integer = Numero1 * Numero2

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Entre.Click
        Dim Numero1 As Integer = Integer.Parse(txtbxnum1.Text)
        Dim Numero2 As Integer = Integer.Parse(txtbxnum2.Text)

        Dim Resultado As Integer = Numero1 / Numero2

        Label6.Text = Resultado.ToString()
    End Sub

    Private Sub Cero_Click(sender As Object, e As EventArgs) Handles Cero.Click
        txtbxnum1.Text = txtbxnum1.Text & "0"
    End Sub

    Private Sub Uno_Click(sender As Object, e As EventArgs) Handles Uno.Click
        txtbxnum1.Text = txtbxnum1.Text & "1"
    End Sub

    Private Sub Dos_Click(sender As Object, e As EventArgs) Handles Dos.Click
        txtbxnum1.Text = txtbxnum1.Text & "2"
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles Tres.Click
        txtbxnum1.Text = txtbxnum1.Text & "3"
    End Sub

    Private Sub Cuatro_Click(sender As Object, e As EventArgs) Handles Cuatro.Click
        txtbxnum1.Text = txtbxnum1.Text & "4"
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles Cinco.Click
        txtbxnum1.Text = txtbxnum1.Text & "5"
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles Seis.Click
        txtbxnum1.Text = txtbxnum1.Text & "6"
    End Sub

    Private Sub Siete_Click(sender As Object, e As EventArgs) Handles Siete.Click
        txtbxnum1.Text = txtbxnum1.Text & "7"
    End Sub

    Private Sub Ocho_Click(sender As Object, e As EventArgs) Handles Ocho.Click
        txtbxnum1.Text = txtbxnum1.Text & "8"
    End Sub

    Private Sub Nueve_Click(sender As Object, e As EventArgs) Handles Nueve.Click
        txtbxnum1.Text = txtbxnum1.Text & "9"
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        txtbxnum1.Text = " "
    End Sub

    Private Sub Resultado_Click(sender As Object, e As EventArgs) Handles Resultado.Click

    End Sub
End Class
