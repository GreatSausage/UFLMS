Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class FrmAddBorrower

    Private Sub LabelClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelClose.LinkClicked
        Me.Close()
        TxtStudentID.Clear()
        TxtFirstName.Clear()
        TxtLastName.Clear()
        TxtAddress.Clear()
        TxtEmail.Clear()
        TxtCourse.SelectedIndex = -1
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT COUNT(*) FROM tblBorrowers WHERE studentID = @studentID", connection)
        command.Parameters.AddWithValue("@studentID", TxtStudentID.Text)
        Dim count As Integer = CInt(command.ExecuteScalar())

        If String.IsNullOrEmpty(TxtStudentID.Text) Then
            MessageBox.Show("Please enter your Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf count > 0 Then
            MessageBox.Show("Student ID already exists. Please enter a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtStudentID.Clear()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtFirstName.Text) Then
            MessageBox.Show("Please enter your first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLastName.Text) Then
            MessageBox.Show("Please enter your last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtCourse.Text) Then
            MessageBox.Show("Please enter your course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtAddress.Text) Then
            MessageBox.Show("Please enter your address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtEmail.Text) Then
            MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            AddBorrower(TxtStudentID.Text.ToString, TxtFirstName.Text.ToString, TxtLastName.Text.ToString, TxtCourse.Text.ToString, TxtAddress.Text.ToString, TxtEmail.Text.ToString)
            DisplayAllBorrowersAndLibrarins(FrmBorrower.DisplayDatagrid, "tblBorrowers")
            Me.Close()
        End If
    End Sub

    Private Sub TxtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStudentID.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        ElseIf TxtStudentID.Text.Length >= 7 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFirstName.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLastName.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCourse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCourse.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAddress.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        If (Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class