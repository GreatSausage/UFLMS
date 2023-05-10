Public Class FrmBookInfo
    Private Sub LabelClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteBooks(CLng(TxtIsbn.Text))
        Me.Close()
        DisplayByAvailability("ALL", FrmManageBooks.DisplayDatagrid)
        RecordCount("tblBooks", FrmDashboard.BooksCount)
    End Sub
End Class