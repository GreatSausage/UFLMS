Public Class FrmBorrowerSetup
    Private Sub FrmBorrowerSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayAvailableBooks(DisplayDataGrid)
        DisplayDataGrid.Columns("isbn").HeaderText = "ISBN"
        DisplayDataGrid.Columns("bookAuthor").HeaderText = "Book Author"
        DisplayDataGrid.Columns("bookTitle").HeaderText = "Book Title"
    End Sub

    Private Sub TxtStudentID_LostFocus(sender As Object, e As EventArgs) Handles TxtStudentID.LostFocus
        Dim studentID As Integer
        If Integer.TryParse(TxtStudentID.Text, studentID) Then
            DisplayAutomatically(studentID, TxtFirstname, TxtLastname, TxtCourse)
        End If
    End Sub

    Private Sub DisplayAvailableBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplayDataGrid.CellClick
        If DisplayDataGrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DisplayDataGrid.SelectedRows(0)
            TxtISBN.Text = selectedRow.Cells("isbn").Value.ToString()
            TxtBookAuthor.Text = selectedRow.Cells("bookAuthor").Value.ToString()
            TxtBookTitle.Text = selectedRow.Cells("bookTitle").Value.ToString()
        End If
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If String.IsNullOrEmpty(TxtStudentID.Text) Then
            MessageBox.Show("Please fill up the necessary fields before confirming the borrow request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf TxtStudentID.Text.Length <> 7 Then
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtStudentID.Clear()
            Exit Sub
        End If
        BookExistence(TxtISBN.Text)
        DisplayAvailableBooks(DisplayDataGrid)
        DisplayAvailableBooks()
        DisplayBorrowedBooks()
        DisplayBorrowedBooks(FrmReturnedSetup.DisplayDataGrid)
    End Sub

    Private Sub TxtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStudentID.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        ElseIf TxtStudentID.Text.Length >= 7 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class