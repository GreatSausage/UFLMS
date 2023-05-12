Public Class FrmAddBook
    Private Sub LabelClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        If String.IsNullOrEmpty(TxtIsbn.Text) Then
            MessageBox.Show("Please fill up the necessary fields before importing a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtAuthor.Text) Then
            MessageBox.Show("Please fill up the necessary fields before importing a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtTitle.Text) Then
            MessageBox.Show("Please fill up the necessary fields before importing a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ImportBooks(TxtIsbn.Text, TxtAuthor.Text, TxtTitle.Text)
        DisplayByAvailability("ALL", FrmManageBooks.DisplayDatagrid)
        RecordCount("tblBooks", FrmDashboard.BooksCount)
        DisplayAvailableBooks()
    End Sub

    Private Sub TxtIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIsbn.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        ElseIf TxtIsbn.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAuthor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAuthor.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTitle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTitle.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class