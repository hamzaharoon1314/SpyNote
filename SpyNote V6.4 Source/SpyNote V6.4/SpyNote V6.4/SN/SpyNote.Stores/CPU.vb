Imports System.Threading

Namespace SN.SpyNote.Stores
    Public Class CPU
        Public Threading_0 As Thread

        Public bBoolean As Boolean

        Private cpuUsage As PerformanceCounter

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub StartThread()
            Me.Threading_0 = New Thread(New ThreadStart(AddressOf Me.ThreadingCPU)) With
            {
                .IsBackground = True
            }
            Me.Threading_0.Start()
        End Sub

        Private Sub SubCPUAndMem(ByVal ParametersString0 As String, ByVal ParametersString1 As String, ByVal ParametersString2 As String)
            If (Not Data.SpyNote.IsDisposed) Then
                If (Not Data.SpyNote.InvokeRequired) Then
                    Data.SpyNote.GView.Rows(2).Cells(2).Value = ParametersString0
                    Data.SpyNote.GView.Rows(3).Cells(2).Value = ParametersString1
                    Data.SpyNote.GView.Rows(4).Cells(2).Value = ParametersString2
                Else
                    Data.SpyNote.Invoke(New CPU.Delegate0(AddressOf Me.SubCPUAndMem), New String() {ParametersString0, ParametersString1, ParametersString2})
                End If
            End If
        End Sub

        Private Sub ThreadingCPU()
            Try
                Me.cpuUsage = New PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName)
                While Me.bBoolean
                    Thread.Sleep(1000)
                    Dim [single] As Single = Convert.ToSingle(CInt(Math.Round(CDbl((Me.cpuUsage.NextValue() / CSng(Environment.ProcessorCount))))))
                    Dim str As String = String.Format("{0:0.00}%", [single])
                    Dim num As Long = CLng(Math.Round(CDbl(Process.GetCurrentProcess().PagedMemorySize64) / 1024))
                    Dim str1 As String = String.Format("{0:0,0}K", num)
                    Dim num1 As Long = CLng(Math.Round(CDbl(Process.GetCurrentProcess().WorkingSet64) / 1024))
                    Dim str2 As String = String.Format("{0:0,0}K", num1)
                    Me.SubCPUAndMem(str, str1, str2)
                End While
            Catch exception As System.Exception
                Return
            End Try
        End Sub

        Public Delegate Sub Delegate0(ByVal ParametersString0 As String, ByVal ParametersString1 As String, ByVal ParametersString2 As String)
    End Class
End Namespace