Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SN
	Public Class ToolTip_0
		Inherits Control
		Public MyFont As System.Drawing.Font
        Public __ToolTip As ToolTip
        Public Overridable Property _ToolTip As ToolTip
            <CompilerGenerated()>
            Get
                Return Me.__ToolTip
            End Get
            <CompilerGenerated()>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(value As ToolTip)
                Dim value2 As PopupEventHandler = AddressOf Me._ToolTip1_Popup
                Dim value3 As DrawToolTipEventHandler = AddressOf Me.ToolTip1_Draw
                Dim _ToolTip As ToolTip = Me.__ToolTip
                If _ToolTip IsNot Nothing Then
                    RemoveHandler _ToolTip.Popup, value2
                    RemoveHandler _ToolTip.Draw, value3
                End If
                Me.__ToolTip = value
                _ToolTip = Me.__ToolTip
                If _ToolTip IsNot Nothing Then
                    AddHandler _ToolTip.Popup, value2
                    AddHandler _ToolTip.Draw, value3
                End If
            End Set
        End Property

        Public Sub New()
			MyBase.New()
			Me.MyFont = New System.Drawing.Font("Segoe UI Semibold", 8.25!, FontStyle.Regular)
			Me._ToolTip = New System.Windows.Forms.ToolTip()
			Dim toolTip As System.Windows.Forms.ToolTip = Me._ToolTip
			Me._ToolTip.Active = True
			Me._ToolTip.UseAnimation = True
			Me._ToolTip.UseFading = True
			Me._ToolTip.AutomaticDelay = 100
			Me._ToolTip.AutoPopDelay = 18000
			Me._ToolTip.OwnerDraw = True
			Me._ToolTip.BackColor = Color.FromArgb(255, 45, 45, 48)
			toolTip = Nothing
			AddHandler Me._ToolTip.Popup,  New PopupEventHandler(AddressOf Me._ToolTip1_Popup)
			AddHandler Me._ToolTip.Draw,  New DrawToolTipEventHandler(AddressOf Me.ToolTip1_Draw)
		End Sub

		Private Sub _ToolTip1_Popup(ByVal sender As Object, ByVal e As PopupEventArgs)
			Dim width As System.Drawing.Size = TextRenderer.MeasureText(Me._ToolTip.GetToolTip(DirectCast(e.AssociatedWindow, Control)), Me.MyFont)
			width.Width = width.Width + 16
			width.Height = width.Height + 10
			e.ToolTipSize = width
		End Sub

		Private Sub ToolTip1_Draw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
			e.DrawBackground()
			Dim width As Integer = e.Bounds.Width
			Dim bounds As System.Drawing.Rectangle = e.Bounds
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, width, bounds.Height)
			ControlPaint.DrawBorder(e.Graphics, rectangle, Color.FromArgb(32, 146, 255), ButtonBorderStyle.Solid)
			Using stringFormat As System.Drawing.StringFormat = New System.Drawing.StringFormat()
				stringFormat.Alignment = StringAlignment.Near
				stringFormat.LineAlignment = StringAlignment.Center
				Dim num As Integer = e.Bounds.Width
				bounds = e.Bounds
				Dim rectangle1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, num, bounds.Height)
				e.Graphics.MeasureString(e.ToolTipText, Me.MyFont)
				e.Graphics.DrawString(e.ToolTipText, Me.MyFont, New SolidBrush(Color.FromArgb(241, 241, 241)), rectangle1, stringFormat)
			End Using
		End Sub
	End Class
End Namespace