Public Class FrmMain
    Private Sub FrmLibrarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayFormPanel(FrmDashboard, PanelDisplay)
    End Sub

    Private Sub FrmLibrarian_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - 40
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        DisplayFormPanel(FrmDashboard, PanelDisplay)
    End Sub

    Private Sub BtnBorrower_Click(sender As Object, e As EventArgs) Handles BtnBorrower.Click
        DisplayFormPanel(FrmBorrower, PanelDisplay)
    End Sub

    Private Sub BtnLibrarian_Click(sender As Object, e As EventArgs) Handles BtnLibrarian.Click
        DisplayFormPanel(FrmLibrarian, PanelDisplay)
    End Sub

    Private Sub BtnManageBooks_Click(sender As Object, e As EventArgs) Handles BtnManageBooks.Click
        DisplayFormPanel(FrmManageBooks, PanelDisplay)
    End Sub

    Private Sub BtnAccountSettings_Click(sender As Object, e As EventArgs)
        DisplayFormPanel(FrmAccountSettings, PanelDisplay)
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        Me.Close()
        FrmSignInScreen.Show()
    End Sub

    Private Sub btnBorrowedBooks_Click(sender As Object, e As EventArgs) Handles btnBorrowedBooks.Click
        DisplayFormPanel(FrmBorrowerSetup, PanelDisplay)
    End Sub

    Private Sub BtnBorrowHistory_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtnAccountSettings_Click_1(sender As Object, e As EventArgs) 
        DisplayFormPanel(FrmAccountSettings, PanelDisplay)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayFormPanel(FrmReturnedSetup, PanelDisplay)
    End Sub

    Private Sub BtnBorrowHistory_Click_2(sender As Object, e As EventArgs) Handles BtnBorrowHistory.Click
        DisplayFormPanel(FrmHistory, PanelDisplay)
    End Sub

    Private Sub BtnAccountSettings_Click_2(sender As Object, e As EventArgs) Handles BtnAccountSettings.Click
        DisplayFormPanel(FrmAccountSettings, PanelDisplay)
    End Sub
End Class