Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN

Public Class LogoSN
    Public F As Integer

    Private sr As String

    Public Pont As Point

    Private MOV_X As Integer

    Private MOV_Y As Integer

    Public Sub New()
        Me.F = -1
        Me.sr = Nothing
        Me.InitializeComponent()
        genr.nx = Me
    End Sub
    Public Function GetDriveSerialNumber() As String
        Dim num As Integer
        Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""))
        Dim objArray(0) As Object
        Dim obj As Object = objectValue
        Dim objArray1(0) As Object
        Dim startupPath As String = Application.StartupPath
        Dim obj1 As Object = startupPath
        objArray1(0) = startupPath
        objArray(0) = NewLateBinding.LateGet(obj, Nothing, "GetDriveName", objArray1, Nothing, Nothing, Nothing)
        Dim objArray2 As Object() = objArray
        Dim flagArray() As Boolean = {True}
        Dim flagArray1 As Boolean() = flagArray
        Dim obj2 As Object = NewLateBinding.LateGet(objectValue, Nothing, "GetDrive", objArray, Nothing, Nothing, flagArray)
        If (flagArray1(0)) Then
            NewLateBinding.LateSetComplex(obj, Nothing, "GetDriveName", New Object() {obj1, objArray2(0)}, Nothing, Nothing, True, False)
        End If
        Dim objectValue1 As Object = RuntimeHelpers.GetObjectValue(obj2)
        num = If(Not Conversions.ToBoolean(NewLateBinding.LateGet(objectValue1, Nothing, "IsReady", New Object(-1) {}, Nothing, Nothing, Nothing)), -1, Conversions.ToInteger(NewLateBinding.LateGet(objectValue1, Nothing, "SerialNumber", New Object(-1) {}, Nothing, Nothing, Nothing)))
        objectValue1 = Nothing
        Return num.ToString("X2")
    End Function

    Public Function GetRegistryValue(ByVal KeyName As String, Optional ByVal DefaultValue As Object = Nothing) As Object
        Dim objectValue As Object = Nothing
        Try
            Dim registryKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\spynote", True)
            If (registryKey IsNot Nothing) Then
                objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(KeyName, RuntimeHelpers.GetObjectValue(DefaultValue)))
            End If
            If (registryKey IsNot Nothing) Then
                registryKey.Close()
            End If
        Catch exception As System.Exception
        End Try
        Return objectValue
    End Function

    Private Function hosts(ByVal p As String) As Boolean
        Dim flag As Boolean
        Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
        If (File.Exists(p)) Then
            stringBuilder.Append(File.ReadAllText(p))
            If (stringBuilder.ToString().Contains("import.systems")) Then
                flag = False
                Return flag
            ElseIf (stringBuilder.ToString().Contains("185.127.25.40")) Then
                flag = False
                Return flag
            End If
        End If
        flag = True
        Return flag
    End Function
    Private Sub LogoSN_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            If (Not Me.hosts("C:\Windows\System32\drivers\etc")) Then
                End
            End If
        Catch exception As System.Exception
            End
        End Try
        Try
            If (Me.GetRegistryValue("spynote", Nothing) Is Nothing) Then
                Me.SetRegistryValue("spynote", "0")
            End If
            If (Me.GetRegistryValue("patch", Nothing) Is Nothing) Then
                Me.SetRegistryValue("patch", "0")
            End If
            If (Me.GetRegistryValue("path", Nothing) Is Nothing) Then
                Me.SetRegistryValue("path", Application.StartupPath)
            End If
            Me.sr = Me.GetDriveSerialNumber()
            Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf genr.ce))
            thread.Start()
            Me.Trans.Enabled = True
        Catch exception1 As System.Exception
        End Try
    End Sub

    Private Sub LogoSN_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseClick
        If (Not (Me.MOV_X >= MyBase.ClientSize.Width - 25 And Me.MOV_Y <= 15)) Then
            Try
                My.Computer.Clipboard.SetText(Me.sr)
            Catch exception As System.Exception

            End Try
        Else
            Try
                Application.ExitThread()
                ProjectData.EndApp()
            Catch exception1 As System.Exception
                ProjectData.EndApp()
            End Try
        End If
    End Sub

    Private Sub LogoSN_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Me.Pont = e.Location
        End If
    End Sub

    Private Sub LogoSN_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            MyBase.Location = MyBase.Location + CType((e.Location - CType(Me.Pont, System.Drawing.Size)), System.Drawing.Size)
        End If
        Me.MOV_X = e.X
        Me.MOV_Y = e.Y
    End Sub

    Private Sub LogoSN_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Me.Paint
        Dim bitmap As System.Drawing.Bitmap = Store.Bitmap_0("Logo\logo")
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.DrawImage(bitmap, New Rectangle(1, 1, bitmap.Width, bitmap.Height))
        Dim graphics As System.Drawing.Graphics = e.Graphics
        Dim solidBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(72, 72, 76))
        Dim clientSize As System.Drawing.Size = MyBase.ClientSize
        graphics.FillEllipse(solidBrush, clientSize.Width - 20, 5, 10, 10)
        Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(72, 72, 76)
        Dim clientRectangle As Rectangle = MyBase.ClientRectangle
        ControlPaint.DrawBorder(e.Graphics, clientRectangle, color, ButtonBorderStyle.Solid)
        Dim font As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, FontStyle.Regular)
        Dim font1 As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 8.75!, FontStyle.Regular)
        Dim font2 As System.Drawing.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, FontStyle.Regular)
        Dim brush As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(224, 224, 224))
        Dim solidBrush1 As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(224, 224, 224))
        Dim brush1 As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(150, 150, 150))
        Dim solidBrush2 As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(224, 224, 224))
        e.Graphics.DrawString("Spy", font, brush, 8.0!, 10.0!)
        e.Graphics.DrawString("Note", font, solidBrush1, 30.0!, 10.0!)
        e.Graphics.DrawString("Remote Access Android - V6.4", font1, solidBrush2, 8.0!, 30.0!)
        If (Me.F = -1) Then
            e.Graphics.DrawString("Please wait ...", font1, solidBrush1, 8.0!, 55.0!)
            e.Graphics.DrawString("Connecting To Server : ( Checking ID )", font1, solidBrush1, 8.0!, 70.0!)
        ElseIf (Me.F = 0) Then
            e.Graphics.DrawString("Connecting To Server : ( ID Not Activated )", font1, New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 128, 128)), 8.0!, 55.0!)
            e.Graphics.DrawString(String.Concat(New String() {"ID:(", Me.sr, ")", Strings.Space(1), "copy"}), font1, New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(77, 178, 250)), 8.0!, 70.0!)
            e.Graphics.DrawString("Please copy the ID and send it to us for activation", font1, solidBrush1, 8.0!, 85.0!)
        ElseIf (Me.F = 1) Then
            Me.F = 2
            e.Graphics.DrawString("Connecting To Server : ( ID Activated )", font1, New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(78, 201, 176)), 8.0!, 55.0!)
            Me.OK.Enabled = True
        End If
        e.Graphics.DrawString("copyright © 2018 spynote all rights reserved", font2, brush1, 8.0!, CSng((MyBase.Height - 50)))
        Dim color1 As System.Drawing.Color = System.Drawing.Color.FromArgb(72, 72, 76)
        Dim color2 As System.Drawing.Color = System.Drawing.Color.FromArgb(72, 72, 76)
        Dim num As Integer = 8
        Dim num1 As Integer = 50
        e.Graphics.DrawLine(New Pen(color1), num, num1, MyBase.Width - num, num1)
        e.Graphics.DrawLine(New Pen(color2), num, num1 + 1, MyBase.Width - num, num1 + 1)
    End Sub

    Private Sub OK_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Tick
        Me.OK.Enabled = False
        genr.nx.Hide()
        My.Forms.MainSpyNote.Show()
    End Sub

    Public Sub SetRegistryValue(ByVal KeyName As String, ByVal _Value As Object)
        Try
            Dim registryKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\spynote", True)
            If (registryKey Is Nothing) Then
                registryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\spynote")
                registryKey.SetValue(KeyName, RuntimeHelpers.GetObjectValue(_Value))
            Else
                registryKey.SetValue(KeyName, RuntimeHelpers.GetObjectValue(_Value))
            End If
            If (registryKey IsNot Nothing) Then
                registryKey.Close()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class