'****************************************************************
'PROJECT: Open Picture Viewer
'FILE: PictureForm.vb
'PURPOSE: Picture Viewer Main Module.
'AUTHOR: CJH
'****************************************************************

Imports System.IO
Imports System
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Public Class PictureForm
    Public cmdfile As String
    Public cmdfilew As String

    Public fopm As String
    Public fdnm As String

    Public fsci As Integer
    Public formst As Object
    Public openimg As String

    Private Sub PoctureForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fopm = Nothing
        fdnm = Nothing
        'For win11
        If Environment.GetEnvironmentVariable("ProgramFiles(x86)") = "" Then
            'x86
            If System.IO.File.Exists("C:\Windows\System32\mspaint.exe") = False Then
                mspaintrb.Visible = False
                mspaintrbl.Visible = False

            End If
        Else
            'x64
            If System.IO.File.Exists("C:\Windows\SysWOW64\mspaint.exe") = False Then
                mspaintrb.Visible = False
                mspaintrbl.Visible = False
            End If
        End If
        fsci = 0

        ' the PictureBox's SizeMode property to "Zoom".
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        OpenFileDialog1.Filter = "所有支持的文件 (*.png;*.jpg;*.jpeg;*.jpe;*.jfif;*.bmp;*.dib;*.gif;*.tif;*.tiff;*.ico)|*.png;*.jpg;*.jpeg;*.jpe;*.jfif;*.bmp;*.dib;*.gif;*.tif;*.tiff;*.ico|" _
                               & "PNG 图像 (*.png)|*.png|JPEG 文件 (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|" _
                               & "BMP 文件 (*.bmp;*.dib)|*.bmp;*.dib|GIF 图像 (*.gif)|*.gif|TIFF 文件 (*.tif;*.tiff)|*.tif;*.tiff|图标文件(*.ico)|*.ico|所有文件 (*.*)|*.*"

        If Command() <> "" Then
            cmdfile = Command()
        End If

        If cmdfile <> "" Then
            Call cmdpic()
        End If
    End Sub

    Sub cmdpic()
        '命令行加载图片
        cmdfilew = cmdfile

        If cmdfile = "/?" Then
            MsgBox("Open Picture Viewer 命令参数帮助" & vbCrLf _
                 & "使用方法：" & vbCrLf _
                 & "opv [命令参数]" & vbCrLf & vbCrLf _
                 & "命令参数为以下其中一项：" & vbCrLf _
                 & "/?         获取本帮助信息。" & vbCrLf _
                 & "%1         图片文件的路径。" _
                 , MsgBoxStyle.Information, "帮助")
        Else
            ' the PictureBox's SizeMode property to "Zoom".
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Image = Nothing
            openimg = cmdfilew
            fopm = Me.openimg
            fdnm = cmdfile

            Dim spstr As Boolean
            spstr = InStr(cmdfile, " ")
            'If spstr = False Then
            'Dim ttstr As Boolean
            'ttstr = InStr(cmdfile, Chr(34))
            'If ttstr = True Then
            cmdfile = cmdfile.Replace("""", "").Trim()
            'End If
            If System.IO.File.Exists(cmdfile) = True Then
                Try
                    PictureBox1.Load(cmdfile)
                    If PictureBox1.Image.Size.Height < 64 Then
                        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    ElseIf PictureBox1.Image.Size.Width < 64 Then
                        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    End If
                    Me.Text = PictureBox1.ImageLocation & " - Fly Picture Viewer"
                    OpenFileDialog1.FileName = cmdfile
                    openimg = cmdfile
                    cmdfile = ""
                    cmdfilew = ""
                Catch ex As Exception
                    PictureBox1.Image = (My.Resources.otimg)
                    Me.Text = "Fly Picture Viewer"
                    openimg = ""
                    cmdfile = ""
                End Try
            Else
                If cmdfile <> "" Then
                    MsgBox("尝试打开文件 " & Chr(34) & " " & cmdfile & " " & Chr(34) & " 出错。", MsgBoxStyle.Critical, "错误")
                End If
                openimg = ""
                cmdfile = ""
            End If
        End If
        fopm = Nothing
        fdnm = Nothing
        cmdfile = ""
    End Sub


    Private Sub infocmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infocmd.Click
        If openimg <> "" Then
            Dim imginfoa As New System.IO.FileInfo(openimg)
            infoform.Label7.Visible = True
            infoform.Text = imginfoa.Name & " 属性"

            infoform.Label2.Text = imginfoa.Name

            If 1024 > imginfoa.Length Then
                '小于1024字节，字节为单位
                infoform.Label3.Text = "大小: " & imginfoa.Length & " 字节"
            ElseIf 1024 > imginfoa.Length / 1024 Then
                '小于1024KB，KB为单位
                infoform.Label3.Text = "大小: " & imginfoa.Length / 1024 & " KB"
            ElseIf 1024 > imginfoa.Length / 1024 / 1024 Then
                '小于1024MB，MB为单位
                infoform.Label3.Text = "大小: " & imginfoa.Length / 1024 / 1024 & " MB"
            Else
                infoform.Label3.Text = "大小: " & imginfoa.Length / 1024 / 1024 / 1024 & " GB"
            End If

            infoform.Label4.Text = "创建时间: " & imginfoa.CreationTime
            infoform.Label5.Text = "修改时间: " & imginfoa.LastWriteTime
            If imginfoa.Extension.ToLower = ".png" Then
                infoform.Label6.Text = "类型: PNG 图像"
            ElseIf imginfoa.Extension.ToLower = ".jpg" Then
                infoform.Label6.Text = "类型: JPEG 图像"
            ElseIf imginfoa.Extension.ToLower = ".jpeg" Then
                infoform.Label6.Text = "类型: JPEG 图像"
            ElseIf imginfoa.Extension.ToLower = ".jpe" Then
                infoform.Label6.Text = "类型: JPEG 图像"
            ElseIf imginfoa.Extension.ToLower = ".jfif" Then
                infoform.Label6.Text = "类型: JPEG 图像"
            ElseIf imginfoa.Extension.ToLower = ".bmp" Then
                infoform.Label6.Text = "类型: BMP 文件"
            ElseIf imginfoa.Extension.ToLower = ".dib" Then
                infoform.Label6.Text = "类型: BMP 文件"
            ElseIf imginfoa.Extension.ToLower = ".gif" Then
                infoform.Label6.Text = "类型: GIF 图像"
            ElseIf imginfoa.Extension.ToLower = ".tif" Then
                infoform.Label6.Text = "类型: TIFF 文件"
            ElseIf imginfoa.Extension.ToLower = ".tiff" Then
                infoform.Label6.Text = "类型: TIFF 文件"
            ElseIf imginfoa.Extension.ToLower = ".ico" Then
                infoform.Label6.Text = "类型: 图标文件"
            Else
                infoform.Label6.Text = "类型: " & imginfoa.Extension.ToUpper
            End If

            Try
                infoform.Label7.Text = "大小: " & PictureBox1.Image.Width & " × " & PictureBox1.Image.Height
            Catch ex As Exception
                infoform.Label7.Visible = False
            End Try

            Try
                infoform.PictureBox2.Load(openimg)
            Catch ex As Exception
                infoform.Label7.Visible = False
                infoform.PictureBox2.Image = Nothing
            End Try

            infoform.ShowDialog()
        End If
    End Sub

    Private Sub closecmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closecmd.Click
        ' Clear the picture.
        PictureBox1.Image = Nothing
        openimg = ""
        OpenFileDialog1.FileName = ""
        Me.Text = "Open Picture Viewer"
    End Sub

    Private Sub fsccmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsccmd.Click
        If fsci = 0 Then
            fsci = 1
            formst = Me.WindowState
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = 0
            Me.WindowState = 2
            PictureBox1.BackColor = Color.Black
            TableLayoutPanel1.Visible = False
            TableLayoutPanel2.Visible = False
            PictureBox1.ContextMenuStrip = picturefullcm
        Else
            fsci = 0
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = formst
            formst = Nothing
            PictureBox1.BackColor = Color.White
            TableLayoutPanel1.Visible = True
            TableLayoutPanel2.Visible = True
            PictureBox1.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub closecm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closecm.Click
        closecmd_Click(sender, e)
    End Sub

    Private Sub fscm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fscm.Click
        fsccmd_Click(sender, e)
    End Sub
    '----------------------------------------------------

    Public Class NoSystemMenuException
        Inherits System.Exception
    End Class

    '这些值来自于MSDN 

    Public Enum ItemFlags
        ' The item dot.gif 

        mfUnchecked = &H0
        ' dot.gif is not checked 
        mfString = &H0
        ' dot.gif contains a string as label 
        mfDisabled = &H2
        ' dot.gif is disabled 
        mfGrayed = &H1
        ' dot.gif is grayed 
        mfChecked = &H8
        ' dot.gif is checked 
        mfPopup = &H10
        ' dot.gif Is a popup menu. Pass the 
        ' menu handle of the popup 
        ' menu into the ID parameter. 

        mfBarBreak = &H20
        ' dot.gif is a bar break 
        mfBreak = &H40
        ' dot.gif is a break 
        mfByPosition = &H400
        ' dot.gif is identified by the position 
        mfByCommand = &H0
        ' dot.gif is identified by its ID 
        mfSeparator = &H800
    End Enum
    ' dot.gif is a seperator (String and 
    ' ID parameters are ignored). 

    Public Enum WindowMessages
        wmSysCommand = &H112
    End Enum

    ' 
    ' 帮助实现操作系统菜单的类的定义 
    '''. 
    '注意：用P/Invoke调用动态链接库中非托管函数时，应执行如下步骤： 
    '1，定位包含该函数的DLL。 
    '2，把该DLL库装载入内存。 
    '3，找到即将调用的函数地址，并将所有的现场压入堆栈。 
    '4，调用函数。 
    ' 

    Public Class SystemMenu
        ' 提示：C＃把函数声明为外部的，而且使用属性DllImport来指定DLL 
        '和任何其他可能需要的参数。 
        ' 首先，我们需要GetSystemMenu() 函数 
        ' 注意这个函数没有Unicode 版本 

        <DllImport("USER32", EntryPoint:="GetSystemMenu", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.Winapi)> _
        Private Shared Function apiGetSystemMenu(ByVal WindowHandle As IntPtr, ByVal bReset As Integer) As IntPtr
        End Function



        ' 还需要AppendMenu()。 既然 .NET 使用Unicode, 
        ' 我们应该选取它的Unicode版本。 

        <DllImport("USER32", EntryPoint:="AppendMenuW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.Winapi)> _
        Private Shared Function apiAppendMenu(ByVal MenuHandle As IntPtr, ByVal Flags As Integer, ByVal NewID As Integer, ByVal Item As String) As Integer
        End Function

        '还可能需要InsertMenu() 

        <DllImport("USER32", EntryPoint:="InsertMenuW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.Winapi)> _
        Private Shared Function apiInsertMenu(ByVal hMenu As IntPtr, ByVal Position As Integer, ByVal Flags As Integer, ByVal NewId As Integer, ByVal Item As String) As Integer
        End Function

        Private m_SysMenu As IntPtr = IntPtr.Zero
        ' 系统菜单句柄 
        Public Sub New()

        End Sub

        ' 在给定的位置（以0为索引开始值）插入一个分隔条 

        Public Function InsertSeparator(ByVal Pos As Integer) As Boolean
            Return (InsertMenu(Pos, ItemFlags.mfSeparator Or ItemFlags.mfByPosition, 0, ""))
        End Function

        ' 简化的InsertMenu()，前提――Pos参数是一个0开头的相对索引位置 

        Public Function InsertMenu(ByVal Pos As Integer, ByVal ID As Integer, ByVal Item As String) As Boolean
            Return (InsertMenu(Pos, ItemFlags.mfByPosition Or ItemFlags.mfString, ID, Item))
        End Function

        ' 在给定位置插入一个菜单项。具体插入的位置取决于Flags 

        Public Function InsertMenu(ByVal Pos As Integer, ByVal Flags As ItemFlags, ByVal ID As Integer, ByVal Item As String) As Boolean
            ' Return (apiInsertMenu(m_SysMenu, Pos, DirectCast(Flags, Int32), ID, Item) = 0)
            Return (apiInsertMenu(m_SysMenu, Pos, CType(Flags, Int32), ID, Item) = 0)
        End Function

        ' 添加一个分隔条 

        Public Function AppendSeparator() As Boolean
            Return AppendMenu(0, "", ItemFlags.mfSeparator)
        End Function

        ' 使用ItemFlags.mfString 作为缺省值 

        Public Function AppendMenu(ByVal ID As Integer, ByVal Item As String) As Boolean
            Return AppendMenu(ID, Item, ItemFlags.mfString)
        End Function

        ' 被取代的函数 

        Public Function AppendMenu(ByVal ID As Integer, ByVal Item As String, ByVal Flags As ItemFlags) As Boolean
            Return (apiAppendMenu(m_SysMenu, CInt(Flags), ID, Item) = 0)
        End Function

        '从一个Form对象检索一个新对象 
        Public Shared Function FromForm(ByVal Frm As Form) As SystemMenu
            Dim cSysMenu As New SystemMenu
            cSysMenu.m_SysMenu = apiGetSystemMenu(Frm.Handle, 0)

            If cSysMenu.m_SysMenu.Equals(IntPtr.Zero) Then
                ' 一旦失败，引发一个异常 
                Throw New NoSystemMenuException
            End If
            Return cSysMenu
        End Function

        ' 当前窗口菜单还原 
        Public Shared Sub ResetSystemMenu(ByVal Frm As Form)
            apiGetSystemMenu(Frm.Handle, 1)
        End Sub

        ' 检查是否一个给定的ID在系统菜单ID范围之内 

        Public Shared Function VerifyItemID(ByVal ID As Integer) As Boolean
            Return CBool((ID < &HF000 AndAlso ID > 0))
        End Function
    End Class
    '调用代码如下:

    Private Const m_OpenID As Integer = &H100
    Private Const m_FsID As Integer = &H101
    Private Const m_InfoID As Integer = &H102
    Private Const m_AboutID As Integer = &H103




    Protected Overloads Overrides Sub WndProc(ByRef msg As Message)
        ' 通过截取WM_SYSCOMMAND消息并进行处理 
        ' 注意，消息WM_SYSCOMMAND被定义在WindowMessages枚举类中 
        ' 消息的WParam参数包含点击的项的ID 
        ' 该值与通过上面类的InsertMenu()或AppendMenu()成员函数传递的一样 

        If msg.Msg = CInt(WindowMessages.wmSysCommand) Then
            Select Case msg.WParam.ToInt32()
                Case m_OpenID
                    If True Then
                        ' “打开”菜单项 
                        ' Show the Open File dialog. If the user clicks OK, load the
                        ' picture that the user chose.
                        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                            PictureBox1.Image = Nothing
                            openimg = OpenFileDialog1.FileName
                            fopm = Me.openimg
                            fdnm = Me.OpenFileDialog1.FileName
                            Dim imgminfo As New System.IO.FileInfo(Me.openimg)
                            Me.Text = imgminfo.Name & " - Open Picture Viewer"
                            Try
                                PictureBox1.Load(OpenFileDialog1.FileName)
                            Catch ex As Exception
                                openimg = OpenFileDialog1.FileName
                                OpenFileDialog1.FileName = ""

                                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                                If imgminfo.Length = 0 Then
                                    PictureBox1.Image = (My.Resources.noimg)
                                ElseIf imgminfo.Length <> 0 Then
                                    PictureBox1.Image = (My.Resources.wrimg)
                                Else
                                    PictureBox1.Image = (My.Resources.otimg)
                                End If
                                Me.Text = "Open Picture Viewer"
                            End Try
                            fopm = Nothing
                            fdnm = Nothing
                        End If
                    End If
                    Exit Select
                Case m_FsID
                    fsci = 1
                    formst = Me.WindowState
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    Me.WindowState = 0
                    Me.WindowState = 2
                    PictureBox1.BackColor = Color.Black
                    TableLayoutPanel1.Visible = False
                    TableLayoutPanel2.Visible = False
                    PictureBox1.ContextMenuStrip = picturefullcm
                    Exit Select
                Case m_InfoID
                    If True Then
                        ' “属性”菜单项 
                        If openimg <> "" Then
                            Dim imginfoa As New System.IO.FileInfo(openimg)
                            infoform.Label7.Visible = True
                            infoform.Text = imginfoa.Name & " 属性"

                            infoform.Label2.Text = imginfoa.Name

                            If 1024 > imginfoa.Length Then
                                '小于1024字节，字节为单位
                                infoform.Label3.Text = "大小: " & imginfoa.Length & " 字节"
                            ElseIf 1024 > imginfoa.Length / 1024 Then
                                '小于1024KB，KB为单位
                                infoform.Label3.Text = "大小: " & imginfoa.Length / 1024 & " KB"
                            ElseIf 1024 > imginfoa.Length / 1024 / 1024 Then
                                '小于1024MB，MB为单位
                                infoform.Label3.Text = "大小: " & imginfoa.Length / 1024 / 1024 & " MB"
                            Else
                                infoform.Label3.Text = "大小: " & imginfoa.Length / 1024 / 1024 / 1024 & " GB"
                            End If

                            infoform.Label4.Text = "创建时间: " & imginfoa.CreationTime
                            infoform.Label5.Text = "修改时间: " & imginfoa.LastWriteTime
                            If imginfoa.Extension.ToLower = ".png" Then
                                infoform.Label6.Text = "类型: PNG 图像"
                            ElseIf imginfoa.Extension.ToLower = ".jpg" Then
                                infoform.Label6.Text = "类型: JPEG 图像"
                            ElseIf imginfoa.Extension.ToLower = ".jpeg" Then
                                infoform.Label6.Text = "类型: JPEG 图像"
                            ElseIf imginfoa.Extension.ToLower = ".jpe" Then
                                infoform.Label6.Text = "类型: JPEG 图像"
                            ElseIf imginfoa.Extension.ToLower = ".jfif" Then
                                infoform.Label6.Text = "类型: JPEG 图像"
                            ElseIf imginfoa.Extension.ToLower = ".bmp" Then
                                infoform.Label6.Text = "类型: BMP 文件"
                            ElseIf imginfoa.Extension.ToLower = ".dib" Then
                                infoform.Label6.Text = "类型: BMP 文件"
                            ElseIf imginfoa.Extension.ToLower = ".gif" Then
                                infoform.Label6.Text = "类型: GIF 图像"
                            ElseIf imginfoa.Extension.ToLower = ".tif" Then
                                infoform.Label6.Text = "类型: TIFF 文件"
                            ElseIf imginfoa.Extension.ToLower = ".tiff" Then
                                infoform.Label6.Text = "类型: TIFF 文件"
                            ElseIf imginfoa.Extension.ToLower = ".ico" Then
                                infoform.Label6.Text = "类型: 图标文件"
                            Else
                                infoform.Label6.Text = "类型: " & imginfoa.Extension.ToUpper
                            End If

                            Try
                                infoform.Label7.Text = "大小: " & PictureBox1.Image.Width & " × " & PictureBox1.Image.Height
                            Catch ex As Exception
                                infoform.Label7.Visible = False
                            End Try

                            Try
                                infoform.PictureBox2.Load(openimg)
                            Catch ex As Exception
                                infoform.Label7.Visible = False
                                infoform.PictureBox2.Image = Nothing
                            End Try

                            infoform.ShowDialog()
                        End If
                    End If
                    Exit Select
                Case m_AboutID
                    If True Then
                        ' “关于”菜单项 
                        aboutform.ShowDialog()
                    End If
                    Exit Select
                    ' 这里可以针对另外的菜单项设计处理过程 
            End Select
        End If
        ' 调用基类函数 

        MyBase.WndProc(msg)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim m_SystemMenu As SystemMenu = SystemMenu.FromForm(Me)

            '分隔线
            m_SystemMenu.AppendSeparator()
            ' 添加"打开" 菜单项 
            m_SystemMenu.AppendMenu(m_OpenID, "打开(&O)")

            ' 添加"全屏" 菜单项 
            m_SystemMenu.AppendMenu(m_FsID, "全屏")

            ' 添加"属性" 菜单项 
            m_SystemMenu.AppendMenu(m_InfoID, "属性(&I)")

            '分隔线
            m_SystemMenu.AppendSeparator()
            ' 添加"关于" 菜单项 
            m_SystemMenu.AppendMenu(m_AboutID, "关于 Open Picture Viewer(&A)")

        Catch generatedExceptionName As NoSystemMenuException
            MsgBox(generatedExceptionName.ToString, MsgBoxStyle.Critical, "错误")
            ' error
            ' 建立你的错误处理器 
        End Try
    End Sub


    '-------------------------------------------------------------
    '处理Tab里的菜单事件

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If OpenFileDialog1.FileName <> "" Then
            Dim g As Graphics = e.Graphics
            g.DrawImage(PictureBox1.Image, New Rectangle(0, 0, PrintPreviewDialog1.Document.PrinterSettings.DefaultPageSettings.PaperSize.Width, PrintPreviewDialog1.Document.PrinterSettings.DefaultPageSettings.PaperSize.Height), New Rectangle(0, 0, PictureBox1.Image.Width, PictureBox1.Image.Height), GraphicsUnit.Pixel)
        End If
    End Sub

    Private Sub filerb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filerb.Click
        ' Show the Open File dialog. If the user clicks OK, load the
        ' picture that the user chose.
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' the PictureBox's SizeMode property to "Zoom".
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Image = Nothing
            openimg = OpenFileDialog1.FileName
            fopm = Me.openimg
            fdnm = Me.OpenFileDialog1.FileName
            Dim imgminfo As New System.IO.FileInfo(Me.openimg)
            Me.Text = imgminfo.Name & " - Open Picture Viewer"
            Try
                PictureBox1.Load(OpenFileDialog1.FileName)
            Catch ex As Exception
                openimg = OpenFileDialog1.FileName
                OpenFileDialog1.FileName = ""

                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                If imgminfo.Length = 0 Then
                    PictureBox1.Image = (My.Resources.noimg)
                ElseIf imgminfo.Length <> 0 Then
                    PictureBox1.Image = (My.Resources.wrimg)
                Else
                    PictureBox1.Image = (My.Resources.otimg)
                End If
                Me.Text = "Open Picture Viewer"
            End Try
            fopm = Nothing
            fdnm = Nothing
        End If
    End Sub

    Private Sub printrb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printrb.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDialog1.Document.Print()
        End If
    End Sub

    Private Sub printviewrb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printviewrb.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowIcon = False
        PrintPreviewDialog1.Size = New Size(500, 450)
        PrintPreviewDialog1.AutoSizeMode = AutoSizeMode.GrowOnly
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub inforb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inforb.Click
        infocmd_Click(sender, e)
    End Sub

    Private Sub exitrb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitrb.Click
        End
    End Sub

    Private Sub fsrb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsrb.Click
        fsccmd_Click(sender, e)
    End Sub

    Private Sub mspaintrb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mspaintrb.Click
        Shell("mspaint.exe " & Chr(34) & openimg & Chr(34), AppWinStyle.NormalFocus)
        'mspaint.exe "file.bmp"
    End Sub

    Private Sub prghlprb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prghlprb.Click
        MsgBox("该版本没有帮助。", MsgBoxStyle.Exclamation, "提示")
    End Sub

    Private Sub aboutrb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutrb.Click
        aboutform.ShowDialog()
    End Sub


    '-------------------------------------
    Private Sub FullviewlinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullviewlinkToolStripMenuItem.Click
        fsccmd_Click(sender, e)
    End Sub

    Private Sub HelplinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelplinkToolStripMenuItem.Click
        prghlprb_Click(sender, e)
    End Sub
End Class
