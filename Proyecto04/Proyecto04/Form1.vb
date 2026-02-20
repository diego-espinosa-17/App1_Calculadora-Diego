Public Class Form1
    Dim activo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonMas.Click

        Dim Numero1 As Double = Double.Parse(Me.TXTBXNumero1.Text)
        Dim Numero2 As Double = Double.Parse(TXTBXNumero2.Text)

        Dim resultado As Double = Numero1 + Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotonResta.Click
        Dim Numero1 As Double = Double.Parse(Me.TXTBXNumero1.Text)
        Dim Numero2 As Double = Double.Parse(TXTBXNumero2.Text)

        Dim resultado As Double = Numero1 - Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BotonMultiplicacion.Click
        Dim Numero1 As Double = Double.Parse(Me.TXTBXNumero1.Text)
        Dim Numero2 As Double = Double.Parse(TXTBXNumero2.Text)

        Dim resultado As Double = Numero1 * Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BotonDivision.Click

        Dim resultado

        Dim Numero1 As Double = Double.Parse(Me.TXTBXNumero1.Text)
        Dim Numero2 As Double = Double.Parse(TXTBXNumero2.Text)

        If Numero2 > 0 Then
            resultado = Numero1 / Numero2
        Else
            resultado = "No se puede"
        End If
        Label4.Text = resultado.ToString()
    End Sub

    Private Sub BotonCero_Click(sender As Object, e As EventArgs) Handles BotonCero.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub BotonUno_Click(sender As Object, e As EventArgs) Handles BotonUno.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub ButonDos_Click(sender As Object, e As EventArgs) Handles ButonDos.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub ButonTres_Click(sender As Object, e As EventArgs) Handles ButonTres.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub BotonCuatro_Click(sender As Object, e As EventArgs) Handles BotonCuatro.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub BotonCinco_Click(sender As Object, e As EventArgs) Handles BotonCinco.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub BotonSeis_Click(sender As Object, e As EventArgs) Handles BotonSeis.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub BotonSiete_Click(sender As Object, e As EventArgs) Handles BotonSiete.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub BotonOcho_Click(sender As Object, e As EventArgs) Handles BotonOcho.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub BotonNueve_Click(sender As Object, e As EventArgs) Handles BotonNueve.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub BotonBorrar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        activo.Text = ""
    End Sub

    Private Sub botonpunto_Click(sender As Object, e As EventArgs) Handles botonpunto.Click
        activo.Text = activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = TXTBXNumero1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = TXTBXNumero2
    End Sub
End Class