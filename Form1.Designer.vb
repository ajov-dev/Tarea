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
        Me.ImgPresentacion = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.GrupoOpciones = New System.Windows.Forms.GroupBox()
        Me.RadioPrecio = New System.Windows.Forms.RadioButton()
        Me.RadioReservacion = New System.Windows.Forms.RadioButton()
        Me.RadioAlquiler = New System.Windows.Forms.RadioButton()
        CType(Me.ImgPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoOpciones.SuspendLayout()
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
        'GrupoOpciones
        '
        Me.GrupoOpciones.BackColor = System.Drawing.Color.SlateGray
        Me.GrupoOpciones.Controls.Add(Me.RadioAlquiler)
        Me.GrupoOpciones.Controls.Add(Me.RadioReservacion)
        Me.GrupoOpciones.Controls.Add(Me.RadioPrecio)
        Me.GrupoOpciones.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GrupoOpciones.Location = New System.Drawing.Point(500, 109)
        Me.GrupoOpciones.Name = "GrupoOpciones"
        Me.GrupoOpciones.Size = New System.Drawing.Size(350, 200)
        Me.GrupoOpciones.TabIndex = 5
        Me.GrupoOpciones.TabStop = False
        Me.GrupoOpciones.Text = "OPCIONES"
        '
        'RadioPrecio
        '
        Me.RadioPrecio.AutoSize = True
        Me.RadioPrecio.Location = New System.Drawing.Point(6, 33)
        Me.RadioPrecio.Name = "RadioPrecio"
        Me.RadioPrecio.Size = New System.Drawing.Size(107, 30)
        Me.RadioPrecio.TabIndex = 0
        Me.RadioPrecio.Text = "TARIFAS"
        Me.RadioPrecio.UseVisualStyleBackColor = True
        '
        'RadioReservacion
        '
        Me.RadioReservacion.AutoSize = True
        Me.RadioReservacion.Location = New System.Drawing.Point(6, 69)
        Me.RadioReservacion.Name = "RadioReservacion"
        Me.RadioReservacion.Size = New System.Drawing.Size(161, 30)
        Me.RadioReservacion.TabIndex = 1
        Me.RadioReservacion.Text = "RESERVACION"
        Me.RadioReservacion.UseVisualStyleBackColor = True
        '
        'RadioAlquiler
        '
        Me.RadioAlquiler.AutoSize = True
        Me.RadioAlquiler.Location = New System.Drawing.Point(6, 105)
        Me.RadioAlquiler.Name = "RadioAlquiler"
        Me.RadioAlquiler.Size = New System.Drawing.Size(122, 30)
        Me.RadioAlquiler.TabIndex = 2
        Me.RadioAlquiler.Text = "ALQUILER"
        Me.RadioAlquiler.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.GrupoOpciones)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.BotonContinuar)
        Me.Controls.Add(Me.ImgPresentacion)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PANAMA CAR RENTAL"
        CType(Me.ImgPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoOpciones.ResumeLayout(False)
        Me.GrupoOpciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImgPresentacion As PictureBox
    Friend WithEvents BotonContinuar As Button
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents GrupoOpciones As GroupBox
    Friend WithEvents RadioPrecio As RadioButton
    Friend WithEvents RadioAlquiler As RadioButton
    Friend WithEvents RadioReservacion As RadioButton
End Class
