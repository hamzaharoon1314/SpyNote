Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SN
	Friend Class ThemeCoBox
		Inherits PictureBox
		Public ThemeButtonselected_Color As Color

		Public BackClr As Color

		Public BackClrOver As Color

		Public ArrwColorNone As Color

		Public ArrwColorOvr As Color

		Public ArrwBackColorOvr As Color

		Public BordColor As Color

		Public ColorFont As Color

		Public LinColorNone As Color

		Public LinColorOvr As Color

		Public TFint As System.Drawing.Font

		Public FAr As System.Drawing.Font

		Private _TxText As String

		Private Stated As ThemeCoBox.MouseState

		<Category("Colours")>
		Public Property MlinColorovr As Color
			Get
				Return Me.LinColorOvr
			End Get
			Set(ByVal value As Color)
				Me.LinColorOvr = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MyArrwBackColorOvr As Color
			Get
				Return Me.ArrwBackColorOvr
			End Get
			Set(ByVal value As Color)
				Me.ArrwBackColorOvr = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MyArrwColorNone As Color
			Get
				Return Me.ArrwColorNone
			End Get
			Set(ByVal value As Color)
				Me.ArrwColorNone = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MyArrwColorOvr As Color
			Get
				Return Me.ArrwColorOvr
			End Get
			Set(ByVal value As Color)
				Me.ArrwColorOvr = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MyBackColorNone As Color
			Get
				Return Me.BackClr
			End Get
			Set(ByVal value As Color)
				Me.BackClr = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MyBackColorOver As Color
			Get
				Return Me.BackClrOver
			End Get
			Set(ByVal value As Color)
				Me.BackClrOver = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MyBordColor As Color
			Get
				Return Me.BordColor
			End Get
			Set(ByVal value As Color)
				Me.BordColor = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MyFontColor As Color
			Get
				Return Me.ColorFont
			End Get
			Set(ByVal value As Color)
				Me.ColorFont = value
				MyBase.Invalidate()
			End Set
		End Property

		<Category("Colours")>
		Public Property MylinColorNone As Color
			Get
				Return Me.LinColorNone
			End Get
			Set(ByVal value As Color)
				Me.LinColorNone = value
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
			Me.ThemeButtonselected_Color = Color.FromArgb(0, 118, 177)
			Me.BackClr = Color.FromArgb(51, 51, 55)
			Me.BackClrOver = Color.FromArgb(63, 63, 70)
			Me.ArrwColorNone = Color.FromArgb(153, 153, 153)
			Me.ArrwColorOvr = Color.FromArgb(0, 113, 171)
			Me.ArrwBackColorOvr = Color.FromArgb(0, 0, 0)
			Me.BordColor = Color.FromArgb(67, 67, 70)
			Me.ColorFont = Color.FromArgb(241, 241, 241)
			Me.LinColorNone = Color.FromArgb(153, 153, 153)
			Me.LinColorOvr = Color.FromArgb(0, 113, 171)
			Me.TFint = New System.Drawing.Font("Segoe UI Semibold", 9!, FontStyle.Regular)
			Me.FAr = New System.Drawing.Font("Marlett", 8.25!, FontStyle.Regular)
			Me._TxText = Nothing
			Me.Stated = ThemeCoBox.MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.Font = Me.TFint
			Me.BackColor = Color.Transparent
			MyBase.Size = New System.Drawing.Size(MyBase.Size.Width, 20)
		End Sub

		Protected Overrides Sub CreateHandle()
			MyBase.CreateHandle()
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			Me.Stated = ThemeCoBox.MouseState.Over
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			MyBase.OnMouseEnter(e)
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			Me.Stated = ThemeCoBox.MouseState.None
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			Me.Stated = ThemeCoBox.MouseState.Over
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			Me.Stated = ThemeCoBox.MouseState.None
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			Dim graphics As System.Drawing.Graphics = e.Graphics
			graphics.Clear(Color.Transparent)
			graphics.SmoothingMode = SmoothingMode.AntiAlias
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(-1, -1, MyBase.Width + 1, MyBase.Height + 1)
			Dim stated As ThemeCoBox.MouseState = Me.Stated
			If (stated = ThemeCoBox.MouseState.None) Then
				graphics.FillRectangle(New System.Drawing.SolidBrush(Me.MyBackColorNone), rectangle)
				Me.OnTexy(graphics, MyBase.Width)
				Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(MyBase.Width - 17, 1, 15, MyBase.Height - 2)
				Using solidBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me.MyArrwBackColorOvr)
					graphics.FillRectangle(solidBrush, rectangle1)
				End Using
				graphics.DrawString("u", Me.FAr, New System.Drawing.SolidBrush(Me.MyArrwColorNone), New Point(MyBase.Width - 16, CInt(Math.Round(CDbl(MyBase.Height) / 2 - 5))))
				graphics.DrawLine(New Pen(Me.MylinColorNone, 1!), New Point(MyBase.Width - 17, 1), New Point(MyBase.Width - 17, MyBase.Height - 2))
			ElseIf (stated = ThemeCoBox.MouseState.Over) Then
				graphics.FillRectangle(New System.Drawing.SolidBrush(Me.MyBackColorOver), rectangle)
				Me.OnTexy(graphics, MyBase.Width)
				Dim rectangle2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(MyBase.Width - 17, 1, 15, MyBase.Height - 2)
				Using solidBrush1 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me.MyArrwBackColorOvr)
					graphics.FillRectangle(solidBrush1, rectangle2)
				End Using
				graphics.DrawString("u", Me.FAr, New System.Drawing.SolidBrush(Me.MyArrwColorOvr), New Point(MyBase.Width - 16, CInt(Math.Round(CDbl(MyBase.Height) / 2 - 5))))
				graphics.DrawLine(New Pen(Me.MlinColorovr, 1!), New Point(MyBase.Width - 17, 1), New Point(MyBase.Width - 17, MyBase.Height - 2))
			End If
			graphics.DrawRectangle(New Pen(Me.MyBordColor, 3!), rectangle)
		End Sub

		Private Sub OnTexy(ByVal G As Graphics, ByVal w As Integer)
			Try
				If (Me._TxText.Length > 0) Then
					Dim str As String = Me._TxText
					Dim length As Integer = Me._TxText.Length - 1
					Dim num As Integer = 0
					While num <= length
						If (TextRenderer.MeasureText(str, Me.Font).Width < w - 17) Then
							Exit While
						Else
							str = String.Concat(str.Substring(0, Me._TxText.Length - num), "...")
							num = num + 1
						End If
					End While
					Dim num1 As Integer = 1
					Dim height As Double = CDbl((MyBase.Height - 5)) / 2
					Dim sizeF As System.Drawing.SizeF = G.MeasureString(Me._TxText, Me.Font)
					Dim num2 As Integer = CInt(Math.Round(height - CDbl((sizeF.Height / 2!)) + 2))
					G.DrawString(str, Me.Font, New SolidBrush(Me.MyFontColor), New Point(num1, num2))
				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Public Enum MouseState As Byte
			None
			Over
			Down
		End Enum
	End Class
End Namespace