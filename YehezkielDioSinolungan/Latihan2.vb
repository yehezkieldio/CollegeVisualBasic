Public Class Latihan2
    Dim Bilangan_One As Integer
    Dim Bilangan_Two As Integer
    Dim Hasil As Double
    Dim IsOverflow As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            IsOverflow = Integer.TryParse(TextBox1.Text, Bilangan_One)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            IsOverflow = Integer.TryParse(TextBox2.Text, Bilangan_Two)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            Bilangan_One = Integer.Parse(TextBox1.Text)
            Bilangan_Two = Integer.Parse(TextBox2.Text)

            Hasil = Bilangan_One + Bilangan_Two

            MessageBox.Show(Hasil, "Jawaban", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox3.Text = Bilangan_One & " + " & Bilangan_Two & " = " & Hasil.ToString()
        Catch ex As FormatException
            MessageBox.Show("Invalid input. Please enter valid integers.")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            IsOverflow = Integer.TryParse(TextBox1.Text, Bilangan_One)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            IsOverflow = Integer.TryParse(TextBox2.Text, Bilangan_Two)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            Bilangan_One = Integer.Parse(TextBox1.Text)
            Bilangan_Two = Integer.Parse(TextBox2.Text)

            Hasil = Bilangan_One - Bilangan_Two

            MessageBox.Show(Hasil, "Jawaban", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox3.Text = Bilangan_One & " - " & Bilangan_Two & " = " & Hasil.ToString()
        Catch ex As FormatException
            MessageBox.Show("Invalid input. Please enter valid integers.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            IsOverflow = Integer.TryParse(TextBox1.Text, Bilangan_One)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            IsOverflow = Integer.TryParse(TextBox2.Text, Bilangan_Two)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            Bilangan_One = Integer.Parse(TextBox1.Text)
            Bilangan_Two = Integer.Parse(TextBox2.Text)

            Hasil = Bilangan_One * Bilangan_Two

            MessageBox.Show(Hasil, "Jawaban", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox3.Text = Bilangan_One & " * " & Bilangan_Two & " = " & Hasil.ToString()
        Catch ex As FormatException
            MessageBox.Show("Invalid input. Please enter valid integers.")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            IsOverflow = Integer.TryParse(TextBox1.Text, Bilangan_One)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            IsOverflow = Integer.TryParse(TextBox2.Text, Bilangan_Two)
            If Not IsOverflow Then
                MessageBox.Show("Input overflow. Please enter valid integers.")
                Exit Sub
            End If

            Bilangan_One = Integer.Parse(TextBox1.Text)
            Bilangan_Two = Integer.Parse(TextBox2.Text)

            If Bilangan_One = 0 Or Bilangan_Two = 0 Then
                MessageBox.Show("Invalid divided by zero input. Please enter valid integers.")
                Exit Sub
            End If

            Hasil = Bilangan_One / Bilangan_Two

            MessageBox.Show(Hasil, "Jawaban", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox3.Text = Bilangan_One & " / " & Bilangan_Two & " = " & Hasil.ToString()
        Catch ex As FormatException
            MessageBox.Show("Invalid input. Please enter valid integers.")
        End Try
    End Sub
End Class