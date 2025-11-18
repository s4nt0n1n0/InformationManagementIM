<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItems
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuItems))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridMenu = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddMenuItemsbtn = New InformationManagement.RoundedButton()
        Me.Image = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridMenu
        '
        Me.DataGridMenu.AllowUserToAddRows = False
        Me.DataGridMenu.AllowUserToDeleteRows = False
        Me.DataGridMenu.AllowUserToResizeColumns = False
        Me.DataGridMenu.AllowUserToResizeRows = False
        Me.DataGridMenu.BackgroundColor = System.Drawing.Color.White
        Me.DataGridMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridMenu.ColumnHeadersHeight = 40
        Me.DataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Image, Me.Name, Me.Description, Me.Price, Me.Category, Me.Status, Me.colEdit, Me.colDelete})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridMenu.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridMenu.EnableHeadersVisualStyles = False
        Me.DataGridMenu.Location = New System.Drawing.Point(30, 98)
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridMenu.RowHeadersVisible = False
        Me.DataGridMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridMenu.RowTemplate.Height = 50
        Me.DataGridMenu.RowTemplate.ReadOnly = True
        Me.DataGridMenu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMenu.Size = New System.Drawing.Size(1046, 237)
        Me.DataGridMenu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Items"
        '
        'AddMenuItemsbtn
        '
        Me.AddMenuItemsbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddMenuItemsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMenuItemsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.AddMenuItemsbtn.ForeColor = System.Drawing.Color.White
        Me.AddMenuItemsbtn.Image = CType(resources.GetObject("AddMenuItemsbtn.Image"), System.Drawing.Image)
        Me.AddMenuItemsbtn.Location = New System.Drawing.Point(888, 16)
        Me.AddMenuItemsbtn.Name = "AddMenuItemsbtn"
        Me.AddMenuItemsbtn.Size = New System.Drawing.Size(188, 39)
        Me.AddMenuItemsbtn.TabIndex = 4
        Me.AddMenuItemsbtn.Text = "   Add Menu Items"
        Me.AddMenuItemsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddMenuItemsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddMenuItemsbtn.UseVisualStyleBackColor = False
        '
        'Image
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Image.DefaultCellStyle = DataGridViewCellStyle2
        Me.Image.HeaderText = "Image"
        Me.Image.Name = "Image"
        Me.Image.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Name
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        Me.Name.Width = 250
        '
        'Description
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Description.DefaultCellStyle = DataGridViewCellStyle4
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 200
        '
        'Price
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle5
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.Width = 150
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.Width = 120
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 120
        '
        'colEdit
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.colEdit.DefaultCellStyle = DataGridViewCellStyle6
        Me.colEdit.HeaderText = "Action"
        Me.colEdit.Name = "colEdit"
        Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEdit.Text = "Edit"
        Me.colEdit.UseColumnTextForButtonValue = True
        Me.colEdit.Width = 50
        '
        'colDelete
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDelete.Text = "Delete"
        Me.colDelete.UseColumnTextForButtonValue = True
        Me.colDelete.Width = 50
        '
        'MenuItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1123, 749)
        Me.Controls.Add(Me.DataGridMenu)
        Me.Controls.Add(Me.AddMenuItemsbtn)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Text = "MenuItems"
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddMenuItemsbtn As RoundedButton
    Friend WithEvents DataGridMenu As DataGridView
    Friend WithEvents Image As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
End Class
