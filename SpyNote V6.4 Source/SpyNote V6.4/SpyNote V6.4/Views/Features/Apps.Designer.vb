<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apps
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
        Me.ProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.TScrolls = New System.Windows.Forms.Timer(Me.components)
        Me.PNLERRORS = New System.Windows.Forms.Panel()
        Me.LBER = New System.Windows.Forms.Label()
        Me.VisualStudioVerticalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioVerticalScrollBar()
        Me.VisualStudioHorizontalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar()
        Me.ViewManager = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextApps = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GooglePlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PCNOTF = New System.Windows.Forms.PictureBox()
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BOXDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLERRORS.SuspendLayout()
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextApps.SuspendLayout()
        CType(Me.PCNOTF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOXDOWN
        '
        Me.BOXDOWN.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BOXDOWN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BOXDOWN.Location = New System.Drawing.Point(0, 405)
        Me.BOXDOWN.Name = "BOXDOWN"
        Me.BOXDOWN.Size = New System.Drawing.Size(634, 18)
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
        Me.ProgressBar1.Size = New System.Drawing.Size(634, 10)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
        '
        'TProgressBar
        '
        Me.TProgressBar.Interval = 1
        '
        'TScrolls
        '
        Me.TScrolls.Interval = 1
        '
        'PNLERRORS
        '
        Me.PNLERRORS.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PNLERRORS.Controls.Add(Me.LBER)
        Me.PNLERRORS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNLERRORS.Location = New System.Drawing.Point(0, 376)
        Me.PNLERRORS.Name = "PNLERRORS"
        Me.PNLERRORS.Size = New System.Drawing.Size(634, 19)
        Me.PNLERRORS.TabIndex = 2
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
        Me.LBER.TabIndex = 1
        Me.LBER.Text = "Errors"
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
        Me.VisualStudioVerticalScrollBar1.Location = New System.Drawing.Point(624, 0)
        Me.VisualStudioVerticalScrollBar1.Maximum = 1
        Me.VisualStudioVerticalScrollBar1.Minimum = 0
        Me.VisualStudioVerticalScrollBar1.Name = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioVerticalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioVerticalScrollBar1.Size = New System.Drawing.Size(10, 376)
        Me.VisualStudioVerticalScrollBar1.SmallChange = 10
        Me.VisualStudioVerticalScrollBar1.TabIndex = 4
        Me.VisualStudioVerticalScrollBar1.Text = "VisualStudioVerticalScrollBar1"
        Me.VisualStudioVerticalScrollBar1.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioVerticalScrollBar1.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioVerticalScrollBar1.Value = 0
        '
        'VisualStudioHorizontalScrollBar1
        '
        Me.VisualStudioHorizontalScrollBar1.AmountOfInnerLines = SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar.__InnerLineCount.One
        Me.VisualStudioHorizontalScrollBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ButtonSize = 16
        Me.VisualStudioHorizontalScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VisualStudioHorizontalScrollBar1.LargeChange = 10
        Me.VisualStudioHorizontalScrollBar1.Location = New System.Drawing.Point(0, 366)
        Me.VisualStudioHorizontalScrollBar1.Maximum = 1
        Me.VisualStudioHorizontalScrollBar1.Minimum = 0
        Me.VisualStudioHorizontalScrollBar1.Name = "VisualStudioHorizontalScrollBar1"
        Me.VisualStudioHorizontalScrollBar1.OuterBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar1.ShowOuterBorder = False
        Me.VisualStudioHorizontalScrollBar1.ShowThumbBorder = False
        Me.VisualStudioHorizontalScrollBar1.Size = New System.Drawing.Size(624, 10)
        Me.VisualStudioHorizontalScrollBar1.SmallChange = 10
        Me.VisualStudioHorizontalScrollBar1.TabIndex = 5
        Me.VisualStudioHorizontalScrollBar1.Text = "VisualStudioHorizontalScrollBar1"
        Me.VisualStudioHorizontalScrollBar1.ThumbBorderColour = System.Drawing.Color.Empty
        Me.VisualStudioHorizontalScrollBar1.ThumbHoverColour = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ThumbNormalColour = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.ThumbPressedColour = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.VisualStudioHorizontalScrollBar1.Value = 0
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
        Me.ViewManager.ContextMenuStrip = Me.ContextApps
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
        Me.ViewManager.Size = New System.Drawing.Size(624, 366)
        Me.ViewManager.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 27
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 63
        '
        'Column3
        '
        Me.Column3.HeaderText = "Package"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Apps source"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 96
        '
        'Column5
        '
        Me.Column5.HeaderText = "install Time"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 92
        '
        'ContextApps
        '
        Me.ContextApps.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.GooglePlayToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.PropertiesToolStripMenuItem})
        Me.ContextApps.Name = "ContextApps"
        Me.ContextApps.ShowImageMargin = False
        Me.ContextApps.Size = New System.Drawing.Size(154, 92)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'GooglePlayToolStripMenuItem
        '
        Me.GooglePlayToolStripMenuItem.Name = "GooglePlayToolStripMenuItem"
        Me.GooglePlayToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.GooglePlayToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GooglePlayToolStripMenuItem.Text = "Google play"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'PCNOTF
        '
        Me.PCNOTF.ErrorImage = Nothing
        Me.PCNOTF.InitialImage = Nothing
        Me.PCNOTF.Location = New System.Drawing.Point(98, 88)
        Me.PCNOTF.Name = "PCNOTF"
        Me.PCNOTF.Size = New System.Drawing.Size(131, 68)
        Me.PCNOTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCNOTF.TabIndex = 7
        Me.PCNOTF.TabStop = False
        Me.PCNOTF.Visible = False
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'Apps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 423)
        Me.Controls.Add(Me.PCNOTF)
        Me.Controls.Add(Me.ViewManager)
        Me.Controls.Add(Me.VisualStudioHorizontalScrollBar1)
        Me.Controls.Add(Me.VisualStudioVerticalScrollBar1)
        Me.Controls.Add(Me.PNLERRORS)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BOXDOWN)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Name = "Apps"
        Me.Opacity = 0R
        Me.Text = "Apps"
        CType(Me.BOXDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLERRORS.ResumeLayout(False)
        Me.PNLERRORS.PerformLayout()
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextApps.ResumeLayout(False)
        CType(Me.PCNOTF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BOXDOWN As PictureBox
    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents TScrolls As Timer
    Friend WithEvents PNLERRORS As Panel
    Friend WithEvents LBER As Label
    Friend WithEvents VisualStudioVerticalScrollBar1 As SN.VisualStudioVerticalScrollBar
    Friend WithEvents VisualStudioHorizontalScrollBar1 As SN.VisualStudioHorizontalScrollBar
    Friend WithEvents ViewManager As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PCNOTF As PictureBox
    Friend WithEvents ContextApps As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GooglePlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Trans As Timer
End Class
