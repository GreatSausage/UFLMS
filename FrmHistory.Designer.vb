<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDisplay = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnDeleteAll = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DisplayDatagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        CType(Me.DisplayDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.TxtDisplay)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1302, 91)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1002, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Display:"
        '
        'TxtDisplay
        '
        Me.TxtDisplay.BackColor = System.Drawing.Color.Transparent
        Me.TxtDisplay.BorderColor = System.Drawing.Color.Black
        Me.TxtDisplay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TxtDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtDisplay.FocusedColor = System.Drawing.Color.Black
        Me.TxtDisplay.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.TxtDisplay.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtDisplay.ForeColor = System.Drawing.Color.Black
        Me.TxtDisplay.ItemHeight = 30
        Me.TxtDisplay.Items.AddRange(New Object() {"Borrow History", "Return History", "Borrower Created", "Deleted Borrower", "Librarian Created", "Deleted Librarian", "Book Imports", "Book Deleted"})
        Me.TxtDisplay.Location = New System.Drawing.Point(1100, 54)
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.Size = New System.Drawing.Size(187, 36)
        Me.TxtDisplay.TabIndex = 3
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
        Me.Label1.Text = "History"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.Location = New System.Drawing.Point(10, 872)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1282, 10)
        Me.Guna2Panel5.TabIndex = 9
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 91)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(10, 791)
        Me.Guna2Panel4.TabIndex = 8
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(1292, 91)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(10, 791)
        Me.Guna2Panel3.TabIndex = 7
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Controls.Add(Me.BtnDeleteAll)
        Me.Guna2Panel9.Controls.Add(Me.Guna2Panel10)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel9.Location = New System.Drawing.Point(10, 801)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(1282, 71)
        Me.Guna2Panel9.TabIndex = 10
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.BorderRadius = 5
        Me.BtnDeleteAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeleteAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDeleteAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDeleteAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnDeleteAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BtnDeleteAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDeleteAll.ForeColor = System.Drawing.Color.White
        Me.BtnDeleteAll.Location = New System.Drawing.Point(1095, 10)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(187, 61)
        Me.BtnDeleteAll.TabIndex = 8
        Me.BtnDeleteAll.Text = "DELETE ALL"
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.Size = New System.Drawing.Size(1282, 10)
        Me.Guna2Panel10.TabIndex = 0
        '
        'DisplayDatagrid
        '
        Me.DisplayDatagrid.AllowUserToAddRows = False
        Me.DisplayDatagrid.AllowUserToDeleteRows = False
        Me.DisplayDatagrid.AllowUserToResizeColumns = False
        Me.DisplayDatagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DisplayDatagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DisplayDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DisplayDatagrid.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DisplayDatagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.DisplayDatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayDatagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayDatagrid.Location = New System.Drawing.Point(10, 106)
        Me.DisplayDatagrid.MultiSelect = False
        Me.DisplayDatagrid.Name = "DisplayDatagrid"
        Me.DisplayDatagrid.ReadOnly = True
        Me.DisplayDatagrid.RowHeadersVisible = False
        Me.DisplayDatagrid.RowHeadersWidth = 51
        Me.DisplayDatagrid.RowTemplate.Height = 30
        Me.DisplayDatagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DisplayDatagrid.Size = New System.Drawing.Size(1282, 695)
        Me.DisplayDatagrid.TabIndex = 13
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
        'Guna2Panel8
        '
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel8.Location = New System.Drawing.Point(10, 91)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(1282, 15)
        Me.Guna2Panel8.TabIndex = 12
        '
        'FrmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1302, 882)
        Me.ControlBox = False
        Me.Controls.Add(Me.DisplayDatagrid)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel9)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmHistory"
        Me.Text = "FrmBorrowHistory"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel9.ResumeLayout(False)
        CType(Me.DisplayDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnDeleteAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DisplayDatagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDisplay As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
End Class
