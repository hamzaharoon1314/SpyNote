Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Namespace SN.SpyNote.Stores
    Public Module libIcons
        Private Const SHGFI_ICON As Integer = 256

        Private Const SHGFI_LARGEICON As Integer = 0

        Private Const SHGFI_SMALLICON As Integer = 1

        <DllImport("user32.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
        Private Function DestroyIcon(ByVal hIcon As IntPtr) As Boolean
        End Function

        Public Function GetIcon(ByVal PathName As String, ByVal LargeIco As Boolean) As System.Drawing.Bitmap
            Dim sHFILEINFOW As libIcons.SHFILEINFOW = New libIcons.SHFILEINFOW()
            sHFILEINFOW = New libIcons.SHFILEINFOW()
            If (Not LargeIco) Then
                libIcons.SHGetFileInfoW(PathName, 0, sHFILEINFOW, Marshal.SizeOf(sHFILEINFOW), 257)
            Else
                libIcons.SHGetFileInfoW(PathName, 0, sHFILEINFOW, Marshal.SizeOf(sHFILEINFOW), 256)
            End If
            Dim bitmap As System.Drawing.Bitmap = Icon.FromHandle(sHFILEINFOW.hIcon).ToBitmap()
            libIcons.DestroyIcon(sHFILEINFOW.hIcon)
            Return bitmap
        End Function

        Public Function IconGraphics(ByVal Icon As System.Drawing.Icon) As System.Drawing.Bitmap
            Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Icon.ToBitmap())
            Dim bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap(16, 16)
            Dim graphic As Graphics = Graphics.FromImage(bitmap1)
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphic.DrawImage(bitmap, New Rectangle(0, 0, 16, 16), New Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel)
            graphic.Dispose()
            bitmap.Dispose()
            Return bitmap1
        End Function

        <DllImport("shell32.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
        Private Function SHGetFileInfoW(<InAttribute> ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As libIcons.SHFILEINFOW, ByVal cbFileInfo As Integer, ByVal uFlags As Integer) As Integer
        End Function

        Public Structure SHFILEINFOW
            Public hIcon As IntPtr

            Public iIcon As Integer

            Public dwAttributes As Integer

            Public szDisplayName As String

            Public szTypeName As String
        End Structure
    End Module
End Namespace