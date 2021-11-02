<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grupoDetallesConductor = New System.Windows.Forms.GroupBox()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.textEdad = New System.Windows.Forms.TextBox()
        Me.labelNacionalidad = New System.Windows.Forms.Label()
        Me.labelCedula = New System.Windows.Forms.Label()
        Me.textCedula = New System.Windows.Forms.TextBox()
        Me.textDireccion = New System.Windows.Forms.TextBox()
        Me.labelDireccion = New System.Windows.Forms.Label()
        Me.labelEdad = New System.Windows.Forms.Label()
        Me.labelLicencia = New System.Windows.Forms.Label()
        Me.textApellido = New System.Windows.Forms.TextBox()
        Me.labelApellido = New System.Windows.Forms.Label()
        Me.textNacionalidad = New System.Windows.Forms.TextBox()
        Me.textLicencia = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.grupoDatosReserva = New System.Windows.Forms.GroupBox()
        Me.grupoDatosReservaTarifa = New System.Windows.Forms.GroupBox()
        Me.comboMetodoPago = New System.Windows.Forms.ComboBox()
        Me.textoTiempoRentar = New System.Windows.Forms.TextBox()
        Me.labelMetodoPago = New System.Windows.Forms.Label()
        Me.grupoTarifaElegida = New System.Windows.Forms.GroupBox()
        Me.radioTarifaElegidaDias = New System.Windows.Forms.RadioButton()
        Me.radioTarifaElegidaSemanas = New System.Windows.Forms.RadioButton()
        Me.radioTarifaElegidaMeses = New System.Windows.Forms.RadioButton()
        Me.radioTarifaElegidaHoras = New System.Windows.Forms.RadioButton()
        Me.labelTiempoRentar = New System.Windows.Forms.Label()
        Me.comboFechaRetiroAño = New System.Windows.Forms.ComboBox()
        Me.comboFechaRetiroMes = New System.Windows.Forms.ComboBox()
        Me.comboFechaRetiroDia = New System.Windows.Forms.ComboBox()
        Me.labelFechaRetiro = New System.Windows.Forms.Label()
        Me.grupoTipoAuto = New System.Windows.Forms.GroupBox()
        Me.radioTipoVehiculoLujo = New System.Windows.Forms.RadioButton()
        Me.radioTipoVehiculoFamiliar = New System.Windows.Forms.RadioButton()
        Me.comboSucursales = New System.Windows.Forms.ComboBox()
        Me.labelModeloVehiculo = New System.Windows.Forms.Label()
        Me.comboModeloOpciones = New System.Windows.Forms.ComboBox()
        Me.labelLugarRetiro = New System.Windows.Forms.Label()
        Me.botonReservar = New System.Windows.Forms.Button()
        Me.botonContinuar = New System.Windows.Forms.Button()
        Me.botonCancelar = New System.Windows.Forms.Button()
        Me.grupoDetallesConductor.SuspendLayout()
        Me.grupoDatosReserva.SuspendLayout()
        Me.grupoDatosReservaTarifa.SuspendLayout()
        Me.grupoTarifaElegida.SuspendLayout()
        Me.grupoTipoAuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoDetallesConductor
        '
        Me.grupoDetallesConductor.BackColor = System.Drawing.Color.White
        Me.grupoDetallesConductor.Controls.Add(Me.textNombre)
        Me.grupoDetallesConductor.Controls.Add(Me.textEdad)
        Me.grupoDetallesConductor.Controls.Add(Me.labelNacionalidad)
        Me.grupoDetallesConductor.Controls.Add(Me.labelCedula)
        Me.grupoDetallesConductor.Controls.Add(Me.textCedula)
        Me.grupoDetallesConductor.Controls.Add(Me.textDireccion)
        Me.grupoDetallesConductor.Controls.Add(Me.labelDireccion)
        Me.grupoDetallesConductor.Controls.Add(Me.labelEdad)
        Me.grupoDetallesConductor.Controls.Add(Me.labelLicencia)
        Me.grupoDetallesConductor.Controls.Add(Me.textApellido)
        Me.grupoDetallesConductor.Controls.Add(Me.labelApellido)
        Me.grupoDetallesConductor.Controls.Add(Me.textNacionalidad)
        Me.grupoDetallesConductor.Controls.Add(Me.textLicencia)
        Me.grupoDetallesConductor.Controls.Add(Me.labelNombre)
        Me.grupoDetallesConductor.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoDetallesConductor.Location = New System.Drawing.Point(12, 12)
        Me.grupoDetallesConductor.Name = "grupoDetallesConductor"
        Me.grupoDetallesConductor.Size = New System.Drawing.Size(860, 161)
        Me.grupoDetallesConductor.TabIndex = 0
        Me.grupoDetallesConductor.TabStop = False
        Me.grupoDetallesConductor.Text = "DETALLES DEL CONDUCTOR"
        '
        'textNombre
        '
        Me.textNombre.BackColor = System.Drawing.Color.Silver
        Me.textNombre.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textNombre.Location = New System.Drawing.Point(106, 35)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(206, 31)
        Me.textNombre.TabIndex = 33
        '
        'textEdad
        '
        Me.textEdad.BackColor = System.Drawing.Color.Silver
        Me.textEdad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textEdad.Location = New System.Drawing.Point(677, 75)
        Me.textEdad.Name = "textEdad"
        Me.textEdad.Size = New System.Drawing.Size(149, 31)
        Me.textEdad.TabIndex = 30
        '
        'labelNacionalidad
        '
        Me.labelNacionalidad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNacionalidad.Location = New System.Drawing.Point(6, 80)
        Me.labelNacionalidad.Name = "labelNacionalidad"
        Me.labelNacionalidad.Size = New System.Drawing.Size(142, 25)
        Me.labelNacionalidad.TabIndex = 29
        Me.labelNacionalidad.Text = "NACIONALIDAD"
        '
        'labelCedula
        '
        Me.labelCedula.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCedula.Location = New System.Drawing.Point(601, 40)
        Me.labelCedula.Name = "labelCedula"
        Me.labelCedula.Size = New System.Drawing.Size(90, 25)
        Me.labelCedula.TabIndex = 28
        Me.labelCedula.Text = "CÉDULA#"
        '
        'textCedula
        '
        Me.textCedula.BackColor = System.Drawing.Color.Silver
        Me.textCedula.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textCedula.Location = New System.Drawing.Point(697, 35)
        Me.textCedula.Name = "textCedula"
        Me.textCedula.Size = New System.Drawing.Size(129, 31)
        Me.textCedula.TabIndex = 27
        '
        'textDireccion
        '
        Me.textDireccion.BackColor = System.Drawing.Color.Silver
        Me.textDireccion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textDireccion.Location = New System.Drawing.Point(135, 115)
        Me.textDireccion.Name = "textDireccion"
        Me.textDireccion.Size = New System.Drawing.Size(691, 31)
        Me.textDireccion.TabIndex = 26
        '
        'labelDireccion
        '
        Me.labelDireccion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDireccion.Location = New System.Drawing.Point(6, 120)
        Me.labelDireccion.Name = "labelDireccion"
        Me.labelDireccion.Size = New System.Drawing.Size(123, 25)
        Me.labelDireccion.TabIndex = 25
        Me.labelDireccion.Text = "DIRECCIÓN"
        '
        'labelEdad
        '
        Me.labelEdad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEdad.Location = New System.Drawing.Point(603, 80)
        Me.labelEdad.Name = "labelEdad"
        Me.labelEdad.Size = New System.Drawing.Size(68, 25)
        Me.labelEdad.TabIndex = 20
        Me.labelEdad.Text = "EDAD"
        '
        'labelLicencia
        '
        Me.labelLicencia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLicencia.Location = New System.Drawing.Point(339, 80)
        Me.labelLicencia.Name = "labelLicencia"
        Me.labelLicencia.Size = New System.Drawing.Size(108, 25)
        Me.labelLicencia.TabIndex = 24
        Me.labelLicencia.Text = "LICENCIA#"
        '
        'textApellido
        '
        Me.textApellido.BackColor = System.Drawing.Color.Silver
        Me.textApellido.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textApellido.Location = New System.Drawing.Point(445, 35)
        Me.textApellido.Name = "textApellido"
        Me.textApellido.Size = New System.Drawing.Size(129, 31)
        Me.textApellido.TabIndex = 23
        '
        'labelApellido
        '
        Me.labelApellido.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelApellido.Location = New System.Drawing.Point(339, 40)
        Me.labelApellido.Name = "labelApellido"
        Me.labelApellido.Size = New System.Drawing.Size(100, 25)
        Me.labelApellido.TabIndex = 22
        Me.labelApellido.Text = "APELLIDO"
        '
        'textNacionalidad
        '
        Me.textNacionalidad.BackColor = System.Drawing.Color.Silver
        Me.textNacionalidad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textNacionalidad.Location = New System.Drawing.Point(154, 75)
        Me.textNacionalidad.Name = "textNacionalidad"
        Me.textNacionalidad.Size = New System.Drawing.Size(158, 31)
        Me.textNacionalidad.TabIndex = 21
        '
        'textLicencia
        '
        Me.textLicencia.BackColor = System.Drawing.Color.Silver
        Me.textLicencia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLicencia.Location = New System.Drawing.Point(453, 75)
        Me.textLicencia.Name = "textLicencia"
        Me.textLicencia.Size = New System.Drawing.Size(121, 31)
        Me.textLicencia.TabIndex = 13
        '
        'labelNombre
        '
        Me.labelNombre.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.Location = New System.Drawing.Point(6, 40)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(100, 25)
        Me.labelNombre.TabIndex = 0
        Me.labelNombre.Text = "NOMBRE"
        '
        'grupoDatosReserva
        '
        Me.grupoDatosReserva.BackColor = System.Drawing.Color.White
        Me.grupoDatosReserva.Controls.Add(Me.grupoDatosReservaTarifa)
        Me.grupoDatosReserva.Controls.Add(Me.grupoTipoAuto)
        Me.grupoDatosReserva.Controls.Add(Me.comboSucursales)
        Me.grupoDatosReserva.Controls.Add(Me.labelModeloVehiculo)
        Me.grupoDatosReserva.Controls.Add(Me.comboModeloOpciones)
        Me.grupoDatosReserva.Controls.Add(Me.labelLugarRetiro)
        Me.grupoDatosReserva.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoDatosReserva.Location = New System.Drawing.Point(12, 179)
        Me.grupoDatosReserva.Name = "grupoDatosReserva"
        Me.grupoDatosReserva.Size = New System.Drawing.Size(860, 294)
        Me.grupoDatosReserva.TabIndex = 1
        Me.grupoDatosReserva.TabStop = False
        Me.grupoDatosReserva.Text = "DATOS DE RESERVA"
        '
        'grupoDatosReservaTarifa
        '
        Me.grupoDatosReservaTarifa.BackColor = System.Drawing.Color.Transparent
        Me.grupoDatosReservaTarifa.Controls.Add(Me.comboMetodoPago)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.textoTiempoRentar)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.labelMetodoPago)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.grupoTarifaElegida)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.labelTiempoRentar)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.comboFechaRetiroAño)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.comboFechaRetiroMes)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.comboFechaRetiroDia)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.labelFechaRetiro)
        Me.grupoDatosReservaTarifa.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grupoDatosReservaTarifa.Location = New System.Drawing.Point(358, 0)
        Me.grupoDatosReservaTarifa.Name = "grupoDatosReservaTarifa"
        Me.grupoDatosReservaTarifa.Size = New System.Drawing.Size(496, 278)
        Me.grupoDatosReservaTarifa.TabIndex = 20
        Me.grupoDatosReservaTarifa.TabStop = False
        '
        'comboMetodoPago
        '
        Me.comboMetodoPago.BackColor = System.Drawing.Color.Silver
        Me.comboMetodoPago.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMetodoPago.FormattingEnabled = True
        Me.comboMetodoPago.Location = New System.Drawing.Point(6, 233)
        Me.comboMetodoPago.Name = "comboMetodoPago"
        Me.comboMetodoPago.Size = New System.Drawing.Size(324, 31)
        Me.comboMetodoPago.TabIndex = 22
        Me.comboMetodoPago.Text = "SELECCIONE UN METODO DE PAGO"
        '
        'textoTiempoRentar
        '
        Me.textoTiempoRentar.BackColor = System.Drawing.Color.Silver
        Me.textoTiempoRentar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textoTiempoRentar.Location = New System.Drawing.Point(170, 157)
        Me.textoTiempoRentar.Name = "textoTiempoRentar"
        Me.textoTiempoRentar.Size = New System.Drawing.Size(175, 31)
        Me.textoTiempoRentar.TabIndex = 25
        '
        'labelMetodoPago
        '
        Me.labelMetodoPago.AutoSize = True
        Me.labelMetodoPago.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMetodoPago.Location = New System.Drawing.Point(6, 207)
        Me.labelMetodoPago.Name = "labelMetodoPago"
        Me.labelMetodoPago.Size = New System.Drawing.Size(162, 23)
        Me.labelMetodoPago.TabIndex = 21
        Me.labelMetodoPago.Text = "METODO DE PAGO"
        '
        'grupoTarifaElegida
        '
        Me.grupoTarifaElegida.BackColor = System.Drawing.Color.Silver
        Me.grupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaDias)
        Me.grupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaSemanas)
        Me.grupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaMeses)
        Me.grupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaHoras)
        Me.grupoTarifaElegida.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoTarifaElegida.Location = New System.Drawing.Point(6, 30)
        Me.grupoTarifaElegida.Name = "grupoTarifaElegida"
        Me.grupoTarifaElegida.Size = New System.Drawing.Size(462, 86)
        Me.grupoTarifaElegida.TabIndex = 1
        Me.grupoTarifaElegida.TabStop = False
        Me.grupoTarifaElegida.Text = "TARIFA ELEGIDA"
        '
        'radioTarifaElegidaDias
        '
        Me.radioTarifaElegidaDias.AutoSize = True
        Me.radioTarifaElegidaDias.Location = New System.Drawing.Point(153, 36)
        Me.radioTarifaElegidaDias.Name = "radioTarifaElegidaDias"
        Me.radioTarifaElegidaDias.Size = New System.Drawing.Size(67, 27)
        Me.radioTarifaElegidaDias.TabIndex = 3
        Me.radioTarifaElegidaDias.TabStop = True
        Me.radioTarifaElegidaDias.Text = "DIAS"
        Me.radioTarifaElegidaDias.UseVisualStyleBackColor = True
        '
        'radioTarifaElegidaSemanas
        '
        Me.radioTarifaElegidaSemanas.AutoSize = True
        Me.radioTarifaElegidaSemanas.Location = New System.Drawing.Point(226, 36)
        Me.radioTarifaElegidaSemanas.Name = "radioTarifaElegidaSemanas"
        Me.radioTarifaElegidaSemanas.Size = New System.Drawing.Size(111, 27)
        Me.radioTarifaElegidaSemanas.TabIndex = 2
        Me.radioTarifaElegidaSemanas.TabStop = True
        Me.radioTarifaElegidaSemanas.Text = "SEMANAS"
        Me.radioTarifaElegidaSemanas.UseVisualStyleBackColor = True
        '
        'radioTarifaElegidaMeses
        '
        Me.radioTarifaElegidaMeses.AutoSize = True
        Me.radioTarifaElegidaMeses.Location = New System.Drawing.Point(343, 36)
        Me.radioTarifaElegidaMeses.Name = "radioTarifaElegidaMeses"
        Me.radioTarifaElegidaMeses.Size = New System.Drawing.Size(84, 27)
        Me.radioTarifaElegidaMeses.TabIndex = 1
        Me.radioTarifaElegidaMeses.TabStop = True
        Me.radioTarifaElegidaMeses.Text = "MESES"
        Me.radioTarifaElegidaMeses.UseVisualStyleBackColor = True
        '
        'radioTarifaElegidaHoras
        '
        Me.radioTarifaElegidaHoras.AutoSize = True
        Me.radioTarifaElegidaHoras.Location = New System.Drawing.Point(61, 36)
        Me.radioTarifaElegidaHoras.Name = "radioTarifaElegidaHoras"
        Me.radioTarifaElegidaHoras.Size = New System.Drawing.Size(86, 27)
        Me.radioTarifaElegidaHoras.TabIndex = 0
        Me.radioTarifaElegidaHoras.TabStop = True
        Me.radioTarifaElegidaHoras.Text = "HORAS"
        Me.radioTarifaElegidaHoras.UseVisualStyleBackColor = True
        '
        'labelTiempoRentar
        '
        Me.labelTiempoRentar.AutoSize = True
        Me.labelTiempoRentar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTiempoRentar.Location = New System.Drawing.Point(2, 157)
        Me.labelTiempoRentar.Name = "labelTiempoRentar"
        Me.labelTiempoRentar.Size = New System.Drawing.Size(162, 23)
        Me.labelTiempoRentar.TabIndex = 24
        Me.labelTiempoRentar.Text = "TIEMPO A RENTAR"
        '
        'comboFechaRetiroAño
        '
        Me.comboFechaRetiroAño.BackColor = System.Drawing.Color.Silver
        Me.comboFechaRetiroAño.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboFechaRetiroAño.FormattingEnabled = True
        Me.comboFechaRetiroAño.Items.AddRange(New Object() {"2021" & Global.Microsoft.VisualBasic.ChrW(9), "2022" & Global.Microsoft.VisualBasic.ChrW(9), "2023" & Global.Microsoft.VisualBasic.ChrW(9), "2024" & Global.Microsoft.VisualBasic.ChrW(9), "2025" & Global.Microsoft.VisualBasic.ChrW(9), "2026" & Global.Microsoft.VisualBasic.ChrW(9), "2027" & Global.Microsoft.VisualBasic.ChrW(9), "2028" & Global.Microsoft.VisualBasic.ChrW(9), "2029" & Global.Microsoft.VisualBasic.ChrW(9), "2030" & Global.Microsoft.VisualBasic.ChrW(9), "2031" & Global.Microsoft.VisualBasic.ChrW(9), "2032" & Global.Microsoft.VisualBasic.ChrW(9), "2033" & Global.Microsoft.VisualBasic.ChrW(9), "2034" & Global.Microsoft.VisualBasic.ChrW(9), "2035" & Global.Microsoft.VisualBasic.ChrW(9), "2036" & Global.Microsoft.VisualBasic.ChrW(9), "2037" & Global.Microsoft.VisualBasic.ChrW(9), "2038" & Global.Microsoft.VisualBasic.ChrW(9), "2039" & Global.Microsoft.VisualBasic.ChrW(9), "2040" & Global.Microsoft.VisualBasic.ChrW(9), "2041" & Global.Microsoft.VisualBasic.ChrW(9), "2042" & Global.Microsoft.VisualBasic.ChrW(9), "2043" & Global.Microsoft.VisualBasic.ChrW(9), "2044" & Global.Microsoft.VisualBasic.ChrW(9), "2045" & Global.Microsoft.VisualBasic.ChrW(9), "2046" & Global.Microsoft.VisualBasic.ChrW(9), "2047" & Global.Microsoft.VisualBasic.ChrW(9), "2048" & Global.Microsoft.VisualBasic.ChrW(9), "2049" & Global.Microsoft.VisualBasic.ChrW(9), "2050" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.comboFechaRetiroAño.Location = New System.Drawing.Point(361, 119)
        Me.comboFechaRetiroAño.Name = "comboFechaRetiroAño"
        Me.comboFechaRetiroAño.Size = New System.Drawing.Size(103, 31)
        Me.comboFechaRetiroAño.TabIndex = 23
        Me.comboFechaRetiroAño.Text = "AÑO"
        '
        'comboFechaRetiroMes
        '
        Me.comboFechaRetiroMes.BackColor = System.Drawing.Color.Silver
        Me.comboFechaRetiroMes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboFechaRetiroMes.FormattingEnabled = True
        Me.comboFechaRetiroMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.comboFechaRetiroMes.Location = New System.Drawing.Point(260, 119)
        Me.comboFechaRetiroMes.Name = "comboFechaRetiroMes"
        Me.comboFechaRetiroMes.Size = New System.Drawing.Size(95, 31)
        Me.comboFechaRetiroMes.TabIndex = 22
        Me.comboFechaRetiroMes.Text = "MES"
        '
        'comboFechaRetiroDia
        '
        Me.comboFechaRetiroDia.BackColor = System.Drawing.Color.Silver
        Me.comboFechaRetiroDia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboFechaRetiroDia.FormattingEnabled = True
        Me.comboFechaRetiroDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.comboFechaRetiroDia.Location = New System.Drawing.Point(171, 119)
        Me.comboFechaRetiroDia.Name = "comboFechaRetiroDia"
        Me.comboFechaRetiroDia.Size = New System.Drawing.Size(83, 31)
        Me.comboFechaRetiroDia.TabIndex = 21
        Me.comboFechaRetiroDia.Text = "DIA"
        '
        'labelFechaRetiro
        '
        Me.labelFechaRetiro.AutoSize = True
        Me.labelFechaRetiro.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFechaRetiro.Location = New System.Drawing.Point(2, 119)
        Me.labelFechaRetiro.Name = "labelFechaRetiro"
        Me.labelFechaRetiro.Size = New System.Drawing.Size(163, 23)
        Me.labelFechaRetiro.TabIndex = 20
        Me.labelFechaRetiro.Text = "FECHA DEL RETIRO"
        '
        'grupoTipoAuto
        '
        Me.grupoTipoAuto.BackColor = System.Drawing.Color.Silver
        Me.grupoTipoAuto.Controls.Add(Me.radioTipoVehiculoLujo)
        Me.grupoTipoAuto.Controls.Add(Me.radioTipoVehiculoFamiliar)
        Me.grupoTipoAuto.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoTipoAuto.Location = New System.Drawing.Point(16, 30)
        Me.grupoTipoAuto.Name = "grupoTipoAuto"
        Me.grupoTipoAuto.Size = New System.Drawing.Size(336, 86)
        Me.grupoTipoAuto.TabIndex = 0
        Me.grupoTipoAuto.TabStop = False
        Me.grupoTipoAuto.Text = "TIPO DE VEHICULO"
        '
        'radioTipoVehiculoLujo
        '
        Me.radioTipoVehiculoLujo.AutoSize = True
        Me.radioTipoVehiculoLujo.Location = New System.Drawing.Point(187, 36)
        Me.radioTipoVehiculoLujo.Name = "radioTipoVehiculoLujo"
        Me.radioTipoVehiculoLujo.Size = New System.Drawing.Size(71, 27)
        Me.radioTipoVehiculoLujo.TabIndex = 1
        Me.radioTipoVehiculoLujo.TabStop = True
        Me.radioTipoVehiculoLujo.Text = "LUJO"
        Me.radioTipoVehiculoLujo.UseVisualStyleBackColor = True
        '
        'radioTipoVehiculoFamiliar
        '
        Me.radioTipoVehiculoFamiliar.AutoSize = True
        Me.radioTipoVehiculoFamiliar.Location = New System.Drawing.Point(74, 36)
        Me.radioTipoVehiculoFamiliar.Name = "radioTipoVehiculoFamiliar"
        Me.radioTipoVehiculoFamiliar.Size = New System.Drawing.Size(107, 27)
        Me.radioTipoVehiculoFamiliar.TabIndex = 0
        Me.radioTipoVehiculoFamiliar.TabStop = True
        Me.radioTipoVehiculoFamiliar.Text = "FAMILIAR"
        Me.radioTipoVehiculoFamiliar.UseVisualStyleBackColor = True
        '
        'comboSucursales
        '
        Me.comboSucursales.BackColor = System.Drawing.Color.Silver
        Me.comboSucursales.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSucursales.FormattingEnabled = True
        Me.comboSucursales.Location = New System.Drawing.Point(16, 233)
        Me.comboSucursales.Name = "comboSucursales"
        Me.comboSucursales.Size = New System.Drawing.Size(324, 31)
        Me.comboSucursales.TabIndex = 19
        Me.comboSucursales.Text = "SELECCIONE UNA SUCURSAL"
        '
        'labelModeloVehiculo
        '
        Me.labelModeloVehiculo.AutoSize = True
        Me.labelModeloVehiculo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelModeloVehiculo.Location = New System.Drawing.Point(18, 119)
        Me.labelModeloVehiculo.Name = "labelModeloVehiculo"
        Me.labelModeloVehiculo.Size = New System.Drawing.Size(206, 23)
        Me.labelModeloVehiculo.TabIndex = 18
        Me.labelModeloVehiculo.Text = "MODELO DEL VEHICULO"
        '
        'comboModeloOpciones
        '
        Me.comboModeloOpciones.BackColor = System.Drawing.Color.Silver
        Me.comboModeloOpciones.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboModeloOpciones.FormattingEnabled = True
        Me.comboModeloOpciones.Location = New System.Drawing.Point(16, 157)
        Me.comboModeloOpciones.Name = "comboModeloOpciones"
        Me.comboModeloOpciones.Size = New System.Drawing.Size(232, 31)
        Me.comboModeloOpciones.TabIndex = 19
        Me.comboModeloOpciones.Text = "SELECCIONE EL MODELO"
        '
        'labelLugarRetiro
        '
        Me.labelLugarRetiro.AutoSize = True
        Me.labelLugarRetiro.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLugarRetiro.Location = New System.Drawing.Point(18, 207)
        Me.labelLugarRetiro.Name = "labelLugarRetiro"
        Me.labelLugarRetiro.Size = New System.Drawing.Size(268, 23)
        Me.labelLugarRetiro.TabIndex = 18
        Me.labelLugarRetiro.Text = "LUGAR A RETIRAR EL VEHICULO"
        '
        'botonReservar
        '
        Me.botonReservar.BackColor = System.Drawing.Color.White
        Me.botonReservar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.botonReservar.Location = New System.Drawing.Point(12, 479)
        Me.botonReservar.Name = "botonReservar"
        Me.botonReservar.Size = New System.Drawing.Size(243, 71)
        Me.botonReservar.TabIndex = 2
        Me.botonReservar.Text = "RESERVAR"
        Me.botonReservar.UseVisualStyleBackColor = False
        '
        'botonContinuar
        '
        Me.botonContinuar.BackColor = System.Drawing.Color.White
        Me.botonContinuar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.botonContinuar.Location = New System.Drawing.Point(322, 478)
        Me.botonContinuar.Name = "botonContinuar"
        Me.botonContinuar.Size = New System.Drawing.Size(243, 71)
        Me.botonContinuar.TabIndex = 3
        Me.botonContinuar.Text = "CONTINUAR"
        Me.botonContinuar.UseVisualStyleBackColor = False
        '
        'botonCancelar
        '
        Me.botonCancelar.BackColor = System.Drawing.Color.White
        Me.botonCancelar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.botonCancelar.Location = New System.Drawing.Point(623, 478)
        Me.botonCancelar.Name = "botonCancelar"
        Me.botonCancelar.Size = New System.Drawing.Size(243, 71)
        Me.botonCancelar.TabIndex = 4
        Me.botonCancelar.Text = "CANCELAR"
        Me.botonCancelar.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.botonCancelar)
        Me.Controls.Add(Me.botonContinuar)
        Me.Controls.Add(Me.botonReservar)
        Me.Controls.Add(Me.grupoDatosReserva)
        Me.Controls.Add(Me.grupoDetallesConductor)
        Me.Name = "Form5"
        Me.Text = "RESERVACION"
        Me.grupoDetallesConductor.ResumeLayout(False)
        Me.grupoDetallesConductor.PerformLayout()
        Me.grupoDatosReserva.ResumeLayout(False)
        Me.grupoDatosReserva.PerformLayout()
        Me.grupoDatosReservaTarifa.ResumeLayout(False)
        Me.grupoDatosReservaTarifa.PerformLayout()
        Me.grupoTarifaElegida.ResumeLayout(False)
        Me.grupoTarifaElegida.PerformLayout()
        Me.grupoTipoAuto.ResumeLayout(False)
        Me.grupoTipoAuto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grupoDetallesConductor As GroupBox
    Friend WithEvents textLicencia As TextBox
    Friend WithEvents labelNombre As Label
    Friend WithEvents grupoDatosReserva As GroupBox
    Friend WithEvents comboSucursales As ComboBox
    Friend WithEvents labelLugarRetiro As Label
    Friend WithEvents grupoTarifaElegida As GroupBox
    Friend WithEvents grupoTipoAuto As GroupBox
    Friend WithEvents radioTipoVehiculoLujo As RadioButton
    Friend WithEvents radioTipoVehiculoFamiliar As RadioButton
    Friend WithEvents radioTarifaElegidaDias As RadioButton
    Friend WithEvents radioTarifaElegidaSemanas As RadioButton
    Friend WithEvents radioTarifaElegidaMeses As RadioButton
    Friend WithEvents radioTarifaElegidaHoras As RadioButton
    Friend WithEvents botonReservar As Button
    Friend WithEvents botonContinuar As Button
    Friend WithEvents botonCancelar As Button
    Friend WithEvents textApellido As TextBox
    Friend WithEvents labelApellido As Label
    Friend WithEvents textNacionalidad As TextBox
    Friend WithEvents labelEdad As Label
    Friend WithEvents textEdad As TextBox
    Friend WithEvents labelNacionalidad As Label
    Friend WithEvents labelCedula As Label
    Friend WithEvents textCedula As TextBox
    Friend WithEvents textDireccion As TextBox
    Friend WithEvents labelDireccion As Label
    Friend WithEvents labelLicencia As Label
    Friend WithEvents grupoDatosReservaTarifa As GroupBox
    Friend WithEvents textoTiempoRentar As TextBox
    Friend WithEvents labelTiempoRentar As Label
    Friend WithEvents comboFechaRetiroAño As ComboBox
    Friend WithEvents comboFechaRetiroMes As ComboBox
    Friend WithEvents comboFechaRetiroDia As ComboBox
    Friend WithEvents labelFechaRetiro As Label
    Friend WithEvents comboModeloOpciones As ComboBox
    Friend WithEvents labelModeloVehiculo As Label
    Friend WithEvents textNombre As TextBox
    Friend WithEvents comboMetodoPago As ComboBox
    Friend WithEvents labelMetodoPago As Label
End Class
