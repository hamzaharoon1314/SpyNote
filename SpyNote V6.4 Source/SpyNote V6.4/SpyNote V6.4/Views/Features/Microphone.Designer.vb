<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Microphone
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
        Me.PSoundOutput = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ThemeSeparator1 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.STALAB = New SpyNote_V6._4.SN.ThemeButton()
        Me.LBSampleRate = New SpyNote_V6._4.SN.ThemeCoBox()
        Me.LBAudioSource = New SpyNote_V6._4.SN.ThemeCoBox()
        Me.Transdown = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.TRefresher = New System.Windows.Forms.Timer(Me.components)
        Me.FPTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SELCT_AS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SELCT_SR = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PNLERRORS.SuspendLayout()
        CType(Me.PSoundOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LBSampleRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBAudioSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 197)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(463, 10)
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
        Me.PNLERRORS.Location = New System.Drawing.Point(0, 178)
        Me.PNLERRORS.Name = "PNLERRORS"
        Me.PNLERRORS.Size = New System.Drawing.Size(463, 19)
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
        'PSoundOutput
        '
        Me.PSoundOutput.Dock = System.Windows.Forms.DockStyle.Left
        Me.PSoundOutput.Location = New System.Drawing.Point(0, 0)
        Me.PSoundOutput.Name = "PSoundOutput"
        Me.PSoundOutput.Size = New System.Drawing.Size(281, 178)
        Me.PSoundOutput.TabIndex = 4
        Me.PSoundOutput.TabStop = False
        Me.PSoundOutput.Tag = "281; 175"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ThemeSeparator1)
        Me.Panel1.Controls.Add(Me.STALAB)
        Me.Panel1.Controls.Add(Me.LBSampleRate)
        Me.Panel1.Controls.Add(Me.LBAudioSource)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(281, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 178)
        Me.Panel1.TabIndex = 5
        '
        'ThemeSeparator1
        '
        Me.ThemeSeparator1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator1.Location = New System.Drawing.Point(28, 62)
        Me.ThemeSeparator1.Name = "ThemeSeparator1"
        Me.ThemeSeparator1.Size = New System.Drawing.Size(126, 10)
        Me.ThemeSeparator1.TabIndex = 5
        Me.ThemeSeparator1.Text = "ThemeSeparator1"
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
        Me.STALAB.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.STALAB.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.STALAB.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.STALAB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.STALAB.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.STALAB.ImageChoice = Nothing
        Me.STALAB.Location = New System.Drawing.Point(40, 89)
        Me.STALAB.Name = "STALAB"
        Me.STALAB.ShowImage = False
        Me.STALAB.ShowText = True
        Me.STALAB.Size = New System.Drawing.Size(100, 28)
        Me.STALAB.TabIndex = 4
        Me.STALAB.Tag = "-1"
        Me.STALAB.Text = "Start"
        Me.STALAB.TextAlignment = System.Drawing.StringAlignment.Center
        Me.STALAB.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.STALAB.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.STALAB.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.STALAB.Visible = False
        '
        'LBSampleRate
        '
        Me.LBSampleRate.BackColor = System.Drawing.Color.Transparent
        Me.LBSampleRate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.LBSampleRate.Location = New System.Drawing.Point(8, 7)
        Me.LBSampleRate.MlinColorovr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBSampleRate.MyArrwBackColorOvr = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LBSampleRate.MyArrwColorNone = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LBSampleRate.MyArrwColorOvr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBSampleRate.MyBackColorNone = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LBSampleRate.MyBackColorOver = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LBSampleRate.MyBordColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LBSampleRate.MyFontColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.LBSampleRate.MylinColorNone = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LBSampleRate.Name = "LBSampleRate"
        Me.LBSampleRate.Size = New System.Drawing.Size(166, 20)
        Me.LBSampleRate.TabIndex = 1
        Me.LBSampleRate.TabStop = False
        Me.LBSampleRate.Tag = "0"
        Me.LBSampleRate.TxText = "SampleRate:"
        '
        'LBAudioSource
        '
        Me.LBAudioSource.BackColor = System.Drawing.Color.Transparent
        Me.LBAudioSource.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.LBAudioSource.Location = New System.Drawing.Point(8, 33)
        Me.LBAudioSource.MlinColorovr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBAudioSource.MyArrwBackColorOvr = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LBAudioSource.MyArrwColorNone = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LBAudioSource.MyArrwColorOvr = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBAudioSource.MyBackColorNone = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LBAudioSource.MyBackColorOver = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LBAudioSource.MyBordColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LBAudioSource.MyFontColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.LBAudioSource.MylinColorNone = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LBAudioSource.Name = "LBAudioSource"
        Me.LBAudioSource.Size = New System.Drawing.Size(166, 20)
        Me.LBAudioSource.TabIndex = 0
        Me.LBAudioSource.TabStop = False
        Me.LBAudioSource.Tag = "0"
        Me.LBAudioSource.TxText = "AudioSource:"
        '
        'Transdown
        '
        Me.Transdown.Interval = 20
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'TRefresher
        '
        Me.TRefresher.Interval = 5
        '
        'FPTimer
        '
        Me.FPTimer.Interval = 1000
        '
        'SELCT_AS
        '
        Me.SELCT_AS.AutoSize = False
        Me.SELCT_AS.Name = "SELCT_AS"
        Me.SELCT_AS.ShowImageMargin = False
        Me.SELCT_AS.Size = New System.Drawing.Size(153, 26)
        '
        'SELCT_SR
        '
        Me.SELCT_SR.AutoSize = False
        Me.SELCT_SR.Name = "SELCT_AS"
        Me.SELCT_SR.ShowImageMargin = False
        Me.SELCT_SR.Size = New System.Drawing.Size(153, 26)
        '
        'Microphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(463, 207)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PSoundOutput)
        Me.Controls.Add(Me.PNLERRORS)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(479, 242)
        Me.Name = "Microphone"
        Me.Opacity = 0R
        Me.Text = "Microphone"
        Me.PNLERRORS.ResumeLayout(False)
        Me.PNLERRORS.PerformLayout()
        CType(Me.PSoundOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LBSampleRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBAudioSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents PNLERRORS As Panel
    Friend WithEvents LBER As Label
    Friend WithEvents PSoundOutput As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBAudioSource As SN.ThemeCoBox
    Friend WithEvents LBSampleRate As SN.ThemeCoBox
    Friend WithEvents STALAB As SN.ThemeButton
    Friend WithEvents ThemeSeparator1 As SN.ThemeSeparator
    Friend WithEvents Transdown As Timer
    Friend WithEvents Trans As Timer
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents TRefresher As Timer
    Friend WithEvents FPTimer As Timer
    Friend WithEvents SELCT_AS As ContextMenuStrip
    Friend WithEvents SELCT_SR As ContextMenuStrip
End Class
