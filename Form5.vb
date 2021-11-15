Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs)
        TextoApellido.Clear()
        TextoCedula.Clear()
        TextoDireccion.Clear()
        TextoEdad.Clear()
        TextoLicencia.Clear()
        TextoNacionalidad.Clear()
        TextoNombre.Clear()
        TextoTelefono.Clear()
        TextoTiempoRentar.Clear()
        RadioTarifaElegidaDias.Checked = False
        RadioTarifaElegidaHoras.Checked = False
    End Sub
End Class