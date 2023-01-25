Public Class Dialog

    Private Sub PageSetUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetUpToolStripMenuItem.Click
      If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub ForeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
        Label2.ForeColor = ColorDialog1.Color
    End Sub
    Private Sub BackColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Label1.BackColor = ColorDialog1.Color
        Label2.BackColor = ColorDialog1.Color
    End Sub

    Private Sub DateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateAndTime.DateString
        Label2.Text = DateAndTime.TimeString
    End Sub
    Private Sub FontSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontSizeToolStripMenuItem.Click
        With FontDialog1
            .Font = Label1.Font
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Label1.Font = .Font
                Label2.Font = .Font
            End If
        End With
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OpenPicture1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPicture1.Click
        OpenFileDialog1.Filter = "Picture Files(*.Bitmap, *.Gif, *.Jpg) | *.bmp; *.gif; *.jpg"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class