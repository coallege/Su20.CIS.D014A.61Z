Public Class frmEx4_3_1
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim age, price As Double
    age = CDbl(InputBox("What is your age?"))
    Select Case age
      Case Is < 6
        price = 0
      Case 6 To 17
        price = 3.75
      Case Is >= 17
        price = 5
    End Select
    txtOutput.Text = "The price is " & price.ToString("C")
  End Sub
End Class
