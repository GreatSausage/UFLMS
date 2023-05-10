Public Class FrmAccountSettings
    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If showPassword.Checked Then
            TxtPassword.PasswordChar = ""
            TxtConfirmPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "●"
            TxtConfirmPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub TxtFirstname_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstname.TextChanged
        BtnSave.Enabled = True
    End Sub


    Private Sub FrmAccountSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnSave.Enabled = False
    End Sub

    Private Sub TxtLastname_TextChanged(sender As Object, e As EventArgs) Handles TxtLastname.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtAddress.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Sub TxtAnswer_TextChanged(sender As Object, e As EventArgs) Handles TxtAnswer.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Sub TxtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtConfirmPassword.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(TxtFirstname.Text) Then
            MessageBox.Show("Please fill up the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLastname.Text) Then
            MessageBox.Show("Please fill up the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtAddress.Text) Then
            MessageBox.Show("Please fill up the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtAnswer.Text) Then
            MessageBox.Show("Please fill up the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtPassword.Text) Then
            MessageBox.Show("Please fill up the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtConfirmPassword.Text) Then
            MessageBox.Show("Please fill up the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SavedChanges()
    End Sub
End Class