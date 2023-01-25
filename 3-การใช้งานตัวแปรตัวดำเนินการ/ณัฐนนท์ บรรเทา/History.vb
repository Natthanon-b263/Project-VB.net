Public Class History

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = "ณัฐนนท์ บรรเทา"
        TextBox2.Text = "บ้านเลขที่ 69/64 ถนนกาญจนาภิเษก ตำบลบางแม่นาง อำเภอบางใหญ่ จังหวัดนนทบุรี 11140"
        TextBox3.Text = "natthanon263.b@gmail.com"
        TextBox4.Text = "062-530-2060"
        TextBox5.Text = "โอ"
        TextBox6.Text = "20 ปี"
        TextBox7.Text = "ส้มตำ"
        TextBox8.Text = "ไทยสากล-ลูกทุ่ง"
        TextBox9.Text = "ความพยายามอยู่ที่ไหน ความสำเร็จอยู่ที่นั้น"
        PictureBox1.Image = My.Resources.image
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Calculate.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
End Class
