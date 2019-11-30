Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports SpyNote_V6._4.SN.PI

Namespace SN
    Public Class ThemeBtnBar
        Inherits Control
        Private State As MouseState

        Private _ShowImage As Boolean

        Private _Image As Image

        Private _CLREnabled As Color

        Private _CLRNone As Color

        Private _CLRNone1 As Color

        Private _CLRNonebrd As Color

        Private _CLRDown As Color

        Private _CLRDown1 As Color

        Private _CLRDownbrd As Color

        Private _CLROver0 As Color

        Private _CLROver1 As Color

        Private _CLROverbrd As Color

        <Category("Colours")>
        Public Property CLRDown0 As Color
            Get
                Return Me._CLRDown
            End Get
            Set(ByVal value As Color)
                Me._CLRDown = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLRDown1 As Color
            Get
                Return Me._CLRDown1
            End Get
            Set(ByVal value As Color)
                Me._CLRDown1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLRDownbrd As Color
            Get
                Return Me._CLRDownbrd
            End Get
            Set(ByVal value As Color)
                Me._CLRDownbrd = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLREnabled As Color
            Get
                Return Me._CLREnabled
            End Get
            Set(ByVal value As Color)
                Me._CLREnabled = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLRNone0 As Color
            Get
                Return Me._CLRNone
            End Get
            Set(ByVal value As Color)
                Me._CLRNone = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLRNone1 As Color
            Get
                Return Me._CLRNone1
            End Get
            Set(ByVal value As Color)
                Me._CLRNone1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLRNonebrd As Color
            Get
                Return Me._CLRNonebrd
            End Get
            Set(ByVal value As Color)
                Me._CLRNonebrd = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLROver0 As Color
            Get
                Return Me._CLROver0
            End Get
            Set(ByVal value As Color)
                Me._CLROver0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLROver1 As Color
            Get
                Return Me._CLROver1
            End Get
            Set(ByVal value As Color)
                Me._CLROver1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property CLROverbrd As Color
            Get
                Return Me._CLROverbrd
            End Get
            Set(ByVal value As Color)
                Me._CLROverbrd = value
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

        Public Sub New()
            MyBase.New()
            Me.State = MouseState.None
            Me._ShowImage = False
            Me._Image = Nothing
            Me._CLREnabled = Color.FromArgb(20, 20, 20)
            Me._CLRNone = Color.FromArgb(73, 73, 73)
            Me._CLRNone1 = Color.FromArgb(81, 86, 88)
            Me._CLRNonebrd = Color.FromArgb(43, 43, 43)
            Me._CLRDown = Color.FromArgb(1, 1, 1)
            Me._CLRDown1 = Color.FromArgb(1, 1, 1)
            Me._CLRDownbrd = Color.FromArgb(43, 43, 43)
            Me._CLROver0 = Color.FromArgb(73, 73, 73)
            Me._CLROver1 = Color.FromArgb(91, 96, 98)
            Me._CLROverbrd = Color.FromArgb(43, 43, 43)
            MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.DoubleBuffered = True
            MyBase.Size = New System.Drawing.Size(65, 65)
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
            If (MyBase.Size.Width <> 65 Or MyBase.Size.Height <> 65) Then
                MyBase.Size = New System.Drawing.Size(65, 65)
            End If
            Dim graphics As System.Drawing.Graphics = e.Graphics
            Dim graphic As System.Drawing.Graphics = graphics
            Me.Font = New System.Drawing.Font(New FontFamily("Arial"), 8.0!, FontStyle.Bold)
            graphics.Clear(Me.BackColor)
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim num As Integer = 62
            If (MyBase.Enabled) Then
                Select Case Me.State
                    Case MouseState.None
                        Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.CLRNone0, Me.CLRNone1, 270.0!)
                        graphics.FillPath(linearGradientBrush, Draw.RoundRect(MyBase.ClientRectangle, 37))
                        Dim pen As System.Drawing.Pen = New System.Drawing.Pen(Me.CLRNonebrd, 3.0!)
                        graphics.DrawEllipse(pen, 1, 1, num, num)
                        Exit Select
                    Case MouseState.Over
                        Dim linearGradientBrush1 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.CLROver0, Me.CLROver1, 270.0!)
                        graphics.FillPath(linearGradientBrush1, Draw.RoundRect(MyBase.ClientRectangle, 37))
                        Dim pen1 As System.Drawing.Pen = New System.Drawing.Pen(Me.CLROverbrd, 3.0!)
                        graphics.DrawEllipse(pen1, 1, 1, num, num)
                        Exit Select
                    Case MouseState.Down
                        Dim linearGradientBrush2 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.CLRDown0, Me.CLRDown1, 270.0!)
                        graphics.FillPath(linearGradientBrush2, Draw.RoundRect(MyBase.ClientRectangle, 37))
                        Dim pen2 As System.Drawing.Pen = New System.Drawing.Pen(Me.CLRDownbrd, 3.0!)
                        graphics.DrawEllipse(pen2, 1, 1, num, num)
                        Exit Select
                End Select
            Else
                Dim linearGradientBrush3 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(MyBase.ClientRectangle, Me.CLREnabled, Me.CLREnabled, LinearGradientMode.Vertical)
                graphics.FillPath(linearGradientBrush3, Draw.RoundRect(MyBase.ClientRectangle, 37))
                Dim pen3 As System.Drawing.Pen = New System.Drawing.Pen(Me.CLREnabled, 3.0!)
                graphics.DrawEllipse(pen3, 1, 1, num, num)
            End If
            If (Me._ShowImage) Then
                If (Me._Image IsNot Nothing) Then
                    graphic.DrawImage(Me._Image, New Rectangle(21, 22, 24, 24))
                End If
            End If
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphic = Nothing
        End Sub
    End Class
End Namespace