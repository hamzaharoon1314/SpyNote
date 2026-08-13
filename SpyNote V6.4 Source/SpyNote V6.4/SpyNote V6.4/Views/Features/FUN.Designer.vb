<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUN
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
        Me.ProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        Me.PNLERRORS = New System.Windows.Forms.Panel()
        Me.LBER = New System.Windows.Forms.Label()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Track1 = New SpyNote_V6._4.SN.Track()
        Me.ThemeButton2 = New SpyNote_V6._4.SN.ThemeButton()
        Me.ThemeButton3 = New SpyNote_V6._4.SN.ThemeButton()
        Me.BtnToast = New SpyNote_V6._4.SN.ThemeButton()
        Me.TextToast = New SpyNote_V6._4.SN.ThemeTextBox()
        Me.Vib = New SpyNote_V6._4.SN.ThemeTextBox()
        Me.ThemeSeparator1 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.ThemeSeparator2 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.PNLERRORS.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Animated = True
        Me.ProgressBar1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ProgressBar1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ProgressBar1.Customization = "AAAAAAAAAAAAAAAAAAAAAA=="
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ProgressBar1.Image = Nothing
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 282)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 10)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
        '
        'PNLERRORS
        '
        Me.PNLERRORS.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PNLERRORS.Controls.Add(Me.LBER)
        Me.PNLERRORS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLERRORS.Location = New System.Drawing.Point(0, 263)
        Me.PNLERRORS.Name = "PNLERRORS"
        Me.PNLERRORS.Size = New System.Drawing.Size(424, 19)
        Me.PNLERRORS.TabIndex = 3
        Me.PNLERRORS.Visible = False
        '
        'LBER
        '
        Me.LBER.AutoSize = True
        Me.LBER.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBER.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LBER.Location = New System.Drawing.Point(0, 0)
        Me.LBER.Name = "LBER"
        Me.LBER.Size = New System.Drawing.Size(37, 15)
        Me.LBER.TabIndex = 0
        Me.LBER.Text = "Errors"
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LBL1.Location = New System.Drawing.Point(12, 9)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(35, 15)
        Me.LBL1.TabIndex = 4
        Me.LBL1.Text = "Toast"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Vibrator"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(109, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ms"
        '
        'Track1
        '
        Me.Track1.DrawValueString = False
        Me.Track1.JumpToMouse = False
        Me.Track1.Location = New System.Drawing.Point(166, 162)
        Me.Track1.Maximum = 10000
        Me.Track1.Minimum = 0
        Me.Track1.MinimumSize = New System.Drawing.Size(47, 35)
        Me.Track1.Name = "Track1"
        Me.Track1.Size = New System.Drawing.Size(176, 35)
        Me.Track1.TabIndex = 7
        Me.Track1.Text = "Track1"
        Me.Track1.Value = 1000
        Me.Track1.ValueDivison = SpyNote_V6._4.SN.Track.ValueDivisor.By1
        Me.Track1.ValueToSet = 1000.0!
        '
        'ThemeButton2
        '
        Me.ThemeButton2.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton2.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton2.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton2.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton2.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton2.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton2.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton2.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton2.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ThemeButton2.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton2.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ThemeButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton2.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton2.ImageChoice = Nothing
        Me.ThemeButton2.Location = New System.Drawing.Point(272, 203)
        Me.ThemeButton2.Name = "ThemeButton2"
        Me.ThemeButton2.ShowImage = False
        Me.ThemeButton2.ShowText = True
        Me.ThemeButton2.Size = New System.Drawing.Size(100, 28)
        Me.ThemeButton2.TabIndex = 9
        Me.ThemeButton2.Tag = ""
        Me.ThemeButton2.Text = "On"
        Me.ThemeButton2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton2.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemeButton2.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeButton2.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'ThemeButton3
        '
        Me.ThemeButton3.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton3.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton3.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton3.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton3.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton3.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton3.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton3.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton3.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ThemeButton3.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton3.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ThemeButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton3.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton3.ImageChoice = Nothing
        Me.ThemeButton3.Location = New System.Drawing.Point(166, 203)
        Me.ThemeButton3.Name = "ThemeButton3"
        Me.ThemeButton3.ShowImage = False
        Me.ThemeButton3.ShowText = True
        Me.ThemeButton3.Size = New System.Drawing.Size(100, 28)
        Me.ThemeButton3.TabIndex = 10
        Me.ThemeButton3.Tag = ""
        Me.ThemeButton3.Text = "Off"
        Me.ThemeButton3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton3.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemeButton3.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeButton3.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'BtnToast
        '
        Me.BtnToast.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnToast.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnToast.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnToast.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnToast.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnToast.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnToast.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnToast.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnToast.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BtnToast.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnToast.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnToast.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.BtnToast.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.BtnToast.ImageChoice = Nothing
        Me.BtnToast.Location = New System.Drawing.Point(272, 74)
        Me.BtnToast.Name = "BtnToast"
        Me.BtnToast.ShowImage = False
        Me.BtnToast.ShowText = True
        Me.BtnToast.Size = New System.Drawing.Size(100, 28)
        Me.BtnToast.TabIndex = 11
        Me.BtnToast.Tag = ""
        Me.BtnToast.Text = "Show"
        Me.BtnToast.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BtnToast.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnToast.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnToast.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'TextToast
        '
        Me.TextToast.__CLRXX_S = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TextToast.__CLRXX_SLave = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextToast._CBorderEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextToast._CBorderEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextToast._CBorderEnter0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextToast._CBorderEnter1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextToast._CBorderLave0_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextToast._CBorderLave1_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextToast._CVK_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextToast.BackColor = System.Drawing.Color.Transparent
        Me.TextToast.Btnshow = False
        Me.TextToast.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextToast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TextToast.Location = New System.Drawing.Point(50, 37)
        Me.TextToast.MaxLength = 32767
        Me.TextToast.Multiline = False
        Me.TextToast.Name = "TextToast"
        Me.TextToast.ReadOnly = False
        Me.TextToast.Size = New System.Drawing.Size(322, 19)
        Me.TextToast.TabIndex = 12
        Me.TextToast.Text = "SPY \n NOTE"
        Me.TextToast.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextToast.UseSystemPasswordChar = False
        '
        'Vib
        '
        Me.Vib.__CLRXX_S = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Vib.__CLRXX_SLave = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Vib._CBorderEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Vib._CBorderEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Vib._CBorderEnter0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Vib._CBorderEnter1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Vib._CBorderLave0_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Vib._CBorderLave1_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Vib._CVK_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Vib.BackColor = System.Drawing.Color.Transparent
        Me.Vib.Btnshow = False
        Me.Vib.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vib.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Vib.Location = New System.Drawing.Point(50, 165)
        Me.Vib.MaxLength = 32767
        Me.Vib.Multiline = False
        Me.Vib.Name = "Vib"
        Me.Vib.ReadOnly = False
        Me.Vib.Size = New System.Drawing.Size(58, 19)
        Me.Vib.TabIndex = 13
        Me.Vib.Text = "1000"
        Me.Vib.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.Vib.UseSystemPasswordChar = False
        '
        'ThemeSeparator1
        '
        Me.ThemeSeparator1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeSeparator1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeSeparator1.Location = New System.Drawing.Point(-19, 113)
        Me.ThemeSeparator1.Name = "ThemeSeparator1"
        Me.ThemeSeparator1.Size = New System.Drawing.Size(451, 10)
        Me.ThemeSeparator1.TabIndex = 14
        Me.ThemeSeparator1.Text = "ThemeSeparator1"
        '
        'ThemeSeparator2
        '
        Me.ThemeSeparator2.Colour0 = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeSeparator2.Colour1 = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeSeparator2.Location = New System.Drawing.Point(-19, 248)
        Me.ThemeSeparator2.Name = "ThemeSeparator2"
        Me.ThemeSeparator2.Size = New System.Drawing.Size(451, 10)
        Me.ThemeSeparator2.TabIndex = 15
        Me.ThemeSeparator2.Text = "ThemeSeparator2"
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'FUN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(424, 292)
        Me.Controls.Add(Me.ThemeSeparator2)
        Me.Controls.Add(Me.ThemeSeparator1)
        Me.Controls.Add(Me.Vib)
        Me.Controls.Add(Me.TextToast)
        Me.Controls.Add(Me.BtnToast)
        Me.Controls.Add(Me.ThemeButton3)
        Me.Controls.Add(Me.ThemeButton2)
        Me.Controls.Add(Me.Track1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL1)
        Me.Controls.Add(Me.PNLERRORS)
        Me.Controls.Add(Me.ProgressBar1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FUN"
        Me.Text = "FUN"
        Me.PNLERRORS.ResumeLayout(False)
        Me.PNLERRORS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents PNLERRORS As Panel
    Friend WithEvents LBER As Label
    Friend WithEvents LBL1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Track1 As SN.Track
    Friend WithEvents ThemeButton2 As SN.ThemeButton
    Friend WithEvents ThemeButton3 As SN.ThemeButton
    Friend WithEvents BtnToast As SN.ThemeButton
    Friend WithEvents TextToast As SN.ThemeTextBox
    Friend WithEvents Vib As SN.ThemeTextBox
    Friend WithEvents ThemeSeparator1 As SN.ThemeSeparator
    Friend WithEvents ThemeSeparator2 As SN.ThemeSeparator
    Friend WithEvents Trans As Timer
    Friend WithEvents TProgressBar As Timer
End Class
