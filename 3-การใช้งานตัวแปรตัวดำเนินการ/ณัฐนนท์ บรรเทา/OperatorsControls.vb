Public Class OperatorsControls
    Dim Num1, Num2, Total As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        If RadioButton1.Checked = True Then
            Total = Num1 + Num2
        ElseIf RadioButton2.Checked = True Then
            Total = Num1 - Num2
        ElseIf RadioButton3.Checked = True Then
            Total = Num1 * Num2
        ElseIf RadioButton4.Checked = True Then
            Total = Num1 / Num2
        ElseIf RadioButton5.Checked = True Then
            Total = Num1 \ Num2
        ElseIf RadioButton6.Checked = True Then
            Total = Num1 Mod Num2
        ElseIf RadioButton7.Checked = True Then
            Total = Num1 ^ Num2
        End If
        TextBox3.Text = Total
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataType.Show()
        Me.Show()
    End Sub
End Class