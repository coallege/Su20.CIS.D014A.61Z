Public Class frmEx4_2_3
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim change As Double = 356
    'Amount of change in cents
    If change >= 100 Then
      txtOutput.Text = "Your change contains " & Int(change / 100) & " dollars."
    Else
      txtOutput.Text = "Your change contains no dollars."
    End If
  End Sub
End Class
