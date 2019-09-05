Public Class Main
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim ex As New textTab()
        ex.Text = "New Text"
        ccmain.AddTab(ex)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim fl As New OpenFileDialog
        If fl.ShowDialog() = DialogResult.OK Then
            Dim ex As New textTab(fl.FileName)
            If ex.WasOpened Then
                ccmain.AddTab(ex)
            Else
                ex.Dispose()
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, SaveToolStripMenuItem1.Click
        ccmain.SelectedTab.Save()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        ccmain.SelectedTab.Save(True)
    End Sub

    Private Sub ChangeKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeKeyToolStripMenuItem.Click
        DirectCast(ccmain.SelectedTab, textTab).ChangeKey()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ccmain.RemoveTab(ccmain.SelectedTab)
    End Sub

End Class
