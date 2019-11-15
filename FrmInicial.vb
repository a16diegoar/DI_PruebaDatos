Public Class FrmInicial
    Private Sub Salir(sender As Object, e As EventArgs) Handles MnuSalir.Click, TsSalir.Click
        Me.Close()
    End Sub

    Private Sub SociosBenef_Click(sender As Object, e As EventArgs) Handles MnuSociosBenef.Click, TsSociosBenef.Click
        Dim frmSocBenef As New FrmMantSocBenef
        frmSocBenef.ShowDialog()
    End Sub
End Class