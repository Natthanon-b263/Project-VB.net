<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Array_Enum_Struc
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LBLocation = New System.Windows.Forms.Label()
        Me.LBLocationType = New System.Windows.Forms.Label()
        Me.LBDistance = New System.Windows.Forms.Label()
        Me.LBRegionLocation = New System.Windows.Forms.Label()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtLocationType = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtRegionLocation = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(79, 264)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(185, 24)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "คลิกดูรายละเอียดเพิ่มเติม"
        '
        'LBLocation
        '
        Me.LBLocation.AutoSize = True
        Me.LBLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBLocation.Location = New System.Drawing.Point(172, 290)
        Me.LBLocation.Name = "LBLocation"
        Me.LBLocation.Size = New System.Drawing.Size(92, 24)
        Me.LBLocation.TabIndex = 1
        Me.LBLocation.Text = "ที่ตั้งสถานที่"
        '
        'LBLocationType
        '
        Me.LBLocationType.AutoSize = True
        Me.LBLocationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBLocationType.Location = New System.Drawing.Point(146, 326)
        Me.LBLocationType.Name = "LBLocationType"
        Me.LBLocationType.Size = New System.Drawing.Size(118, 24)
        Me.LBLocationType.TabIndex = 2
        Me.LBLocationType.Text = "ประเภทสถานที่"
        '
        'LBDistance
        '
        Me.LBDistance.AutoSize = True
        Me.LBDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBDistance.Location = New System.Drawing.Point(136, 374)
        Me.LBDistance.Name = "LBDistance"
        Me.LBDistance.Size = New System.Drawing.Size(128, 24)
        Me.LBDistance.TabIndex = 3
        Me.LBDistance.Text = "ระยะการเดินทาง"
        '
        'LBRegionLocation
        '
        Me.LBRegionLocation.AutoSize = True
        Me.LBRegionLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBRegionLocation.Location = New System.Drawing.Point(172, 415)
        Me.LBRegionLocation.Name = "LBRegionLocation"
        Me.LBRegionLocation.Size = New System.Drawing.Size(92, 24)
        Me.LBRegionLocation.TabIndex = 4
        Me.LBRegionLocation.Text = "ที่ตั้งภูมิภาค"
        '
        'BtnShow
        '
        Me.BtnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnShow.Location = New System.Drawing.Point(196, 451)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(110, 31)
        Me.BtnShow.TabIndex = 5
        Me.BtnShow.Text = "แสดงข้อมูล"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.งานที่ึ7_ณัฐนนท์_126.My.Resources.Resources.Doi_Inthanon
        Me.PictureBox1.Location = New System.Drawing.Point(117, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(473, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(271, 284)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(319, 30)
        Me.txtLocation.TabIndex = 7
        Me.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLocationType
        '
        Me.txtLocationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLocationType.Location = New System.Drawing.Point(271, 323)
        Me.txtLocationType.Multiline = True
        Me.txtLocationType.Name = "txtLocationType"
        Me.txtLocationType.Size = New System.Drawing.Size(319, 30)
        Me.txtLocationType.TabIndex = 8
        Me.txtLocationType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDistance
        '
        Me.txtDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDistance.Location = New System.Drawing.Point(271, 368)
        Me.txtDistance.Multiline = True
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(319, 30)
        Me.txtDistance.TabIndex = 9
        Me.txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRegionLocation
        '
        Me.txtRegionLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRegionLocation.Location = New System.Drawing.Point(271, 415)
        Me.txtRegionLocation.Multiline = True
        Me.txtRegionLocation.Name = "txtRegionLocation"
        Me.txtRegionLocation.Size = New System.Drawing.Size(319, 30)
        Me.txtRegionLocation.TabIndex = 10
        Me.txtRegionLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(558, 451)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(110, 31)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "ปิดโปรแกรม"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnPrevious.Location = New System.Drawing.Point(312, 451)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(110, 31)
        Me.BtnPrevious.TabIndex = 12
        Me.BtnPrevious.Text = "ก่อนหน้านี้"
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(428, 451)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(110, 31)
        Me.BtnNext.TabIndex = 13
        Me.BtnNext.Text = "ถัดไป"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'Array_Enum_Struc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(703, 491)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.txtRegionLocation)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.txtLocationType)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.LBRegionLocation)
        Me.Controls.Add(Me.LBDistance)
        Me.Controls.Add(Me.LBLocationType)
        Me.Controls.Add(Me.LBLocation)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Name = "Array_Enum_Struc"
        Me.Text = "การใช้งาน Array & Structure และ Enumeration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LBLocation As System.Windows.Forms.Label
    Friend WithEvents LBLocationType As System.Windows.Forms.Label
    Friend WithEvents LBDistance As System.Windows.Forms.Label
    Friend WithEvents LBRegionLocation As System.Windows.Forms.Label
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtLocationType As System.Windows.Forms.TextBox
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtRegionLocation As System.Windows.Forms.TextBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button

End Class
