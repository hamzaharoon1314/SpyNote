Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class NameChat
    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOK.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
    Private Sub NameChat_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\25.ico"))
        Me.aName.HTBTB.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class