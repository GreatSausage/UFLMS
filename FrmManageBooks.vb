Public Class FrmManageBooks
    Private Sub FrmManageBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayByAvailability("ALL", DisplayDatagrid)
        DisplayDatagrid.Columns("isbn").HeaderText = "ISBN"
        DisplayDatagrid.Columns("bookTitle").HeaderText = "Book Title"
        DisplayDatagrid.Columns("bookAuthor").HeaderText = "Book Author"
    End Sub

    Private Sub BtnAddBorrower_Click(sender As Object, e As EventArgs) Handles BtnAddBorrower.Click
        FrmAddBook.ShowDialog()
        DisplayByAvailability("ALL", DisplayDatagrid)
    End Sub

    Private Sub TxtIsAvailable_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles TxtIsAvailable.SelectedIndexChanged
        DisplayByAvailability(TxtIsAvailable.SelectedItem.ToString, DisplayDatagrid)
        DisplayDamagedAndLost()
    End Sub

    Private Sub DisplayDatagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplayDatagrid.CellClick
        If DisplayDatagrid.SelectedCells.Count = 0 Then
            Dim result As DialogResult = MessageBox.Show("There is no record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If result = DialogResult.OK Then
                Return
            End If
        End If
        Dim frm As New FrmBookInfo
        With DisplayDatagrid.CurrentRow.Cells
            frm.TxtIsbn.Text = .Item(0).Value
            frm.TxtBookAuthor.Text = .Item(1).Value
            frm.TxtBookTitle.Text = .Item(2).Value
        End With
        frm.Owner = Me
        frm.ShowDialog()
    End Sub

    Private Sub TxtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchBooks(DisplayDatagrid, TxtSearch.Text)
    End Sub

    Private Sub TxtGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtGenre.SelectedIndexChanged
        DisplayByGenre()
    End Sub
End Class