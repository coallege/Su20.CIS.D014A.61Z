Public Class frmEx5_2_5
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim hours As Double
    hours = 24
    Minutes(60 * hours)
  End Sub
  Sub Minutes(num As Double)
    txtOutput.Text = num & " minutes in a day"
  End Sub
End Class
