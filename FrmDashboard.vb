Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        RecordCount("tblBorrowers", BorrowersCount)
        RecordCount("tblLibrarians", LibrariansCount)
        RecordCount("tblBooks", BooksCount)
        BooksAvailability("tblBooks", AvailableBooks, 1)
        BooksAvailability("tblBooks", BorrowedBooks, 0)
        RecordCount("tblDamagedBooks", DamagedCount)
        RecordCount("tblLostBooks", LostCount)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currentDate As String = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        Dim currentTime As String = DateTime.Now.ToString("h:mm:ss tt")
        Dim currentDateTime As String = currentTime
        DisplayDate.Text = currentDate
        DisplayTime.Text = currentDateTime
    End Sub

End Class
