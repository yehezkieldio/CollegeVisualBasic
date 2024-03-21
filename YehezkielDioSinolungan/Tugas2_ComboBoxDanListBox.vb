' This practice project is authored by: @elizielx - https://github.com/yehezkieldio
' Licensed under the MIT license, refer to the LICENSE file for more information.

Imports System.IO

Public Class Tugas2_ComboBoxDanListBox
    ' Load all drives to the ComboBox1.
    Private Sub Tugas2_ComboBoxDanListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(IO.DriveInfo.GetDrives)
    End Sub

    ' Show drive information to the ListBox1.
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()

        Dim dvr As New DriveInfo(ComboBox1.Text)
        ListBox1.Items.Add("Nama: " & dvr.Name)
        ListBox1.Items.Add("Format: " & dvr.DriveFormat)
        ListBox1.Items.Add("Tipe: " & dvr.DriveType.ToString())
        ListBox1.Items.Add("Ruang Kosong Tersedia: " & Math.Round(dvr.AvailableFreeSpace / 1024 ^ 3, 2) & " GB")
        ListBox1.Items.Add("Jumlah Ruang Kosong: " & Math.Round(dvr.TotalFreeSpace / 1024 ^ 3, 2) & " GB")
        ListBox1.Items.Add("Jumlah Ruang Terpakai: " & Math.Round((dvr.TotalSize - dvr.TotalFreeSpace) / 1024 ^ 3, 2) & " GB")
        ListBox1.Items.Add("Ukuran Total: " & Math.Round(dvr.TotalSize / 1024 ^ 3, 2) & " GB")
    End Sub
End Class