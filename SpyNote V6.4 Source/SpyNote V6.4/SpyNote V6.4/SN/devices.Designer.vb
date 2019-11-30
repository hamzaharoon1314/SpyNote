<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(devices))
        Me.ViewManager = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOK = New SpyNote_V6._4.SN.ThemeButton()
        Me.ThemeButton1 = New SpyNote_V6._4.SN.ThemeButton()
        Me.PictureLoading = New System.Windows.Forms.PictureBox()
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ViewManager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewManager.DefaultCellStyle = DataGridViewCellStyle2
        Me.ViewManager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ViewManager.EnableHeadersVisualStyles = False
        Me.ViewManager.GridColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ViewManager.Location = New System.Drawing.Point(7, 8)
        Me.ViewManager.Name = "ViewManager"
        Me.ViewManager.RowHeadersVisible = False
        Me.ViewManager.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ViewManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewManager.ShowCellToolTips = False
        Me.ViewManager.Size = New System.Drawing.Size(432, 339)
        Me.ViewManager.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.HeaderText = "Connected devices"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 130
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
        Me.BtnOK.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BtnOK.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnOK.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BtnOK.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.BtnOK.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.BtnOK.ImageChoice = Nothing
        Me.BtnOK.Location = New System.Drawing.Point(338, 351)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.ShowImage = False
        Me.BtnOK.ShowText = True
        Me.BtnOK.Size = New System.Drawing.Size(100, 28)
        Me.BtnOK.TabIndex = 7
        Me.BtnOK.Tag = ""
        Me.BtnOK.Text = "OK"
        Me.BtnOK.TextAlignment = System.Drawing.StringAlignment.Center
        Me.BtnOK.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnOK.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnOK.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'ThemeButton1
        '
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
        Me.ThemeButton1.Location = New System.Drawing.Point(232, 351)
        Me.ThemeButton1.Name = "ThemeButton1"
        Me.ThemeButton1.ShowImage = False
        Me.ThemeButton1.ShowText = True
        Me.ThemeButton1.Size = New System.Drawing.Size(100, 28)
        Me.ThemeButton1.TabIndex = 8
        Me.ThemeButton1.Tag = ""
        Me.ThemeButton1.Text = "Cancel"
        Me.ThemeButton1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton1.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'PictureLoading
        '
        Me.PictureLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PictureLoading.Image = CType(resources.GetObject("PictureLoading.Image"), System.Drawing.Image)
        Me.PictureLoading.Location = New System.Drawing.Point(7, 8)
        Me.PictureLoading.Name = "PictureLoading"
        Me.PictureLoading.Size = New System.Drawing.Size(432, 339)
        Me.PictureLoading.TabIndex = 9
        Me.PictureLoading.TabStop = False
        '
        'Trans
        '
        Me.Trans.Interval = 40
        '
        'devices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 386)
        Me.Controls.Add(Me.PictureLoading)
        Me.Controls.Add(Me.ThemeButton1)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.ViewManager)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "devices"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "devices"
        CType(Me.ViewManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewManager As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents BtnOK As SN.ThemeButton
    Friend WithEvents ThemeButton1 As SN.ThemeButton
    Friend WithEvents PictureLoading As PictureBox
    Friend WithEvents Trans As Timer
End Class
