Imports System.Drawing.Drawing2D

Public Class FormEditMenu
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub RoundedPane21_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    ' Draw rounded border for Panel
    Private Sub DrawRoundedBorder(p As Panel, color As Color, Optional radius As Integer = 10)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(p.Width - radius - 1, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(p.Width - radius - 1, p.Height - radius - 1, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, p.Height - radius - 1, radius, radius), 90, 90)
        path.CloseFigure()

        p.Region = New Region(path)

        ' Draw colored border
        Dim bmp As New Bitmap(p.Width, p.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Using pen As New Pen(color, 2)
                g.DrawPath(pen, path)
            End Using
        End Using
        p.BackgroundImage = bmp
        p.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub AddPlaceholder(txt As TextBox, placeholder As String, panel As Panel)
        txt.Text = placeholder
        txt.ForeColor = Color.Gray

        ' When focus gained
        AddHandler txt.GotFocus, Sub()
                                     If txt.Text = placeholder Then
                                         txt.Text = ""
                                         txt.ForeColor = Color.Black
                                     End If
                                     DrawRoundedBorder(panel, Color.DeepSkyBlue, 10) ' Blue border when active
                                 End Sub

        ' When focus lost
        AddHandler txt.LostFocus, Sub()
                                      If String.IsNullOrWhiteSpace(txt.Text) Then
                                          txt.Text = placeholder
                                          txt.ForeColor = Color.Gray
                                      End If
                                      DrawRoundedBorder(panel, Color.LightGray, 10) ' Gray border when inactive
                                  End Sub
    End Sub

    Private Sub FormEditMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ComboBox_DrawItem(sender As Object, e As DrawItemEventArgs) _
       Handles cmbCategory.DrawItem, cmbStatus.DrawItem

        If e.Index < 0 Then Return
        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        e.DrawBackground()
        e.Graphics.DrawString(cmb.Items(e.Index).ToString(), cmb.Font, Brushes.Black, e.Bounds)
        e.DrawFocusRectangle()
    End Sub
    Private Sub FormEditMenu_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class