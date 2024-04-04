Public Class Tugas3_Praktikum5_Form3
    Private Sub Tugas3_Praktikum5_Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("+")
        ComboBox1.Items.Add("-")
        ComboBox1.Items.Add("/")
        ComboBox1.Items.Add("Sisa")
        ComboBox1.Items.Add("Pangkat")
        ComboBox1.Items.Add("<>")
        ComboBox1.Items.Add("<")
        ComboBox1.Items.Add(">")
        ComboBox1.Items.Add("<=")
        ComboBox1.Items.Add(">=")
        ComboBox1.Items.Add("Like")
        ComboBox1.Items.Add("Not")
        ComboBox1.Items.Add("And")
        ComboBox1.Items.Add("Or")
        ComboBox1.Items.Add("Xor")
        ComboBox1.Items.Add("+p")
        ComboBox1.Items.Add("&")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "+"
                TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
            Case "-"
                TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
            Case "/"
                TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
            Case "Sisa"
                TextBox3.Text = Val(TextBox1.Text) Mod Val(TextBox2.Text)
            Case "Pangkat"
                TextBox3.Text = Val(TextBox1.Text) ^ Val(TextBox2.Text)
            Case "<>"
                TextBox3.Text = Val(TextBox1.Text) <> Val(TextBox2.Text)
            Case "<"
                TextBox3.Text = Val(TextBox1.Text) < Val(TextBox2.Text)
            Case ">"
                TextBox3.Text = Val(TextBox1.Text) > Val(TextBox2.Text)
            Case "<="
                TextBox3.Text = Val(TextBox1.Text) <= Val(TextBox2.Text)
            Case ">="
                TextBox3.Text = Val(TextBox1.Text) >= Val(TextBox2.Text)
            Case "Like"
                TextBox3.Text = Val(TextBox1.Text) Like Val(TextBox2.Text)
            Case "Not"
                TextBox3.Text = Not Val(TextBox1.Text)
            Case "And"
                TextBox3.Text = Val(TextBox1.Text) And Val(TextBox2.Text)
            Case "Or"
                TextBox3.Text = Val(TextBox1.Text) Or Val(TextBox2.Text)
            Case "Xor"
                TextBox3.Text = Val(TextBox1.Text) Xor Val(TextBox2.Text)
            Case "+p"
                TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
            Case "&"
                TextBox3.Text = Val(TextBox1.Text) & Val(TextBox2.Text)
        End Select
    End Sub
End Class