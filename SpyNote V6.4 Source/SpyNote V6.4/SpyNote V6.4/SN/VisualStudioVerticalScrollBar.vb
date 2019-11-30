Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports SpyNote_V6._4.SN.PI

Namespace SN
    <DefaultEvent("Scroll")>
    Public Class VisualStudioVerticalScrollBar
        Inherits Control
        Private _BaseColour As Color

        Private _ThumbNormalColour As Color

        Private _ThumbHoverColour As Color

        Private _ThumbPressedColour As Color

        Private _LenColour As Color

        Private _OuterBorderColour As Color

        Private _ThumbBorderColour As Color

        Public _Minimum As Integer

        Public _Len0 As Integer

        Public _Maximum As Integer

        Private _Value As Integer

        Public _SmallChange As Integer

        Private _ButtonSize As Integer

        Public _LargeChange As Integer

        Private _ShowOuterBorder As Boolean

        Private _ShowThumbBorder As Boolean

        Private _AmountOfInnerLines As VisualStudioVerticalScrollBar.__InnerLineCount

        Private _ThumbState As MouseState

        Private ThumbMovement As Integer

        Private TSA As Rectangle

        Private BSA As Rectangle

        Private Shaft As Rectangle

        Private Thumb As Rectangle

        Private ShowThumb As Boolean

        Private ThumbPressed As Boolean

        Private _ThumbSize As Integer

        Private bm As Bitmap

        Public Timers As System.Threading.Timer

        Private isa As Integer

        Private nx As Color

        Private clrSplit As Color

        <Category("Control")>
        Public Property AmountOfInnerLines As VisualStudioVerticalScrollBar.__InnerLineCount
            Get
                Return Me._AmountOfInnerLines
            End Get
            Set(ByVal value As VisualStudioVerticalScrollBar.__InnerLineCount)
                Me._AmountOfInnerLines = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BaseColour As Color
            Get
                Return Me._BaseColour
            End Get
            Set(ByVal value As Color)
                Me._BaseColour = value
            End Set
        End Property

        <Category("Control")>
        Public Property ButtonSize As Integer
            Get
                Return Me._ButtonSize
            End Get
            Set(ByVal value As Integer)
                If (value >= 16) Then
                    Me._ButtonSize = value
                Else
                    Me._ButtonSize = 16
                End If
            End Set
        End Property

        <Category("Control")>
        Public Property LargeChange As Integer
            Get
                Return Me._LargeChange
            End Get
            Set(ByVal value As Integer)
                If (value >= 1) Then
                    Me._LargeChange = value
                End If
            End Set
        End Property

        <Category("Colours")>
        Public Property LenColour As Color
            Get
                Return Me._LenColour
            End Get
            Set(ByVal value As Color)
                Me._LenColour = value
            End Set
        End Property

        <Category("Control")>
        Public Property Llen As Integer
            Get
                Return Me._Len0
            End Get
            Set(ByVal value As Integer)
                Me._Len0 = value
                Me.InvalidateLayout()
            End Set
        End Property

        <Category("Control")>
        Public Property Maximum As Integer
            Get
                Return Me._Maximum
            End Get
            Set(ByVal value As Integer)
                Me._Maximum = value
                If (value < Me._Value) Then
                    Me._Value = value
                End If
                If (value < Me._Minimum) Then
                    Me._Minimum = value
                End If
                Me.InvalidateLayout()
            End Set
        End Property

        <Category("Control")>
        Public Property Minimum As Integer
            Get
                Return Me._Minimum
            End Get
            Set(ByVal value As Integer)
                Me._Minimum = value
                If (value > Me._Value) Then
                    Me._Value = value
                End If
                If (value > Me.Maximum) Then
                    Me.Maximum = value
                End If
                Me.InvalidateLayout()
            End Set
        End Property

        <Category("Colours")>
        Public Property OuterBorderColour As Color
            Get
                Return Me._OuterBorderColour
            End Get
            Set(ByVal value As Color)
                Me._OuterBorderColour = value
            End Set
        End Property

        <Category("Control")>
        Public Property ShowOuterBorder As Boolean
            Get
                Return Me._ShowOuterBorder
            End Get
            Set(ByVal value As Boolean)
                Me._ShowOuterBorder = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Control")>
        Public Property ShowThumbBorder As Boolean
            Get
                Return Me._ShowThumbBorder
            End Get
            Set(ByVal value As Boolean)
                Me._ShowThumbBorder = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Control")>
        Public Property SmallChange As Integer
            Get
                Return Me._SmallChange
            End Get
            Set(value As Integer)
                Dim flag As Boolean = value < 1
                If Not flag Then
                    flag = (value > If((-If(((Me._SmallChange = value) > False), 1, 0)), 1, 0))
                    If flag Then
                    End If
                End If
            End Set
        End Property

        <Category("Colours")>
        Public Property ThumbBorderColour As Color
            Get
                Return Me._ThumbBorderColour
            End Get
            Set(ByVal value As Color)
                Me._ThumbBorderColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ThumbHoverColour As Color
            Get
                Return Me._ThumbHoverColour
            End Get
            Set(ByVal value As Color)
                Me._ThumbHoverColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ThumbNormalColour As Color
            Get
                Return Me._ThumbNormalColour
            End Get
            Set(ByVal value As Color)
                Me._ThumbNormalColour = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ThumbPressedColour As Color
            Get
                Return Me._ThumbPressedColour
            End Get
            Set(ByVal value As Color)
                Me._ThumbPressedColour = value
            End Set
        End Property

        <Category("Control")>
        Public Property Value As Integer
            Get
                Return Me._Value
            End Get
            Set(ByVal value As Integer)
                Dim num As Integer = value
                If (num <> Me._Value) Then
                    If (num < Me._Minimum) Then
                        Me._Value = Me._Minimum
                    ElseIf (num <= Me.Maximum) Then
                        Me._Value = value
                    Else
                        Me._Value = Me.Maximum
                    End If
                    Me.InvalidatePosition()
                    RaiseEvent Scroll(Me)
                End If
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            Me._BaseColour = Color.FromArgb(45, 45, 48)
            Me._ThumbNormalColour = Color.FromArgb(104, 104, 104)
            Me._ThumbHoverColour = Color.FromArgb(158, 158, 158)
            Me._ThumbPressedColour = Color.FromArgb(239, 235, 239)
            Me._LenColour = Color.FromArgb(0, 113, 171)
            Me._Minimum = 0
            Me._Len0 = -1
            Me._Maximum = 50
            Me._Value = 0
            Me._SmallChange = 10
            Me._ButtonSize = 16
            Me._LargeChange = 10
            Me._ShowOuterBorder = False
            Me._ShowThumbBorder = False
            Me._AmountOfInnerLines = VisualStudioVerticalScrollBar.__InnerLineCount.None
            Me._ThumbState = MouseState.None
            Me._ThumbSize = 38
            Me.isa = 0
            Me.nx = Me.BaseColour
            Me.clrSplit = Color.FromArgb(255, 83, 83, 90)
            MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.Selectable Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.DoubleBuffered = True
            MyBase.Size = New System.Drawing.Size(17, 50)
        End Sub

        Private Sub InvalidateLayout()
            Me.TSA = New Rectangle(0, 0, MyBase.Width, 16)
            Me.BSA = New Rectangle(0, MyBase.Height - Me.ButtonSize, MyBase.Width, Me.ButtonSize)
            Me.Shaft = New Rectangle(0, Me.TSA.Bottom + 1, MyBase.Width, CInt(Math.Round(CDbl(MyBase.Height) - CDbl(MyBase.Height) / 8 - 1)))
            Me.ShowThumb = Me.Maximum - Me._Minimum <> 0
            If (Me.ShowThumb) Then
                Me.Thumb = New Rectangle(0, 0, MyBase.Width, CInt(Math.Round(CDbl(MyBase.Height) / 8)))
            End If
            RaiseEvent Scroll(Me)
            Me.InvalidatePosition()
        End Sub

        Public Sub InvalidatePosition()
            Try
                Me.Thumb.Y = CInt(Math.Round(CDbl((Me.Value - Me._Minimum)) / CDbl((Me.Maximum - Me._Minimum)) * CDbl((Me.Shaft.Height - Me._ThumbSize)) + CDbl(Me._ThumbSize) / 2))
                MyBase.Invalidate()
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            If (If(e.Button <> System.Windows.Forms.MouseButtons.Left, False, Me.ShowThumb)) Then
                If (Me.Thumb.Contains(e.Location)) Then
                    Me._ThumbState = MouseState.Down
                    MyBase.Invalidate()
                    Return
                End If
                If (e.Y >= Me.Thumb.Y) Then
                    Me.ThumbMovement = Me.Value + Me.LargeChange
                Else
                    Me.ThumbMovement = Me.Value - Me.LargeChange
                End If
                Me.Value = Math.Min(Math.Max(Me.ThumbMovement, Me._Minimum), Me.Maximum)
                MyBase.Invalidate()
                Me.InvalidatePosition()
            End If
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            Me.Timers = New System.Threading.Timer(Sub(a0 As Object) Me.SubTimers(), Nothing, 0, 8)
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            Me._ThumbState = MouseState.None
            Dim r As Byte = Me.BaseColour.R
            Dim g As Byte = Me.BaseColour.G
            Dim baseColour As Color = Me.BaseColour
            Me.nx = Color.FromArgb(CInt(r), CInt(g), CInt(baseColour.B))
            Me.isa = 0
            Try
                Me.Timers.Dispose()
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            Try
                If (Me.Thumb.Contains(e.Location) And Me._ThumbState <> MouseState.Down) Then
                    Me._ThumbState = MouseState.Over
                ElseIf (Me._ThumbState <> MouseState.Down) Then
                    Me._ThumbState = MouseState.None
                End If
                If (If(Me._ThumbState <> MouseState.Down, False, Me.ShowThumb)) Then
                    Dim y As Integer = e.Y + 2 - Me.TSA.Height - Me._ThumbSize / 2
                    Dim height As Integer = Me.Shaft.Height - Me._ThumbSize
                    Me.ThumbMovement = CInt(Math.Round(CDbl(y) / CDbl(height) * CDbl((Me.Maximum - Me._Minimum)))) - Me._Minimum
                    Me.Value = Math.Min(Math.Max(Me.ThumbMovement, Me._Minimum), Me.Maximum)
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.Refresh()
            Me.InvalidatePosition()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            If (Me.Thumb.Contains(e.Location)) Then
                Me._ThumbState = MouseState.Over
            ElseIf (Not Me.Thumb.Contains(e.Location)) Then
                Me._ThumbState = MouseState.None
            End If
            If (e.Location.Y < 16 Or e.Location.Y > MyBase.Width - 16) Then
                Me._ThumbState = MouseState.Over
            ElseIf (e.Location.Y >= 16 Or e.Location.Y > MyBase.Width - 16) Then
                Me._ThumbState = MouseState.None
            End If
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Try
                Dim graphics As System.Drawing.Graphics = e.Graphics
                Dim graphic As System.Drawing.Graphics = graphics
                graphic.TextRenderingHint = TextRenderingHint.AntiAlias
                graphic.SmoothingMode = SmoothingMode.HighQuality
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality
                graphic.Clear(Me.nx)
                Dim num As Integer = CInt(Math.Round(CDbl(Me._ThumbSize) / 2))
                Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(-1, MyBase.Height - Me._ThumbSize + num, 20, 20)
                Using solidBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Color.FromArgb(45, 45, 48))
                    graphics.FillRectangle(solidBrush, rectangle)
                End Using
                Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(-1, 0, 20, 20)
                Using solidBrush1 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Color.FromArgb(45, 45, 48))
                    graphics.FillRectangle(solidBrush1, rectangle1)
                End Using
                Select Case Me._ThumbState
                    Case MouseState.None
                        Using solidBrush2 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me._ThumbNormalColour)
                            graphic.FillRectangle(solidBrush2, Me.Thumb)
                        End Using
                        Exit Select
                    Case MouseState.Over
                        Using solidBrush3 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me._ThumbHoverColour)
                            graphic.FillRectangle(solidBrush3, Me.Thumb)
                        End Using
                        Exit Select
                    Case MouseState.Down
                        Using solidBrush4 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me._ThumbPressedColour)
                            graphic.FillRectangle(solidBrush4, Me.Thumb)
                        End Using
                        Exit Select
                End Select
                If (Me.Llen <> -1) Then
                    Dim num1 As Integer = CInt(Math.Round(CDbl(Me._ThumbSize) / 2))
                    Dim num2 As Integer = CInt(Math.Round(CDbl((Me.Llen - Me._Minimum)) / CDbl((Me.Maximum - Me._Minimum)) * CDbl((Me.Shaft.Height - num1))))
                    graphic.DrawLine(New Pen(Me.LenColour, 8.0!), 1, num2 + num1, 5, num2 + num1)
                End If
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic
                graphic = Nothing
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            Me.InvalidateLayout()
        End Sub

        Private Sub SubTimers()
            Dim flag As Boolean = Me.isa >= 18
            If flag Then
                Try
                    Me.Timers.Dispose()
                Catch ex As Exception
                End Try
                Me.isa = 0
            Else
                Me.nx = Color.FromArgb(CInt(Me.BaseColour.R) + Me.isa, CInt(Me.BaseColour.G) + Me.isa, CInt(Me.BaseColour.B) + Me.isa + 4)
                Me.isa += 1
                MyBase.Invalidate()
            End If
        End Sub

        Public Event Scroll As VisualStudioVerticalScrollBar.ScrollEventHandler

        Public Enum __InnerLineCount
            None
            One
            Two
            Three
        End Enum

        Public Delegate Sub ScrollEventHandler(ByVal sender As Object)
    End Class
End Namespace