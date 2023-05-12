Public Class FrmHistory
    Private Sub FrmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBorrowHistory(DisplayDatagrid)
        DisplayDatagrid.Columns("bookTitle").HeaderText = "Book Title"
        DisplayDatagrid.Columns("bookAuthor").HeaderText = "Book Author"
        DisplayDatagrid.Columns("firstName").HeaderText = "Firstname"
        DisplayDatagrid.Columns("lastName").HeaderText = "Lastname"
        DisplayDatagrid.Columns("course").HeaderText = "Course"
        DisplayDatagrid.Columns("dateBorrowed").HeaderText = "Date Borrowed"
        DisplayDatagrid.Columns("dueDate").HeaderText = "Due Date"
        DisplayDatagrid.Columns("isbn").Visible = False
        DisplayDatagrid.Columns("studentID").Visible = False
        TxtDisplay.SelectedIndex = 0
    End Sub

    Private Sub TxtDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDisplay.SelectedIndexChanged
        Auditing()
    End Sub

    Private Sub BtnDeleteAll_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll.Click
        DeleteHistory()
    End Sub
End Class