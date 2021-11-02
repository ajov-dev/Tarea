<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gvbPrecios = New System.Windows.Forms.GroupBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.txtmes = New System.Windows.Forms.TextBox()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.lblprecioaño = New System.Windows.Forms.Label()
        Me.lblpreciohora = New System.Windows.Forms.Label()
        Me.lblpreciomes = New System.Windows.Forms.Label()
        Me.lblpreciodia = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gvbPrecios.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Enabled = False
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTitulo.Size = New System.Drawing.Size(884, 90)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "LUJO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(75, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(350, 200)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(435, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(360, 60)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "C&ANCELAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(435, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(360, 60)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "&CONTINUAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'gvbPrecios
        '
        Me.gvbPrecios.BackColor = System.Drawing.Color.White
        Me.gvbPrecios.Controls.Add(Me.txtaño)
        Me.gvbPrecios.Controls.Add(Me.txtdia)
        Me.gvbPrecios.Controls.Add(Me.txtmes)
        Me.gvbPrecios.Controls.Add(Me.txthora)
        Me.gvbPrecios.Controls.Add(Me.lblprecioaño)
        Me.gvbPrecios.Controls.Add(Me.lblpreciohora)
        Me.gvbPrecios.Controls.Add(Me.lblpreciomes)
        Me.gvbPrecios.Controls.Add(Me.lblpreciodia)
        Me.gvbPrecios.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvbPrecios.Location = New System.Drawing.Point(76, 318)
        Me.gvbPrecios.Name = "gvbPrecios"
        Me.gvbPrecios.Size = New System.Drawing.Size(720, 231)
        Me.gvbPrecios.TabIndex = 12
        Me.gvbPrecios.TabStop = False
        Me.gvbPrecios.Text = "PRECIOS DE ALQUILER (SEGURO INCLUIDO)"
        '
        'txtaño
        '
        Me.txtaño.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtaño.Location = New System.Drawing.Point(470, 163)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(100, 31)
        Me.txtaño.TabIndex = 11
        '
        'txtdia
        '
        Me.txtdia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtdia.Location = New System.Drawing.Point(470, 67)
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(100, 31)
        Me.txtdia.TabIndex = 10
        '
        'txtmes
        '
        Me.txtmes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtmes.Location = New System.Drawing.Point(114, 163)
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(100, 31)
        Me.txtmes.TabIndex = 9
        '
        'txthora
        '
        Me.txthora.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txthora.Location = New System.Drawing.Point(114, 70)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(100, 31)
        Me.txthora.TabIndex = 8
        '
        'lblprecioaño
        '
        Me.lblprecioaño.AutoSize = True
        Me.lblprecioaño.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecioaño.Location = New System.Drawing.Point(576, 171)
        Me.lblprecioaño.Name = "lblprecioaño"
        Me.lblprecioaño.Size = New System.Drawing.Size(63, 23)
        Me.lblprecioaño.TabIndex = 7
        Me.lblprecioaño.Text = "&X AÑO"
        '
        'lblpreciohora
        '
        Me.lblpreciohora.AutoSize = True
        Me.lblpreciohora.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciohora.Location = New System.Drawing.Point(220, 70)
        Me.lblpreciohora.Name = "lblpreciohora"
        Me.lblpreciohora.Size = New System.Drawing.Size(73, 23)
        Me.lblpreciohora.TabIndex = 6
        Me.lblpreciohora.Text = "&X HORA"
        '
        'lblpreciomes
        '
        Me.lblpreciomes.AutoSize = True
        Me.lblpreciomes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciomes.Location = New System.Drawing.Point(225, 166)
        Me.lblpreciomes.Name = "lblpreciomes"
        Me.lblpreciomes.Size = New System.Drawing.Size(61, 23)
        Me.lblpreciomes.TabIndex = 5
        Me.lblpreciomes.Text = "&X MES"
        '
        'lblpreciodia
        '
        Me.lblpreciodia.AutoSize = True
        Me.lblpreciodia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciodia.Location = New System.Drawing.Point(576, 73)
        Me.lblpreciodia.Name = "lblpreciodia"
        Me.lblpreciodia.Size = New System.Drawing.Size(54, 23)
        Me.lblpreciodia.TabIndex = 4
        Me.lblpreciodia.Text = "&X DÍA"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Hyundai Accent", "Hyundai Elantra", "Hyundai Grand i10", "Hyundai Tucson", "Hyundai Santa Fe", "Kia Rio", "Kia Cerato", "Kia Optima", "Kia Carnival", "Kia Sportage", "Kia Sorento", "Toyota Yaris", "Toyota Corrolla", "Toyota Rav4", "Toyota Rush"})
        Me.ComboBox1.Location = New System.Drawing.Point(435, 100)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(360, 34)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.Text = "SELECCIONE UNA OPCION"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.gvbPrecios)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form4"
        Me.Text = "LUJO"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gvbPrecios.ResumeLayout(False)
        Me.gvbPrecios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents gvbPrecios As GroupBox
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtdia As TextBox
    Friend WithEvents txtmes As TextBox
    Friend WithEvents txthora As TextBox
    Friend WithEvents lblprecioaño As Label
    Friend WithEvents lblpreciohora As Label
    Friend WithEvents lblpreciomes As Label
    Friend WithEvents lblpreciodia As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
