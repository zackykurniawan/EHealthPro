Public Class Form1


    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim FormJadwal As New Form5()
        FormJadwal.Show()
    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Dim FormBMI As New Form2()
        FormBMI.Show()
    End Sub

    Private Sub btnCalories_Click(sender As Object, e As EventArgs) Handles btnCalories.Click
        Dim FormKalori As New Form3()
        FormKalori.Show()
    End Sub

    Private Sub btnHydratio_Click(sender As Object, e As EventArgs) Handles btnHydration.Click
        Dim FormAir As New Form4()
        FormAir.Show()
    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        Dim FormPendaftaran As New Form6()
        FormPendaftaran.Show()
    End Sub
End Class
