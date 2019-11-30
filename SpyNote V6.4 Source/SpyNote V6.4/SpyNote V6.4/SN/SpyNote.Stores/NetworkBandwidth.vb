Imports System.Net.NetworkInformation

Namespace SN.SpyNote.Stores
    Public Class NetworkBandwidth
        Private Function ArrayNetType(ByVal Arr As NetworkInterfaceType(), ByVal Match As NetworkInterfaceType) As Boolean
            Dim type As NetworkInterfaceType
            For Each type In Arr
                If (type = Match) Then
                    Return True
                End If
            Next
            Return False
        End Function

        Public Function GetNetInteface() As List(Of NetworkInterface)
            Me.Adapters = NetworkInterface.GetAllNetworkInterfaces
            Dim list2 As New List(Of NetworkInterface)
            Dim arr As NetworkInterfaceType() = New NetworkInterfaceType() {NetworkInterfaceType.Ethernet, NetworkInterfaceType.Ppp, NetworkInterfaceType.Wireless80211}
            Dim interface2 As NetworkInterface
            For Each interface2 In Me.Adapters
                If Me.ArrayNetType(arr, interface2.NetworkInterfaceType) Then
                    list2.Add(interface2)
                End If
            Next
            Return list2
        End Function


        Private Adapters As NetworkInterface()
    End Class
End Namespace
