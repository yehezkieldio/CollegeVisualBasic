Public Class Latihan3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nilai As String = TextBox1.Text
        Dim Evaluasi As String

        ' Kalau Nilai lebih atau sama dengan  85, maka Evaluasi adalah A
        If Nilai >= 85 Then
            Evaluasi = "A"

            ' Kalau Nilai lebih atau sama dengan 75, maka Evaluasi adalah B
        ElseIf Nilai >= 75 Then
            Evaluasi = "B"

            ' Kalau Nilai lebih atau sama dengan 65, maka Evaluasi adalah C
        ElseIf Nilai >= 65 Then
            Evaluasi = "C"

            ' Kalau Nilai lebih atau sama dengan 50, maka Evaluasi adalah D
        ElseIf Nilai >= 50 Then
            Evaluasi = "D"

            ' Kalau Nilai lebih atau sama dengan 0, maka Evaluasi adalah E
        ElseIf Nilai >= 0 Then
            Evaluasi = "E"

            ' Kalau Nilai Kurang dari 0, maka tampilkan tidak tersedia
        Else
            Throw New ArgumentException("Nilai tidak boleh kurang dari 0.")
        End If


        MessageBox.Show(Evaluasi, "Hasil Nilai")
    End Sub
End Class