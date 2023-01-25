Public Class TabControls

    Private Sub TabControls_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        CheckedListBox1.Items.Add("อาหารพื้นเมือง")
        CheckedListBox1.Items.Add("ประเพณี")
        CheckedListBox1.Items.Add("กีฬา")
        CheckedListBox1.Items.Add("สถานที่ท่องเที่ยวยอดฮิต")
        CheckedListBox1.Items.Add("ศิลปะ")

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Select Case CheckedListBox1.SelectedIndex
            Case 0
                MsgBox("ต้องการดูข้อมูลเกี่ยวกับอาหารพื้นเมือง")
                PictureBox1.Image = My.Resources.Food
                Button1.Show()
                TextBox1.Text = "สูตรอาหารทั่วไปในแต่ละท้องถิ่น ลักษณะของอาหารจะแตกต่างกันตามภูมิอากาศ ภูมิประเทศ และ แหล่งวัตถุดิบ เป็นวัฒนธรรมการกินเพื่อการดำรงชีพ"
                Button1.Show()
            Case 1
                MsgBox("ต้องการดูข้อมูลเกี่ยวกับประเพณี")
                PictureBox1.Image = My.Resources.Trandition
                Button2.Show()
                TextBox1.Text = "พื้นที่ท้องถิ่นนั้นจะมีประเพณีที่แตกต่างกันออกไป แสดงให้เห็นถึงการใช้ชีวิต วัฒนธรรมที่เรียกว่าเป็นจุดเด่นของในภูมิภาค"
            Case 2
                MsgBox("ต้องการดูข้อมูลเกี่ยวกับกีฬา")
                PictureBox1.Image = My.Resources.Sport
                Button3.Show()
                TextBox1.Text = "กิจกรรมหรือการเล่นเพื่อความสนุกเพลิดเพลินหรือเพื่อผ่อนคลายความเคร่งเครียดทางจิต"
            Case 3
                MsgBox("ต้องการดูข้อมูลเกี่ยวกับสถานที่ท่องเที่ยวยอดฮิต")
                PictureBox1.Image = My.Resources.Travel
                Button4.Show()
                TextBox1.Text = "ที่เที่ยวยอดฮิต ที่ผู้คนชอบไปเที่ยวแบบทะเล ภูเขา วัด หรือน้ำตก "
            Case 4
                MsgBox("ต้องการดูข้อมูลเกี่ยวกับศิลปะ")
                PictureBox1.Image = My.Resources.Art
                Button5.Show()
                TextBox1.Text = "การสร้างสรรค์จากภูมิปัญญาของมนุษย์ที่ถ่ายทอดออกมา โดยผ่านสื่อวัสดุ เทคนิควิธีการต่างๆ มีคุณค่า ทั้งเนื้อหา เรื่องราวและความหมาย"
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Foods.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Trandition.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sport.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Travel.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Art.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Calculate.Show()
        Me.Hide()
    End Sub
End Class