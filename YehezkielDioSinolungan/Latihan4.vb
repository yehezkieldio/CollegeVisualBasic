Public Class Latihan4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PerkalianMultiplier As String = TextBox1.Text
        Dim Limit As Integer = 10

        ListBox1.Items.Clear()

        Limit = InputBox("Masukkan batas perkalian", "Batas Perkalian", 10)

        For i As Integer = 1 To Limit
            ListBox1.Items.Add(i & " x " & PerkalianMultiplier & " = " & i * PerkalianMultiplier)
        Next
    End Sub
End Class