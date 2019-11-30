Namespace SN
    Friend Module ThemeShare46546
        Private Frames As Integer

        Private Invalidate As Boolean

        Public ThemeTimer As PrecisionTimer

        Private Const FPS As Integer = 50

        Private Const Rate As Integer = 50

        Private Callbacks As List(Of ThemeShare46546.AnimationDelegate)

        Sub New()
            ThemeShare46546.ThemeTimer = New PrecisionTimer()
            ThemeShare46546.Callbacks = New List(Of ThemeShare46546.AnimationDelegate)()
        End Sub

        Public Sub AddAnimationCallback(ByVal callback As ThemeShare46546.AnimationDelegate)
            SyncLock ThemeShare46546.Callbacks
                If (Not ThemeShare46546.Callbacks.Contains(callback)) Then
                    ThemeShare46546.Callbacks.Add(callback)
                    ThemeShare46546.InvalidateThemeTimer()
                Else
                    Return
                End If
            End SyncLock
        End Sub

        Private Sub HandleCallbacks(ByVal state As IntPtr, ByVal reserve As Boolean)
            ThemeShare46546.Invalidate = ThemeShare46546.Frames >= 50
            If (ThemeShare46546.Invalidate) Then
                ThemeShare46546.Frames = 0
            End If
            SyncLock ThemeShare46546.Callbacks
                Dim count As Integer = ThemeShare46546.Callbacks.Count - 1
                For i As Integer = 0 To count Step 1
                    ThemeShare46546.Callbacks(i)(ThemeShare46546.Invalidate)
                Next

            End SyncLock
            ThemeShare46546.Frames = ThemeShare46546.Frames + 50
        End Sub

        Private Sub InvalidateThemeTimer()
            Dim flag As Boolean = ThemeShare46546.Callbacks.Count = 0
            If flag Then
                ThemeShare46546.ThemeTimer.Delete()
            Else
                ThemeShare46546.ThemeTimer.Create(0UI, 50UI, AddressOf ThemeShare46546.HandleCallbacks)
            End If
        End Sub

        Public Sub RemoveAnimationCallback(ByVal callback As ThemeShare46546.AnimationDelegate)
            SyncLock ThemeShare46546.Callbacks
                If (ThemeShare46546.Callbacks.Contains(callback)) Then
                    ThemeShare46546.Callbacks.Remove(callback)
                    ThemeShare46546.InvalidateThemeTimer()
                Else
                    Return
                End If
            End SyncLock
        End Sub

        Public Delegate Sub AnimationDelegate(ByVal invalidate As Boolean)
    End Module
End Namespace