Public Class DataType
    Dim sh As Short
    Dim int As Integer
    Dim lon As Long
    Dim sin As Single
    Dim dou As Double
    Dim dec As Decimal
    Dim byt As Byte
    Dim cha As Char
    Dim str As String
    Dim Boo As Boolean
    Dim Day As Date
    Dim Obj As Object

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControls.Show()
        Me.Hide()
    End Sub

    Private Sub DataType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("1.Short")
        ListBox1.Items.Add("2.Integer")
        ListBox1.Items.Add("3.Long")
        ListBox1.Items.Add("4.Single")
        ListBox1.Items.Add("5.Double")
        ListBox1.Items.Add("6.Decimal")
        ListBox1.Items.Add("7.Byte")
        ListBox1.Items.Add("8.Char")
        ListBox1.Items.Add("9.Sting")
        ListBox1.Items.Add("10.Boolean")
        ListBox1.Items.Add("11.Date")
        ListBox1.Items.Add("12.Object")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                sh = 32737
                Label3.Text = sh
                TextBox1.Text = "ขนาดข้อมูล 16 บิต ช่วงค่าที่เก็บได้ -32,768 ถึง 32,767"
            Case 1
                Int = 2147483647
                Label3.Text = Int
                TextBox1.Text = "ขนาดข้อมูล 32 บิต ช่วงค่าที่เก็บได้ - 2,147,483,648 ถึง 2,147,483,647"
            Case 2
                lon = 9223372036854775807
                Label3.Text = lon
                TextBox1.Text = "ขนาดข้อมูล 64 บิต "
            Case 3
                Sin = 1.401298
                Label3.Text = Sin
                TextBox1.Text = "ขนาดข้อมูล 32 บิต "
            Case 4
                dou = 4.9406564
                Label3.Text = dou
                TextBox1.Text = "ขนาดข้อมูล 64 บิต "
            Case 5
                dec = 7.9228162514264335
                Label3.Text = dec
                TextBox1.Text = "ขนาดข้อมูล 128 บิต "
            Case 6
                byt = 255
                Label3.Text = byt
                TextBox1.Text = "ขนาดข้อมูล 8 บิต "
            Case 7
                cha = "S"
                Label3.Text = cha
                TextBox1.Text = "ขนาดข้อมูล 16 บิต "
            Case 8
                str = " สวัสดี / Hello"
                Label3.Text = str
                TextBox1.Text = "ขนาดข้อมูล 16 บิต ต่อ 1 ตัวอักษร "
            Case 9
                Boo = True
                Label3.Text = Boo
                TextBox1.Text = "ขนาดข้อมูล 16 บิต "
            Case 10
                Day = #7/11/2008#
                Label3.Text = Day
                TextBox1.Text = "ขนาดข้อมูล 64 บิต "
            Case 11
                Obj = " EveryThings "
                Label3.Text = Obj
                TextBox1.Text = "ขนาดข้อมูล 32 บิต "
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OperatorsControls.Show()
        Me.Hide()
    End Sub
End Class