Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class AboutSpyNote
    Private Sub AboutSpyNote_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Closed
        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub AboutSpyNote_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\19.ico"))
        Me.Text = "About Remote Access SpyNote"
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub
    Private Sub Trans_Tick(sender As Object, e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class