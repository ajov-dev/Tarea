﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelModelo = New System.Windows.Forms.Label()
        Me.GrupoReservacion = New System.Windows.Forms.GroupBox()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.TextoTelefono = New System.Windows.Forms.TextBox()
        Me.TextoNombre = New System.Windows.Forms.TextBox()
        Me.TextoEdad = New System.Windows.Forms.TextBox()
        Me.LabelNacionalidad = New System.Windows.Forms.Label()
        Me.LabelCedula = New System.Windows.Forms.Label()
        Me.TextoCedula = New System.Windows.Forms.TextBox()
        Me.TextoDireccion = New System.Windows.Forms.TextBox()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.LabelLicencia = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.TextoApellido = New System.Windows.Forms.TextBox()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.TextoNacionalidad = New System.Windows.Forms.TextBox()
        Me.TextoLicencia = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.GrupoDatosDelVehiculo = New System.Windows.Forms.GroupBox()
        Me.TextoTotalPagar = New System.Windows.Forms.TextBox()
        Me.TextoImpuesto = New System.Windows.Forms.TextBox()
        Me.TextoCosto = New System.Windows.Forms.TextBox()
        Me.TextoTiempoRentar = New System.Windows.Forms.TextBox()
        Me.TextoSucursal = New System.Windows.Forms.TextBox()
        Me.TextoFechaRetiro = New System.Windows.Forms.TextBox()
        Me.TextoMetodoPago = New System.Windows.Forms.TextBox()
        Me.TextoTarifaElegida = New System.Windows.Forms.TextBox()
        Me.TextoModelo = New System.Windows.Forms.TextBox()
        Me.LabelTiempoRentar = New System.Windows.Forms.Label()
        Me.LabelCosto = New System.Windows.Forms.Label()
        Me.LabelItbms = New System.Windows.Forms.Label()
        Me.LabelTotalPagar = New System.Windows.Forms.Label()
        Me.LabelFechaRetiro = New System.Windows.Forms.Label()
        Me.LabelSucursal = New System.Windows.Forms.Label()
        Me.LabelMetodoPago = New System.Windows.Forms.Label()
        Me.LabelTarifa = New System.Windows.Forms.Label()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.GrupoReservacion.SuspendLayout()
        Me.GrupoDatosDelVehiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelModelo
        '
        Me.LabelModelo.AutoSize = True
        Me.LabelModelo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModelo.Location = New System.Drawing.Point(6, 42)
        Me.LabelModelo.Name = "LabelModelo"
        Me.LabelModelo.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelModelo.Size = New System.Drawing.Size(103, 43)
        Me.LabelModelo.TabIndex = 18
        Me.LabelModelo.Text = "MODELO"
        '
        'GrupoReservacion
        '
        Me.GrupoReservacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GrupoReservacion.Controls.Add(Me.LabelTelefono)
        Me.GrupoReservacion.Controls.Add(Me.TextoTelefono)
        Me.GrupoReservacion.Controls.Add(Me.TextoNombre)
        Me.GrupoReservacion.Controls.Add(Me.TextoEdad)
        Me.GrupoReservacion.Controls.Add(Me.LabelNacionalidad)
        Me.GrupoReservacion.Controls.Add(Me.LabelCedula)
        Me.GrupoReservacion.Controls.Add(Me.TextoCedula)
        Me.GrupoReservacion.Controls.Add(Me.TextoDireccion)
        Me.GrupoReservacion.Controls.Add(Me.LabelEdad)
        Me.GrupoReservacion.Controls.Add(Me.LabelLicencia)
        Me.GrupoReservacion.Controls.Add(Me.LabelDireccion)
        Me.GrupoReservacion.Controls.Add(Me.TextoApellido)
        Me.GrupoReservacion.Controls.Add(Me.LabelApellido)
        Me.GrupoReservacion.Controls.Add(Me.TextoNacionalidad)
        Me.GrupoReservacion.Controls.Add(Me.TextoLicencia)
        Me.GrupoReservacion.Controls.Add(Me.LabelNombre)
        Me.GrupoReservacion.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold)
        Me.GrupoReservacion.Location = New System.Drawing.Point(10, 10)
        Me.GrupoReservacion.Name = "GrupoReservacion"
        Me.GrupoReservacion.Size = New System.Drawing.Size(862, 160)
        Me.GrupoReservacion.TabIndex = 5
        Me.GrupoReservacion.TabStop = False
        Me.GrupoReservacion.Text = "DETALLES DEL CONDUCTOR"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.Location = New System.Drawing.Point(605, 79)
        Me.LabelTelefono.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelTelefono.Size = New System.Drawing.Size(54, 33)
        Me.LabelTelefono.TabIndex = 5
        Me.LabelTelefono.Text = "TEL."
        '
        'TextoTelefono
        '
        Me.TextoTelefono.BackColor = System.Drawing.Color.White
        Me.TextoTelefono.Enabled = False
        Me.TextoTelefono.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoTelefono.Location = New System.Drawing.Point(674, 76)
        Me.TextoTelefono.Name = "TextoTelefono"
        Me.TextoTelefono.Size = New System.Drawing.Size(147, 31)
        Me.TextoTelefono.TabIndex = 50
        '
        'TextoNombre
        '
        Me.TextoNombre.BackColor = System.Drawing.Color.White
        Me.TextoNombre.Enabled = False
        Me.TextoNombre.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNombre.Location = New System.Drawing.Point(136, 39)
        Me.TextoNombre.Name = "TextoNombre"
        Me.TextoNombre.Size = New System.Drawing.Size(147, 31)
        Me.TextoNombre.TabIndex = 33
        '
        'TextoEdad
        '
        Me.TextoEdad.BackColor = System.Drawing.Color.White
        Me.TextoEdad.Enabled = False
        Me.TextoEdad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoEdad.Location = New System.Drawing.Point(674, 39)
        Me.TextoEdad.Name = "TextoEdad"
        Me.TextoEdad.Size = New System.Drawing.Size(147, 31)
        Me.TextoEdad.TabIndex = 30
        '
        'LabelNacionalidad
        '
        Me.LabelNacionalidad.AutoSize = True
        Me.LabelNacionalidad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNacionalidad.Location = New System.Drawing.Point(286, 37)
        Me.LabelNacionalidad.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNacionalidad.Name = "LabelNacionalidad"
        Me.LabelNacionalidad.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelNacionalidad.Size = New System.Drawing.Size(149, 33)
        Me.LabelNacionalidad.TabIndex = 29
        Me.LabelNacionalidad.Text = "NACIONALIDAD"
        '
        'LabelCedula
        '
        Me.LabelCedula.AutoSize = True
        Me.LabelCedula.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedula.Location = New System.Drawing.Point(15, 113)
        Me.LabelCedula.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCedula.Name = "LabelCedula"
        Me.LabelCedula.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelCedula.Size = New System.Drawing.Size(87, 33)
        Me.LabelCedula.TabIndex = 28
        Me.LabelCedula.Text = "CÉDULA"
        '
        'TextoCedula
        '
        Me.TextoCedula.BackColor = System.Drawing.Color.White
        Me.TextoCedula.Enabled = False
        Me.TextoCedula.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoCedula.Location = New System.Drawing.Point(136, 113)
        Me.TextoCedula.Name = "TextoCedula"
        Me.TextoCedula.Size = New System.Drawing.Size(147, 31)
        Me.TextoCedula.TabIndex = 27
        '
        'TextoDireccion
        '
        Me.TextoDireccion.BackColor = System.Drawing.Color.White
        Me.TextoDireccion.Enabled = False
        Me.TextoDireccion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoDireccion.Location = New System.Drawing.Point(438, 113)
        Me.TextoDireccion.Name = "TextoDireccion"
        Me.TextoDireccion.Size = New System.Drawing.Size(383, 31)
        Me.TextoDireccion.TabIndex = 26
        '
        'LabelEdad
        '
        Me.LabelEdad.AutoSize = True
        Me.LabelEdad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEdad.Location = New System.Drawing.Point(605, 37)
        Me.LabelEdad.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEdad.Name = "LabelEdad"
        Me.LabelEdad.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelEdad.Size = New System.Drawing.Size(66, 33)
        Me.LabelEdad.TabIndex = 20
        Me.LabelEdad.Text = "EDAD"
        '
        'LabelLicencia
        '
        Me.LabelLicencia.AutoSize = True
        Me.LabelLicencia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicencia.Location = New System.Drawing.Point(286, 76)
        Me.LabelLicencia.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelLicencia.Name = "LabelLicencia"
        Me.LabelLicencia.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelLicencia.Size = New System.Drawing.Size(106, 33)
        Me.LabelLicencia.TabIndex = 24
        Me.LabelLicencia.Text = "LICENCIA#"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccion.Location = New System.Drawing.Point(286, 113)
        Me.LabelDireccion.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelDireccion.Size = New System.Drawing.Size(111, 33)
        Me.LabelDireccion.TabIndex = 25
        Me.LabelDireccion.Text = "DIRECCIÓN"
        '
        'TextoApellido
        '
        Me.TextoApellido.BackColor = System.Drawing.Color.White
        Me.TextoApellido.Enabled = False
        Me.TextoApellido.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoApellido.Location = New System.Drawing.Point(136, 76)
        Me.TextoApellido.Name = "TextoApellido"
        Me.TextoApellido.Size = New System.Drawing.Size(147, 31)
        Me.TextoApellido.TabIndex = 23
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido.Location = New System.Drawing.Point(15, 76)
        Me.LabelApellido.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelApellido.Size = New System.Drawing.Size(101, 33)
        Me.LabelApellido.TabIndex = 22
        Me.LabelApellido.Text = "APELLIDO"
        '
        'TextoNacionalidad
        '
        Me.TextoNacionalidad.BackColor = System.Drawing.Color.White
        Me.TextoNacionalidad.Enabled = False
        Me.TextoNacionalidad.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoNacionalidad.Location = New System.Drawing.Point(438, 39)
        Me.TextoNacionalidad.Name = "TextoNacionalidad"
        Me.TextoNacionalidad.Size = New System.Drawing.Size(164, 31)
        Me.TextoNacionalidad.TabIndex = 21
        '
        'TextoLicencia
        '
        Me.TextoLicencia.BackColor = System.Drawing.Color.White
        Me.TextoLicencia.Enabled = False
        Me.TextoLicencia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoLicencia.Location = New System.Drawing.Point(438, 76)
        Me.TextoLicencia.Name = "TextoLicencia"
        Me.TextoLicencia.Size = New System.Drawing.Size(164, 31)
        Me.TextoLicencia.TabIndex = 13
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(15, 39)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelNombre.Size = New System.Drawing.Size(94, 33)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "NOMBRE"
        '
        'GrupoDatosDelVehiculo
        '
        Me.GrupoDatosDelVehiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoTotalPagar)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoImpuesto)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoCosto)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoTiempoRentar)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoSucursal)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoFechaRetiro)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoMetodoPago)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoTarifaElegida)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.TextoModelo)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelTiempoRentar)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelCosto)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelItbms)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelTotalPagar)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelFechaRetiro)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelSucursal)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelMetodoPago)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelTarifa)
        Me.GrupoDatosDelVehiculo.Controls.Add(Me.LabelModelo)
        Me.GrupoDatosDelVehiculo.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GrupoDatosDelVehiculo.Location = New System.Drawing.Point(10, 180)
        Me.GrupoDatosDelVehiculo.Name = "GrupoDatosDelVehiculo"
        Me.GrupoDatosDelVehiculo.Size = New System.Drawing.Size(862, 300)
        Me.GrupoDatosDelVehiculo.TabIndex = 6
        Me.GrupoDatosDelVehiculo.TabStop = False
        Me.GrupoDatosDelVehiculo.Text = "DATOS DEL VEHICULO ALQUILADO"
        '
        'TextoTotalPagar
        '
        Me.TextoTotalPagar.BackColor = System.Drawing.Color.White
        Me.TextoTotalPagar.Enabled = False
        Me.TextoTotalPagar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoTotalPagar.Location = New System.Drawing.Point(635, 214)
        Me.TextoTotalPagar.Name = "TextoTotalPagar"
        Me.TextoTotalPagar.Size = New System.Drawing.Size(149, 31)
        Me.TextoTotalPagar.TabIndex = 42
        '
        'TextoImpuesto
        '
        Me.TextoImpuesto.BackColor = System.Drawing.Color.White
        Me.TextoImpuesto.Enabled = False
        Me.TextoImpuesto.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoImpuesto.Location = New System.Drawing.Point(635, 128)
        Me.TextoImpuesto.Name = "TextoImpuesto"
        Me.TextoImpuesto.Size = New System.Drawing.Size(149, 31)
        Me.TextoImpuesto.TabIndex = 41
        '
        'TextoCosto
        '
        Me.TextoCosto.BackColor = System.Drawing.Color.White
        Me.TextoCosto.Enabled = False
        Me.TextoCosto.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoCosto.Location = New System.Drawing.Point(635, 85)
        Me.TextoCosto.Name = "TextoCosto"
        Me.TextoCosto.Size = New System.Drawing.Size(149, 31)
        Me.TextoCosto.TabIndex = 40
        '
        'TextoTiempoRentar
        '
        Me.TextoTiempoRentar.BackColor = System.Drawing.Color.White
        Me.TextoTiempoRentar.Enabled = False
        Me.TextoTiempoRentar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoTiempoRentar.Location = New System.Drawing.Point(636, 42)
        Me.TextoTiempoRentar.Name = "TextoTiempoRentar"
        Me.TextoTiempoRentar.Size = New System.Drawing.Size(148, 31)
        Me.TextoTiempoRentar.TabIndex = 39
        '
        'TextoSucursal
        '
        Me.TextoSucursal.BackColor = System.Drawing.Color.White
        Me.TextoSucursal.Enabled = False
        Me.TextoSucursal.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoSucursal.Location = New System.Drawing.Point(189, 214)
        Me.TextoSucursal.Name = "TextoSucursal"
        Me.TextoSucursal.Size = New System.Drawing.Size(237, 31)
        Me.TextoSucursal.TabIndex = 38
        '
        'TextoFechaRetiro
        '
        Me.TextoFechaRetiro.BackColor = System.Drawing.Color.White
        Me.TextoFechaRetiro.Enabled = False
        Me.TextoFechaRetiro.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoFechaRetiro.Location = New System.Drawing.Point(189, 171)
        Me.TextoFechaRetiro.Name = "TextoFechaRetiro"
        Me.TextoFechaRetiro.Size = New System.Drawing.Size(237, 31)
        Me.TextoFechaRetiro.TabIndex = 37
        '
        'TextoMetodoPago
        '
        Me.TextoMetodoPago.BackColor = System.Drawing.Color.White
        Me.TextoMetodoPago.Enabled = False
        Me.TextoMetodoPago.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoMetodoPago.Location = New System.Drawing.Point(189, 128)
        Me.TextoMetodoPago.Name = "TextoMetodoPago"
        Me.TextoMetodoPago.Size = New System.Drawing.Size(237, 31)
        Me.TextoMetodoPago.TabIndex = 36
        '
        'TextoTarifaElegida
        '
        Me.TextoTarifaElegida.BackColor = System.Drawing.Color.White
        Me.TextoTarifaElegida.Enabled = False
        Me.TextoTarifaElegida.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoTarifaElegida.Location = New System.Drawing.Point(189, 85)
        Me.TextoTarifaElegida.Name = "TextoTarifaElegida"
        Me.TextoTarifaElegida.Size = New System.Drawing.Size(237, 31)
        Me.TextoTarifaElegida.TabIndex = 35
        '
        'TextoModelo
        '
        Me.TextoModelo.BackColor = System.Drawing.Color.White
        Me.TextoModelo.Enabled = False
        Me.TextoModelo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoModelo.Location = New System.Drawing.Point(189, 42)
        Me.TextoModelo.Name = "TextoModelo"
        Me.TextoModelo.Size = New System.Drawing.Size(237, 31)
        Me.TextoModelo.TabIndex = 34
        '
        'LabelTiempoRentar
        '
        Me.LabelTiempoRentar.AutoSize = True
        Me.LabelTiempoRentar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTiempoRentar.Location = New System.Drawing.Point(448, 42)
        Me.LabelTiempoRentar.Name = "LabelTiempoRentar"
        Me.LabelTiempoRentar.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelTiempoRentar.Size = New System.Drawing.Size(182, 43)
        Me.LabelTiempoRentar.TabIndex = 26
        Me.LabelTiempoRentar.Text = "TIEMPO A RENTAR"
        '
        'LabelCosto
        '
        Me.LabelCosto.AutoSize = True
        Me.LabelCosto.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCosto.Location = New System.Drawing.Point(450, 85)
        Me.LabelCosto.Name = "LabelCosto"
        Me.LabelCosto.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelCosto.Size = New System.Drawing.Size(87, 43)
        Me.LabelCosto.TabIndex = 25
        Me.LabelCosto.Text = "COSTO"
        '
        'LabelItbms
        '
        Me.LabelItbms.AutoSize = True
        Me.LabelItbms.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItbms.Location = New System.Drawing.Point(450, 131)
        Me.LabelItbms.Name = "LabelItbms"
        Me.LabelItbms.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelItbms.Size = New System.Drawing.Size(82, 43)
        Me.LabelItbms.TabIndex = 24
        Me.LabelItbms.Text = "ITBMS"
        '
        'LabelTotalPagar
        '
        Me.LabelTotalPagar.AutoSize = True
        Me.LabelTotalPagar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPagar.Location = New System.Drawing.Point(450, 214)
        Me.LabelTotalPagar.Name = "LabelTotalPagar"
        Me.LabelTotalPagar.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelTotalPagar.Size = New System.Drawing.Size(162, 43)
        Me.LabelTotalPagar.TabIndex = 23
        Me.LabelTotalPagar.Text = "TOTAL A PAGAR"
        '
        'LabelFechaRetiro
        '
        Me.LabelFechaRetiro.AutoSize = True
        Me.LabelFechaRetiro.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaRetiro.Location = New System.Drawing.Point(6, 171)
        Me.LabelFechaRetiro.Name = "LabelFechaRetiro"
        Me.LabelFechaRetiro.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelFechaRetiro.Size = New System.Drawing.Size(174, 43)
        Me.LabelFechaRetiro.TabIndex = 22
        Me.LabelFechaRetiro.Text = "FECHA DE RETIRO"
        '
        'LabelSucursal
        '
        Me.LabelSucursal.AutoSize = True
        Me.LabelSucursal.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSucursal.Location = New System.Drawing.Point(2, 214)
        Me.LabelSucursal.Name = "LabelSucursal"
        Me.LabelSucursal.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelSucursal.Size = New System.Drawing.Size(177, 43)
        Me.LabelSucursal.TabIndex = 21
        Me.LabelSucursal.Text = "LUGAR DE RETIRO"
        '
        'LabelMetodoPago
        '
        Me.LabelMetodoPago.AutoSize = True
        Me.LabelMetodoPago.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMetodoPago.Location = New System.Drawing.Point(6, 128)
        Me.LabelMetodoPago.Name = "LabelMetodoPago"
        Me.LabelMetodoPago.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelMetodoPago.Size = New System.Drawing.Size(169, 43)
        Me.LabelMetodoPago.TabIndex = 20
        Me.LabelMetodoPago.Text = "FORMA DE PAGO"
        '
        'LabelTarifa
        '
        Me.LabelTarifa.AutoSize = True
        Me.LabelTarifa.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTarifa.Location = New System.Drawing.Point(6, 85)
        Me.LabelTarifa.Name = "LabelTarifa"
        Me.LabelTarifa.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelTarifa.Size = New System.Drawing.Size(163, 43)
        Me.LabelTarifa.TabIndex = 19
        Me.LabelTarifa.Text = "TARIFA ELEGIDA"
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.Location = New System.Drawing.Point(194, 499)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(200, 50)
        Me.BotonCancelar.TabIndex = 52
        Me.BotonCancelar.Text = "C&ANCELAR"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'BotonContinuar
        '
        Me.BotonContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonContinuar.ForeColor = System.Drawing.Color.White
        Me.BotonContinuar.Location = New System.Drawing.Point(500, 499)
        Me.BotonContinuar.Name = "BotonContinuar"
        Me.BotonContinuar.Size = New System.Drawing.Size(200, 50)
        Me.BotonContinuar.TabIndex = 51
        Me.BotonContinuar.Text = "&CONTINUAR"
        Me.BotonContinuar.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.GrupoReservacion)
        Me.Controls.Add(Me.BotonContinuar)
        Me.Controls.Add(Me.GrupoDatosDelVehiculo)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PANAMA CAR RENTAL - ALQUILER"
        Me.GrupoReservacion.ResumeLayout(False)
        Me.GrupoReservacion.PerformLayout()
        Me.GrupoDatosDelVehiculo.ResumeLayout(False)
        Me.GrupoDatosDelVehiculo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelModelo As Label
    Friend WithEvents GrupoReservacion As GroupBox
    Friend WithEvents TextoNombre As TextBox
    Friend WithEvents TextoEdad As TextBox
    Friend WithEvents LabelNacionalidad As Label
    Friend WithEvents LabelCedula As Label
    Friend WithEvents TextoCedula As TextBox
    Friend WithEvents TextoDireccion As TextBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelEdad As Label
    Friend WithEvents LabelLicencia As Label
    Friend WithEvents TextoApellido As TextBox
    Friend WithEvents LabelApellido As Label
    Friend WithEvents TextoNacionalidad As TextBox
    Friend WithEvents TextoLicencia As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents GrupoDatosDelVehiculo As GroupBox
    Friend WithEvents TextoTotalPagar As TextBox
    Friend WithEvents TextoImpuesto As TextBox
    Friend WithEvents TextoCosto As TextBox
    Friend WithEvents TextoTiempoRentar As TextBox
    Friend WithEvents TextoSucursal As TextBox
    Friend WithEvents TextoFechaRetiro As TextBox
    Friend WithEvents TextoMetodoPago As TextBox
    Friend WithEvents TextoTarifaElegida As TextBox
    Friend WithEvents TextoModelo As TextBox
    Friend WithEvents LabelTiempoRentar As Label
    Friend WithEvents LabelCosto As Label
    Friend WithEvents LabelItbms As Label
    Friend WithEvents LabelTotalPagar As Label
    Friend WithEvents LabelFechaRetiro As Label
    Friend WithEvents LabelSucursal As Label
    Friend WithEvents LabelMetodoPago As Label
    Friend WithEvents LabelTarifa As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents TextoTelefono As TextBox
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents BotonContinuar As Button
End Class
