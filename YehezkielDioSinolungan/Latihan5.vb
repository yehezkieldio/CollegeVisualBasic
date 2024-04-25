Public Class Latihan5
    Private menuItems As New Dictionary(Of String, Decimal) From {
        {"Nasi Goreng", 15000},
        {"Nasi Padang", 25000},
        {"Es Teh", 8000},
        {"Kopi", 10000}
    }

    Private order As New List(Of KeyValuePair(Of String, Integer))
    Private meja As Integer = -1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Check if the item is already in the order
        Dim existingItem = order.Find(Function(item) item.Key = "Nasi Goreng")
        If existingItem.Key IsNot Nothing Then
            ' If the item is already in the order, remove it
            order.Remove(existingItem)
        Else
            ' If the item is not in the order, add it with quantity 1
            order.Add(New KeyValuePair(Of String, Integer)("Nasi Goreng", 1))
        End If

        UpdateOrderDisplay()
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Check if the item is already in the order
        Dim existingItem = order.Find(Function(item) item.Key = "Nasi Padang")
        If existingItem.Key IsNot Nothing Then
            ' If the item is already in the order, remove it
            order.Remove(existingItem)
        Else
            ' If the item is not in the order, add it with quantity 1
            order.Add(New KeyValuePair(Of String, Integer)("Nasi Padang", 1))
        End If

        UpdateOrderDisplay()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' Check if the item is already in the order
        Dim existingItem = order.Find(Function(item) item.Key = "Es Teh")
        If existingItem.Key IsNot Nothing Then
            ' If the item is already in the order, remove it
            order.Remove(existingItem)
        Else
            ' If the item is not in the order, add it with quantity 1
            order.Add(New KeyValuePair(Of String, Integer)("Es Teh", 1))
        End If

        UpdateOrderDisplay()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ' Check if the item is already in the order
        Dim existingItem = order.Find(Function(item) item.Key = "Kopi")
        If existingItem.Key IsNot Nothing Then
            ' If the item is already in the order, remove it
            order.Remove(existingItem)
        Else
            ' If the item is not in the order, add it with quantity 1
            order.Add(New KeyValuePair(Of String, Integer)("Kopi", 1))
        End If

        UpdateOrderDisplay()
    End Sub


    ' Helper method to update the order display
    Private Sub UpdateOrderDisplay()
        ' Clear the previous display
        ListBox1.Items.Clear()

        ' Display the current order
        For Each item In order
            Dim price = menuItems(item.Key)
            ListBox1.Items.Add(item.Key & " - " & price.ToString())
        Next

        ' update price total of Label2
        Dim total As Decimal = order.Sum(Function(item) menuItems(item.Key) * item.Value)
        Dim totalFormatted As String = total.ToString("C2").Substring(1)
        Label2.Text = "Total: " & totalFormatted
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        order.Clear()
        Label2.Text = "Total: 0"
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Latihan5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' add items or meja to ComboBox1
        For i As Integer = 1 To 10
            ComboBox1.Items.Add("Meja " & i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if a table has been selected
        If meja = -1 Then
            MessageBox.Show("Pilih meja terdahulu", "Tidak ada Meja", MessageBoxButtons.OK)
            Return
        End If

        ' check if the order is empty
        If order.Count = 0 Then
            MessageBox.Show("Harus ada satu orderan", "Tidak ada orderaan", MessageBoxButtons.OK)
            Return
        End If

        Dim total As Decimal = order.Sum(Function(item) menuItems(item.Key) * item.Value)
        Dim totalFormatted As String = total.ToString("C2").Substring(1)
        Dim finalMeja As Integer = meja + 1
        MessageBox.Show("Meja " & finalMeja & " Total Bayar " & totalFormatted, "Konfirmasi Checkout", MessageBoxButtons.OK)

        ' reset the order
        ListBox1.Items.Clear()
        order.Clear()
        Label2.Text = "Total: 0"
        ComboBox1.SelectedIndex = -1
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        meja = ComboBox1.SelectedIndex
    End Sub
End Class