Public Class Form5
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printer As New Printing.PrintDocument()
            AddHandler printer.PrintPage, AddressOf PrintSchedule
            printer.Print()
        End If
    End Sub

    Private Sub PrintSchedule(sender As Object, e As Printing.PrintPageEventArgs)
        Dim fontHeader As New Font("Arial", 14, FontStyle.Bold)
        Dim fontRegular As New Font("Arial", 12)
        Dim brush As Brush = Brushes.Black
        Dim x As Integer = 50
        Dim y As Integer = 50
        Dim pageWidth As Integer = e.PageBounds.Width

        ' Cetak Judul (Align Center)
        Dim title As String = "Jadwal Praktik Dokter Umum"
        Dim titleSize As SizeF = e.Graphics.MeasureString(title, fontHeader)
        Dim titleX As Integer = (pageWidth - titleSize.Width) / 2
        e.Graphics.DrawString(title, fontHeader, brush, titleX, y)
        y += 40

        ' Header tabel
        e.Graphics.DrawString("Hari", fontRegular, brush, x, y)
        e.Graphics.DrawString("Jam", fontRegular, brush, x + 150, y)
        e.Graphics.DrawString("Dokter Praktik", fontRegular, brush, x + 300, y)
        y += 30

        ' Data jadwal praktik
        Dim schedule As String(,) = {
            {"Senin", "08.00 - 14.00", "dr. Andika Pratama, Sp.JP"},
            {"", "14.00 - 20.00", "dr. Siti Rahmawati, Sp.KK"},
            {"Selasa", "08.00 - 14.00", "dr. Budi Santoso, Sp.A"},
            {"", "14.00 - 20.00", "dr. Dewi Lestari, Sp.OG"},
            {"Rabu", "08.00 - 14.00", "dr. Faisal Anwar, Sp.B"},
            {"", "14.00 - 20.00", "dr. Rina Kartika, Sp.THT-KL"},
            {"Kamis", "08.00 - 14.00", "dr. Yuliana Putri, Sp.Rad"},
            {"", "14.00 - 20.00", "dr. Anton Wijaya, Sp.N"},
            {"Jumat", "08.00 - 14.00", "dr. Melisa Oktaviani, Sp.PD"},
            {"", "14.00 - 20.00", "dr. Heru Wibowo, Sp.M"},
            {"Sabtu", "10.00 - 16.00", "dr. Richard Lee, Sp.DV"},
            {"Minggu", "10.00 - 16.00", "dr. Tirta Mandira Hudhi, M.B.A"}
        }

        ' Cetak data
        For i As Integer = 0 To schedule.GetLength(0) - 1
            e.Graphics.DrawString(schedule(i, 0), fontRegular, brush, x, y)
            e.Graphics.DrawString(schedule(i, 1), fontRegular, brush, x + 150, y)
            e.Graphics.DrawString(schedule(i, 2), fontRegular, brush, x + 300, y)
            y += 25
        Next
    End Sub
End Class
