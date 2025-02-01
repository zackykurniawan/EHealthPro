Public Class Form2
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' Validasi input kosong
        If txtWeight.Text = "" Or txtHeight.Text = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil nilai inputan
        Dim berat As Double
        Dim tinggi As Double

        ' Validasi input angka
        If Not Double.TryParse(txtWeight.Text, berat) OrElse Not Double.TryParse(txtHeight.Text, tinggi) Then
            MessageBox.Show("Masukkan angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Konversi tinggi dari cm ke meter
        tinggi = tinggi / 100

        ' Hitung BMI
        Dim BMI As Double = berat / (tinggi * tinggi)
        Dim kategori As String = ""

        ' Tentukan kategori BMI
        If BMI < 18.5 Then
            kategori = "Kurus"
        ElseIf BMI >= 18.5 And BMI <= 24.9 Then
            kategori = "Ideal"
        ElseIf BMI >= 25 And BMI <= 29.9 Then
            kategori = "Kelebihan Berat Badan"
        Else
            kategori = "Obesitas"
        End If

        ' Tampilkan hasil di listBox listResults
        listResults.Items.Clear()
        listResults.Items.Add("Berat : " & berat & " Kg")
        listResults.Items.Add("Tinggi : " & tinggi * 100 & " cm")
        listResults.Items.Add("BMI : " & Math.Round(BMI, 2))
        listResults.Items.Add("Kategori : " & kategori)
    End Sub

    ' Tombol Reset untuk menghapus inputan
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtWeight.Clear()
        txtHeight.Clear()
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
            Dim i As Integer = 0

            While i < listResults.Items.Count
                printText &= listResults.Items(i).ToString() & Environment.NewLine
                i += 1
            End While

            ' Kirim teks ke printer
            Dim printer As New Printing.PrintDocument()
            AddHandler printer.PrintPage, Sub(senderObj, eArgs)
                                              eArgs.Graphics.DrawString("Hasil Perhitungan BMI", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50)
                                              eArgs.Graphics.DrawString(printText, New Font("Arial", 12), Brushes.Black, 50, 80)
                                          End Sub
            printer.Print()
        End If
    End Sub
End Class
