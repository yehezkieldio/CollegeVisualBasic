﻿Public Class Tugas3_Praktikum_5_Form2
    Dim Tutup As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tutup = MessageBox.Show("Apakah anda yakin ingin menututup form ini?", "Lokal Variable", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class