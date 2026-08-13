<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSManager
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
        Me.BOXDOWN = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ONLICON = New System.Windows.Forms.Panel()
        Me.p6 = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine5 = New SpyNote_V6._4.SN.LinearLine()
        Me.p5 = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine4 = New SpyNote_V6._4.SN.LinearLine()
        Me.p4 = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine2 = New SpyNote_V6._4.SN.LinearLine()
        Me.p3 = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine1 = New SpyNote_V6._4.SN.LinearLine()
        Me.p2 = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine3 = New SpyNote_V6._4.SN.LinearLine()
        Me.p1 = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.ThemeSeparator1 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.ProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        Me.PNLRD = New System.Windows.Forms.Panel()
        Me.PNLRDMSG = New System.Windows.Forms.Panel()
        Me.ThemeButton2 = New SpyNote_V6._4.SN.ThemeButton()
        Me.ThemeButton1 = New SpyNote_V6._4.SN.ThemeButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNDOCK = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNLERRORS = New System.Windows.Forms.Panel()
        Me.LBER = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PCNOTF = New System.Windows.Forms.PictureBox()
        Me.ViewManager = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisualStudioHorizontalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar()
        Me.VisualStudioVerticalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioVerticalScrollBar()
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.TScrolls = New System.Windows.Forms.Timer(Me.components)
        Me.UPTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DwonTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BOXDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ONLICON.SuspendLayout()
        Me.PNLRD.SuspendLayout()
        Me.PNLRDMSG.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLERRORS.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PCNOTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOXDOWN
        '
        Me.BOXDOWN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BOXDOWN.Location = New System.Drawing.Point(0, 429)
        Me.BOXDOWN.Name = "BOXDOWN"
        Me.BOXDOWN.Size = New System.Drawing.Size(755, 18)
        Me.BOXDOWN.TabIndex = 0
        Me.BOXDOWN.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ONLICON)
        Me.Panel1.Controls.Add(Me.ThemeSeparator1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 30)
        Me.Panel1.TabIndex = 1
        '
        'ONLICON
        '
        Me.ONLICON.Controls.Add(Me.p6)
        Me.ONLICON.Controls.Add(Me.LinearLine5)
        Me.ONLICON.Controls.Add(Me.p5)
        Me.ONLICON.Controls.Add(Me.LinearLine4)
        Me.ONLICON.Controls.Add(Me.p4)
        Me.ONLICON.Controls.Add(Me.LinearLine2)
        Me.ONLICON.Controls.Add(Me.p3)
        Me.ONLICON.Controls.Add(Me.LinearLine1)
        Me.ONLICON.Controls.Add(Me.p2)
        Me.ONLICON.Controls.Add(Me.LinearLine3)
        Me.ONLICON.Controls.Add(Me.p1)
        Me.ONLICON.Enabled = False
        Me.ONLICON.Location = New System.Drawing.Point(3, 4)
        Me.ONLICON.Name = "ONLICON"
        Me.ONLICON.Size = New System.Drawing.Size(499, 20)
        Me.ONLICON.TabIndex = 9
        '
        'p6
        '
        Me.p6.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p6.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p6.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p6.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p6.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p6.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p6.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p6.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p6.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p6.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p6.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p6.Dock = System.Windows.Forms.DockStyle.Left
        Me.p6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.p6.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.p6.ImageChoice = Nothing
        Me.p6.Location = New System.Drawing.Point(155, 0)
        Me.p6.Name = "p6"
        Me.p6.ShowImage = False
        Me.p6.ShowText = False
        Me.p6.Size = New System.Drawing.Size(20, 20)
        Me.p6.TabIndex = 10
        Me.p6.Text = "ThemeButtonImge1"
        Me.p6.TextAlignment = System.Drawing.StringAlignment.Center
        Me.p6.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p6.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.p6.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine5
        '
        Me.LinearLine5.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine5.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine5.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine5.Location = New System.Drawing.Point(144, 0)
        Me.LinearLine5.Name = "LinearLine5"
        Me.LinearLine5.Size = New System.Drawing.Size(11, 20)
        Me.LinearLine5.TabIndex = 9
        Me.LinearLine5.Text = "LinearLine5"
        '
        'p5
        '
        Me.p5.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p5.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p5.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p5.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p5.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p5.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p5.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p5.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p5.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p5.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p5.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p5.Dock = System.Windows.Forms.DockStyle.Left
        Me.p5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.p5.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.p5.ImageChoice = Nothing
        Me.p5.Location = New System.Drawing.Point(124, 0)
        Me.p5.Name = "p5"
        Me.p5.ShowImage = False
        Me.p5.ShowText = False
        Me.p5.Size = New System.Drawing.Size(20, 20)
        Me.p5.TabIndex = 8
        Me.p5.Text = "ThemeButtonImge1"
        Me.p5.TextAlignment = System.Drawing.StringAlignment.Center
        Me.p5.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p5.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.p5.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine4
        '
        Me.LinearLine4.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine4.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine4.Location = New System.Drawing.Point(113, 0)
        Me.LinearLine4.Name = "LinearLine4"
        Me.LinearLine4.Size = New System.Drawing.Size(11, 20)
        Me.LinearLine4.TabIndex = 7
        Me.LinearLine4.Text = "LinearLine4"
        '
        'p4
        '
        Me.p4.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p4.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p4.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p4.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p4.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p4.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p4.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p4.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p4.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p4.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p4.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p4.Dock = System.Windows.Forms.DockStyle.Left
        Me.p4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.p4.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.p4.ImageChoice = Nothing
        Me.p4.Location = New System.Drawing.Point(93, 0)
        Me.p4.Name = "p4"
        Me.p4.ShowImage = False
        Me.p4.ShowText = False
        Me.p4.Size = New System.Drawing.Size(20, 20)
        Me.p4.TabIndex = 6
        Me.p4.Text = "ThemeButtonImge1"
        Me.p4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.p4.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p4.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.p4.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine2
        '
        Me.LinearLine2.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine2.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine2.Location = New System.Drawing.Point(82, 0)
        Me.LinearLine2.Name = "LinearLine2"
        Me.LinearLine2.Size = New System.Drawing.Size(11, 20)
        Me.LinearLine2.TabIndex = 5
        Me.LinearLine2.Text = "LinearLine2"
        '
        'p3
        '
        Me.p3.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p3.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p3.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p3.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p3.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p3.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p3.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p3.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p3.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p3.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p3.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p3.Dock = System.Windows.Forms.DockStyle.Left
        Me.p3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.p3.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.p3.ImageChoice = Nothing
        Me.p3.Location = New System.Drawing.Point(62, 0)
        Me.p3.Name = "p3"
        Me.p3.ShowImage = False
        Me.p3.ShowText = False
        Me.p3.Size = New System.Drawing.Size(20, 20)
        Me.p3.TabIndex = 4
        Me.p3.Text = "ThemeButtonImge1"
        Me.p3.TextAlignment = System.Drawing.StringAlignment.Center
        Me.p3.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p3.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.p3.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine1
        '
        Me.LinearLine1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine1.Location = New System.Drawing.Point(51, 0)
        Me.LinearLine1.Name = "LinearLine1"
        Me.LinearLine1.Size = New System.Drawing.Size(11, 20)
        Me.LinearLine1.TabIndex = 3
        Me.LinearLine1.Text = "LinearLine1"
        '
        'p2
        '
        Me.p2.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p2.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p2.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p2.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p2.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p2.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p2.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p2.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p2.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p2.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p2.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p2.Dock = System.Windows.Forms.DockStyle.Left
        Me.p2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.p2.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.p2.ImageChoice = Nothing
        Me.p2.Location = New System.Drawing.Point(31, 0)
        Me.p2.Name = "p2"
        Me.p2.ShowImage = False
        Me.p2.ShowText = False
        Me.p2.Size = New System.Drawing.Size(20, 20)
        Me.p2.TabIndex = 2
        Me.p2.Text = "ThemeButtonImge1"
        Me.p2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.p2.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p2.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.p2.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine3
        '
        Me.LinearLine3.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine3.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine3.Location = New System.Drawing.Point(20, 0)
        Me.LinearLine3.Name = "LinearLine3"
        Me.LinearLine3.Size = New System.Drawing.Size(11, 20)
        Me.LinearLine3.TabIndex = 1
        Me.LinearLine3.Text = "LinearLine1"
        '
        'p1
        '
        Me.p1.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p1.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p1.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p1.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p1.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.p1.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p1.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p1.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.p1.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p1.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.p1.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.p1.Dock = System.Windows.Forms.DockStyle.Left
        Me.p1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.p1.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.p1.ImageChoice = Nothing
        Me.p1.Location = New System.Drawing.Point(0, 0)
        Me.p1.Name = "p1"
        Me.p1.ShowImage = False
        Me.p1.ShowText = False
        Me.p1.Size = New System.Drawing.Size(20, 20)
        Me.p1.TabIndex = 0
        Me.p1.Text = "ThemeButtonImge1"
        Me.p1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.p1.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p1.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.p1.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'ThemeSeparator1
        '
        Me.ThemeSeparator1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ThemeSeparator1.Location = New System.Drawing.Point(0, 20)
        Me.ThemeSeparator1.Name = "ThemeSeparator1"
        Me.ThemeSeparator1.Size = New System.Drawing.Size(755, 10)
        Me.ThemeSeparator1.TabIndex = 8
        Me.ThemeSeparator1.Text = "ThemeSeparator1"
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 419)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(755, 10)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
        '
        'PNLRD
        '
        Me.PNLRD.Controls.Add(Me.PNLRDMSG)
        Me.PNLRD.Controls.Add(Me.Panel2)
        Me.PNLRD.Dock = System.Windows.Forms.DockStyle.Right
        Me.PNLRD.Location = New System.Drawing.Point(427, 30)
        Me.PNLRD.Name = "PNLRD"
        Me.PNLRD.Size = New System.Drawing.Size(328, 389)
        Me.PNLRD.TabIndex = 3
        '
        'PNLRDMSG
        '
        Me.PNLRDMSG.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PNLRDMSG.Controls.Add(Me.ThemeButton2)
        Me.PNLRDMSG.Controls.Add(Me.ThemeButton1)
        Me.PNLRDMSG.Controls.Add(Me.RichTextBox1)
        Me.PNLRDMSG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNLRDMSG.Location = New System.Drawing.Point(0, 44)
        Me.PNLRDMSG.Name = "PNLRDMSG"
        Me.PNLRDMSG.Size = New System.Drawing.Size(328, 345)
        Me.PNLRDMSG.TabIndex = 1
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
        Me.ThemeButton2.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ThemeButton2.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton2.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ThemeButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton2.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton2.ImageChoice = Nothing
        Me.ThemeButton2.Location = New System.Drawing.Point(291, 318)
        Me.ThemeButton2.Name = "ThemeButton2"
        Me.ThemeButton2.ShowImage = False
        Me.ThemeButton2.ShowText = False
        Me.ThemeButton2.Size = New System.Drawing.Size(24, 24)
        Me.ThemeButton2.TabIndex = 8
        Me.ThemeButton2.Tag = ""
        Me.ThemeButton2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton2.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton2.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
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
        Me.ThemeButton1.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ThemeButton1.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemeButton1.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ThemeButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ThemeButton1.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.ThemeButton1.ImageChoice = Nothing
        Me.ThemeButton1.Location = New System.Drawing.Point(291, 290)
        Me.ThemeButton1.Name = "ThemeButton1"
        Me.ThemeButton1.ShowImage = False
        Me.ThemeButton1.ShowText = False
        Me.ThemeButton1.Size = New System.Drawing.Size(24, 24)
        Me.ThemeButton1.TabIndex = 7
        Me.ThemeButton1.Tag = ""
        Me.ThemeButton1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton1.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(328, 345)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BTNDOCK)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 44)
        Me.Panel2.TabIndex = 0
        '
        'BTNDOCK
        '
        Me.BTNDOCK.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNDOCK.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNDOCK.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDOCK.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDOCK.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNDOCK.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNDOCK.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNDOCK.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNDOCK.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNDOCK.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNDOCK.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNDOCK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNDOCK.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BTNDOCK.ImageChoice = Nothing
        Me.BTNDOCK.Location = New System.Drawing.Point(291, 15)
        Me.BTNDOCK.Name = "BTNDOCK"
        Me.BTNDOCK.ShowImage = False
        Me.BTNDOCK.ShowText = False
        Me.BTNDOCK.Size = New System.Drawing.Size(25, 20)
        Me.BTNDOCK.TabIndex = 13
        Me.BTNDOCK.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNDOCK.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNDOCK.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNDOCK.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 33)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(48, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name:"
        '
        'PNLERRORS
        '
        Me.PNLERRORS.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PNLERRORS.Controls.Add(Me.LBER)
        Me.PNLERRORS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLERRORS.Location = New System.Drawing.Point(0, 400)
        Me.PNLERRORS.Name = "PNLERRORS"
        Me.PNLERRORS.Size = New System.Drawing.Size(427, 19)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PCNOTF)
        Me.Panel3.Controls.Add(Me.ViewManager)
        Me.Panel3.Controls.Add(Me.VisualStudioHorizontalScrollBar1)
        Me.Panel3.Controls.Add(Me.VisualStudioVerticalScrollBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(427, 370)
        Me.Panel3.TabIndex = 5
        '
        'PCNOTF
        '
        Me.PCNOTF.ErrorImage = Nothing
        Me.PCNOTF.InitialImage = Nothing
        Me.PCNOTF.Location = New System.Drawing.Point(54, 93)
        Me.PCNOTF.Name = "PCNOTF"
        Me.PCNOTF.Size = New System.Drawing.Size(131, 68)
        Me.PCNOTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCNOTF.TabIndex = 7
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
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewManager.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewManager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
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
        Me.ViewManager.Name = "ViewManager"
        Me.ViewManager.RowHeadersVisible = False
        Me.ViewManager.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ViewManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewManager.ShowCellToolTips = False
        Me.ViewManager.Size = New System.Drawing.Size(417, 360)
        Me.ViewManager.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "Address"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 73
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 63
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 56
        '
        'Column5
        '
        Me.Column5.HeaderText = "Part Of Message"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 117
        '
        'VisualStudioHorizontalScrollBar1
        '
        Me.VisualStudioHorizontalScrollBar1.AmountOfInnerLines = SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar.__InnerLineCount.One
        Me.VisualStudioHorizontalScrollBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ButtonSize = 16
        Me.VisualStudioHorizontalScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VisualStudioHorizontalScrollBar1.LargeChange = 10
        Me.VisualStudioHorizontalScrollBar1.Location = New System.Drawing.Point(0, 360)
        Me.VisualStudioHorizontalScrollBar1.Maximum = 1
        Me.VisualStudioHorizontalScrollBar1.Minimum = 0
        Me.VisualStudioHorizontalScrollBar1.Name = "VisualStudioHorizontalScrollBar1"
        Me.VisualStudioHorizontalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioHorizontalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioHorizontalScrollBar1.Size = New System.Drawing.Size(417, 10)
        Me.VisualStudioHorizontalScrollBar1.SmallChange = 10
        Me.VisualStudioHorizontalScrollBar1.TabIndex = 5
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
        Me.VisualStudioVerticalScrollBar1.Location = New System.Drawing.Point(417, 0)
        Me.VisualStudioVerticalScrollBar1.Maximum = 1
        Me.VisualStudioVerticalScrollBar1.Minimum = 0
        Me.VisualStudioVerticalScrollBar1.Name = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioVerticalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioVerticalScrollBar1.Size = New System.Drawing.Size(10, 370)
        Me.VisualStudioVerticalScrollBar1.SmallChange = 10
        Me.VisualStudioVerticalScrollBar1.TabIndex = 4
        Me.VisualStudioVerticalScrollBar1.Text = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.Value = 0
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'TScrolls
        '
        Me.TScrolls.Interval = 1
        '
        'UPTimer
        '
        Me.UPTimer.Interval = 30
        '
        'DwonTimer
        '
        Me.DwonTimer.Interval = 30
        '
        'SMSManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 447)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PNLERRORS)
        Me.Controls.Add(Me.PNLRD)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BOXDOWN)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(343, 278)
        Me.Name = "SMSManager"
        Me.Opacity = 0R
        Me.Text = "SMSManager"
        CType(Me.BOXDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ONLICON.ResumeLayout(False)
        Me.PNLRD.ResumeLayout(False)
        Me.PNLRDMSG.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLERRORS.ResumeLayout(False)
        Me.PNLERRORS.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PCNOTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BOXDOWN As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ONLICON As Panel
    Friend WithEvents ThemeSeparator1 As SN.ThemeSeparator
    Friend WithEvents p1 As SN.ThemeButtonImge
    Friend WithEvents LinearLine3 As SN.LinearLine
    Friend WithEvents p6 As SN.ThemeButtonImge
    Friend WithEvents LinearLine5 As SN.LinearLine
    Friend WithEvents p5 As SN.ThemeButtonImge
    Friend WithEvents LinearLine4 As SN.LinearLine
    Friend WithEvents p4 As SN.ThemeButtonImge
    Friend WithEvents LinearLine2 As SN.LinearLine
    Friend WithEvents p3 As SN.ThemeButtonImge
    Friend WithEvents LinearLine1 As SN.LinearLine
    Friend WithEvents p2 As SN.ThemeButtonImge
    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents PNLRD As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNDOCK As SN.ThemeButtonImge
    Friend WithEvents PNLRDMSG As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ThemeButton2 As SN.ThemeButton
    Friend WithEvents ThemeButton1 As SN.ThemeButton
    Friend WithEvents PNLERRORS As Panel
    Friend WithEvents LBER As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents VisualStudioVerticalScrollBar1 As SN.VisualStudioVerticalScrollBar
    Friend WithEvents VisualStudioHorizontalScrollBar1 As SN.VisualStudioHorizontalScrollBar
    Friend WithEvents ViewManager As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PCNOTF As PictureBox
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents Trans As Timer
    Friend WithEvents TScrolls As Timer
    Friend WithEvents UPTimer As Timer
    Friend WithEvents DwonTimer As Timer
End Class
