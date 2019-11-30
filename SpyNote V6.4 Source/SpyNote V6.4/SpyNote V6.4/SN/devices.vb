Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.InteropServices
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class devices
    Public comd As String

    Public comdPAth As String

    Private isClosed As Boolean

    Public HNDL As Integer

    Private Const WM_COPYDATA As Integer = 74
    Public Sub New()
        Me.isClosed = True
        Me.InitializeComponent()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOK.Click
        Me.okyy()
    End Sub

    Private Sub devices_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Closed
        If (Me.isClosed) Then
            If (My.Forms.MainSpyNote.PublicPID <> -1) Then
                If (Store.FindPID(My.Forms.MainSpyNote.PublicPID)) Then
                    My.Forms.MainSpyNote.PublicPID = -1
                End If
            End If
        End If
    End Sub

    Private Sub devices_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\6.ico"))
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub
    <DllImport("user32.dll", CharSet:=CharSet.None, ExactSpelling:=False, SetLastError:=True)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    Private Sub okyy()
        If (Me.ViewManager.SelectedRows.Count > 0) Then
            For i As Integer = Me.ViewManager.SelectedRows.Count - 1 To 0 Step -1
                Dim str As String = Me.ViewManager.Rows(Me.ViewManager.SelectedRows(i).Index).Cells(1).Tag.ToString()
                Dim str1 As String = ""
                Dim length As Integer = str.Length - 1
                Dim num As Integer = 0
                While num <= length
                    If (Operators.CompareString(Conversions.ToString(str(num)), Strings.Space(1), False) <> 0) Then
                        str1 = String.Concat(str1, Conversions.ToString(str(num)))
                        num = num + 1
                    Else
                        Exit While
                    End If
                End While
                If (Operators.CompareString(Me.comd, "install", False) = 0) Then
                    Me.isClosed = False
                    Me.SendMessageToMain(String.Concat(New String() {"install", My.Forms.MainSpyNote.SPL, Me.comdPAth, My.Forms.MainSpyNote.SPL, str1.Trim()}))
                    MyBase.Close()
                End If
            Next

        End If
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByRef lParam As devices.COPYDATASTRUCT) As IntPtr
    End Function

    Private Sub SendMessageToMain(ByVal msg As String)
        Dim length As devices.COPYDATASTRUCT = New devices.COPYDATASTRUCT()
        Dim hNDL As IntPtr = CType(Me.HNDL, IntPtr)
        length.lpData = msg
        length.cbData = length.lpData.Length + 1
        devices.SendMessage(hNDL, 74, IntPtr.Zero, length)
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        If (My.Forms.MainSpyNote.PublicPID <> -1) Then
            Store.FindPID(My.Forms.MainSpyNote.PublicPID)
        End If
        MyBase.Close()
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub

    Private Sub ViewManager_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles ViewManager.CellMouseDoubleClick
        Me.okyy()
    End Sub

    Private Structure COPYDATASTRUCT
        Public dwData As IntPtr

        Public cbData As Integer

        Public lpData As String
    End Structure
End Class