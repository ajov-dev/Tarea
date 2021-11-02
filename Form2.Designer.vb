<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.grupoOpciones = New System.Windows.Forms.GroupBox()
        Me.botonCancelar = New System.Windows.Forms.Button()
        Me.imgLujo = New System.Windows.Forms.PictureBox()
        Me.imgFamiliar = New System.Windows.Forms.PictureBox()
        Me.radioLujo = New System.Windows.Forms.RadioButton()
        Me.radioFamiliar = New System.Windows.Forms.RadioButton()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.grupoOpciones.SuspendLayout()
        CType(Me.imgLujo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFamiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoOpciones
        '
        Me.grupoOpciones.Controls.Add(Me.botonCancelar)
        Me.grupoOpciones.Controls.Add(Me.imgLujo)
        Me.grupoOpciones.Controls.Add(Me.imgFamiliar)
        Me.grupoOpciones.Controls.Add(Me.radioLujo)
        Me.grupoOpciones.Controls.Add(Me.radioFamiliar)
        Me.grupoOpciones.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoOpciones.Location = New System.Drawing.Point(3, 60)
        Me.grupoOpciones.Name = "grupoOpciones"
        Me.grupoOpciones.Size = New System.Drawing.Size(858, 489)
        Me.grupoOpciones.TabIndex = 1
        Me.grupoOpciones.TabStop = False
        Me.grupoOpciones.Text = "ESCOJA UNA OPCIÓN"
        '
        'botonCancelar
        '
        Me.botonCancelar.BackColor = System.Drawing.Color.White
        Me.botonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonCancelar.Location = New System.Drawing.Point(634, 367)
        Me.botonCancelar.Name = "botonCancelar"
        Me.botonCancelar.Size = New System.Drawing.Size(218, 100)
        Me.botonCancelar.TabIndex = 6
        Me.botonCancelar.Text = "&CANCELAR"
        Me.botonCancelar.UseVisualStyleBackColor = False
        '
        'imgLujo
        '
        Me.imgLujo.Image = CType(resources.GetObject("imgLujo.Image"), System.Drawing.Image)
        Me.imgLujo.Location = New System.Drawing.Point(278, 267)
        Me.imgLujo.Name = "imgLujo"
        Me.imgLujo.Size = New System.Drawing.Size(350, 200)
        Me.imgLujo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLujo.TabIndex = 5
        Me.imgLujo.TabStop = False
        '
        'imgFamiliar
        '
        Me.imgFamiliar.Image = CType(resources.GetObject("imgFamiliar.Image"), System.Drawing.Image)
        Me.imgFamiliar.Location = New System.Drawing.Point(278, 31)
        Me.imgFamiliar.Name = "imgFamiliar"
        Me.imgFamiliar.Size = New System.Drawing.Size(350, 200)
        Me.imgFamiliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFamiliar.TabIndex = 4
        Me.imgFamiliar.TabStop = False
        '
        'radioLujo
        '
        Me.radioLujo.AutoSize = True
        Me.radioLujo.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.radioLujo.Location = New System.Drawing.Point(114, 267)
        Me.radioLujo.Name = "radioLujo"
        Me.radioLujo.Size = New System.Drawing.Size(77, 30)
        Me.radioLujo.TabIndex = 2
        Me.radioLujo.TabStop = True
        Me.radioLujo.Text = "LUJO"
        Me.radioLujo.UseVisualStyleBackColor = True
        '
        'radioFamiliar
        '
        Me.radioFamiliar.AutoSize = True
        Me.radioFamiliar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.radioFamiliar.Location = New System.Drawing.Point(114, 98)
        Me.radioFamiliar.Name = "radioFamiliar"
        Me.radioFamiliar.Size = New System.Drawing.Size(119, 30)
        Me.radioFamiliar.TabIndex = 0
        Me.radioFamiliar.TabStop = True
        Me.radioFamiliar.Text = "FAMILIAR"
        Me.radioFamiliar.UseVisualStyleBackColor = True
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
        Me.labelTitulo.Size = New System.Drawing.Size(884, 67)
        Me.labelTitulo.TabIndex = 7
        Me.labelTitulo.Text = "TARIFAS"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.grupoOpciones)
        Me.Controls.Add(Me.labelTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "Form2"
        Me.Text = "PANTALLA - PRECIOS"
        Me.grupoOpciones.ResumeLayout(False)
        Me.grupoOpciones.PerformLayout()
        CType(Me.imgLujo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFamiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoOpciones As GroupBox
    Friend WithEvents radioFamiliar As RadioButton
    Friend WithEvents radioLujo As RadioButton
    Friend WithEvents imgFamiliar As PictureBox
    Friend WithEvents imgLujo As PictureBox
    Friend WithEvents botonCancelar As Button
    Friend WithEvents labelTitulo As Label
End Class
