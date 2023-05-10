Public Class FrmSignInScreen
    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If showPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please enter your email")
            Exit Sub
        ElseIf String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("Please enter your password")
            Exit Sub
        End If
        Signin(txtEmail.Text, txtPassword.Text)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        FrmForgotPassword.Show()
    End Sub
End Class
