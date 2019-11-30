Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Namespace spy673
    Friend Class ThemeProgressBar
        Inherits ThemeControl0
        Public Property Minimum As Integer
            Get
                Return Me._Minimum
            End Get
            Set(value As Integer)
                Dim flag As Boolean = value < 0
                If flag Then
                End If
                Me._Minimum = value
                Dim flag2 As Boolean = value > Me._Value
                If flag2 Then
                    Me._Value = value
                End If
                Dim flag3 As Boolean = value > Me._Maximum
                If flag3 Then
                    Me._Maximum = value
                End If
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Maximum As Integer
            Get
                Return Me._Maximum
            End Get
            Set(value As Integer)
                Dim flag As Boolean = value < 0
                If flag Then
                End If
                Me._Maximum = value
                Dim flag2 As Boolean = value < Me._Value
                If flag2 Then
                    Me._Value = value
                End If
                Dim flag3 As Boolean = value < Me._Minimum
                If flag3 Then
                    Me._Minimum = value
                End If
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Animated As Boolean
            Get
                Return MyBase.IsAnimated
            End Get
            Set(value As Boolean)
                MyBase.IsAnimated = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Value As Integer
            Get
                Return Me._Value
            End Get
            Set(value As Integer)
                Dim flag As Boolean = value > Me._Maximum OrElse value < Me._Minimum
                If flag Then
                End If
                Me._Value = value
                MyBase.Invalidate()
            End Set
        End Property

        Private Sub Increment(amount As Integer)
            Me.Value += amount
        End Sub

        Public Sub New()
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

        <Category("Colours")>
        Public Property Colour0 As Color
            Get
                Return Me._Color0
            End Get
            Set(value As Color)
                Me._Color0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property Colour1 As Color
            Get
                Return Me._Color1
            End Get
            Set(value As Color)
                Me._Color1 = value
            End Set
        End Property

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
            Dim brush As LinearGradientBrush = New LinearGradientBrush(New Rectangle(New Point(1, 1), New Size(MyBase.Width - 2, MyBase.Height - 2)), Me.G1, Me.G2, 90.0F)
            Dim rect As Rectangle = New Rectangle(1, 1, CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1.0)), MyBase.Height - 2)
            Dim rect2 As Rectangle = New Rectangle(1, 1, CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1.0)), CInt(Math.Round(CDbl(MyBase.Height) / 2.0 - 3.0)))
            Dim rect3 As Rectangle = New Rectangle(1, 1, MyBase.Width - 2, MyBase.Height - 2)
            Dim brush2 As HatchBrush = New HatchBrush(HatchStyle.WideUpwardDiagonal, Me.Colour0, Me.Colour1)
            Dim rect4 As Rectangle = New Rectangle(1, 2, CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1.0)), MyBase.Height - 3)
            Me.G.FillRectangle(brush, rect)
            Me.G.FillRectangle(New SolidBrush(Me.Glow), rect2)
            Me.G.RenderingOrigin = New Point(Me.GlowPosition, 0)
            Me.G.FillRectangle(brush2, rect4)
            Me.G.DrawLine(New Pen(Me.Edge), New Point(CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1.0)), 1), New Point(CInt(Math.Round(CDbl(MyBase.Width) / CDbl(Me.Maximum) * CDbl(Me.Value) - 1.0)), MyBase.Height - 1))
            Me.G.DrawRectangle(New Pen(Me.Edge), rect3)
        End Sub

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
    End Class
End Namespace
