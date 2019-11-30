Imports System.Runtime.InteropServices

Namespace SN
    Public Class WindowsApi
        Private Declare Ansi Function FlashWindowEx Lib "User32" (ByRef fwInfo As WindowsApi.FLASHWINFO) As Boolean

        Public Shared Function FlashWindow(ByRef handle As IntPtr, FlashTitleBar As Boolean, FlashTray As Boolean, FlashCount As Integer) As Boolean
            Dim result As Boolean
            If handle = 0 Then
                result = False
            Else
                Try
                    Dim flashwinfo As WindowsApi.FLASHWINFO = Nothing
                    flashwinfo.hwnd = handle
                    If FlashTitleBar Then
                        flashwinfo.dwFlags = flashwinfo.dwFlags Or WindowsApi.FlashWindowFlags.FLASHW_CAPTION
                    End If
                    If FlashTray Then
                        flashwinfo.dwFlags = flashwinfo.dwFlags Or WindowsApi.FlashWindowFlags.FLASHW_TRAY
                    End If
                    flashwinfo.uCount = CUInt(FlashCount)
                    If FlashCount = 0 Then
                        flashwinfo.dwFlags = flashwinfo.dwFlags Or WindowsApi.FlashWindowFlags.FLASHW_TIMERNOFG
                    End If
                    flashwinfo.dwTimeout = 0UI
                    flashwinfo.cbSize = CUInt(Marshal.SizeOf(flashwinfo))
                    result = WindowsApi.FlashWindowEx(flashwinfo)
                Catch ex As Exception
                    result = False
                End Try
            End If
            Return result
        End Function

        Public Enum FlashWindowFlags As UInteger
            FLASHW_STOP
            FLASHW_CAPTION
            FLASHW_TRAY
            FLASHW_ALL
            FLASHW_TIMER
            FLASHW_TIMERNOFG = 12UI
        End Enum

        Public Structure FLASHWINFO
            Public cbSize As UInteger

            Public hwnd As IntPtr

            Public dwFlags As WindowsApi.FlashWindowFlags

            Public uCount As UInteger

            Public dwTimeout As UInteger
        End Structure
    End Class
End Namespace
