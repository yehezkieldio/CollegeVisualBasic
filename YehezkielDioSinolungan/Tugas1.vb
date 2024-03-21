' This practice project is authored by: @elizielx - https://github.com/yehezkieldio
' Licensed under the MIT license, refer to the LICENSE file for more information.

Public Class Tugas1
    ' StrikeOut label.
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, Label1.Font.Style Xor FontStyle.Strikeout)
    End Sub

    ' Underline label.
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, Label1.Font.Style Xor FontStyle.Underline)
    End Sub

    ' Regular label.
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, FontStyle.Regular)
    End Sub

    ' Italic label
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, FontStyle.Italic)
    End Sub

    ' Bold label
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, FontStyle.Bold)
    End Sub

    ' Bold and Italic label
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Font = New Font("Microsoft Sans Serif", Label1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
    End Sub
End Class
