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
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.ComboMFamiliar = New System.Windows.Forms.ComboBox()
        Me.GrupoPrecios = New System.Windows.Forms.GroupBox()
        Me.TextoSemana = New System.Windows.Forms.TextBox()
        Me.TextoDia = New System.Windows.Forms.TextBox()
        Me.TextoMes = New System.Windows.Forms.TextBox()
        Me.TextoHora = New System.Windows.Forms.TextBox()
        Me.LabelPrecioSemana = New System.Windows.Forms.Label()
        Me.LabelPrecioHora = New System.Windows.Forms.Label()
        Me.LabelPrecioMes = New System.Windows.Forms.Label()
        Me.LabelPrecioDia = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.ImgFamiliar = New System.Windows.Forms.PictureBox()
        Me.GrupoPrecios.SuspendLayout()
        CType(Me.ImgFamiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.BotonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.Location = New System.Drawing.Point(125, 475)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(200, 50)
        Me.BotonCancelar.TabIndex = 18
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
        Me.BotonContinuar.TabIndex = 17
        Me.BotonContinuar.Text = "&CONTINUAR"
        Me.BotonContinuar.UseVisualStyleBackColor = False
        '
        'ComboMFamiliar
        '
        Me.ComboMFamiliar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.ComboMFamiliar.AllowDrop = True
        Me.ComboMFamiliar.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ComboMFamiliar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ComboMFamiliar.ForeColor = System.Drawing.Color.Black
        Me.ComboMFamiliar.FormattingEnabled = True
        Me.ComboMFamiliar.Location = New System.Drawing.Point(75, 350)
        Me.ComboMFamiliar.Name = "ComboMFamiliar"
        Me.ComboMFamiliar.Size = New System.Drawing.Size(300, 34)
        Me.ComboMFamiliar.TabIndex = 19
        Me.ComboMFamiliar.Text = "SELECCIONE UN MODELO"
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
        Me.GrupoPrecios.TabIndex = 20
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
        Me.TextoHora.HideSelection = False
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
        Me.LabelTitulo.TabIndex = 24
        Me.LabelTitulo.Text = "TARIFAS PARA MODELOS FAMILIARES"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgFamiliar
        '
        Me.ImgFamiliar.Image = Global.Tarea.My.Resources.Resources.familiar2
        Me.ImgFamiliar.Location = New System.Drawing.Point(25, 100)
        Me.ImgFamiliar.Name = "ImgFamiliar"
        Me.ImgFamiliar.Size = New System.Drawing.Size(400, 225)
        Me.ImgFamiliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgFamiliar.TabIndex = 11
        Me.ImgFamiliar.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.GrupoPrecios)
        Me.Controls.Add(Me.ComboMFamiliar)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.BotonContinuar)
        Me.Controls.Add(Me.ImgFamiliar)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FAMILIAR"
        Me.GrupoPrecios.ResumeLayout(False)
        Me.GrupoPrecios.PerformLayout()
        CType(Me.ImgFamiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImgFamiliar As PictureBox
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents BotonContinuar As Button
    Friend WithEvents ComboMFamiliar As ComboBox
    Friend WithEvents GrupoPrecios As GroupBox
    Friend WithEvents TextoSemana As TextBox
    Friend WithEvents TextoDia As TextBox
    Friend WithEvents TextoMes As TextBox
    Friend WithEvents TextoHora As TextBox
    Friend WithEvents LabelPrecioSemana As Label
    Friend WithEvents LabelPrecioHora As Label
    Friend WithEvents LabelPrecioMes As Label
    Friend WithEvents LabelPrecioDia As Label
    Friend WithEvents LabelTitulo As Label
End Class
