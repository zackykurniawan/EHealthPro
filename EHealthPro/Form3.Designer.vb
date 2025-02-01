<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        GroupBox1 = New GroupBox()
        radioHigh = New RadioButton()
        radioMedium = New RadioButton()
        radioLow = New RadioButton()
        Label8 = New Label()
        cmbGender = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtHeight = New TextBox()
        Label2 = New Label()
        txtWeight = New TextBox()
        txtAge = New TextBox()
        Label1 = New Label()
        listResults = New ListBox()
        btnPrint = New Button()
        btnReset = New Button()
        btnCount = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioHigh)
        GroupBox1.Controls.Add(radioMedium)
        GroupBox1.Controls.Add(radioLow)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cmbGender)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtHeight)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtWeight)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(415, 264)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Masukkan data"
        ' 
        ' radioHigh
        ' 
        radioHigh.AutoSize = True
        radioHigh.Location = New Point(138, 225)
        radioHigh.Name = "radioHigh"
        radioHigh.Size = New Size(72, 24)
        radioHigh.TabIndex = 26
        radioHigh.TabStop = True
        radioHigh.Text = "Tinggi"
        radioHigh.UseVisualStyleBackColor = True
        ' 
        ' radioMedium
        ' 
        radioMedium.AutoSize = True
        radioMedium.Location = New Point(138, 195)
        radioMedium.Name = "radioMedium"
        radioMedium.Size = New Size(80, 24)
        radioMedium.TabIndex = 25
        radioMedium.TabStop = True
        radioMedium.Text = "Sedang"
        radioMedium.UseVisualStyleBackColor = True
        ' 
        ' radioLow
        ' 
        radioLow.AutoSize = True
        radioLow.Location = New Point(138, 165)
        radioLow.Name = "radioLow"
        radioLow.Size = New Size(80, 24)
        radioLow.TabIndex = 24
        radioLow.TabStop = True
        radioLow.Text = "Rendah"
        radioLow.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 165)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 20)
        Label8.TabIndex = 23
        Label8.Text = "Tingkat Aktivitas"
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        cmbGender.Location = New Point(138, 128)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(229, 28)
        cmbGender.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(373, 95)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 20)
        Label7.TabIndex = 21
        Label7.Text = "cm"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(373, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 20)
        Label6.TabIndex = 20
        Label6.Text = "Kg"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(355, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 19
        Label5.Text = "Tahun"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 18
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 17
        Label3.Text = "Tinggi Badan"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(138, 92)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(229, 27)
        txtHeight.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 14
        Label2.Text = "Berat Badan"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(138, 59)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(229, 27)
        txtWeight.TabIndex = 13
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(138, 26)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(211, 27)
        txtAge.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 11
        Label1.Text = "Umur"
        ' 
        ' listResults
        ' 
        listResults.FormattingEnabled = True
        listResults.Location = New Point(12, 352)
        listResults.Name = "listResults"
        listResults.Size = New Size(415, 104)
        listResults.TabIndex = 6
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = SystemColors.ButtonFace
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Location = New Point(268, 298)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 29)
        btnPrint.TabIndex = 13
        btnPrint.Text = "Cetak"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.ForeColor = SystemColors.ButtonFace
        btnReset.Location = New Point(168, 298)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 12
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnCount
        ' 
        btnCount.BackColor = Color.Lime
        btnCount.FlatStyle = FlatStyle.Popup
        btnCount.Location = New Point(68, 298)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(94, 29)
        btnCount.TabIndex = 11
        btnCount.Text = "Hitung"
        btnCount.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(439, 469)
        Controls.Add(btnPrint)
        Controls.Add(btnReset)
        Controls.Add(btnCount)
        Controls.Add(listResults)
        Controls.Add(GroupBox1)
        Name = "Form3"
        Text = "Kalkulator Kalori"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radioHigh As RadioButton
    Friend WithEvents radioMedium As RadioButton
    Friend WithEvents radioLow As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents listResults As ListBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCount As Button
End Class
