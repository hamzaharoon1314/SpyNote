Imports System.Drawing.Drawing2D

Namespace SN
	Friend Module DrewTabControl
		Public Function RoundRect(ByVal rectangle As System.Drawing.Rectangle, ByVal curve As Integer) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim num As Integer = curve * 2
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.X, rectangle.Y, num, num), -180!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -1!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0!, 90!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90!, 90!)
			graphicsPath.AddLine(New Point(rectangle.X, rectangle.Height - num + rectangle.Y), New Point(rectangle.X, curve + rectangle.Y))
			Return graphicsPath
		End Function
	End Module
End Namespace