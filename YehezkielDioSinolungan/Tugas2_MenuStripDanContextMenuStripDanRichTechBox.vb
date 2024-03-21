' This practice project is authored by: @elizielx - https://github.com/yehezkieldio
' Licensed under the MIT license, refer to the LICENSE file for more information.

Public Class Tugas2_MenuStripDanContextMenuStripDanRichTechBox
    ' Handle the BaruToolStripMenuItem_Click event to clear the RichTextBox1.
    Private Sub BaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaruToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub

    ' Handle the BukaToolStripMenuItem_Click event to open a file to the RichTextBox1.
    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim kota_dialog As OpenFileDialog = New OpenFileDialog
        kota_dialog.Filter = "File Text (*.txt)|*.txt"
        kota_dialog.ShowDialog()

        If kota_dialog.FileName <> "" Then
            Dim file_text As String = My.Computer.FileSystem.ReadAllText(kota_dialog.FileName)
            RichTextBox1.Text = file_text
        End If
    End Sub

    ' Handle the SimpanToolStripMenuItem_Click event to save the RichTextBox1 to a file.
    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim kota_dialog As SaveFileDialog = New SaveFileDialog
        kota_dialog.Filter = "File Text (*.txt)|*.txt"
        kota_dialog.ShowDialog()

        My.Computer.FileSystem.WriteAllText(kota_dialog.FileName, RichTextBox1.Text, False)
    End Sub

    ' Handle the CutToolStripMenuItem_Click event to cut the selected text in the RichTextBox1.
    Private Sub RegularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Regular)
    End Sub

    ' Handle the ItalicToolStripMenuItem_Click event to italicize the selected text in the RichTextBox1.
    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
    End Sub
End Class