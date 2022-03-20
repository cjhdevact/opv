<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PictureForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PictureForm))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTipText = New System.Windows.Forms.ToolTip(Me.components)
        Me.backcmd = New System.Windows.Forms.Button()
        Me.infocmd = New System.Windows.Forms.Button()
        Me.fsccmd = New System.Windows.Forms.Button()
        Me.nextcmd = New System.Windows.Forms.Button()
        Me.closecmd = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fliem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openm = New System.Windows.Forms.ToolStripMenuItem()
        Me.printm = New System.Windows.Forms.ToolStripMenuItem()
        Me.printviewm = New System.Windows.Forms.ToolStripMenuItem()
        Me.infom = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitm = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewm = New System.Windows.Forms.ToolStripMenuItem()
        Me.fsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.openexem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mspaintm = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpm = New System.Windows.Forms.ToolStripMenuItem()
        Me.prghelpm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutm = New System.Windows.Forms.ToolStripMenuItem()
        Me.picturefullcm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.closecm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.fscm = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.picturefullcm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Title = "打开文件"
        '
        'backcmd
        '
        Me.backcmd.Enabled = False
        Me.backcmd.Image = CType(resources.GetObject("backcmd.Image"), System.Drawing.Image)
        Me.backcmd.Location = New System.Drawing.Point(85, 3)
        Me.backcmd.Name = "backcmd"
        Me.backcmd.Size = New System.Drawing.Size(42, 28)
        Me.backcmd.TabIndex = 2
        Me.ToolTipText.SetToolTip(Me.backcmd, "上一张")
        Me.backcmd.UseVisualStyleBackColor = True
        '
        'infocmd
        '
        Me.infocmd.Image = CType(resources.GetObject("infocmd.Image"), System.Drawing.Image)
        Me.infocmd.Location = New System.Drawing.Point(51, 3)
        Me.infocmd.Name = "infocmd"
        Me.infocmd.Size = New System.Drawing.Size(28, 28)
        Me.infocmd.TabIndex = 1
        Me.ToolTipText.SetToolTip(Me.infocmd, "属性")
        Me.infocmd.UseVisualStyleBackColor = True
        '
        'fsccmd
        '
        Me.fsccmd.Image = CType(resources.GetObject("fsccmd.Image"), System.Drawing.Image)
        Me.fsccmd.Location = New System.Drawing.Point(3, 3)
        Me.fsccmd.Name = "fsccmd"
        Me.fsccmd.Size = New System.Drawing.Size(44, 28)
        Me.fsccmd.TabIndex = 3
        Me.ToolTipText.SetToolTip(Me.fsccmd, "全屏/窗口")
        Me.fsccmd.UseVisualStyleBackColor = True
        '
        'nextcmd
        '
        Me.nextcmd.Enabled = False
        Me.nextcmd.Image = CType(resources.GetObject("nextcmd.Image"), System.Drawing.Image)
        Me.nextcmd.Location = New System.Drawing.Point(3, 3)
        Me.nextcmd.Name = "nextcmd"
        Me.nextcmd.Size = New System.Drawing.Size(42, 28)
        Me.nextcmd.TabIndex = 2
        Me.nextcmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipText.SetToolTip(Me.nextcmd, "下一张")
        Me.nextcmd.UseVisualStyleBackColor = True
        '
        'closecmd
        '
        Me.closecmd.Image = CType(resources.GetObject("closecmd.Image"), System.Drawing.Image)
        Me.closecmd.Location = New System.Drawing.Point(51, 3)
        Me.closecmd.Name = "closecmd"
        Me.closecmd.Size = New System.Drawing.Size(28, 28)
        Me.closecmd.TabIndex = 1
        Me.ToolTipText.SetToolTip(Me.closecmd, "清除图像")
        Me.closecmd.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 425)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(618, 34)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(464, 0)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(154, 34)
        Me.FlowLayoutPanel3.TabIndex = 6
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(154, 34)
        Me.FlowLayoutPanel2.TabIndex = 5
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.backcmd)
        Me.FlowLayoutPanel1.Controls.Add(Me.infocmd)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(154, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(130, 34)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel5.Controls.Add(Me.fsccmd)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(284, 0)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(50, 34)
        Me.FlowLayoutPanel5.TabIndex = 6
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel4.Controls.Add(Me.nextcmd)
        Me.FlowLayoutPanel4.Controls.Add(Me.closecmd)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(334, 0)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(130, 34)
        Me.FlowLayoutPanel4.TabIndex = 5
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(618, 27)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fliem, Me.viewm, Me.openexem, Me.helpm})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(618, 27)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'fliem
        '
        Me.fliem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openm, Me.printm, Me.printviewm, Me.infom, Me.ToolStripMenuItem1, Me.exitm})
        Me.fliem.ForeColor = System.Drawing.Color.Black
        Me.fliem.Name = "fliem"
        Me.fliem.Size = New System.Drawing.Size(58, 27)
        Me.fliem.Text = "文件(&F)"
        '
        'openm
        '
        Me.openm.Image = CType(resources.GetObject("openm.Image"), System.Drawing.Image)
        Me.openm.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.openm.Name = "openm"
        Me.openm.ShortcutKeyDisplayString = ""
        Me.openm.Size = New System.Drawing.Size(140, 22)
        Me.openm.Text = "打开(&O)"
        '
        'printm
        '
        Me.printm.Image = CType(resources.GetObject("printm.Image"), System.Drawing.Image)
        Me.printm.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.printm.Name = "printm"
        Me.printm.Size = New System.Drawing.Size(140, 22)
        Me.printm.Text = "打印(&P)"
        '
        'printviewm
        '
        Me.printviewm.Image = CType(resources.GetObject("printviewm.Image"), System.Drawing.Image)
        Me.printviewm.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.printviewm.Name = "printviewm"
        Me.printviewm.Size = New System.Drawing.Size(140, 22)
        Me.printviewm.Text = "打印预览(&V)"
        '
        'infom
        '
        Me.infom.Image = CType(resources.GetObject("infom.Image"), System.Drawing.Image)
        Me.infom.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.infom.Name = "infom"
        Me.infom.ShortcutKeyDisplayString = ""
        Me.infom.Size = New System.Drawing.Size(140, 22)
        Me.infom.Text = "属性(&I)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(137, 6)
        '
        'exitm
        '
        Me.exitm.Name = "exitm"
        Me.exitm.ShortcutKeyDisplayString = " "
        Me.exitm.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.exitm.Size = New System.Drawing.Size(140, 22)
        Me.exitm.Text = "退出(&X)"
        '
        'viewm
        '
        Me.viewm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fsm})
        Me.viewm.ForeColor = System.Drawing.Color.Black
        Me.viewm.Name = "viewm"
        Me.viewm.ShortcutKeyDisplayString = ""
        Me.viewm.Size = New System.Drawing.Size(60, 27)
        Me.viewm.Text = "查看(&V)"
        '
        'fsm
        '
        Me.fsm.Image = CType(resources.GetObject("fsm.Image"), System.Drawing.Image)
        Me.fsm.ImageTransparentColor = System.Drawing.Color.White
        Me.fsm.Name = "fsm"
        Me.fsm.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.fsm.Size = New System.Drawing.Size(128, 22)
        Me.fsm.Text = "全屏"
        '
        'openexem
        '
        Me.openexem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mspaintm})
        Me.openexem.ForeColor = System.Drawing.Color.Black
        Me.openexem.Name = "openexem"
        Me.openexem.ShortcutKeyDisplayString = ""
        Me.openexem.Size = New System.Drawing.Size(83, 27)
        Me.openexem.Text = "打开方式(&E)"
        '
        'mspaintm
        '
        Me.mspaintm.Image = CType(resources.GetObject("mspaintm.Image"), System.Drawing.Image)
        Me.mspaintm.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mspaintm.Name = "mspaintm"
        Me.mspaintm.ShortcutKeyDisplayString = ""
        Me.mspaintm.Size = New System.Drawing.Size(115, 22)
        Me.mspaintm.Text = "画图(&P)"
        '
        'helpm
        '
        Me.helpm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prghelpm, Me.ToolStripMenuItem2, Me.aboutm})
        Me.helpm.ForeColor = System.Drawing.Color.Black
        Me.helpm.Name = "helpm"
        Me.helpm.Size = New System.Drawing.Size(61, 27)
        Me.helpm.Text = "帮助(&H)"
        '
        'prghelpm
        '
        Me.prghelpm.Image = CType(resources.GetObject("prghelpm.Image"), System.Drawing.Image)
        Me.prghelpm.Name = "prghelpm"
        Me.prghelpm.ShortcutKeyDisplayString = ""
        Me.prghelpm.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.prghelpm.Size = New System.Drawing.Size(238, 22)
        Me.prghelpm.Text = "帮助(&P)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(235, 6)
        '
        'aboutm
        '
        Me.aboutm.Image = CType(resources.GetObject("aboutm.Image"), System.Drawing.Image)
        Me.aboutm.Name = "aboutm"
        Me.aboutm.ShortcutKeyDisplayString = ""
        Me.aboutm.Size = New System.Drawing.Size(238, 22)
        Me.aboutm.Text = "关于 Open Picture Viewer(&A)"
        '
        'picturefullcm
        '
        Me.picturefullcm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.closecm, Me.ToolStripMenuItem3, Me.fscm})
        Me.picturefullcm.Name = "picturefullcm"
        Me.picturefullcm.Size = New System.Drawing.Size(153, 54)
        '
        'closecm
        '
        Me.closecm.Image = CType(resources.GetObject("closecm.Image"), System.Drawing.Image)
        Me.closecm.Name = "closecm"
        Me.closecm.Size = New System.Drawing.Size(152, 22)
        Me.closecm.Text = "清除图像"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(149, 6)
        '
        'fscm
        '
        Me.fscm.Image = CType(resources.GetObject("fscm.Image"), System.Drawing.Image)
        Me.fscm.Name = "fscm"
        Me.fscm.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.fscm.Size = New System.Drawing.Size(152, 22)
        Me.fscm.Text = "退出全屏"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(618, 398)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 459)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(424, 370)
        Me.Name = "PictureForm"
        Me.Text = "Open Picture Viewer"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.picturefullcm.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTipText As System.Windows.Forms.ToolTip
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents fsccmd As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents closecmd As System.Windows.Forms.Button
    Friend WithEvents nextcmd As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents infocmd As System.Windows.Forms.Button
    Friend WithEvents backcmd As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents fliem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printviewm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents infom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents viewm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fsm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openexem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mspaintm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prghelpm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents aboutm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picturefullcm As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents closecm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents fscm As System.Windows.Forms.ToolStripMenuItem

End Class
