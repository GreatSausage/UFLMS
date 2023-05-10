Public Class FrmHistory
    Private Sub FrmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBorrowHistory(DisplayDatagrid)
        DisplayDatagrid.Columns(0).HeaderText = "Book Title"
        DisplayDatagrid.Columns("bookAuthor").HeaderText = "Book Author"
        DisplayDatagrid.Columns("firstName").HeaderText = "Firstname"
        DisplayDatagrid.Columns("lastName").HeaderText = "Lastname"
        DisplayDatagrid.Columns("course").HeaderText = "Course"
        DisplayDatagrid.Columns("dateBorrowed").HeaderText = "Date Borrowed"
        DisplayDatagrid.Columns("dueDate").HeaderText = "Due Date"
        DisplayDatagrid.Columns("isbn").Visible = False
        DisplayDatagrid.Columns("studentID").Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        DisplayBorrowHistory(DisplayDatagrid)
        DisplayDatagrid.Columns(0).HeaderText = "Book Title"
        DisplayDatagrid.Columns("bookAuthor").HeaderText = "Book Author"
        DisplayDatagrid.Columns("firstName").HeaderText = "Firstname"
        DisplayDatagrid.Columns("lastName").HeaderText = "Lastname"
        DisplayDatagrid.Columns("course").HeaderText = "Course"
        DisplayDatagrid.Columns("dateBorrowed").HeaderText = "Date Borrowed"
        DisplayDatagrid.Columns("dueDate").HeaderText = "Due Date"
        DisplayDatagrid.Columns("isbn").Visible = False
        DisplayDatagrid.Columns("studentID").Visible = False
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        DisplayReturnHistory(DisplayDatagrid)
        DisplayDatagrid.Columns("dateReturned").HeaderText = "Date Returned"
    End Sub
End Class