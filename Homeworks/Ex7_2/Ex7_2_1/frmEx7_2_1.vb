Public Class frmEx7_2_1
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim nums() As Integer = {5, 7, 2, 3}
    Dim numQuery = nums.Where(Function(num) num > 4)
    For Each num As Integer In numQuery
      lstOutput.Items.Add(num)
    Next
  End Sub
End Class
