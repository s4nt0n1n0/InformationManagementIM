<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditReservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditReservation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFullName = New InformationManagement.RoundedTextBox()
        Me.txtEmail = New InformationManagement.RoundedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhone = New InformationManagement.RoundedTextBox()
        Me.numGuests = New System.Windows.Forms.NumericUpDown()
        Me.cmbEventType = New System.Windows.Forms.ComboBox()
        Me.reservationDate = New System.Windows.Forms.DateTimePicker()
        Me.reservationTime = New System.Windows.Forms.DateTimePicker()
        Me.txtNote = New InformationManagement.RoundedTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdateReservation = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.numGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Edit Reservation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.Transparent
        Me.txtFullName.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtFullName.Location = New System.Drawing.Point(30, 81)
        Me.txtFullName.MaxLength = 32767
        Me.txtFullName.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtFullName.Multiline = False
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullName.Size = New System.Drawing.Size(438, 40)
        Me.txtFullName.TabIndex = 23
        Me.txtFullName.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFullName.TextColor = System.Drawing.Color.Black
        Me.txtFullName.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtEmail.Location = New System.Drawing.Point(30, 163)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.Size = New System.Drawing.Size(438, 40)
        Me.txtEmail.TabIndex = 24
        Me.txtEmail.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.TextColor = System.Drawing.Color.Black
        Me.txtEmail.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.Transparent
        Me.txtPhone.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtPhone.Location = New System.Drawing.Point(30, 242)
        Me.txtPhone.MaxLength = 32767
        Me.txtPhone.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtPhone.Multiline = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.Size = New System.Drawing.Size(438, 40)
        Me.txtPhone.TabIndex = 27
        Me.txtPhone.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPhone.TextColor = System.Drawing.Color.Black
        Me.txtPhone.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'numGuests
        '
        Me.numGuests.BackColor = System.Drawing.Color.WhiteSmoke
        Me.numGuests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numGuests.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numGuests.Location = New System.Drawing.Point(32, 316)
        Me.numGuests.Name = "numGuests"
        Me.numGuests.Size = New System.Drawing.Size(180, 21)
        Me.numGuests.TabIndex = 28
        Me.numGuests.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbEventType
        '
        Me.cmbEventType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbEventType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEventType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEventType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEventType.FormattingEnabled = True
        Me.cmbEventType.ItemHeight = 30
        Me.cmbEventType.Items.AddRange(New Object() {"Birthday Parte\y", "Wedding", "Anniversary", "Corporate Event", "Family Dinner", "Other"})
        Me.cmbEventType.Location = New System.Drawing.Point(276, 316)
        Me.cmbEventType.Name = "cmbEventType"
        Me.cmbEventType.Size = New System.Drawing.Size(192, 36)
        Me.cmbEventType.TabIndex = 29
        '
        'reservationDate
        '
        Me.reservationDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.reservationDate.CustomFormat = "dd/MM/yyyy"
        Me.reservationDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.reservationDate.Location = New System.Drawing.Point(30, 385)
        Me.reservationDate.MaxDate = New Date(2025, 10, 31, 0, 0, 0, 0)
        Me.reservationDate.Name = "reservationDate"
        Me.reservationDate.Size = New System.Drawing.Size(182, 25)
        Me.reservationDate.TabIndex = 30
        Me.reservationDate.Value = New Date(2025, 10, 31, 0, 0, 0, 0)
        '
        'reservationTime
        '
        Me.reservationTime.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.reservationTime.CustomFormat = "dd/MM/yyyy"
        Me.reservationTime.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.reservationTime.Location = New System.Drawing.Point(276, 385)
        Me.reservationTime.MaxDate = New Date(2025, 10, 31, 0, 0, 0, 0)
        Me.reservationTime.Name = "reservationTime"
        Me.reservationTime.Size = New System.Drawing.Size(192, 25)
        Me.reservationTime.TabIndex = 31
        Me.reservationTime.Value = New Date(2025, 10, 31, 0, 0, 0, 0)
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.Transparent
        Me.txtNote.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtNote.Location = New System.Drawing.Point(30, 450)
        Me.txtNote.MaxLength = 32767
        Me.txtNote.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtNote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNote.Size = New System.Drawing.Size(438, 58)
        Me.txtNote.TabIndex = 32
        Me.txtNote.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNote.TextColor = System.Drawing.Color.Black
        Me.txtNote.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(193, 542)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 33)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdateReservation
        '
        Me.btnUpdateReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdateReservation.FlatAppearance.BorderSize = 0
        Me.btnUpdateReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateReservation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateReservation.ForeColor = System.Drawing.Color.White
        Me.btnUpdateReservation.Location = New System.Drawing.Point(295, 541)
        Me.btnUpdateReservation.Name = "btnUpdateReservation"
        Me.btnUpdateReservation.Size = New System.Drawing.Size(173, 33)
        Me.btnUpdateReservation.TabIndex = 27
        Me.btnUpdateReservation.Text = "Update Reservation"
        Me.btnUpdateReservation.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Guests"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(273, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Event Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(273, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Note"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(449, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 27)
        Me.btnClose.TabIndex = 39
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FormEditReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 588)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUpdateReservation)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.reservationTime)
        Me.Controls.Add(Me.reservationDate)
        Me.Controls.Add(Me.cmbEventType)
        Me.Controls.Add(Me.numGuests)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEditReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.numGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFullName As RoundedTextBox
    Friend WithEvents txtEmail As RoundedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As RoundedTextBox
    Friend WithEvents numGuests As NumericUpDown
    Friend WithEvents cmbEventType As ComboBox
    Friend WithEvents reservationDate As DateTimePicker
    Friend WithEvents reservationTime As DateTimePicker
    Friend WithEvents txtNote As RoundedTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdateReservation As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClose As Button
End Class
