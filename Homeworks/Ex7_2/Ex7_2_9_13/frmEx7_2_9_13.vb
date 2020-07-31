Public Class frmEx7_2_9_13
  Private Sub btnDisplay9_Click() Handles btnDisplay9.Click
    Dim numbers() = {"2", "6"}
    Dim query = numbers.Select(AddressOf Int)
    lstOutput.Items.Add(query(0) + query(1))
  End Sub

  Function Identity(Of T)(val As T) As T
    Return val
  End Function

  Private Sub btnDisplay13_Click() Handles btnDisplay13.Click
    Dim nums() As Integer = {12, 5, 7, 10, 3, 15, 4}
    Dim query = nums.Where(Function(num) num > 10).OrderByDescending(AddressOf Identity)
    lstOutput.DataSource = query.ToList
    lstOutput.SelectedItem = Nothing
  End Sub

  Private Sub btnReset_Click() Handles btnReset.Click
    Application.Restart()
    Environment.Exit(0)
  End Sub
End Class
