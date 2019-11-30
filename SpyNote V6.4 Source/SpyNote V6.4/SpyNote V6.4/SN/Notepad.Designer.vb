<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notepad
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
        Me.PNL1 = New System.Windows.Forms.Panel()
        Me.SAVELAB = New SpyNote_V6._4.SN.ThemeButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSpace = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ThemeButton1 = New SpyNote_V6._4.SN.ThemeButton()
        Me.ThemeButton2 = New SpyNote_V6._4.SN.ThemeButton()
        Me.TProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.TScrolls = New System.Windows.Forms.Timer(Me.components)
        Me.DwonTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UPTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PNL1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL1
        '
        Me.PNL1.Controls.Add(Me.SAVELAB)
        Me.PNL1.Controls.Add(Me.Label2)
        Me.PNL1.Controls.Add(Me.Label1)
        Me.PNL1.Controls.Add(Me.LabelSpace)
        Me.PNL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PNL1.Location = New System.Drawing.Point(0, 0)
        Me.PNL1.Name = "PNL1"
        Me.PNL1.Size = New System.Drawing.Size(70, 423)
        Me.PNL1.TabIndex = 0
        '
        'SAVELAB
        '
        Me.SAVELAB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SAVELAB.BackColorDown0_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SAVELAB.BackColorDown1_S = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SAVELAB.BackColorNone0_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SAVELAB.BackColorNone1_S = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SAVELAB.BackColorOver0_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SAVELAB.BackColorOver1_S = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.SAVELAB.ButtonBackColorEnabled0_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SAVELAB.ButtonBackColorEnabled1_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SAVELAB.ButtonForColor_S = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.SAVELAB.ButtonForColorEnabled_S = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.SAVELAB.Buttonselected_Color_ForColor_S = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.SAVELAB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SAVELAB.ImageAlignment = SpyNote_V6._4.SN.ThemeButton.__ImageAlignment.Left
        Me.SAVELAB.ImageChoice = Nothing
        Me.SAVELAB.Location = New System.Drawing.Point(5, 392)
        Me.SAVELAB.Name = "SAVELAB"
        Me.SAVELAB.ShowImage = False
        Me.SAVELAB.ShowText = True
        Me.SAVELAB.Size = New System.Drawing.Size(59, 28)
        Me.SAVELAB.TabIndex = 5
        Me.SAVELAB.Tag = "-1"
        Me.SAVELAB.Text = "Save"
        Me.SAVELAB.TextAlignment = System.Drawing.StringAlignment.Center
        Me.SAVELAB.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SAVELAB.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SAVELAB.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ch"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ln"
        '
        'LabelSpace
        '
        Me.LabelSpace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelSpace.AutoSize = True
        Me.LabelSpace.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSpace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelSpace.Location = New System.Drawing.Point(3, 399)
        Me.LabelSpace.Name = "LabelSpace"
        Me.LabelSpace.Size = New System.Drawing.Size(64, 14)
        Me.LabelSpace.TabIndex = 0
        Me.LabelSpace.Text = "                   "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(70, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(556, 423)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
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
        Me.ThemeButton1.Location = New System.Drawing.Point(598, 350)
        Me.ThemeButton1.Name = "ThemeButton1"
        Me.ThemeButton1.ShowImage = False
        Me.ThemeButton1.ShowText = False
        Me.ThemeButton1.Size = New System.Drawing.Size(24, 24)
        Me.ThemeButton1.TabIndex = 6
        Me.ThemeButton1.Tag = ""
        Me.ThemeButton1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton1.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ThemeButton1.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
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
        Me.ThemeButton2.Location = New System.Drawing.Point(598, 378)
        Me.ThemeButton2.Name = "ThemeButton2"
        Me.ThemeButton2.ShowImage = False
        Me.ThemeButton2.ShowText = False
        Me.ThemeButton2.Size = New System.Drawing.Size(24, 24)
        Me.ThemeButton2.TabIndex = 7
        Me.ThemeButton2.Tag = ""
        Me.ThemeButton2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.ThemeButton2.ThemeButtonclrBorder_S = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ThemeButton2.ThemeButtonclrBorderactive_S = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ThemeButton2.ThemeButtonclrBorderEnabled_S = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
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
        'DwonTimer
        '
        Me.DwonTimer.Interval = 30
        '
        'UPTimer
        '
        Me.UPTimer.Interval = 30
        '
        'Notepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 423)
        Me.Controls.Add(Me.ThemeButton2)
        Me.Controls.Add(Me.ThemeButton1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PNL1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(251, 177)
        Me.Name = "Notepad"
        Me.Opacity = 0R
        Me.Text = "Notepad"
        Me.PNL1.ResumeLayout(False)
        Me.PNL1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelSpace As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SAVELAB As SN.ThemeButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ThemeButton1 As SN.ThemeButton
    Friend WithEvents ThemeButton2 As SN.ThemeButton
    Friend WithEvents TProgressBar As Timer
    Friend WithEvents Trans As Timer
    Friend WithEvents TScrolls As Timer
    Friend WithEvents DwonTimer As Timer
    Friend WithEvents UPTimer As Timer
End Class
