Public Class frmEx7_4_1_3_7_9
  Dim nums(,) As Double = {
    {7, 3, 1, 0},
    {2, 5, 9, 8},
    {0, 6, 4, 10}
  }

  Private Sub Reset() Handles _
    btnDisplay1.Click,
    btnDisplay3.Click,
    btnDisplay7.Click,
    btnDisplay9.Click
    lstOutput.Items.Clear()
  End Sub

  Private Sub btnDisplay1_Click() Handles btnDisplay1.Click
    lstOutput.Items.Add(nums(0, 2))
  End Sub

  Private Sub btnDisplay3_Click() Handles btnDisplay3.Click
    lstOutput.Items.Add(nums.GetUpperBound(1))
  End Sub

  Private Sub btnDisplay7_Click() Handles btnDisplay7.Click
    Dim total As Double = 0
    For r As Integer = 0 To nums.GetUpperBound(0)
      total += nums(r, 2)
    Next
    lstOutput.Items.Add(total)
  End Sub

  Private Sub btnDisplay9_Click() Handles btnDisplay9.Click
    Dim query = From num In nums.Cast(Of Double)()
                Where (num > 8)
                Select num
    lstOutput.Items.Add(query.Count)
  End Sub
End Class
