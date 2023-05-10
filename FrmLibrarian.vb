Public Class FrmLibrarian
    Private Sub FrmLibrarian_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayAllBorrowersAndLibrarins(DisplayDatagrid, "tblLibrarians")
        DisplayDatagrid.Columns("emailAddress").Visible = False
        DisplayDatagrid.Columns("password").Visible = False
        DisplayDatagrid.Columns("question").Visible = False
        DisplayDatagrid.Columns("answer").Visible = False
        DisplayDatagrid.Columns("id").Visible = False
        DisplayDatagrid.Columns("firstName").HeaderText = "Firstname"
        DisplayDatagrid.Columns("lastName").HeaderText = "Lastname"
        DisplayDatagrid.Columns("address").HeaderText = "Address"
    End Sub

    Private Sub BtnAddBorrower_Click(sender As Object, e As EventArgs) Handles BtnAddBorrower.Click
        FrmAddLibrarian.ShowDialog()
        RecordCount("tblLibrarians", FrmDashboard.LibrariansCount)
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchLibrarians(DisplayDatagrid, TxtSearch.Text)
    End Sub

    Private Sub DisplayDatagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplayDatagrid.CellClick
        If DisplayDatagrid.SelectedCells.Count = 0 Then
            Dim result As DialogResult = MessageBox.Show("There is no record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If result = DialogResult.OK Then
                Return
            End If
        End If
        Dim frm As New FrmLibrarianInfo
        With DisplayDatagrid.CurrentRow.Cells
            frm.TxtID.Text = .Item(0).Value
            frm.TxtFirstname.Text = .Item(1).Value
            frm.TxtLastname.Text = .Item(2).Value
            frm.TxtAddress.Text = .Item(3).Value
            frm.TxtEmail.Text = .Item(4).Value
        End With
        frm.Owner = Me
        frm.ShowDialog()
        DisplayAllBorrowersAndLibrarins(DisplayDatagrid, "tblLibrarians")
    End Sub

End Class