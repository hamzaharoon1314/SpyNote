Imports System.Drawing.Drawing2D

Namespace SN
	Friend Module Draw
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
	End Module
End Namespace