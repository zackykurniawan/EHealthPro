<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        btnReset = New Button()
        btnPrint = New Button()
        btnCreate = New Button()
        cmbLastEducation = New ComboBox()
        Label9 = New Label()
        Label7 = New Label()
        txtResponsible = New TextBox()
        radioMarried = New RadioButton()
        radioSingle = New RadioButton()
        Label5 = New Label()
        txtJob = New TextBox()
        Label6 = New Label()
        cmbGender = New ComboBox()
        Label4 = New Label()
        txtTelephone = New TextBox()
        txtAddress = New RichTextBox()
        Label3 = New Label()
        Label1 = New Label()
        dtpDateOfBirth = New DateTimePicker()
        Label8 = New Label()
        Label2 = New Label()
        txtFullName = New TextBox()
        dataResults = New DataGridView()
        Column10 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(dataResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnCreate)
        GroupBox1.Controls.Add(cmbLastEducation)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtResponsible)
        GroupBox1.Controls.Add(radioMarried)
        GroupBox1.Controls.Add(radioSingle)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtJob)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(cmbGender)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtTelephone)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dtpDateOfBirth)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtFullName)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 415)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Masukkan data"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.ForeColor = SystemColors.ButtonFace
        btnReset.Location = New Point(597, 205)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(103, 33)
        btnReset.TabIndex = 52
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Location = New Point(597, 244)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(103, 33)
        btnPrint.TabIndex = 51
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.Lime
        btnCreate.FlatStyle = FlatStyle.Popup
        btnCreate.Location = New Point(597, 166)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(103, 33)
        btnCreate.TabIndex = 50
        btnCreate.Text = "Tambah"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' cmbLastEducation
        ' 
        cmbLastEducation.FormattingEnabled = True
        cmbLastEducation.Items.AddRange(New Object() {"SD ", "SMP", "SMA/SMK", "Diploma (D1, D2, D3, D4)", "Sarjana (S1)", "Magister (S2)", "Doktor (S3)"})
        cmbLastEducation.Location = New Point(195, 270)
        cmbLastEducation.Name = "cmbLastEducation"
        cmbLastEducation.Size = New Size(310, 28)
        cmbLastEducation.TabIndex = 49
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 273)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 20)
        Label9.TabIndex = 48
        Label9.Text = "Pendidikan Terakhir"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 366)
        Label7.Name = "Label7"
        Label7.Size = New Size(180, 20)
        Label7.TabIndex = 46
        Label7.Text = "Nama Penanggung Jawab"
        ' 
        ' txtResponsible
        ' 
        txtResponsible.Location = New Point(195, 363)
        txtResponsible.Name = "txtResponsible"
        txtResponsible.Size = New Size(310, 27)
        txtResponsible.TabIndex = 45
        ' 
        ' radioMarried
        ' 
        radioMarried.AutoSize = True
        radioMarried.Location = New Point(195, 333)
        radioMarried.Name = "radioMarried"
        radioMarried.Size = New Size(86, 24)
        radioMarried.TabIndex = 44
        radioMarried.TabStop = True
        radioMarried.Text = "Menikah"
        radioMarried.UseVisualStyleBackColor = True
        ' 
        ' radioSingle
        ' 
        radioSingle.AutoSize = True
        radioSingle.Location = New Point(195, 303)
        radioSingle.Name = "radioSingle"
        radioSingle.Size = New Size(132, 24)
        radioSingle.TabIndex = 43
        radioSingle.TabStop = True
        radioSingle.Text = "Belum Menikah"
        radioSingle.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 42
        Label5.Text = "Pekerjaan"
        ' 
        ' txtJob
        ' 
        txtJob.Location = New Point(195, 237)
        txtJob.Name = "txtJob"
        txtJob.Size = New Size(310, 27)
        txtJob.TabIndex = 41
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 20)
        Label6.TabIndex = 39
        Label6.Text = "Status Perikahan"
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        cmbGender.Location = New Point(195, 100)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(310, 28)
        cmbGender.TabIndex = 38
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 37
        Label4.Text = "No Telepon"
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(195, 133)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(310, 27)
        txtTelephone.TabIndex = 36
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(195, 166)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(310, 65)
        txtAddress.TabIndex = 35
        txtAddress.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 34
        Label3.Text = "Alamat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 32
        Label1.Text = "Jenis Kelamin"
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Location = New Point(195, 67)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(310, 27)
        dtpDateOfBirth.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 67)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 20)
        Label8.TabIndex = 29
        Label8.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 28
        Label2.Text = "Nama Lengkap"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(195, 30)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(310, 27)
        txtFullName.TabIndex = 27
        ' 
        ' dataResults
        ' 
        dataResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataResults.Columns.AddRange(New DataGridViewColumn() {Column10, Column1, Column2, Column3, Column4, Column9, Column5, Column6, Column7, Column8})
        dataResults.Location = New Point(12, 433)
        dataResults.Name = "dataResults"
        dataResults.RowHeadersWidth = 51
        dataResults.Size = New Size(776, 212)
        dataResults.TabIndex = 1
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Waktu Pendaftaran"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nama Lengkap"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Tanggal Lahir"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Jenis Kelamin"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "No Telepon"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Alamat"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Pekerjaan"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Pendidikan Terakhir"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Status Pernikahan"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Penanggung Jawab"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 125
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 657)
        Controls.Add(dataResults)
        Controls.Add(GroupBox1)
        Name = "Form6"
        Text = "Pendaftaran Pasien"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dataResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents radioMarried As RadioButton
    Friend WithEvents radioSingle As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJob As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtResponsible As TextBox
    Friend WithEvents cmbLastEducation As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents dataResults As DataGridView
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
