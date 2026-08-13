Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports SpyNote_V6._4.SN.SpyNote.Stores

Namespace SN
    Friend Class PI
        Inherits PictureBox
        Public ThemeButtonselected_Color As Color

        Public BackClr As Color

        Public CLRChecked As Color

        Public CLRCnone As Color

        Public CLRs7 As Color

        Public TFint As System.Drawing.Font

        Private Stated As PI.MouseState

        <Category("Colours")>
        Public Property _CLRChecked As Color
            Get
                Return Me.CLRChecked
            End Get
            Set(ByVal value As Color)
                Me.CLRChecked = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Colours")>
        Public Property _CLRCnone As Color
            Get
                Return Me.CLRCnone
            End Get
            Set(ByVal value As Color)
                Me.CLRCnone = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Colours")>
        Public Property _CLRs7e As Color
            Get
                Return Me.CLRs7
            End Get
            Set(ByVal value As Color)
                Me.CLRs7 = value
                MyBase.Invalidate()
            End Set
        End Property

        <Category("Colours")>
        Public Property BACKCOLORR As Color
            Get
                Return Me.BackClr
            End Get
            Set(ByVal value As Color)
                Me.BackClr = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            Me.ThemeButtonselected_Color = Color.FromArgb(0, 118, 177)
            Me.BackClr = Color.FromArgb(63, 63, 70)
            Me.CLRChecked = Color.FromArgb(30, 145, 255)
            Me.CLRCnone = Color.DimGray
            Me.CLRs7 = Color.FromArgb(224, 224, 224)
            Me.TFint = New System.Drawing.Font("Arial", 8.25!, FontStyle.Bold)
            Me.Stated = PI.MouseState.None
            MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            Me.Font = Me.TFint
            Me.BackColor = Color.Transparent
            MyBase.Size = New System.Drawing.Size(MyBase.Size.Width, 20)
        End Sub

        Protected Overrides Sub CreateHandle()
            MyBase.CreateHandle()
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            Me.Stated = PI.MouseState.Over
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            Me.Stated = PI.MouseState.None
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            Me.Stated = PI.MouseState.Over
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            Me.Stated = PI.MouseState.None
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim color As System.Drawing.Color
            MyBase.OnPaint(e)
            Dim graphics As System.Drawing.Graphics = e.Graphics
            graphics.Clear(System.Drawing.Color.Transparent)
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(-1, -1, MyBase.Width + 1, MyBase.Height + 1)
            Using solidBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me.BACKCOLORR)
                graphics.FillRectangle(solidBrush, rectangle)
            End Using
            If (Not Operators.ConditionalCompareObjectEqual(MyBase.Tag, "OK", False)) Then
                Dim r As Byte = Me._CLRCnone.R
                Dim g As Byte = Me._CLRCnone.G
                color = Me._CLRCnone
                Dim solidBrush1 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, CInt(r), CInt(g), CInt(color.B)))
                Dim pen As System.Drawing.Pen = New System.Drawing.Pen(solidBrush1, 2.0!)
                graphics.DrawEllipse(pen, 5, 5, 15, 15)
            Else
                Dim num As Byte = Me._CLRChecked.R
                Dim g1 As Byte = Me._CLRChecked.G
                color = Me._CLRChecked
                Dim solidBrush2 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(40, CInt(num), CInt(g1), CInt(color.B)))
                Dim pen1 As System.Drawing.Pen = New System.Drawing.Pen(solidBrush2, 2.0!)
                graphics.DrawEllipse(pen1, 5, 5, 15, 15)
                Dim r1 As Byte = Me._CLRChecked.R
                Dim num1 As Byte = Me._CLRChecked.G
                color = Me._CLRChecked
                Using solidBrush3 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, CInt(r1), CInt(num1), CInt(color.B)))
                    e.Graphics.FillEllipse(solidBrush3, 5, 5, 15, 15)
                End Using
                Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Store.Bitmap_0("ToolStrip\Check1"))
                graphics.DrawImage(bitmap, 6, 4, bitmap.Width, bitmap.Height)
            End If
        End Sub

        Public Enum MouseState As Byte
            None
            Over
            Down
        End Enum
    End Class
End Namespace
