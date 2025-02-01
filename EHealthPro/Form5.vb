Public Class Form5
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDialog As New PrintDialog
        If printDialog.ShowDialog = DialogResult.OK Then
            Dim printer As New Printing.PrintDocument
            AddHandler printer.PrintPage, AddressOf PrintSchedule
            printer.Print()
        End If
    End Sub

    Private Sub PrintSchedule(sender As Object, e As Printing.PrintPageEventArgs)
        Dim fontHeader As New Font("Arial", 14, FontStyle.Bold)
        Dim fontRegular As New Font("Arial", 12)
        Dim brush As Brush = Brushes.Black
        Dim pen As New Pen(Color.Black, 2)
        Dim x As Integer = 50
        Dim y As Integer = 50
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim columnWidths As Integer() = {150, 150, 300}

        ' Calculate the total table width
        Dim totalTableWidth As Integer = columnWidths.Sum()

        ' Cetak Judul (Align Center)
        Dim title As String = "Jadwal Praktik Dokter Umum Medicare+ Clinic"
        Dim titleSize As SizeF = e.Graphics.MeasureString(title, fontHeader)
        Dim titleX As Integer = (pageWidth - titleSize.Width) / 2
        e.Graphics.DrawString(title, fontHeader, brush, titleX, y)
        y += 40

        ' Header tabel (Align Center)
        Dim headerX As Integer = (pageWidth - totalTableWidth) / 2
        e.Graphics.DrawRectangle(pen, headerX, y, columnWidths(0), 30)
        e.Graphics.DrawRectangle(pen, headerX + columnWidths(0), y, columnWidths(1), 30)
        e.Graphics.DrawRectangle(pen, headerX + columnWidths(0) + columnWidths(1), y, columnWidths(2), 30)
        e.Graphics.DrawString("Hari", fontRegular, brush, headerX + 5, y + 5)
        e.Graphics.DrawString("Jam", fontRegular, brush, headerX + columnWidths(0) + 5, y + 5)
        e.Graphics.DrawString("Dokter Praktik", fontRegular, brush, headerX + columnWidths(0) + columnWidths(1) + 5, y + 5)
        y += 30

        ' Data jadwal praktik (Align Center)
        Dim schedule As String(,) = {
            {"Senin", "08.00 - 14.00", "dr. Andika Pratama, Sp.JP"},
            {"Senin", "14.00 - 20.00", "dr. Siti Rahmawati, Sp.KK"},
            {"Selasa", "08.00 - 14.00", "dr. Budi Santoso, Sp.A"},
            {"Selasa", "14.00 - 20.00", "dr. Dewi Lestari, Sp.OG"},
            {"Rabu", "08.00 - 14.00", "dr. Faisal Anwar, Sp.B"},
            {"Rabu", "14.00 - 20.00", "dr. Rina Kartika, Sp.THT-KL"},
            {"Kamis", "08.00 - 14.00", "dr. Yuliana Putri, Sp.Rad"},
            {"Kamis", "14.00 - 20.00", "dr. Anton Wijaya, Sp.N"},
            {"Jumat", "08.00 - 14.00", "dr. Melisa Oktaviani, Sp.PD"},
            {"Jumat", "14.00 - 20.00", "dr. Heru Wibowo, Sp.M"},
            {"Sabtu", "10.00 - 16.00", "dr. Richard Lee, Sp.DV"},
            {"Minggu", "10.00 - 16.00", "dr. Tirta Mandira Hudhi, M.B.A"}
        }

        ' Cetak data dengan garis tabel (Align Center)
        Dim i As Integer = 0
        Do While i < schedule.GetLength(0)
            e.Graphics.DrawRectangle(pen, headerX, y, columnWidths(0), 25)
            e.Graphics.DrawRectangle(pen, headerX + columnWidths(0), y, columnWidths(1), 25)
            e.Graphics.DrawRectangle(pen, headerX + columnWidths(0) + columnWidths(1), y, columnWidths(2), 25)
            e.Graphics.DrawString(schedule(i, 0), fontRegular, brush, headerX + 5, y + 5)
            e.Graphics.DrawString(schedule(i, 1), fontRegular, brush, headerX + columnWidths(0) + 5, y + 5)
            e.Graphics.DrawString(schedule(i, 2), fontRegular, brush, headerX + columnWidths(0) + columnWidths(1) + 5, y + 5)
            y += 25
            i += 1
        Loop
    End Sub


End Class
