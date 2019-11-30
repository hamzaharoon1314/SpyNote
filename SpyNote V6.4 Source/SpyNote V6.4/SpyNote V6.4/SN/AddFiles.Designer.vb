<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFiles
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
        Me.BtnOK = New SpyNote_V6._4.SN.ThemeButton()
        Me.aFileName = New SpyNote_V6._4.SN.ThemeTextBox()
        Me.ThemeSeparator1 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.ThemeSeparator2 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderORfile = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnOK.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnOK.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnOK.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnOK.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnOK.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnOK.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnOK.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnOK.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.BtnOK.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnOK.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BtnOK.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.BtnOK.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.BtnOK.ImageChoice = Nothing
        Me.BtnOK.Location = New System.Drawing.Point(354, 64)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.ShowImage = False
        Me.BtnOK.ShowText = True
        Me.BtnOK.Size = New System.Drawing.Size(100, 23)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "OK"
        Me.BtnOK.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BtnOK.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnOK.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOK.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'aFileName
        '
        Me.aFileName.__CLRXX_S = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.aFileName.__CLRXX_SLave = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.aFileName._CBorderEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.aFileName._CBorderEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.aFileName._CBorderEnter0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.aFileName._CBorderEnter1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.aFileName._CBorderLave0_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.aFileName._CBorderLave1_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.aFileName._CVK_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.aFileName.BackColor = System.Drawing.Color.Transparent
        Me.aFileName.Btnshow = False
        Me.aFileName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.aFileName.Location = New System.Drawing.Point(35, 36)
        Me.aFileName.MaxLength = 32767
        Me.aFileName.Multiline = False
        Me.aFileName.Name = "aFileName"
        Me.aFileName.ReadOnly = False
        Me.aFileName.Size = New System.Drawing.Size(400, 19)
        Me.aFileName.TabIndex = 1
        Me.aFileName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.aFileName.UseSystemPasswordChar = False
        '
        'ThemeSeparator1
        '
        Me.ThemeSeparator1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator1.Location = New System.Drawing.Point(36, 12)
        Me.ThemeSeparator1.Name = "ThemeSeparator1"
        Me.ThemeSeparator1.Size = New System.Drawing.Size(167, 10)
        Me.ThemeSeparator1.TabIndex = 2
        Me.ThemeSeparator1.Text = "ThemeSeparator1"
        '
        'ThemeSeparator2
        '
        Me.ThemeSeparator2.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator2.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator2.Location = New System.Drawing.Point(269, 12)
        Me.ThemeSeparator2.Name = "ThemeSeparator2"
        Me.ThemeSeparator2.Size = New System.Drawing.Size(167, 10)
        Me.ThemeSeparator2.TabIndex = 3
        Me.ThemeSeparator2.Text = "ThemeSeparator2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the file name"
        '
        'FolderORfile
        '
        Me.FolderORfile.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FolderORfile.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FolderORfile.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.FolderORfile.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.FolderORfile.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FolderORfile.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.FolderORfile.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FolderORfile.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FolderORfile.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.FolderORfile.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.FolderORfile.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.FolderORfile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FolderORfile.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.FolderORfile.ImageChoice = Nothing
        Me.FolderORfile.Location = New System.Drawing.Point(328, 68)
        Me.FolderORfile.Name = "FolderORfile"
        Me.FolderORfile.ShowImage = False
        Me.FolderORfile.ShowText = False
        Me.FolderORfile.Size = New System.Drawing.Size(20, 20)
        Me.FolderORfile.TabIndex = 5
        Me.FolderORfile.Tag = "0"
        Me.FolderORfile.TextAlignment = System.Drawing.StringAlignment.Center
        Me.FolderORfile.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FolderORfile.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.FolderORfile.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'AddFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 96)
        Me.Controls.Add(Me.FolderORfile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThemeSeparator2)
        Me.Controls.Add(Me.ThemeSeparator1)
        Me.Controls.Add(Me.aFileName)
        Me.Controls.Add(Me.BtnOK)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddFiles"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddFiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOK As SN.ThemeButton
    Friend WithEvents aFileName As SN.ThemeTextBox
    Friend WithEvents ThemeSeparator1 As SN.ThemeSeparator
    Friend WithEvents ThemeSeparator2 As SN.ThemeSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents FolderORfile As SN.ThemeButtonImge
    Friend WithEvents Trans As Timer
End Class
