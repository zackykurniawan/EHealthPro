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
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        txtHeight = New TextBox()
        Label2 = New Label()
        txtWeight = New TextBox()
        btnPrint = New Button()
        listResults = New ListBox()
        btnReset = New Button()
        btnCount = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtHeight)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtWeight)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(417, 113)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Masukkan data"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(374, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 20)
        Label7.TabIndex = 10
        Label7.Text = "cm"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(374, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 20)
        Label6.TabIndex = 9
        Label6.Text = "Kg"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 5
        Label3.Text = "Tinggi Badan"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(139, 61)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(229, 27)
        txtHeight.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 3
        Label2.Text = "Berat Badan"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(139, 28)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(229, 27)
        txtWeight.TabIndex = 2
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = SystemColors.ButtonFace
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Location = New Point(277, 148)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 29)
        btnPrint.TabIndex = 14
        btnPrint.Text = "Cetak"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' listResults
        ' 
        listResults.FormattingEnabled = True
        listResults.Location = New Point(12, 203)
        listResults.Name = "listResults"
        listResults.Size = New Size(417, 124)
        listResults.TabIndex = 13
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.ForeColor = SystemColors.ButtonFace
        btnReset.Location = New Point(177, 148)
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
        btnCount.Location = New Point(77, 148)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(94, 29)
        btnCount.TabIndex = 11
        btnCount.Text = "Hitung"
        btnCount.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 340)
        Controls.Add(btnPrint)
        Controls.Add(listResults)
        Controls.Add(btnReset)
        Controls.Add(btnCount)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Kalkulator BMI"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnPrint As Button
    Friend WithEvents listResults As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCount As Button
End Class
