<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.imgFamiliar = New System.Windows.Forms.PictureBox()
        Me.botonCancelar = New System.Windows.Forms.Button()
        Me.botonContinuar = New System.Windows.Forms.Button()
        Me.grupoPrecios = New System.Windows.Forms.GroupBox()
        Me.textoAño = New System.Windows.Forms.TextBox()
        Me.textoDia = New System.Windows.Forms.TextBox()
        Me.textoMes = New System.Windows.Forms.TextBox()
        Me.textoHora = New System.Windows.Forms.TextBox()
        Me.labelPrecioAño = New System.Windows.Forms.Label()
        Me.labelPrecioHora = New System.Windows.Forms.Label()
        Me.labelPrecioMes = New System.Windows.Forms.Label()
        Me.labelPrecioDia = New System.Windows.Forms.Label()
        Me.comboOpciones = New System.Windows.Forms.ComboBox()
        CType(Me.imgFamiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoPrecios.SuspendLayout()
        Me.SuspendLayout()
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
        Me.labelTitulo.TabIndex = 6
        Me.labelTitulo.Text = "FAMILIAR"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgFamiliar
        '
        Me.imgFamiliar.Image = CType(resources.GetObject("imgFamiliar.Image"), System.Drawing.Image)
        Me.imgFamiliar.Location = New System.Drawing.Point(75, 100)
        Me.imgFamiliar.Name = "imgFamiliar"
        Me.imgFamiliar.Size = New System.Drawing.Size(350, 200)
        Me.imgFamiliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFamiliar.TabIndex = 11
        Me.imgFamiliar.TabStop = False
        '
        'botonCancelar
        '
        Me.botonCancelar.BackColor = System.Drawing.Color.White
        Me.botonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonCancelar.Location = New System.Drawing.Point(435, 240)
        Me.botonCancelar.Name = "botonCancelar"
        Me.botonCancelar.Size = New System.Drawing.Size(360, 60)
        Me.botonCancelar.TabIndex = 18
        Me.botonCancelar.Text = "C&ANCELAR"
        Me.botonCancelar.UseVisualStyleBackColor = False
        '
        'botonContinuar
        '
        Me.botonContinuar.BackColor = System.Drawing.Color.White
        Me.botonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonContinuar.Location = New System.Drawing.Point(435, 174)
        Me.botonContinuar.Name = "botonContinuar"
        Me.botonContinuar.Size = New System.Drawing.Size(360, 60)
        Me.botonContinuar.TabIndex = 17
        Me.botonContinuar.Text = "&CONTINUAR"
        Me.botonContinuar.UseVisualStyleBackColor = False
        '
        'grupoPrecios
        '
        Me.grupoPrecios.BackColor = System.Drawing.Color.White
        Me.grupoPrecios.Controls.Add(Me.textoAño)
        Me.grupoPrecios.Controls.Add(Me.textoDia)
        Me.grupoPrecios.Controls.Add(Me.textoMes)
        Me.grupoPrecios.Controls.Add(Me.textoHora)
        Me.grupoPrecios.Controls.Add(Me.labelPrecioAño)
        Me.grupoPrecios.Controls.Add(Me.labelPrecioHora)
        Me.grupoPrecios.Controls.Add(Me.labelPrecioMes)
        Me.grupoPrecios.Controls.Add(Me.labelPrecioDia)
        Me.grupoPrecios.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoPrecios.Location = New System.Drawing.Point(76, 318)
        Me.grupoPrecios.Name = "grupoPrecios"
        Me.grupoPrecios.Size = New System.Drawing.Size(720, 231)
        Me.grupoPrecios.TabIndex = 16
        Me.grupoPrecios.TabStop = False
        Me.grupoPrecios.Text = "PRECIOS DE ALQUILER (SEGURO INCLUIDO)"
        '
        'textoAño
        '
        Me.textoAño.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.textoAño.Location = New System.Drawing.Point(470, 163)
        Me.textoAño.Name = "textoAño"
        Me.textoAño.Size = New System.Drawing.Size(100, 31)
        Me.textoAño.TabIndex = 11
        '
        'textoDia
        '
        Me.textoDia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.textoDia.Location = New System.Drawing.Point(470, 67)
        Me.textoDia.Name = "textoDia"
        Me.textoDia.Size = New System.Drawing.Size(100, 31)
        Me.textoDia.TabIndex = 10
        '
        'textoMes
        '
        Me.textoMes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.textoMes.Location = New System.Drawing.Point(114, 163)
        Me.textoMes.Name = "textoMes"
        Me.textoMes.Size = New System.Drawing.Size(100, 31)
        Me.textoMes.TabIndex = 9
        '
        'textoHora
        '
        Me.textoHora.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.textoHora.Location = New System.Drawing.Point(114, 70)
        Me.textoHora.Name = "textoHora"
        Me.textoHora.Size = New System.Drawing.Size(100, 31)
        Me.textoHora.TabIndex = 8
        '
        'labelPrecioAño
        '
        Me.labelPrecioAño.AutoSize = True
        Me.labelPrecioAño.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrecioAño.Location = New System.Drawing.Point(576, 171)
        Me.labelPrecioAño.Name = "labelPrecioAño"
        Me.labelPrecioAño.Size = New System.Drawing.Size(63, 23)
        Me.labelPrecioAño.TabIndex = 7
        Me.labelPrecioAño.Text = "&X AÑO"
        '
        'labelPrecioHora
        '
        Me.labelPrecioHora.AutoSize = True
        Me.labelPrecioHora.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrecioHora.Location = New System.Drawing.Point(220, 70)
        Me.labelPrecioHora.Name = "labelPrecioHora"
        Me.labelPrecioHora.Size = New System.Drawing.Size(73, 23)
        Me.labelPrecioHora.TabIndex = 6
        Me.labelPrecioHora.Text = "&X HORA"
        '
        'labelPrecioMes
        '
        Me.labelPrecioMes.AutoSize = True
        Me.labelPrecioMes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrecioMes.Location = New System.Drawing.Point(225, 166)
        Me.labelPrecioMes.Name = "labelPrecioMes"
        Me.labelPrecioMes.Size = New System.Drawing.Size(61, 23)
        Me.labelPrecioMes.TabIndex = 5
        Me.labelPrecioMes.Text = "&X MES"
        '
        'labelPrecioDia
        '
        Me.labelPrecioDia.AutoSize = True
        Me.labelPrecioDia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrecioDia.Location = New System.Drawing.Point(576, 73)
        Me.labelPrecioDia.Name = "labelPrecioDia"
        Me.labelPrecioDia.Size = New System.Drawing.Size(54, 23)
        Me.labelPrecioDia.TabIndex = 4
        Me.labelPrecioDia.Text = "&X DÍA"
        '
        'comboOpciones
        '
        Me.comboOpciones.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.comboOpciones.FormattingEnabled = True
        Me.comboOpciones.Items.AddRange(New Object() {"Hyundai Accent", "Hyundai Elantra", "Hyundai Grand i10", "Hyundai Tucson", "Hyundai Santa Fe", "Kia Rio", "Kia Cerato", "Kia Optima", "Kia Carnival", "Kia Sportage", "Kia Sorento", "Toyota Yaris", "Toyota Corrolla", "Toyota Rav4", "Toyota Rush"})
        Me.comboOpciones.Location = New System.Drawing.Point(435, 100)
        Me.comboOpciones.Name = "comboOpciones"
        Me.comboOpciones.Size = New System.Drawing.Size(360, 34)
        Me.comboOpciones.TabIndex = 15
        Me.comboOpciones.Text = "SELECCIONE UNA OPCION"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.botonCancelar)
        Me.Controls.Add(Me.botonContinuar)
        Me.Controls.Add(Me.grupoPrecios)
        Me.Controls.Add(Me.comboOpciones)
        Me.Controls.Add(Me.imgFamiliar)
        Me.Controls.Add(Me.labelTitulo)
        Me.Name = "Form3"
        Me.Text = "FAMILIAR"
        CType(Me.imgFamiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoPrecios.ResumeLayout(False)
        Me.grupoPrecios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelTitulo As Label
    Friend WithEvents imgFamiliar As PictureBox
    Friend WithEvents botonCancelar As Button
    Friend WithEvents botonContinuar As Button
    Friend WithEvents grupoPrecios As GroupBox
    Friend WithEvents textoAño As TextBox
    Friend WithEvents textoDia As TextBox
    Friend WithEvents textoMes As TextBox
    Friend WithEvents textoHora As TextBox
    Friend WithEvents labelPrecioAño As Label
    Friend WithEvents labelPrecioHora As Label
    Friend WithEvents labelPrecioMes As Label
    Friend WithEvents labelPrecioDia As Label
    Friend WithEvents comboOpciones As ComboBox
End Class
