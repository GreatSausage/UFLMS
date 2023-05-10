Public Class FrmBorrower
    Private Sub FrmBorrower_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayAllBorrowersAndLibrarins(DisplayDatagrid, "tblBorrowers")
        DisplayDatagrid.Columns("studentID").HeaderText = "Student ID"
        DisplayDatagrid.Columns("firstName").HeaderText = "Firstname"
        DisplayDatagrid.Columns("lastName").HeaderText = "Lastname"
        DisplayDatagrid.Columns("course").HeaderText = "Course"
        DisplayDatagrid.Columns("address").Visible = False
        DisplayDatagrid.Columns("emailAddress").Visible = False

    End Sub

    Private Sub TxtSelectedCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSelectedCourse.SelectedIndexChanged
        DisplayByCourse(TxtSelectedCourse.Text.ToString, DisplayDatagrid)
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchBorrowers(DisplayDatagrid, TxtSearch.Text)
    End Sub

    Private Sub DisplayDatagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplayDatagrid.CellClick
        If DisplayDatagrid.SelectedCells.Count = 0 Then
            Dim result As DialogResult = MessageBox.Show("There is no record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If result = DialogResult.OK Then
                Return
            End If
        End If
        Dim frm As New FrmBorrowerInfo
        With DisplayDatagrid.CurrentRow.Cells
            frm.TxtStudentID.Text = .Item(0).Value
            frm.TxtFirstName.Text = .Item(1).Value
            frm.TxtLastName.Text = .Item(2).Value
            frm.TxtCourse.Text = .Item(3).Value
            frm.TxtAddress.Text = .Item(4).Value
            frm.TxtEmail.Text = .Item(5).Value
        End With
        frm.Owner = Me
            frm.ShowDialog()
        DisplayAllBorrowersAndLibrarins(DisplayDatagrid, "tblBorrowers")
    End Sub

    Private Sub BtnAddBorrower_Click_1(sender As Object, e As EventArgs) Handles BtnAddBorrower.Click
        FrmAddBorrower.ShowDialog()
        RecordCount("tblBorrowers", FrmDashboard.BorrowersCount)
    End Sub
End Class