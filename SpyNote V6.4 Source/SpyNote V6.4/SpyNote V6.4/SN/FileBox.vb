Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN

Public Class FileBox
    Private PATH As String

    Private xColorR As Color

    Private aColorR As Color

    Public strGetFiles As String

    Public Multi As Boolean

    Private ToolTip_0 As SN.ToolTip_0

    Private MaxLength As String()

    Private Count As Integer

    Private x As Integer

    Private y As Integer

    Private rwidx As Integer
    Public Sub New()
        Me.PATH = Nothing
        Me.xColorR = Color.FromArgb(190, 190, 190)
        Me.aColorR = Color.FromArgb(45, 45, 48)
        Me.strGetFiles = "*.*"
        Me.Multi = False
        Me.ToolTip_0 = New SN.ToolTip_0()
        Me.Count = 0
        Me.InitializeComponent()
    End Sub

    Public Sub _GetLogicalDrives()
        Me.TEXTPATH.Text = Nothing
        Me.BTNback.backColorNone0 = Me.xColorR
        Me.BTNback.backColorNone1 = Me.xColorR
        Me.BTNback.Refresh()
        Me.BoxView1.Rows.Clear()
        Dim logicalDrives As String() = Environment.GetLogicalDrives()
        Dim num As Integer = 0
        While num < CInt(logicalDrives.Length)
            Dim str As String = logicalDrives(num)
            Try
                Dim driveInfo As System.IO.DriveInfo = New System.IO.DriveInfo(str)
                If (driveInfo.DriveType = DriveType.Removable Or driveInfo.DriveType = DriveType.Fixed) Then
                    Me.BoxView1.Rows.Add(New Object() {Store.Bitmap_0("FileBox\Drive"), String.Concat(str, Strings.Space(2), driveInfo.VolumeLabel.Trim()), Store.BytesConverter(driveInfo.TotalSize).GetValue(0)})
                    Me.BoxView1.Rows(Me.BoxView1.Rows.Count - 1).Tag = str
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            num = num + 1
        End While
    End Sub

    Private Sub BoxView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles BoxView1.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.rwidx = e.RowIndex
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub BoxView1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BoxView1.MouseDoubleClick
        If (Me.BoxView1.SelectedRows.Count = 1) Then
            For i As Integer = Me.BoxView1.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Me.BoxView1.Rows(Me.BoxView1.SelectedRows(i).Index).Tag)
                If (str IsNot Nothing) Then
                    If (Directory.Exists(str)) Then
                        Me.ViewList(DirectCast((New String() {str}), Array))
                        Me.RESplit()
                        Me.BtnNext.backColorNone0 = Me.xColorR
                        Me.BtnNext.backColorNone1 = Me.xColorR
                        Me.BtnNext.Refresh()
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub BoxView1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BoxView1.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar1 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            visualStudioVerticalScrollBar1.Value = visualStudioVerticalScrollBar1.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar1
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub BoxView1_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles BoxView1.RowStateChanged
        If (e.StateChanged = DataGridViewElementStates.Selected) Then
            Me.rwidx = e.Row.Index
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.Row.Index >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.Row.Index)
        End If
    End Sub

    Private Sub BoxView1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles BoxView1.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.y = e.NewValue
            Me.VisualStudioVerticalScrollBar1.Value = Me.y
        Else
            Me.x = e.NewValue
        End If
    End Sub

    Private Sub BTNback_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNback.Click
        If (Me.Count >= 0) Then
            Dim num As Integer = Me.PATH.LastIndexOf("\"c)
            If (num = -1) Then
                Me._GetLogicalDrives()
            ElseIf (Not Me.PATH.EndsWith(":\")) Then
                Me.ViewList(DirectCast((New String() {If(Me.PATH.Substring(0, num).EndsWith(":"), String.Concat(Me.PATH.Substring(0, num), "\"), Me.PATH.Substring(0, num))}), Array))
                Me.Count = Me.Count - 1
                Me.BtnNext.backColorNone0 = Me.aColorR
                Me.BtnNext.backColorNone1 = Me.aColorR
                Me.BtnNext.Refresh()
            Else
                Me._GetLogicalDrives()
            End If
        End If
    End Sub

    Private Sub BTNCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNCancel.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BTNDESK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNDESK.Click
        Me.ViewList(DirectCast((New Object() {Me.BTNDESK.Tag}), Array))
        Me.RESplit()
    End Sub

    Private Sub BTNDocuments_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNDocuments.Click
        Me.ViewList(DirectCast((New Object() {Me.BTNDocuments.Tag}), Array))
        Me.RESplit()
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim flag As Boolean = Me.Count <= Me.MaxLength.Length - 1
        If flag Then
            Dim parametersArray As Array = New String() {If(Me.PATH.EndsWith("\"), (Me.PATH + Me.MaxLength(Me.Count)), (Me.PATH + "\" + Me.MaxLength(Me.Count)))}
            Me.ViewList(parametersArray)
            Me.Count += 1
            Me.BTNback.backColorNone0 = Me.aColorR
            Me.BTNback.backColorNone1 = Me.aColorR
            Me.BTNback.Refresh()
            Dim flag2 As Boolean = Me.Count > Me.MaxLength.Length - 1
            If flag2 Then
                Me.BtnNext.backColorNone0 = Me.xColorR
                Me.BtnNext.backColorNone1 = Me.xColorR
                Me.BtnNext.Refresh()
            End If
        Else
            Me.BtnNext.backColorNone0 = Me.xColorR
            Me.BtnNext.backColorNone1 = Me.xColorR
            Me.BtnNext.Refresh()
        End If
    End Sub
    Private Sub BTNPictures_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNPictures.Click
        Me.ViewList(DirectCast((New Object() {Me.BTNPictures.Tag}), Array))
        Me.RESplit()
    End Sub

    Private Sub BTNSAVE_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNSAVE.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BTNUserProfile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNUserProfile.Click
        Me.ViewList(DirectCast((New Object() {Me.BTNUserProfile.Tag}), Array))
        Me.RESplit()
    End Sub

    Private Sub BTNVideos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNVideos.Click
        Me.ViewList(DirectCast((New Object() {Me.BTNVideos.Tag}), Array))
        Me.RESplit()
    End Sub
    Private Sub FileBox_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\20.ico"))
        Try
            Me.TEXTPATH.HTBTB.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
            Me.ThemeTextBox1.HTBTB.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
            Me.BTNback.ImageChoice = Store.Bitmap_0("FileBox\Left")
            Me.BTNback.ShowImage = True
            Me.BtnNext.ImageChoice = Store.Bitmap_0("FileBox\Right")
            Me.BtnNext.ShowImage = True
            Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim str As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            Dim folderPath1 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
            Dim str1 As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            Dim folderPath2 As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            Me.BTNDESK.ImageChoice = Store.Bitmap_0("FileBox\Desktop")
            Me.BTNDESK.ShowImage = True
            Me.BTNDESK.Tag = folderPath
            Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNDESK, "Desktop")
            Me.BTNPictures.ImageChoice = Store.Bitmap_0("FileBox\Pictures")
            Me.BTNPictures.ShowImage = True
            Me.BTNPictures.Tag = str
            Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNPictures, "Pictures")
            Me.BTNVideos.ImageChoice = Store.Bitmap_0("FileBox\Videos")
            Me.BTNVideos.ShowImage = True
            Me.BTNVideos.Tag = folderPath1
            Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNVideos, "Videos")
            Me.BTNDocuments.ImageChoice = Store.Bitmap_0("FileBox\Documents")
            Me.BTNDocuments.ShowImage = True
            Me.BTNDocuments.Tag = str1
            Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNDocuments, "Documents")
            Me.BTNUserProfile.ImageChoice = Store.Bitmap_0("FileBox\UserProfile")
            Me.BTNUserProfile.ShowImage = True
            Me.BTNUserProfile.Tag = folderPath2
            Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNUserProfile, "UserProfile")
            Me.ToolTip_0._ToolTip.SetToolTip(Me.BtnNext, "Go Forward")
            Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNback, "Go Back")
            Me.BoxView1.MultiSelect = Me.Multi
            Me.ViewList(DirectCast((New String() {folderPath}), Array))
            Me.RESplit()
            Me.TScrolls.Interval = Store.TScrollsInterval
            Me.TScrolls.Enabled = True
        Catch exception As System.Exception
        End Try
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub GridViewoVerticalScrollBar0()
        Dim flag As Boolean = Me.BoxView1.Rows.Count > 0
        If flag Then
            Dim num As Integer = Me.BoxView1.Rows.Count * Me.BoxView1.Rows(0).Height
            Dim flag2 As Boolean = num > Me.BoxView1.Height
            If flag2 Then
                Dim flag3 As Boolean = Not Me.VisualStudioVerticalScrollBar1.Visible
                If flag3 Then
                    Me.VisualStudioVerticalScrollBar1.Visible = True
                End If
            Else
                Dim flag4 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
                If flag4 Then
                    Me.VisualStudioVerticalScrollBar1.Visible = False
                End If
            End If
        Else
            Dim flag5 As Boolean = Me.VisualStudioVerticalScrollBar1.Visible > False
            If flag5 Then
                Me.VisualStudioVerticalScrollBar1.Visible = False
            End If
        End If
    End Sub
    Private Sub RefScrolls()
        Dim num As Integer = 0
        If (MyBase.Visible) Then
            SyncLock Me.BoxView1
                If (Me.BoxView1.Rows.Count > 0) Then
                    If (Me.BoxView1.Rows.Count * Me.BoxView1.Rows(0).Height > Me.BoxView1.Height) Then
                        num = CInt(Math.Round(CDbl(Me.BoxView1.Height) / CDbl(Me.BoxView1.Rows(0).Height))) - 2
                        If (num < 0) Then
                            num = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar1.Maximum = Me.BoxView1.Rows.Count - num
                Me.GridViewoVerticalScrollBar0()
                Me.VisualStudioVerticalScrollBar1.Llen = If(Me.rwidx >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, Me.rwidx)
            End SyncLock
        End If
    End Sub

    Private Sub RESplit()
        Me.MaxLength = Me.PATH.Split(New String() {"\"}, StringSplitOptions.None)
        Me.Count = CInt(Me.MaxLength.Length)
        Me.BTNback.backColorNone0 = Me.aColorR
        Me.BTNback.backColorNone1 = Me.aColorR
        Me.BTNback.Refresh()
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

    Public Sub ViewList(ByVal ParametersArray As Array)
        Me.TEXTPATH.Text = Me.TEXTPATH.Text.Replace("\", "/")
        Me.TEXTPATH.Refresh()
        Try
            Me.PATH = Conversions.ToString(ParametersArray.GetValue(0))
            Me.TEXTPATH.Text = Conversions.ToString(ParametersArray.GetValue(0))
            Me.BoxView1.Rows.Clear()
            Dim directoryInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Conversions.ToString(ParametersArray.GetValue(0)))
            Dim directories As String() = Directory.GetDirectories(directoryInfo.FullName)
            Dim num As Integer = 0
            While num < CInt(directories.Length)
                Dim directoryInfo1 As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(directories(num))
                Me.BoxView1.Rows.Add(New Object() {Store.Bitmap_0("FileBox\folder"), directoryInfo1.Name, ""})
                Me.BoxView1.Rows(Me.BoxView1.Rows.Count - 1).Tag = directoryInfo1.FullName
                num = num + 1
            End While
            Dim files As System.IO.FileInfo() = directoryInfo.GetFiles(Me.strGetFiles)
            Dim num1 As Integer = 0
            While num1 < CInt(files.Length)
                Dim fileInfo As System.IO.FileInfo = files(num1)
                Dim icon As System.Drawing.Icon = Nothing
                icon = System.Drawing.Icon.ExtractAssociatedIcon(fileInfo.FullName)
                Me.BoxView1.Rows.Add(New Object() {libIcons.IconGraphics(icon), fileInfo.Name, Store.BytesConverter(fileInfo.Length).GetValue(0)})
                num1 = num1 + 1
            End While
        Catch exception1 As System.Exception
            MsgBox(exception1.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
        End Try
        Me.TEXTPATH.Text = Me.TEXTPATH.Text.Replace("/", "\")
        Me.TEXTPATH.Refresh()
    End Sub

    Private Sub VisualStudioVerticalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar1.Scroll
        Try
            If (Me.BoxView1.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.BoxView1.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar1.Value
            End If
        Catch exception As System.Exception
            If (Me.BoxView1.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.BoxView1.FirstDisplayedScrollingRowIndex = Me.BoxView1.RowCount - 1
            End If
        End Try
    End Sub
End Class