Public Class FrmAddLibrarian
    Private Sub FrmAddLibrarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelClose.LinkClicked
        Me.Close()
    End Sub

    'Private Sub ShowPassword_CheckedChanged_1(sender As Object, e As EventArgs)
    '    If ShowPassword.Checked Then
    '        TxtPassword.PasswordChar = ""
    '        TxtConfirmPass.PasswordChar = ""
    '    Else
    '        TxtPassword.PasswordChar = "●"
    '        TxtConfirmPass.PasswordChar = "●"
    '    End If
    'End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        If String.IsNullOrEmpty(TxtFirstname.Text) Then
            MessageBox.Show("Please enter your firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLastname.Text) Then
            MessageBox.Show("Please enter your lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(txtaddress.Text) Then
            MessageBox.Show("Please enter your address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtEmail.text) Then
            MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtPassword.Text) Then
            MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtConfirmPass.Text) Then
            MessageBox.Show("Please confirm your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtQuestion.Text) Then
            MessageBox.Show("Please choose a question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtAnswer.Text) Then
            MessageBox.Show("Please enter your answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf TxtPassword.Text <> TxtConfirmPass.Text Then
            MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        AddLibrarians(TxtFirstname.Text, TxtLastname.Text, TxtAddress.Text, TxtEmail.Text, TxtPassword.Text, TxtQuestion.Text, TxtAnswer.Text)
        DisplayAllBorrowersAndLibrarins(FrmLibrarian.DisplayDatagrid, "tblLibrarians")
        Me.Close()
    End Sub

    Private Sub TxtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFirstname.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLastname.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAddress.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class