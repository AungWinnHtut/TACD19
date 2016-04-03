Public Class frmHello


    Private Sub btnNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotepad.Click
        Shell("notepad", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnPaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaint.Click
        Shell("mspaint", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmd.Click
        Shell("cmd", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("C:\Program Files\CodeBlocks\codeblocks.exe", AppWinStyle.MaximizedFocus)
    End Sub
End Class
