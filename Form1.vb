Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgPresentacion.Click

    End Sub


    Private Sub rbtprecio_CheckedChanged(sender As Object, e As EventArgs) Handles radioPrecio.CheckedChanged
        Form2.Show()


    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles botonCancelar.Click
        Me.Close()

    End Sub

    Private Sub goveleccion_Enter(sender As Object, e As EventArgs) Handles grupoSeleccion.Enter
        radioAlquiler.Checked = True
    End Sub

    Private Sub btnavanzar_Click(sender As Object, e As EventArgs) Handles botonContinuar.Click

    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles labelTitulo.Click

    End Sub
End Class
