Public Class FrmReturnedSetup
    Private Sub FrmReturnedSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayBorrowedBooks(DisplayDataGrid)
        DisplayDataGrid.Columns("bookTitle").HeaderText = "Book Title"
        DisplayDataGrid.Columns("bookAuthor").HeaderText = "Book Author"
        DisplayDataGrid.Columns("firstName").HeaderText = "Firstname"
        DisplayDataGrid.Columns("lastName").HeaderText = "Lastname"
        DisplayDataGrid.Columns("course").HeaderText = "Course"
        DisplayDataGrid.Columns("dateBorrowed").HeaderText = "Date Borrowed"
        DisplayDataGrid.Columns("dueDate").HeaderText = "Due Date"
        DisplayDataGrid.Columns("isbn").Visible = False
        DisplayDataGrid.Columns("studentID").Visible = False
    End Sub

    Private Sub DisplayDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplayDataGrid.CellClick
        If DisplayDataGrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DisplayDataGrid.SelectedRows(0)
            TxtBookTitle.Text = selectedRow.Cells("bookTitle").Value.ToString()
            TxtBookAuthor.Text = selectedRow.Cells("bookAuthor").Value.ToString()
            TxtFirstname.Text = selectedRow.Cells("firstName").Value.ToString()
            TxtLastname.Text = selectedRow.Cells("lastName").Value.ToString()
            TxtCourse.Text = selectedRow.Cells("course").Value.ToString()
            TxtISBN.Text = selectedRow.Cells("isbn").Value
            TxtStudentID.Text = selectedRow.Cells("studentID").Value
        End If
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If String.IsNullOrEmpty(TxtStudentID.Text) Then
            MessageBox.Show("Please fill up the necessary fields before confirming the borrow request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtISBN.Text) Then
            MessageBox.Show("Please select first a specific record below.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        ReturnBook()
            BooksAvailability("tblBooks", FrmDashboard.AvailableBooks, 1)
        BooksAvailability("tblBooks", FrmDashboard.BorrowedBooks, 0)
        DisplayBorrowedBooks(DisplayDataGrid)
    End Sub
End Class