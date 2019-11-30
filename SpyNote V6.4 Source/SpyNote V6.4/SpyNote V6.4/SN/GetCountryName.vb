Imports Microsoft.VisualBasic.CompilerServices
Imports System

Namespace SN
	Public Module GetCountryName
		Public Function GetCountryName(ByVal ipc As String) As String
			Return Data.GeoIP0.LookupCountryName(ipc.Trim())
		End Function
	End Module
End Namespace