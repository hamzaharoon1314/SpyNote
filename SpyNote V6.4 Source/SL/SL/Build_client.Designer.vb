<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Build_client
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ThemeProgressBar1 = New SL.spy673.ThemeProgressBar()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(638, 499)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'ThemeProgressBar1
        '
        Me.ThemeProgressBar1.Animated = True
        Me.ThemeProgressBar1.Colour0 = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ThemeProgressBar1.Colour1 = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ThemeProgressBar1.Customization = "5ubm/+bm5v/m5ub/fHp6/w=="
        Me.ThemeProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ThemeProgressBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ThemeProgressBar1.Image = Nothing
        Me.ThemeProgressBar1.Location = New System.Drawing.Point(0, 489)
        Me.ThemeProgressBar1.Maximum = 100
        Me.ThemeProgressBar1.Minimum = 0
        Me.ThemeProgressBar1.Name = "ThemeProgressBar1"
        Me.ThemeProgressBar1.NoRounding = False
        Me.ThemeProgressBar1.Size = New System.Drawing.Size(638, 10)
        Me.ThemeProgressBar1.TabIndex = 1
        Me.ThemeProgressBar1.Text = "ThemeProgressBar1"
        Me.ThemeProgressBar1.Transparent = False
        Me.ThemeProgressBar1.Value = 0
        '
        'Build_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 499)
        Me.Controls.Add(Me.ThemeProgressBar1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Build_client"
        Me.Opacity = 0.9R
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ThemeProgressBar1 As spy673.ThemeProgressBar
End Class
