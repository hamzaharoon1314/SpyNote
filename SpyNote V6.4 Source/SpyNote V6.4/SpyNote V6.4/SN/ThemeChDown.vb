Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SN
	Friend Class ThemeChDown
		Inherits PictureBox
		Private _Image As System.Drawing.Image

		Private fnt As System.Drawing.Font

		Private _Count As Integer

		Private Stated As ThemeChDown.MouseState

		<Category("Control")>
		Public Property _Countt As Integer
			Get
				Return Me._Count
			End Get
			Set(ByVal value As Integer)
				Me._Count = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Control")>
		Public Property ImageChoice As System.Drawing.Image
			Get
				Return Me._Image
			End Get
			Set(ByVal value As System.Drawing.Image)
				Me._Image = value
				MyBase.Invalidate()
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me._Image = Nothing
			Me.fnt = New System.Drawing.Font("Arial", 7!, FontStyle.Bold)
			Me.Stated = ThemeChDown.MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.Font = Me.fnt
			MyBase.Size = New System.Drawing.Size(45, 45)
		End Sub

		Protected Overrides Sub CreateHandle()
			MyBase.CreateHandle()
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			Me.Stated = ThemeChDown.MouseState.Over
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			MyBase.OnMouseEnter(e)
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			Me.Stated = ThemeChDown.MouseState.None
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			Me.Stated = ThemeChDown.MouseState.Over
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			Me.Stated = ThemeChDown.MouseState.None
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			Dim graphics As System.Drawing.Graphics = e.Graphics
			graphics.SmoothingMode = SmoothingMode.AntiAlias
			Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(80, 80, 80)
			Select Case Me.Stated
				Case ThemeChDown.MouseState.None
					color = System.Drawing.Color.FromArgb(67, 67, 74)
					Exit Select
				Case ThemeChDown.MouseState.Over
					color = System.Drawing.Color.FromArgb(77, 77, 84)
					Exit Select
				Case ThemeChDown.MouseState.Down
					color = System.Drawing.Color.FromArgb(50, 50, 64)
					Exit Select
			End Select
			Dim white As Brush = Brushes.White
			Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(35, 35)
			graphics.FillEllipse(New SolidBrush(color), 10, 10, bitmap.Width - 6, bitmap.Height - 6)
			If (Me._Image IsNot Nothing) Then
				graphics.DrawImage(Me._Image, New Rectangle(13, 13, Me._Image.Width, Me._Image.Height))
			End If
			Dim pen As System.Drawing.Pen = New System.Drawing.Pen(System.Drawing.Color.FromArgb(200, 63, 63, 70), 2!)
			graphics.DrawEllipse(pen, 10, 10, bitmap.Width - 6, bitmap.Height - 6)
			color = System.Drawing.Color.FromArgb(63, 63, 70)
			graphics.FillEllipse(New SolidBrush(color), 5, 5, 15, 15)
			If (Conversions.ToString(Me._Countt).Length = 1) Then
				graphics.DrawString(Conversions.ToString(Me._Countt), Me.fnt, white, 8!, 7!)
			ElseIf (Conversions.ToString(Me._Countt).Length = 2) Then
				graphics.DrawString(Conversions.ToString(Me._Countt), Me.fnt, white, 5!, 7!)
			ElseIf (Me._Countt > 99) Then
				graphics.DrawString(String.Concat(Conversions.ToString(99), " +"), Me.fnt, white, 5!, 7!)
			End If
		End Sub

		Public Enum MouseState As Byte
			None
			Over
			Down
		End Enum
	End Class
End Namespace