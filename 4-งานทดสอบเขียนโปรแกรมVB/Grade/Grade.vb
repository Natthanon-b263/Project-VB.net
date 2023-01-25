Public Class Grade

    Private Sub Cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cal.Click
        Dim s1, s2, total As Single
        s1 = txt_score1.Text
        s2 = txt_score2.Text
        total = s1 + s2
        txt_total.Text = total

        If total >= 80 And total <= 100 Then
            txt_grade.Text = "A"
        ElseIf total >= 75 And total <= 79 Then
            txt_grade.Text = "B+"
        ElseIf total >= 70 And total <= 74 Then
            txt_grade.Text = "B"
        ElseIf total >= 65 And total <= 69 Then
            txt_grade.Text = "C+"
        ElseIf total >= 60 And total <= 64 Then
            txt_grade.Text = "C"
        ElseIf total >= 55 And total <= 59 Then
            txt_grade.Text = "D+"
        ElseIf total >= 50 And total <= 54 Then
            txt_grade.Text = "D"
        ElseIf total >= 0 And total <= 49 Then
            txt_grade.Text = "F"
        Else
            txt_grade.Text = "ERROR"
        End If
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        txt_score1.Text = ""
        txt_score2.Text = ""
        txt_total.Text = ""
        txt_grade.Text = ""
    End Sub

    Private Sub Out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Out.Click
        End
    End Sub
End Class
