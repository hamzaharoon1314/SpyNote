<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminal
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProgressBar1 = New SpyNote_V6._4.SN.ThemeProgressBar()
        Me.VisualStudioVerticalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioVerticalScrollBar()
        Me.VisualStudioHorizontalScrollBar1 = New SpyNote_V6._4.SN.VisualStudioHorizontalScrollBar()
        Me.ViewManager = New System.Windows.Forms.DataGridView()
        Me.TScrolls = New System.Windows.Forms.Timer(Me.components)
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Transparent = False
        Me.ProgressBar1.Value = 0
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
        Me.VisualStudioVerticalScrollBar1.Size = New System.Drawing.Size(10, 412)
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
        Me.VisualStudioHorizontalScrollBar1.Location = New System.Drawing.Point(0, 402)
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
        Me.ViewManager.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ViewManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ViewManager.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ViewManager.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ViewManager.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewManager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewManager.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewManager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewManager.DefaultCellStyle = DataGridViewCellStyle4
        Me.ViewManager.EnableHeadersVisualStyles = False
        Me.ViewManager.GridColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ViewManager.Location = New System.Drawing.Point(0, 0)
        Me.ViewManager.Name = "ViewManager"
        Me.ViewManager.RowHeadersVisible = False
        Me.ViewManager.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ViewManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewManager.ShowCellToolTips = False
        Me.ViewManager.Size = New System.Drawing.Size(624, 402)
        Me.ViewManager.TabIndex = 6
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
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 14
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(162, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "       "
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 422)
        Me.Controls.Add(Me.ViewManager)
        Me.Controls.Add(Me.VisualStudioHorizontalScrollBar1)
        Me.Controls.Add(Me.VisualStudioVerticalScrollBar1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Name = "Terminal"
        Me.Opacity = 0R
        Me.Text = "Terminal"
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As SN.ThemeProgressBar
    Friend WithEvents VisualStudioVerticalScrollBar1 As SN.VisualStudioVerticalScrollBar
    Friend WithEvents VisualStudioHorizontalScrollBar1 As SN.VisualStudioHorizontalScrollBar
    Friend WithEvents ViewManager As DataGridView
    Friend WithEvents TScrolls As Timer
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents Trans As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
