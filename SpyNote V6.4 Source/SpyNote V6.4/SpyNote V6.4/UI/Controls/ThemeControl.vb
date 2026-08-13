Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SN
	Friend MustInherit Class ThemeControl
		Inherits Control
		Protected G As Graphics

		Protected B As Bitmap

		Protected MouseState As ThemeControl.State

		Private _NoRounding As Boolean

		Private _Image As System.Drawing.Image

		Private _Size As System.Drawing.Size

		Private _Rectangle As Rectangle

		Private _Gradient As LinearGradientBrush

		Private _Brush As SolidBrush

		Public Property Image As System.Drawing.Image
			Get
				Return Me._Image
			End Get
			Set(ByVal value As System.Drawing.Image)
				Me._Image = value
				MyBase.Invalidate()
			End Set
		End Property

		Public ReadOnly Property ImageTop As Integer
			Get
				Dim num As Integer
				num = If(Me._Image IsNot Nothing, MyBase.Height / 2 - Me._Image.Height / 2, 0)
				Return num
			End Get
		End Property

		Public ReadOnly Property ImageWidth As Integer
			Get
				Dim num As Integer
				num = If(Me._Image IsNot Nothing, Me._Image.Width, 0)
				Return num
			End Get
		End Property

		Public Property NoRounding As Boolean
			Get
				Return Me._NoRounding
			End Get
			Set(ByVal value As Boolean)
				Me._NoRounding = value
				MyBase.Invalidate()
			End Set
		End Property

		Public Overrides Property Text As String
			Get
				Return MyBase.Text
			End Get
			Set(ByVal value As String)
				MyBase.Text = value
				MyBase.Invalidate()
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.Opaque Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.B = New Bitmap(1, 1)
			Me.G = Graphics.FromImage(Me.B)
		End Sub

		Public Sub AllowTransparent()
			MyBase.SetStyle(ControlStyles.Opaque, False)
			MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
		End Sub

		Private Sub ChangeMouseState(ByVal e As ThemeControl.State)
			Me.MouseState = e
			MyBase.Invalidate()
		End Sub

		Protected Sub DrawBorders(ByVal p1 As Pen, ByVal p2 As Pen, ByVal rect As Rectangle)
			Me.G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1)
			Me.G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3)
		End Sub

		Protected Sub DrawCorners(ByVal c As Color, ByVal rect As Rectangle)
			If (Not Me._NoRounding) Then
				Me.B.SetPixel(rect.X, rect.Y, c)
				Me.B.SetPixel(rect.X + (rect.Width - 1), rect.Y, c)
				Me.B.SetPixel(rect.X, rect.Y + (rect.Height - 1), c)
				Me.B.SetPixel(rect.X + (rect.Width - 1), rect.Y + (rect.Height - 1), c)
			End If
		End Sub

		Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
			Me._Rectangle = New Rectangle(x, y, width, height)
			Me._Gradient = New LinearGradientBrush(Me._Rectangle, c1, c2, angle)
			Me.G.FillRectangle(Me._Gradient, Me._Rectangle)
		End Sub

		Protected Sub DrawIcon(ByVal a As HorizontalAlignment, ByVal x As Integer)
			Me.DrawIcon(a, x, 0)
		End Sub

		Protected Sub DrawIcon(ByVal a As HorizontalAlignment, ByVal x As Integer, ByVal y As Integer)
			If (Me._Image IsNot Nothing) Then
				Select Case a
					Case HorizontalAlignment.Left
                        '	Me.G.DrawImage(Me._Image, x, MyBase.Height / 2 - Me._Image.Height / 2 + y)
                        Exit Select
					Case HorizontalAlignment.Right
                        '	Me.G.DrawImage(Me._Image, MyBase.Width - Me._Image.Width - x, MyBase.Height / 2 - Me._Image.Height / 2 + y)
                        Exit Select
					Case HorizontalAlignment.Center
                        '	Me.G.DrawImage(Me._Image, MyBase.Width / 2 - Me._Image.Width / 2, MyBase.Height / 2 - Me._Image.Height / 2)
                        Exit Select
				End Select
			End If
		End Sub

		Protected Sub DrawText(ByVal a As HorizontalAlignment, ByVal c As Color, ByVal x As Integer)
			Me.DrawText(a, c, x, 0)
		End Sub

		Protected Sub DrawText(ByVal a As HorizontalAlignment, ByVal c As Color, ByVal x As Integer, ByVal y As Integer)
			If (Not String.IsNullOrEmpty(Me.Text)) Then
				Dim sizeF As System.Drawing.SizeF = Me.G.MeasureString(Me.Text, Me.Font)
				Me._Size = sizeF.ToSize()
				Me._Brush = New SolidBrush(c)
				Select Case a
					Case HorizontalAlignment.Left
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng(x), CSng((MyBase.Height / 2 - Me._Size.Height / 2 + y)))
						Exit Select
					Case HorizontalAlignment.Right
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng((MyBase.Width - Me._Size.Width - x)), CSng((MyBase.Height / 2 - Me._Size.Height / 2 + y)))
						Exit Select
					Case HorizontalAlignment.Center
						Me.G.DrawString(Me.Text, Me.Font, Me._Brush, CSng((MyBase.Width / 2 - Me._Size.Width / 2 + x)), CSng((MyBase.Height / 2 - Me._Size.Height / 2 + y)))
						Exit Select
				End Select
			End If
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
				Me.ChangeMouseState(ThemeControl.State.MouseDown)
			End If
			MyBase.OnMouseDown(e)
		End Sub

		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			Me.ChangeMouseState(ThemeControl.State.MouseOver)
			MyBase.OnMouseEnter(e)
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			Me.ChangeMouseState(ThemeControl.State.MouseNone)
			MyBase.OnMouseLeave(e)
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			Me.ChangeMouseState(ThemeControl.State.MouseOver)
			MyBase.OnMouseUp(e)
		End Sub

		Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			If (If(MyBase.Width = 0, False, MyBase.Height <> 0)) Then
				Me.PaintHook()
				e.Graphics.DrawImage(Me.B, 0, 0)
			End If
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			If (If(MyBase.Width = 0, False, MyBase.Height <> 0)) Then
				Me.B = New Bitmap(MyBase.Width, MyBase.Height)
				Me.G = Graphics.FromImage(Me.B)
				MyBase.Invalidate()
			End If
			MyBase.OnSizeChanged(e)
		End Sub

		Public MustOverride Sub PaintHook()

		Protected Enum State As Byte
			MouseNone
			MouseOver
			MouseDown
		End Enum
	End Class
End Namespace