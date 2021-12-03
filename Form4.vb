Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboMLujo.SelectedIndex Then
            Do
                ComboMLujo.Items.Add(arrayMAutosLujo(x))
                x += 1
            Loop While (x < arrayMAutosLujo.Length)
        End If
    End Sub
    Private Sub ComboModelos_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboMLujo.SelectedIndexChanged
        If ComboMLujo.SelectedIndex Then
            x = 0
            Do
                x += 1
            Loop While (x < ComboMLujo.SelectedIndex)
        End If

        TextoHora.Text = SignoDeBalboa & VPrecioHoraLujo(x)
        TextoDia.Text = SignoDeBalboa & VPrecioDiaLujo(x)
        TextoSemana.Text = SignoDeBalboa & VPrecioSemanaLujo(x)
        TextoMes.Text = SignoDeBalboa & VPrecioMesLujo(x)
    End Sub

    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        Form5.Show()


        Form5.Show()
        Form5.RadioTipoVehiculoLujo.Checked = True
        Form5.ComboMVehiculo.SelectedIndex = ComboMLujo.SelectedIndex

    End Sub

    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Dispose()

    End Sub
End Class