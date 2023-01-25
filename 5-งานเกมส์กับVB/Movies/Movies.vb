Public Class Movies

    Dim films As String() = New String() {"สุริโยไท 2544", "พี่มาก..พระโขนง 2556", "กวนมึนโฮ 2553", "นาคี 2559", "บุพเพสันนิวาส 2561", "วันทอง 2564", "คู่กรรม", "ตํานานสมเด็จนเรศวรมหาราช", "สี่แผ่นดิน", "ไททานิค"}
    Dim blnUsed As Boolean() = New Boolean(films.GetUpperBound(0)) {}
    Dim Count As Integer = 1
    Dim Movies As String
    Dim score As Integer
    Private Sub Movies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        BtnNext.Hide()
        Array.Sort(films)
        ComboBox1.DataSource = films
        DisplayFilms()
    End Sub
    Function BuildPathName() As String
        Dim Output As String = Movies
        Output &= ".jpg"
        Return Output
    End Function
    Function GetRandomNum() As Integer
        Dim ObjRandom As Random = New Random
        Dim intRandom As Integer
        Do
            intRandom = ObjRandom.Next(0, blnUsed.Length)
        Loop Until blnUsed(intRandom) = False
        blnUsed(intRandom) = True
        Return intRandom
    End Function
    Sub DisplayFilms()
        Dim intRandom As Integer = GetRandomNum()
        Movies = films(intRandom)
        Dim Path As String = BuildPathName()
        PictureBox1.Image = My.Resources.ResourceManager.GetObject(Movies)

        Me.Text = "ผลทาย : ครั้งที่" & Count
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Details.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox1.Text = "1. คลิกคำตอบจาก ComboBox แล้วคลิกทายผล"
        TextBox2.Text = "2. คลิกรูปถัดไปจากนั้น ทำเช่นเดี่ยวกับ ข้อ 1."
        TextBox3.Text = "3. เมื่อครบทุกรูปภาพแล้ว ให้คลิก Close เพื่อปิดโปรแกรม"

    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Label2.Text = ""
        ComboBox1.SelectedIndex = 0
        Count += 1
        BtnAnswer.Enabled = True
        BtnNext.Enabled = False
        DisplayFilms()
    End Sub
    Private Sub BtnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnswer.Click
        Dim strResponse As String = Convert.ToString(ComboBox1.SelectedValue)
        If strResponse = Movies Then
            Label2.Text = "ถะ ถะ ถูกต้องนะคร๊าบบบบ!!"
            score += 1
            Label4.Text = score
        Else
            Label2.Text = "ผะ ผะ ผิดครับบบบ!!"
        End If
        BtnNext.Show()
        If Count >= 10 Then
            Label2.Text &= ControlChars.CrLf & " GameOver"
            BtnNext.Enabled = False
            BtnAnswer.Enabled = False
            ComboBox1.Enabled = False
        Else
            BtnAnswer.Enabled = False
            BtnNext.Enabled = True
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        End
    End Sub

End Class


