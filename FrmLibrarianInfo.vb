Public Class FrmLibrarianInfo
    Private Sub LabelClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click_1(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim id As Integer = CInt(TxtID.Text)
        DeleteLibrarian(id)
        Me.Close()
        RecordCount("tblLibrarians", FrmDashboard.LibrariansCount)
    End Sub
End Class