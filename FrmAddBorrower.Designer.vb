<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddBorrower
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddBorrower))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BtnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelClose = New System.Windows.Forms.LinkLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 100
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 8)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(790, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 492)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 490)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(790, 10)
        Me.Panel4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(790, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " Student Registration"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TxtEmail)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel1.Controls.Add(Me.TxtAddress)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel1.Controls.Add(Me.TxtCourse)
        Me.Guna2Panel1.Controls.Add(Me.BtnCreate)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.TxtLastName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.TxtFirstName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.TxtStudentID)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(342, 442)
        Me.Guna2Panel1.TabIndex = 5
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderColor = System.Drawing.Color.Black
        Me.TxtEmail.BorderRadius = 5
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.DefaultText = ""
        Me.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Black
        Me.TxtEmail.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtEmail.Location = New System.Drawing.Point(12, 328)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtEmail.PlaceholderText = "Email Address"
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(330, 43)
        Me.TxtEmail.TabIndex = 50
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel7.Location = New System.Drawing.Point(12, 308)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(330, 20)
        Me.Guna2Panel7.TabIndex = 49
        '
        'TxtAddress
        '
        Me.TxtAddress.BorderColor = System.Drawing.Color.Black
        Me.TxtAddress.BorderRadius = 5
        Me.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddress.DefaultText = ""
        Me.TxtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddress.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtAddress.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtAddress.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.ForeColor = System.Drawing.Color.Black
        Me.TxtAddress.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtAddress.Location = New System.Drawing.Point(12, 265)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddress.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtAddress.PlaceholderText = "Address"
        Me.TxtAddress.SelectedText = ""
        Me.TxtAddress.Size = New System.Drawing.Size(330, 43)
        Me.TxtAddress.TabIndex = 48
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel6.Location = New System.Drawing.Point(12, 245)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(330, 20)
        Me.Guna2Panel6.TabIndex = 47
        '
        'TxtCourse
        '
        Me.TxtCourse.BackColor = System.Drawing.Color.Transparent
        Me.TxtCourse.BorderColor = System.Drawing.Color.Black
        Me.TxtCourse.BorderRadius = 5
        Me.TxtCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TxtCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtCourse.FocusedColor = System.Drawing.Color.Black
        Me.TxtCourse.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCourse.ForeColor = System.Drawing.Color.Black
        Me.TxtCourse.ItemHeight = 30
        Me.TxtCourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSBA", "BSA", "BSE", "BEED", "BSHRM"})
        Me.TxtCourse.Location = New System.Drawing.Point(12, 209)
        Me.TxtCourse.Name = "TxtCourse"
        Me.TxtCourse.Size = New System.Drawing.Size(330, 36)
        Me.TxtCourse.TabIndex = 42
        '
        'BtnCreate
        '
        Me.BtnCreate.BorderRadius = 5
        Me.BtnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCreate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCreate.ForeColor = System.Drawing.Color.White
        Me.BtnCreate.Location = New System.Drawing.Point(12, 398)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(330, 44)
        Me.BtnCreate.TabIndex = 41
        Me.BtnCreate.Text = "Create"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(12, 189)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(330, 20)
        Me.Guna2Panel5.TabIndex = 35
        '
        'TxtLastName
        '
        Me.TxtLastName.BorderColor = System.Drawing.Color.Black
        Me.TxtLastName.BorderRadius = 5
        Me.TxtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLastName.DefaultText = ""
        Me.TxtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtLastName.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtLastName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastName.ForeColor = System.Drawing.Color.Black
        Me.TxtLastName.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtLastName.Location = New System.Drawing.Point(12, 146)
        Me.TxtLastName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLastName.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtLastName.PlaceholderText = "Lastname"
        Me.TxtLastName.SelectedText = ""
        Me.TxtLastName.Size = New System.Drawing.Size(330, 43)
        Me.TxtLastName.TabIndex = 34
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(12, 126)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(330, 20)
        Me.Guna2Panel4.TabIndex = 33
        '
        'TxtFirstName
        '
        Me.TxtFirstName.BorderColor = System.Drawing.Color.Black
        Me.TxtFirstName.BorderRadius = 5
        Me.TxtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFirstName.DefaultText = ""
        Me.TxtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtFirstName.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstName.ForeColor = System.Drawing.Color.Black
        Me.TxtFirstName.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtFirstName.Location = New System.Drawing.Point(12, 83)
        Me.TxtFirstName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstName.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtFirstName.PlaceholderText = "Firstname"
        Me.TxtFirstName.SelectedText = ""
        Me.TxtFirstName.Size = New System.Drawing.Size(330, 43)
        Me.TxtFirstName.TabIndex = 32
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(12, 63)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(330, 20)
        Me.Guna2Panel3.TabIndex = 31
        '
        'TxtStudentID
        '
        Me.TxtStudentID.BorderColor = System.Drawing.Color.Black
        Me.TxtStudentID.BorderRadius = 5
        Me.TxtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtStudentID.DefaultText = ""
        Me.TxtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtStudentID.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtStudentID.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtStudentID.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStudentID.ForeColor = System.Drawing.Color.Black
        Me.TxtStudentID.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtStudentID.Location = New System.Drawing.Point(12, 20)
        Me.TxtStudentID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtStudentID.Name = "TxtStudentID"
        Me.TxtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtStudentID.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtStudentID.PlaceholderText = "Student ID"
        Me.TxtStudentID.SelectedText = ""
        Me.TxtStudentID.Size = New System.Drawing.Size(330, 43)
        Me.TxtStudentID.TabIndex = 30
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(330, 20)
        Me.Guna2Panel2.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 442)
        Me.Panel2.TabIndex = 15
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackgroundImage = CType(resources.GetObject("Guna2Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel8.Location = New System.Drawing.Point(342, 48)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(448, 442)
        Me.Guna2Panel8.TabIndex = 6
        '
        'LabelClose
        '
        Me.LabelClose.ActiveLinkColor = System.Drawing.Color.Black
        Me.LabelClose.AutoSize = True
        Me.LabelClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.LinkColor = System.Drawing.Color.Black
        Me.LabelClose.Location = New System.Drawing.Point(738, 7)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(52, 18)
        Me.LabelClose.TabIndex = 7
        Me.LabelClose.TabStop = True
        Me.LabelClose.Text = "[close]"
        '
        'FrmAddBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LabelClose As LinkLabel
    Friend WithEvents TxtCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
End Class
