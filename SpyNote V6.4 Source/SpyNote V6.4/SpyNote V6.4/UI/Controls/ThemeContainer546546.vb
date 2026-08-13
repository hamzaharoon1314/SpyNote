Imports System.Drawing.Drawing2D

Namespace SN
	Friend MustInherit Class ThemeContainer546546
		Inherits ContainerControl
		Private OffsetReturnRectangle As Rectangle

		Private OffsetReturnSize As System.Drawing.Size

		Private OffsetReturnPoint As Point

		Private CenterReturn As Point

		Private MeasureBitmap As Bitmap

		Private MeasureGraphics As Graphics

		Private CreateRoundPath As GraphicsPath

		Private CreateRoundRectangle As Rectangle

        Protected Function Center(ByVal p As Rectangle, ByVal c As Rectangle) As Point
            Me.CenterReturn = New Point(p.Width / 2 - c.Width / 2 + p.X + c.X, p.Height / 2 - c.Height / 2 + p.Y + c.Y)
            Return Me.CenterReturn
        End Function

        Protected Function Center(ByVal p As Rectangle, ByVal c As System.Drawing.Size) As Point
			Me.CenterReturn = New Point(p.Width / 2 - c.Width / 2 + p.X, p.Height / 2 - c.Height / 2 + p.Y)
			Return Me.CenterReturn
		End Function

		Protected Function Center(ByVal child As Rectangle) As System.Drawing.Point
			Dim point As System.Drawing.Point = Me.Center(MyBase.Width, MyBase.Height, child.Width, child.Height)
			Return point
		End Function

		Protected Function Center(ByVal child As System.Drawing.Size) As System.Drawing.Point
			Dim point As System.Drawing.Point = Me.Center(MyBase.Width, MyBase.Height, child.Width, child.Height)
			Return point
		End Function

		Protected Function Center(ByVal childWidth As Integer, ByVal childHeight As Integer) As System.Drawing.Point
			Dim point As System.Drawing.Point = Me.Center(MyBase.Width, MyBase.Height, childWidth, childHeight)
			Return point
		End Function

		Protected Function Center(ByVal p As System.Drawing.Size, ByVal c As System.Drawing.Size) As System.Drawing.Point
			Dim point As System.Drawing.Point = Me.Center(p.Width, p.Height, c.Width, c.Height)
			Return point
		End Function

		Protected Function Center(ByVal pWidth As Integer, ByVal pHeight As Integer, ByVal cWidth As Integer, ByVal cHeight As Integer) As Point
			Me.CenterReturn = New Point(pWidth / 2 - cWidth / 2, pHeight / 2 - cHeight / 2)
			Return Me.CenterReturn
		End Function

		Protected MustOverride Sub ColorHook()

		Public Function CreateRound(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal slope As Integer) As GraphicsPath
			Me.CreateRoundRectangle = New Rectangle(x, y, width, height)
			Return Me.CreateRound(Me.CreateRoundRectangle, slope)
		End Function

		Public Function CreateRound(ByVal r As Rectangle, ByVal slope As Integer) As GraphicsPath
			Me.CreateRoundPath = New GraphicsPath(FillMode.Winding)
			Me.CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180!, 90!)
			Me.CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270!, 90!)
			Me.CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0!, 90!)
			Me.CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90!, 90!)
			Me.CreateRoundPath.CloseFigure()
			Return Me.CreateRoundPath
		End Function

		Private Sub DoAnimation(ByVal i As Boolean)
			Me.OnAnimation()
			If (i) Then
				MyBase.Invalidate()
			End If
		End Sub

		Protected Function Measure() As System.Drawing.Size
			Dim size As System.Drawing.Size
			SyncLock Me.MeasureGraphics
				Dim sizeF As System.Drawing.SizeF = Me.MeasureGraphics.MeasureString(Me.Text, Me.Font, MyBase.Width)
				size = sizeF.ToSize()
			End SyncLock
			Return size
		End Function

		Protected Function Measure(ByVal text As String) As System.Drawing.Size
			Dim size As System.Drawing.Size
			SyncLock Me.MeasureGraphics
				Dim sizeF As System.Drawing.SizeF = Me.MeasureGraphics.MeasureString(text, Me.Font, MyBase.Width)
				size = sizeF.ToSize()
			End SyncLock
			Return size
		End Function

		Protected Function Offset(ByVal r As Rectangle, ByVal amount As Integer) As Rectangle
			Me.OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - amount * 2, r.Height - amount * 2)
			Return Me.OffsetReturnRectangle
		End Function

		Protected Function Offset(ByVal s As System.Drawing.Size, ByVal amount As Integer) As System.Drawing.Size
			Me.OffsetReturnSize = New System.Drawing.Size(s.Width + amount, s.Height + amount)
			Return Me.OffsetReturnSize
		End Function

		Protected Function Offset(ByVal p As Point, ByVal amount As Integer) As Point
			Me.OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
			Return Me.OffsetReturnPoint
		End Function

		Protected Overridable Sub OnAnimation()
		End Sub

		Protected Overridable Sub OnCreation()
		End Sub

		Protected MustOverride Sub PaintHook()
	End Class
End Namespace