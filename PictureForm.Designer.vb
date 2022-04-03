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
        Me.picturefullcm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.closecm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.fscm = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ribtab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.exitrbl = New System.Windows.Forms.Label()
        Me.exitrb = New System.Windows.Forms.PictureBox()
        Me.inforbl = New System.Windows.Forms.Label()
        Me.inforb = New System.Windows.Forms.PictureBox()
        Me.printviewrbl = New System.Windows.Forms.Label()
        Me.printviewrb = New System.Windows.Forms.PictureBox()
        Me.printrbl = New System.Windows.Forms.Label()
        Me.printrb = New System.Windows.Forms.PictureBox()
        Me.filerbl = New System.Windows.Forms.Label()
        Me.filerb = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fsrbl = New System.Windows.Forms.Label()
        Me.fsrb = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.mspaintrbl = New System.Windows.Forms.Label()
        Me.mspaintrb = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.aboutrbl = New System.Windows.Forms.Label()
        Me.aboutrb = New System.Windows.Forms.PictureBox()
        Me.prghlprbl = New System.Windows.Forms.Label()
        Me.prghlprb = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.fastkeysub = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullviewlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelplinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.picturefullcm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ribtab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.exitrb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inforb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printviewrb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printrb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filerb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.fsrb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.mspaintrb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.aboutrb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prghlprb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fastkeysub.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.PictureBox1.Location = New System.Drawing.Point(0, 103)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(618, 322)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ribtab
        '
        Me.ribtab.Controls.Add(Me.TabPage1)
        Me.ribtab.Controls.Add(Me.TabPage2)
        Me.ribtab.Controls.Add(Me.TabPage3)
        Me.ribtab.Controls.Add(Me.TabPage4)
        Me.ribtab.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ribtab.Location = New System.Drawing.Point(0, 0)
        Me.ribtab.Margin = New System.Windows.Forms.Padding(0)
        Me.ribtab.Name = "ribtab"
        Me.ribtab.SelectedIndex = 0
        Me.ribtab.Size = New System.Drawing.Size(618, 103)
        Me.ribtab.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Azure
        Me.TabPage1.Controls.Add(Me.exitrbl)
        Me.TabPage1.Controls.Add(Me.exitrb)
        Me.TabPage1.Controls.Add(Me.inforbl)
        Me.TabPage1.Controls.Add(Me.inforb)
        Me.TabPage1.Controls.Add(Me.printviewrbl)
        Me.TabPage1.Controls.Add(Me.printviewrb)
        Me.TabPage1.Controls.Add(Me.printrbl)
        Me.TabPage1.Controls.Add(Me.printrb)
        Me.TabPage1.Controls.Add(Me.filerbl)
        Me.TabPage1.Controls.Add(Me.filerb)
        Me.TabPage1.Controls.Add(Me.ShapeContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(610, 73)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  文件  "
        '
        'exitrbl
        '
        Me.exitrbl.AutoSize = True
        Me.exitrbl.Location = New System.Drawing.Point(303, 52)
        Me.exitrbl.Name = "exitrbl"
        Me.exitrbl.Size = New System.Drawing.Size(32, 17)
        Me.exitrbl.TabIndex = 10
        Me.exitrbl.Text = "退出"
        '
        'exitrb
        '
        Me.exitrb.Image = CType(resources.GetObject("exitrb.Image"), System.Drawing.Image)
        Me.exitrb.Location = New System.Drawing.Point(299, 8)
        Me.exitrb.Name = "exitrb"
        Me.exitrb.Size = New System.Drawing.Size(40, 40)
        Me.exitrb.TabIndex = 9
        Me.exitrb.TabStop = False
        '
        'inforbl
        '
        Me.inforbl.AutoSize = True
        Me.inforbl.Location = New System.Drawing.Point(232, 53)
        Me.inforbl.Name = "inforbl"
        Me.inforbl.Size = New System.Drawing.Size(32, 17)
        Me.inforbl.TabIndex = 8
        Me.inforbl.Text = "属性"
        '
        'inforb
        '
        Me.inforb.Image = CType(resources.GetObject("inforb.Image"), System.Drawing.Image)
        Me.inforb.Location = New System.Drawing.Point(228, 8)
        Me.inforb.Name = "inforb"
        Me.inforb.Size = New System.Drawing.Size(40, 40)
        Me.inforb.TabIndex = 7
        Me.inforb.TabStop = False
        '
        'printviewrbl
        '
        Me.printviewrbl.AutoSize = True
        Me.printviewrbl.Location = New System.Drawing.Point(143, 53)
        Me.printviewrbl.Name = "printviewrbl"
        Me.printviewrbl.Size = New System.Drawing.Size(56, 17)
        Me.printviewrbl.TabIndex = 6
        Me.printviewrbl.Text = "打印预览"
        '
        'printviewrb
        '
        Me.printviewrb.Image = CType(resources.GetObject("printviewrb.Image"), System.Drawing.Image)
        Me.printviewrb.Location = New System.Drawing.Point(150, 8)
        Me.printviewrb.Name = "printviewrb"
        Me.printviewrb.Size = New System.Drawing.Size(40, 40)
        Me.printviewrb.TabIndex = 5
        Me.printviewrb.TabStop = False
        '
        'printrbl
        '
        Me.printrbl.AutoSize = True
        Me.printrbl.Location = New System.Drawing.Point(97, 53)
        Me.printrbl.Name = "printrbl"
        Me.printrbl.Size = New System.Drawing.Size(32, 17)
        Me.printrbl.TabIndex = 4
        Me.printrbl.Text = "打印"
        '
        'printrb
        '
        Me.printrb.Image = CType(resources.GetObject("printrb.Image"), System.Drawing.Image)
        Me.printrb.Location = New System.Drawing.Point(93, 8)
        Me.printrb.Name = "printrb"
        Me.printrb.Size = New System.Drawing.Size(40, 40)
        Me.printrb.TabIndex = 3
        Me.printrb.TabStop = False
        '
        'filerbl
        '
        Me.filerbl.AutoSize = True
        Me.filerbl.Location = New System.Drawing.Point(21, 53)
        Me.filerbl.Name = "filerbl"
        Me.filerbl.Size = New System.Drawing.Size(32, 17)
        Me.filerbl.TabIndex = 1
        Me.filerbl.Text = "打开"
        '
        'filerb
        '
        Me.filerb.Image = CType(resources.GetObject("filerb.Image"), System.Drawing.Image)
        Me.filerb.Location = New System.Drawing.Point(17, 8)
        Me.filerb.Name = "filerb"
        Me.filerb.Size = New System.Drawing.Size(40, 40)
        Me.filerb.TabIndex = 0
        Me.filerb.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(604, 67)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Silver
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 282
        Me.LineShape3.X2 = 282
        Me.LineShape3.Y1 = 1
        Me.LineShape3.Y2 = 65
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 205
        Me.LineShape2.X2 = 205
        Me.LineShape2.Y1 = 1
        Me.LineShape2.Y2 = 65
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 73
        Me.LineShape1.X2 = 73
        Me.LineShape1.Y1 = 1
        Me.LineShape1.Y2 = 65
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Azure
        Me.TabPage2.Controls.Add(Me.fsrbl)
        Me.TabPage2.Controls.Add(Me.fsrb)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(610, 73)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  查看  "
        '
        'fsrbl
        '
        Me.fsrbl.AutoSize = True
        Me.fsrbl.Location = New System.Drawing.Point(22, 53)
        Me.fsrbl.Name = "fsrbl"
        Me.fsrbl.Size = New System.Drawing.Size(32, 17)
        Me.fsrbl.TabIndex = 3
        Me.fsrbl.Text = "全屏"
        '
        'fsrb
        '
        Me.fsrb.Image = CType(resources.GetObject("fsrb.Image"), System.Drawing.Image)
        Me.fsrb.Location = New System.Drawing.Point(17, 8)
        Me.fsrb.Name = "fsrb"
        Me.fsrb.Size = New System.Drawing.Size(40, 40)
        Me.fsrb.TabIndex = 2
        Me.fsrb.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Azure
        Me.TabPage3.Controls.Add(Me.mspaintrbl)
        Me.TabPage3.Controls.Add(Me.mspaintrb)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(610, 73)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "  打开方式  "
        '
        'mspaintrbl
        '
        Me.mspaintrbl.AutoSize = True
        Me.mspaintrbl.Location = New System.Drawing.Point(22, 53)
        Me.mspaintrbl.Name = "mspaintrbl"
        Me.mspaintrbl.Size = New System.Drawing.Size(32, 17)
        Me.mspaintrbl.TabIndex = 5
        Me.mspaintrbl.Text = "画图"
        '
        'mspaintrb
        '
        Me.mspaintrb.Image = CType(resources.GetObject("mspaintrb.Image"), System.Drawing.Image)
        Me.mspaintrb.Location = New System.Drawing.Point(17, 8)
        Me.mspaintrb.Name = "mspaintrb"
        Me.mspaintrb.Size = New System.Drawing.Size(40, 40)
        Me.mspaintrb.TabIndex = 4
        Me.mspaintrb.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Azure
        Me.TabPage4.Controls.Add(Me.aboutrbl)
        Me.TabPage4.Controls.Add(Me.aboutrb)
        Me.TabPage4.Controls.Add(Me.prghlprbl)
        Me.TabPage4.Controls.Add(Me.prghlprb)
        Me.TabPage4.Controls.Add(Me.ShapeContainer2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(610, 73)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "  帮助  "
        '
        'aboutrbl
        '
        Me.aboutrbl.AutoSize = True
        Me.aboutrbl.Location = New System.Drawing.Point(91, 52)
        Me.aboutrbl.Name = "aboutrbl"
        Me.aboutrbl.Size = New System.Drawing.Size(32, 17)
        Me.aboutrbl.TabIndex = 10
        Me.aboutrbl.Text = "关于"
        '
        'aboutrb
        '
        Me.aboutrb.Image = CType(resources.GetObject("aboutrb.Image"), System.Drawing.Image)
        Me.aboutrb.Location = New System.Drawing.Point(86, 7)
        Me.aboutrb.Name = "aboutrb"
        Me.aboutrb.Size = New System.Drawing.Size(40, 40)
        Me.aboutrb.TabIndex = 9
        Me.aboutrb.TabStop = False
        '
        'prghlprbl
        '
        Me.prghlprbl.AutoSize = True
        Me.prghlprbl.Location = New System.Drawing.Point(22, 53)
        Me.prghlprbl.Name = "prghlprbl"
        Me.prghlprbl.Size = New System.Drawing.Size(32, 17)
        Me.prghlprbl.TabIndex = 7
        Me.prghlprbl.Text = "帮助"
        '
        'prghlprb
        '
        Me.prghlprb.Image = CType(resources.GetObject("prghlprb.Image"), System.Drawing.Image)
        Me.prghlprb.Location = New System.Drawing.Point(17, 8)
        Me.prghlprb.Name = "prghlprb"
        Me.prghlprb.Size = New System.Drawing.Size(40, 40)
        Me.prghlprb.TabIndex = 6
        Me.prghlprb.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer2.Size = New System.Drawing.Size(604, 67)
        Me.ShapeContainer2.TabIndex = 8
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 66
        Me.LineShape4.X2 = 66
        Me.LineShape4.Y1 = 1
        Me.LineShape4.Y2 = 65
        '
        'fastkeysub
        '
        Me.fastkeysub.Dock = System.Windows.Forms.DockStyle.None
        Me.fastkeysub.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.fastkeysub.Location = New System.Drawing.Point(42, 106)
        Me.fastkeysub.Name = "fastkeysub"
        Me.fastkeysub.Size = New System.Drawing.Size(56, 25)
        Me.fastkeysub.TabIndex = 11
        Me.fastkeysub.Text = "MenuStrip1"
        Me.fastkeysub.Visible = False
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullviewlinkToolStripMenuItem, Me.HelplinkToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(48, 21)
        Me.MainToolStripMenuItem.Text = "main"
        '
        'FullviewlinkToolStripMenuItem
        '
        Me.FullviewlinkToolStripMenuItem.Name = "FullviewlinkToolStripMenuItem"
        Me.FullviewlinkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.FullviewlinkToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FullviewlinkToolStripMenuItem.Text = "fullviewlink"
        '
        'HelplinkToolStripMenuItem
        '
        Me.HelplinkToolStripMenuItem.Name = "HelplinkToolStripMenuItem"
        Me.HelplinkToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelplinkToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.HelplinkToolStripMenuItem.Text = "helplink"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ribtab, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(618, 103)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'PictureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 459)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.fastkeysub)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.fastkeysub
        Me.MinimumSize = New System.Drawing.Size(424, 370)
        Me.Name = "PictureForm"
        Me.Text = "Open Picture Viewer"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.picturefullcm.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ribtab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.exitrb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inforb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printviewrb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printrb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filerb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.fsrb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.mspaintrb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.aboutrb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prghlprb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fastkeysub.ResumeLayout(False)
        Me.fastkeysub.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picturefullcm As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents closecm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents fscm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ribtab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents printviewrbl As System.Windows.Forms.Label
    Friend WithEvents printviewrb As System.Windows.Forms.PictureBox
    Friend WithEvents printrbl As System.Windows.Forms.Label
    Friend WithEvents printrb As System.Windows.Forms.PictureBox
    Friend WithEvents filerbl As System.Windows.Forms.Label
    Friend WithEvents filerb As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents inforbl As System.Windows.Forms.Label
    Friend WithEvents inforb As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents exitrbl As System.Windows.Forms.Label
    Friend WithEvents exitrb As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents fsrbl As System.Windows.Forms.Label
    Friend WithEvents fsrb As System.Windows.Forms.PictureBox
    Friend WithEvents mspaintrbl As System.Windows.Forms.Label
    Friend WithEvents mspaintrb As System.Windows.Forms.PictureBox
    Friend WithEvents prghlprbl As System.Windows.Forms.Label
    Friend WithEvents prghlprb As System.Windows.Forms.PictureBox
    Friend WithEvents aboutrbl As System.Windows.Forms.Label
    Friend WithEvents aboutrb As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents fastkeysub As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullviewlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelplinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel

End Class
