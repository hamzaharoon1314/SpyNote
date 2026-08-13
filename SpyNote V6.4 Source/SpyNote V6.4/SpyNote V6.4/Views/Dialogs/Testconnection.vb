Imports Microsoft.VisualBasic.CompilerServices
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class Testconnection
    Private Sub re()
        Me.Label1.Text = String.Concat("Client (", Conversions.ToString(Me.TrackNumcont.Value), ")")
        Me.Label2.Text = String.Concat("Timed out (", Conversions.ToString(Me.Tracktimed.Value), ") sec")
    End Sub

    Private Sub Testconnection_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\23.ico"))
        Me.TEXTIP.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TEXTPORT.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.re()
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        Dim str As String = String.Concat(Store.Resources(1), "\Imports\T\sS.exe")
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo() With
        {
            .FileName = str,
            .Arguments = String.Concat(New String() {Me.TEXTIP.Text, "|", Me.TEXTPORT.Text, "|", Conversions.ToString(Me.Tracktimed.Value), "|", Conversions.ToString(Me.TrackNumcont.Value)}),
            .WindowStyle = ProcessWindowStyle.Normal
        }
        Process.Start(processStartInfo)
        MyBase.Close()
    End Sub

    Private Sub TrackNumcont_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackNumcont.MouseClick
        Try
            Dim trackNumcont As Track = Me.TrackNumcont
            Dim x As Double = CDbl(e.Location.X)
            Dim size As System.Drawing.Size = Me.TrackNumcont.Size
            trackNumcont.Value = CInt(Math.Round(x / CDbl(size.Width) * CDbl(Me.TrackNumcont.Maximum)))
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub TrackNumcont_ValueChanged()
        Me.re()
    End Sub

    Private Sub Tracktimed_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Tracktimed.MouseClick
        Try
            Dim tracktimed As Track = Me.Tracktimed
            Dim x As Double = CDbl(e.Location.X)
            Dim size As System.Drawing.Size = Me.Tracktimed.Size
            tracktimed.Value = CInt(Math.Round(x / CDbl(size.Width) * CDbl(Me.Tracktimed.Maximum)))
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Tracktimed_ValueChanged()
        Me.re()
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class