Public Class Form5
	Public Impuesto As Double
	Public SaldoTotal As Double
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
		Form6.TextoFechaRetiro.Text = ComboFechaRetiroMes.Text & " / " & ComboFechaRetiroDia.Text & " / " & ComboFechaRetiroAño.Text
		Form6.TextoSucursal.Text = ComboSucursales.Text

		x = 0
		Do
			x += 1
		Loop While (x < ComboMVehiculo.SelectedIndex)
		Dim Costo As Integer

		''CALCULOS LEVES PARA TEXTOCOSTO.TEXT X HORAS

		If RadioTarifaElegidaHoras.Checked Then
			Form6.TextoTarifaElegida.Text = "Horas"
			If RadioTipoVehiculoFamiliar.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioHoraFamiliar(x)
				End If
			End If
			If RadioTipoVehiculoLujo.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioHoraLujo(x)
				End If
			End If
		End If

		''CALCULOS LEVES PARA TEXTOCOSTO.TEXT X DIAS


		If RadioTarifaElegidaDias.Checked Then
			Form6.TextoTarifaElegida.Text = "Dias"

			If RadioTipoVehiculoFamiliar.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioDiaFamiliar(x)
				End If
			End If
			If RadioTipoVehiculoLujo.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioDiaLujo(x)
				End If
			End If

		End If

		''CALCULOS LEVES PARA TEXTOCOSTO.TEXT X SEMANAS


		If RadioTarifaElegidaSemanas.Checked Then
			Form6.TextoTarifaElegida.Text = "Semanas"

			If RadioTipoVehiculoFamiliar.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioSemanaFamiliar(x)
				End If
			End If
			If RadioTipoVehiculoLujo.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioSemanaLujo(x)
				End If
			End If

		End If

		''CALCULOS LEVES PARA TEXTOCOSTO.TEXT X MESES


		If RadioTarifaElegidaMeses.Checked Then
			Form6.TextoTarifaElegida.Text = "Mes"

			If RadioTipoVehiculoFamiliar.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioMesFamiliar(x)
				End If
			End If
			If RadioTipoVehiculoLujo.Checked Then
				If ComboMVehiculo.SelectedIndex Then
					Costo = Val(TextoTiempoRentar.Text) * VPrecioMesLujo(x)
				End If
			End If
		End If

		If RadioTipoVehiculoFamiliar.Checked Then
			Impuesto = Costo * 0.17
			SaldoTotal = Impuesto + Costo
		End If
		If RadioTipoVehiculoLujo.Checked Then
			Impuesto = Costo * 0.23
			SaldoTotal = Impuesto + Costo
		End If
		Form6.TextoCosto.Text = SignoDeBalboa & " " & Costo
		Form6.TextoImpuesto.Text = SignoDeBalboa & " " & Impuesto
		Form6.TextoTotalPagar.Text = SignoDeBalboa & " " & SaldoTotal

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
		ComboMVehiculo.Text = ("")
		ComboSucursales.Text = ("")
		ComboMetodoPago.Text = ("")


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
			ComboMVehiculo.Items.Add("SELECCIONE UN TIPO POR FAVOR.")
		End If

	End Sub
End Class