﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImgPresentacion = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.GrupoSeleccion = New System.Windows.Forms.GroupBox()
        Me.RadioAlquiler = New System.Windows.Forms.RadioButton()
        Me.RadioReservacion = New System.Windows.Forms.RadioButton()
        Me.RadioPrecio = New System.Windows.Forms.RadioButton()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        CType(Me.ImgPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoSeleccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImgPresentacion
        '
        Me.ImgPresentacion.Image = CType(resources.GetObject("ImgPresentacion.Image"), System.Drawing.Image)
        Me.ImgPresentacion.Location = New System.Drawing.Point(75, 100)
        Me.ImgPresentacion.Name = "ImgPresentacion"
        Me.ImgPresentacion.Size = New System.Drawing.Size(350, 200)
        Me.ImgPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPresentacion.TabIndex = 0
        Me.ImgPresentacion.TabStop = False
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTitulo.Enabled = False
        Me.LabelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTitulo.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Padding = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.LabelTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelTitulo.Size = New System.Drawing.Size(884, 90)
        Me.LabelTitulo.TabIndex = 1
        Me.LabelTitulo.Text = "PANAMA CAR RENTAL"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GrupoSeleccion
        '
        Me.GrupoSeleccion.BackColor = System.Drawing.Color.White
        Me.GrupoSeleccion.Controls.Add(Me.RadioAlquiler)
        Me.GrupoSeleccion.Controls.Add(Me.RadioReservacion)
        Me.GrupoSeleccion.Controls.Add(Me.RadioPrecio)
        Me.GrupoSeleccion.Location = New System.Drawing.Point(475, 100)
        Me.GrupoSeleccion.Name = "GrupoSeleccion"
        Me.GrupoSeleccion.Size = New System.Drawing.Size(360, 200)
        Me.GrupoSeleccion.TabIndex = 2
        Me.GrupoSeleccion.TabStop = False
        '
        'RadioAlquiler
        '
        Me.RadioAlquiler.BackColor = System.Drawing.Color.Transparent
        Me.RadioAlquiler.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioAlquiler.Location = New System.Drawing.Point(35, 131)
        Me.RadioAlquiler.Name = "RadioAlquiler"
        Me.RadioAlquiler.Size = New System.Drawing.Size(300, 50)
        Me.RadioAlquiler.TabIndex = 2
        Me.RadioAlquiler.TabStop = True
        Me.RadioAlquiler.Text = "ALQUILER"
        Me.RadioAlquiler.UseVisualStyleBackColor = False
        '
        'RadioReservacion
        '
        Me.RadioReservacion.BackColor = System.Drawing.Color.Transparent
        Me.RadioReservacion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioReservacion.Location = New System.Drawing.Point(35, 75)
        Me.RadioReservacion.Name = "RadioReservacion"
        Me.RadioReservacion.Size = New System.Drawing.Size(300, 50)
        Me.RadioReservacion.TabIndex = 1
        Me.RadioReservacion.TabStop = True
        Me.RadioReservacion.Text = "RESERVACIÓN"
        Me.RadioReservacion.UseVisualStyleBackColor = False
        '
        'RadioPrecio
        '
        Me.RadioPrecio.BackColor = System.Drawing.Color.Transparent
        Me.RadioPrecio.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioPrecio.Location = New System.Drawing.Point(35, 19)
        Me.RadioPrecio.Name = "RadioPrecio"
        Me.RadioPrecio.Size = New System.Drawing.Size(300, 50)
        Me.RadioPrecio.TabIndex = 0
        Me.RadioPrecio.TabStop = True
        Me.RadioPrecio.Text = "PRECIOS"
        Me.RadioPrecio.UseVisualStyleBackColor = False
        '
        'BotonContinuar
        '
        Me.BotonContinuar.BackColor = System.Drawing.Color.White
        Me.BotonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonContinuar.Location = New System.Drawing.Point(500, 350)
        Me.BotonContinuar.Name = "BotonContinuar"
        Me.BotonContinuar.Size = New System.Drawing.Size(300, 100)
        Me.BotonContinuar.TabIndex = 3
        Me.BotonContinuar.Text = "&CONTINUAR"
        Me.BotonContinuar.UseVisualStyleBackColor = False
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.White
        Me.BotonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCancelar.Location = New System.Drawing.Point(100, 350)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(300, 100)
        Me.BotonCancelar.TabIndex = 4
        Me.BotonCancelar.Text = "C&ANCELAR"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.BotonContinuar)
        Me.Controls.Add(Me.GrupoSeleccion)
        Me.Controls.Add(Me.ImgPresentacion)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PANAMA CAR RENTAL"
        CType(Me.ImgPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoSeleccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImgPresentacion As PictureBox
    Friend WithEvents GrupoSeleccion As GroupBox
    Friend WithEvents RadioAlquiler As RadioButton
    Friend WithEvents RadioReservacion As RadioButton
    Friend WithEvents RadioPrecio As RadioButton
    Friend WithEvents BotonContinuar As Button
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents LabelTitulo As Label
End Class
