Public Class FrmBorrowerInfo
    Private textbox As Boolean = False
    Private Sub LabelClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        UpdateBorrower(TxtStudentID.Text.ToString, TxtFirstName.Text.ToString, TxtLastName.Text.ToString, TxtCourse.Text.ToString, TxtAddress.Text.ToString, TxtEmail.Text.ToString)
        Me.Close()
    End Sub

    Private Sub FrmBorrowerInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnUpdate.Enabled = False
        textbox = False
    End Sub

    Private Sub TxtFirstName_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstName.TextChanged
        textbox = True
        BtnUpdate.Enabled = True
    End Sub

    Private Sub TxtLastName_TextChanged(sender As Object, e As EventArgs) Handles TxtLastName.TextChanged
        textbox = True
        BtnUpdate.Enabled = True
    End Sub

    Private Sub TxtCourse_TextChanged(sender As Object, e As EventArgs) Handles TxtCourse.TextChanged
        textbox = True
        BtnUpdate.Enabled = True
    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtAddress.TextChanged
        textbox = True
        BtnUpdate.Enabled = True
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        textbox = True
        BtnUpdate.Enabled = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim studentID As Integer = CInt(TxtStudentID.Text)
        DeleteBorrower(studentID, TxtFirstName.Text, TxtLastName.Text, TxtCourse.Text, TxtAddress.Text, TxtEmail.Text)
        Me.Close()
        RecordCount("tblBorrowers", FrmDashboard.BorrowersCount)
    End Sub

    Private Sub TxtCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtCourse.SelectedIndexChanged
        textbox = True
        BtnUpdate.Enabled = True
    End Sub

    Private Sub TxtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFirstName.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLastName.KeyPress
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