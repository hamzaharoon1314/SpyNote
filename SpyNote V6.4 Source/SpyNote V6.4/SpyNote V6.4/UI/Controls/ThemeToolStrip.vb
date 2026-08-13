Imports System.Drawing.Drawing2D
Imports SpyNote_V6._4.SN.SpyNote.Stores

Namespace SN
    Public Class ThemeToolStrip
        Inherits ToolStripSystemRenderer
        Public selected_Color As Color

        Public selected_Color_ForColor As Color

        Public backColor As Color

        Public backColorStrip As Color

        Public ForColor As Color

        Public clrSelectedBorder As Color

        Public clrSelectedBorderCheck As Color

        Public ColorLines0 As Color

        Public ColorLines1 As Color

        Public backColorChecked0 As Color

        Public backColorChecked1 As Color

        Public ArrowColor As Color

        Public ArrowselectedColor As Color

        Public ENBArrowselectedColor As Color

        Public ColorBorder As Color

        Public MyFont As Font

        Public Property UseDefaultSeperatorStyle As Boolean

        Public Sub New()
            MyBase.New()
            Me.UseDefaultSeperatorStyle = False
            Me.selected_Color = Color.FromArgb(45, 45, 48)
            Me.selected_Color_ForColor = Color.FromArgb(241, 241, 241)
            Me.backColor = Color.FromArgb(27, 27, 28)
            Me.backColorStrip = Color.FromArgb(45, 45, 48)
            Me.ForColor = Color.FromArgb(190, 190, 190)
            Me.clrSelectedBorder = Color.FromArgb(32, 146, 255)
            Me.clrSelectedBorderCheck = Color.FromArgb(10, 10, 10)
            Me.ColorLines0 = Color.FromArgb(37, 37, 38)
            Me.ColorLines1 = Color.FromArgb(17, 17, 18)
            Me.backColorChecked0 = Color.FromArgb(101, 101, 101)
            Me.backColorChecked1 = Color.FromArgb(123, 123, 123)
            Me.ArrowColor = Color.FromArgb(174, 174, 174)
            Me.ArrowselectedColor = Color.FromArgb(32, 146, 255)
            Me.ENBArrowselectedColor = Color.FromArgb(70, 70, 70)
            Me.ColorBorder = Color.FromArgb(27, 27, 28)
            Me.MyFont = New Font("Segoe UI Semibold", 9.0!, FontStyle.Regular)
        End Sub

        Public Sub DrawRoundedRectangle(ByVal objGraphics As Graphics, ByVal m_intxAxis As Integer, ByVal m_intyAxis As Integer, ByVal m_intWidth As Integer, ByVal m_intHeight As Integer, ByVal m_diameter As Integer, ByVal color As System.Drawing.Color)
            Try
                Dim pen As System.Drawing.Pen = New System.Drawing.Pen(color)
                Dim rectangleF As System.Drawing.RectangleF = New System.Drawing.RectangleF(CSng(m_intxAxis), CSng(m_intyAxis), CSng(m_intWidth), CSng(m_intHeight))
                Dim right As System.Drawing.RectangleF = New System.Drawing.RectangleF(rectangleF.Location, New SizeF(CSng(m_diameter), CSng(m_diameter)))
                objGraphics.DrawArc(pen, right, 180.0!, 90.0!)
                objGraphics.DrawLine(pen, m_intxAxis + CInt(Math.Round(CDbl(m_diameter) / 2)), m_intyAxis, m_intxAxis + m_intWidth - CInt(Math.Round(CDbl(m_diameter) / 2)), m_intyAxis)
                right.X = rectangleF.Right - CSng(m_diameter)
                objGraphics.DrawArc(pen, right, 270.0!, 90.0!)
                objGraphics.DrawLine(pen, m_intxAxis + m_intWidth, m_intyAxis + CInt(Math.Round(CDbl(m_diameter) / 2)), m_intxAxis + m_intWidth, m_intyAxis + m_intHeight - CInt(Math.Round(CDbl(m_diameter) / 2)))
                right.Y = rectangleF.Bottom - CSng(m_diameter)
                objGraphics.DrawArc(pen, right, 0!, 90.0!)
                objGraphics.DrawLine(pen, m_intxAxis + CInt(Math.Round(CDbl(m_diameter) / 2)), m_intyAxis + m_intHeight, m_intxAxis + m_intWidth - CInt(Math.Round(CDbl(m_diameter) / 2)), m_intyAxis + m_intHeight)
                right.X = rectangleF.Left
                objGraphics.DrawArc(pen, right, 90.0!, 90.0!)
                objGraphics.DrawLine(pen, m_intxAxis, m_intyAxis + CInt(Math.Round(CDbl(m_diameter) / 2)), m_intxAxis, m_intyAxis + m_intHeight - CInt(Math.Round(CDbl(m_diameter) / 2)))
            Catch exception As System.Exception
            End Try
        End Sub

        Protected Overrides Sub Initialize(ByVal toolStrip As System.Windows.Forms.ToolStrip)
            Try
                MyBase.Initialize(toolStrip)
                If (TypeOf toolStrip Is MenuStrip) Then
                    toolStrip.ForeColor = Me.ForColor
                    toolStrip.BackColor = Me.backColorStrip
                ElseIf (TypeOf toolStrip Is ToolStripDropDownMenu) Then
                    toolStrip.ForeColor = Me.ForColor
                    toolStrip.BackColor = Me.backColor
                ElseIf (TypeOf toolStrip Is System.Windows.Forms.ToolStrip) Then
                    toolStrip.ForeColor = Me.ForColor
                    toolStrip.BackColor = Me.backColor
                End If
                toolStrip.Font = Me.MyFont
                toolStrip.Padding = New Padding(5, 2, 5, 2)
            Catch exception As System.Exception
            End Try
        End Sub

        Protected Overrides Sub OnRenderArrow(ByVal e As ToolStripArrowRenderEventArgs)
            Try
                If (e.Item.Selected) Then
                    If (e.Item.Enabled) Then
                        e.ArrowColor = Me.ArrowselectedColor
                    Else
                        e.ArrowColor = Me.ENBArrowselectedColor
                    End If
                ElseIf (e.Item.Enabled) Then
                    e.ArrowColor = Me.ArrowColor
                Else
                    e.ArrowColor = Me.ENBArrowselectedColor
                End If
                MyBase.OnRenderArrow(e)
            Catch exception As System.Exception
            End Try
        End Sub

        Protected Overrides Sub OnRenderImageMargin(ByVal e As ToolStripRenderEventArgs)
            Try
                MyBase.OnRenderImageMargin(e)
                Dim selectedColor As Color = Me.selected_Color
                Dim solidBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me.ColorLines0)
                Dim solidBrush1 As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Me.ColorLines1)
                Dim affectedBounds As System.Drawing.Rectangle = e.AffectedBounds
                Dim width As Integer = affectedBounds.Width + 0
                affectedBounds = e.AffectedBounds
                Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(width, 2, 1, affectedBounds.Height)
                affectedBounds = e.AffectedBounds
                Dim num As Integer = affectedBounds.Width + 1
                affectedBounds = e.AffectedBounds
                Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(num, 2, 1, affectedBounds.Height)
                Dim pen As System.Drawing.Pen = New System.Drawing.Pen(selectedColor)
                e.Graphics.FillRectangle(solidBrush, rectangle)
                e.Graphics.FillRectangle(solidBrush1, rectangle1)
                e.ToolStrip.BackColor = Me.backColor
            Catch exception As System.Exception
            End Try
        End Sub

        Protected Overrides Sub OnRenderItemCheck(ByVal e As ToolStripItemImageRenderEventArgs)
            Try
                MyBase.OnRenderItemCheck(e)
                Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(4, 3, e.Item.Height - 5, e.Item.Height - 6)
                Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(rectangle, Me.backColor, Me.backColor, LinearGradientMode.Vertical)
                e.Graphics.FillRectangle(linearGradientBrush, rectangle)
                Me.DrawRoundedRectangle(e.Graphics, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height, 1, Me.backColor)
                e.Graphics.DrawImage(Store.Bitmap_0("ToolStrip\Check"), New Point(4, 3))
            Catch exception As System.Exception
            End Try
        End Sub

        Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
            Try
                If (Not TypeOf e.ToolStrip Is ToolStripDropDownMenu) Then
                    If (TypeOf e.ToolStrip Is MenuStrip) Then
                        If (If(e.Item.IsOnDropDown, True, Not e.Item.Selected)) Then
                            If (e.Item.Enabled) Then
                                If (e.Item.Pressed) Then
                                    Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, e.Item.Width - 1, e.Item.Height)
                                    Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(rectangle, Me.backColor, Me.backColor, LinearGradientMode.Vertical)
                                    e.Graphics.FillRectangle(linearGradientBrush, rectangle)
                                    Me.DrawRoundedRectangle(e.Graphics, rectangle.Left, rectangle.Top, rectangle.Width - 1, rectangle.Height - 1, 1, Me.ColorBorder)
                                End If
                            End If
                            e.Item.ForeColor = Me.ForColor
                        Else
                            If (e.Item.Enabled) Then
                                If (Not e.Item.Pressed) Then
                                    Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, e.Item.Width - 1, e.Item.Height)
                                    Dim linearGradientBrush1 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(rectangle1, Me.selected_Color, Me.selected_Color, LinearGradientMode.Vertical)
                                    e.Graphics.FillRectangle(linearGradientBrush1, rectangle1)
                                    Me.DrawRoundedRectangle(e.Graphics, rectangle1.Left, rectangle1.Top, rectangle1.Width - 1, rectangle1.Height - 1, 1, Me.clrSelectedBorder)
                                Else
                                    Dim rectangle2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, e.Item.Width - 1, e.Item.Height)
                                    Dim linearGradientBrush2 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(rectangle2, Me.backColor, Me.backColor, LinearGradientMode.Vertical)
                                    e.Graphics.FillRectangle(linearGradientBrush2, rectangle2)
                                    Me.DrawRoundedRectangle(e.Graphics, rectangle2.Left, rectangle2.Top, rectangle2.Width - 1, rectangle2.Height - 1, 1, Me.ColorBorder)
                                End If
                            End If
                            e.Item.ForeColor = Me.selected_Color_ForColor
                        End If
                    End If
                ElseIf (Not e.Item.Selected) Then
                    e.Item.ForeColor = Me.ForColor
                ElseIf (e.Item.Enabled) Then
                    Dim rectangle3 As System.Drawing.Rectangle = New System.Drawing.Rectangle(1, 0, e.Item.Width - 1, e.Item.Height)
                    Dim linearGradientBrush3 As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(rectangle3, Me.selected_Color, Me.selected_Color, LinearGradientMode.Vertical)
                    e.Graphics.FillRectangle(linearGradientBrush3, rectangle3)
                    Me.DrawRoundedRectangle(e.Graphics, rectangle3.Left, rectangle3.Top, rectangle3.Width - 1, rectangle3.Height - 1, 1, Me.clrSelectedBorder)
                    e.Item.ForeColor = Me.selected_Color_ForColor
                End If
            Catch exception As System.Exception
            End Try
        End Sub

        Protected Overrides Sub OnRenderSeparator(ByVal e As ToolStripSeparatorRenderEventArgs)
            If (If(e.Vertical OrElse Not TypeOf e.Item Is ToolStripSeparator, False, Not Me.UseDefaultSeperatorStyle)) Then
                Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(Point.Empty, e.Item.Size)
                Dim num As Integer = CInt(Math.Round(CDbl(rectangle.Bottom) - CDbl(rectangle.Height) / 2 - 1))
                Dim left As Integer = rectangle.Left + 30
                Dim right As Integer = rectangle.Right - 10
                e.Graphics.DrawLine(New Pen(New SolidBrush(Me.ColorLines0)), left, num, right, num)
                e.Graphics.DrawLine(New Pen(New SolidBrush(Me.ColorLines1)), left, num + 1, right, num + 1)
            Else
                MyBase.OnRenderSeparator(e)
            End If
        End Sub

        Protected Overrides Sub OnRenderToolStripBorder(ByVal e As ToolStripRenderEventArgs)
            If (TypeOf e.ToolStrip Is ToolStripDropDownMenu) Then
                Dim pen As System.Drawing.Pen = New System.Drawing.Pen(Me.ColorBorder, 1.0!)
                e.Graphics.DrawRectangle(pen, 0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1)
            End If
        End Sub
    End Class
End Namespace