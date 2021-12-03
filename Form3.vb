Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ComboMFamiliar.SelectedIndex Then
            Dim x As Integer
            x = 0
            Do
                ComboMFamiliar.Items.Add(Module1.arrayMAutosFamiliar(x))
                x += 1
            Loop While (x < Module1.arrayMAutosFamiliar.Length)
        End If
    End Sub

    Private Sub ComboMFamiliar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMFamiliar.SelectedIndexChanged

        If ComboMFamiliar.SelectedIndex Then
            x = 0
            Do
                x += 1
            Loop While (x < ComboMFamiliar.SelectedIndex)

        End If

        TextoHora.Text = SignoDeBalboa & VPrecioHoraFamiliar(x)
        TextoDia.Text = SignoDeBalboa & VPrecioDiaFamiliar(x)
        TextoSemana.Text = SignoDeBalboa & VPrecioSemanaFamiliar(x)
        TextoMes.Text = SignoDeBalboa & VPrecioMesFamiliar(x)

    End Sub

    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        Form5.Show()
        Form5.RadioTipoVehiculoFamiliar.Checked = True
        Form5.ComboMVehiculo.SelectedIndex = ComboMFamiliar.SelectedIndex
    End Sub

    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Dispose()
    End Sub

End Class