<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CameraManager
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.STALAB = New SpyNote_V6._4.SN.ThemeButton()
        Me.QUALAB = New SpyNote_V6._4.SN.ThemeCoBox()
        Me.SIZLAB = New SpyNote_V6._4.SN.ThemeCoBox()
        Me.LABMUSH = New System.Windows.Forms.Label()
        Me.BTNMUSht = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.ThemeSeparator3 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.SelCamera = New SpyNote_V6._4.SN.ThemeCoBox()
        Me.LBLZOOM = New System.Windows.Forms.Label()
        Me.BTNMIN = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.BTNZay = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LBFOC = New System.Windows.Forms.Label()
        Me.LBFLMO = New System.Windows.Forms.Label()
        Me.ThemeSeparator2 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.ThemeSeparator1 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.BTNFocus = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.BTNFLASH = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.PNLERRORS = New System.Windows.Forms.Panel()
        Me.LBER = New System.Windows.Forms.Label()
        Me.PBox = New System.Windows.Forms.PictureBox()
        Me.SELCT_QUA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SELCTE_SZ = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SELCT_CAM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.TFPS = New System.Windows.Forms.Timer(Me.components)
        Me.RF = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.TZoom = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.QUALAB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIZLAB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLERRORS.SuspendLayout()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 412)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(634, 10)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.STALAB)
        Me.Panel1.Controls.Add(Me.QUALAB)
        Me.Panel1.Controls.Add(Me.SIZLAB)
        Me.Panel1.Controls.Add(Me.LABMUSH)
        Me.Panel1.Controls.Add(Me.BTNMUSht)
        Me.Panel1.Controls.Add(Me.ThemeSeparator3)
        Me.Panel1.Controls.Add(Me.SelCamera)
        Me.Panel1.Controls.Add(Me.LBLZOOM)
        Me.Panel1.Controls.Add(Me.BTNMIN)
        Me.Panel1.Controls.Add(Me.BTNZay)
        Me.Panel1.Controls.Add(Me.LBFOC)
        Me.Panel1.Controls.Add(Me.LBFLMO)
        Me.Panel1.Controls.Add(Me.ThemeSeparator2)
        Me.Panel1.Controls.Add(Me.ThemeSeparator1)
        Me.Panel1.Controls.Add(Me.BTNFocus)
        Me.Panel1.Controls.Add(Me.BTNFLASH)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(460, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 412)
        Me.Panel1.TabIndex = 1
        '
        'STALAB
        '
        Me.STALAB.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.STALAB.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.STALAB.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.STALAB.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.STALAB.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.STALAB.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.STALAB.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.STALAB.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.STALAB.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.STALAB.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.STALAB.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.STALAB.Enabled = False
        Me.STALAB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.STALAB.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.STALAB.ImageChoice = Nothing
        Me.STALAB.Location = New System.Drawing.Point(39, 301)
        Me.STALAB.Name = "STALAB"
        Me.STALAB.ShowImage = False
        Me.STALAB.ShowText = True
        Me.STALAB.Size = New System.Drawing.Size(100, 28)
        Me.STALAB.TabIndex = 17
        Me.STALAB.Tag = "-1"
        Me.STALAB.Text = "Start"
        Me.STALAB.TextAlignment = System.Drawing.StringAlignment.Center
        Me.STALAB.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.STALAB.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.STALAB.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'QUALAB
        '
        Me.QUALAB.BackColor = System.Drawing.Color.Transparent
        Me.QUALAB.Enabled = False
        Me.QUALAB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.QUALAB.Location = New System.Drawing.Point(3, 55)
        Me.QUALAB.MlinColorovr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QUALAB.MyArrwBackColorOvr = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.QUALAB.MyArrwColorNone = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.QUALAB.MyArrwColorOvr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QUALAB.MyBackColorNone = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.QUALAB.MyBackColorOver = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.QUALAB.MyBordColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.QUALAB.MyFontColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.QUALAB.MylinColorNone = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.QUALAB.Name = "QUALAB"
        Me.QUALAB.Size = New System.Drawing.Size(165, 20)
        Me.QUALAB.TabIndex = 16
        Me.QUALAB.TabStop = False
        Me.QUALAB.TxText = "Quality:"
        '
        'SIZLAB
        '
        Me.SIZLAB.BackColor = System.Drawing.Color.Transparent
        Me.SIZLAB.Enabled = False
        Me.SIZLAB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SIZLAB.Location = New System.Drawing.Point(3, 29)
        Me.SIZLAB.MlinColorovr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SIZLAB.MyArrwBackColorOvr = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SIZLAB.MyArrwColorNone = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SIZLAB.MyArrwColorOvr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SIZLAB.MyBackColorNone = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SIZLAB.MyBackColorOver = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.SIZLAB.MyBordColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SIZLAB.MyFontColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SIZLAB.MylinColorNone = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SIZLAB.Name = "SIZLAB"
        Me.SIZLAB.Size = New System.Drawing.Size(165, 20)
        Me.SIZLAB.TabIndex = 15
        Me.SIZLAB.TabStop = False
        Me.SIZLAB.TxText = "Size:"
        '
        'LABMUSH
        '
        Me.LABMUSH.AutoSize = True
        Me.LABMUSH.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABMUSH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LABMUSH.Location = New System.Drawing.Point(46, 153)
        Me.LABMUSH.Name = "LABMUSH"
        Me.LABMUSH.Size = New System.Drawing.Size(101, 15)
        Me.LABMUSH.TabIndex = 14
        Me.LABMUSH.Text = "Multi-Capture:Off"
        '
        'BTNMUSht
        '
        Me.BTNMUSht.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMUSht.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMUSht.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMUSht.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMUSht.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMUSht.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNMUSht.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMUSht.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMUSht.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNMUSht.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNMUSht.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNMUSht.Enabled = False
        Me.BTNMUSht.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNMUSht.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNMUSht.ImageChoice = Nothing
        Me.BTNMUSht.Location = New System.Drawing.Point(2, 147)
        Me.BTNMUSht.Name = "BTNMUSht"
        Me.BTNMUSht.ShowImage = False
        Me.BTNMUSht.ShowText = False
        Me.BTNMUSht.Size = New System.Drawing.Size(20, 20)
        Me.BTNMUSht.TabIndex = 13
        Me.BTNMUSht.Tag = "0"
        Me.BTNMUSht.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNMUSht.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNMUSht.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNMUSht.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'ThemeSeparator3
        '
        Me.ThemeSeparator3.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator3.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator3.Location = New System.Drawing.Point(25, 256)
        Me.ThemeSeparator3.Name = "ThemeSeparator3"
        Me.ThemeSeparator3.Size = New System.Drawing.Size(126, 10)
        Me.ThemeSeparator3.TabIndex = 11
        Me.ThemeSeparator3.Text = "ThemeSeparator3"
        '
        'SelCamera
        '
        Me.SelCamera.BackColor = System.Drawing.Color.Transparent
        Me.SelCamera.Enabled = False
        Me.SelCamera.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SelCamera.Location = New System.Drawing.Point(3, 3)
        Me.SelCamera.MlinColorovr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelCamera.MyArrwBackColorOvr = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SelCamera.MyArrwColorNone = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SelCamera.MyArrwColorOvr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelCamera.MyBackColorNone = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SelCamera.MyBackColorOver = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.SelCamera.MyBordColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SelCamera.MyFontColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SelCamera.MylinColorNone = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SelCamera.Name = "SelCamera"
        Me.SelCamera.Size = New System.Drawing.Size(165, 20)
        Me.SelCamera.TabIndex = 10
        Me.SelCamera.TabStop = False
        Me.SelCamera.TxText = "Select Camera:"
        '
        'LBLZOOM
        '
        Me.LBLZOOM.AutoSize = True
        Me.LBLZOOM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLZOOM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LBLZOOM.Location = New System.Drawing.Point(66, 227)
        Me.LBLZOOM.Name = "LBLZOOM"
        Me.LBLZOOM.Size = New System.Drawing.Size(63, 15)
        Me.LBLZOOM.TabIndex = 9
        Me.LBLZOOM.Text = "ZOOM:0%"
        '
        'BTNMIN
        '
        Me.BTNMIN.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMIN.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMIN.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMIN.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMIN.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNMIN.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNMIN.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMIN.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNMIN.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNMIN.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNMIN.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNMIN.Enabled = False
        Me.BTNMIN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNMIN.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNMIN.ImageChoice = Nothing
        Me.BTNMIN.Location = New System.Drawing.Point(2, 232)
        Me.BTNMIN.Name = "BTNMIN"
        Me.BTNMIN.ShowImage = False
        Me.BTNMIN.ShowText = False
        Me.BTNMIN.Size = New System.Drawing.Size(20, 20)
        Me.BTNMIN.TabIndex = 8
        Me.BTNMIN.Tag = "0"
        Me.BTNMIN.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNMIN.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNMIN.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNMIN.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'BTNZay
        '
        Me.BTNZay.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNZay.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNZay.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNZay.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNZay.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNZay.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNZay.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNZay.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNZay.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNZay.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNZay.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNZay.Enabled = False
        Me.BTNZay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNZay.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNZay.ImageChoice = Nothing
        Me.BTNZay.Location = New System.Drawing.Point(2, 206)
        Me.BTNZay.Name = "BTNZay"
        Me.BTNZay.ShowImage = False
        Me.BTNZay.ShowText = False
        Me.BTNZay.Size = New System.Drawing.Size(20, 20)
        Me.BTNZay.TabIndex = 7
        Me.BTNZay.Tag = "0"
        Me.BTNZay.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNZay.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNZay.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNZay.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LBFOC
        '
        Me.LBFOC.AutoSize = True
        Me.LBFOC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFOC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LBFOC.Location = New System.Drawing.Point(63, 125)
        Me.LBFOC.Name = "LBFOC"
        Me.LBFOC.Size = New System.Drawing.Size(57, 15)
        Me.LBFOC.TabIndex = 6
        Me.LBFOC.Text = "Foces:Off"
        '
        'LBFLMO
        '
        Me.LBFLMO.AutoSize = True
        Me.LBFLMO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFLMO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LBFLMO.Location = New System.Drawing.Point(50, 99)
        Me.LBFLMO.Name = "LBFLMO"
        Me.LBFLMO.Size = New System.Drawing.Size(88, 15)
        Me.LBFLMO.TabIndex = 5
        Me.LBFLMO.Text = "Flash Mode:Off"
        '
        'ThemeSeparator2
        '
        Me.ThemeSeparator2.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator2.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator2.Location = New System.Drawing.Point(25, 191)
        Me.ThemeSeparator2.Name = "ThemeSeparator2"
        Me.ThemeSeparator2.Size = New System.Drawing.Size(126, 10)
        Me.ThemeSeparator2.TabIndex = 3
        Me.ThemeSeparator2.Text = "ThemeSeparator2"
        '
        'ThemeSeparator1
        '
        Me.ThemeSeparator1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator1.Location = New System.Drawing.Point(25, 79)
        Me.ThemeSeparator1.Name = "ThemeSeparator1"
        Me.ThemeSeparator1.Size = New System.Drawing.Size(126, 10)
        Me.ThemeSeparator1.TabIndex = 2
        Me.ThemeSeparator1.Text = "ThemeSeparator1"
        '
        'BTNFocus
        '
        Me.BTNFocus.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNFocus.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNFocus.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFocus.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFocus.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNFocus.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNFocus.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFocus.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFocus.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNFocus.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNFocus.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNFocus.Enabled = False
        Me.BTNFocus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNFocus.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNFocus.ImageChoice = Nothing
        Me.BTNFocus.Location = New System.Drawing.Point(2, 119)
        Me.BTNFocus.Name = "BTNFocus"
        Me.BTNFocus.ShowImage = False
        Me.BTNFocus.ShowText = False
        Me.BTNFocus.Size = New System.Drawing.Size(20, 20)
        Me.BTNFocus.TabIndex = 1
        Me.BTNFocus.Tag = "0"
        Me.BTNFocus.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNFocus.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNFocus.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNFocus.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'BTNFLASH
        '
        Me.BTNFLASH.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNFLASH.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNFLASH.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFLASH.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFLASH.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNFLASH.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNFLASH.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFLASH.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNFLASH.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNFLASH.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNFLASH.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNFLASH.Enabled = False
        Me.BTNFLASH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNFLASH.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Middle
        Me.BTNFLASH.ImageChoice = Nothing
        Me.BTNFLASH.Location = New System.Drawing.Point(2, 93)
        Me.BTNFLASH.Name = "BTNFLASH"
        Me.BTNFLASH.ShowImage = False
        Me.BTNFLASH.ShowText = False
        Me.BTNFLASH.Size = New System.Drawing.Size(20, 20)
        Me.BTNFLASH.TabIndex = 0
        Me.BTNFLASH.Tag = "0"
        Me.BTNFLASH.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNFLASH.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNFLASH.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNFLASH.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'PNLERRORS
        '
        Me.PNLERRORS.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PNLERRORS.Controls.Add(Me.LBER)
        Me.PNLERRORS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLERRORS.Location = New System.Drawing.Point(0, 393)
        Me.PNLERRORS.Name = "PNLERRORS"
        Me.PNLERRORS.Size = New System.Drawing.Size(460, 19)
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
        'PBox
        '
        Me.PBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBox.Location = New System.Drawing.Point(0, 0)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(460, 393)
        Me.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBox.TabIndex = 4
        Me.PBox.TabStop = False
        '
        'SELCT_QUA
        '
        Me.SELCT_QUA.Name = "SELCT_QUA"
        Me.SELCT_QUA.Size = New System.Drawing.Size(61, 4)
        '
        'SELCTE_SZ
        '
        Me.SELCTE_SZ.Name = "SELCTE_SZ"
        Me.SELCTE_SZ.Size = New System.Drawing.Size(61, 4)
        '
        'SELCT_CAM
        '
        Me.SELCT_CAM.Name = "SELCT_CAM"
        Me.SELCT_CAM.Size = New System.Drawing.Size(61, 4)
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'TFPS
        '
        Me.TFPS.Interval = 1000
        '
        'RF
        '
        Me.RF.Interval = 1
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'TZoom
        '
        Me.TZoom.Interval = 1000
        '
        'CameraManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 422)
        Me.Controls.Add(Me.PBox)
        Me.Controls.Add(Me.PNLERRORS)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(634, 422)
        Me.Name = "CameraManager"
        Me.Opacity = 0R
        Me.Text = "Camera Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.QUALAB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIZLAB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLERRORS.ResumeLayout(False)
        Me.PNLERRORS.PerformLayout()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNFLASH As SN.ThemeButtonImge
    Friend WithEvents ThemeSeparator2 As SN.ThemeSeparator
    Friend WithEvents ThemeSeparator1 As SN.ThemeSeparator
    Friend WithEvents BTNFocus As SN.ThemeButtonImge
    Friend WithEvents LBFLMO As Label
    Friend WithEvents LBLZOOM As Label
    Friend WithEvents BTNMIN As SN.ThemeButtonImge
    Friend WithEvents BTNZay As SN.ThemeButtonImge
    Friend WithEvents LBFOC As Label
    Friend WithEvents SelCamera As SN.ThemeCoBox
    Friend WithEvents QUALAB As SN.ThemeCoBox
    Friend WithEvents SIZLAB As SN.ThemeCoBox
    Friend WithEvents LABMUSH As Label
    Friend WithEvents BTNMUSht As SN.ThemeButtonImge
    Friend WithEvents ThemeSeparator3 As SN.ThemeSeparator
    Friend WithEvents PNLERRORS As Panel
    Friend WithEvents LBER As Label
    Friend WithEvents PBox As PictureBox
    Friend WithEvents SELCT_QUA As ContextMenuStrip
    Friend WithEvents SELCTE_SZ As ContextMenuStrip
    Friend WithEvents SELCT_CAM As ContextMenuStrip
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents TFPS As Timer
    Friend WithEvents RF As Timer
    Friend WithEvents Trans As Timer
    Friend WithEvents TZoom As Timer
    Friend WithEvents STALAB As SN.ThemeButton
End Class
