Public Class frmEx5_2_1
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Piano(88)
  End Sub

  Sub Piano(num As Integer)
    txtOutput.Text = num & " keys on a piano"
  End Sub
End Class
