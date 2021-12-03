Public Class Form5
	Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
		Dispose()
	End Sub

	Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
		Form6.Show()

		Form6.TextoNombre.Text = TextoNombre.Text
		Form6.TextoApellido.Text = TextoApellido.Text
		Form6.TextoNacionalidad.Text = TextoNacionalidad.Text
		Form6.TextoCedula.Text = TextoCedula.Text
		Form6.TextoEdad.Text = TextoEdad.Text
		Form6.TextoTelefono.Text = TextoTelefono.Text
		Form6.TextoLicencia.Text = TextoLicencia.Text
		Form6.TextoDireccion.Text = TextoDireccion.Text



		Form6.TextoModelo.Text = ComboMVehiculo.Text
		Form6.TextoMetodoPago.Text = ComboMetodoPago.Text
		Form6.TextoTiempoRentar.Text = TextoTiempoRentar.Text
		Form6.TextoFechaRetiro.Text = ComboFechaRetiroMes.Text & "/" & ComboFechaRetiroDia.Text & "/" & ComboFechaRetiroAño.Text
		Form6.TextoSucursal.Text = ComboSucursales.Text

		If RadioTarifaElegidaHoras.Checked Then
			Form6.TextoTarifaElegida.Text = "HORAS"
		End If
		If RadioTarifaElegidaDias.Checked Then
			Form6.TextoTarifaElegida.Text = "DIAS"
		End If
		If RadioTarifaElegidaSemanas.Checked Then
			Form6.TextoTarifaElegida.Text = "SEMANAS"
		End If
		If RadioTarifaElegidaMeses.Checked Then
			Form6.TextoTarifaElegida.Text = "MESES"
		End If


		''Form6.Texto.Text = ComboMVehiculo.Text
		''Form6.TextoModelo.Text = ComboMVehiculo.Text
		''Form6.TextoModelo.Text = ComboMVehiculo.Text

	End Sub

	Private Sub BotonLimpiar_Click_1(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
		TextoApellido.Clear()
		TextoCedula.Clear()
		TextoDireccion.Clear()
		TextoEdad.Clear()
		TextoLicencia.Clear()
		TextoNacionalidad.Clear()
		TextoNombre.Clear()
		TextoTelefono.Clear()
		TextoTiempoRentar.Clear()
		RadioTipoVehiculoFamiliar.Checked = False
		RadioTipoVehiculoLujo.Checked = False
		RadioTarifaElegidaHoras.Checked = False
		RadioTarifaElegidaDias.Checked = False
		RadioTarifaElegidaSemanas.Checked = False
		RadioTarifaElegidaMeses.Checked = False
		ComboFechaRetiroDia.Text = ("")
		ComboFechaRetiroMes.Text = ("")
		ComboFechaRetiroAño.Text = ("")


	End Sub

	Private Sub RadioTipoVehiculoFamiliar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTipoVehiculoFamiliar.CheckedChanged

		ComboMVehiculo.Items.Clear()
		Dim y As Integer
		y = 0
		Do
			ComboMVehiculo.Items.Add(arrayMAutosFamiliar(y))
			y += 1
		Loop While (y < arrayMAutosFamiliar.Length)

	End Sub

	Private Sub RadioTipoVehiculoLujo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTipoVehiculoLujo.CheckedChanged

		ComboMVehiculo.Items.Clear()
		Dim y As Integer
		y = 0
		Do
			ComboMVehiculo.Items.Add(arrayMAutosLujo(y))
			y += 1
		Loop While (y < arrayMAutosLujo.Length)
	End Sub

	Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		''items de combo dias
		If ComboFechaRetiroDia.SelectedIndex Then
			x = 0
			Do
				ComboFechaRetiroDia.Items.Add(arrayDiasDelMes(x))
				x += 1
			Loop While (x < arrayDiasDelMes.Length)
		End If
		''items combo meses
		If ComboFechaRetiroMes.SelectedIndex Then
			x = 0
			Do
				ComboFechaRetiroMes.Items.Add(arrayMesesDelAño(x))
				x += 1
			Loop While (x < arrayMesesDelAño.Length)
		End If
		''items combo años
		If ComboFechaRetiroAño.SelectedIndex Then
			x = 0
			Do
				ComboFechaRetiroAño.Items.Add(arrayAñosDisponibles(x))
				x += 1
			Loop While (x < arrayAñosDisponibles.Length)
		End If


		If ComboSucursales.SelectedIndex Then
			x = 0
			Do
				ComboSucursales.Items.Add(arraySucursales(x))
				x += 1
			Loop While (x < arraySucursales.Length)
		End If


		If ComboMetodoPago.SelectedIndex Then
			x = 0
			Do
				ComboMetodoPago.Items.Add(arrayMDePago(x))
				x += 1
			Loop While (x < arrayMDePago.Length)
		End If
		ComboMVehiculo.Items.Clear()

		If ComboMVehiculo.SelectedIndex Then
			x = 0
			Do
				ComboMVehiculo.Items.Add(arrayMAutosFamiliar(x))
				ComboMVehiculo.Items.Add(arrayMAutosLujo(x))
				x += 1
			Loop While (x < arrayMAutosFamiliar.Length)
		End If

	End Sub
End Class