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

    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        Form5.Show()
    End Sub



    Private Sub ComboMFamiliar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMFamiliar.SelectedIndexChanged


#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        TextoHora.Text = SignoDeBalboa & VPrecioHora
        TextoDia.Text = SignoDeBalboa & VPrecioDia
        TextoSemana.Text = SignoDeBalboa & VPrecioSemana
        TextoMes.Text = SignoDeBalboa & VPrecioMes
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
    End Sub

    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Dispose()
    End Sub
End Class