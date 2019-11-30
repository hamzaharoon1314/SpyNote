Imports System.Drawing.Drawing2D

Namespace SN
	Friend Module RoundRectangle
		Public Function RoundedTopRect(ByVal Rectangle As System.Drawing.Rectangle, ByVal Curve As Integer) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim num As Integer = Curve * 2
			graphicsPath.AddArc(New System.Drawing.Rectangle(Rectangle.X, Rectangle.Y, num, num), -180!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num), -90!, 90!)
			graphicsPath.AddLine(New Point(Rectangle.X + Rectangle.Width, Rectangle.Y + num), New Point(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height - 1))
			graphicsPath.AddLine(New Point(Rectangle.X, Rectangle.Height - 1 + Rectangle.Y), New Point(Rectangle.X, Rectangle.Y + Curve))
			Return graphicsPath
		End Function

		Public Function RoundRect(ByVal Rectangle As System.Drawing.Rectangle, ByVal Curve As Integer) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim num As Integer = Curve * 2
			graphicsPath.AddArc(New System.Drawing.Rectangle(Rectangle.X, Rectangle.Y, num, num), -180!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num), -90!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 0!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 90!, 90!)
			graphicsPath.AddLine(New Point(Rectangle.X, Rectangle.Height - num + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
			Return graphicsPath
		End Function

		Public Function RoundRect(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer, ByVal Curve As Integer) As System.Drawing.Drawing2D.GraphicsPath
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(X, Y, Width, Height)
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim num As Integer = Curve * 2
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.X, rectangle.Y, num, num), -180!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -90!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90!, 90!)
			graphicsPath.AddLine(New Point(rectangle.X, rectangle.Height - num + rectangle.Y), New Point(rectangle.X, Curve + rectangle.Y))
			Return graphicsPath
		End Function
	End Module
End Namespace