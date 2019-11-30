Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SN
	Friend Class ThemeTit
		Inherits PictureBox
		Public _BackColorNone As Color

		Public _FontColorNone As Color

		Public TFint As System.Drawing.Font

		Private _TxText As String

		Private Stated As ThemeTit.MouseState

		<Category("Colours")>
		Public Property BackColorNone As Color
			Get
				Return Me._BackColorNone
			End Get
			Set(ByVal value As Color)
				Me._BackColorNone = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property FontColorNone As Color
			Get
				Return Me._FontColorNone
			End Get
			Set(ByVal value As Color)
				Me._FontColorNone = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Control")>
		Public Property TxText As String
			Get
				Return Me._TxText
			End Get
			Set(ByVal value As String)
				Me._TxText = value
				MyBase.Invalidate()
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me._BackColorNone = Color.FromArgb(0, 122, 204)
			Me._FontColorNone = Color.FromArgb(241, 241, 241)
			Me.TFint = New System.Drawing.Font("Segoe UI Semibold", 9!, FontStyle.Regular)
			Me._TxText = Nothing
			Me.Stated = ThemeTit.MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.Font = Me.TFint
			Me.BackColor = Color.Transparent
			MyBase.Size = New System.Drawing.Size(MyBase.Size.Width, 17)
		End Sub

		Protected Overrides Sub CreateHandle()
			MyBase.CreateHandle()
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			Me.Stated = ThemeTit.MouseState.None
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			Me.Stated = ThemeTit.MouseState.None
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			Dim graphics As System.Drawing.Graphics = e.Graphics
			graphics.Clear(Color.Transparent)
			graphics.SmoothingMode = SmoothingMode.AntiAlias
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(-1, -1, MyBase.Width + 1, MyBase.Height + 1)
			If (Me.Stated = ThemeTit.MouseState.None) Then
				graphics.FillRectangle(New SolidBrush(Me.BackColorNone), rectangle)
				Dim txText As String = Me.TxText
				Dim size As System.Drawing.Size = TextRenderer.MeasureText(txText, Me.TFint)
				Dim hatchBrush As System.Drawing.Drawing2D.HatchBrush = New System.Drawing.Drawing2D.HatchBrush(HatchStyle.Percent20, Color.FromArgb(113, 113, 120), Me.BackColorNone)
				Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(size.Width + 2, 5, MyBase.Width, MyBase.Height - 15)
				graphics.FillRectangle(hatchBrush, rectangle1)
				graphics.DrawString(txText, Me.TFint, New SolidBrush(Me.FontColorNone), New Point(0, -2))
			End If
		End Sub

		Public Enum MouseState As Byte
			None
			Over
			Down
		End Enum
	End Class
End Namespace