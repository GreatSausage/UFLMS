<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddBook))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelClose = New System.Windows.Forms.LinkLabel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtIsbn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " Import Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 8)
        Me.Panel1.TabIndex = 5
        '
        'LabelClose
        '
        Me.LabelClose.ActiveLinkColor = System.Drawing.Color.Black
        Me.LabelClose.AutoSize = True
        Me.LabelClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.LinkColor = System.Drawing.Color.Black
        Me.LabelClose.Location = New System.Drawing.Point(745, 9)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(52, 18)
        Me.LabelClose.TabIndex = 8
        Me.LabelClose.TabStop = True
        Me.LabelClose.Text = "[close]"
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackgroundImage = CType(resources.GetObject("Guna2Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel8.Location = New System.Drawing.Point(415, 48)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(385, 302)
        Me.Guna2Panel8.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 302)
        Me.Panel2.TabIndex = 16
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderColor = System.Drawing.Color.Black
        Me.TxtTitle.BorderRadius = 5
        Me.TxtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTitle.DefaultText = ""
        Me.TxtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtTitle.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtTitle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.ForeColor = System.Drawing.Color.Black
        Me.TxtTitle.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtTitle.Location = New System.Drawing.Point(12, 194)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTitle.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtTitle.PlaceholderText = "Book Title"
        Me.TxtTitle.SelectedText = ""
        Me.TxtTitle.Size = New System.Drawing.Size(403, 43)
        Me.TxtTitle.TabIndex = 52
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(403, 20)
        Me.Guna2Panel1.TabIndex = 51
        '
        'TxtAuthor
        '
        Me.TxtAuthor.BorderColor = System.Drawing.Color.Black
        Me.TxtAuthor.BorderRadius = 5
        Me.TxtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAuthor.DefaultText = ""
        Me.TxtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAuthor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtAuthor.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtAuthor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAuthor.ForeColor = System.Drawing.Color.Black
        Me.TxtAuthor.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtAuthor.Location = New System.Drawing.Point(12, 131)
        Me.TxtAuthor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAuthor.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtAuthor.PlaceholderText = "Book Author"
        Me.TxtAuthor.SelectedText = ""
        Me.TxtAuthor.Size = New System.Drawing.Size(403, 43)
        Me.TxtAuthor.TabIndex = 50
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(12, 111)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(403, 20)
        Me.Guna2Panel5.TabIndex = 49
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
        Me.TxtIsbn.SelectedText = ""
        Me.TxtIsbn.Size = New System.Drawing.Size(403, 43)
        Me.TxtIsbn.TabIndex = 48
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel6.Location = New System.Drawing.Point(12, 48)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(403, 20)
        Me.Guna2Panel6.TabIndex = 47
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(12, 340)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 10)
        Me.Panel3.TabIndex = 53
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
        Me.BtnCreate.Location = New System.Drawing.Point(12, 296)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(403, 44)
        Me.BtnCreate.TabIndex = 54
        Me.BtnCreate.Text = "IMPORT"
        '
        'FrmAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.TxtIsbn)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAddBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelClose As LinkLabel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtIsbn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCreate As Guna.UI2.WinForms.Guna2Button
End Class
