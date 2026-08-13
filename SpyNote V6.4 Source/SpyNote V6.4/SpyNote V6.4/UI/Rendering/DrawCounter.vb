Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D

Namespace SN
	Friend Module DrawCounter
		Public Function RoundRect(ByVal Rectangle As System.Drawing.Rectangle, ByVal int As Integer, ByVal ar As Array) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim [integer] As Integer = Conversions.ToInteger(NewLateBinding.LateIndexGet(ar, New Object() { 3 }, Nothing))
			graphicsPath.AddArc(New System.Drawing.Rectangle(Conversions.ToInteger(NewLateBinding.LateIndexGet(ar, New Object() { 0 }, Nothing)), Conversions.ToInteger(NewLateBinding.LateIndexGet(ar, New Object() { 1 }, Nothing)), [integer], [integer]), -90!, 0!)
			graphicsPath.AddArc(New System.Drawing.Rectangle(Conversions.ToInteger(NewLateBinding.LateIndexGet(ar, New Object() { 0 }, Nothing)), Conversions.ToInteger(NewLateBinding.LateIndexGet(ar, New Object() { 1 }, Nothing)), [integer], [integer]), 90!, CSng((int * 4)))
			Return graphicsPath
		End Function
	End Module
End Namespace