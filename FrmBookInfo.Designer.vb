<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBookInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBookInfo))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelClose = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtBookTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtBookAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtIsbn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Panel1.Size = New System.Drawing.Size(650, 8)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = " Book Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelClose
        '
        Me.LabelClose.ActiveLinkColor = System.Drawing.Color.Black
        Me.LabelClose.AutoSize = True
        Me.LabelClose.BackColor = System.Drawing.Color.Transparent
        Me.LabelClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.LinkColor = System.Drawing.Color.Black
        Me.LabelClose.Location = New System.Drawing.Point(598, 9)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(52, 18)
        Me.LabelClose.TabIndex = 25
        Me.LabelClose.TabStop = True
        Me.LabelClose.Text = "[close]"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 267)
        Me.Panel2.TabIndex = 33
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.White
        Me.Guna2Panel8.BackgroundImage = CType(resources.GetObject("Guna2Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel8.Location = New System.Drawing.Point(325, 48)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(325, 267)
        Me.Guna2Panel8.TabIndex = 34
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(313, 48)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(12, 267)
        Me.Panel5.TabIndex = 39
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(12, 237)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(301, 20)
        Me.Guna2Panel5.TabIndex = 62
        '
        'TxtBookTitle
        '
        Me.TxtBookTitle.BorderColor = System.Drawing.Color.Black
        Me.TxtBookTitle.BorderRadius = 5
        Me.TxtBookTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBookTitle.DefaultText = ""
        Me.TxtBookTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBookTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBookTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBookTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBookTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtBookTitle.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtBookTitle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBookTitle.ForeColor = System.Drawing.Color.Black
        Me.TxtBookTitle.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtBookTitle.Location = New System.Drawing.Point(12, 194)
        Me.TxtBookTitle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtBookTitle.Name = "TxtBookTitle"
        Me.TxtBookTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBookTitle.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtBookTitle.PlaceholderText = "Book Title"
        Me.TxtBookTitle.ReadOnly = True
        Me.TxtBookTitle.SelectedText = ""
        Me.TxtBookTitle.Size = New System.Drawing.Size(301, 43)
        Me.TxtBookTitle.TabIndex = 61
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(12, 174)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(301, 20)
        Me.Guna2Panel4.TabIndex = 60
        '
        'TxtBookAuthor
        '
        Me.TxtBookAuthor.BorderColor = System.Drawing.Color.Black
        Me.TxtBookAuthor.BorderRadius = 5
        Me.TxtBookAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBookAuthor.DefaultText = ""
        Me.TxtBookAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBookAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBookAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBookAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBookAuthor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtBookAuthor.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtBookAuthor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBookAuthor.ForeColor = System.Drawing.Color.Black
        Me.TxtBookAuthor.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtBookAuthor.Location = New System.Drawing.Point(12, 131)
        Me.TxtBookAuthor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtBookAuthor.Name = "TxtBookAuthor"
        Me.TxtBookAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBookAuthor.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtBookAuthor.PlaceholderText = "Book Author"
        Me.TxtBookAuthor.ReadOnly = True
        Me.TxtBookAuthor.SelectedText = ""
        Me.TxtBookAuthor.Size = New System.Drawing.Size(301, 43)
        Me.TxtBookAuthor.TabIndex = 59
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(12, 111)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(301, 20)
        Me.Guna2Panel3.TabIndex = 58
        '
        'TxtIsbn
        '
        Me.TxtIsbn.BorderColor = System.Drawing.Color.Black
        Me.TxtIsbn.BorderRadius = 5
        Me.TxtIsbn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIsbn.DefaultText = ""
        Me.TxtIsbn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtIsbn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtIsbn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIsbn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtIsbn.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtIsbn.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtIsbn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIsbn.ForeColor = System.Drawing.Color.Black
        Me.TxtIsbn.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtIsbn.Location = New System.Drawing.Point(12, 68)
        Me.TxtIsbn.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIsbn.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtIsbn.PlaceholderText = "ISBN"
        Me.TxtIsbn.ReadOnly = True
        Me.TxtIsbn.SelectedText = ""
        Me.TxtIsbn.Size = New System.Drawing.Size(301, 43)
        Me.TxtIsbn.TabIndex = 57
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel7.Location = New System.Drawing.Point(12, 48)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(301, 20)
        Me.Guna2Panel7.TabIndex = 56
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(12, 305)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(301, 10)
        Me.Panel4.TabIndex = 65
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
        Me.BtnDelete.Location = New System.Drawing.Point(12, 257)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(301, 48)
        Me.BtnDelete.TabIndex = 66
        Me.BtnDelete.Text = "DELETE"
        '
        'FrmBookInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 315)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.TxtBookTitle)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.TxtBookAuthor)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.TxtIsbn)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBookInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBookInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelClose As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtBookTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtBookAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtIsbn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
End Class
