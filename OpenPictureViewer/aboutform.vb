Public Class aboutform

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreateClipBoard(LinkLabel1.Text)
        MsgBox("链接已复制。", MsgBoxStyle.Information, "提示")
    End Sub
    ' 拷贝复制数据到粘贴板
    Private Sub CreateClipBoard(ByVal CopyText As String)
        Clipboard.Clear() ' 清除剪贴板
        Clipboard.SetText(CopyText) ' 拷贝数据到粘贴板
    End Sub
    ' 获取粘贴板数据到文本框
    'Private Sub PasteClipBoard()
    '    LinkLabel1.Text = Clipboard.GetText()
    'End Sub
End Class