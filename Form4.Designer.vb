<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.GrupoPrecios = New System.Windows.Forms.GroupBox()
        Me.TextoSemana = New System.Windows.Forms.TextBox()
        Me.TextoDia = New System.Windows.Forms.TextBox()
        Me.TextoMes = New System.Windows.Forms.TextBox()
        Me.TextoHora = New System.Windows.Forms.TextBox()
        Me.LabelPrecioSemana = New System.Windows.Forms.Label()
        Me.LabelPrecioHora = New System.Windows.Forms.Label()
        Me.LabelPrecioMes = New System.Windows.Forms.Label()
        Me.LabelPrecioDia = New System.Windows.Forms.Label()
        Me.ComboMLujo = New System.Windows.Forms.ComboBox()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.GrupoPrecios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrupoPrecios
        '
        Me.GrupoPrecios.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GrupoPrecios.Controls.Add(Me.TextoSemana)
        Me.GrupoPrecios.Controls.Add(Me.TextoDia)
        Me.GrupoPrecios.Controls.Add(Me.TextoMes)
        Me.GrupoPrecios.Controls.Add(Me.TextoHora)
        Me.GrupoPrecios.Controls.Add(Me.LabelPrecioSemana)
        Me.GrupoPrecios.Controls.Add(Me.LabelPrecioHora)
        Me.GrupoPrecios.Controls.Add(Me.LabelPrecioMes)
        Me.GrupoPrecios.Controls.Add(Me.LabelPrecioDia)
        Me.GrupoPrecios.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoPrecios.ForeColor = System.Drawing.Color.Black
        Me.GrupoPrecios.Location = New System.Drawing.Point(500, 100)
        Me.GrupoPrecios.Name = "GrupoPrecios"
        Me.GrupoPrecios.Size = New System.Drawing.Size(377, 449)
        Me.GrupoPrecios.TabIndex = 26
        Me.GrupoPrecios.TabStop = False
        Me.GrupoPrecios.Text = "PRECIOS DE ALQUILER (SEGURO INCLUIDO)"
        '
        'TextoSemana
        '
        Me.TextoSemana.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TextoSemana.Location = New System.Drawing.Point(37, 290)
        Me.TextoSemana.Name = "TextoSemana"
        Me.TextoSemana.Size = New System.Drawing.Size(100, 31)
        Me.TextoSemana.TabIndex = 11
        Me.TextoSemana.Text = "PRECIO B/."
        '
        'TextoDia
        '
        Me.TextoDia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TextoDia.Location = New System.Drawing.Point(37, 190)
        Me.TextoDia.Name = "TextoDia"
        Me.TextoDia.Size = New System.Drawing.Size(100, 31)
        Me.TextoDia.TabIndex = 10
        Me.TextoDia.Text = "PRECIO B/."
        '
        'TextoMes
        '
        Me.TextoMes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TextoMes.Location = New System.Drawing.Point(37, 390)
        Me.TextoMes.Name = "TextoMes"
        Me.TextoMes.Size = New System.Drawing.Size(100, 31)
        Me.TextoMes.TabIndex = 9
        Me.TextoMes.Text = "PRECIO B/."
        '
        'TextoHora
        '
        Me.TextoHora.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TextoHora.Location = New System.Drawing.Point(37, 90)
        Me.TextoHora.Name = "TextoHora"
        Me.TextoHora.Size = New System.Drawing.Size(100, 31)
        Me.TextoHora.TabIndex = 8
        Me.TextoHora.Text = "PRECIO B/."
        '
        'LabelPrecioSemana
        '
        Me.LabelPrecioSemana.AutoSize = True
        Me.LabelPrecioSemana.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecioSemana.Location = New System.Drawing.Point(143, 298)
        Me.LabelPrecioSemana.Name = "LabelPrecioSemana"
        Me.LabelPrecioSemana.Size = New System.Drawing.Size(98, 23)
        Me.LabelPrecioSemana.TabIndex = 7
        Me.LabelPrecioSemana.Text = "&X SEMANA"
        Me.LabelPrecioSemana.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelPrecioHora
        '
        Me.LabelPrecioHora.AutoSize = True
        Me.LabelPrecioHora.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecioHora.Location = New System.Drawing.Point(143, 98)
        Me.LabelPrecioHora.Name = "LabelPrecioHora"
        Me.LabelPrecioHora.Size = New System.Drawing.Size(73, 23)
        Me.LabelPrecioHora.TabIndex = 6
        Me.LabelPrecioHora.Text = "&X HORA"
        Me.LabelPrecioHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelPrecioMes
        '
        Me.LabelPrecioMes.AutoSize = True
        Me.LabelPrecioMes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecioMes.Location = New System.Drawing.Point(143, 398)
        Me.LabelPrecioMes.Name = "LabelPrecioMes"
        Me.LabelPrecioMes.Size = New System.Drawing.Size(61, 23)
        Me.LabelPrecioMes.TabIndex = 5
        Me.LabelPrecioMes.Text = "&X MES"
        Me.LabelPrecioMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelPrecioDia
        '
        Me.LabelPrecioDia.AutoSize = True
        Me.LabelPrecioDia.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecioDia.Location = New System.Drawing.Point(143, 198)
        Me.LabelPrecioDia.Name = "LabelPrecioDia"
        Me.LabelPrecioDia.Size = New System.Drawing.Size(54, 23)
        Me.LabelPrecioDia.TabIndex = 4
        Me.LabelPrecioDia.Text = "&X DÍA"
        Me.LabelPrecioDia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboMLujo
        '
        Me.ComboMLujo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.ComboMLujo.AllowDrop = True
        Me.ComboMLujo.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ComboMLujo.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ComboMLujo.ForeColor = System.Drawing.Color.Black
        Me.ComboMLujo.FormattingEnabled = True
        Me.ComboMLujo.Location = New System.Drawing.Point(75, 350)
        Me.ComboMLujo.Name = "ComboMLujo"
        Me.ComboMLujo.Size = New System.Drawing.Size(300, 34)
        Me.ComboMLujo.TabIndex = 25
        Me.ComboMLujo.Text = "SELECCIONE UN MODELO"
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.Location = New System.Drawing.Point(125, 475)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(200, 50)
        Me.BotonCancelar.TabIndex = 24
        Me.BotonCancelar.Text = "C&ANCELAR"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'BotonContinuar
        '
        Me.BotonContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonContinuar.ForeColor = System.Drawing.Color.White
        Me.BotonContinuar.Location = New System.Drawing.Point(125, 400)
        Me.BotonContinuar.Name = "BotonContinuar"
        Me.BotonContinuar.Size = New System.Drawing.Size(200, 50)
        Me.BotonContinuar.TabIndex = 23
        Me.BotonContinuar.Text = "&CONTINUAR"
        Me.BotonContinuar.UseVisualStyleBackColor = False
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
        Me.LabelTitulo.TabIndex = 28
        Me.LabelTitulo.Text = "TARIFAS PARA MODELOS LUJOSOS"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tarea.My.Resources.Resources.lujo2
        Me.PictureBox1.Location = New System.Drawing.Point(25, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
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
        Me.LabelTitulo.TabIndex = 28
        Me.LabelTitulo.Text = "TARIFAS PARA MODELOS LUJOSOS"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GrupoPrecios)
        Me.Controls.Add(Me.ComboMLujo)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.BotonContinuar)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LUJO"
        Me.GrupoPrecios.ResumeLayout(False)
        Me.GrupoPrecios.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrupoPrecios As GroupBox
    Friend WithEvents TextoSemana As TextBox
    Friend WithEvents TextoDia As TextBox
    Friend WithEvents TextoMes As TextBox
    Friend WithEvents TextoHora As TextBox
    Friend WithEvents LabelPrecioSemana As Label
    Friend WithEvents LabelPrecioHora As Label
    Friend WithEvents LabelPrecioMes As Label
    Friend WithEvents LabelPrecioDia As Label
    Friend WithEvents ComboMLujo As ComboBox
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents BotonContinuar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTitulo As Label
End Class
