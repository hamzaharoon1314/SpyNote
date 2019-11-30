Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SN
    Public Class ThemeTabControl
        Inherits TabControl

        Public Sub New()
            Me.ThemeTabControl = New Font("Segoe UI Semibold", 9.0F, FontStyle.Regular)
            Me.MouseOver0 = Color.FromArgb(63, 63, 70)
            Me.MouseOver1 = Color.FromArgb(37, 37, 38)
            Me.DefaultColor0 = Color.FromArgb(37, 37, 38)
            Me.DefaultColor1 = Color.FromArgb(174, 174, 174)
            Me.DefaultBackColorr = Color.FromArgb(37, 37, 38)
            Me.DefaultFForeColoerr = Color.FromArgb(37, 37, 38)
            Me.BorderColor = Color.FromArgb(37, 37, 38)
            Me.FForColorSelcted = Color.FromArgb(214, 214, 214)
            MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
            Me.BackColor = Color.Transparent
            Me.DoubleBuffered = True
            MyBase.ItemSize = New Size(25, 25)
        End Sub

        <Category("Colours")>
        Public Property MouseOver0_S As Color
            Get
                Return Me.MouseOver0
            End Get
            Set(value As Color)
                Me.MouseOver0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property MouseOver1_S As Color
            Get
                Return Me.MouseOver1
            End Get
            Set(value As Color)
                Me.MouseOver1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property DefaultColor0_S As Color
            Get
                Return Me.DefaultColor0
            End Get
            Set(value As Color)
                Me.DefaultColor0 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property DefaultColor1_S As Color
            Get
                Return Me.DefaultColor1
            End Get
            Set(value As Color)
                Me.DefaultColor1 = value
            End Set
        End Property

        <Category("Colours")>
        Public Property DefaultBackColor_S As Color
            Get
                Return Me.DefaultBackColorr
            End Get
            Set(value As Color)
                Me.DefaultBackColorr = value
            End Set
        End Property

        <Category("Colours")>
        Public Property DefaultForColor_S As Color
            Get
                Return Me.DefaultFForeColoerr
            End Get
            Set(value As Color)
                Me.DefaultFForeColoerr = value
            End Set
        End Property

        <Category("Colours")>
        Public Property BorderColor_S As Color
            Get
                Return Me.BorderColor
            End Get
            Set(value As Color)
                Me.BorderColor = value
            End Set
        End Property

        <Category("Colours")>
        Public Property FForColorSelcted_S As Color
            Get
                Return Me.FForColorSelcted
            End Get
            Set(value As Color)
                Me.FForColorSelcted = value
            End Set
        End Property

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
            Dim graphics As Graphics = Graphics.FromImage(bitmap)
            Dim rect As Rectangle = New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1)
            graphics.Clear(Me.BackColor)
            graphics.FillRectangle(New SolidBrush(Me.DefaultBackColor_S), rect)
            graphics.DrawRectangle(New Pen(Me.BorderColor_S), rect)
            Dim num As Integer = MyBase.TabCount - 1
            For i As Integer = 0 To num
                Dim r As Rectangle = New Rectangle(New Point(MyBase.GetTabRect(i).Location.X, MyBase.GetTabRect(i).Location.Y), New Size(MyBase.GetTabRect(i).Width, MyBase.GetTabRect(i).Height))
                Dim flag As Boolean = MyBase.SelectedIndex <> -1
                If flag Then
                    Dim flag2 As Boolean = i = MyBase.SelectedIndex
                    If flag2 Then
                        Dim rectangle As Rectangle = New Rectangle(New Point(MyBase.GetTabRect(i).Location.X, MyBase.GetTabRect(i).Location.Y + 22), New Size(MyBase.GetTabRect(i).Width, 4))
                        Dim brush As LinearGradientBrush = New LinearGradientBrush(rectangle, Me.MouseOver0_S, Me.MouseOver1_S, LinearGradientMode.Horizontal)
                        graphics.FillPath(brush, DrewTabControl.RoundRect(rectangle, 1))
                        graphics.DrawString(MyBase.TabPages(i).Text, Me.ThemeTabControl, New SolidBrush(Me.FForColorSelcted_S), r, New StringFormat() With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                    Else
                        Dim rectangle2 As Rectangle = New Rectangle(New Point(MyBase.GetTabRect(i).Location.X, MyBase.GetTabRect(i).Location.Y), New Size(MyBase.GetTabRect(i).Width, MyBase.GetTabRect(i).Height))
                        Dim brush2 As LinearGradientBrush = New LinearGradientBrush(rectangle2, Me.DefaultColor0_S, Me.DefaultColor1_S, LinearGradientMode.Horizontal)
                        graphics.FillPath(brush2, DrewTabControl.RoundRect(rectangle2, 1))
                        graphics.DrawString(MyBase.TabPages(i).Text, Me.ThemeTabControl, New SolidBrush(Me.DefaultForColor_S), r, New StringFormat() With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                    End If
                End If
            Next
            e.Graphics.DrawImage(bitmap, New Point(0, 0))
            graphics.Dispose()
            bitmap.Dispose()
        End Sub

        Public ThemeTabControl As Font

        Private MouseOver0 As Color

        Private MouseOver1 As Color

        Private DefaultColor0 As Color

        Private DefaultColor1 As Color

        Private DefaultBackColorr As Color

        Private DefaultFForeColoerr As Color

        Private BorderColor As Color

        Private FForColorSelcted As Color
    End Class
End Namespace
