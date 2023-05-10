Public Class FrmForgotPassword
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        ForgotPassword(TxtEmail.Text)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        SaveNewPassword()
    End Sub
End Class