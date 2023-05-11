Imports System.Data.SqlClient
Imports System.Web

Module mdlDatabaseRelated


    Dim adapter As SqlDataAdapter
    Dim dataset As DataSet

    'TAGA OPEN NG CONNECTION STRING
    Public Function OpenConnectionString(connectionString As String) As SqlConnection
        Dim connection As SqlConnection = Nothing
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connection
    End Function

#Region "SIGN IN SCREEN METHODS"
    Public Sub Signin(emailAddress As String, password As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim commandLibrarians As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE emailAddress = @emailAddress", connection)
        Dim commandAdmin As New SqlCommand("SELECT COUNT(*) FROM tblAdmin WHERE emailAddress = @emailAddress", connection)
        commandLibrarians.Parameters.AddWithValue("@emailAddress", emailAddress)
        commandAdmin.Parameters.AddWithValue("@emailAddress", emailAddress)

        If CInt(commandLibrarians.ExecuteScalar()) > 0 Then
            Dim commandLibrarianPassword As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE password = @password", connection)
            commandLibrarianPassword.Parameters.AddWithValue("@password", password)

            If CInt(commandLibrarianPassword.ExecuteScalar()) > 0 Then
                FrmMain.Show()
                FrmSignInScreen.Close()
                FrmMain.BtnLibrarian.Visible = False
                FrmMain.BtnBorrowHistory.Visible = False

                Dim commandOne As New SqlCommand("SELECT * FROM tblLibrarians WHERE emailAddress = @emailAddress", connection)
                commandOne.Parameters.AddWithValue("@emailAddress", emailAddress)

                Dim adapter As New SqlDataAdapter(commandOne)
                Dim datatable As New DataTable()
                adapter.Fill(datatable)

                With FrmAccountSettings
                    .TxtID.Text = datatable.Rows(0)("id")
                    .TxtFirstname.Text = datatable.Rows(0)("firstName").ToString()
                    .TxtLastname.Text = datatable.Rows(0)("lastName").ToString()
                    .TxtAddress.Text = datatable.Rows(0)("address").ToString()
                    .TxtEmail.Text = datatable.Rows(0)("emailAddress").ToString()
                    .TxtPassword.Text = datatable.Rows(0)("password").ToString
                    .TxtQuestion.Text = datatable.Rows(0)("question").ToString()
                    .TxtAnswer.Text = datatable.Rows(0)("answer").ToString()
                End With

            Else
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf CInt(commandAdmin.ExecuteScalar()) > 0 Then
            Dim commandAdminPassword As New SqlCommand("SELECT COUNT(*) FROM tblAdmin WHERE password = @password", connection)
            commandAdminPassword.Parameters.AddWithValue("@password", password)

            If CInt(commandAdminPassword.ExecuteScalar()) > 0 Then
                FrmMain.Show()
                FrmSignInScreen.Close()

                Dim commandOne As New SqlCommand("SELECT * FROM tblAdmin WHERE emailAddress = @emailAddress", connection)
                commandOne.Parameters.AddWithValue("@emailAddress", emailAddress)

                Dim adapter As New SqlDataAdapter(commandOne)
                Dim datatable As New DataTable()
                adapter.Fill(datatable)

                With FrmAccountSettings
                    .TxtID.Text = datatable.Rows(0)("id")
                    .TxtFirstname.Text = datatable.Rows(0)("firstName").ToString()
                    .TxtLastname.Text = datatable.Rows(0)("lastName").ToString()
                    .TxtAddress.Text = datatable.Rows(0)("address").ToString()
                    .TxtEmail.Text = datatable.Rows(0)("emailAddress").ToString()
                    .TxtPassword.Text = datatable.Rows(0)("password").ToString
                    .TxtQuestion.Text = datatable.Rows(0)("question").ToString()
                    .TxtAnswer.Text = datatable.Rows(0)("answer").ToString()
                End With
            Else
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            MessageBox.Show("Email not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FrmSignInScreen.txtEmail.Clear()
            FrmSignInScreen.txtPassword.Clear()
        End If

    End Sub
#End Region



#Region "DASHBOARD FORM METHODS"
    Public Sub RecordCount(tableName As String, labelCount As Label)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT COUNT(*) FROM " & tableName & "", connection)
        Dim count As Integer = CInt(command.ExecuteScalar())
        connection.Close()
        labelCount.Text = count.ToString()
    End Sub

#End Region



#Region "BORROWER FORM METHOD"
    Public Sub DisplayByCourse(course As String, datagridview As DataGridView)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim commandText As String = "SELECT * FROM tblBorrowers"
        Select Case course.ToString()
            Case "CCS"
                commandText += " WHERE course IN ('BSIT', 'BSCS')"
            Case "CBAA"
                commandText += " WHERE course IN ('BSA', 'BSBA')"
            Case "COE"
                commandText += " WHERE course IN ('BSE', 'BEED')"
            Case "COHM"
                commandText += " WHERE course = 'BSHRM'"
            Case "All"
                commandText = commandText
        End Select
        Dim command As New SqlCommand(commandText, connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        datagridview.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    Public Sub AddBorrower(studentID As String, firstname As String, lastname As String, course As String, address As String, email As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")

        Dim commandOne As New SqlCommand("INSERT INTO tblBorrowers (studentID, firstName, lastName, course, address, emailAddress) VALUES (@studentID, @firstName, @lastName, @course, @address, @emailAddress)", connection)
        With commandOne.Parameters
            .AddWithValue("@studentID", studentID)
            .AddWithValue("@firstName", firstname)
            .AddWithValue("@lastName", lastname)
            .AddWithValue("@course", course)
            .AddWithValue("@address", address)
            .AddWithValue("@emailAddress", email)
        End With
        commandOne.ExecuteNonQuery()

        Dim commandTwo As New SqlCommand("INSERT INTO tblBorrowerHistory (studentID, firstName, lastName, course, address, emailAddress, dateCreated) VALUES (@studentID, @firstName, @lastName, @course, @address, @emailAddress, GETDATE())", connection)
        With commandTwo.Parameters
            .AddWithValue("@studentID", studentID)
            .AddWithValue("@firstName", firstname)
            .AddWithValue("@lastName", lastname)
            .AddWithValue("@course", course)
            .AddWithValue("@address", address)
            .AddWithValue("@emailAddress", email)
        End With
        commandTwo.ExecuteNonQuery()
        connection.Close()
        DisplayBorrowerCreation(FrmHistory.DisplayDatagrid)
        MessageBox.Show("Borrower added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SearchBorrowers(dataGridView As DataGridView, searchKeyword As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim query As String = "SELECT * FROM tblBorrowers"
        If Not String.IsNullOrEmpty(searchKeyword) Then
            query += " WHERE firstName LIKE @searchKeyword OR lastName LIKE @searchKeyword OR studentID LIKE @searchKeyword"
        End If
        Dim command As New SqlCommand(query, connection)
        If Not String.IsNullOrEmpty(searchKeyword) Then
            command.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")
        End If
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        dataGridView.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    Public Sub UpdateBorrower(studentID As String, firstname As String, lastname As String, course As String, address As String, emailaddress As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("UPDATE tblBorrowers SET studentID = @studentID, firstName = @firstname, lastName = @lastname, course = @course, address = @address, emailAddress = @email WHERE studentID = @studentID", connection)
        With command.Parameters
            .AddWithValue("@studentID", studentID)
            .AddWithValue("@firstName", firstname)
            .AddWithValue("@lastName", lastname)
            .AddWithValue("@course", course)
            .AddWithValue("@address", address)
            .AddWithValue("@email", emailaddress)
        End With
        command.ExecuteNonQuery()
        connection.Close()
        MsgBox("Updated Successfully")
    End Sub

    Public Sub DeleteBorrower(ByVal studentID As Integer)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim command As New SqlCommand("DELETE FROM tblBorrowers WHERE studentID = @studentID", connection)
            command.Parameters.AddWithValue("@studentID", studentID)
            command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region



#Region "LIBRARIAN FORM METHODS"
    Public Sub AddLibrarians(firstname As String, lastname As String, address As String, email As String, password As String, question As String, answer As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE emailAddress = @email", connection)
        checkCommand.Parameters.AddWithValue("@email", email)
        If CInt(checkCommand.ExecuteScalar()) > 0 Then
            MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FrmAddLibrarian.TxtEmail.Text = ""
            Exit Sub
        Else
            Dim command As New SqlCommand("INSERT INTO tblLibrarians (firstName, lastName, address, emailAddress, password, question, answer) 
            VALUES (@firstname, @lastname, @address, @email, @password, @question, @answer)", connection)
            With command.Parameters
                .AddWithValue("@firstname", firstname)
                .AddWithValue("@lastname", lastname)
                .AddWithValue("@address", address)
                .AddWithValue("@email", email)
                .AddWithValue("@password", password)
                .AddWithValue("@question", question)
                .AddWithValue("@answer", answer)
            End With
            command.ExecuteNonQuery()
            MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        connection.Close()
    End Sub

    Public Sub DeleteLibrarian(ByVal id As Integer)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("DELETE FROM tblLibrarians WHERE id = @id", connection)
        command.Parameters.AddWithValue("@id", id)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            command.ExecuteNonQuery()
            MessageBox.Show("Record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            FrmLibrarianInfo.Close()
        End If
    End Sub

    Public Sub SearchLibrarians(dataGridView As DataGridView, searchKeyword As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim query As String = "SELECT * FROM tblLibrarians"
        If Not String.IsNullOrEmpty(searchKeyword) Then
            query += " WHERE firstName LIKE @searchKeyword OR lastName LIKE @searchKeyword"
        End If
        Dim command As New SqlCommand(query, connection)
        If Not String.IsNullOrEmpty(searchKeyword) Then
            command.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")
        End If
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        dataGridView.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub
#End Region



#Region "MANAGE BOOK FORM METHOD"

    Public Sub DisplayByGenre()
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim commandText As String = "SELECT isbn, bookAuthor, bookTitle FROM tblBooks"
        Select Case FrmManageBooks.TxtGenre.Text
            Case "Computer Studies"
                commandText += " WHERE bookGenre = 'Computer Studies'"
            Case "Business Administration"
                commandText += " WHERE bookGenre = 'Business Administration'"
            Case "Education"
                commandText += " WHERE bookGenre = 'Education'"
            Case "Hospitality Management"
                commandText += " WHERE bookGenre = 'Hospitality Management'"
            Case "All"
                commandText = commandText
            Case "Others"
                commandText += " WHERE bookGenre = 'Others'"
        End Select
        Dim command As New SqlCommand(commandText, connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        FrmManageBooks.DisplayDatagrid.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub
    Public Sub DisplayByAvailability(isAvailable As String, datagridview As DataGridView)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim commandText As String = "SELECT isbn, bookAuthor, bookTitle FROM tblBooks"
        Select Case isAvailable.ToString()
            Case "ALL"
                commandText = commandText
            Case "AVAILABLE"
                commandText += " WHERE availability = 1"
            Case "UNAVAILABLE"
                commandText += " WHERE availability = 0"
        End Select
        Dim command As New SqlCommand(commandText, connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        datagridview.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    Public Sub BooksAvailability(tableName As String, labelCount As Label, availability As Integer)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT COUNT(*) FROM " & tableName & " WHERE availability = " & availability & "", connection)
        Dim count As Integer = CInt(command.ExecuteScalar())
        connection.Close()
        labelCount.Text = count.ToString()
    End Sub

    Public Sub SearchBooks(dataGridView As DataGridView, searchKeyword As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim query As String = "SELECT isbn, bookAuthor, bookTitle FROM tblBooks"
        If Not String.IsNullOrEmpty(searchKeyword) Then
            query += " WHERE isbn LIKE @searchKeyword OR bookAuthor LIKE @searchKeyword OR bookTitle LIKE @searchKeyword"
        End If
        Dim command As New SqlCommand(query, connection)
        If Not String.IsNullOrEmpty(searchKeyword) Then
            command.Parameters.AddWithValue("@searchKeyword", "%" & searchKeyword & "%")
        End If
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        dataGridView.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    Public Sub ImportBooks(isbn As String, author As String, title As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("INSERT INTO tblBooks (isbn, bookAuthor, bookTitle, availability, bookGenre) VALUES (@isbn, @bookAuthor, @bookTitle, @availability, @bookGenre)", connection)
        With command.Parameters
            .AddWithValue("@isbn", isbn)
            .AddWithValue("@bookAuthor", author)
            .AddWithValue("@bookTitle", title)
            .AddWithValue("@availability", 1)
        End With
        Select Case FrmAddBook.TxtGenre.Text
            Case "Computer Studies"
                command.Parameters.AddWithValue("@bookGenre", FrmAddBook.TxtGenre.Text)
            Case "Business Administration"
                command.Parameters.AddWithValue("@bookGenre", FrmAddBook.TxtGenre.Text)
            Case "Hospitality Management"
                command.Parameters.AddWithValue("@bookGenre", FrmAddBook.TxtGenre.Text)
            Case "Education"
                command.Parameters.AddWithValue("@bookGenre", FrmAddBook.TxtGenre.Text)
            Case "Others"
                command.Parameters.AddWithValue("@bookGenre", FrmAddBook.TxtGenre.Text)
        End Select
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Book has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FrmAddBook.Close()
    End Sub

    Public Sub DeleteBooks(ByVal isbn As Long)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim command As New SqlCommand("DELETE FROM tblBooks WHERE isbn = @isbn", connection)
            command.Parameters.AddWithValue("@isbn", isbn)
            command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BooksAvailability("tblBooks", FrmDashboard.AvailableBooks, 1)
        End If
    End Sub

#End Region



#Region "BORROWER SETUP FORM METHODS"

    Public Sub DisplayAvailableBooks(dataGridView As DataGridView)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT isbn, bookAuthor, bookTitle FROM tblBooks WHERE availability = 1", connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        dataGridView.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    'TAGA DISPLAY NG RECORD NG GIVEN STUDENT ID SA TEXTBOXES (FIRSTNAME, LASTNAME, COURSE)
    Public Sub DisplayAutomatically(studentID As Integer, txtFirstname As Control, txtLastname As Control, txtCourse As Control)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT FirstName, LastName, Course FROM tblBorrowers WHERE studentID = @StudentID", connection)
        command.Parameters.AddWithValue("@StudentID", studentID)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            txtFirstname.Text = reader("FirstName").ToString()
            txtLastname.Text = reader("LastName").ToString()
            txtCourse.Text = reader("Course").ToString()
        Else
            MessageBox.Show("Student ID do not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFirstname.Focus()
            FrmBorrowerSetup.TxtStudentID.Clear()
        End If
    End Sub

    Public Sub BookExistence(isbn As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT isbn, bookAuthor, bookTitle FROM tblBooks WHERE isbn = @isbn", connection)
        command.Parameters.AddWithValue("@isbn", isbn)
        If command.ExecuteScalar() Then
            BorrowConfirm()
            Exit Sub
        Else
            MessageBox.Show("Please choose an available book first below before you proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub

    Public Sub BorrowConfirm()
        Dim result As DialogResult = MessageBox.Show("Confirm borrow request", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        If result = DialogResult.Yes Then

            Dim borrowedBooksCommand As New SqlCommand("INSERT INTO tblBorrowedBooks (studentID, isbn, dateBorrowed, dueDate) VALUES (@StudentID, @isbn, GETDATE(), DATEADD(day, 7, GETDATE()))", connection)
            borrowedBooksCommand.Parameters.AddWithValue("@StudentID", FrmBorrowerSetup.TxtStudentID.Text)
            borrowedBooksCommand.Parameters.AddWithValue("@isbn", FrmBorrowerSetup.TxtISBN.Text)
            borrowedBooksCommand.ExecuteNonQuery()

            Dim updateBookCommand As New SqlCommand("UPDATE tblBooks SET availability = @availability WHERE isbn = @isbn", connection)
            updateBookCommand.Parameters.AddWithValue("@isbn", FrmBorrowerSetup.TxtISBN.Text)
            updateBookCommand.Parameters.AddWithValue("@availability", 0)
            updateBookCommand.ExecuteNonQuery()
            MessageBox.Show("Book has been borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim commandHistory As New SqlCommand("INSERT INTO tblBorrowHistory (studentID, isbn, dateBorrowed, dueDate) VALUES (@studentID, @isbn, GETDATE(), DATEADD(day, 7, GETDATE()))", connection)
            commandHistory.Parameters.AddWithValue("@studentID", FrmBorrowerSetup.TxtStudentID.Text)
            commandHistory.Parameters.AddWithValue("@isbn", FrmBorrowerSetup.TxtISBN.Text)
            commandHistory.ExecuteNonQuery()
            DisplayBorrowHistory(FrmHistory.DisplayDatagrid)

            With FrmBorrowerSetup
                .TxtStudentID.Text = ""
                .TxtFirstname.Text = ""
                .TxtLastname.Text = ""
                .TxtCourse.Text = ""
                .TxtISBN.Text = ""
                .TxtBookAuthor.Text = ""
                .TxtBookTitle.Text = ""
            End With
        End If
    End Sub
#End Region



#Region "RETURNED BOOKS FORM METHODS"
    Public Sub DisplayBorrowedBooks(datagrid As DataGridView)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim query As String = "SELECT b.isbn, b.bookTitle, b.bookAuthor, bo.studentID, bo.firstName, bo.lastName, bo.course, br.dateBorrowed, br.dueDate 
        FROM tblBorrowedBooks br
        JOIN tblBooks b ON br.isbn = b.isbn JOIN tblBorrowers bo ON br.studentID = bo.studentID"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        datagrid.DataSource = dataTable
    End Sub

    Public Sub ReturnBook()
        Dim result As DialogResult = MessageBox.Show("Confirm return book", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")

            Dim updateCommand As New SqlCommand("UPDATE tblBooks SET availability = @availability WHERE isbn = @isbn", connection)
            updateCommand.Parameters.AddWithValue("@isbn", FrmReturnedSetup.TxtISBN.Text)
            updateCommand.Parameters.AddWithValue("@availability", 1)
            updateCommand.ExecuteNonQuery()

            Dim deleteCommand As New SqlCommand("DELETE FROM tblBorrowedBooks WHERE studentID = @studentID AND isbn = @isbn", connection)
            With deleteCommand.Parameters
                .AddWithValue("@studentID", FrmReturnedSetup.TxtStudentID.Text)
                .AddWithValue("@isbn", FrmReturnedSetup.TxtISBN.Text)
            End With
            deleteCommand.ExecuteNonQuery()

            Dim insertCommand As New SqlCommand("INSERT INTO tblReturnHistory (studentID, isbn, dateReturned) VALUES (@id, @isbn, GETDATE())", connection)
            With insertCommand.Parameters
                .AddWithValue("@id", FrmReturnedSetup.TxtStudentID.Text)
                .AddWithValue("@isbn", FrmReturnedSetup.TxtISBN.Text)
            End With
            insertCommand.ExecuteNonQuery()

            MessageBox.Show("Book has been returned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            DisplayAvailableBooks(FrmBorrowerSetup.DisplayDataGrid)
            DisplayReturnHistory(FrmHistory.DisplayDatagrid)

            FrmReturnedSetup.TxtStudentID.Text = ""
            FrmReturnedSetup.TxtFirstname.Text = ""
            FrmReturnedSetup.TxtLastname.Text = ""
            FrmReturnedSetup.TxtCourse.Text = ""
            FrmReturnedSetup.TxtISBN.Text = ""
            FrmReturnedSetup.TxtBookAuthor.Text = ""
            FrmReturnedSetup.TxtBookTitle.Text = ""
        End If

    End Sub
#End Region


#Region "ACCOUNT SETTINGS FORM METHODS"
    Public Sub SavedChanges()
        Dim result As DialogResult = MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
            Dim commandAdmin As New SqlCommand("SELECT COUNT(*) FROM tblAdmin WHERE id = @id", connection)
            commandAdmin.Parameters.AddWithValue("@id", FrmAccountSettings.TxtID.Text)
            Dim commandLibrarians As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE id = @id", connection)
            commandLibrarians.Parameters.AddWithValue("id", FrmAccountSettings.TxtID.Text)

            If CInt(commandAdmin.ExecuteScalar()) > 0 Then
                Dim updateAdmins As New SqlCommand("UPDATE tblAdmin SET firstName = @firstname, lastName = @lastname, address = @address, password = @password, question = @question, answer = @answer WHERE id = @id", connection)
                updateAdmins.Parameters.AddWithValue("id", FrmAccountSettings.TxtID.Text)
                With updateAdmins.Parameters
                    .AddWithValue("@firstname", FrmAccountSettings.TxtFirstname.Text)
                    .AddWithValue("@lastname", FrmAccountSettings.TxtLastname.Text)
                    .AddWithValue("@address", FrmAccountSettings.TxtAddress.Text)
                    .AddWithValue("@password", FrmAccountSettings.TxtPassword.Text)
                    .AddWithValue("@question", FrmAccountSettings.TxtQuestion.Text)
                    .AddWithValue("@answer", FrmAccountSettings.TxtAnswer.Text)
                    .AddWithValue("@email", FrmAccountSettings.TxtEmail.Text)
                End With
                updateAdmins.ExecuteNonQuery()
                MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmAccountSettings.BtnSave.Enabled = False
            End If

            If CInt(commandLibrarians.ExecuteScalar()) > 0 Then
                Dim updateLibrarians As New SqlCommand("UPDATE tblLibrarians SET firstName = @firstname, lastName = @lastname, address = @address, password = @password, question = @question, answer = @answer WHERE id = @id", connection)
                updateLibrarians.Parameters.AddWithValue("@id", FrmAccountSettings.TxtID.Text)
                With updateLibrarians.Parameters
                    .AddWithValue("@firstname", FrmAccountSettings.TxtFirstname.Text)
                    .AddWithValue("@lastname", FrmAccountSettings.TxtLastname.Text)
                    .AddWithValue("@address", FrmAccountSettings.TxtAddress.Text)
                    .AddWithValue("@password", FrmAccountSettings.TxtPassword.Text)
                    .AddWithValue("@question", FrmAccountSettings.TxtQuestion.Text)
                    .AddWithValue("@answer", FrmAccountSettings.TxtAnswer.Text)
                    .AddWithValue("@email", FrmAccountSettings.TxtEmail.Text)
                End With
                updateLibrarians.ExecuteNonQuery()
                MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region



#Region "HISTORY FORM METHODS"
    Public Sub DisplayBorrowHistory(datagridview As DataGridView)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT b.isbn, b.bookTitle, b.bookAuthor, bo.studentID, bo.firstName, bo.lastName, bo.course, br.dateBorrowed, br.dueDate 
        FROM tblBorrowHistory br
        JOIN tblBooks b ON br.isbn = b.isbn JOIN tblBorrowers bo ON br.studentID = bo.studentID", connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        datagridview.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    Public Sub DisplayReturnHistory(datagridview As DataGridView)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT br.firstName, br.lastName, br.course, b.isbn, b.bookAuthor, b.bookTitle, rh.dateReturned
        FROM tblReturnHistory rh
        JOIN tblBooks b ON b.isbn = rh.isbn JOIN tblBorrowers br ON br.studentID = rh.studentID", connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        datagridview.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    Public Sub DisplayBorrowerCreation(datagridview As DataGridView)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT * FROM tblBorrowerHistory", connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        datagridview.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub
#End Region


#Region "FORGOT PASSWORD METHODS"

    Public Sub ForgotPassword(emailAddress As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim commandLibrarians As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE emailAddress = @emailAddress", connection)
        Dim commandAdmin As New SqlCommand("SELECT COUNT(*) FROM tblAdmin WHERE emailAddress = @emailAddress", connection)
        commandLibrarians.Parameters.AddWithValue("@emailAddress", emailAddress)
        commandAdmin.Parameters.AddWithValue("@emailAddress", emailAddress)

        If CInt(commandLibrarians.ExecuteScalar()) > 0 Then
            Dim commandOne As New SqlCommand("SELECT question FROM tblLibrarians WHERE emailAddress = @email", connection)
            commandOne.Parameters.AddWithValue("@email", FrmForgotPassword.TxtEmail.Text)
            Dim reader As SqlDataReader = commandOne.ExecuteReader()
            If reader.Read() Then
                FrmForgotPassword.TxtQuestion.Text = reader("question").ToString()
            End If

        ElseIf CInt(commandAdmin.ExecuteScalar()) > 0 Then
            Dim commandTwo As New SqlCommand("SELECT question FROM tblAdmin WHERE emailAddress = @email", connection)
            commandTwo.Parameters.AddWithValue("@email", FrmForgotPassword.TxtEmail.Text)
            Dim reader As SqlDataReader = commandTwo.ExecuteReader()
            If reader.Read() Then
                FrmForgotPassword.TxtQuestion.Text = reader("question").ToString()
            End If
        Else
            MessageBox.Show("Email not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub SaveNewPassword()
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim commandLibrarian As New SqlCommand("SELECT COUNT(*) FROM tblLibrarians WHERE emailAddress = @emailAddress AND question = @question AND answer = @answer", connection)
        Dim commandAdmin As New SqlCommand("SELECT COUNT(*) FROM tblAdmin WHERE emailAddress = @emailAddress AND question = @question AND answer = @answer", connection)
        commandLibrarian.Parameters.AddWithValue("@emailAddress", FrmForgotPassword.TxtEmail.Text)
        commandLibrarian.Parameters.AddWithValue("@question", FrmForgotPassword.TxtQuestion.Text)
        commandLibrarian.Parameters.AddWithValue("@answer", FrmForgotPassword.TxtAnswer.Text)

        commandAdmin.Parameters.AddWithValue("@emailAddress", FrmForgotPassword.TxtEmail.Text)
        commandAdmin.Parameters.AddWithValue("@question", FrmForgotPassword.TxtQuestion.Text)
        commandAdmin.Parameters.AddWithValue("@answer", FrmForgotPassword.TxtAnswer.Text)

        If CInt(commandLibrarian.ExecuteScalar()) > 0 Then
            FrmForgotPassword.Close()
            FrmMain.Show()

            Dim commandOne As New SqlCommand("SELECT * FROM tblLibrarians WHERE emailAddress = @emailAddress", connection)
            commandOne.Parameters.AddWithValue("@emailAddress", FrmForgotPassword.TxtEmail.Text)

            Dim adapter As New SqlDataAdapter(commandOne)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)

        ElseIf CInt(commandAdmin.ExecuteScalar()) > 0 Then
            FrmForgotPassword.Close()
            FrmMain.Show()
        Else
            MessageBox.Show("Wrong answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region



    Public Sub DisplayAllBorrowersAndLibrarins(dataGridView As DataGridView, tablename As String)
        Dim connection As SqlConnection = OpenConnectionString("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\UFLMS\dbUsers.mdf;Integrated Security=True")
        Dim command As New SqlCommand("SELECT * FROM " & tablename & "", connection)
        adapter = New SqlDataAdapter(command)
        dataset = New DataSet
        adapter.Fill(dataset)
        dataGridView.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub
End Module
