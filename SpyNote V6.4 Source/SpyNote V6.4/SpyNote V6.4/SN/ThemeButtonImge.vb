Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports SpyNote_V6._4.SN.PI

Namespace SN
    Public Class ThemeButtonImge
        Inherits Control
        Public ThemeButtonselected_Color As Color

        Public ThemeButtonselected_Color_ForColor As Color

        Public ThemeButtonbackColor As Color

        Public ThemeButtonForColor As Color

        Public ThemeButtonclrBorder As Color

        Public backColorNone0 As Color

        Public backColorNone1 As Color

        Public backColorOver0 As Color

        Public backColorOver1 As Color

        Public backColorDown0 As Color

        Public backColorDown1 As Color

        Public ButtonForColor As Color

        Public Buttonselected_Color_ForColor As Color

        Public ButtonForColorEnabled As Color

        Public ButtonBackColorEnabled0 As Color

        Public ButtonBackColorEnabled1 As Color

        Public ThemeButtonclrBorderactive As Color

        Public ThemeButtonclrBorderEnabled As Color

        Private _FontColour As Color

        Public ThemeButtonFont As System.Drawing.Font

        Private State As MouseState

        Private _ShowImage As Boolean

        Private _ShowText As Boolean

        Private _Image As Image

        Private _TextAlignment As StringAlignment

        Private _ImageAlignment As ThemeButtonImge.__ImageAlignment

        <Category("Colours")>
        Public Property BackColorDown0_S As Color
            Get
                Return Me.backColorDown0
            End Get
            Set(ByVal value As Color)
                Me.backColorDown0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BackColorDown1_S As Color
            Get
                Return Me.backColorDown1
            End Get
            Set(ByVal value As Color)
                Me.backColorDown1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BackColorNone0_S As Color
            Get
                Return Me.backColorNone0
            End Get
            Set(ByVal value As Color)
                Me.backColorNone0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BackColorNone1_S As Color
            Get
                Return Me.backColorNone1
            End Get
            Set(ByVal value As Color)
                Me.backColorNone1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BackColorOver0_S As Color
            Get
                Return Me.backColorOver0
            End Get
            Set(ByVal value As Color)
                Me.backColorOver0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BackColorOver1_S As Color
            Get
                Return Me.backColorOver1
            End Get
            Set(ByVal value As Color)
                Me.backColorOver1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ButtonBackColorEnabled0_S As Color
            Get
                Return Me.ButtonBackColorEnabled0
            End Get
            Set(ByVal value As Color)
                Me.ButtonBackColorEnabled0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ButtonBackColorEnabled1_S As Color
            Get
                Return Me.ButtonBackColorEnabled1
            End Get
            Set(ByVal value As Color)
                Me.ButtonBackColorEnabled1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ButtonForColor_S As Color
            Get
                Return Me.ButtonForColor
            End Get
            Set(ByVal value As Color)
                Me.ButtonForColor = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ButtonForColorEnabled_S As Color
            Get
                Return Me.ButtonForColorEnabled
            End Get
            Set(ByVal value As Color)
                Me.ButtonForColorEnabled = value
            End Set
        End Property

        <Category("Colours")>
        Public Property Buttonselected_Color_ForColor_S As Color
            Get
                Return Me.Buttonselected_Color_ForColor
            End Get
            Set(ByVal value As Color)
                Me.Buttonselected_Color_ForColor = value
            End Set
        End Property

        <Category("Control")>
        Public Property ImageAlignment As ThemeButtonImge.__ImageAlignment
            Get
                Return Me._ImageAlignment
            End Get
            Set(ByVal value As ThemeButtonImge.__ImageAlignment)
                If (If(Not Me._ShowText, True, value <> ThemeButtonImge.__ImageAlignment.Middle)) Then
                    Me._ImageAlignment = value
                Else
                    Me._ImageAlignment = ThemeButtonImge.__ImageAlignment.Left
                End If
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Control")>
        Public Property ImageChoice As Image
            Get
                Return Me._Image
            End Get
            Set(ByVal value As Image)
                Me._Image = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Control")>
        Public Property ShowImage As Boolean
            Get
                Return Me._ShowImage
            End Get
            Set(ByVal value As Boolean)
                Me._ShowImage = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Control")>
        Public Property ShowText As Boolean
            Get
                Return Me._ShowText
            End Get
            Set(ByVal value As Boolean)
                If (If(Me._ImageAlignment <> ThemeButtonImge.__ImageAlignment.Middle OrElse Not Me.ShowImage, False, value)) Then
                    Me._ImageAlignment = ThemeButtonImge.__ImageAlignment.Left
                End If
                Me._ShowText = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Control")>
        Public Property TextAlignment As StringAlignment
            Get
                Return Me._TextAlignment
            End Get
            Set(ByVal value As StringAlignment)
                Me._TextAlignment = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Colours")>
        Public Property ThemeButtonclrBorder_S As Color
            Get
                Return Me.ThemeButtonclrBorder
            End Get
            Set(ByVal value As Color)
                Me.ThemeButtonclrBorder = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ThemeButtonclrBorderactive_S As Color
            Get
                Return Me.ThemeButtonclrBorderactive
            End Get
            Set(ByVal value As Color)
                Me.ThemeButtonclrBorderactive = value
            End Set
        End Property

        <Category("Colours")>
        Public Property ThemeButtonclrBorderEnabled_S As Color
            Get
                Return Me.ThemeButtonclrBorderEnabled
            End Get
            Set(ByVal value As Color)
                Me.ThemeButtonclrBorderEnabled = value
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            Me.ThemeButtonselected_Color = Color.FromArgb(0, 118, 177)
            Me.ThemeButtonselected_Color_ForColor = Color.FromArgb(214, 214, 214)
            Me.ThemeButtonbackColor = Color.FromArgb(54, 56, 59)
            Me.ThemeButtonForColor = Color.FromArgb(174, 174, 174)
            Me.ThemeButtonclrBorder = Color.FromArgb(53, 53, 60)
            Me.backColorNone0 = Color.FromArgb(63, 63, 70)
            Me.backColorNone1 = Color.FromArgb(73, 73, 80)
            Me.backColorOver0 = Color.FromArgb(63, 63, 70)
            Me.backColorOver1 = Color.FromArgb(83, 83, 90)
            Me.backColorDown0 = Color.FromArgb(63, 63, 70)
            Me.backColorDown1 = Color.FromArgb(93, 93, 100)
            Me.ButtonForColor = Color.FromArgb(174, 174, 174)
            Me.Buttonselected_Color_ForColor = Color.FromArgb(214, 214, 214)
            Me.ButtonForColorEnabled = Color.FromArgb(83, 83, 90)
            Me.ButtonBackColorEnabled0 = Color.FromArgb(53, 53, 60)
            Me.ButtonBackColorEnabled1 = Color.FromArgb(53, 53, 60)
            Me.ThemeButtonclrBorderactive = Color.FromArgb(56, 56, 63)
            Me.ThemeButtonclrBorderEnabled = Color.FromArgb(68, 68, 75)
            Me._FontColour = Color.FromArgb(0, 0, 0)
            Me.ThemeButtonFont = New System.Drawing.Font("Arial", 8.25!, FontStyle.Bold)
            Me.State = MouseState.None
            Me._ShowImage = False
            Me._Image = Nothing
            Me._TextAlignment = StringAlignment.Center
            Me._ImageAlignment = ThemeButtonImge.__ImageAlignment.Left
            MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.DoubleBuffered = True
            MyBase.Size = New System.Drawing.Size(100, 20)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            Me.State = MouseState.Down
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            Me.State = MouseState.Over
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            Me.State = MouseState.None
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            Me.State = MouseState.Over
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim graphics As System.Drawing.Graphics = e.Graphics
            Dim graphic As System.Drawing.Graphics = graphics
            Me.Font = Me.ThemeButtonFont
            graphics.Clear(Me.BackColor)
            graphics.SmoothingMode = SmoothingMode.HighSpeed
            If (MyBase.Size.Height <> 20) Then
                MyBase.Size = New System.Drawing.Size(MyBase.Size.Width, 20)
            End If
            If (MyBase.Enabled) Then
                Select Case Me.State
                    Case MouseState.None
                        Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.BackColorNone1_S, Me.BackColorNone0_S, LinearGradientMode.Vertical)
                        Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 17, MyBase.Width - 1, MyBase.Height - 1)
                        graphics.FillRectangle(linearGradientBrush, rectangle)
                        Me._FontColour = Me.ButtonForColor_S
                        Exit Select
                    Case MouseState.Over
                        Dim linearGradientBrush1 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.BackColorOver1_S, Me.BackColorOver0_S, LinearGradientMode.Vertical)
                        Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, MyBase.Width - 1, MyBase.Height - 1)
                        graphics.FillRectangle(linearGradientBrush1, rectangle1)
                        Me._FontColour = Me.Buttonselected_Color_ForColor_S
                        Exit Select
                    Case MouseState.Down
                        Dim linearGradientBrush2 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.BackColorDown1_S, Me.BackColorDown0_S, LinearGradientMode.Vertical)
                        Dim rectangle2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, MyBase.Width - 1, MyBase.Height - 1)
                        graphics.FillRectangle(linearGradientBrush2, rectangle2)
                        Me._FontColour = Me.Buttonselected_Color_ForColor_S
                        Exit Select
                End Select
            ElseIf (Me.State = MouseState.None) Then
                Dim linearGradientBrush3 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.ButtonBackColorEnabled1_S, Me.ButtonBackColorEnabled0_S, LinearGradientMode.Vertical)
                Dim rectangle3 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 1, MyBase.Width - 1, MyBase.Height - 1)
                graphics.FillRectangle(linearGradientBrush3, rectangle3)
                Me._FontColour = Me.ButtonForColorEnabled_S
            End If
            If (Not Me._ShowImage) Then
                If (Me._ShowText) Then
                    graphic.DrawString(Me.Text, Me.Font, New SolidBrush(Me._FontColour), New System.Drawing.Rectangle(10, 0, MyBase.Width - 20, MyBase.Height), New StringFormat() With
                    {
                        .Alignment = Me._TextAlignment,
                        .LineAlignment = StringAlignment.Center
                    })
                End If
            ElseIf (Not Me._ShowText) Then
                If (Me._ImageAlignment = ThemeButtonImge.__ImageAlignment.Left) Then
                    graphic.DrawImage(Me._Image, New System.Drawing.Rectangle(1, 1, MyBase.Height - 3, MyBase.Height - 3))
                ElseIf (Me._ImageAlignment <> ThemeButtonImge.__ImageAlignment.Middle) Then
                    graphic.DrawImage(Me._Image, New System.Drawing.Rectangle(MyBase.Width - 1 - (MyBase.Height - 3), 1, MyBase.Height - 3, MyBase.Height - 3))
                Else
                    graphic.DrawImage(Me._Image, New System.Drawing.Rectangle(CInt(Math.Round(CDbl(MyBase.Width) / 2 - CDbl((MyBase.Height - 3)) / 2)), 1, MyBase.Height - 3, MyBase.Height - 3))
                End If
            ElseIf (If(MyBase.Width <= 50, True, MyBase.Height <= 22)) Then
                graphic.DrawString(Me.Text, Me.Font, New SolidBrush(Me._FontColour), New System.Drawing.Rectangle(10, 0, MyBase.Width - 20, MyBase.Height), New StringFormat() With
                {
                    .Alignment = Me._TextAlignment,
                    .LineAlignment = StringAlignment.Center
                })
            ElseIf (Me._ImageAlignment = ThemeButtonImge.__ImageAlignment.Left) Then
                graphic.DrawImage(Me._Image, New System.Drawing.Rectangle(1, 1, MyBase.Height - 3, MyBase.Height - 3))
                graphic.DrawString(Me.Text, Me.Font, New SolidBrush(Me._FontColour), New System.Drawing.Rectangle(0 + (MyBase.Height - 3), 0, MyBase.Width - 20 - (MyBase.Height - 1), MyBase.Height), New StringFormat() With
                {
                    .Alignment = Me._TextAlignment,
                    .LineAlignment = StringAlignment.Center
                })
            ElseIf (Me._ImageAlignment = ThemeButtonImge.__ImageAlignment.Right) Then
                graphic.DrawImage(Me._Image, New System.Drawing.Rectangle(MyBase.Width - 2 - (MyBase.Height - 3), 1, MyBase.Height - 3, MyBase.Height - 3))
                graphic.DrawString(Me.Text, Me.Font, New SolidBrush(Me._FontColour), New System.Drawing.Rectangle(10, 0, MyBase.Width - 20 - (MyBase.Height - 20), MyBase.Height), New StringFormat() With
                {
                    .Alignment = Me._TextAlignment,
                    .LineAlignment = StringAlignment.Center
                })
            End If
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphic = Nothing
        End Sub

        Public Enum __ImageAlignment
            Left
            Middle
            Right
        End Enum
    End Class
End Namespace