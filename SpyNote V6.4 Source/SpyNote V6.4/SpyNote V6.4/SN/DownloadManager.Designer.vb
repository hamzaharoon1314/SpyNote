<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadManager
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
        Me.PDow = New System.Windows.Forms.Panel()
        Me.aCancel = New SpyNote_V6._4.SN.ThemeButton()
        Me.LabNameFile = New System.Windows.Forms.Label()
        Me.PnlTime = New System.Windows.Forms.Panel()
        Me.ThemeSeparator1 = New SpyNote_V6._4.SN.ThemeSeparator()
        Me.Iwillfinishwhen = New System.Windows.Forms.Label()
        Me.expectedtime = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        Me.PN = New System.Windows.Forms.Panel()
        Me.DManager = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisualStudioHorizontalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar()
        Me.VisualStudioVerticalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioVerticalScrollBar()
        Me.TDownload = New System.Windows.Forms.Timer(Me.components)
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.TCompletion = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.TScrolls = New System.Windows.Forms.Timer(Me.components)
        Me.PDow.SuspendLayout()
        Me.PnlTime.SuspendLayout()
        Me.PN.SuspendLayout()
        CType(Me.DManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PDow
        '
        Me.PDow.Controls.Add(Me.aCancel)
        Me.PDow.Controls.Add(Me.LabNameFile)
        Me.PDow.Controls.Add(Me.PnlTime)
        Me.PDow.Controls.Add(Me.ProgressBar1)
        Me.PDow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PDow.Location = New System.Drawing.Point(0, 261)
        Me.PDow.Name = "PDow"
        Me.PDow.Size = New System.Drawing.Size(662, 141)
        Me.PDow.TabIndex = 0
        '
        'aCancel
        '
        Me.aCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aCancel.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.aCancel.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.aCancel.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.aCancel.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.aCancel.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.aCancel.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.aCancel.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.aCancel.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.aCancel.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.aCancel.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.aCancel.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.aCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.aCancel.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.aCancel.ImageChoice = Nothing
        Me.aCancel.Location = New System.Drawing.Point(546, 97)
        Me.aCancel.Name = "aCancel"
        Me.aCancel.ShowImage = False
        Me.aCancel.ShowText = True
        Me.aCancel.Size = New System.Drawing.Size(100, 28)
        Me.aCancel.TabIndex = 9
        Me.aCancel.Tag = ""
        Me.aCancel.Text = "Cancel"
        Me.aCancel.TextAlignment = System.Drawing.StringAlignment.Center
        Me.aCancel.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.aCancel.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.aCancel.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'LabNameFile
        '
        Me.LabNameFile.AutoSize = True
        Me.LabNameFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabNameFile.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNameFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LabNameFile.Location = New System.Drawing.Point(0, 52)
        Me.LabNameFile.Name = "LabNameFile"
        Me.LabNameFile.Size = New System.Drawing.Size(58, 15)
        Me.LabNameFile.TabIndex = 8
        Me.LabNameFile.Text = "waiting ..."
        '
        'PnlTime
        '
        Me.PnlTime.Controls.Add(Me.ThemeSeparator1)
        Me.PnlTime.Controls.Add(Me.Iwillfinishwhen)
        Me.PnlTime.Controls.Add(Me.expectedtime)
        Me.PnlTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTime.Location = New System.Drawing.Point(0, 0)
        Me.PnlTime.Name = "PnlTime"
        Me.PnlTime.Size = New System.Drawing.Size(662, 52)
        Me.PnlTime.TabIndex = 4
        '
        'ThemeSeparator1
        '
        Me.ThemeSeparator1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ThemeSeparator1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemeSeparator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ThemeSeparator1.Location = New System.Drawing.Point(0, 0)
        Me.ThemeSeparator1.Name = "ThemeSeparator1"
        Me.ThemeSeparator1.Size = New System.Drawing.Size(662, 10)
        Me.ThemeSeparator1.TabIndex = 9
        Me.ThemeSeparator1.Text = "ThemeSeparator1"
        '
        'Iwillfinishwhen
        '
        Me.Iwillfinishwhen.AutoSize = True
        Me.Iwillfinishwhen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iwillfinishwhen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Iwillfinishwhen.Location = New System.Drawing.Point(5, 32)
        Me.Iwillfinishwhen.Name = "Iwillfinishwhen"
        Me.Iwillfinishwhen.Size = New System.Drawing.Size(25, 15)
        Me.Iwillfinishwhen.TabIndex = 8
        Me.Iwillfinishwhen.Text = "n/a"
        '
        'expectedtime
        '
        Me.expectedtime.AutoSize = True
        Me.expectedtime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expectedtime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.expectedtime.Location = New System.Drawing.Point(5, 11)
        Me.expectedtime.Name = "expectedtime"
        Me.expectedtime.Size = New System.Drawing.Size(25, 15)
        Me.expectedtime.TabIndex = 7
        Me.expectedtime.Text = "n/a"
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
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 131)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(662, 10)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
        '
        'PN
        '
        Me.PN.Controls.Add(Me.DManager)
        Me.PN.Controls.Add(Me.VisualStudioHorizontalScrollBar1)
        Me.PN.Controls.Add(Me.VisualStudioVerticalScrollBar1)
        Me.PN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN.Location = New System.Drawing.Point(0, 0)
        Me.PN.Name = "PN"
        Me.PN.Size = New System.Drawing.Size(662, 261)
        Me.PN.TabIndex = 1
        '
        'DManager
        '
        Me.DManager.AllowUserToAddRows = False
        Me.DManager.AllowUserToDeleteRows = False
        Me.DManager.AllowUserToResizeColumns = False
        Me.DManager.AllowUserToResizeRows = False
        Me.DManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DManager.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DManager.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DManager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DManager.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DManager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DManager.DefaultCellStyle = DataGridViewCellStyle2
        Me.DManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DManager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DManager.EnableHeadersVisualStyles = False
        Me.DManager.GridColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DManager.Location = New System.Drawing.Point(0, 0)
        Me.DManager.MultiSelect = False
        Me.DManager.Name = "DManager"
        Me.DManager.RowHeadersVisible = False
        Me.DManager.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DManager.ShowCellToolTips = False
        Me.DManager.Size = New System.Drawing.Size(652, 251)
        Me.DManager.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 44
        '
        'Column3
        '
        Me.Column3.HeaderText = "Size"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 53
        '
        'Column4
        '
        Me.Column4.HeaderText = "Path"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 55
        '
        'VisualStudioHorizontalScrollBar1
        '
        Me.VisualStudioHorizontalScrollBar1.AmountOfInnerLines = SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar.__InnerLineCount.One
        Me.VisualStudioHorizontalScrollBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ButtonSize = 16
        Me.VisualStudioHorizontalScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VisualStudioHorizontalScrollBar1.LargeChange = 10
        Me.VisualStudioHorizontalScrollBar1.Location = New System.Drawing.Point(0, 251)
        Me.VisualStudioHorizontalScrollBar1.Maximum = 1
        Me.VisualStudioHorizontalScrollBar1.Minimum = 0
        Me.VisualStudioHorizontalScrollBar1.Name = "VisualStudioHorizontalScrollBar1"
        Me.VisualStudioHorizontalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioHorizontalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioHorizontalScrollBar1.Size = New System.Drawing.Size(652, 10)
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
        Me.VisualStudioVerticalScrollBar1.Location = New System.Drawing.Point(652, 0)
        Me.VisualStudioVerticalScrollBar1.Maximum = 1
        Me.VisualStudioVerticalScrollBar1.Minimum = 0
        Me.VisualStudioVerticalScrollBar1.Name = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioVerticalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioVerticalScrollBar1.Size = New System.Drawing.Size(10, 261)
        Me.VisualStudioVerticalScrollBar1.SmallChange = 10
        Me.VisualStudioVerticalScrollBar1.TabIndex = 4
        Me.VisualStudioVerticalScrollBar1.Text = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.Value = 0
        '
        'TDownload
        '
        Me.TDownload.Interval = 10
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'TCompletion
        '
        Me.TCompletion.Interval = 1
        '
        'Trans
        '
        Me.Trans.Interval = 20
        '
        'TScrolls
        '
        Me.TScrolls.Interval = 1
        '
        'DownloadManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 402)
        Me.Controls.Add(Me.PN)
        Me.Controls.Add(Me.PDow)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(246, 193)
        Me.Name = "DownloadManager"
        Me.Opacity = 0R
        Me.Text = "DownloadManager"
        Me.PDow.ResumeLayout(False)
        Me.PDow.PerformLayout()
        Me.PnlTime.ResumeLayout(False)
        Me.PnlTime.PerformLayout()
        Me.PN.ResumeLayout(False)
        CType(Me.DManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PDow As Panel
    Friend WithEvents PnlTime As Panel
    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents Iwillfinishwhen As Label
    Friend WithEvents expectedtime As Label
    Friend WithEvents ThemeSeparator1 As SN.ThemeSeparator
    Friend WithEvents LabNameFile As Label
    Friend WithEvents aCancel As SN.ThemeButton
    Friend WithEvents PN As Panel
    Friend WithEvents VisualStudioVerticalScrollBar1 As SN.VisualStudioVerticalScrollBar
    Friend WithEvents VisualStudioHorizontalScrollBar1 As SN.VisualStudioHorizontalScrollBar
    Friend WithEvents DManager As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TDownload As Timer
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents TCompletion As Timer
    Friend WithEvents Trans As Timer
    Friend WithEvents TScrolls As Timer
End Class
