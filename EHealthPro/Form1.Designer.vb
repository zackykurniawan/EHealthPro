<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(81, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 44)
        Button1.TabIndex = 0
        Button1.Text = "Jadwal Praktik"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(222, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 31)
        Label1.TabIndex = 1
        Label1.Text = "Klinik Kesehatan"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Location = New Point(314, 94)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(282, 270)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Fasilitas"
        GroupBox1.UseWaitCursor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(56, 184)
        Button4.Name = "Button4"
        Button4.Size = New Size(167, 44)
        Button4.TabIndex = 5
        Button4.Text = "Kalkulator Air MInum" & vbCrLf
        Button4.UseVisualStyleBackColor = True
        Button4.UseWaitCursor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(56, 113)
        Button3.Name = "Button3"
        Button3.Size = New Size(167, 44)
        Button3.TabIndex = 4
        Button3.Text = "Kalkulator Kalori"
        Button3.UseVisualStyleBackColor = True
        Button3.UseWaitCursor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(56, 47)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 44)
        Button2.TabIndex = 3
        Button2.Text = "Kalkulator BMI "
        Button2.UseVisualStyleBackColor = True
        Button2.UseWaitCursor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(633, 403)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Menu"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button

End Class
