<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Testconnection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ThemeButton1 = New SpyNote_V6._4.SN.ThemeButton()
        Me.TEXTIP = New System.Windows.Forms.TextBox()
        Me.TEXTPORT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackNumcont = New SpyNote_V6._4.SN.Track()
        Me.Tracktimed = New SpyNote_V6._4.SN.Track()
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(4, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "IP"
        '
        'ThemeButton1
        '
        Me.ThemeButton1.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton1.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton1.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton1.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton1.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton1.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton1.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton1.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton1.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ThemeButton1.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton1.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ThemeButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton1.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton1.ImageChoice = Nothing
        Me.ThemeButton1.Location = New System.Drawing.Point(221, 258)
        Me.ThemeButton1.Name = "ThemeButton1"
        Me.ThemeButton1.ShowImage = False
        Me.ThemeButton1.ShowText = True
        Me.ThemeButton1.Size = New System.Drawing.Size(100, 23)
        Me.ThemeButton1.TabIndex = 6
        Me.ThemeButton1.Text = "OK"
        Me.ThemeButton1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton1.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'TEXTIP
        '
        Me.TEXTIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TEXTIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TEXTIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TEXTIP.Location = New System.Drawing.Point(7, 27)
        Me.TEXTIP.Name = "TEXTIP"
        Me.TEXTIP.Size = New System.Drawing.Size(314, 20)
        Me.TEXTIP.TabIndex = 7
        Me.TEXTIP.Text = "127.0.0.1"
        '
        'TEXTPORT
        '
        Me.TEXTPORT.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TEXTPORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TEXTPORT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TEXTPORT.Location = New System.Drawing.Point(7, 71)
        Me.TEXTPORT.Name = "TEXTPORT"
        Me.TEXTPORT.Size = New System.Drawing.Size(314, 20)
        Me.TEXTPORT.TabIndex = 9
        Me.TEXTPORT.Text = "3210"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Timed out"
        '
        'TrackNumcont
        '
        Me.TrackNumcont.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TrackNumcont.DrawValueString = False
        Me.TrackNumcont.JumpToMouse = False
        Me.TrackNumcont.Location = New System.Drawing.Point(7, 124)
        Me.TrackNumcont.Maximum = 30
        Me.TrackNumcont.Minimum = 0
        Me.TrackNumcont.MinimumSize = New System.Drawing.Size(47, 22)
        Me.TrackNumcont.Name = "TrackNumcont"
        Me.TrackNumcont.Size = New System.Drawing.Size(314, 35)
        Me.TrackNumcont.TabIndex = 12
        Me.TrackNumcont.Text = "Track1"
        Me.TrackNumcont.Value = 25
        Me.TrackNumcont.ValueDivison = SpyNote_V6._4.SN.Track.ValueDivisor.By1
        Me.TrackNumcont.ValueToSet = 25.0!
        '
        'Tracktimed
        '
        Me.Tracktimed.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Tracktimed.DrawValueString = False
        Me.Tracktimed.JumpToMouse = False
        Me.Tracktimed.Location = New System.Drawing.Point(7, 184)
        Me.Tracktimed.Maximum = 30
        Me.Tracktimed.Minimum = 0
        Me.Tracktimed.MinimumSize = New System.Drawing.Size(47, 22)
        Me.Tracktimed.Name = "Tracktimed"
        Me.Tracktimed.Size = New System.Drawing.Size(314, 35)
        Me.Tracktimed.TabIndex = 13
        Me.Tracktimed.Text = "Track1"
        Me.Tracktimed.Value = 15
        Me.Tracktimed.ValueDivison = SpyNote_V6._4.SN.Track.ValueDivisor.By1
        Me.Tracktimed.ValueToSet = 15.0!
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'Testconnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(329, 289)
        Me.Controls.Add(Me.Tracktimed)
        Me.Controls.Add(Me.TrackNumcont)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TEXTPORT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TEXTIP)
        Me.Controls.Add(Me.ThemeButton1)
        Me.Controls.Add(Me.Label6)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Testconnection"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testconnection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents ThemeButton1 As SN.ThemeButton
    Friend WithEvents TEXTIP As TextBox
    Friend WithEvents TEXTPORT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TrackNumcont As SN.Track
    Friend WithEvents Tracktimed As SN.Track
    Friend WithEvents Trans As Timer
End Class
