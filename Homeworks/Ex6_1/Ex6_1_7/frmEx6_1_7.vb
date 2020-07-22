Public Class frmEx6_1_7
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim q As Double = 1
    Do While q > 0 ' ????????
      q = 3 * q - 1
      lstOutput.Items.Add(q)
    Loop
  End Sub
End Class
