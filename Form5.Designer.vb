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
        Me.GrupoDetallesConductor = New System.Windows.Forms.GroupBox()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.textEdad = New System.Windows.Forms.TextBox()
        Me.LabelNacionalidad = New System.Windows.Forms.Label()
        Me.LabelCedula = New System.Windows.Forms.Label()
        Me.textCedula = New System.Windows.Forms.TextBox()
        Me.textDireccion = New System.Windows.Forms.TextBox()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.LabelLicencia = New System.Windows.Forms.Label()
        Me.textApellido = New System.Windows.Forms.TextBox()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.textNacionalidad = New System.Windows.Forms.TextBox()
        Me.textLicencia = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.grupoDatosReserva = New System.Windows.Forms.GroupBox()
        Me.grupoDatosReservaTarifa = New System.Windows.Forms.GroupBox()
        Me.comboMetodoPago = New System.Windows.Forms.ComboBox()
        Me.textoTiempoRentar = New System.Windows.Forms.TextBox()
        Me.LabelMetodoPago = New System.Windows.Forms.Label()
        Me.GrupoTarifaElegida = New System.Windows.Forms.GroupBox()
        Me.radioTarifaElegidaDias = New System.Windows.Forms.RadioButton()
        Me.radioTarifaElegidaSemanas = New System.Windows.Forms.RadioButton()
        Me.radioTarifaElegidaMeses = New System.Windows.Forms.RadioButton()
        Me.radioTarifaElegidaHoras = New System.Windows.Forms.RadioButton()
        Me.LabelTiempoRentar = New System.Windows.Forms.Label()
        Me.comboFechaRetiroAño = New System.Windows.Forms.ComboBox()
        Me.comboFechaRetiroMes = New System.Windows.Forms.ComboBox()
        Me.comboFechaRetiroDia = New System.Windows.Forms.ComboBox()
        Me.LabelFechaRetiro = New System.Windows.Forms.Label()
        Me.GrupoTipoAuto = New System.Windows.Forms.GroupBox()
        Me.radioTipoVehiculoLujo = New System.Windows.Forms.RadioButton()
        Me.radioTipoVehiculoFamiliar = New System.Windows.Forms.RadioButton()
        Me.comboSucursales = New System.Windows.Forms.ComboBox()
        Me.LabelModeloVehiculo = New System.Windows.Forms.Label()
        Me.comboModeloOpciones = New System.Windows.Forms.ComboBox()
        Me.LabelLugarRetiro = New System.Windows.Forms.Label()
        Me.BotonReservar = New System.Windows.Forms.Button()
        Me.botonContinuar = New System.Windows.Forms.Button()
        Me.botonCancelar = New System.Windows.Forms.Button()
        Me.GrupoDetallesConductor.SuspendLayout()
        Me.grupoDatosReserva.SuspendLayout()
        Me.grupoDatosReservaTarifa.SuspendLayout()
        Me.GrupoTarifaElegida.SuspendLayout()
        Me.GrupoTipoAuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoDetallesConductor
        '
        Me.GrupoDetallesConductor.BackColor = System.Drawing.Color.White
        Me.GrupoDetallesConductor.Controls.Add(Me.textNombre)
        Me.GrupoDetallesConductor.Controls.Add(Me.textEdad)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelNacionalidad)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelCedula)
        Me.GrupoDetallesConductor.Controls.Add(Me.textCedula)
        Me.GrupoDetallesConductor.Controls.Add(Me.textDireccion)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelDireccion)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelEdad)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelLicencia)
        Me.GrupoDetallesConductor.Controls.Add(Me.textApellido)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelApellido)
        Me.GrupoDetallesConductor.Controls.Add(Me.textNacionalidad)
        Me.GrupoDetallesConductor.Controls.Add(Me.textLicencia)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelNombre)
        Me.GrupoDetallesConductor.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoDetallesConductor.Location = New System.Drawing.Point(12, 12)
        Me.GrupoDetallesConductor.Name = "GrupoDetallesConductor"
        Me.GrupoDetallesConductor.Size = New System.Drawing.Size(860, 161)
        Me.GrupoDetallesConductor.TabIndex = 0
        Me.GrupoDetallesConductor.TabStop = False
        Me.GrupoDetallesConductor.Text = "DETALLES DEL CONDUCTOR"
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
        'LabelNacionalidad
        '
        Me.LabelNacionalidad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNacionalidad.Location = New System.Drawing.Point(6, 80)
        Me.LabelNacionalidad.Name = "LabelNacionalidad"
        Me.LabelNacionalidad.Size = New System.Drawing.Size(142, 25)
        Me.LabelNacionalidad.TabIndex = 29
        Me.LabelNacionalidad.Text = "NACIONALIDAD"
        '
        'LabelCedula
        '
        Me.LabelCedula.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedula.Location = New System.Drawing.Point(601, 40)
        Me.LabelCedula.Name = "LabelCedula"
        Me.LabelCedula.Size = New System.Drawing.Size(90, 25)
        Me.LabelCedula.TabIndex = 28
        Me.LabelCedula.Text = "CÉDULA#"
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
        'LabelDireccion
        '
        Me.LabelDireccion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccion.Location = New System.Drawing.Point(6, 120)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(123, 25)
        Me.LabelDireccion.TabIndex = 25
        Me.LabelDireccion.Text = "DIRECCIÓN"
        '
        'LabelEdad
        '
        Me.LabelEdad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEdad.Location = New System.Drawing.Point(603, 80)
        Me.LabelEdad.Name = "LabelEdad"
        Me.LabelEdad.Size = New System.Drawing.Size(68, 25)
        Me.LabelEdad.TabIndex = 20
        Me.LabelEdad.Text = "EDAD"
        '
        'LabelLicencia
        '
        Me.LabelLicencia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicencia.Location = New System.Drawing.Point(339, 80)
        Me.LabelLicencia.Name = "LabelLicencia"
        Me.LabelLicencia.Size = New System.Drawing.Size(108, 25)
        Me.LabelLicencia.TabIndex = 24
        Me.LabelLicencia.Text = "LICENCIA#"
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
        'LabelApellido
        '
        Me.LabelApellido.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido.Location = New System.Drawing.Point(339, 40)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(100, 25)
        Me.LabelApellido.TabIndex = 22
        Me.LabelApellido.Text = "APELLIDO"
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
        'LabelNombre
        '
        Me.LabelNombre.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(6, 40)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(100, 25)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "NOMBRE"
        '
        'grupoDatosReserva
        '
        Me.grupoDatosReserva.BackColor = System.Drawing.Color.White
        Me.grupoDatosReserva.Controls.Add(Me.grupoDatosReservaTarifa)
        Me.grupoDatosReserva.Controls.Add(Me.GrupoTipoAuto)
        Me.grupoDatosReserva.Controls.Add(Me.comboSucursales)
        Me.grupoDatosReserva.Controls.Add(Me.LabelModeloVehiculo)
        Me.grupoDatosReserva.Controls.Add(Me.comboModeloOpciones)
        Me.grupoDatosReserva.Controls.Add(Me.LabelLugarRetiro)
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
        Me.grupoDatosReservaTarifa.Controls.Add(Me.LabelMetodoPago)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.GrupoTarifaElegida)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.LabelTiempoRentar)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.comboFechaRetiroAño)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.comboFechaRetiroMes)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.comboFechaRetiroDia)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.LabelFechaRetiro)
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
        'LabelMetodoPago
        '
        Me.LabelMetodoPago.AutoSize = True
        Me.LabelMetodoPago.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMetodoPago.Location = New System.Drawing.Point(6, 207)
        Me.LabelMetodoPago.Name = "LabelMetodoPago"
        Me.LabelMetodoPago.Size = New System.Drawing.Size(162, 23)
        Me.LabelMetodoPago.TabIndex = 21
        Me.LabelMetodoPago.Text = "METODO DE PAGO"
        '
        'GrupoTarifaElegida
        '
        Me.GrupoTarifaElegida.BackColor = System.Drawing.Color.Silver
        Me.GrupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaDias)
        Me.GrupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaSemanas)
        Me.GrupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaMeses)
        Me.GrupoTarifaElegida.Controls.Add(Me.radioTarifaElegidaHoras)
        Me.GrupoTarifaElegida.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoTarifaElegida.Location = New System.Drawing.Point(6, 30)
        Me.GrupoTarifaElegida.Name = "GrupoTarifaElegida"
        Me.GrupoTarifaElegida.Size = New System.Drawing.Size(462, 86)
        Me.GrupoTarifaElegida.TabIndex = 1
        Me.GrupoTarifaElegida.TabStop = False
        Me.GrupoTarifaElegida.Text = "TARIFA ELEGIDA"
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
        'LabelTiempoRentar
        '
        Me.LabelTiempoRentar.AutoSize = True
        Me.LabelTiempoRentar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTiempoRentar.Location = New System.Drawing.Point(2, 157)
        Me.LabelTiempoRentar.Name = "LabelTiempoRentar"
        Me.LabelTiempoRentar.Size = New System.Drawing.Size(162, 23)
        Me.LabelTiempoRentar.TabIndex = 24
        Me.LabelTiempoRentar.Text = "TIEMPO A RENTAR"
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
        'LabelFechaRetiro
        '
        Me.LabelFechaRetiro.AutoSize = True
        Me.LabelFechaRetiro.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaRetiro.Location = New System.Drawing.Point(2, 119)
        Me.LabelFechaRetiro.Name = "LabelFechaRetiro"
        Me.LabelFechaRetiro.Size = New System.Drawing.Size(163, 23)
        Me.LabelFechaRetiro.TabIndex = 20
        Me.LabelFechaRetiro.Text = "FECHA DEL RETIRO"
        '
        'GrupoTipoAuto
        '
        Me.GrupoTipoAuto.BackColor = System.Drawing.Color.Silver
        Me.GrupoTipoAuto.Controls.Add(Me.radioTipoVehiculoLujo)
        Me.GrupoTipoAuto.Controls.Add(Me.radioTipoVehiculoFamiliar)
        Me.GrupoTipoAuto.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoTipoAuto.Location = New System.Drawing.Point(16, 30)
        Me.GrupoTipoAuto.Name = "GrupoTipoAuto"
        Me.GrupoTipoAuto.Size = New System.Drawing.Size(336, 86)
        Me.GrupoTipoAuto.TabIndex = 0
        Me.GrupoTipoAuto.TabStop = False
        Me.GrupoTipoAuto.Text = "TIPO DE VEHICULO"
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
        'LabelModeloVehiculo
        '
        Me.LabelModeloVehiculo.AutoSize = True
        Me.LabelModeloVehiculo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModeloVehiculo.Location = New System.Drawing.Point(18, 119)
        Me.LabelModeloVehiculo.Name = "LabelModeloVehiculo"
        Me.LabelModeloVehiculo.Size = New System.Drawing.Size(206, 23)
        Me.LabelModeloVehiculo.TabIndex = 18
        Me.LabelModeloVehiculo.Text = "MODELO DEL VEHICULO"
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
        'LabelLugarRetiro
        '
        Me.LabelLugarRetiro.AutoSize = True
        Me.LabelLugarRetiro.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLugarRetiro.Location = New System.Drawing.Point(18, 207)
        Me.LabelLugarRetiro.Name = "LabelLugarRetiro"
        Me.LabelLugarRetiro.Size = New System.Drawing.Size(268, 23)
        Me.LabelLugarRetiro.TabIndex = 18
        Me.LabelLugarRetiro.Text = "LUGAR A RETIRAR EL VEHICULO"
        '
        'BotonReservar
        '
        Me.BotonReservar.BackColor = System.Drawing.Color.White
        Me.BotonReservar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BotonReservar.Location = New System.Drawing.Point(12, 479)
        Me.BotonReservar.Name = "BotonReservar"
        Me.BotonReservar.Size = New System.Drawing.Size(243, 71)
        Me.BotonReservar.TabIndex = 2
        Me.BotonReservar.Text = "RESERVAR"
        Me.BotonReservar.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.BotonReservar)
        Me.Controls.Add(Me.grupoDatosReserva)
        Me.Controls.Add(Me.GrupoDetallesConductor)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESERVACION"
        Me.GrupoDetallesConductor.ResumeLayout(False)
        Me.GrupoDetallesConductor.PerformLayout()
        Me.grupoDatosReserva.ResumeLayout(False)
        Me.grupoDatosReserva.PerformLayout()
        Me.grupoDatosReservaTarifa.ResumeLayout(False)
        Me.grupoDatosReservaTarifa.PerformLayout()
        Me.GrupoTarifaElegida.ResumeLayout(False)
        Me.GrupoTarifaElegida.PerformLayout()
        Me.GrupoTipoAuto.ResumeLayout(False)
        Me.GrupoTipoAuto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrupoDetallesConductor As GroupBox
    Friend WithEvents textLicencia As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents grupoDatosReserva As GroupBox
    Friend WithEvents comboSucursales As ComboBox
    Friend WithEvents LabelLugarRetiro As Label
    Friend WithEvents GrupoTarifaElegida As GroupBox
    Friend WithEvents GrupoTipoAuto As GroupBox
    Friend WithEvents radioTipoVehiculoLujo As RadioButton
    Friend WithEvents radioTipoVehiculoFamiliar As RadioButton
    Friend WithEvents radioTarifaElegidaDias As RadioButton
    Friend WithEvents radioTarifaElegidaSemanas As RadioButton
    Friend WithEvents radioTarifaElegidaMeses As RadioButton
    Friend WithEvents radioTarifaElegidaHoras As RadioButton
    Friend WithEvents BotonReservar As Button
    Friend WithEvents botonContinuar As Button
    Friend WithEvents botonCancelar As Button
    Friend WithEvents textApellido As TextBox
    Friend WithEvents LabelApellido As Label
    Friend WithEvents textNacionalidad As TextBox
    Friend WithEvents LabelEdad As Label
    Friend WithEvents textEdad As TextBox
    Friend WithEvents LabelNacionalidad As Label
    Friend WithEvents LabelCedula As Label
    Friend WithEvents textCedula As TextBox
    Friend WithEvents textDireccion As TextBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelLicencia As Label
    Friend WithEvents grupoDatosReservaTarifa As GroupBox
    Friend WithEvents textoTiempoRentar As TextBox
    Friend WithEvents LabelTiempoRentar As Label
    Friend WithEvents comboFechaRetiroAño As ComboBox
    Friend WithEvents comboFechaRetiroMes As ComboBox
    Friend WithEvents comboFechaRetiroDia As ComboBox
    Friend WithEvents LabelFechaRetiro As Label
    Friend WithEvents comboModeloOpciones As ComboBox
    Friend WithEvents LabelModeloVehiculo As Label
    Friend WithEvents textNombre As TextBox
    Friend WithEvents comboMetodoPago As ComboBox
    Friend WithEvents LabelMetodoPago As Label
End Class
