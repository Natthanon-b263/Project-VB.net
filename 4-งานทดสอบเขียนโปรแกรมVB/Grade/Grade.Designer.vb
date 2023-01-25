<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grade))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_score1 = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_score2 = New System.Windows.Forms.TextBox()
        Me.txt_grade = New System.Windows.Forms.TextBox()
        Me.Cal = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Out = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH Sarabun New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "คะแนนกลางภาค"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("TH Sarabun New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "คะแนนปลายภาค"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("TH Sarabun New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "คะแนนรวม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("TH Sarabun New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 279)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 36)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เกรดที่ได้"
        '
        'txt_score1
        '
        Me.txt_score1.Font = New System.Drawing.Font("TH Sarabun New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_score1.Location = New System.Drawing.Point(239, 63)
        Me.txt_score1.Multiline = True
        Me.txt_score1.Name = "txt_score1"
        Me.txt_score1.Size = New System.Drawing.Size(186, 39)
        Me.txt_score1.TabIndex = 4
        Me.txt_score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("TH Sarabun New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_total.Location = New System.Drawing.Point(239, 207)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(186, 39)
        Me.txt_total.TabIndex = 5
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_score2
        '
        Me.txt_score2.Font = New System.Drawing.Font("TH Sarabun New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_score2.Location = New System.Drawing.Point(239, 141)
        Me.txt_score2.Multiline = True
        Me.txt_score2.Name = "txt_score2"
        Me.txt_score2.Size = New System.Drawing.Size(186, 39)
        Me.txt_score2.TabIndex = 6
        Me.txt_score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_grade
        '
        Me.txt_grade.BackColor = System.Drawing.Color.Silver
        Me.txt_grade.Font = New System.Drawing.Font("TH Sarabun New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_grade.ForeColor = System.Drawing.Color.Red
        Me.txt_grade.Location = New System.Drawing.Point(73, 318)
        Me.txt_grade.Name = "txt_grade"
        Me.txt_grade.Size = New System.Drawing.Size(130, 71)
        Me.txt_grade.TabIndex = 7
        Me.txt_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cal
        '
        Me.Cal.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cal.Location = New System.Drawing.Point(239, 288)
        Me.Cal.Name = "Cal"
        Me.Cal.Size = New System.Drawing.Size(186, 41)
        Me.Cal.TabIndex = 8
        Me.Cal.Text = "คำนวณเกรด"
        Me.Cal.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.Red
        Me.Clear.Location = New System.Drawing.Point(239, 338)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(186, 41)
        Me.Clear.TabIndex = 9
        Me.Clear.Text = "ล้างข้อมูล"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Out
        '
        Me.Out.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Out.Location = New System.Drawing.Point(239, 385)
        Me.Out.Name = "Out"
        Me.Out.Size = New System.Drawing.Size(186, 41)
        Me.Out.TabIndex = 10
        Me.Out.Text = "ออกโปรแกรม"
        Me.Out.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(525, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 288)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไข"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 252)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(525, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 129)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ผู้พัฒนา"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 84)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "นายณัฐนนท์ บรรเทา" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รหัสนศ.056250201126-4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ปวค.62/2"
        '
        'Grade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(827, 506)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Out)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Cal)
        Me.Controls.Add(Me.txt_grade)
        Me.Controls.Add(Me.txt_score2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_score1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Grade"
        Me.Text = "โปรแกรมคำนวณเกรดนักศึกษา"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_score1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_score2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_grade As System.Windows.Forms.TextBox
    Friend WithEvents Cal As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Out As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
