Public Class Form6
    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Dispose()

    End Sub

    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        Form7.Show()

        Form7.LabelAviso.Text = "Pago Realizado"
        If TextoNombre.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoApellido.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoCedula.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoNacionalidad.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoLicencia.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoDireccion.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoEdad.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoTelefono.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If


        If TextoCosto.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoTotalPagar.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoTiempoRentar.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoSucursal.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoMetodoPago.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoModelo.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoTarifaElegida.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoImpuesto.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
        If TextoFechaRetiro.Text.Length = 0 Then
            Form7.LabelAviso.Text = "Regrese y rellene todos los campos."
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class