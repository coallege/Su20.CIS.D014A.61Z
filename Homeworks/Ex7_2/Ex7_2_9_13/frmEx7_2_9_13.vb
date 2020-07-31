Public Class frmEx7_2_9_13
  Private Sub btnDisplay9_Click() Handles btnDisplay9.Click
    'The first four lines of Numbers.txt contain the numbers 2, 6, 7, and 8.
    'Dim numbers() As String = IO.File.ReadAllLines("Numbers.txt")
    Dim numbers() = {"2", "6"}
    Dim query = From num In numbers
                Select CInt(num)
    lstOutput.Items.Add(query(0) + query(1))
  End Sub
  Private Sub btnDisplay13_Click() Handles btnDisplay13.Click
    Dim nums() As Integer = {12, 5, 7, 10, 3, 15, 4}
    Dim query = From num In nums
                Where num > 10
                Order By num Descending
                Select num
    lstOutput.DataSource = query.ToList
    lstOutput.SelectedItem = Nothing
  End Sub

  Private Sub btnReset_Click() Handles btnReset.Click
    Application.Restart()
    Environment.Exit(0)
  End Sub
End Class
