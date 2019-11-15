Public Class FrmAuxSocio
    Private Sub BtnAcept_Click(sender As Object, e As EventArgs) Handles BtnAcept.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class