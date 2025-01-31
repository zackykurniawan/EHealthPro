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
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label8 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        ListView1 = New ListView()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(408, 176)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Masukkan data"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(138, 127)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(111, 24)
        RadioButton3.TabIndex = 26
        RadioButton3.TabStop = True
        RadioButton3.Text = "Sangat Aktif"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(138, 97)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(61, 24)
        RadioButton2.TabIndex = 25
        RadioButton2.TabStop = True
        RadioButton2.Text = "Aktif"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(138, 67)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(112, 24)
        RadioButton1.TabIndex = 24
        RadioButton1.TabStop = True
        RadioButton1.Text = "Kurang Aktif"
        RadioButton1.UseVisualStyleBackColor = True
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
        ' TextBox2
        ' 
        TextBox2.Location = New Point(138, 30)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(229, 27)
        TextBox2.TabIndex = 13
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(219, 211)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(119, 211)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 270)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(408, 88)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 370)
        Controls.Add(ListView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Name = "Form4"
        Text = "Kalkulator Air Minum"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
End Class
