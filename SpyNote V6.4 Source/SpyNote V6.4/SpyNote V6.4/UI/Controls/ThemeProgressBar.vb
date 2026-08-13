Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SN
	Friend Class ThemeProgressBar
		Inherits ThemeControl0
		Private G1 As Color

		Private G2 As Color

		Private Glow As Color

		Private Edge As Color

		Private GlowPosition As Integer

		Private _Minimum As Integer

		Private _Maximum As Integer

		Private _Value As Integer

		Private _Color0 As Color

		Private _Color1 As Color

		Public Property Animated As Boolean
			Get
				Return MyBase.IsAnimated
			End Get
			Set(ByVal value As Boolean)
				MyBase.IsAnimated = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property Colour0 As Color
			Get
				Return Me._Color0
			End Get
			Set(ByVal value As Color)
				Me._Color0 = value
			End Set
		End Property

		<Category("Colours")>
		Public Property Colour1 As Color
			Get
				Return Me._Color1
			End Get
			Set(ByVal value As Color)
				Me._Color1 = value
			End Set
		End Property

		Public Property Maximum As Integer
			Get
				Return Me._Maximum
			End Get
			Set(ByVal value As Integer)
				If (value < 0) Then
				End If
				Me._Maximum = value
				If (value < Me._Value) Then
					Me._Value = value
				End If
				If (value < Me._Minimum) Then
					Me._Minimum = value
				End If
				MyBase.Invalidate()
			End Set
		End Property

		Public Property Minimum As Integer
			Get
				Return Me._Minimum
			End Get
			Set(ByVal value As Integer)
				If (value < 0) Then
				End If
				Me._Minimum = value
				If (value > Me._Value) Then
					Me._Value = value
				End If
				If (value > Me._Maximum) Then
					Me._Maximum = value
				End If
				MyBase.Invalidate()
			End Set
		End Property

		Public Property Value As Integer
			Get
				Return Me._Value
			End Get
			Set(ByVal value As Integer)
				If (If(value > Me._Maximum, True, value < Me._Minimum)) Then
				End If
				Me._Value = value
				MyBase.Invalidate()
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me._Maximum = 100
			Me._Color0 = Color.FromArgb(0, 0, 0)
			Me._Color1 = Color.FromArgb(0, 0, 0)
			MyBase.SetColor("Gradient 1", 230, 230, 230)
			MyBase.SetColor("Gradient 2", 230, 230, 230)
			MyBase.SetColor("Glow", 230, 230, 230)
			MyBase.SetColor("Edge", 122, 122, 124)
			MyBase.IsAnimated = True
		End Sub

		Protected Overrides Sub ColorHook()
			Me.G1 = MyBase.GetColor("Gradient 1")
			Me.G2 = MyBase.GetColor("Gradient 2")
			Me.Glow = MyBase.GetColor("Glow")
			Me.Edge = MyBase.GetColor("Edge")
		End Sub

		Private Sub Increment(ByVal amount As Integer)
			Me.Value = Me.Value + amount
		End Sub

        Protected Overrides Sub OnAnimation()
            Dim flag As Boolean = Me.GlowPosition <= 0
            If flag Then
                Me.GlowPosition = 7
            Else
                Me.GlowPosition -= 1
            End If
        End Sub

        Protected Overrides Sub PaintHook()
			Me.G.Clear(Me.G1)
			Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(New System.Drawing.Rectangle(New Point(1, 1), New System.Drawing.Size(MyBase.Width - 2, MyBase.Height - 2)), Me.G1, Me.G2, 90!)
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1)), MyBase.Height - 2)
			Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1)), CInt(Math.Round(CDbl(MyBase.Height) / 2 - 3)))
			Dim rectangle2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, MyBase.Width - 2, MyBase.Height - 2)
			Dim hatchBrush As System.Drawing.Drawing2D.HatchBrush = New System.Drawing.Drawing2D.HatchBrush(HatchStyle.WideUpwardDiagonal, Me.Colour0, Me.Colour1)
			Dim rectangle3 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 2, CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1)), MyBase.Height - 3)
			Me.G.FillRectangle(linearGradientBrush, rectangle)
			Me.G.FillRectangle(New SolidBrush(Me.Glow), rectangle1)
			Me.G.RenderingOrigin = New Point(Me.GlowPosition, 0)
			Me.G.FillRectangle(hatchBrush, rectangle3)
			Me.G.DrawLine(New Pen(Me.Edge), New Point(CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1)), 1), New Point(CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1)), MyBase.Height - 1))
			Me.G.DrawRectangle(New Pen(Me.Edge), rectangle2)
		End Sub
	End Class
End Namespace