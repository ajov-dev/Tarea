<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.imgPresentacion = New System.Windows.Forms.PictureBox()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.grupoSeleccion = New System.Windows.Forms.GroupBox()
        Me.radioAlquiler = New System.Windows.Forms.RadioButton()
        Me.radioReservacion = New System.Windows.Forms.RadioButton()
        Me.radioPrecio = New System.Windows.Forms.RadioButton()
        Me.botonContinuar = New System.Windows.Forms.Button()
        Me.botonCancelar = New System.Windows.Forms.Button()
        CType(Me.imgPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoSeleccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgPresentacion
        '
        Me.imgPresentacion.Image = CType(resources.GetObject("imgPresentacion.Image"), System.Drawing.Image)
        Me.imgPresentacion.Location = New System.Drawing.Point(75, 100)
        Me.imgPresentacion.Name = "imgPresentacion"
        Me.imgPresentacion.Size = New System.Drawing.Size(350, 200)
        Me.imgPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPresentacion.TabIndex = 0
        Me.imgPresentacion.TabStop = False
        '
        'labelTitulo
        '
        Me.labelTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTitulo.Enabled = False
        Me.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelTitulo.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.labelTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Padding = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.labelTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.labelTitulo.Size = New System.Drawing.Size(884, 90)
        Me.labelTitulo.TabIndex = 1
        Me.labelTitulo.Text = "PANAMA CAR RENTAL"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grupoSeleccion
        '
        Me.grupoSeleccion.BackColor = System.Drawing.Color.White
        Me.grupoSeleccion.Controls.Add(Me.radioAlquiler)
        Me.grupoSeleccion.Controls.Add(Me.radioReservacion)
        Me.grupoSeleccion.Controls.Add(Me.radioPrecio)
        Me.grupoSeleccion.Location = New System.Drawing.Point(475, 100)
        Me.grupoSeleccion.Name = "grupoSeleccion"
        Me.grupoSeleccion.Size = New System.Drawing.Size(360, 200)
        Me.grupoSeleccion.TabIndex = 2
        Me.grupoSeleccion.TabStop = False
        '
        'radioAlquiler
        '
        Me.radioAlquiler.BackColor = System.Drawing.Color.Transparent
        Me.radioAlquiler.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.radioAlquiler.Location = New System.Drawing.Point(35, 131)
        Me.radioAlquiler.Name = "radioAlquiler"
        Me.radioAlquiler.Size = New System.Drawing.Size(300, 50)
        Me.radioAlquiler.TabIndex = 2
        Me.radioAlquiler.TabStop = True
        Me.radioAlquiler.Text = "ALQUILER"
        Me.radioAlquiler.UseVisualStyleBackColor = False
        '
        'radioReservacion
        '
        Me.radioReservacion.BackColor = System.Drawing.Color.Transparent
        Me.radioReservacion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.radioReservacion.Location = New System.Drawing.Point(35, 75)
        Me.radioReservacion.Name = "radioReservacion"
        Me.radioReservacion.Size = New System.Drawing.Size(300, 50)
        Me.radioReservacion.TabIndex = 1
        Me.radioReservacion.TabStop = True
        Me.radioReservacion.Text = "RESERVACIÓN"
        Me.radioReservacion.UseVisualStyleBackColor = False
        '
        'radioPrecio
        '
        Me.radioPrecio.BackColor = System.Drawing.Color.Transparent
        Me.radioPrecio.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.radioPrecio.Location = New System.Drawing.Point(35, 19)
        Me.radioPrecio.Name = "radioPrecio"
        Me.radioPrecio.Size = New System.Drawing.Size(300, 50)
        Me.radioPrecio.TabIndex = 0
        Me.radioPrecio.TabStop = True
        Me.radioPrecio.Text = "PRECIOS"
        Me.radioPrecio.UseVisualStyleBackColor = False
        '
        'botonContinuar
        '
        Me.botonContinuar.BackColor = System.Drawing.Color.White
        Me.botonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonContinuar.Location = New System.Drawing.Point(500, 350)
        Me.botonContinuar.Name = "botonContinuar"
        Me.botonContinuar.Size = New System.Drawing.Size(300, 100)
        Me.botonContinuar.TabIndex = 3
        Me.botonContinuar.Text = "&CONTINUAR"
        Me.botonContinuar.UseVisualStyleBackColor = False
        '
        'botonCancelar
        '
        Me.botonCancelar.BackColor = System.Drawing.Color.White
        Me.botonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonCancelar.Location = New System.Drawing.Point(100, 350)
        Me.botonCancelar.Name = "botonCancelar"
        Me.botonCancelar.Size = New System.Drawing.Size(300, 100)
        Me.botonCancelar.TabIndex = 4
        Me.botonCancelar.Text = "C&ANCELAR"
        Me.botonCancelar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.botonCancelar)
        Me.Controls.Add(Me.botonContinuar)
        Me.Controls.Add(Me.grupoSeleccion)
        Me.Controls.Add(Me.imgPresentacion)
        Me.Controls.Add(Me.labelTitulo)
        Me.Name = "Form1"
        Me.Text = "PANAMA CAR RENTAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoSeleccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgPresentacion As PictureBox
    Friend WithEvents grupoSeleccion As GroupBox
    Friend WithEvents radioAlquiler As RadioButton
    Friend WithEvents radioReservacion As RadioButton
    Friend WithEvents radioPrecio As RadioButton
    Friend WithEvents botonContinuar As Button
    Friend WithEvents botonCancelar As Button
    Friend WithEvents labelTitulo As Label
End Class
