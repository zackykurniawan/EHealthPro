Public Class Form6
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Ambil data dari input pengguna
        Dim namaLengkap As String = txtFullName.Text
        Dim tanggalLahir As String = dtpDateOfBirth.Text
        Dim jenisKelamin As String = cmbGender.Text
        Dim noTelepon As String = txtTelephone.Text
        Dim alamat As String = txtAddress.Text
        Dim pekerjaan As String = txtJob.Text
        Dim pendidikanTerakhir As String = cmbLastEducation.Text
        Dim statusPerkawinan As String = If(radioSingle.Checked, "Belum Menikah", If(radioMarried.Checked, "Menikah", ""))
        Dim penanggungJawab As String = txtResponsible.Text
        Dim waktuPendaftaran As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Waktu saat tombol diklik

        ' Validasi: Periksa apakah ada input yang kosong
        If String.IsNullOrWhiteSpace(namaLengkap) OrElse
       String.IsNullOrWhiteSpace(tanggalLahir) OrElse
       String.IsNullOrWhiteSpace(jenisKelamin) OrElse
       String.IsNullOrWhiteSpace(noTelepon) OrElse
       String.IsNullOrWhiteSpace(alamat) OrElse
       String.IsNullOrWhiteSpace(pekerjaan) OrElse
       String.IsNullOrWhiteSpace(pendidikanTerakhir) OrElse
       String.IsNullOrWhiteSpace(statusPerkawinan) OrElse
       String.IsNullOrWhiteSpace(penanggungJawab) Then

            ' Tampilkan pesan peringatan jika ada input yang kosong
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Hentikan proses jika ada input yang kosong
        End If

        ' Tambahkan data ke DataGridView
        dataResults.Rows.Add(waktuPendaftaran, namaLengkap, tanggalLahir, jenisKelamin, noTelepon, alamat, pekerjaan, pendidikanTerakhir, statusPerkawinan, penanggungJawab)

        ' Bersihkan input setelah data ditambahkan (opsional)
        txtFullName.Clear()
        txtTelephone.Clear()
        txtAddress.Clear()
        txtJob.Clear()
        txtResponsible.Clear()
        cmbGender.SelectedIndex = -1
        cmbLastEducation.SelectedIndex = -1
        radioSingle.Checked = False
        radioMarried.Checked = False
    End Sub

    Private Sub txtTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephone.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau tombol kontrol (backspace, delete, dll.)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Mencegah input jika bukan angka
            MessageBox.Show("Hanya boleh memasukkan angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Bersihkan semua inputan di form
        txtFullName.Clear()
        dtpDateOfBirth.Value = DateTime.Now ' Reset tanggal lahir ke tanggal hari ini
        cmbGender.SelectedIndex = -1
        txtTelephone.Clear()
        txtAddress.Clear()
        txtJob.Clear()
        cmbLastEducation.SelectedIndex = -1
        radioSingle.Checked = False
        radioMarried.Checked = False
        txtResponsible.Clear()
    End Sub


    Dim WithEvents printDoc As New Printing.PrintDocument

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Menentukan printer yang akan digunakan (opsional, default printer)
        printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF" ' Ganti dengan printer yang Anda inginkan

        ' Memulai proses pencetakan
        printDoc.Print()
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        ' Menyusun teks untuk mencetak hasil DataGridView
        Dim font As New Font("Arial", 5)
        Dim yPos As Single = 10 ' Posisi Y awal
        Dim lineHeight As Single = font.GetHeight(e.Graphics)
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim maxHeight As Single = e.MarginBounds.Bottom ' Batas bawah halaman

        ' Menulis judul kolom di bagian atas halaman
        e.Graphics.DrawString("Data Pendaftaran", font, Brushes.Black, leftMargin, yPos)
        yPos += lineHeight * 2 ' Memberikan jarak untuk judul

        ' Menulis nama kolom DataGridView
        For Each column As DataGridViewColumn In dataResults.Columns
            e.Graphics.DrawString(column.HeaderText, font, Brushes.Black, leftMargin, yPos)
            leftMargin += column.Width ' Pindahkan posisi horizontal untuk kolom berikutnya
        Next

        yPos += lineHeight ' Memberikan jarak setelah header kolom
        leftMargin = e.MarginBounds.Left ' Reset posisi horizontal ke margin kiri

        ' Menulis data dari setiap baris DataGridView
        For Each row As DataGridViewRow In dataResults.Rows
            If yPos + lineHeight > maxHeight Then
                ' Jika posisi Y melebihi batas bawah halaman, buat halaman baru
                e.HasMorePages = True
                Return
            End If

            For Each cell As DataGridViewCell In row.Cells
                ' Cek apakah nilai sel adalah Nothing
                Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty)
                e.Graphics.DrawString(cellValue, font, Brushes.Black, leftMargin, yPos)
                leftMargin += cell.OwningColumn.Width ' Pindahkan posisi horizontal untuk kolom berikutnya
            Next
            yPos += lineHeight ' Memberikan jarak antar baris
            leftMargin = e.MarginBounds.Left ' Reset posisi horizontal ke margin kiri untuk baris berikutnya
        Next
    End Sub




End Class