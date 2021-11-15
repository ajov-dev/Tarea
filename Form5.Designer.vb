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
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.TextoTelefono = New System.Windows.Forms.TextBox()
        Me.TextoNombre = New System.Windows.Forms.TextBox()
        Me.TextoEdad = New System.Windows.Forms.TextBox()
        Me.LabelNacionalidad = New System.Windows.Forms.Label()
        Me.LabelCedula = New System.Windows.Forms.Label()
        Me.TextoCedula = New System.Windows.Forms.TextBox()
        Me.TextoDireccion = New System.Windows.Forms.TextBox()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.LabelLicencia = New System.Windows.Forms.Label()
        Me.TextoApellido = New System.Windows.Forms.TextBox()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.TextoNacionalidad = New System.Windows.Forms.TextBox()
        Me.TextoLicencia = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.GrupoDatosReserva = New System.Windows.Forms.GroupBox()
        Me.grupoDatosReservaTarifa = New System.Windows.Forms.GroupBox()
        Me.ComboMetodoPago = New System.Windows.Forms.ComboBox()
        Me.TextoTiempoRentar = New System.Windows.Forms.TextBox()
        Me.LabelMetodoPago = New System.Windows.Forms.Label()
        Me.GrupoTarifaElegida = New System.Windows.Forms.GroupBox()
        Me.RadioTarifaElegidaDias = New System.Windows.Forms.RadioButton()
        Me.RadioTarifaElegidaSemanas = New System.Windows.Forms.RadioButton()
        Me.RadioTarifaElegidaMeses = New System.Windows.Forms.RadioButton()
        Me.RadioTarifaElegidaHoras = New System.Windows.Forms.RadioButton()
        Me.LabelTiempoRentar = New System.Windows.Forms.Label()
        Me.ComboFechaRetiroAño = New System.Windows.Forms.ComboBox()
        Me.ComboFechaRetiroMes = New System.Windows.Forms.ComboBox()
        Me.ComboFechaRetiroDia = New System.Windows.Forms.ComboBox()
        Me.LabelFechaRetiro = New System.Windows.Forms.Label()
        Me.GrupoTipoAuto = New System.Windows.Forms.GroupBox()
        Me.RadioTipoVehiculoLujo = New System.Windows.Forms.RadioButton()
        Me.RadioTipoVehiculoFamiliar = New System.Windows.Forms.RadioButton()
        Me.ComboSucursales = New System.Windows.Forms.ComboBox()
        Me.LabelModeloVehiculo = New System.Windows.Forms.Label()
        Me.ComboModeloOpciones = New System.Windows.Forms.ComboBox()
        Me.LabelLugarRetiro = New System.Windows.Forms.Label()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.GrupoDetallesConductor.SuspendLayout()
        Me.GrupoDatosReserva.SuspendLayout()
        Me.grupoDatosReservaTarifa.SuspendLayout()
        Me.GrupoTarifaElegida.SuspendLayout()
        Me.GrupoTipoAuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoDetallesConductor
        '
        Me.GrupoDetallesConductor.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelTelefono)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoTelefono)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoNombre)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoEdad)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelNacionalidad)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelCedula)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoCedula)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoDireccion)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelDireccion)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelEdad)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelLicencia)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoApellido)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelApellido)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoNacionalidad)
        Me.GrupoDetallesConductor.Controls.Add(Me.TextoLicencia)
        Me.GrupoDetallesConductor.Controls.Add(Me.LabelNombre)
        Me.GrupoDetallesConductor.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoDetallesConductor.Location = New System.Drawing.Point(12, 12)
        Me.GrupoDetallesConductor.Name = "GrupoDetallesConductor"
        Me.GrupoDetallesConductor.Size = New System.Drawing.Size(860, 161)
        Me.GrupoDetallesConductor.TabIndex = 0
        Me.GrupoDetallesConductor.TabStop = False
        Me.GrupoDetallesConductor.Text = "DETALLES DEL CONDUCTOR"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTelefono.Location = New System.Drawing.Point(603, 123)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(70, 25)
        Me.LabelTelefono.TabIndex = 51
        Me.LabelTelefono.Text = "TEL."
        '
        'TextoTelefono
        '
        Me.TextoTelefono.BackColor = System.Drawing.Color.White
        Me.TextoTelefono.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TextoTelefono.Location = New System.Drawing.Point(695, 115)
        Me.TextoTelefono.Name = "TextoTelefono"
        Me.TextoTelefono.Size = New System.Drawing.Size(133, 31)
        Me.TextoTelefono.TabIndex = 52
        '
        'TextoNombre
        '
        Me.TextoNombre.BackColor = System.Drawing.Color.White
        Me.TextoNombre.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNombre.Location = New System.Drawing.Point(154, 35)
        Me.TextoNombre.Name = "TextoNombre"
        Me.TextoNombre.Size = New System.Drawing.Size(158, 31)
        Me.TextoNombre.TabIndex = 33
        '
        'TextoEdad
        '
        Me.TextoEdad.BackColor = System.Drawing.Color.White
        Me.TextoEdad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoEdad.Location = New System.Drawing.Point(695, 75)
        Me.TextoEdad.Name = "TextoEdad"
        Me.TextoEdad.Size = New System.Drawing.Size(133, 31)
        Me.TextoEdad.TabIndex = 30
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
        'TextoCedula
        '
        Me.TextoCedula.BackColor = System.Drawing.Color.White
        Me.TextoCedula.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoCedula.Location = New System.Drawing.Point(697, 35)
        Me.TextoCedula.Name = "TextoCedula"
        Me.TextoCedula.Size = New System.Drawing.Size(131, 31)
        Me.TextoCedula.TabIndex = 27
        '
        'TextoDireccion
        '
        Me.TextoDireccion.BackColor = System.Drawing.Color.White
        Me.TextoDireccion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoDireccion.Location = New System.Drawing.Point(154, 115)
        Me.TextoDireccion.Name = "TextoDireccion"
        Me.TextoDireccion.Size = New System.Drawing.Size(420, 31)
        Me.TextoDireccion.TabIndex = 26
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
        'TextoApellido
        '
        Me.TextoApellido.BackColor = System.Drawing.Color.White
        Me.TextoApellido.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoApellido.Location = New System.Drawing.Point(453, 35)
        Me.TextoApellido.Name = "TextoApellido"
        Me.TextoApellido.Size = New System.Drawing.Size(121, 31)
        Me.TextoApellido.TabIndex = 23
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
        'TextoNacionalidad
        '
        Me.TextoNacionalidad.BackColor = System.Drawing.Color.White
        Me.TextoNacionalidad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNacionalidad.Location = New System.Drawing.Point(154, 75)
        Me.TextoNacionalidad.Name = "TextoNacionalidad"
        Me.TextoNacionalidad.Size = New System.Drawing.Size(158, 31)
        Me.TextoNacionalidad.TabIndex = 21
        '
        'TextoLicencia
        '
        Me.TextoLicencia.BackColor = System.Drawing.Color.White
        Me.TextoLicencia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoLicencia.Location = New System.Drawing.Point(453, 75)
        Me.TextoLicencia.Name = "TextoLicencia"
        Me.TextoLicencia.Size = New System.Drawing.Size(121, 31)
        Me.TextoLicencia.TabIndex = 13
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
        'GrupoDatosReserva
        '
        Me.GrupoDatosReserva.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GrupoDatosReserva.Controls.Add(Me.grupoDatosReservaTarifa)
        Me.GrupoDatosReserva.Controls.Add(Me.GrupoTipoAuto)
        Me.GrupoDatosReserva.Controls.Add(Me.ComboSucursales)
        Me.GrupoDatosReserva.Controls.Add(Me.LabelModeloVehiculo)
        Me.GrupoDatosReserva.Controls.Add(Me.ComboModeloOpciones)
        Me.GrupoDatosReserva.Controls.Add(Me.LabelLugarRetiro)
        Me.GrupoDatosReserva.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoDatosReserva.Location = New System.Drawing.Point(12, 179)
        Me.GrupoDatosReserva.Name = "GrupoDatosReserva"
        Me.GrupoDatosReserva.Size = New System.Drawing.Size(860, 294)
        Me.GrupoDatosReserva.TabIndex = 1
        Me.GrupoDatosReserva.TabStop = False
        Me.GrupoDatosReserva.Text = "DATOS DE RESERVA"
        '
        'grupoDatosReservaTarifa
        '
        Me.grupoDatosReservaTarifa.BackColor = System.Drawing.Color.Transparent
        Me.grupoDatosReservaTarifa.Controls.Add(Me.ComboMetodoPago)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.TextoTiempoRentar)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.LabelMetodoPago)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.GrupoTarifaElegida)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.LabelTiempoRentar)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.ComboFechaRetiroAño)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.ComboFechaRetiroMes)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.ComboFechaRetiroDia)
        Me.grupoDatosReservaTarifa.Controls.Add(Me.LabelFechaRetiro)
        Me.grupoDatosReservaTarifa.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.grupoDatosReservaTarifa.Location = New System.Drawing.Point(358, 3)
        Me.grupoDatosReservaTarifa.Name = "grupoDatosReservaTarifa"
        Me.grupoDatosReservaTarifa.Size = New System.Drawing.Size(496, 277)
        Me.grupoDatosReservaTarifa.TabIndex = 20
        Me.grupoDatosReservaTarifa.TabStop = False
        '
        'ComboMetodoPago
        '
        Me.ComboMetodoPago.BackColor = System.Drawing.Color.Silver
        Me.ComboMetodoPago.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMetodoPago.FormattingEnabled = True
        Me.ComboMetodoPago.Location = New System.Drawing.Point(6, 233)
        Me.ComboMetodoPago.Name = "ComboMetodoPago"
        Me.ComboMetodoPago.Size = New System.Drawing.Size(324, 31)
        Me.ComboMetodoPago.TabIndex = 22
        Me.ComboMetodoPago.Text = "SELECCIONE UN METODO DE PAGO"
        '
        'TextoTiempoRentar
        '
        Me.TextoTiempoRentar.BackColor = System.Drawing.Color.Silver
        Me.TextoTiempoRentar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoTiempoRentar.Location = New System.Drawing.Point(171, 153)
        Me.TextoTiempoRentar.Name = "TextoTiempoRentar"
        Me.TextoTiempoRentar.Size = New System.Drawing.Size(175, 31)
        Me.TextoTiempoRentar.TabIndex = 25
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
        Me.GrupoTarifaElegida.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.GrupoTarifaElegida.Controls.Add(Me.RadioTarifaElegidaDias)
        Me.GrupoTarifaElegida.Controls.Add(Me.RadioTarifaElegidaSemanas)
        Me.GrupoTarifaElegida.Controls.Add(Me.RadioTarifaElegidaMeses)
        Me.GrupoTarifaElegida.Controls.Add(Me.RadioTarifaElegidaHoras)
        Me.GrupoTarifaElegida.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoTarifaElegida.ForeColor = System.Drawing.Color.White
        Me.GrupoTarifaElegida.Location = New System.Drawing.Point(6, 30)
        Me.GrupoTarifaElegida.Name = "GrupoTarifaElegida"
        Me.GrupoTarifaElegida.Size = New System.Drawing.Size(462, 86)
        Me.GrupoTarifaElegida.TabIndex = 1
        Me.GrupoTarifaElegida.TabStop = False
        Me.GrupoTarifaElegida.Text = "TARIFA ELEGIDA"
        '
        'RadioTarifaElegidaDias
        '
        Me.RadioTarifaElegidaDias.AutoSize = True
        Me.RadioTarifaElegidaDias.Location = New System.Drawing.Point(153, 36)
        Me.RadioTarifaElegidaDias.Name = "RadioTarifaElegidaDias"
        Me.RadioTarifaElegidaDias.Size = New System.Drawing.Size(67, 27)
        Me.RadioTarifaElegidaDias.TabIndex = 3
        Me.RadioTarifaElegidaDias.TabStop = True
        Me.RadioTarifaElegidaDias.Text = "DIAS"
        Me.RadioTarifaElegidaDias.UseVisualStyleBackColor = True
        '
        'RadioTarifaElegidaSemanas
        '
        Me.RadioTarifaElegidaSemanas.AutoSize = True
        Me.RadioTarifaElegidaSemanas.Location = New System.Drawing.Point(226, 36)
        Me.RadioTarifaElegidaSemanas.Name = "RadioTarifaElegidaSemanas"
        Me.RadioTarifaElegidaSemanas.Size = New System.Drawing.Size(111, 27)
        Me.RadioTarifaElegidaSemanas.TabIndex = 2
        Me.RadioTarifaElegidaSemanas.TabStop = True
        Me.RadioTarifaElegidaSemanas.Text = "SEMANAS"
        Me.RadioTarifaElegidaSemanas.UseVisualStyleBackColor = True
        '
        'RadioTarifaElegidaMeses
        '
        Me.RadioTarifaElegidaMeses.AutoSize = True
        Me.RadioTarifaElegidaMeses.Location = New System.Drawing.Point(343, 36)
        Me.RadioTarifaElegidaMeses.Name = "RadioTarifaElegidaMeses"
        Me.RadioTarifaElegidaMeses.Size = New System.Drawing.Size(84, 27)
        Me.RadioTarifaElegidaMeses.TabIndex = 1
        Me.RadioTarifaElegidaMeses.TabStop = True
        Me.RadioTarifaElegidaMeses.Text = "MESES"
        Me.RadioTarifaElegidaMeses.UseVisualStyleBackColor = True
        '
        'RadioTarifaElegidaHoras
        '
        Me.RadioTarifaElegidaHoras.AutoSize = True
        Me.RadioTarifaElegidaHoras.Location = New System.Drawing.Point(61, 36)
        Me.RadioTarifaElegidaHoras.Name = "RadioTarifaElegidaHoras"
        Me.RadioTarifaElegidaHoras.Size = New System.Drawing.Size(86, 27)
        Me.RadioTarifaElegidaHoras.TabIndex = 0
        Me.RadioTarifaElegidaHoras.TabStop = True
        Me.RadioTarifaElegidaHoras.Text = "HORAS"
        Me.RadioTarifaElegidaHoras.UseVisualStyleBackColor = True
        '
        'LabelTiempoRentar
        '
        Me.LabelTiempoRentar.AutoSize = True
        Me.LabelTiempoRentar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTiempoRentar.Location = New System.Drawing.Point(6, 161)
        Me.LabelTiempoRentar.Name = "LabelTiempoRentar"
        Me.LabelTiempoRentar.Size = New System.Drawing.Size(162, 23)
        Me.LabelTiempoRentar.TabIndex = 24
        Me.LabelTiempoRentar.Text = "TIEMPO A RENTAR"
        '
        'ComboFechaRetiroAño
        '
        Me.ComboFechaRetiroAño.BackColor = System.Drawing.Color.Silver
        Me.ComboFechaRetiroAño.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboFechaRetiroAño.FormattingEnabled = True
        Me.ComboFechaRetiroAño.Items.AddRange(New Object() {"2021" & Global.Microsoft.VisualBasic.ChrW(9), "2022" & Global.Microsoft.VisualBasic.ChrW(9), "2023" & Global.Microsoft.VisualBasic.ChrW(9), "2024" & Global.Microsoft.VisualBasic.ChrW(9), "2025" & Global.Microsoft.VisualBasic.ChrW(9), "2026" & Global.Microsoft.VisualBasic.ChrW(9), "2027" & Global.Microsoft.VisualBasic.ChrW(9), "2028" & Global.Microsoft.VisualBasic.ChrW(9), "2029" & Global.Microsoft.VisualBasic.ChrW(9), "2030" & Global.Microsoft.VisualBasic.ChrW(9), "2031" & Global.Microsoft.VisualBasic.ChrW(9), "2032" & Global.Microsoft.VisualBasic.ChrW(9), "2033" & Global.Microsoft.VisualBasic.ChrW(9), "2034" & Global.Microsoft.VisualBasic.ChrW(9), "2035" & Global.Microsoft.VisualBasic.ChrW(9), "2036" & Global.Microsoft.VisualBasic.ChrW(9), "2037" & Global.Microsoft.VisualBasic.ChrW(9), "2038" & Global.Microsoft.VisualBasic.ChrW(9), "2039" & Global.Microsoft.VisualBasic.ChrW(9), "2040" & Global.Microsoft.VisualBasic.ChrW(9), "2041" & Global.Microsoft.VisualBasic.ChrW(9), "2042" & Global.Microsoft.VisualBasic.ChrW(9), "2043" & Global.Microsoft.VisualBasic.ChrW(9), "2044" & Global.Microsoft.VisualBasic.ChrW(9), "2045" & Global.Microsoft.VisualBasic.ChrW(9), "2046" & Global.Microsoft.VisualBasic.ChrW(9), "2047" & Global.Microsoft.VisualBasic.ChrW(9), "2048" & Global.Microsoft.VisualBasic.ChrW(9), "2049" & Global.Microsoft.VisualBasic.ChrW(9), "2050" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboFechaRetiroAño.Location = New System.Drawing.Point(361, 119)
        Me.ComboFechaRetiroAño.Name = "ComboFechaRetiroAño"
        Me.ComboFechaRetiroAño.Size = New System.Drawing.Size(103, 31)
        Me.ComboFechaRetiroAño.TabIndex = 23
        Me.ComboFechaRetiroAño.Text = "AÑO"
        '
        'ComboFechaRetiroMes
        '
        Me.ComboFechaRetiroMes.BackColor = System.Drawing.Color.Silver
        Me.ComboFechaRetiroMes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboFechaRetiroMes.FormattingEnabled = True
        Me.ComboFechaRetiroMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboFechaRetiroMes.Location = New System.Drawing.Point(260, 119)
        Me.ComboFechaRetiroMes.Name = "ComboFechaRetiroMes"
        Me.ComboFechaRetiroMes.Size = New System.Drawing.Size(95, 31)
        Me.ComboFechaRetiroMes.TabIndex = 22
        Me.ComboFechaRetiroMes.Text = "MES"
        '
        'ComboFechaRetiroDia
        '
        Me.ComboFechaRetiroDia.BackColor = System.Drawing.Color.Silver
        Me.ComboFechaRetiroDia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboFechaRetiroDia.FormattingEnabled = True
        Me.ComboFechaRetiroDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboFechaRetiroDia.Location = New System.Drawing.Point(171, 119)
        Me.ComboFechaRetiroDia.Name = "ComboFechaRetiroDia"
        Me.ComboFechaRetiroDia.Size = New System.Drawing.Size(83, 31)
        Me.ComboFechaRetiroDia.TabIndex = 21
        Me.ComboFechaRetiroDia.Text = "DIA"
        '
        'LabelFechaRetiro
        '
        Me.LabelFechaRetiro.AutoSize = True
        Me.LabelFechaRetiro.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaRetiro.Location = New System.Drawing.Point(6, 127)
        Me.LabelFechaRetiro.Name = "LabelFechaRetiro"
        Me.LabelFechaRetiro.Size = New System.Drawing.Size(163, 23)
        Me.LabelFechaRetiro.TabIndex = 20
        Me.LabelFechaRetiro.Text = "FECHA DEL RETIRO"
        '
        'GrupoTipoAuto
        '
        Me.GrupoTipoAuto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.GrupoTipoAuto.Controls.Add(Me.RadioTipoVehiculoLujo)
        Me.GrupoTipoAuto.Controls.Add(Me.RadioTipoVehiculoFamiliar)
        Me.GrupoTipoAuto.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoTipoAuto.ForeColor = System.Drawing.Color.White
        Me.GrupoTipoAuto.Location = New System.Drawing.Point(16, 30)
        Me.GrupoTipoAuto.Name = "GrupoTipoAuto"
        Me.GrupoTipoAuto.Size = New System.Drawing.Size(336, 86)
        Me.GrupoTipoAuto.TabIndex = 0
        Me.GrupoTipoAuto.TabStop = False
        Me.GrupoTipoAuto.Text = "TIPO DE VEHICULO"
        '
        'RadioTipoVehiculoLujo
        '
        Me.RadioTipoVehiculoLujo.AutoSize = True
        Me.RadioTipoVehiculoLujo.Location = New System.Drawing.Point(187, 36)
        Me.RadioTipoVehiculoLujo.Name = "RadioTipoVehiculoLujo"
        Me.RadioTipoVehiculoLujo.Size = New System.Drawing.Size(71, 27)
        Me.RadioTipoVehiculoLujo.TabIndex = 1
        Me.RadioTipoVehiculoLujo.TabStop = True
        Me.RadioTipoVehiculoLujo.Text = "LUJO"
        Me.RadioTipoVehiculoLujo.UseVisualStyleBackColor = True
        '
        'RadioTipoVehiculoFamiliar
        '
        Me.RadioTipoVehiculoFamiliar.AutoSize = True
        Me.RadioTipoVehiculoFamiliar.Location = New System.Drawing.Point(74, 36)
        Me.RadioTipoVehiculoFamiliar.Name = "RadioTipoVehiculoFamiliar"
        Me.RadioTipoVehiculoFamiliar.Size = New System.Drawing.Size(107, 27)
        Me.RadioTipoVehiculoFamiliar.TabIndex = 0
        Me.RadioTipoVehiculoFamiliar.TabStop = True
        Me.RadioTipoVehiculoFamiliar.Text = "FAMILIAR"
        Me.RadioTipoVehiculoFamiliar.UseVisualStyleBackColor = True
        '
        'ComboSucursales
        '
        Me.ComboSucursales.BackColor = System.Drawing.Color.Silver
        Me.ComboSucursales.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSucursales.FormattingEnabled = True
        Me.ComboSucursales.Location = New System.Drawing.Point(16, 233)
        Me.ComboSucursales.Name = "ComboSucursales"
        Me.ComboSucursales.Size = New System.Drawing.Size(324, 31)
        Me.ComboSucursales.TabIndex = 19
        Me.ComboSucursales.Text = "SELECCIONE UNA SUCURSAL"
        '
        'LabelModeloVehiculo
        '
        Me.LabelModeloVehiculo.AutoSize = True
        Me.LabelModeloVehiculo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModeloVehiculo.Location = New System.Drawing.Point(18, 127)
        Me.LabelModeloVehiculo.Name = "LabelModeloVehiculo"
        Me.LabelModeloVehiculo.Size = New System.Drawing.Size(206, 23)
        Me.LabelModeloVehiculo.TabIndex = 18
        Me.LabelModeloVehiculo.Text = "MODELO DEL VEHICULO"
        '
        'ComboModeloOpciones
        '
        Me.ComboModeloOpciones.BackColor = System.Drawing.Color.Silver
        Me.ComboModeloOpciones.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboModeloOpciones.FormattingEnabled = True
        Me.ComboModeloOpciones.Location = New System.Drawing.Point(16, 153)
        Me.ComboModeloOpciones.Name = "ComboModeloOpciones"
        Me.ComboModeloOpciones.Size = New System.Drawing.Size(232, 31)
        Me.ComboModeloOpciones.TabIndex = 19
        Me.ComboModeloOpciones.Text = "SELECCIONE EL MODELO"
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
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.Location = New System.Drawing.Point(100, 500)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(250, 50)
        Me.BotonCancelar.TabIndex = 55
        Me.BotonCancelar.Text = "C&ANCELAR"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'BotonContinuar
        '
        Me.BotonContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonContinuar.ForeColor = System.Drawing.Color.White
        Me.BotonContinuar.Location = New System.Drawing.Point(500, 500)
        Me.BotonContinuar.Name = "BotonContinuar"
        Me.BotonContinuar.Size = New System.Drawing.Size(250, 50)
        Me.BotonContinuar.TabIndex = 54
        Me.BotonContinuar.Text = "&CONTINUAR"
        Me.BotonContinuar.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.GrupoDatosReserva)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.GrupoDetallesConductor)
        Me.Controls.Add(Me.BotonContinuar)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESERVACION"
        Me.GrupoDetallesConductor.ResumeLayout(False)
        Me.GrupoDetallesConductor.PerformLayout()
        Me.GrupoDatosReserva.ResumeLayout(False)
        Me.GrupoDatosReserva.PerformLayout()
        Me.grupoDatosReservaTarifa.ResumeLayout(False)
        Me.grupoDatosReservaTarifa.PerformLayout()
        Me.GrupoTarifaElegida.ResumeLayout(False)
        Me.GrupoTarifaElegida.PerformLayout()
        Me.GrupoTipoAuto.ResumeLayout(False)
        Me.GrupoTipoAuto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrupoDetallesConductor As GroupBox
    Friend WithEvents TextoLicencia As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents GrupoDatosReserva As GroupBox
    Friend WithEvents ComboSucursales As ComboBox
    Friend WithEvents LabelLugarRetiro As Label
    Friend WithEvents GrupoTarifaElegida As GroupBox
    Friend WithEvents GrupoTipoAuto As GroupBox
    Friend WithEvents RadioTipoVehiculoLujo As RadioButton
    Friend WithEvents RadioTipoVehiculoFamiliar As RadioButton
    Friend WithEvents RadioTarifaElegidaDias As RadioButton
    Friend WithEvents RadioTarifaElegidaSemanas As RadioButton
    Friend WithEvents RadioTarifaElegidaMeses As RadioButton
    Friend WithEvents RadioTarifaElegidaHoras As RadioButton
    Friend WithEvents TextoApellido As TextBox
    Friend WithEvents LabelApellido As Label
    Friend WithEvents TextoNacionalidad As TextBox
    Friend WithEvents LabelEdad As Label
    Friend WithEvents TextoEdad As TextBox
    Friend WithEvents LabelNacionalidad As Label
    Friend WithEvents LabelCedula As Label
    Friend WithEvents TextoCedula As TextBox
    Friend WithEvents TextoDireccion As TextBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelLicencia As Label
    Friend WithEvents grupoDatosReservaTarifa As GroupBox
    Friend WithEvents TextoTiempoRentar As TextBox
    Friend WithEvents LabelTiempoRentar As Label
    Friend WithEvents ComboFechaRetiroAño As ComboBox
    Friend WithEvents ComboFechaRetiroMes As ComboBox
    Friend WithEvents ComboFechaRetiroDia As ComboBox
    Friend WithEvents LabelFechaRetiro As Label
    Friend WithEvents ComboModeloOpciones As ComboBox
    Friend WithEvents LabelModeloVehiculo As Label
    Friend WithEvents TextoNombre As TextBox
    Friend WithEvents ComboMetodoPago As ComboBox
    Friend WithEvents LabelMetodoPago As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents TextoTelefono As TextBox
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents BotonContinuar As Button
End Class
