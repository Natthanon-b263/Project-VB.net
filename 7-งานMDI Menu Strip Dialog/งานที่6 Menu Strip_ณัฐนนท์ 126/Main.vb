Public Class Main

    Private Sub DialogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogsToolStripMenuItem.Click
        Dialog.Show()
        Dialog.MdiParent = Me
        Songs.Hide()
    End Sub
    Private Sub SongsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SongsToolStripMenuItem.Click
        Songs.Show()
        Songs.MdiParent = Me
        Dialog.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
