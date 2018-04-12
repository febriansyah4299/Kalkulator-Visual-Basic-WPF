Class MainWindow

    Dim AngkaPertama As Double
    Dim AngkaKedua As Double
    Dim Kalkulasi As String
    Dim Hasil As Double

    Private Sub buttonTambah_Click(sender As Object, e As RoutedEventArgs) Handles buttonTambah.Click
        Kalkulasi = "+"
        labelOperasi.Content = "+"
    End Sub

    Private Sub buttonKurang_Click(sender As Object, e As RoutedEventArgs) Handles buttonKurang.Click
        Kalkulasi = "-"
        labelOperasi.Content = "-"
    End Sub

    Private Sub buttonKali_Click(sender As Object, e As RoutedEventArgs) Handles buttonKali.Click
        Kalkulasi = "*"
        labelOperasi.Content = "*"
    End Sub

    Private Sub buttonBagi_Click(sender As Object, e As RoutedEventArgs) Handles buttonBagi.Click
        Kalkulasi = "/"
        labelOperasi.Content = "/"
    End Sub

    Private Sub buttonSD_Click(sender As Object, e As RoutedEventArgs) Handles buttonSD.Click
        AngkaPertama = textBox1.Text
        AngkaKedua = textBox2.Text

        If Kalkulasi = "+" Then
            Hasil = AngkaPertama + AngkaKedua
        ElseIf Kalkulasi = "-" Then
            Hasil = AngkaPertama - AngkaKedua
        ElseIf Kalkulasi = "*" Then
            Hasil = AngkaPertama * AngkaKedua
        ElseIf Kalkulasi = "/" Then
            Hasil = AngkaPertama / AngkaKedua
        End If

        textBoxHasil.Text = Hasil
    End Sub
End Class
