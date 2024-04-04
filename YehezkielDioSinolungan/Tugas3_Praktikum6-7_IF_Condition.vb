Public Class Tugas3_Praktikum6_7_IF_Condition
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' if condition
        Dim Usia As String
        Dim Nilai As Single
        Dim Tahun As Integer

        Usia = InputBox("Usia pengawai saat ini?", "Batasan usia pensiun", 0)
        Nilai = Val(Usia)
        If Nilai >= 55 Then
            Tahun = Nilai - 55
            MessageBox.Show("Usia pegawai: " & Usia & " tahun", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Keterangan: Pegawai harus pensiun " & Tahun & " tahun yang lalu.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' if else condition
        Dim Usia As String
        Dim Nilai As Single
        Dim Tahun As Integer

        Usia = InputBox("Usia pengawai saat ini?", "Batasan usia pensiun", 0)
        Nilai = Val(Usia)
        If Nilai >= 55 Then
            Tahun = Nilai - 55
            MessageBox.Show("Usia pegawai: " & Usia & " tahun", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Keterangan: Pegawai harus pensiun " & Tahun & " tahun yang lalu.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Tahun = 55 - Nilai
            MessageBox.Show("Usia pegawai: " & Usia & " tahun", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Keterangan: Pegawai harus pensiun dalam " & Tahun & " tahun.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Isian As String
        Dim Usia As Integer

        Isian = InputBox("Usia anda sekarang ini?", "Status Anda")
        Usia = Val(Isian)

        MessageBox.Show("Usia anda saat ini: " & Usia & " tahun", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Select Case Usia
            Case 1 To 4
                MessageBox.Show("Anda masih balita", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5 To 16
                MessageBox.Show("Anda masih anak-anak", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 17 To 25
                MessageBox.Show("Anda sudah remaja", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 26 To 56
                MessageBox.Show("Anda sudah dewasa", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Is >= 57
                MessageBox.Show("Anda sudah tua", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Usia anda tidak valid", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class