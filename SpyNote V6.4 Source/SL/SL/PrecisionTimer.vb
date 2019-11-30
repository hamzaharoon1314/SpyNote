Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Runtime.InteropServices

Namespace spy673
    Friend Class PrecisionTimer
        Implements IDisposable
        Private _Enabled As Boolean

        Private Handle As IntPtr

        Private TimerCallback As PrecisionTimer.TimerDelegate

        Public ReadOnly Property Enabled As Boolean
            Get
                Return Me._Enabled
            End Get
        End Property

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub Create(ByVal dueTime As UInteger, ByVal period As UInteger, ByVal callback As PrecisionTimer.TimerDelegate)
            If (Not Me._Enabled) Then
                Me.TimerCallback = callback
                Dim flag As Boolean = PrecisionTimer.CreateTimerQueueTimer(Me.Handle, IntPtr.Zero, Me.TimerCallback, IntPtr.Zero, dueTime, period, 0)
                If (Not flag) Then
                    Me.ThrowNewException("CreateTimerQueueTimer")
                End If
                Me._Enabled = flag
            End If
        End Sub

        <DllImport("kernel32.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
        Private Shared Function CreateTimerQueueTimer(ByRef handle As IntPtr, ByVal queue As IntPtr, ByVal callback As PrecisionTimer.TimerDelegate, ByVal state As IntPtr, ByVal dueTime As UInteger, ByVal period As UInteger, ByVal flags As UInteger) As Boolean
        End Function

        Public Sub Delete()
            Try
                If (Me._Enabled) Then
                    Dim flag As Boolean = PrecisionTimer.DeleteTimerQueueTimer(IntPtr.Zero, Me.Handle, IntPtr.Zero)
                    If (If(flag, False, Marshal.GetLastWin32Error() <> 997)) Then
                        Me.ThrowNewException("DeleteTimerQueueTimer")
                    End If
                    Me._Enabled = Not flag
                Else
                    Return
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        <DllImport("kernel32.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
        Private Shared Function DeleteTimerQueueTimer(ByVal queue As IntPtr, ByVal handle As IntPtr, ByVal callback As IntPtr) As Boolean
        End Function

        Public Sub Dispose() Implements IDisposable.Dispose
            Me.Delete()
        End Sub

        Private Sub ThrowNewException(ByVal name As String)
            Try
                Throw New System.Exception(String.Format("{0} failed. Win32Error: {1}", name, Marshal.GetLastWin32Error()))
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Delegate Sub TimerDelegate(ByVal r1 As IntPtr, ByVal r2 As Boolean)
    End Class
End Namespace