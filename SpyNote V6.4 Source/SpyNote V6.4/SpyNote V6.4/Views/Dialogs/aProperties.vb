Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class aProperties
    Public TClient As SocketClient

    Private b1 As Bitmap

    Private b2 As Bitmap

    Private b3 As Bitmap

    Private x As Integer

    Private y As Integer

    Private x1 As Integer

    Private y1 As Integer

    Private x10 As Integer

    Private y10 As Integer
    Private Sub aProperties_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\10.ico"))
        Me.b1 = New Bitmap(Store.Bitmap_0("AppProperties\Permissions"))
        Me.b2 = New Bitmap(Store.Bitmap_0("AppProperties\Receivers"))
        Me.b3 = New Bitmap(Store.Bitmap_0("AppProperties\Activities"))
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar2.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar2.Maximum, Me.VisualStudioVerticalScrollBar2.Maximum, e.RowIndex)
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

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar3.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar3.Maximum, Me.VisualStudioVerticalScrollBar3.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub DataGridView2_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataGridView2.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar3 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar3
            visualStudioVerticalScrollBar3.Value = visualStudioVerticalScrollBar3.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar3
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub DataGridView2_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles DataGridView2.RowStateChanged
        If (e.StateChanged = DataGridViewElementStates.Selected) Then
            Me.VisualStudioVerticalScrollBar3.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar3.Maximum, Me.VisualStudioVerticalScrollBar3.Maximum, e.Row.Index)
        End If
    End Sub

    Private Sub DataGridView2_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles DataGridView2.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.y10 = e.NewValue
            Me.VisualStudioVerticalScrollBar3.Value = Me.y10
        Else
            Me.x10 = e.NewValue
            Me.VisualStudioHorizontalScrollBar3.Value = Me.x10
        End If
    End Sub

    Private Sub DataGridView2_Sorted(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView2.Sorted
        Me.VisualStudioVerticalScrollBar3.Llen = -1
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
                End If
            End If
        Else
            Dim flag9 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
            If flag9 Then
                Me.VisualStudioVerticalScrollBar1.Visible = False
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

    Private Sub GridViewoVerticalScrollBar2()
        Dim columnsWidth As Integer = Me.DataGridView2.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DataGridView2.Width
        If flag Then
            Me.VisualStudioHorizontalScrollBar3.Maximum = columnsWidth - Me.DataGridView2.Width
        Else
            Me.VisualStudioHorizontalScrollBar3.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.DataGridView2.Width
        If flag2 Then
            Dim flag3 As Boolean = Not Me.VisualStudioHorizontalScrollBar3.Visible
            If flag3 Then
                Me.VisualStudioHorizontalScrollBar3.Visible = True
            End If
        Else
            Dim flag4 As Boolean = Me.VisualStudioHorizontalScrollBar3.Visible > False
            If flag4 Then
                Me.VisualStudioHorizontalScrollBar3.Visible = False
            End If
        End If
        Dim flag5 As Boolean = Me.DataGridView2.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.DataGridView2.Rows.Count * Me.DataGridView2.Rows(0).Height
            Dim flag6 As Boolean = num > Me.DataGridView2.Height
            If flag6 Then
                Dim flag7 As Boolean = Not Me.VisualStudioVerticalScrollBar3.Visible
                If flag7 Then
                    Me.VisualStudioVerticalScrollBar3.Visible = True
                End If
            Else
                Dim flag8 As Boolean = Me.VisualStudioVerticalScrollBar3.Visible > False
                If flag8 Then
                    Me.VisualStudioVerticalScrollBar3.Visible = False
                End If
            End If
        Else
            Dim flag9 As Boolean = Me.VisualStudioVerticalScrollBar3.Visible > False
            If flag9 Then
                Me.VisualStudioVerticalScrollBar3.Visible = False
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
            End SyncLock
        End If
    End Sub

    Private Sub RefScrolls3()
        Dim num As Integer = 0
        If (MyBase.Visible) Then
            SyncLock Me.DataGridView2
                If (Me.DataGridView2.Rows.Count > 0) Then
                    If (Me.DataGridView2.Rows.Count * Me.DataGridView2.Rows(0).Height > Me.DataGridView2.Height) Then
                        num = CInt(Math.Round(CDbl(Me.DataGridView2.Height) / CDbl(Me.DataGridView2.Rows(0).Height))) - 2
                        If (num < 0) Then
                            num = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar3.Maximum = Me.DataGridView2.Rows.Count - num
                Me.GridViewoVerticalScrollBar2()
            End SyncLock
        End If
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Try
            Dim value As String = CStr(Ay.GetValue(0))
            If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) <> 0) Then
            Else
                Dim strArrays As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitLines}, StringSplitOptions.RemoveEmptyEntries)
                Try
                    Dim strArrays1 As String() = strArrays(0).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    Me.Label1.Text = String.Concat("ApplicationName:", strArrays1(0))
                    Me.Label2.Text = String.Concat("PackageName:", strArrays1(1))
                    Dim numArray As Byte() = Convert.FromBase64String(strArrays1(2))
                    Dim image As System.Drawing.Image = System.Drawing.Image.FromStream(New MemoryStream(numArray))
                    Me.PictureBox1.Image = image
                    Me.Label3.Text = String.Concat("Apps source:", strArrays1(3))
                    Me.Label4.Text = String.Concat("installTime:", strArrays1(4))
                Catch exception As System.Exception
                End Try
                Try
                    Dim strArrays2 As String() = strArrays(1).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    Dim length As Integer = CInt(strArrays2.Length) - 1
                    For i As Integer = 0 To length Step 1
                        If (Operators.CompareString(strArrays2(i).Trim(), "null", False) <> 0) Then
                            Me.ViewManager.Rows.Add(New Object() {Me.b1, strArrays2(i)})
                        End If
                    Next

                Catch exception1 As System.Exception
                End Try
                Try
                    Dim strArrays3 As String() = strArrays(2).Split(New String() {Data.SplitPaths}, StringSplitOptions.RemoveEmptyEntries)
                    Dim num As Integer = CInt(strArrays3.Length) - 1
                    For j As Integer = 0 To num Step 1
                        Dim strArrays4 As String() = strArrays3(j).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                        If (Operators.CompareString(strArrays4(0).Trim(), "null", False) <> 0 And Operators.CompareString(strArrays4(1).Trim(), "null", False) <> 0) Then
                            Me.DataGridView1.Rows.Add(New Object() {Me.b2, strArrays4(0), strArrays4(1)})
                            Dim count As Integer = Me.DataGridView1.Rows.Count - 1
                            If (Operators.CompareString(strArrays4(1).ToLower(), "true", False) = 0) Then
                                Me.DataGridView1.Rows(count).Cells(2).Style.ForeColor = Color.FromArgb(255, 255, 92, 94)
                                Me.DataGridView1.Rows(count).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 255, 92, 94)
                            End If
                        End If
                    Next

                Catch exception2 As System.Exception
                End Try
                Try
                    Dim strArrays5 As String() = strArrays(3).Split(New String() {Data.SplitPaths}, StringSplitOptions.RemoveEmptyEntries)
                    Dim length1 As Integer = CInt(strArrays5.Length) - 1
                    For k As Integer = 0 To length1 Step 1
                        Dim strArrays6 As String() = strArrays5(k).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                        If (Operators.CompareString(strArrays6(0).Trim(), "null", False) <> 0 And Operators.CompareString(strArrays6(1).Trim(), "null", False) <> 0) Then
                            Me.DataGridView2.Rows.Add(New Object() {Me.b3, strArrays6(0), strArrays6(1)})
                            Dim count1 As Integer = Me.DataGridView2.Rows.Count - 1
                            If (Operators.CompareString(strArrays6(1).ToLower(), "true", False) = 0) Then
                                Me.DataGridView2.Rows(count1).Cells(2).Style.ForeColor = Color.FromArgb(255, 255, 92, 94)
                                Me.DataGridView2.Rows(count1).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 255, 92, 94)
                            End If
                        End If
                    Next

                Catch exception3 As System.Exception
                End Try
            End If
        Catch exception4 As System.Exception
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
        Me.RefScrolls2()
        Me.RefScrolls3()
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
        If (e.Row.Index <> -1) Then
            If (e.StateChanged = DataGridViewElementStates.Selected) Then
                Me.VisualStudioVerticalScrollBar1.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.Row.Index)
            End If
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

    Private Sub VisualStudioHorizontalScrollBar2_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar2.Scroll
        Try
            If (Me.DataGridView1.HorizontalScrollingOffset <> -1) Then
                Me.DataGridView1.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar2.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioHorizontalScrollBar3_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar3.Scroll
        Try
            If (Me.DataGridView2.HorizontalScrollingOffset <> -1) Then
                Me.DataGridView2.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar3.Value
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
            ProjectData.SetProjectError(exception)
            If (Me.DataGridView1.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
            End If
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar3_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar3.Scroll
        Try
            If (Me.DataGridView2.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.DataGridView2.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar3.Value
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            If (Me.DataGridView2.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataGridView2.FirstDisplayedScrollingRowIndex = Me.DataGridView2.RowCount - 1
            End If
            ProjectData.ClearProjectError()
        End Try
    End Sub
End Class