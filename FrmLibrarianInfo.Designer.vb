<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLibrarianInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibrarianInfo))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelClose = New System.Windows.Forms.LinkLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
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
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = " Librarian Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 332)
        Me.Panel2.TabIndex = 21
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BtnDelete)
        Me.Guna2Panel1.Controls.Add(Me.Panel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel1.Controls.Add(Me.TxtEmail)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.TxtAddress)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.TxtLastname)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.TxtFirstname)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 48)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(342, 332)
        Me.Guna2Panel1.TabIndex = 22
        '
        'BtnDelete
        '
        Me.BtnDelete.BorderRadius = 5
        Me.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(0, 272)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(342, 50)
        Me.BtnDelete.TabIndex = 67
        Me.BtnDelete.Text = "DELETE"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 322)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(342, 10)
        Me.Panel4.TabIndex = 38
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 252)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(342, 20)
        Me.Guna2Panel6.TabIndex = 37
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
        Me.TxtEmail.Location = New System.Drawing.Point(0, 209)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtEmail.PlaceholderText = "Email Address"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(342, 43)
        Me.TxtEmail.TabIndex = 36
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 189)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(342, 20)
        Me.Guna2Panel5.TabIndex = 35
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
        Me.TxtAddress.Location = New System.Drawing.Point(0, 146)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddress.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtAddress.PlaceholderText = "Address"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.SelectedText = ""
        Me.TxtAddress.Size = New System.Drawing.Size(342, 43)
        Me.TxtAddress.TabIndex = 34
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 126)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(342, 20)
        Me.Guna2Panel4.TabIndex = 33
        '
        'TxtLastname
        '
        Me.TxtLastname.BorderColor = System.Drawing.Color.Black
        Me.TxtLastname.BorderRadius = 5
        Me.TxtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLastname.DefaultText = ""
        Me.TxtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtLastname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtLastname.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastname.ForeColor = System.Drawing.Color.Black
        Me.TxtLastname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtLastname.Location = New System.Drawing.Point(0, 83)
        Me.TxtLastname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLastname.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtLastname.PlaceholderText = "Lastname"
        Me.TxtLastname.ReadOnly = True
        Me.TxtLastname.SelectedText = ""
        Me.TxtLastname.Size = New System.Drawing.Size(342, 43)
        Me.TxtLastname.TabIndex = 32
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 63)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(342, 20)
        Me.Guna2Panel3.TabIndex = 31
        '
        'TxtFirstname
        '
        Me.TxtFirstname.BorderColor = System.Drawing.Color.Black
        Me.TxtFirstname.BorderRadius = 5
        Me.TxtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFirstname.DefaultText = ""
        Me.TxtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstname.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtFirstname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtFirstname.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstname.ForeColor = System.Drawing.Color.Black
        Me.TxtFirstname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtFirstname.Location = New System.Drawing.Point(0, 20)
        Me.TxtFirstname.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstname.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtFirstname.PlaceholderText = "Firstname"
        Me.TxtFirstname.ReadOnly = True
        Me.TxtFirstname.SelectedText = ""
        Me.TxtFirstname.Size = New System.Drawing.Size(342, 43)
        Me.TxtFirstname.TabIndex = 30
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(342, 20)
        Me.Guna2Panel2.TabIndex = 29
        '
        'LabelClose
        '
        Me.LabelClose.ActiveLinkColor = System.Drawing.Color.Black
        Me.LabelClose.AutoSize = True
        Me.LabelClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.LinkColor = System.Drawing.Color.Black
        Me.LabelClose.Location = New System.Drawing.Point(748, 8)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(52, 18)
        Me.LabelClose.TabIndex = 24
        Me.LabelClose.TabStop = True
        Me.LabelClose.Text = "[close]"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(354, 48)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 332)
        Me.Panel5.TabIndex = 25
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.White
        Me.Guna2Panel8.BackgroundImage = CType(resources.GetObject("Guna2Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel8.Controls.Add(Me.TxtID)
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel8.Location = New System.Drawing.Point(364, 48)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(436, 332)
        Me.Guna2Panel8.TabIndex = 35
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(21, -2)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 22)
        Me.TxtID.TabIndex = 0
        '
        'FrmLibrarianInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 380)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLibrarianInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLibrarianInfo"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelClose As LinkLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtID As TextBox
End Class
