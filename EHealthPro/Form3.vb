Public Class Form3
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' Validasi input kosong
        If txtAge.Text = "" Or txtWeight.Text = "" Or txtHeight.Text = "" Or cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil nilai inputan
        Dim umur As Integer
        Dim berat As Double
        Dim tinggi As Double

        ' Validasi input angka
        If Not Integer.TryParse(txtAge.Text, umur) OrElse Not Double.TryParse(txtWeight.Text, berat) OrElse Not Double.TryParse(txtHeight.Text, tinggi) Then
            MessageBox.Show("Masukkan angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hitung BMR berdasarkan jenis kelamin
        Dim BMR As Double
        If cmbGender.SelectedItem.ToString() = "Laki-laki" Then
            BMR = (88.4 + (13.4 * berat)) + (4.8 * tinggi) - (5.68 * umur)
        ElseIf cmbGender.SelectedItem.ToString() = "Perempuan" Then
            BMR = (447.6 + (9.25 * berat)) + (3.1 * tinggi) - (4.33 * umur)
        Else
            MessageBox.Show("Pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hitung total kebutuhan kalori berdasarkan tingkat aktivitas
        Dim totalKalori As Double
        If radioLow.Checked Then
            totalKalori = BMR * 1.2
        ElseIf radioMedium.Checked Then
            totalKalori = BMR * 1.55
        ElseIf radioHigh.Checked Then
            totalKalori = BMR * 1.9
        Else
            MessageBox.Show("Pilih tingkat aktivitas!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tampilkan hasil di listBox listResults
        listResults.Items.Clear()
        listResults.Items.Add("Umur : " & umur & " Tahun")
        listResults.Items.Add("Berat : " & berat & " Kg")
        listResults.Items.Add("Tinggi : " & tinggi & " cm")
        listResults.Items.Add("Jenis Kelamin : " & cmbGender.SelectedItem.ToString())
        listResults.Items.Add("BMR (Basal Metabolic Rate) : " & Math.Round(BMR, 2) & " Kalori")
        listResults.Items.Add("Total Kebutuhan Kalori : " & Math.Round(totalKalori, 2) & " Kalori/hari")
    End Sub

    ' Tombol Reset untuk menghapus inputan
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAge.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
        cmbGender.SelectedIndex = -1
        radioLow.Checked = False
        radioMedium.Checked = False
        radioHigh.Checked = False
        listResults.Items.Clear()
    End Sub

    ' Tombol Cetak (hanya mencetak jika ada data)
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If listResults.Items.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk dicetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printText As String = ""
            For i As Integer = 0 To listResults.Items.Count - 1
                printText &= listResults.Items(i).ToString() & Environment.NewLine
            Next

            ' Kirim teks ke printer
            Dim printer As New Printing.PrintDocument()
            AddHandler printer.PrintPage, Sub(senderObj, eArgs)
                                              eArgs.Graphics.DrawString("Hasil Perhitungan Kalori", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50)
                                              eArgs.Graphics.DrawString(printText, New Font("Arial", 12), Brushes.Black, 50, 80)
                                          End Sub
            printer.Print()
        End If
    End Sub


End Class
