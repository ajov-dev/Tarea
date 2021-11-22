Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Dispose()
    End Sub

    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        If RadioPrecio.Checked Then
            Form2.Show()
        End If
        If RadioReservacion.Checked Then
            Form5.Show()
        End If
        If RadioAlquiler.Checked Then
            Form6.Show()
        End If
    End Sub
End Class
