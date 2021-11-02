Public Class Form2
    Private Sub lblprecio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbtSedan_CheckedChanged(sender As Object, e As EventArgs) Handles radioFamiliar.CheckedChanged
        Form3.Show()


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub rbtLujo_CheckedChanged(sender As Object, e As EventArgs) Handles radioLujo.CheckedChanged
        radioLujo.Checked = True

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles imgFamiliar.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grupoOpciones.Enter

    End Sub

    Private Sub btnavanzar_Click(sender As Object, e As EventArgs) Handles botonCancelar.Click

    End Sub
End Class