Imports System.IO

Public Class Form4
    ' Fungsi untuk menghitung kebutuhan air berdasarkan berat badan dan tingkat aktivitas
    Private Function HitungKebutuhanAir(ByVal weight As Double, ByVal activity As String) As Double
        Select Case activity
            Case "Kurang Aktif"
                Return weight * 30
            Case "Aktif"
                Return weight * 35
            Case "Sangat Aktif"
                Return weight * 40
            Case Else
                Return 0
        End Select
    End Function

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' Try...Catch untuk menangani error input
        Try
            ' Validasi input berat badan
            Dim weight As Double
            If Not Double.TryParse(txtWeight.Text, weight) OrElse weight <= 0 Then
                MessageBox.Show("Masukkan berat badan yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim activityLevel As String = ""
            If radioLessActive.Checked Then
                activityLevel = "Kurang Aktif"
            ElseIf radioActive.Checked Then
                activityLevel = "Aktif"
            ElseIf radioVeryActive.Checked Then
                activityLevel = "Sangat Aktif"
            Else
                MessageBox.Show("Pilih tingkat aktivitas!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Hitung kebutuhan air
            Dim waterIntake As Double = HitungKebutuhanAir(weight, activityLevel)

            ' Gunakan List(Of String) untuk menyimpan hasil
            Dim hasilPerhitungan As New List(Of String)
            hasilPerhitungan.Add($"Berat Badan: {weight} kg")
            hasilPerhitungan.Add($"Tingkat Aktivitas: {activityLevel}")
            hasilPerhitungan.Add($"Kebutuhan Air: {waterIntake} ml / {waterIntake / 1000:F2} liter")

            ' Tampilkan hasil di ListBox
            listResults.Items.Clear()
            For Each hasil As String In hasilPerhitungan
                listResults.Items.Add(hasil)
            Next

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset input dan hasil
        txtWeight.Clear()
        radioLessActive.Checked = False
        radioActive.Checked = False
        radioVeryActive.Checked = False
        listResults.Items.Clear()
    End Sub

    ' Fungsi untuk mencetak hasil ke printer
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Cek apakah ListBox kosong
        If listResults.Items.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk dicetak!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printText As String = ""
            For Each hasil As String In listResults.Items
                printText &= hasil & Environment.NewLine
            Next

            ' Kirim teks ke printer
            Dim printer As New Printing.PrintDocument()
            AddHandler printer.PrintPage, Sub(senderObj, eArgs)
                                              eArgs.Graphics.DrawString("Hasil Perhitungan Air Minum", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50)
                                              eArgs.Graphics.DrawString(printText, New Font("Arial", 12), Brushes.Black, 50, 80)
                                          End Sub
            printer.Print()
        End If
    End Sub

End Class
