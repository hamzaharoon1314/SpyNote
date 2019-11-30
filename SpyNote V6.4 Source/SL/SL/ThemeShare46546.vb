
Namespace spy673
    Friend Module ThemeShare46546
        Private Sub HandleCallbacks(state As IntPtr, reserve As Boolean)
            ThemeShare46546.Invalidate = (ThemeShare46546.Frames >= 50)
            Dim invalidate As Boolean = ThemeShare46546.Invalidate
            If invalidate Then
                ThemeShare46546.Frames = 0
            End If
            Dim callbacks As Object = ThemeShare46546.Callbacks
            SyncLock callbacks
                Dim num As Integer = ThemeShare46546.Callbacks.Count - 1
                For i As Integer = 0 To num
                    ThemeShare46546.Callbacks(i)(ThemeShare46546.Invalidate)
                Next
            End SyncLock
            ThemeShare46546.Frames += 50
        End Sub

        Private Sub InvalidateThemeTimer()
            Dim flag As Boolean = ThemeShare46546.Callbacks.Count = 0
            If flag Then
                ThemeShare46546.ThemeTimer.Delete()
            Else
                ThemeShare46546.ThemeTimer.Create(0UI, 50UI, AddressOf ThemeShare46546.HandleCallbacks)
            End If
        End Sub

        Public Sub AddAnimationCallback(callback As ThemeShare46546.AnimationDelegate)
            Dim callbacks As Object = ThemeShare46546.Callbacks
            SyncLock callbacks
                Dim flag2 As Boolean = ThemeShare46546.Callbacks.Contains(callback)
                If Not flag2 Then
                    ThemeShare46546.Callbacks.Add(callback)
                    ThemeShare46546.InvalidateThemeTimer()
                End If
            End SyncLock
        End Sub

        Public Sub RemoveAnimationCallback(callback As ThemeShare46546.AnimationDelegate)
            Dim callbacks As Object = ThemeShare46546.Callbacks
            SyncLock callbacks
                Dim flag2 As Boolean = Not ThemeShare46546.Callbacks.Contains(callback)
                If Not flag2 Then
                    ThemeShare46546.Callbacks.Remove(callback)
                    ThemeShare46546.InvalidateThemeTimer()
                End If
            End SyncLock
        End Sub

        Private Frames As Integer

        Private Invalidate As Boolean

        Public ThemeTimer As PrecisionTimer = New PrecisionTimer()

        Private Const FPS As Integer = 50

        Private Const Rate As Integer = 50

        Private Callbacks As List(Of ThemeShare46546.AnimationDelegate) = New List(Of ThemeShare46546.AnimationDelegate)()

        Public Delegate Sub AnimationDelegate(invalidate As Boolean)
    End Module
End Namespace
