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
        Me.GroupBoxBGround = New System.Windows.Forms.GroupBox()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.GrupoOpciones = New System.Windows.Forms.GroupBox()
        Me.RadioAlquiler = New System.Windows.Forms.RadioButton()
        Me.RadioReservacion = New System.Windows.Forms.RadioButton()
        Me.RadioPrecio = New System.Windows.Forms.RadioButton()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.GroupBoxBGround.SuspendLayout()
        Me.GrupoOpciones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBGround
        '
        Me.GroupBoxBGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GroupBoxBGround.Controls.Add(Me.BotonContinuar)
        Me.GroupBoxBGround.Controls.Add(Me.GrupoOpciones)
        Me.GroupBoxBGround.Controls.Add(Me.BotonCancelar)
        Me.GroupBoxBGround.Controls.Add(Me.PictureBox1)
        Me.GroupBoxBGround.Location = New System.Drawing.Point(10, 75)
        Me.GroupBoxBGround.Name = "GroupBoxBGround"
        Me.GroupBoxBGround.Size = New System.Drawing.Size(865, 480)
        Me.GroupBoxBGround.TabIndex = 0
        Me.GroupBoxBGround.TabStop = False
        '
        'BotonContinuar
        '
        Me.BotonContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonContinuar.ForeColor = System.Drawing.Color.White
        Me.BotonContinuar.Location = New System.Drawing.Point(550, 390)
        Me.BotonContinuar.Name = "BotonContinuar"
        Me.BotonContinuar.Size = New System.Drawing.Size(200, 50)
        Me.BotonContinuar.TabIndex = 24
        Me.BotonContinuar.Text = "&CONTINUAR"
        Me.BotonContinuar.UseVisualStyleBackColor = False
        '
        'GrupoOpciones
        '
        Me.GrupoOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.GrupoOpciones.Controls.Add(Me.RadioAlquiler)
        Me.GrupoOpciones.Controls.Add(Me.RadioReservacion)
        Me.GrupoOpciones.Controls.Add(Me.RadioPrecio)
        Me.GrupoOpciones.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoOpciones.ForeColor = System.Drawing.Color.White
        Me.GrupoOpciones.Location = New System.Drawing.Point(450, 75)
        Me.GrupoOpciones.Name = "GrupoOpciones"
        Me.GrupoOpciones.Size = New System.Drawing.Size(400, 225)
        Me.GrupoOpciones.TabIndex = 21
        Me.GrupoOpciones.TabStop = False
        Me.GrupoOpciones.Text = "OPCIONES"
        '
        'RadioAlquiler
        '
        Me.RadioAlquiler.AutoSize = True
        Me.RadioAlquiler.ForeColor = System.Drawing.Color.White
        Me.RadioAlquiler.Location = New System.Drawing.Point(6, 159)
        Me.RadioAlquiler.Name = "RadioAlquiler"
        Me.RadioAlquiler.Padding = New System.Windows.Forms.Padding(15)
        Me.RadioAlquiler.Size = New System.Drawing.Size(152, 60)
        Me.RadioAlquiler.TabIndex = 2
        Me.RadioAlquiler.Text = "ALQUILER"
        Me.RadioAlquiler.UseVisualStyleBackColor = True
        '
        'RadioReservacion
        '
        Me.RadioReservacion.AutoSize = True
        Me.RadioReservacion.ForeColor = System.Drawing.Color.White
        Me.RadioReservacion.Location = New System.Drawing.Point(6, 93)
        Me.RadioReservacion.Name = "RadioReservacion"
        Me.RadioReservacion.Padding = New System.Windows.Forms.Padding(15)
        Me.RadioReservacion.Size = New System.Drawing.Size(191, 60)
        Me.RadioReservacion.TabIndex = 1
        Me.RadioReservacion.Text = "RESERVACION"
        Me.RadioReservacion.UseVisualStyleBackColor = True
        '
        'RadioPrecio
        '
        Me.RadioPrecio.AutoSize = True
        Me.RadioPrecio.ForeColor = System.Drawing.Color.White
        Me.RadioPrecio.Location = New System.Drawing.Point(6, 27)
        Me.RadioPrecio.Name = "RadioPrecio"
        Me.RadioPrecio.Padding = New System.Windows.Forms.Padding(15)
        Me.RadioPrecio.Size = New System.Drawing.Size(137, 60)
        Me.RadioPrecio.TabIndex = 0
        Me.RadioPrecio.Text = "TARIFAS"
        Me.RadioPrecio.UseVisualStyleBackColor = True
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.Location = New System.Drawing.Point(110, 390)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(200, 50)
        Me.BotonCancelar.TabIndex = 25
        Me.BotonCancelar.Text = "C&ANCELAR"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'LabelTitulo
        '
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTitulo.Font = New System.Drawing.Font("Candara", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelTitulo.Size = New System.Drawing.Size(884, 75)
        Me.LabelTitulo.TabIndex = 23
        Me.LabelTitulo.Text = "PANAMA CAR RENTAL"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.GroupBoxBGround)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PANAMA CAR RENTAL"
        Me.GroupBoxBGround.ResumeLayout(False)
        Me.GrupoOpciones.ResumeLayout(False)
        Me.GrupoOpciones.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxBGround As GroupBox
    Friend WithEvents BotonContinuar As Button
    Friend WithEvents GrupoOpciones As GroupBox
    Friend WithEvents RadioAlquiler As RadioButton
    Friend WithEvents RadioReservacion As RadioButton
    Friend WithEvents RadioPrecio As RadioButton
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
