Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports SpyNote_V6._4.SN.PI

Namespace SN
    <DefaultEvent("ValueChanged")>
    Friend Class Track
        Inherits Control
        Private State As MouseState

        Private PipeBorder As GraphicsPath

        Private FillValue As GraphicsPath

        Private TrackBarHandleRect As Rectangle

        Private Cap As Boolean

        Private ValueDrawer As Integer

        Private ThumbSize As System.Drawing.Size

        Private TrackThumb As Rectangle

        Private _Minimum As Integer

        Private _Maximum As Integer

        Private _Value As Integer

        Private _DrawValueString As Boolean

        Private _JumpToMouse As Boolean

        Private DividedValue As Track.ValueDivisor

        Public Property DrawValueString As Boolean
            Get
                Return Me._DrawValueString
            End Get
            Set(ByVal value As Boolean)
                Me._DrawValueString = value
                If (Not Me._DrawValueString) Then
                    MyBase.Height = 22
                Else
                    MyBase.Height = 35
                End If
                MyBase.Invalidate()
            End Set
        End Property

        Public Property JumpToMouse As Boolean
            Get
                Return Me._JumpToMouse
            End Get
            Set(ByVal value As Boolean)
                Me._JumpToMouse = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Maximum As Integer
            Get
                Return Me._Maximum
            End Get
            Set(ByVal value As Integer)
                If (value <= Me._Minimum) Then
                    value = Me._Minimum + 10
                End If
                If (Me._Value > value) Then
                    Me._Value = value
                End If
                Me._Maximum = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Minimum As Integer
            Get
                Return Me._Minimum
            End Get
            Set(ByVal value As Integer)
                If (value >= Me._Maximum) Then
                    value = Me._Maximum - 10
                End If
                If (Me._Value < value) Then
                    Me._Value = value
                End If
                Me._Minimum = value
                MyBase.Invalidate()
            End Set
        End Property

        Public Property Value As Integer
            Get
                Return Me._Value
            End Get
            Set(ByVal value As Integer)
                If (Me._Value <> value) Then
                    If (value < Me._Minimum) Then
                        Me._Value = Me._Minimum
                    ElseIf (value <= Me._Maximum) Then
                        Me._Value = value
                    Else
                        Me._Value = Me._Maximum
                    End If
                    MyBase.Invalidate()
                    RaiseEvent ValueChanged()
                End If
            End Set
        End Property

        Public Property ValueDivison As Track.ValueDivisor
            Get
                Return Me.DividedValue
            End Get
            Set(ByVal value As Track.ValueDivisor)
                Me.DividedValue = value
                MyBase.Invalidate()
            End Set
        End Property

        <Browsable(False)>
        Public Property ValueToSet As Single
            Get
                Return CSng((CDbl(Me._Value) / CDbl(Me.DividedValue)))
            End Get
            Set(ByVal value As Single)
                Me.Value = CInt(Math.Round(CDbl((value * CSng(Me.DividedValue)))))
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            Me.State = MouseState.None
            Me.ThumbSize = New System.Drawing.Size(15, 15)
            Me._Minimum = 0
            Me._Maximum = 10
            Me._Value = 0
            Me._DrawValueString = False
            Me._JumpToMouse = False
            Me.DividedValue = Track.ValueDivisor.By1
            MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer, True)
            MyBase.Size = New System.Drawing.Size(80, 35)
            Me.MinimumSize = New System.Drawing.Size(47, 35)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Me.ValueDrawer = CInt(Math.Round(CDbl((Me._Value - Me._Minimum)) / CDbl((Me._Maximum - Me._Minimum)) * CDbl((MyBase.Width - 30))))
                Me.TrackBarHandleRect = New Rectangle(Me.ValueDrawer, 0, 25, 25)
                Me.Cap = Me.TrackBarHandleRect.Contains(e.Location)
                MyBase.Focus()
                If (Me._JumpToMouse) Then
                    Me.Value = Me._Minimum + CInt(Math.Round(CDbl((Me._Maximum - Me._Minimum)) * (CDbl(e.X) / CDbl(MyBase.Width))))
                End If
            End If
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            If (If(Not Me.Cap OrElse e.X <= -1, True, e.X >= MyBase.Width + 1)) Then
                Me.State = MouseState.None
            Else
                Me.Value = Me._Minimum + CInt(Math.Round(CDbl((Me._Maximum - Me._Minimum)) * (CDbl(e.X) / CDbl(MyBase.Width))))
                Me.State = MouseState.Down
            End If
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            Me.State = MouseState.None
            Me.Cap = False
            MyBase.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim graphics As System.Drawing.Graphics = e.Graphics
            graphics.Clear(MyBase.Parent.BackColor)
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            Me.TrackThumb = New Rectangle(17, 15, MyBase.Width - 30, 2)
            Me.PipeBorder = RoundRectangle.RoundRect(17, 13, MyBase.Width - 25, 5, 2)
            Try
                Me.ValueDrawer = CInt(Math.Round(CDbl((Me._Value - Me._Minimum)) / CDbl((Me._Maximum - Me._Minimum)) * CDbl((MyBase.Width - 30))))
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.TrackBarHandleRect = New Rectangle(Me.ValueDrawer, 0, 10, 20)
            graphics.SetClip(Me.PipeBorder)
            graphics.FillPath(New SolidBrush(System.Drawing.Color.FromArgb(41, 41, 43)), Me.PipeBorder)
            Me.FillValue = RoundRectangle.RoundRect(17, 13, Me.TrackBarHandleRect.X + Me.TrackBarHandleRect.Width - 10, 5, 2)
            graphics.ResetClip()
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            graphics.DrawPath(New Pen(System.Drawing.Color.FromArgb(63, 63, 70)), Me.PipeBorder)
            Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(32, 146, 255)
            graphics.FillPath(New SolidBrush(color), Me.FillValue)
            graphics.FillEllipse(New SolidBrush(System.Drawing.Color.FromArgb(200, 200, 200)), Me.TrackThumb.X + CInt(Math.Round(CDbl(Me.TrackThumb.Width) * (CDbl(Me.Value) / CDbl(Me.Maximum)))) - CInt(Math.Round(CDbl(Me.ThumbSize.Width) / 2)), Me.TrackThumb.Y + CInt(Math.Round(CDbl(Me.TrackThumb.Height) / 2)) - CInt(Math.Round(CDbl(Me.ThumbSize.Height) / 2)), Me.ThumbSize.Width, Me.ThumbSize.Height)
            If (Me.State <> MouseState.Down) Then
                graphics.DrawEllipse(New Pen(System.Drawing.Color.FromArgb(63, 63, 70)), Me.TrackThumb.X + CInt(Math.Round(CDbl(Me.TrackThumb.Width) * (CDbl(Me.Value) / CDbl(Me.Maximum)))) - CInt(Math.Round(CDbl(Me.ThumbSize.Width) / 2)), Me.TrackThumb.Y + CInt(Math.Round(CDbl(Me.TrackThumb.Height) / 2)) - CInt(Math.Round(CDbl(Me.ThumbSize.Height) / 2)), Me.ThumbSize.Width, Me.ThumbSize.Height)
            Else
                graphics.DrawEllipse(New Pen(System.Drawing.Color.FromArgb(32, 146, 255)), Me.TrackThumb.X + CInt(Math.Round(CDbl(Me.TrackThumb.Width) * (CDbl(Me.Value) / CDbl(Me.Maximum)))) - CInt(Math.Round(CDbl(Me.ThumbSize.Width) / 2)), Me.TrackThumb.Y + CInt(Math.Round(CDbl(Me.TrackThumb.Height) / 2)) - CInt(Math.Round(CDbl(Me.ThumbSize.Height) / 2)), Me.ThumbSize.Width, Me.ThumbSize.Height)
                graphics.DrawEllipse(New Pen(System.Drawing.Color.FromArgb(120, 32, 146, 255), 10.0!), Me.TrackThumb.X + CInt(Math.Round(CDbl(Me.TrackThumb.Width) * (CDbl(Me.Value) / CDbl(Me.Maximum)))) - CInt(Math.Round(CDbl(Me.ThumbSize.Width) / 2)), Me.TrackThumb.Y + CInt(Math.Round(CDbl(Me.TrackThumb.Height) / 2)) - CInt(Math.Round(CDbl(Me.ThumbSize.Height) / 2)), Me.ThumbSize.Width, Me.ThumbSize.Height)
            End If
            If (Me._DrawValueString) Then
                graphics.DrawString(Conversions.ToString(Me.ValueToSet), Me.Font, Brushes.DimGray, 1.0!, 20.0!)
            End If
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            If (Not Me._DrawValueString) Then
                MyBase.Height = 35
            Else
                MyBase.Height = 45
            End If
        End Sub

        Public Event ValueChanged As Track.ValueChangedEventHandler

        Public Delegate Sub ValueChangedEventHandler()

        Public Enum ValueDivisor
            By1 = 1
            By10 = 10
            By100 = 100
            By1000 = 1000
        End Enum
    End Class
End Namespace