Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace spy673
    Friend MustInherit Class ThemeContainer546546
        Inherits ContainerControl

        Private Sub DoAnimation(i As Boolean)
            Me.OnAnimation()
            If i Then
                MyBase.Invalidate()
            End If
        End Sub

        Protected MustOverride Sub ColorHook()

        Protected MustOverride Sub PaintHook()

        Protected Overridable Sub OnCreation()
        End Sub

        Protected Overridable Sub OnAnimation()
        End Sub

        Protected Function Offset(r As Rectangle, amount As Integer) As Rectangle
            Me.OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - amount * 2, r.Height - amount * 2)
            Return Me.OffsetReturnRectangle
        End Function

        Protected Function Offset(s As Size, amount As Integer) As Size
            Me.OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
            Return Me.OffsetReturnSize
        End Function

        Protected Function Offset(p As Point, amount As Integer) As Point
            Me.OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
            Return Me.OffsetReturnPoint
        End Function

        Protected Function Center(p As Rectangle, c As Rectangle) As Point
            Me.CenterReturn = New Point(p.Width / 2 - c.Width / 2 + p.X + c.X, p.Height / 2 - c.Height / 2 + p.Y + c.Y)
            Return Me.CenterReturn
        End Function

        Protected Function Center(p As Rectangle, c As Size) As Point
            Me.CenterReturn = New Point(p.Width / 2 - c.Width / 2 + p.X, p.Height / 2 - c.Height / 2 + p.Y)
            Return Me.CenterReturn
        End Function

        Protected Function Center(child As Rectangle) As Point
            Return Me.Center(MyBase.Width, MyBase.Height, child.Width, child.Height)
        End Function

        Protected Function Center(child As Size) As Point
            Return Me.Center(MyBase.Width, MyBase.Height, child.Width, child.Height)
        End Function

        Protected Function Center(childWidth As Integer, childHeight As Integer) As Point
            Return Me.Center(MyBase.Width, MyBase.Height, childWidth, childHeight)
        End Function

        Protected Function Center(p As Size, c As Size) As Point
            Return Me.Center(p.Width, p.Height, c.Width, c.Height)
        End Function

        Protected Function Center(pWidth As Integer, pHeight As Integer, cWidth As Integer, cHeight As Integer) As Point
            Me.CenterReturn = New Point(pWidth / 2 - cWidth / 2, pHeight / 2 - cHeight / 2)
            Return Me.CenterReturn
        End Function

        Protected Function Measure() As Size
            Dim measureGraphics As Object = Me.MeasureGraphics
            Dim result As Size
            SyncLock measureGraphics
                result = Me.MeasureGraphics.MeasureString(Me.Text, Me.Font, MyBase.Width).ToSize()
            End SyncLock
            Return result
        End Function

        Protected Function Measure(text As String) As Size
            Dim measureGraphics As Object = Me.MeasureGraphics
            Dim result As Size
            SyncLock measureGraphics
                result = Me.MeasureGraphics.MeasureString(text, Me.Font, MyBase.Width).ToSize()
            End SyncLock
            Return result
        End Function

        Public Function CreateRound(x As Integer, y As Integer, width As Integer, height As Integer, slope As Integer) As GraphicsPath
            Me.CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return Me.CreateRound(Me.CreateRoundRectangle, slope)
        End Function

        Public Function CreateRound(r As Rectangle, slope As Integer) As GraphicsPath
            Me.CreateRoundPath = New GraphicsPath(FillMode.Winding)
            Me.CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            Me.CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            Me.CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0F, 90.0F)
            Me.CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            Me.CreateRoundPath.CloseFigure()
            Return Me.CreateRoundPath
        End Function

        Private OffsetReturnRectangle As Rectangle

        Private OffsetReturnSize As Size

        Private OffsetReturnPoint As Point

        Private CenterReturn As Point

        Private MeasureBitmap As Bitmap

        Private MeasureGraphics As Graphics

        Private CreateRoundPath As GraphicsPath

        Private CreateRoundRectangle As Rectangle
    End Class
End Namespace
