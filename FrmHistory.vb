Public Class FrmHistory
    Private Sub FrmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DisplayBorrowHistory(DisplayDatagrid)
        'DisplayDatagrid.Columns(0).HeaderText = "Book Title"
        'DisplayDatagrid.Columns("bookAuthor").HeaderText = "Book Author"
        'DisplayDatagrid.Columns("firstName").HeaderText = "Firstname"
        'DisplayDatagrid.Columns("lastName").HeaderText = "Lastname"
        'DisplayDatagrid.Columns("course").HeaderText = "Course"
        'DisplayDatagrid.Columns("dateBorrowed").HeaderText = "Date Borrowed"
        'DisplayDatagrid.Columns("dueDate").HeaderText = "Due Date"
        'DisplayDatagrid.Columns("isbn").Visible = False
        'DisplayDatagrid.Columns("studentID").Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
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
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        DisplayReturnHistory(DisplayDatagrid)
        DisplayDatagrid.Columns("dateReturned").HeaderText = "Date Returned"
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        DisplayBorrowerCreation(DisplayDatagrid)
        DisplayDatagrid.Columns("id").Visible = False
        DisplayDatagrid.Columns("firstName").HeaderText = "Firstname"
        DisplayDatagrid.Columns("lastName").HeaderText = "Lastname"
        DisplayDatagrid.Columns("course").HeaderText = "Course"
        DisplayDatagrid.Columns("address").HeaderText = "Address"
        DisplayDatagrid.Columns("emailAddress").HeaderText = "Email Address"
    End Sub

    Private Sub TxtDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDisplay.SelectedIndexChanged
        Auditing()
    End Sub
End Class