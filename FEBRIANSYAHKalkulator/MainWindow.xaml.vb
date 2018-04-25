Class MainWindow

    Dim Angka1 As Double
    Dim Angka2 As Double
    Dim Kalkulasi As String
    Dim Hasil As Double

    Private Sub Btn_1_Click(sender As Object, e As RoutedEventArgs) Handles Btn_1.Click
        labelHasil.Content = labelHasil.Content + "1"
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As RoutedEventArgs) Handles Btn_2.Click
        labelHasil.Content = labelHasil.Content + "2"
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As RoutedEventArgs) Handles Btn_3.Click
        labelHasil.Content = labelHasil.Content + "3"
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As RoutedEventArgs) Handles Btn_4.Click
        labelHasil.Content = labelHasil.Content + "4"
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As RoutedEventArgs) Handles Btn_5.Click
        labelHasil.Content = labelHasil.Content + "5"
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As RoutedEventArgs) Handles Btn_6.Click
        labelHasil.Content = labelHasil.Content + "6"
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As RoutedEventArgs) Handles Btn_7.Click
        labelHasil.Content = labelHasil.Content + "7"
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As RoutedEventArgs) Handles Btn_8.Click
        labelHasil.Content = labelHasil.Content + "8"
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As RoutedEventArgs) Handles Btn_9.Click
        labelHasil.Content = labelHasil.Content + "9"
    End Sub

    Private Sub Btn_0_Click(sender As Object, e As RoutedEventArgs) Handles Btn_0.Click
        labelHasil.Content = labelHasil.Content + "0"
    End Sub

    Private Sub Btn_SD_Click(sender As Object, e As RoutedEventArgs) Handles Btn_SD.Click
        labelOperasi.Content = labelOperasi.Content + labelHasil.Content + " = "
        labelNotice.Content = "Mohon maaf jika hasilnya salah :("

        Angka2 = Val(labelHasil.Content)

        If Kalkulasi = "+" Then
            Hasil = Angka1 + Angka2
        ElseIf Kalkulasi = "-" Then
            Hasil = Angka1 - Angka2
        ElseIf Kalkulasi = "*" Then
            Hasil = Angka1 * Angka2
        ElseIf Kalkulasi = "/" Then
            Hasil = Angka1 / Angka2
        End If

        labelHasil.Content = Hasil
    End Sub

    Private Sub Btn_Tambah_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Tambah.Click
        Kalkulasi = "+"
        labelOperasi.Content = labelOperasi.Content + labelHasil.Content + " + "
        Angka1 = Val(labelHasil.Content)
        labelHasil.Content = ""
    End Sub

    Private Sub Btn_Kurang_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Kurang.Click
        Kalkulasi = "-"
        labelOperasi.Content = labelOperasi.Content + labelHasil.Content + " - "
        Angka1 = Val(labelHasil.Content)
        labelHasil.Content = ""
    End Sub

    Private Sub Btn_Kali_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Kali.Click
        Kalkulasi = "*"
        labelOperasi.Content = labelOperasi.Content + labelHasil.Content + " * "
        Angka1 = Val(labelHasil.Content)
        labelHasil.Content = ""
    End Sub

    Private Sub Btn_Bagi_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Bagi.Click
        Kalkulasi = "/"
        labelOperasi.Content = labelOperasi.Content + labelHasil.Content + " / "
        Angka1 = Val(labelHasil.Content)
        labelHasil.Content = ""
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Clear.Click
        labelHasil.Content = Nothing
        labelOperasi.Content = Nothing
        Angka1 = Nothing
        Angka2 = Nothing
        Kalkulasi = Nothing
        Hasil = Nothing
    End Sub

    Private Sub Btn_Sin_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Sin.Click
        labelOperasi.Content = "Sin(" + labelHasil.Content + ")"
        labelHasil.Content = (Math.Sin(Double.Parse(labelHasil.Content))).ToString()
        labelNotice.Content = "Mohon maaf jika hasilnya salah :("
    End Sub

    Private Sub Btn_Cos_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Cos.Click
        labelOperasi.Content = "Cos(" + labelHasil.Content + ")"
        labelHasil.Content = (Math.Cos(Double.Parse(labelHasil.Content))).ToString()
        labelNotice.Content = "Mohon maaf jika hasilnya salah :("
    End Sub

    Private Sub Btn_Tan_Click(sender As Object, e As RoutedEventArgs) Handles Btn_Tan.Click
        labelOperasi.Content = "Tan(" + labelHasil.Content + ")"
        labelHasil.Content = (Math.Tan(Double.Parse(labelHasil.Content))).ToString()
        labelNotice.Content = "Mohon maaf jika hasilnya salah :("
    End Sub
End Class
