<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileBox
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
        Me.PNL3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThemeTextBox1 = New SpyNote_V6._4.SN.ThemeTextBox()
        Me.BTNCancel = New SpyNote_V6._4.SN.ThemeButton()
        Me.BTNSAVE = New SpyNote_V6._4.SN.ThemeButton()
        Me.PNL1 = New System.Windows.Forms.Panel()
        Me.ONLICON = New System.Windows.Forms.Panel()
        Me.BTNUserProfile = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine4 = New SpyNote_V6._4.SN.LinearLine()
        Me.BTNDocuments = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine2 = New SpyNote_V6._4.SN.LinearLine()
        Me.BTNVideos = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine1 = New SpyNote_V6._4.SN.LinearLine()
        Me.BTNPictures = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.LinearLine3 = New SpyNote_V6._4.SN.LinearLine()
        Me.BTNDESK = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.BTNback = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.TEXTPATH = New SpyNote_V6._4.SN.ThemeTextBox()
        Me.BtnNext = New SpyNote_V6._4.SN.ThemeButtonImge()
        Me.VisualStudioVerticalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioVerticalScrollBar()
        Me.BoxView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TScrolls = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.PNL3.SuspendLayout()
        Me.PNL1.SuspendLayout()
        Me.ONLICON.SuspendLayout()
        CType(Me.BoxView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL3
        '
        Me.PNL3.Controls.Add(Me.Label1)
        Me.PNL3.Controls.Add(Me.ThemeTextBox1)
        Me.PNL3.Controls.Add(Me.BTNCancel)
        Me.PNL3.Controls.Add(Me.BTNSAVE)
        Me.PNL3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNL3.Location = New System.Drawing.Point(0, 398)
        Me.PNL3.Name = "PNL3"
        Me.PNL3.Size = New System.Drawing.Size(405, 45)
        Me.PNL3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name:"
        '
        'ThemeTextBox1
        '
        Me.ThemeTextBox1.__CLRXX_S = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ThemeTextBox1.__CLRXX_SLave = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThemeTextBox1._CBorderEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ThemeTextBox1._CBorderEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ThemeTextBox1._CBorderEnter0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ThemeTextBox1._CBorderEnter1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ThemeTextBox1._CBorderLave0_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ThemeTextBox1._CBorderLave1_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ThemeTextBox1._CVK_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ThemeTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.ThemeTextBox1.Btnshow = False
        Me.ThemeTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemeTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ThemeTextBox1.Location = New System.Drawing.Point(54, 13)
        Me.ThemeTextBox1.MaxLength = 32767
        Me.ThemeTextBox1.Multiline = False
        Me.ThemeTextBox1.Name = "ThemeTextBox1"
        Me.ThemeTextBox1.ReadOnly = False
        Me.ThemeTextBox1.Size = New System.Drawing.Size(120, 19)
        Me.ThemeTextBox1.TabIndex = 12
        Me.ThemeTextBox1.Text = "TextName"
        Me.ThemeTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.ThemeTextBox1.UseSystemPasswordChar = False
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCancel.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BTNCancel.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BTNCancel.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BTNCancel.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BTNCancel.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNCancel.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNCancel.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNCancel.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNCancel.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNCancel.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNCancel.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.BTNCancel.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.BTNCancel.ImageChoice = Nothing
        Me.BTNCancel.Location = New System.Drawing.Point(191, 8)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.ShowImage = False
        Me.BTNCancel.ShowText = True
        Me.BTNCancel.Size = New System.Drawing.Size(100, 28)
        Me.BTNCancel.TabIndex = 11
        Me.BTNCancel.Tag = ""
        Me.BTNCancel.Text = "Cancel"
        Me.BTNCancel.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNCancel.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNCancel.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNCancel.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'BTNSAVE
        '
        Me.BTNSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNSAVE.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BTNSAVE.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BTNSAVE.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BTNSAVE.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BTNSAVE.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNSAVE.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNSAVE.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNSAVE.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNSAVE.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNSAVE.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNSAVE.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNSAVE.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.BTNSAVE.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.BTNSAVE.ImageChoice = Nothing
        Me.BTNSAVE.Location = New System.Drawing.Point(297, 8)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.ShowImage = False
        Me.BTNSAVE.ShowText = True
        Me.BTNSAVE.Size = New System.Drawing.Size(100, 28)
        Me.BTNSAVE.TabIndex = 10
        Me.BTNSAVE.Tag = ""
        Me.BTNSAVE.Text = "OK"
        Me.BTNSAVE.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNSAVE.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNSAVE.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNSAVE.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'PNL1
        '
        Me.PNL1.Controls.Add(Me.ONLICON)
        Me.PNL1.Controls.Add(Me.BTNback)
        Me.PNL1.Controls.Add(Me.TEXTPATH)
        Me.PNL1.Controls.Add(Me.BtnNext)
        Me.PNL1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL1.Location = New System.Drawing.Point(0, 0)
        Me.PNL1.Name = "PNL1"
        Me.PNL1.Size = New System.Drawing.Size(405, 51)
        Me.PNL1.TabIndex = 1
        '
        'ONLICON
        '
        Me.ONLICON.Controls.Add(Me.BTNUserProfile)
        Me.ONLICON.Controls.Add(Me.LinearLine4)
        Me.ONLICON.Controls.Add(Me.BTNDocuments)
        Me.ONLICON.Controls.Add(Me.LinearLine2)
        Me.ONLICON.Controls.Add(Me.BTNVideos)
        Me.ONLICON.Controls.Add(Me.LinearLine1)
        Me.ONLICON.Controls.Add(Me.BTNPictures)
        Me.ONLICON.Controls.Add(Me.LinearLine3)
        Me.ONLICON.Controls.Add(Me.BTNDESK)
        Me.ONLICON.Location = New System.Drawing.Point(6, 25)
        Me.ONLICON.Name = "ONLICON"
        Me.ONLICON.Size = New System.Drawing.Size(396, 20)
        Me.ONLICON.TabIndex = 15
        '
        'BTNUserProfile
        '
        Me.BTNUserProfile.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNUserProfile.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BTNUserProfile.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNUserProfile.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNUserProfile.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNUserProfile.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNUserProfile.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNUserProfile.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNUserProfile.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNUserProfile.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNUserProfile.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNUserProfile.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNUserProfile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNUserProfile.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BTNUserProfile.ImageChoice = Nothing
        Me.BTNUserProfile.Location = New System.Drawing.Point(112, 0)
        Me.BTNUserProfile.Name = "BTNUserProfile"
        Me.BTNUserProfile.ShowImage = False
        Me.BTNUserProfile.ShowText = False
        Me.BTNUserProfile.Size = New System.Drawing.Size(20, 20)
        Me.BTNUserProfile.TabIndex = 23
        Me.BTNUserProfile.Text = "ThemeButtonImge1"
        Me.BTNUserProfile.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNUserProfile.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNUserProfile.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNUserProfile.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine4
        '
        Me.LinearLine4.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine4.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine4.Location = New System.Drawing.Point(104, 0)
        Me.LinearLine4.Name = "LinearLine4"
        Me.LinearLine4.Size = New System.Drawing.Size(8, 20)
        Me.LinearLine4.TabIndex = 22
        Me.LinearLine4.Text = "LinearLine4"
        '
        'BTNDocuments
        '
        Me.BTNDocuments.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNDocuments.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BTNDocuments.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDocuments.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDocuments.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNDocuments.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNDocuments.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDocuments.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDocuments.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNDocuments.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNDocuments.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNDocuments.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNDocuments.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNDocuments.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BTNDocuments.ImageChoice = Nothing
        Me.BTNDocuments.Location = New System.Drawing.Point(84, 0)
        Me.BTNDocuments.Name = "BTNDocuments"
        Me.BTNDocuments.ShowImage = False
        Me.BTNDocuments.ShowText = False
        Me.BTNDocuments.Size = New System.Drawing.Size(20, 20)
        Me.BTNDocuments.TabIndex = 21
        Me.BTNDocuments.Text = "ThemeButtonImge1"
        Me.BTNDocuments.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNDocuments.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNDocuments.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNDocuments.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine2
        '
        Me.LinearLine2.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine2.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine2.Location = New System.Drawing.Point(76, 0)
        Me.LinearLine2.Name = "LinearLine2"
        Me.LinearLine2.Size = New System.Drawing.Size(8, 20)
        Me.LinearLine2.TabIndex = 20
        Me.LinearLine2.Text = "LinearLine2"
        '
        'BTNVideos
        '
        Me.BTNVideos.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNVideos.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BTNVideos.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNVideos.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNVideos.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNVideos.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNVideos.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNVideos.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNVideos.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNVideos.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNVideos.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNVideos.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNVideos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNVideos.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BTNVideos.ImageChoice = Nothing
        Me.BTNVideos.Location = New System.Drawing.Point(56, 0)
        Me.BTNVideos.Name = "BTNVideos"
        Me.BTNVideos.ShowImage = False
        Me.BTNVideos.ShowText = False
        Me.BTNVideos.Size = New System.Drawing.Size(20, 20)
        Me.BTNVideos.TabIndex = 19
        Me.BTNVideos.Text = "ThemeButtonImge1"
        Me.BTNVideos.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNVideos.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNVideos.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNVideos.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine1
        '
        Me.LinearLine1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine1.Location = New System.Drawing.Point(48, 0)
        Me.LinearLine1.Name = "LinearLine1"
        Me.LinearLine1.Size = New System.Drawing.Size(8, 20)
        Me.LinearLine1.TabIndex = 18
        Me.LinearLine1.Text = "LinearLine1"
        '
        'BTNPictures
        '
        Me.BTNPictures.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNPictures.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BTNPictures.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNPictures.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNPictures.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNPictures.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNPictures.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNPictures.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNPictures.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNPictures.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNPictures.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNPictures.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNPictures.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNPictures.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BTNPictures.ImageChoice = Nothing
        Me.BTNPictures.Location = New System.Drawing.Point(28, 0)
        Me.BTNPictures.Name = "BTNPictures"
        Me.BTNPictures.ShowImage = False
        Me.BTNPictures.ShowText = False
        Me.BTNPictures.Size = New System.Drawing.Size(20, 20)
        Me.BTNPictures.TabIndex = 17
        Me.BTNPictures.Text = "ThemeButtonImge1"
        Me.BTNPictures.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNPictures.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNPictures.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNPictures.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LinearLine3
        '
        Me.LinearLine3.Colour0 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine3.Colour1 = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinearLine3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinearLine3.Location = New System.Drawing.Point(20, 0)
        Me.LinearLine3.Name = "LinearLine3"
        Me.LinearLine3.Size = New System.Drawing.Size(8, 20)
        Me.LinearLine3.TabIndex = 16
        Me.LinearLine3.Text = "LinearLine1"
        '
        'BTNDESK
        '
        Me.BTNDESK.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNDESK.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BTNDESK.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDESK.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDESK.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNDESK.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNDESK.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDESK.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNDESK.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNDESK.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNDESK.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNDESK.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNDESK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNDESK.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BTNDESK.ImageChoice = Nothing
        Me.BTNDESK.Location = New System.Drawing.Point(0, 0)
        Me.BTNDESK.Name = "BTNDESK"
        Me.BTNDESK.ShowImage = False
        Me.BTNDESK.ShowText = False
        Me.BTNDESK.Size = New System.Drawing.Size(20, 20)
        Me.BTNDESK.TabIndex = 15
        Me.BTNDESK.Text = "ThemeButtonImge1"
        Me.BTNDESK.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNDESK.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNDESK.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNDESK.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'BTNback
        '
        Me.BTNback.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNback.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BTNback.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNback.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNback.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BTNback.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNback.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNback.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNback.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BTNback.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BTNback.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNback.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNback.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BTNback.ImageChoice = Nothing
        Me.BTNback.Location = New System.Drawing.Point(7, 1)
        Me.BTNback.Name = "BTNback"
        Me.BTNback.ShowImage = False
        Me.BTNback.ShowText = False
        Me.BTNback.Size = New System.Drawing.Size(20, 20)
        Me.BTNback.TabIndex = 14
        Me.BTNback.Text = "ThemeButtonImge1"
        Me.BTNback.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BTNback.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BTNback.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BTNback.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'TEXTPATH
        '
        Me.TEXTPATH.__CLRXX_S = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TEXTPATH.__CLRXX_SLave = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TEXTPATH._CBorderEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEXTPATH._CBorderEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEXTPATH._CBorderEnter0_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEXTPATH._CBorderEnter1_S = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEXTPATH._CBorderLave0_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TEXTPATH._CBorderLave1_S = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TEXTPATH._CVK_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TEXTPATH.BackColor = System.Drawing.Color.Transparent
        Me.TEXTPATH.Btnshow = False
        Me.TEXTPATH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEXTPATH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TEXTPATH.Location = New System.Drawing.Point(62, 1)
        Me.TEXTPATH.MaxLength = 32767
        Me.TEXTPATH.Multiline = False
        Me.TEXTPATH.Name = "TEXTPATH"
        Me.TEXTPATH.ReadOnly = False
        Me.TEXTPATH.Size = New System.Drawing.Size(331, 19)
        Me.TEXTPATH.TabIndex = 13
        Me.TEXTPATH.Text = "%PATH%"
        Me.TEXTPATH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TEXTPATH.UseSystemPasswordChar = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnNext.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnNext.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnNext.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnNext.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnNext.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnNext.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnNext.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnNext.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BtnNext.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnNext.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnNext.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnNext.ImageAlignment = SpyNote_V6._4.SN.ThemeButtonImge.__ImageAlignment.Left
        Me.BtnNext.ImageChoice = Nothing
        Me.BtnNext.Location = New System.Drawing.Point(36, 1)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.ShowImage = False
        Me.BtnNext.ShowText = False
        Me.BtnNext.Size = New System.Drawing.Size(20, 20)
        Me.BtnNext.TabIndex = 0
        Me.BtnNext.Text = "ThemeButtonImge1"
        Me.BtnNext.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BtnNext.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnNext.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnNext.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
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
        Me.VisualStudioVerticalScrollBar1.Location = New System.Drawing.Point(395, 51)
        Me.VisualStudioVerticalScrollBar1.Maximum = 1
        Me.VisualStudioVerticalScrollBar1.Minimum = 0
        Me.VisualStudioVerticalScrollBar1.Name = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioVerticalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioVerticalScrollBar1.Size = New System.Drawing.Size(10, 347)
        Me.VisualStudioVerticalScrollBar1.SmallChange = 10
        Me.VisualStudioVerticalScrollBar1.TabIndex = 6
        Me.VisualStudioVerticalScrollBar1.Text = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.Value = 0
        '
        'BoxView1
        '
        Me.BoxView1.AllowUserToAddRows = False
        Me.BoxView1.AllowUserToDeleteRows = False
        Me.BoxView1.AllowUserToResizeColumns = False
        Me.BoxView1.AllowUserToResizeRows = False
        Me.BoxView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BoxView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BoxView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BoxView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BoxView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BoxView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BoxView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BoxView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Size})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BoxView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.BoxView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.BoxView1.EnableHeadersVisualStyles = False
        Me.BoxView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BoxView1.Location = New System.Drawing.Point(0, 51)
        Me.BoxView1.MultiSelect = False
        Me.BoxView1.Name = "BoxView1"
        Me.BoxView1.RowHeadersVisible = False
        Me.BoxView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BoxView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BoxView1.ShowCellToolTips = False
        Me.BoxView1.Size = New System.Drawing.Size(395, 347)
        Me.BoxView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Image"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 46
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.Width = 63
        '
        'Size
        '
        Me.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        '
        'TScrolls
        '
        Me.TScrolls.Interval = 1
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'FileBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 443)
        Me.Controls.Add(Me.BoxView1)
        Me.Controls.Add(Me.VisualStudioVerticalScrollBar1)
        Me.Controls.Add(Me.PNL1)
        Me.Controls.Add(Me.PNL3)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(416, 222)
        Me.Name = "FileBox"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileBox"
        Me.PNL3.ResumeLayout(False)
        Me.PNL3.PerformLayout()
        Me.PNL1.ResumeLayout(False)
        Me.ONLICON.ResumeLayout(False)
        CType(Me.BoxView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL3 As Panel
    Friend WithEvents BTNSAVE As SN.ThemeButton
    Friend WithEvents BTNCancel As SN.ThemeButton
    Friend WithEvents ThemeTextBox1 As SN.ThemeTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PNL1 As Panel
    Friend WithEvents BtnNext As SN.ThemeButtonImge
    Friend WithEvents TEXTPATH As SN.ThemeTextBox
    Friend WithEvents ONLICON As Panel
    Friend WithEvents BTNPictures As SN.ThemeButtonImge
    Friend WithEvents LinearLine3 As SN.LinearLine
    Friend WithEvents BTNDESK As SN.ThemeButtonImge
    Friend WithEvents BTNback As SN.ThemeButtonImge
    Friend WithEvents BTNVideos As SN.ThemeButtonImge
    Friend WithEvents LinearLine1 As SN.LinearLine
    Friend WithEvents BTNUserProfile As SN.ThemeButtonImge
    Friend WithEvents LinearLine4 As SN.LinearLine
    Friend WithEvents BTNDocuments As SN.ThemeButtonImge
    Friend WithEvents LinearLine2 As SN.LinearLine
    Friend WithEvents VisualStudioVerticalScrollBar1 As SN.VisualStudioVerticalScrollBar
    Friend WithEvents BoxView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents TScrolls As Timer
    Friend WithEvents Trans As Timer
End Class
