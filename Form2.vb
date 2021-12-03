Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Dispose()
    End Sub

    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        If RadioFamiliar.Checked Then
            Form3.Show()
            ''Form5.RadioTipoVehiculoFamiliar.Checked = RadioFamiliar.Checked
        End If
        If RadioLujo.Checked Then
            Form4.Show()
            ''Form5.RadioTipoVehiculoLujo.Checked = RadioLujo.Checked
        End If
    End Sub

    Private Sub RadioLujo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioLujo.CheckedChanged

    End Sub
End Class