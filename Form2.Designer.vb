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
        Me.GrupoOpciones = New System.Windows.Forms.GroupBox()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.ImgLujo = New System.Windows.Forms.PictureBox()
        Me.ImgFamiliar = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.RadioLujo = New System.Windows.Forms.RadioButton()
        Me.RadioFamiliar = New System.Windows.Forms.RadioButton()
        Me.GrupoOpciones.SuspendLayout()
        CType(Me.ImgLujo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgFamiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrupoOpciones
        '
        Me.GrupoOpciones.Controls.Add(Me.RadioFamiliar)
        Me.GrupoOpciones.Controls.Add(Me.RadioLujo)
        Me.GrupoOpciones.Controls.Add(Me.BotonContinuar)
        Me.GrupoOpciones.Controls.Add(Me.BotonCancelar)
        Me.GrupoOpciones.Controls.Add(Me.ImgLujo)
        Me.GrupoOpciones.Controls.Add(Me.ImgFamiliar)
        Me.GrupoOpciones.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoOpciones.Location = New System.Drawing.Point(12, 60)
        Me.GrupoOpciones.Name = "GrupoOpciones"
        Me.GrupoOpciones.Size = New System.Drawing.Size(858, 489)
        Me.GrupoOpciones.TabIndex = 1
        Me.GrupoOpciones.TabStop = False
        Me.GrupoOpciones.Text = "ESCOJA UNA OPCIÓN"
        '
        'BotonContinuar
        '
        Me.BotonContinuar.BackColor = System.Drawing.Color.White
        Me.BotonContinuar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonContinuar.Location = New System.Drawing.Point(522, 349)
        Me.BotonContinuar.Name = "BotonContinuar"
        Me.BotonContinuar.Size = New System.Drawing.Size(218, 100)
        Me.BotonContinuar.TabIndex = 7
        Me.BotonContinuar.Text = "C&ONTINUAR"
        Me.BotonContinuar.UseVisualStyleBackColor = False
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.White
        Me.BotonCancelar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCancelar.Location = New System.Drawing.Point(126, 349)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(218, 100)
        Me.BotonCancelar.TabIndex = 6
        Me.BotonCancelar.Text = "&CANCELAR"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'ImgLujo
        '
        Me.ImgLujo.Image = CType(resources.GetObject("ImgLujo.Image"), System.Drawing.Image)
        Me.ImgLujo.Location = New System.Drawing.Point(53, 85)
        Me.ImgLujo.Name = "ImgLujo"
        Me.ImgLujo.Size = New System.Drawing.Size(350, 200)
        Me.ImgLujo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLujo.TabIndex = 5
        Me.ImgLujo.TabStop = False
        '
        'ImgFamiliar
        '
        Me.ImgFamiliar.Image = CType(resources.GetObject("ImgFamiliar.Image"), System.Drawing.Image)
        Me.ImgFamiliar.Location = New System.Drawing.Point(460, 85)
        Me.ImgFamiliar.Name = "ImgFamiliar"
        Me.ImgFamiliar.Size = New System.Drawing.Size(350, 200)
        Me.ImgFamiliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgFamiliar.TabIndex = 4
        Me.ImgFamiliar.TabStop = False
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
        Me.LabelTitulo.Size = New System.Drawing.Size(884, 67)
        Me.LabelTitulo.TabIndex = 7
        Me.LabelTitulo.Text = "TARIFAS"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RadioLujo
        '
        Me.RadioLujo.AutoSize = True
        Me.RadioLujo.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RadioLujo.Location = New System.Drawing.Point(138, 298)
        Me.RadioLujo.Name = "RadioLujo"
        Me.RadioLujo.Size = New System.Drawing.Size(206, 30)
        Me.RadioLujo.TabIndex = 8
        Me.RadioLujo.TabStop = True
        Me.RadioLujo.Text = "MODELOS DE LUJO"
        Me.RadioLujo.UseVisualStyleBackColor = True
        '
        'RadioFamiliar
        '
        Me.RadioFamiliar.AutoSize = True
        Me.RadioFamiliar.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RadioFamiliar.Location = New System.Drawing.Point(510, 298)
        Me.RadioFamiliar.Name = "RadioFamiliar"
        Me.RadioFamiliar.Size = New System.Drawing.Size(240, 30)
        Me.RadioFamiliar.TabIndex = 9
        Me.RadioFamiliar.TabStop = True
        Me.RadioFamiliar.Text = "MODELOS FAMILIARES"
        Me.RadioFamiliar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.GrupoOpciones)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PANTALLA - PRECIOS"
        Me.GrupoOpciones.ResumeLayout(False)
        Me.GrupoOpciones.PerformLayout()
        CType(Me.ImgLujo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgFamiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrupoOpciones As GroupBox
    Friend WithEvents ImgFamiliar As PictureBox
    Friend WithEvents ImgLujo As PictureBox
    Friend WithEvents BotonCancelar As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents BotonContinuar As Button
    Friend WithEvents RadioFamiliar As RadioButton
    Friend WithEvents RadioLujo As RadioButton
End Class
