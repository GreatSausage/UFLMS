Imports System.Data.SqlClient

Public Class frmLoginScreen
    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If showPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please enter your email")
            Exit Sub
        ElseIf String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("Please enter your password")
            Exit Sub
        Else
            Dim connection As SqlConnection = openConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
            Dim email As String = txtEmail.Text
            Dim command As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE emailAddress = @emailAddress", connection)
            command.Parameters.AddWithValue("@emailAddress", txtEmail.Text)

            If CInt(command.ExecuteScalar()) > 0 Then
                Dim commandTwo As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE emailAddress = @emailAddress AND password = @password", connection)
                commandTwo.Parameters.AddWithValue("@emailAddress", txtEmail.Text)
                commandTwo.Parameters.AddWithValue("@password", txtPassword.Text)

                If CInt(commandTwo.ExecuteScalar()) > 0 Then
                    Dim frmAddLibrarians As New frmAddLibrarians()
                    frmAddLibrarians.Show()
                    Me.Hide()
                Else
                    MsgBox("Incorrect Password")
                End If

            Else
                MsgBox("Email not found")
            End If
        End If
    End Sub

End Class
