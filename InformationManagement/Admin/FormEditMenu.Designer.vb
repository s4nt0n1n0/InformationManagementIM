<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditMenu))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemName = New InformationManagement.RoundedTextBox()
        Me.txtDescription = New InformationManagement.RoundedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.txtxImageUrl = New InformationManagement.RoundedTextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.numericPrice = New System.Windows.Forms.NumericUpDown()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(471, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 27)
        Me.btnClose.TabIndex = 26
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Edit Menu Item"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.Transparent
        Me.txtItemName.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtItemName.Location = New System.Drawing.Point(41, 91)
        Me.txtItemName.MaxLength = 32767
        Me.txtItemName.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtItemName.Multiline = False
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.Size = New System.Drawing.Size(427, 40)
        Me.txtItemName.TabIndex = 28
        Me.txtItemName.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItemName.TextColor = System.Drawing.Color.Black
        Me.txtItemName.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtDescription.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtDescription.Location = New System.Drawing.Point(41, 164)
        Me.txtDescription.MaxLength = 32767
        Me.txtDescription.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.Size = New System.Drawing.Size(427, 40)
        Me.txtDescription.TabIndex = 29
        Me.txtDescription.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescription.TextColor = System.Drawing.Color.Black
        Me.txtDescription.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Image Url"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Status"
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdateItem.FlatAppearance.BorderSize = 0
        Me.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItem.ForeColor = System.Drawing.Color.White
        Me.btnUpdateItem.Location = New System.Drawing.Point(41, 514)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(427, 43)
        Me.btnUpdateItem.TabIndex = 36
        Me.btnUpdateItem.Text = "Update Item"
        Me.btnUpdateItem.UseVisualStyleBackColor = False
        '
        'txtxImageUrl
        '
        Me.txtxImageUrl.BackColor = System.Drawing.Color.Transparent
        Me.txtxImageUrl.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtxImageUrl.Location = New System.Drawing.Point(41, 371)
        Me.txtxImageUrl.MaxLength = 32767
        Me.txtxImageUrl.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtxImageUrl.Multiline = False
        Me.txtxImageUrl.Name = "txtxImageUrl"
        Me.txtxImageUrl.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtxImageUrl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtxImageUrl.Size = New System.Drawing.Size(427, 40)
        Me.txtxImageUrl.TabIndex = 37
        Me.txtxImageUrl.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtxImageUrl.TextColor = System.Drawing.Color.Black
        Me.txtxImageUrl.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.ItemHeight = 30
        Me.cmbStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cmbStatus.Location = New System.Drawing.Point(49, 458)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(427, 36)
        Me.cmbStatus.TabIndex = 38
        '
        'numericPrice
        '
        Me.numericPrice.AutoSize = True
        Me.numericPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.numericPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numericPrice.Location = New System.Drawing.Point(41, 247)
        Me.numericPrice.Name = "numericPrice"
        Me.numericPrice.Size = New System.Drawing.Size(427, 16)
        Me.numericPrice.TabIndex = 39
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cmbCategory.Location = New System.Drawing.Point(41, 303)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(427, 36)
        Me.cmbCategory.TabIndex = 40
        '
        'FormEditMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(512, 656)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.numericPrice)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtxImageUrl)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEditMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditMenu"
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemName As RoundedTextBox
    Friend WithEvents txtDescription As RoundedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents txtxImageUrl As RoundedTextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents numericPrice As NumericUpDown
    Friend WithEvents cmbCategory As ComboBox
End Class
