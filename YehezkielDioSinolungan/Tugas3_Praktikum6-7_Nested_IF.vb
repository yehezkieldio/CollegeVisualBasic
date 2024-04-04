Public Class Tugas3_Praktikum6_7_Nested_IF
    Dim CorrectUsername As String = "STIKOM"
    Dim CorrectPassword As String = "1234"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" And TextBox1.Text = "" Then
            MessageBox.Show("Kolom tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Password tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Username tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
        ElseIf TextBox2.Text = CorrectPassword And TextBox1.Text = CorrectUsername Then
            MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TextBox2.Text <> CorrectPassword And TextBox1.Text = CorrectUsername Then
            MessageBox.Show("Password Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
        ElseIf TextBox2.Text = CorrectPassword And TextBox1.Text <> CorrectUsername Then
            MessageBox.Show("Username Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
        ElseIf TextBox2.Text <> CorrectPassword And TextBox1.Text <> CorrectUsername Then
            MessageBox.Show("Username dan Password Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class