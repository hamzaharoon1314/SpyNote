Namespace SN
    Public Module GetFlagThisIp
        Public Function GetFlagThisIp(ByVal ipc As String) As Image
            Dim num As Integer = 0
            Dim num1 As Integer = 0
            Dim upper As String = Data.GeoIP0.LookupCountryCode(ipc.Trim()).ToUpper()
            num = Array.IndexOf(Of String)(Data.GeoIP0.CountryCode, upper)
            num1 = My.Forms.MainSpyNote.imageList_Flags.Images.IndexOfKey(upper)
            Dim num2 As Integer = num
            If (num2 = -1) Then
                num = 0
                num1 = -1
            ElseIf (num2 = CInt(Data.GeoIP0.CountryName.Length)) Then
                num = num - 1
                num1 = -1
            ElseIf (num2 > CInt(Data.GeoIP0.CountryName.Length)) Then
                num = 0
                num1 = -1
            End If
            If (num1 = -1) Then
                num1 = My.Forms.MainSpyNote.imageList_Flags.Images.IndexOfKey("-1".ToUpper())
            End If
            Return My.Forms.MainSpyNote.imageList_Flags.Images(num1)
        End Function
    End Module
End Namespace