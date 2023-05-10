<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManageBooks
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnAddBorrower = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DisplayDatagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtGenre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIsAvailable = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel9.SuspendLayout()
        CType(Me.DisplayDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Controls.Add(Me.BtnAddBorrower)
        Me.Guna2Panel9.Controls.Add(Me.Guna2Panel10)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 741)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(1292, 71)
        Me.Guna2Panel9.TabIndex = 14
        '
        'BtnAddBorrower
        '
        Me.BtnAddBorrower.BorderRadius = 5
        Me.BtnAddBorrower.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddBorrower.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddBorrower.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddBorrower.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddBorrower.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAddBorrower.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BtnAddBorrower.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddBorrower.ForeColor = System.Drawing.Color.White
        Me.BtnAddBorrower.Location = New System.Drawing.Point(1105, 10)
        Me.BtnAddBorrower.Name = "BtnAddBorrower"
        Me.BtnAddBorrower.Size = New System.Drawing.Size(187, 61)
        Me.BtnAddBorrower.TabIndex = 8
        Me.BtnAddBorrower.Text = "IMPORT BOOK"
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.Size = New System.Drawing.Size(1292, 10)
        Me.Guna2Panel10.TabIndex = 0
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 812)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1292, 10)
        Me.Guna2Panel5.TabIndex = 11
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(1292, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(10, 822)
        Me.Guna2Panel3.TabIndex = 9
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel8.Location = New System.Drawing.Point(0, 91)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(1292, 30)
        Me.Guna2Panel8.TabIndex = 15
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 121)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(10, 620)
        Me.Guna2Panel4.TabIndex = 16
        '
        'DisplayDatagrid
        '
        Me.DisplayDatagrid.AllowUserToAddRows = False
        Me.DisplayDatagrid.AllowUserToDeleteRows = False
        Me.DisplayDatagrid.AllowUserToResizeColumns = False
        Me.DisplayDatagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        Me.DisplayDatagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DisplayDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DisplayDatagrid.ColumnHeadersHeight = 25
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DisplayDatagrid.DefaultCellStyle = DataGridViewCellStyle21
        Me.DisplayDatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayDatagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayDatagrid.Location = New System.Drawing.Point(10, 121)
        Me.DisplayDatagrid.MultiSelect = False
        Me.DisplayDatagrid.Name = "DisplayDatagrid"
        Me.DisplayDatagrid.ReadOnly = True
        Me.DisplayDatagrid.RowHeadersVisible = False
        Me.DisplayDatagrid.RowHeadersWidth = 51
        Me.DisplayDatagrid.RowTemplate.Height = 30
        Me.DisplayDatagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DisplayDatagrid.Size = New System.Drawing.Size(1282, 620)
        Me.DisplayDatagrid.TabIndex = 17
        Me.DisplayDatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DisplayDatagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DisplayDatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DisplayDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DisplayDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DisplayDatagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DisplayDatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayDatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayDatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DisplayDatagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayDatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DisplayDatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DisplayDatagrid.ThemeStyle.HeaderStyle.Height = 25
        Me.DisplayDatagrid.ThemeStyle.ReadOnly = True
        Me.DisplayDatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DisplayDatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DisplayDatagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayDatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DisplayDatagrid.ThemeStyle.RowsStyle.Height = 30
        Me.DisplayDatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayDatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(14, 91)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 91)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TxtGenre
        '
        Me.TxtGenre.BackColor = System.Drawing.Color.Transparent
        Me.TxtGenre.BorderColor = System.Drawing.Color.Black
        Me.TxtGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TxtGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtGenre.FocusedColor = System.Drawing.Color.Black
        Me.TxtGenre.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtGenre.ForeColor = System.Drawing.Color.Black
        Me.TxtGenre.ItemHeight = 30
        Me.TxtGenre.Items.AddRange(New Object() {"All", "Computer Studies", "Business Administration", "Education", "Hospitality Management", "Others"})
        Me.TxtGenre.Location = New System.Drawing.Point(457, 55)
        Me.TxtGenre.Name = "TxtGenre"
        Me.TxtGenre.Size = New System.Drawing.Size(223, 36)
        Me.TxtGenre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Genre:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.TxtIsAvailable)
        Me.Guna2Panel1.Controls.Add(Me.TxtSearch)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.TxtGenre)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1292, 91)
        Me.Guna2Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(686, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "  Availability:"
        '
        'TxtIsAvailable
        '
        Me.TxtIsAvailable.BackColor = System.Drawing.Color.Transparent
        Me.TxtIsAvailable.BorderColor = System.Drawing.Color.Black
        Me.TxtIsAvailable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TxtIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtIsAvailable.FocusedColor = System.Drawing.Color.Black
        Me.TxtIsAvailable.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtIsAvailable.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIsAvailable.ForeColor = System.Drawing.Color.Black
        Me.TxtIsAvailable.ItemHeight = 30
        Me.TxtIsAvailable.Items.AddRange(New Object() {"ALL", "AVAILABLE", "UNAVAILABLE"})
        Me.TxtIsAvailable.Location = New System.Drawing.Point(813, 55)
        Me.TxtIsAvailable.Name = "TxtIsAvailable"
        Me.TxtIsAvailable.Size = New System.Drawing.Size(187, 36)
        Me.TxtIsAvailable.TabIndex = 6
        '
        'TxtSearch
        '
        Me.TxtSearch.BorderColor = System.Drawing.Color.Black
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearch.DefaultText = ""
        Me.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.ForeColor = System.Drawing.Color.Black
        Me.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSearch.Location = New System.Drawing.Point(1006, 55)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TxtSearch.PlaceholderText = "Search Book"
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.Size = New System.Drawing.Size(274, 36)
        Me.TxtSearch.TabIndex = 5
        '
        'FrmManageBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1302, 822)
        Me.ControlBox = False
        Me.Controls.Add(Me.DisplayDatagrid)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel9)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmManageBooks"
        Me.Text = "FrmManageBooks"
        Me.Guna2Panel9.ResumeLayout(False)
        CType(Me.DisplayDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnAddBorrower As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DisplayDatagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtGenre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIsAvailable As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
