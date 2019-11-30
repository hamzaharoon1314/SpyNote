Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices

Namespace SN
    Friend MustInherit Class ThemeControl0
        Inherits Control
        Public Sub New()
            Me.Items = New Dictionary(Of String, Color)()
            MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.Opaque Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me._ImageSize = Size.Empty
            Me.Font = New Font("Verdana", 8.0F)
            Me.MeasureBitmap = New Bitmap(1, 1)
            Me.MeasureGraphics = Graphics.FromImage(Me.MeasureBitmap)
            Me.DrawRadialPath = New GraphicsPath()
            Me.InvalidateCustimization()
        End Sub

        Protected Overrides Sub OnHandleCreated(e As EventArgs)
            Me.InvalidateCustimization()
            Me.ColorHook()
            Dim flag As Boolean = Me._LockWidth <> 0
            If flag Then
                MyBase.Width = Me._LockWidth
            End If
            Dim flag2 As Boolean = Me._LockHeight <> 0
            If flag2 Then
                MyBase.Height = Me._LockHeight
            End If
            Me.Transparent = Me._Transparent
            Dim flag3 As Boolean = Me._Transparent AndAlso Me._BackColor
            If flag3 Then
                Me.BackColor = Color.Transparent
            End If
            MyBase.OnHandleCreated(e)
        End Sub

        Protected Overrides Sub OnParentChanged(e As EventArgs)
            Dim flag As Boolean = MyBase.Parent IsNot Nothing
            If flag Then
                Me.OnCreation()
                Me.DoneCreation = True
                Me.InvalidateTimer()
            End If
            MyBase.OnParentChanged(e)
        End Sub

        Private Sub DoAnimation(i As Boolean)
            Me.OnAnimation()
            If i Then
                MyBase.Invalidate()
            End If
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim flag As Boolean = MyBase.Width = 0 OrElse MyBase.Height = 0
            If Not flag Then
                Dim transparent As Boolean = Me._Transparent
                If transparent Then
                    Me.PaintHook()
                    e.Graphics.DrawImage(Me.B, 0, 0)
                Else
                    Me.G = e.Graphics
                    Me.PaintHook()
                End If
            End If
        End Sub

        Protected Overrides Sub OnHandleDestroyed(e As EventArgs)
            ThemeShare46546.RemoveAnimationCallback(AddressOf Me.DoAnimation)
            MyBase.OnHandleDestroyed(e)
        End Sub

        Protected Overrides Sub OnSizeChanged(e As EventArgs)
            Dim transparent As Boolean = Me._Transparent
            If transparent Then
                Me.InvalidateBitmap()
            End If
            MyBase.Invalidate()
            MyBase.OnSizeChanged(e)
        End Sub

        Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
            Dim flag As Boolean = Me._LockWidth <> 0
            If flag Then
                width = Me._LockWidth
            End If
            Dim flag2 As Boolean = Me._LockHeight <> 0
            If flag2 Then
                height = Me._LockHeight
            End If
            MyBase.SetBoundsCore(x, y, width, height, specified)
        End Sub

        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property ForeColor As Color
            Get
                Return Color.Empty
            End Get
            Set(value As Color)
            End Set
        End Property

        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property BackgroundImage As Image
            Get
                Return Nothing
            End Get
            Set(value As Image)
            End Set
        End Property

        <Browsable(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property BackgroundImageLayout As ImageLayout
            Get
                Return ImageLayout.None
            End Get
            Set(value As ImageLayout)
            End Set
        End Property

        Public Overrides Property Text As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                MyBase.Text = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Overrides Property Font As Font
            Get
                Return MyBase.Font
            End Get
            Set(value As Font)
                MyBase.Font = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Misc")>
        Public Overrides Property BackColor As Color
            Get
                Return MyBase.BackColor
            End Get
            Set(value As Color)
                Dim flag As Boolean = Not MyBase.IsHandleCreated AndAlso value = Color.Transparent
                If flag Then
                    Me._BackColor = True
                Else
                    MyBase.BackColor = value
                    Dim flag2 As Boolean = MyBase.Parent IsNot Nothing
                    If flag2 Then
                        Me.ColorHook()
                    End If
                End If
            End Set
        End Property

        Public Property NoRounding As Boolean
            Get
                Return Me._NoRounding
            End Get
            Set(value As Boolean)
                Me._NoRounding = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Image As Image
            Get
                Return Me._Image
            End Get
            Set(value As Image)
                Dim flag As Boolean = value Is Nothing
                If flag Then
                    Me._ImageSize = Size.Empty
                Else
                    Me._ImageSize = value.Size
                End If
                Me._Image = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Transparent As Boolean
            Get
                Return Me._Transparent
            End Get
            Set(value As Boolean)
                Me._Transparent = value
                Dim flag As Boolean = Not MyBase.IsHandleCreated
                If Not flag Then
                    Dim flag2 As Boolean = Not value AndAlso Me.BackColor.A <> Byte.MaxValue
                    If flag2 Then
                        Throw New Exception("Unable to change value to false while a transparent BackColor is in use.")
                    End If
                    MyBase.SetStyle(ControlStyles.Opaque, Not value)
                    MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, value)
                    If value Then
                        Me.InvalidateBitmap()
                    Else
                        Me.B = Nothing
                    End If
                    MyBase.Invalidate()
                End If
            End Set
        End Property

        Public Property Colors As Bloom55546()
            Get
                Dim list As List(Of Bloom55546) = New List(Of Bloom55546)()
                Dim enumerator As Dictionary(Of String, Color).Enumerator = Me.Items.GetEnumerator()
                While enumerator.MoveNext()
                    Dim list2 As List(Of Bloom55546) = list
                    Dim keyValuePair As KeyValuePair(Of String, Color) = enumerator.Current
                    Dim key As String = keyValuePair.Key
                    keyValuePair = enumerator.Current
                    list2.Add(New Bloom55546(key, keyValuePair.Value))
                End While
                Return list.ToArray()
            End Get
            Set(value As Bloom55546())
                Try
                    For i As Integer = 0 To value.Length - 1
                        Dim bloom As Bloom55546 = value(i)
                        Dim flag As Boolean = Me.Items.ContainsKey(bloom.Name)
                        If flag Then
                            Me.Items(bloom.Name) = bloom.Value
                        End If
                    Next
                Catch ex As Exception

                End Try

                Me.InvalidateCustimization()
                Me.ColorHook()
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Customization As String
            Get
                Return Me._Customization
            End Get
            Set(value As String)
                Dim flag As Boolean = Operators.CompareString(value, Me._Customization, False) = 0
                If Not flag Then
                    Dim colors As Bloom55546() = Me.Colors
                    Try
                        Dim value2 As Byte() = Convert.FromBase64String(value)
                        Dim num As Integer = colors.Length - 1
                        For i As Integer = 0 To num
                            colors(i).Value = Color.FromArgb(BitConverter.ToInt32(value2, i * 4))
                        Next
                    Catch ex As Exception
                        Return
                    End Try
                    Me._Customization = value
                    Me.Colors = colors
                    Me.ColorHook()
                    MyBase.Invalidate()
                End If
            End Set
        End Property

        Protected ReadOnly Property ImageSize As Size
            Get
                Return Me._ImageSize
            End Get
        End Property

        Protected Property LockWidth As Integer
            Get
                Return Me._LockWidth
            End Get
            Set(value As Integer)
                Me._LockWidth = value
                Dim flag As Boolean = Me.LockWidth <> 0 AndAlso MyBase.IsHandleCreated
                If flag Then
                    MyBase.Width = Me.LockWidth
                End If
            End Set
        End Property

        Protected Property LockHeight As Integer
            Get
                Return Me._LockHeight
            End Get
            Set(value As Integer)
                Me._LockHeight = value
                Dim flag As Boolean = Me.LockHeight <> 0 AndAlso MyBase.IsHandleCreated
                If flag Then
                    MyBase.Height = Me.LockHeight
                End If
            End Set
        End Property

        Protected Property IsAnimated As Boolean
            Get
                Return Me._IsAnimated
            End Get
            Set(value As Boolean)
                Me._IsAnimated = value
                Me.InvalidateTimer()
            End Set
        End Property

        Protected Function GetPen(name As String) As Pen
            Return New Pen(Me.Items(name))
        End Function

        Protected Function GetPen(name As String, width As Single) As Pen
            Return New Pen(Me.Items(name), width)
        End Function

        Protected Function GetBrush(name As String) As SolidBrush
            Return New SolidBrush(Me.Items(name))
        End Function

        Protected Function GetColor(name As String) As Color
            Return Me.Items(name)
        End Function

        Protected Sub SetColor(name As String, value As Color)
            Dim flag As Boolean = Me.Items.ContainsKey(name)
            If flag Then
                Me.Items(name) = value
            Else
                Me.Items.Add(name, value)
            End If
        End Sub

        Protected Sub SetColor(name As String, r As Byte, g As Byte, b As Byte)
            Me.SetColor(name, Color.FromArgb(CInt(r), CInt(g), CInt(b)))
        End Sub

        Protected Sub SetColor(name As String, a As Byte, r As Byte, g As Byte, b As Byte)
            Me.SetColor(name, Color.FromArgb(CInt(a), CInt(r), CInt(g), CInt(b)))
        End Sub

        Protected Sub SetColor(name As String, a As Byte, value As Color)
            Me.SetColor(name, Color.FromArgb(CInt(a), value))
        End Sub

        Private Sub InvalidateBitmap()
            Dim flag As Boolean = MyBase.Width = 0 OrElse MyBase.Height = 0
            If Not flag Then
                Me.B = New Bitmap(MyBase.Width, MyBase.Height, PixelFormat.Format32bppPArgb)
                Me.G = Graphics.FromImage(Me.B)
            End If
        End Sub

        Private Sub InvalidateCustimization()
            Dim memoryStream As MemoryStream = New MemoryStream(Me.Items.Count * 4)
            For Each bloom As Bloom55546 In Me.Colors
                memoryStream.Write(BitConverter.GetBytes(bloom.Value.ToArgb()), 0, 4)
            Next
            memoryStream.Close()
            Me._Customization = Convert.ToBase64String(memoryStream.ToArray())
        End Sub

        Private Sub InvalidateTimer()
            Dim flag As Boolean = MyBase.DesignMode OrElse Not Me.DoneCreation
            If Not flag Then
                Dim isAnimated As Boolean = Me._IsAnimated
                If isAnimated Then
                    ThemeShare46546.AddAnimationCallback(AddressOf Me.DoAnimation)
                Else
                    ThemeShare46546.RemoveAnimationCallback(AddressOf Me.DoAnimation)
                End If
            End If
        End Sub

        Protected MustOverride Sub ColorHook()

        Protected MustOverride Sub PaintHook()

        Protected Overridable Sub OnCreation()
        End Sub

        Protected Overridable Sub OnAnimation()
        End Sub

        Protected Function Offset(r As Rectangle, amount As Integer) As Rectangle
            ' The following expression was wrapped in a checked-expression
            Me.OffsetReturnRectangle = New Rectangle(r.X + amount, r.Y + amount, r.Width - amount * 2, r.Height - amount * 2)
            Return Me.OffsetReturnRectangle
        End Function

        Protected Function Offset(s As Size, amount As Integer) As Size
            Me.OffsetReturnSize = New Size(s.Width + amount, s.Height + amount)
            Return Me.OffsetReturnSize
        End Function

        Protected Function Offset(p As Point, amount As Integer) As Point
            Me.OffsetReturnPoint = New Point(p.X + amount, p.Y + amount)
            Return Me.OffsetReturnPoint
        End Function

        Protected Function Center(p As Rectangle, c As Rectangle) As Point
            Me.CenterReturn = New Point(p.Width / 2 - c.Width / 2 + p.X + c.X, p.Height / 2 - c.Height / 2 + p.Y + c.Y)
            Return Me.CenterReturn
        End Function

        Protected Function Center(p As Rectangle, c As Size) As Point
            Me.CenterReturn = New Point(p.Width / 2 - c.Width / 2 + p.X, p.Height / 2 - c.Height / 2 + p.Y)
            Return Me.CenterReturn
        End Function

        Protected Function Center(child As Rectangle) As Point
            Return Me.Center(MyBase.Width, MyBase.Height, child.Width, child.Height)
        End Function

        Protected Function Center(child As Size) As Point
            Return Me.Center(MyBase.Width, MyBase.Height, child.Width, child.Height)
        End Function

        Protected Function Center(childWidth As Integer, childHeight As Integer) As Point
            Return Me.Center(MyBase.Width, MyBase.Height, childWidth, childHeight)
        End Function

        Protected Function Center(p As Size, c As Size) As Point
            Return Me.Center(p.Width, p.Height, c.Width, c.Height)
        End Function

        Protected Function Center(pWidth As Integer, pHeight As Integer, cWidth As Integer, cHeight As Integer) As Point
            Me.CenterReturn = New Point(pWidth / 2 - cWidth / 2, pHeight / 2 - cHeight / 2)
            Return Me.CenterReturn
        End Function

        Protected Function Measure() As Size
            Return Me.MeasureGraphics.MeasureString(Me.Text, Me.Font, MyBase.Width).ToSize()
        End Function

        Protected Function Measure(text As String) As Size
            Return Me.MeasureGraphics.MeasureString(text, Me.Font, MyBase.Width).ToSize()
        End Function

        Protected Sub DrawPixel(c1 As Color, x As Integer, y As Integer)
            Dim transparent As Boolean = Me._Transparent
            If transparent Then
                Me.B.SetPixel(x, y, c1)
            Else
                Me.DrawPixelBrush = New SolidBrush(c1)
                Me.G.FillRectangle(Me.DrawPixelBrush, x, y, 1, 1)
            End If
        End Sub

        Protected Sub DrawCorners(c1 As Color, offset As Integer)
            Me.DrawCorners(c1, 0, 0, MyBase.Width, MyBase.Height, offset)
        End Sub

        Protected Sub DrawCorners(c1 As Color, r1 As Rectangle, offset As Integer)
            Me.DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset)
        End Sub

        Protected Sub DrawCorners(c1 As Color, x As Integer, y As Integer, width As Integer, height As Integer, offset As Integer)
            Me.DrawCorners(c1, x + offset, y + offset, width - offset * 2, height - offset * 2)
        End Sub

        Protected Sub DrawCorners(c1 As Color)
            Me.DrawCorners(c1, 0, 0, MyBase.Width, MyBase.Height)
        End Sub

        Protected Sub DrawCorners(c1 As Color, r1 As Rectangle)
            Me.DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height)
        End Sub

        Protected Sub DrawCorners(c1 As Color, x As Integer, y As Integer, width As Integer, height As Integer)
            Dim noRounding As Boolean = Me._NoRounding
            If Not noRounding Then
                Dim transparent As Boolean = Me._Transparent
                If transparent Then
                    Me.B.SetPixel(x, y, c1)
                    Me.B.SetPixel(x + (width - 1), y, c1)
                    Me.B.SetPixel(x, y + (height - 1), c1)
                    Me.B.SetPixel(x + (width - 1), y + (height - 1), c1)
                Else
                    Me.DrawCornersBrush = New SolidBrush(c1)
                    Me.G.FillRectangle(Me.DrawCornersBrush, x, y, 1, 1)
                    Me.G.FillRectangle(Me.DrawCornersBrush, x + (width - 1), y, 1, 1)
                    Me.G.FillRectangle(Me.DrawCornersBrush, x, y + (height - 1), 1, 1)
                    Me.G.FillRectangle(Me.DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1)
                End If
            End If
        End Sub

        Protected Sub DrawBorders(p1 As Pen, offset As Integer)
            Me.DrawBorders(p1, 0, 0, MyBase.Width, MyBase.Height, offset)
        End Sub

        Protected Sub DrawBorders(p1 As Pen, r As Rectangle, offset As Integer)
            Me.DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset)
        End Sub

        Protected Sub DrawBorders(p1 As Pen, x As Integer, y As Integer, width As Integer, height As Integer, offset As Integer)
            Me.DrawBorders(p1, x + offset, y + offset, width - offset * 2, height - offset * 2)
        End Sub

        Protected Sub DrawBorders(p1 As Pen)
            Me.DrawBorders(p1, 0, 0, MyBase.Width, MyBase.Height)
        End Sub

        Protected Sub DrawBorders(p1 As Pen, r As Rectangle)
            Me.DrawBorders(p1, r.X, r.Y, r.Width, r.Height)
        End Sub

        Protected Sub DrawBorders(p1 As Pen, x As Integer, y As Integer, width As Integer, height As Integer)
            Me.G.DrawRectangle(p1, x, y, width - 1, height - 1)
        End Sub

        Protected Sub DrawText(b1 As Brush, a As HorizontalAlignment, x As Integer, y As Integer)
            Me.DrawText(b1, Me.Text, a, x, y)
        End Sub

        Protected Sub DrawText(b1 As Brush, text As String, a As HorizontalAlignment, x As Integer, y As Integer)
            Dim flag As Boolean = text.Length = 0
            If Not flag Then
                Me.DrawTextSize = Me.Measure(text)
                Me.DrawTextPoint = Me.Center(Me.DrawTextSize)
                Select Case a
                    Case HorizontalAlignment.Left
                        Me.G.DrawString(text, Me.Font, b1, CSng(x), CSng((Me.DrawTextPoint.Y + y)))
                    Case HorizontalAlignment.Right
                        Me.G.DrawString(text, Me.Font, b1, CSng((MyBase.Width - Me.DrawTextSize.Width - x)), CSng((Me.DrawTextPoint.Y + y)))
                    Case HorizontalAlignment.Center
                        Me.G.DrawString(text, Me.Font, b1, CSng((Me.DrawTextPoint.X + x)), CSng((Me.DrawTextPoint.Y + y)))
                End Select
            End If
        End Sub

        Protected Sub DrawText(b1 As Brush, p1 As Point)
            Dim flag As Boolean = Me.Text.Length = 0
            If Not flag Then
                Me.G.DrawString(Me.Text, Me.Font, b1, p1)
            End If
        End Sub

        Protected Sub DrawText(b1 As Brush, x As Integer, y As Integer)
            Dim flag As Boolean = Me.Text.Length = 0
            If Not flag Then
                Me.G.DrawString(Me.Text, Me.Font, b1, CSng(x), CSng(y))
            End If
        End Sub

        Protected Sub DrawImage(a As HorizontalAlignment, x As Integer, y As Integer)
            Me.DrawImage(Me._Image, a, x, y)
        End Sub

        Protected Sub DrawImage(image As Image, a As HorizontalAlignment, x As Integer, y As Integer)
            Dim flag As Boolean = image Is Nothing
            If Not flag Then
                Me.DrawImagePoint = Me.Center(image.Size)
                Select Case a
                    Case HorizontalAlignment.Left
                        Me.G.DrawImage(image, x, Me.DrawImagePoint.Y + y, image.Width, image.Height)
                    Case HorizontalAlignment.Right
                        Me.G.DrawImage(image, MyBase.Width - image.Width - x, Me.DrawImagePoint.Y + y, image.Width, image.Height)
                    Case HorizontalAlignment.Center
                        Me.G.DrawImage(image, Me.DrawImagePoint.X + x, Me.DrawImagePoint.Y + y, image.Width, image.Height)
                End Select
            End If
        End Sub

        Protected Sub DrawImage(p1 As Point)
            Me.DrawImage(Me._Image, p1.X, p1.Y)
        End Sub

        Protected Sub DrawImage(x As Integer, y As Integer)
            Me.DrawImage(Me._Image, x, y)
        End Sub

        Protected Sub DrawImage(image As Image, p1 As Point)
            Me.DrawImage(image, p1.X, p1.Y)
        End Sub

        Protected Sub DrawImage(image As Image, x As Integer, y As Integer)
            Dim flag As Boolean = image Is Nothing
            If Not flag Then
                Me.G.DrawImage(image, x, y, image.Width, image.Height)
            End If
        End Sub

        Protected Sub DrawGradient(blend As ColorBlend, x As Integer, y As Integer, width As Integer, height As Integer)
            Me.DrawGradientRectangle = New Rectangle(x, y, width, height)
            Me.DrawGradient(blend, Me.DrawGradientRectangle)
        End Sub

        Protected Sub DrawGradient(blend As ColorBlend, x As Integer, y As Integer, width As Integer, height As Integer, angle As Single)
            Me.DrawGradientRectangle = New Rectangle(x, y, width, height)
            Me.DrawGradient(blend, Me.DrawGradientRectangle, angle)
        End Sub

        Protected Sub DrawGradient(blend As ColorBlend, r As Rectangle)
            Me.DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, 90.0F)
            Me.DrawGradientBrush.InterpolationColors = blend
            Me.G.FillRectangle(Me.DrawGradientBrush, r)
        End Sub

        Protected Sub DrawGradient(blend As ColorBlend, r As Rectangle, angle As Single)
            Me.DrawGradientBrush = New LinearGradientBrush(r, Color.Empty, Color.Empty, angle)
            Me.DrawGradientBrush.InterpolationColors = blend
            Me.G.FillRectangle(Me.DrawGradientBrush, r)
        End Sub

        Protected Sub DrawGradient(c1 As Color, c2 As Color, x As Integer, y As Integer, width As Integer, height As Integer)
            Me.DrawGradientRectangle = New Rectangle(x, y, width, height)
            Me.DrawGradient(c1, c2, Me.DrawGradientRectangle)
        End Sub

        Protected Sub DrawGradient(c1 As Color, c2 As Color, x As Integer, y As Integer, width As Integer, height As Integer, angle As Single)
            Me.DrawGradientRectangle = New Rectangle(x, y, width, height)
            Me.DrawGradient(c1, c2, Me.DrawGradientRectangle, angle)
        End Sub

        Protected Sub DrawGradient(c1 As Color, c2 As Color, r As Rectangle)
            Me.DrawGradientBrush = New LinearGradientBrush(r, c1, c2, 90.0F)
            Me.G.FillRectangle(Me.DrawGradientBrush, r)
        End Sub

        Protected Sub DrawGradient(c1 As Color, c2 As Color, r As Rectangle, angle As Single)
            Me.DrawGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
            Me.G.FillRectangle(Me.DrawGradientBrush, r)
        End Sub

        Public Sub DrawRadial(blend As ColorBlend, x As Integer, y As Integer, width As Integer, height As Integer)
            Me.DrawRadialRectangle = New Rectangle(x, y, width, height)
            Me.DrawRadial(blend, Me.DrawRadialRectangle, width / 2, height / 2)
        End Sub

        Public Sub DrawRadial(blend As ColorBlend, x As Integer, y As Integer, width As Integer, height As Integer, center As Point)
            Me.DrawRadialRectangle = New Rectangle(x, y, width, height)
            Me.DrawRadial(blend, Me.DrawRadialRectangle, center.X, center.Y)
        End Sub

        Public Sub DrawRadial(blend As ColorBlend, x As Integer, y As Integer, width As Integer, height As Integer, cx As Integer, cy As Integer)
            Me.DrawRadialRectangle = New Rectangle(x, y, width, height)
            Me.DrawRadial(blend, Me.DrawRadialRectangle, cx, cy)
        End Sub

        Public Sub DrawRadial(blend As ColorBlend, r As Rectangle)
            Me.DrawRadial(blend, r, r.Width / 2, r.Height / 2)
        End Sub

        Public Sub DrawRadial(blend As ColorBlend, r As Rectangle, center As Point)
            Me.DrawRadial(blend, r, center.X, center.Y)
        End Sub

        Public Sub DrawRadial(blend As ColorBlend, r As Rectangle, cx As Integer, cy As Integer)
            Me.DrawRadialPath.Reset()
            Me.DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1)
            Me.DrawRadialBrush1 = New PathGradientBrush(Me.DrawRadialPath)
            Me.DrawRadialBrush1.CenterPoint = New Point(r.X + cx, r.Y + cy)
            Me.DrawRadialBrush1.InterpolationColors = blend
            Dim flag As Boolean = Me.G.SmoothingMode = SmoothingMode.AntiAlias
            If flag Then
                Me.G.FillEllipse(Me.DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3)
            Else
                Me.G.FillEllipse(Me.DrawRadialBrush1, r)
            End If
        End Sub

        Protected Sub DrawRadial(c1 As Color, c2 As Color, x As Integer, y As Integer, width As Integer, height As Integer)
            Me.DrawRadialRectangle = New Rectangle(x, y, width, height)
            Me.DrawRadial(c1, c2, Me.DrawRadialRectangle)
        End Sub

        Protected Sub DrawRadial(c1 As Color, c2 As Color, x As Integer, y As Integer, width As Integer, height As Integer, angle As Single)
            Me.DrawRadialRectangle = New Rectangle(x, y, width, height)
            Me.DrawRadial(c1, c2, Me.DrawRadialRectangle, angle)
        End Sub

        Protected Sub DrawRadial(c1 As Color, c2 As Color, r As Rectangle)
            Me.DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, 90.0F)
            Me.G.FillEllipse(Me.DrawRadialBrush2, r)
        End Sub

        Protected Sub DrawRadial(c1 As Color, c2 As Color, r As Rectangle, angle As Single)
            Me.DrawRadialBrush2 = New LinearGradientBrush(r, c1, c2, angle)
            Me.G.FillEllipse(Me.DrawRadialBrush2, r)
        End Sub

        Public Function CreateRound(x As Integer, y As Integer, width As Integer, height As Integer, slope As Integer) As GraphicsPath
            Me.CreateRoundRectangle = New Rectangle(x, y, width, height)
            Return Me.CreateRound(Me.CreateRoundRectangle, slope)
        End Function

        Public Function CreateRound(r As Rectangle, slope As Integer) As GraphicsPath
            Me.CreateRoundPath = New GraphicsPath(FillMode.Winding)
            Me.CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F)
            Me.CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F)
            Me.CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0F, 90.0F)
            Me.CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F)
            Me.CreateRoundPath.CloseFigure()
            Return Me.CreateRoundPath
        End Function

        Protected G As Graphics

        Protected B As Bitmap

        Private DoneCreation As Boolean

        Private _BackColor As Boolean

        Private _NoRounding As Boolean

        Private _Image As Image

        Private _Transparent As Boolean

        Private Items As Dictionary(Of String, Color)

        Private _Customization As String

        Private _ImageSize As Size

        Private _LockWidth As Integer

        Private _LockHeight As Integer

        Private _IsAnimated As Boolean

        Private OffsetReturnRectangle As Rectangle

        Private OffsetReturnSize As Size

        Private OffsetReturnPoint As Point

        Private CenterReturn As Point

        Private MeasureBitmap As Bitmap

        Private MeasureGraphics As Graphics

        Private DrawPixelBrush As SolidBrush

        Private DrawCornersBrush As SolidBrush

        Private DrawTextPoint As Point

        Private DrawTextSize As Size

        Private DrawImagePoint As Point

        Private DrawGradientBrush As LinearGradientBrush

        Private DrawGradientRectangle As Rectangle

        Private DrawRadialPath As GraphicsPath

        Private DrawRadialBrush1 As PathGradientBrush

        Private DrawRadialBrush2 As LinearGradientBrush

        Private DrawRadialRectangle As Rectangle

        Private CreateRoundPath As GraphicsPath

        Private CreateRoundRectangle As Rectangle
    End Class
End Namespace
