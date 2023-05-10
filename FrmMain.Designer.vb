<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnAccountSettings = New System.Windows.Forms.Button()
        Me.BtnBorrowHistory = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBorrowedBooks = New System.Windows.Forms.Button()
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.BtnManageBooks = New System.Windows.Forms.Button()
        Me.BtnLibrarian = New System.Windows.Forms.Button()
        Me.BtnBorrower = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PanelDisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1942, 15)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.BtnAccountSettings)
        Me.Guna2Panel2.Controls.Add(Me.BtnBorrowHistory)
        Me.Guna2Panel2.Controls.Add(Me.Button1)
        Me.Guna2Panel2.Controls.Add(Me.btnBorrowedBooks)
        Me.Guna2Panel2.Controls.Add(Me.BtnSignOut)
        Me.Guna2Panel2.Controls.Add(Me.BtnManageBooks)
        Me.Guna2Panel2.Controls.Add(Me.BtnLibrarian)
        Me.Guna2Panel2.Controls.Add(Me.BtnBorrower)
        Me.Guna2Panel2.Controls.Add(Me.BtnDashboard)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 15)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(299, 999)
        Me.Guna2Panel2.TabIndex = 13
        '
        'BtnAccountSettings
        '
        Me.BtnAccountSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAccountSettings.FlatAppearance.BorderSize = 0
        Me.BtnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccountSettings.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccountSettings.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAccountSettings.Image = CType(resources.GetObject("BtnAccountSettings.Image"), System.Drawing.Image)
        Me.BtnAccountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAccountSettings.Location = New System.Drawing.Point(0, 561)
        Me.BtnAccountSettings.Name = "BtnAccountSettings"
        Me.BtnAccountSettings.Size = New System.Drawing.Size(299, 50)
        Me.BtnAccountSettings.TabIndex = 14
        Me.BtnAccountSettings.Text = "  ACCOUNT SETTINGS"
        Me.BtnAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAccountSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAccountSettings.UseVisualStyleBackColor = True
        '
        'BtnBorrowHistory
        '
        Me.BtnBorrowHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBorrowHistory.FlatAppearance.BorderSize = 0
        Me.BtnBorrowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrowHistory.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrowHistory.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBorrowHistory.Image = CType(resources.GetObject("BtnBorrowHistory.Image"), System.Drawing.Image)
        Me.BtnBorrowHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrowHistory.Location = New System.Drawing.Point(0, 511)
        Me.BtnBorrowHistory.Name = "BtnBorrowHistory"
        Me.BtnBorrowHistory.Size = New System.Drawing.Size(299, 50)
        Me.BtnBorrowHistory.TabIndex = 13
        Me.BtnBorrowHistory.Text = "  HISTORY"
        Me.BtnBorrowHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrowHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBorrowHistory.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(299, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "  RETURNED SETUP"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBorrowedBooks
        '
        Me.btnBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBorrowedBooks.FlatAppearance.BorderSize = 0
        Me.btnBorrowedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowedBooks.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowedBooks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBorrowedBooks.Image = CType(resources.GetObject("btnBorrowedBooks.Image"), System.Drawing.Image)
        Me.btnBorrowedBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowedBooks.Location = New System.Drawing.Point(0, 411)
        Me.btnBorrowedBooks.Name = "btnBorrowedBooks"
        Me.btnBorrowedBooks.Size = New System.Drawing.Size(299, 50)
        Me.btnBorrowedBooks.TabIndex = 9
        Me.btnBorrowedBooks.Text = "  BORROWER SETUP"
        Me.btnBorrowedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowedBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrowedBooks.UseVisualStyleBackColor = True
        '
        'BtnSignOut
        '
        Me.BtnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSignOut.FlatAppearance.BorderSize = 0
        Me.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignOut.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignOut.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSignOut.Image = CType(resources.GetObject("BtnSignOut.Image"), System.Drawing.Image)
        Me.BtnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSignOut.Location = New System.Drawing.Point(0, 949)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(299, 50)
        Me.BtnSignOut.TabIndex = 7
        Me.BtnSignOut.Text = "  SIGN OUT"
        Me.BtnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSignOut.UseVisualStyleBackColor = True
        '
        'BtnManageBooks
        '
        Me.BtnManageBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnManageBooks.FlatAppearance.BorderSize = 0
        Me.BtnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManageBooks.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageBooks.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnManageBooks.Image = CType(resources.GetObject("BtnManageBooks.Image"), System.Drawing.Image)
        Me.BtnManageBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageBooks.Location = New System.Drawing.Point(0, 361)
        Me.BtnManageBooks.Name = "BtnManageBooks"
        Me.BtnManageBooks.Size = New System.Drawing.Size(299, 50)
        Me.BtnManageBooks.TabIndex = 5
        Me.BtnManageBooks.Text = "  MANAGE BOOKS"
        Me.BtnManageBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnManageBooks.UseVisualStyleBackColor = True
        '
        'BtnLibrarian
        '
        Me.BtnLibrarian.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLibrarian.FlatAppearance.BorderSize = 0
        Me.BtnLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLibrarian.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLibrarian.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLibrarian.Image = CType(resources.GetObject("BtnLibrarian.Image"), System.Drawing.Image)
        Me.BtnLibrarian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLibrarian.Location = New System.Drawing.Point(0, 311)
        Me.BtnLibrarian.Name = "BtnLibrarian"
        Me.BtnLibrarian.Size = New System.Drawing.Size(299, 50)
        Me.BtnLibrarian.TabIndex = 4
        Me.BtnLibrarian.Text = "  LIBRARIAN"
        Me.BtnLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLibrarian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLibrarian.UseVisualStyleBackColor = True
        '
        'BtnBorrower
        '
        Me.BtnBorrower.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBorrower.FlatAppearance.BorderSize = 0
        Me.BtnBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrower.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrower.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBorrower.Image = CType(resources.GetObject("BtnBorrower.Image"), System.Drawing.Image)
        Me.BtnBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrower.Location = New System.Drawing.Point(0, 261)
        Me.BtnBorrower.Name = "BtnBorrower"
        Me.BtnBorrower.Size = New System.Drawing.Size(299, 50)
        Me.BtnBorrower.TabIndex = 3
        Me.BtnBorrower.Text = "  BORROWER"
        Me.BtnBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBorrower.UseVisualStyleBackColor = True
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 211)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(299, 50)
        Me.BtnDashboard.TabIndex = 2
        Me.BtnDashboard.Text = "  DASHBOARD"
        Me.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDashboard.UseVisualStyleBackColor = True
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 178)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(299, 33)
        Me.Guna2Panel4.TabIndex = 1
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackgroundImage = CType(resources.GetObject("Guna2Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(299, 178)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.PanelDisplay)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel8)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel5.Location = New System.Drawing.Point(299, 15)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1643, 999)
        Me.Guna2Panel5.TabIndex = 14
        '
        'PanelDisplay
        '
        Me.PanelDisplay.BackColor = System.Drawing.Color.White
        Me.PanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDisplay.Location = New System.Drawing.Point(10, 0)
        Me.PanelDisplay.Name = "PanelDisplay"
        Me.PanelDisplay.Size = New System.Drawing.Size(1623, 991)
        Me.PanelDisplay.TabIndex = 4
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.White
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel8.Location = New System.Drawing.Point(10, 991)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(1623, 8)
        Me.Guna2Panel8.TabIndex = 2
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.White
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel7.Location = New System.Drawing.Point(1633, 0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(10, 999)
        Me.Guna2Panel7.TabIndex = 1
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.White
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(10, 999)
        Me.Guna2Panel6.TabIndex = 0
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 50
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1942, 1014)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmin"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents BtnManageBooks As Button
    Friend WithEvents BtnLibrarian As Button
    Friend WithEvents BtnBorrower As Button
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelDisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnBorrowedBooks As Button
    Friend WithEvents BtnAccountSettings As Button
    Friend WithEvents BtnBorrowHistory As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
