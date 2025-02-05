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
        btnSchedule = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnHydration = New Button()
        btnCalories = New Button()
        btnBMI = New Button()
        btnRegistration = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSchedule
        ' 
        btnSchedule.BackColor = SystemColors.ActiveCaption
        btnSchedule.FlatStyle = FlatStyle.Popup
        btnSchedule.Location = New Point(94, 172)
        btnSchedule.Name = "btnSchedule"
        btnSchedule.Size = New Size(158, 44)
        btnSchedule.TabIndex = 0
        btnSchedule.Text = "Jadwal Praktik"
        btnSchedule.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(222, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 31)
        Label1.TabIndex = 1
        Label1.Text = "Medicare+ Clinic"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnHydration)
        GroupBox1.Controls.Add(btnCalories)
        GroupBox1.Controls.Add(btnBMI)
        GroupBox1.Location = New Point(314, 94)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(282, 270)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Kalkulator Kesehatan"
        GroupBox1.UseWaitCursor = True
        ' 
        ' btnHydration
        ' 
        btnHydration.Location = New Point(56, 184)
        btnHydration.Name = "btnHydration"
        btnHydration.Size = New Size(167, 44)
        btnHydration.TabIndex = 5
        btnHydration.Text = "Kalkulator Air MInum" & vbCrLf
        btnHydration.UseVisualStyleBackColor = True
        btnHydration.UseWaitCursor = True
        ' 
        ' btnCalories
        ' 
        btnCalories.Location = New Point(56, 113)
        btnCalories.Name = "btnCalories"
        btnCalories.Size = New Size(167, 44)
        btnCalories.TabIndex = 4
        btnCalories.Text = "Kalkulator Kalori"
        btnCalories.UseVisualStyleBackColor = True
        btnCalories.UseWaitCursor = True
        ' 
        ' btnBMI
        ' 
        btnBMI.Location = New Point(56, 47)
        btnBMI.Name = "btnBMI"
        btnBMI.Size = New Size(167, 44)
        btnBMI.TabIndex = 3
        btnBMI.Text = "Kalkulator BMI "
        btnBMI.UseVisualStyleBackColor = True
        btnBMI.UseWaitCursor = True
        ' 
        ' btnRegistration
        ' 
        btnRegistration.BackColor = SystemColors.ActiveCaption
        btnRegistration.FlatStyle = FlatStyle.Popup
        btnRegistration.Location = New Point(94, 239)
        btnRegistration.Name = "btnRegistration"
        btnRegistration.Size = New Size(158, 44)
        btnRegistration.TabIndex = 3
        btnRegistration.Text = "Pendaftaran Pasien"
        btnRegistration.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(633, 403)
        Controls.Add(btnRegistration)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(btnSchedule)
        Name = "Form1"
        Text = "Menu"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSchedule As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHydration As Button
    Friend WithEvents btnCalories As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnRegistration As Button

End Class
