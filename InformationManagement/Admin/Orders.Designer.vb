<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AddOrdersBtn = New InformationManagement.RoundedButton()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Products = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantities = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Orders"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CustomerName, Me.OrderType, Me.Products, Me.Quantities, Me.UnitPrices, Me.TotalPrice, Me.Status, Me.Edit, Me.Delete})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(34, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(1283, 196)
        Me.DataGridView1.TabIndex = 5
        '
        'AddOrdersBtn
        '
        Me.AddOrdersBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddOrdersBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.AddOrdersBtn.ForeColor = System.Drawing.Color.White
        Me.AddOrdersBtn.Image = CType(resources.GetObject("AddOrdersBtn.Image"), System.Drawing.Image)
        Me.AddOrdersBtn.Location = New System.Drawing.Point(926, 14)
        Me.AddOrdersBtn.Name = "AddOrdersBtn"
        Me.AddOrdersBtn.Size = New System.Drawing.Size(147, 42)
        Me.AddOrdersBtn.TabIndex = 4
        Me.AddOrdersBtn.Text = "   Add Orders"
        Me.AddOrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddOrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddOrdersBtn.UseVisualStyleBackColor = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Width = 150
        '
        'OrderType
        '
        Me.OrderType.HeaderText = "Order Type"
        Me.OrderType.Name = "OrderType"
        Me.OrderType.Width = 120
        '
        'Products
        '
        Me.Products.HeaderText = "Products"
        Me.Products.Name = "Products"
        Me.Products.Width = 150
        '
        'Quantities
        '
        Me.Quantities.HeaderText = "Quantities"
        Me.Quantities.Name = "Quantities"
        Me.Quantities.Width = 150
        '
        'UnitPrices
        '
        Me.UnitPrices.HeaderText = "Unit Prices"
        Me.UnitPrices.Name = "UnitPrices"
        Me.UnitPrices.Width = 150
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Width = 120
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 120
        '
        'Edit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle2
        Me.Edit.HeaderText = "Actions"
        Me.Edit.Name = "Edit"
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'Delete
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle3
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1296, 568)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AddOrdersBtn)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Orders"
        Me.Text = "Orders"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddOrdersBtn As RoundedButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents OrderType As DataGridViewTextBoxColumn
    Friend WithEvents Products As DataGridViewTextBoxColumn
    Friend WithEvents Quantities As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrices As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
