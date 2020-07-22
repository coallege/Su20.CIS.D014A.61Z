Public Class frmEx6_1_1
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim num As Integer = 3
    Do While num < 15
      num += 5
    Loop
    txtOutput.Text = CStr(num)
  End Sub
End Class
