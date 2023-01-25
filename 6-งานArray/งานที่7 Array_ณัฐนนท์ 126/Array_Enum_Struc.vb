Public Class Array_Enum_Struc
    'ประกาศตัวแปร ประเภท Enumeration (ตัวแปรชุดที่เป็นชนิดเดียวกัน)
    Enum province
        จังหวัดเชียงใหม่
        จังหวัดน่าน
        จังหวัดตาก
    End Enum
    'ประกาศตัวแปร Enumeration
    Enum category
        ภูเขา
        วัด
        น้ำตก
    End Enum
    'ประกาศค่าตัวแปร Structure (ตัวแปรชุด ต่างชนิดกันได้)
    Structure Detial
        Dim Names As province
        Dim Types As category
        Dim Distance As String
        Dim location As String
        Dim pics As Object
    End Structure
    Dim MP(2) As Detial 'ประการตัวแปรอาร์เรย์ เก็บข้อมูล 3 ชุด
    Dim CurrentMP As Integer = 0 'กหนดให้แสดงข้อมูลแรกก่อน
    'โพรซีเยอร์ใช้แสดงข้อมูลที่มีหลายหมายเลขลาดับเท่ากับ CurrentMP
    Sub ShowCurrentclip()
        txtLocation.Text = MP(CurrentMP).Names.ToString
        txtLocationType.Text = MP(CurrentMP).Types.ToString
        txtDistance.Text = MP(CurrentMP).Distance
        txtRegionLocation.Text = MP(CurrentMP).location
        PictureBox1.Image = MP(CurrentMP).pics
    End Sub
    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        MP(0).Names = province.จังหวัดเชียงใหม่
        MP(0).Types = category.ภูเขา
        MP(0).Distance = "จากเมืองเชียงใหม่ 106 กิโลเมตร"
        MP(0).location = "ภาคเหนือตอนบน"
        MP(0).pics = My.Resources.Doi_Inthanon

        MP(1).Names = province.จังหวัดน่าน
        MP(1).Types = category.วัด
        MP(1).Distance = "อยู่ไม่ไกลกันมากจากเมืองน่าน"
        MP(1).location = "ภาคเหนือตอนบน"
        MP(1).pics = My.Resources.Wat_Phumin

        MP(2).Names = province.จังหวัดตาก
        MP(2).Types = category.น้ำตก
        MP(2).Distance = "จากอำเภอแม่สอดประมาณ 230 กิโลเมตร"
        MP(2).location = "ภาคเหนือตอนล่าง"
        MP(2).pics = My.Resources.Thi_Lo_Su_Waterfall
        ShowCurrentclip()
    End Sub
    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        If CurrentMP > 0 Then
            CurrentMP -= 1
            ShowCurrentclip()
        End If
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If CurrentMP < 2 Then
            CurrentMP += 1
            ShowCurrentclip()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Details.Show()
        Me.Hide()
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub
End Class