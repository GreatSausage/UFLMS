<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSignInScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSignInScreen))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel13 = New Guna.UI2.WinForms.Guna2Panel()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel14 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel11 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel13.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 100
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(450, 500)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(450, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(450, 500)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.txtEmail)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel12)
        Me.Guna2Panel5.Controls.Add(Me.Label1)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 125)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(450, 125)
        Me.Guna2Panel5.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.BorderRadius = 10
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(50, 55)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(350, 41)
        Me.txtEmail.TabIndex = 0
        '
        'Guna2Panel12
        '
        Me.Guna2Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel12.Location = New System.Drawing.Point(50, 96)
        Me.Guna2Panel12.Name = "Guna2Panel12"
        Me.Guna2Panel12.Size = New System.Drawing.Size(350, 29)
        Me.Guna2Panel12.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "EMAIL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(50, 125)
        Me.Guna2Panel9.TabIndex = 6
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel7.Location = New System.Drawing.Point(400, 0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(50, 125)
        Me.Guna2Panel7.TabIndex = 5
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.txtPassword)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel13)
        Me.Guna2Panel4.Controls.Add(Me.Label2)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel10)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 250)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(450, 125)
        Me.Guna2Panel4.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(50, 55)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(350, 41)
        Me.txtPassword.TabIndex = 1
        '
        'Guna2Panel13
        '
        Me.Guna2Panel13.Controls.Add(Me.showPassword)
        Me.Guna2Panel13.Controls.Add(Me.LinkLabel1)
        Me.Guna2Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel13.Location = New System.Drawing.Point(50, 96)
        Me.Guna2Panel13.Name = "Guna2Panel13"
        Me.Guna2Panel13.Size = New System.Drawing.Size(350, 29)
        Me.Guna2Panel13.TabIndex = 11
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.showPassword.Location = New System.Drawing.Point(192, 10)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(151, 27)
        Me.showPassword.TabIndex = 3
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(-4, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(146, 23)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password?"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 55)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PASSWORD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.Size = New System.Drawing.Size(50, 125)
        Me.Guna2Panel10.TabIndex = 7
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel6.Location = New System.Drawing.Point(400, 0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(50, 125)
        Me.Guna2Panel6.TabIndex = 6
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(407, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(43, 34)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "X"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.btnSignIn)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel14)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel11)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel8)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 375)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(450, 125)
        Me.Guna2Panel3.TabIndex = 1
        '
        'btnSignIn
        '
        Me.btnSignIn.BorderRadius = 10
        Me.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignIn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.Black
        Me.btnSignIn.Location = New System.Drawing.Point(50, 52)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(350, 41)
        Me.btnSignIn.TabIndex = 9
        Me.btnSignIn.Text = "SIGN IN"
        '
        'Guna2Panel14
        '
        Me.Guna2Panel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel14.Location = New System.Drawing.Point(50, 93)
        Me.Guna2Panel14.Name = "Guna2Panel14"
        Me.Guna2Panel14.Size = New System.Drawing.Size(350, 32)
        Me.Guna2Panel14.TabIndex = 8
        '
        'Guna2Panel11
        '
        Me.Guna2Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel11.Name = "Guna2Panel11"
        Me.Guna2Panel11.Size = New System.Drawing.Size(50, 125)
        Me.Guna2Panel11.TabIndex = 7
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel8.Location = New System.Drawing.Point(400, 0)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(50, 125)
        Me.Guna2Panel8.TabIndex = 6
        '
        'FrmSignInScreen
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSignInScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSignInScreen"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel13.ResumeLayout(False)
        Me.Guna2Panel13.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel11 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel13 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents showPassword As CheckBox
    Friend WithEvents btnSignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel14 As Guna.UI2.WinForms.Guna2Panel
End Class
