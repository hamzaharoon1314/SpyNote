Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SN
	<DefaultEvent("TextChanged")>
	Friend Class ThemeTextBox
		Inherits Control
		Public ThemeTextBoxFont As System.Drawing.Font

		Private _maxchars As Integer

		Private _ReadOnly As Boolean

		Private _Multiline As Boolean

		Private ALNType As HorizontalAlignment

		Private isPasswordMasked As Boolean

		Private isLave As Boolean

		Private isShow As Boolean

		Private _CBorderEnabled0 As Color

		Private _CBorderEnabled1 As Color

		Private _CBorderLave0 As Color

		Private _CBorderLave1 As Color

		Private _CBorderEnter0 As Color

		Private _CBorderEnter1 As Color

		Private _BACKCOLOR As Color

		Private _CLRXX As Color

		Private _CLRXXLave As Color

		Private entr As Boolean

		<Category("Colours")>
		Public Property __CLRXX_S As Color
			Get
				Return Me._CLRXX
			End Get
			Set(ByVal value As Color)
				Me._CLRXX = value
			End Set
		End Property

		<Category("Colours")>
		Public Property __CLRXX_SLave As Color
			Get
				Return Me._CLRXXLave
			End Get
			Set(ByVal value As Color)
				Me._CLRXXLave = value
			End Set
		End Property

		<Category("Colours")>
		Public Property _CBorderEnabled0_S As Color
			Get
				Return Me._CBorderEnabled0
			End Get
			Set(ByVal value As Color)
				Me._CBorderEnabled0 = value
			End Set
		End Property

		<Category("Colours")>
		Public Property _CBorderEnabled1_S As Color
			Get
				Return Me._CBorderEnabled1
			End Get
			Set(ByVal value As Color)
				Me._CBorderEnabled1 = value
			End Set
		End Property

		<Category("Colours")>
		Public Property _CBorderEnter0_S As Color
			Get
				Return Me._CBorderEnter0
			End Get
			Set(ByVal value As Color)
				Me._CBorderEnter0 = value
			End Set
		End Property

		<Category("Colours")>
		Public Property _CBorderEnter1_S As Color
			Get
				Return Me._CBorderEnter1
			End Get
			Set(ByVal value As Color)
				Me._CBorderEnter1 = value
			End Set
		End Property

		<Category("Colours")>
		Public Property _CBorderLave0_S As Color
			Get
				Return Me._CBorderLave0
			End Get
			Set(ByVal value As Color)
				Me._CBorderLave0 = value
			End Set
		End Property

		<Category("Colours")>
		Public Property _CBorderLave1_S As Color
			Get
				Return Me._CBorderLave1
			End Get
			Set(ByVal value As Color)
				Me._CBorderLave1 = value
			End Set
		End Property

		<Category("Colours")>
		Public Property _CVK_S As Color
			Get
				Return Me._BACKCOLOR
			End Get
			Set(ByVal value As Color)
				Me._BACKCOLOR = value
			End Set
		End Property

		Public Overridable Property _PictureBox As PictureBox

		Public Property Btnshow As Boolean
			Get
				Return Me.isShow
			End Get
			Set(ByVal value As Boolean)
				Me.isShow = value
			End Set
		End Property
        Public _HTBTB As TextBox
        Public Overridable Property HTBTB As TextBox
            <CompilerGenerated()>
            Get
                Return Me._HTBTB
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As TextBox)
                Dim value2 As EventHandler = Sub(a0 As Object, a1 As EventArgs)
                                                 Me._TextChanged()
                                             End Sub
                Dim htbtb As TextBox = Me._HTBTB
                If htbtb IsNot Nothing Then
                    RemoveHandler htbtb.TextChanged, value2
                End If
                Me._HTBTB = value
                htbtb = Me._HTBTB
                If htbtb IsNot Nothing Then
                    AddHandler htbtb.TextChanged, value2
                End If
            End Set
        End Property

        Public Property MaxLength As Integer
			Get
				Return Me._maxchars
			End Get
			Set(ByVal value As Integer)
				Me._maxchars = value
				Me.HTBTB.MaxLength = Me.MaxLength
				MyBase.Invalidate()
			End Set
		End Property

		Public Property Multiline As Boolean
			Get
				Return Me._Multiline
			End Get
			Set(ByVal value As Boolean)
				Me._Multiline = value
				If (Me.HTBTB IsNot Nothing) Then
					Me.HTBTB.Multiline = value
					If (Not value) Then
						MyBase.Height = Me.HTBTB.Height + 3
					Else
						Me.HTBTB.Height = MyBase.Height - 3
					End If
				End If
			End Set
		End Property

		Public Property [ReadOnly] As Boolean
			Get
				Return Me._ReadOnly
			End Get
			Set(ByVal value As Boolean)
				Me._ReadOnly = value
				If (Me.HTBTB IsNot Nothing) Then
					Me.HTBTB.[ReadOnly] = value
				End If
			End Set
		End Property

		Public Property TextAlignment As HorizontalAlignment
			Get
				Return Me.ALNType
			End Get
			Set(ByVal value As HorizontalAlignment)
				Me.ALNType = value
				MyBase.Invalidate()
			End Set
		End Property

		Public Property UseSystemPasswordChar As Boolean
			Get
				Return Me.isPasswordMasked
			End Get
			Set(ByVal value As Boolean)
				Me.HTBTB.UseSystemPasswordChar = Me.UseSystemPasswordChar
				Me.isPasswordMasked = value
				MyBase.Invalidate()
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			AddHandler MyBase.TextChanged,  New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me._BaseTextChanged())
			Me.ThemeTextBoxFont = New System.Drawing.Font("Arial", 8.25!, FontStyle.Bold)
			Me.HTBTB = New TextBox()
			Me._PictureBox = New PictureBox()
			Me._maxchars = 32767
			Me.isPasswordMasked = False
			Me.isLave = False
			Me.isShow = False
			Me._CBorderEnabled0 = Color.FromArgb(62, 62, 64)
			Me._CBorderEnabled1 = Color.FromArgb(62, 62, 64)
			Me._CBorderLave0 = Color.FromArgb(0, 122, 204)
			Me._CBorderLave1 = Color.FromArgb(0, 122, 204)
			Me._CBorderEnter0 = Color.FromArgb(62, 62, 64)
			Me._CBorderEnter1 = Color.FromArgb(62, 62, 64)
			Me._BACKCOLOR = Color.FromArgb(37, 37, 38)
			Me._CLRXX = Color.FromArgb(100, 100, 100)
			Me._CLRXXLave = Color.FromArgb(50, 50, 50)
			Me.entr = False
			MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			MyBase.SetStyle(ControlStyles.UserPaint, True)
			Me.AddTextBox()
			Me.Add_PictureBox()
			MyBase.Controls.Add(Me.HTBTB)
			MyBase.Controls.Add(Me._PictureBox)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.FromArgb(215, 215, 215)
			Me.Text = Nothing
			Me.Font = Me.ThemeTextBoxFont
			MyBase.Size = New System.Drawing.Size(135, 33)
			Me.DoubleBuffered = True
		End Sub

		Public Sub _BaseTextChanged()
			Me.HTBTB.Text = Me.Text
		End Sub

		Private Sub _Enter(ByVal Obj As Object, ByVal e As EventArgs)
			Me.isLave = True
			Me.Refresh()
		End Sub

		Private Sub _Leave(ByVal Obj As Object, ByVal e As EventArgs)
			Me.isLave = False
			Me.Refresh()
		End Sub

		Private Sub _MouseClick(ByVal Obj As Object, ByVal e As MouseEventArgs)
			Me.HTBTB.Text = ""
		End Sub

		Private Sub _OnKeyDown(ByVal Obj As Object, ByVal e As KeyEventArgs)
			If (If(Not e.Control, False, e.KeyCode = Keys.A)) Then
				Me.HTBTB.SelectAll()
				e.SuppressKeyPress = True
			End If
			If (If(Not e.Control, False, e.KeyCode = Keys.C)) Then
				Me.HTBTB.Copy()
				e.SuppressKeyPress = True
			End If
		End Sub

		Public Sub _TextChanged()
			Me.Text = Me.HTBTB.Text
		End Sub

		Public Sub Add_PictureBox()
			Dim point As PictureBox = Me._PictureBox
			point.Location = New System.Drawing.Point(Me.HTBTB.Width - 20, 2)
			point.BorderStyle = BorderStyle.None
			point.BackColor = Color.Transparent
			point.SizeMode = PictureBoxSizeMode.Normal
			point = Nothing
			AddHandler Me._PictureBox.MouseClick,  New MouseEventHandler(AddressOf Me._MouseClick)
		End Sub

		Public Sub AddTextBox()
			Dim hTBTB As TextBox = Me.HTBTB
			hTBTB.Size = New System.Drawing.Size(MyBase.Width - 1, 33)
			hTBTB.Location = New Point(2, 2)
			hTBTB.Text = String.Empty
			hTBTB.BorderStyle = BorderStyle.None
			hTBTB.BackColor = Me._CVK_S
			hTBTB.TextAlign = HorizontalAlignment.Left
			hTBTB.Font = Me.ThemeTextBoxFont
			hTBTB.UseSystemPasswordChar = Me.UseSystemPasswordChar
			hTBTB.Multiline = False
			hTBTB = Nothing
			AddHandler Me.HTBTB.KeyDown,  New KeyEventHandler(AddressOf Me._OnKeyDown)
			AddHandler Me.HTBTB.Enter,  New EventHandler(AddressOf Me._Enter)
			AddHandler Me.HTBTB.Leave,  New EventHandler(AddressOf Me._Leave)
		End Sub

		Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
			MyBase.OnFontChanged(e)
			Me.HTBTB.Font = Me.Font
		End Sub

		Protected Overrides Sub OnForeColorChanged(ByVal e As EventArgs)
			MyBase.OnForeColorChanged(e)
			Me.HTBTB.ForeColor = Me.ForeColor
			MyBase.Invalidate()
		End Sub

		Protected Overrides Sub OnGotFocus(ByVal e As EventArgs)
			MyBase.OnGotFocus(e)
			Me.HTBTB.Focus()
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			Dim solidBrush As System.Drawing.SolidBrush
			MyBase.OnPaint(e)
			Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(MyBase.Width, MyBase.Height)
			Dim graphic As Graphics = Graphics.FromImage(bitmap)
			graphic.SmoothingMode = SmoothingMode.AntiAlias
			Dim bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap(17, 13)
			Dim graphic1 As Graphics = Graphics.FromImage(bitmap1)
			graphic1.Clear(Me._CVK_S)
			graphic1.SmoothingMode = SmoothingMode.AntiAlias
			Dim font As System.Drawing.Font = New System.Drawing.Font("Consolas", 8.25!, FontStyle.Bold)
			Dim hTBTB As TextBox = Me.HTBTB
			hTBTB.BackColor = Me._CVK_S
			hTBTB.Width = MyBase.Width - If(Me.Btnshow, 20, 3)
			hTBTB.TextAlign = Me.TextAlignment
			hTBTB.UseSystemPasswordChar = Me.UseSystemPasswordChar
			hTBTB = Nothing
			graphic.Clear(Color.Transparent)
			If (Not MyBase.Enabled) Then
				Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me._CBorderEnabled0_S, Me._CBorderEnabled1_S, LinearGradientMode.Horizontal)
				Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, MyBase.Width - 1, MyBase.Height - 1)
				graphic.FillRectangle(linearGradientBrush, rectangle)
				solidBrush = New System.Drawing.SolidBrush(Me.__CLRXX_SLave)
			ElseIf (Not Me.isLave) Then
				Dim linearGradientBrush1 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me._CBorderEnter0_S, Me._CBorderEnter1_S, LinearGradientMode.Horizontal)
				Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, MyBase.Width - 1, MyBase.Height - 1)
				graphic.FillRectangle(linearGradientBrush1, rectangle1)
				solidBrush = New System.Drawing.SolidBrush(Me.__CLRXX_SLave)
			Else
				Dim linearGradientBrush2 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me._CBorderLave0_S, Me._CBorderLave1_S, LinearGradientMode.Horizontal)
				Dim rectangle2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, MyBase.Width - 1, MyBase.Height - 1)
				graphic.FillRectangle(linearGradientBrush2, rectangle2)
				solidBrush = New System.Drawing.SolidBrush(Me.__CLRXX_S)
			End If
			If (Me.Btnshow) Then
				graphic1.DrawString("x", font, solidBrush, 2!, 0!)
				Dim _CVKS As PictureBox = Me._PictureBox
				_CVKS.Image = Nothing
				_CVKS.BackColor = Me._CVK_S
				_CVKS.Location = New Point(MyBase.Width - 18, 2)
				_CVKS.Size = New System.Drawing.Size(17, 13)
				_CVKS.Image = bitmap1
				_CVKS = Nothing
			End If
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphic.Dispose()
			bitmap.Dispose()
		End Sub

		Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
			MyBase.OnPaintBackground(e)
		End Sub

		Protected Overrides Sub OnResize(ByVal e As EventArgs)
			MyBase.OnResize(e)
			If (Not Me._Multiline) Then
				MyBase.Height = Me.HTBTB.Height + 3
			Else
				Me.HTBTB.Height = MyBase.Height - 3
			End If
		End Sub

		Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
			MyBase.OnTextChanged(e)
			MyBase.Invalidate()
		End Sub
	End Class
End Namespace