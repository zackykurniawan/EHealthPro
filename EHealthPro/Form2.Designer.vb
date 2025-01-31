<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        ListView1 = New ListView()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(412, 189)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Masukkan data"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(139, 137)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(229, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(374, 104)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 20)
        Label7.TabIndex = 10
        Label7.Text = "cm"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(374, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 20)
        Label6.TabIndex = 9
        Label6.Text = "Kg"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(356, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 8
        Label5.Text = "Tahun"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 7
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 5
        Label3.Text = "Tinggi Badan"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(139, 101)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(229, 27)
        TextBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 3
        Label2.Text = "Berat Badan"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(139, 68)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(229, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(139, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(211, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 0
        Label1.Text = "Umur"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(110, 219)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(210, 219)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 2
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 273)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(417, 165)
        ListView1.TabIndex = 4
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 450)
        Controls.Add(ListView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Kalkulator BMI"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
End Class
