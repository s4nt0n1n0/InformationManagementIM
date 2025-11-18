<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservations
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservations))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataReservations = New System.Windows.Forms.DataGridView()
        Me.btnAddNewReservation = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guests = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reservationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actions = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Approved = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Reject = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservations Management"
        '
        'DataReservations
        '
        Me.DataReservations.AllowUserToAddRows = False
        Me.DataReservations.AllowUserToDeleteRows = False
        Me.DataReservations.AllowUserToResizeColumns = False
        Me.DataReservations.AllowUserToResizeRows = False
        Me.DataReservations.BackgroundColor = System.Drawing.Color.White
        Me.DataReservations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataReservations.ColumnHeadersHeight = 40
        Me.DataReservations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FullName, Me.ContactNumber, Me.Guests, Me.Time, Me.reservationDate, Me.EventType, Me.Status, Me.Actions, Me.Edit, Me.Delete, Me.Approved, Me.Reject})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataReservations.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataReservations.EnableHeadersVisualStyles = False
        Me.DataReservations.Location = New System.Drawing.Point(33, 79)
        Me.DataReservations.Margin = New System.Windows.Forms.Padding(2)
        Me.DataReservations.Name = "DataReservations"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataReservations.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.DataReservations.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataReservations.Size = New System.Drawing.Size(1032, 116)
        Me.DataReservations.TabIndex = 5
        '
        'btnAddNewReservation
        '
        Me.btnAddNewReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddNewReservation.FlatAppearance.BorderSize = 0
        Me.btnAddNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewReservation.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewReservation.ForeColor = System.Drawing.Color.White
        Me.btnAddNewReservation.Image = CType(resources.GetObject("btnAddNewReservation.Image"), System.Drawing.Image)
        Me.btnAddNewReservation.Location = New System.Drawing.Point(841, 12)
        Me.btnAddNewReservation.Name = "btnAddNewReservation"
        Me.btnAddNewReservation.Size = New System.Drawing.Size(224, 44)
        Me.btnAddNewReservation.TabIndex = 6
        Me.btnAddNewReservation.Text = "   Add New Reservation"
        Me.btnAddNewReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNewReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewReservation.UseVisualStyleBackColor = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'FullName
        '
        Me.FullName.HeaderText = "Full Name"
        Me.FullName.Name = "FullName"
        Me.FullName.Width = 150
        '
        'ContactNumber
        '
        Me.ContactNumber.HeaderText = "Contact Number"
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.Width = 150
        '
        'Guests
        '
        Me.Guests.HeaderText = "Guests"
        Me.Guests.Name = "Guests"
        Me.Guests.Width = 120
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.Width = 120
        '
        'reservationDate
        '
        Me.reservationDate.HeaderText = "Date"
        Me.reservationDate.Name = "reservationDate"
        Me.reservationDate.Width = 120
        '
        'EventType
        '
        Me.EventType.HeaderText = "Event Type"
        Me.EventType.Name = "EventType"
        Me.EventType.Width = 120
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 120
        '
        'Actions
        '
        Me.Actions.HeaderText = "Actions"
        Me.Actions.Image = Global.InformationManagement.My.Resources.Resources.view
        Me.Actions.Name = "Actions"
        Me.Actions.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Actions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Actions.Width = 50
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Image = Global.InformationManagement.My.Resources.Resources.editing
        Me.Edit.Name = "Edit"
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Width = 50
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = Global.InformationManagement.My.Resources.Resources.deletebox
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Width = 50
        '
        'Approved
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Approved.DefaultCellStyle = DataGridViewCellStyle2
        Me.Approved.HeaderText = ""
        Me.Approved.Name = "Approved"
        Me.Approved.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Approved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Approved.Text = "Approved"
        Me.Approved.UseColumnTextForButtonValue = True
        '
        'Reject
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Reject.DefaultCellStyle = DataGridViewCellStyle3
        Me.Reject.HeaderText = ""
        Me.Reject.Name = "Reject"
        Me.Reject.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Reject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Reject.Text = "Reject"
        Me.Reject.UseColumnTextForButtonValue = True
        '
        'Reservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1123, 749)
        Me.Controls.Add(Me.btnAddNewReservation)
        Me.Controls.Add(Me.DataReservations)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Reservations"
        Me.Text = "Reservations"
        CType(Me.DataReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataReservations As DataGridView
    Friend WithEvents btnAddNewReservation As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents Guests As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents reservationDate As DataGridViewTextBoxColumn
    Friend WithEvents EventType As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Actions As DataGridViewImageColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents Approved As DataGridViewButtonColumn
    Friend WithEvents Reject As DataGridViewButtonColumn
End Class
