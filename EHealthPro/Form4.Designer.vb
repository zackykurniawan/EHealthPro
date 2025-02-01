<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        radioVeryActive = New RadioButton()
        radioActive = New RadioButton()
        radioLessActive = New RadioButton()
        Label8 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        txtWeight = New TextBox()
        btnReset = New Button()
        btnCount = New Button()
        listResults = New ListBox()
        btnPrint = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioVeryActive)
        GroupBox1.Controls.Add(radioActive)
        GroupBox1.Controls.Add(radioLessActive)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtWeight)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(408, 176)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Masukkan data"
        ' 
        ' radioVeryActive
        ' 
        radioVeryActive.AutoSize = True
        radioVeryActive.Location = New Point(138, 127)
        radioVeryActive.Name = "radioVeryActive"
        radioVeryActive.Size = New Size(111, 24)
        radioVeryActive.TabIndex = 26
        radioVeryActive.TabStop = True
        radioVeryActive.Text = "Sangat Aktif"
        radioVeryActive.UseVisualStyleBackColor = True
        ' 
        ' radioActive
        ' 
        radioActive.AutoSize = True
        radioActive.Location = New Point(138, 97)
        radioActive.Name = "radioActive"
        radioActive.Size = New Size(61, 24)
        radioActive.TabIndex = 25
        radioActive.TabStop = True
        radioActive.Text = "Aktif"
        radioActive.UseVisualStyleBackColor = True
        ' 
        ' radioLessActive
        ' 
        radioLessActive.AutoSize = True
        radioLessActive.Location = New Point(138, 67)
        radioLessActive.Name = "radioLessActive"
        radioLessActive.Size = New Size(112, 24)
        radioLessActive.TabIndex = 24
        radioLessActive.TabStop = True
        radioLessActive.Text = "Kurang Aktif"
        radioLessActive.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 67)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 20)
        Label8.TabIndex = 23
        Label8.Text = "Tingkat Aktivitas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(373, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 20)
        Label6.TabIndex = 20
        Label6.Text = "Kg"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 14
        Label2.Text = "Berat Badan"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(138, 30)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(229, 27)
        txtWeight.TabIndex = 13
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.ForeColor = SystemColors.ButtonFace
        btnReset.Location = New Point(173, 211)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnCount
        ' 
        btnCount.BackColor = Color.Lime
        btnCount.FlatStyle = FlatStyle.Popup
        btnCount.Location = New Point(73, 211)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(94, 29)
        btnCount.TabIndex = 5
        btnCount.Text = "Hitung"
        btnCount.UseVisualStyleBackColor = False
        ' 
        ' listResults
        ' 
        listResults.FormattingEnabled = True
        listResults.Location = New Point(12, 266)
        listResults.Name = "listResults"
        listResults.Size = New Size(408, 104)
        listResults.TabIndex = 9
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = SystemColors.ButtonFace
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Location = New Point(273, 211)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 29)
        btnPrint.TabIndex = 10
        btnPrint.Text = "Cetak"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 383)
        Controls.Add(btnPrint)
        Controls.Add(listResults)
        Controls.Add(btnReset)
        Controls.Add(btnCount)
        Controls.Add(GroupBox1)
        Name = "Form4"
        Text = "Kalkulator Air Minum"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioVeryActive As RadioButton
    Friend WithEvents radioActive As RadioButton
    Friend WithEvents radioLessActive As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents listResults As ListBox
    Friend WithEvents btnPrint As Button
End Class
