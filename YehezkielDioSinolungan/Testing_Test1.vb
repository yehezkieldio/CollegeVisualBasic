Public Class Testing_Test1
    Dim currentPlayer As String = "X"
    Dim board As New List(Of String) From {"", "", "", "", "", "", "", "", ""}

    Private Sub Testing_Test1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each btn As Button In Me.Controls.OfType(Of Button)()
            If btn.Name.StartsWith("Button") Then
                AddHandler btn.Click, AddressOf Button_Click
            End If
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If btn.Text = "" Then
            btn.Text = currentPlayer
            Dim index As Integer
            Try
                index = Convert.ToInt32(btn.Name.Substring(3)) - 1
            Catch ex As FormatException
                index = 0 ' Default value
            End Try
            board(index) = currentPlayer
            If CheckWin() Then
                MessageBox.Show(currentPlayer & " wins!")
                ResetGame()
            ElseIf board.All(Function(s) s <> "") Then
                MessageBox.Show("It's a draw!")
                ResetGame()
            Else
                SwitchPlayer()
            End If
        End If
    End Sub

    Private Sub SwitchPlayer()
        If currentPlayer = "X" Then
            currentPlayer = "O"
        Else
            currentPlayer = "X"
        End If
    End Sub

    Private Function CheckWin() As Boolean
        Dim winningCombinations As New List(Of List(Of Integer)) From {
            New List(Of Integer) From {0, 1, 2},
            New List(Of Integer) From {3, 4, 5},
            New List(Of Integer) From {6, 7, 8},
            New List(Of Integer) From {0, 3, 6},
            New List(Of Integer) From {1, 4, 7},
            New List(Of Integer) From {2, 5, 8},
            New List(Of Integer) From {0, 4, 8},
            New List(Of Integer) From {2, 4, 6}
        }

        For Each combination In winningCombinations
            Dim a As Integer = combination(0)
            Dim b As Integer = combination(1)
            Dim c As Integer = combination(2)
            If board(a) <> "" AndAlso board(a) = board(b) AndAlso board(a) = board(c) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ResetGame()
        For Each btn As Button In Me.Controls.OfType(Of Button)()
            If btn.Name.StartsWith("btn") Then
                btn.Text = ""
            End If
        Next
        board = New List(Of String) From {"", "", "", "", "", "", "", "", ""}
        currentPlayer = "X"
    End Sub
End Class