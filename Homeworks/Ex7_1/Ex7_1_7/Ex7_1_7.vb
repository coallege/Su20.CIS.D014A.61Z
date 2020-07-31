Public Class Ex7_1_7
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim primes() As Integer = {2, 3, 5, 7, 11}
    lstOutput.Items.Add(primes(2) + primes(3))
  End Sub
End Class
