Public Class frmEx5_3_6
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim price, markdown, salesTax, finalCost As Decimal
    InputData(price, markdown, salesTax)
    finalCost = CostOfItem(price, markdown, salesTax)
    DisplayOutput(price, finalCost)
  End Sub
  Sub InputData(ByRef price As Decimal, ByRef markdown As Decimal, ByRef salesTax As Decimal)
    price = CDec(InputBox("Price of item:"))
    markdown = CDec(InputBox("Percentage discount:"))
    salesTax = CDec(InputBox("Percentage state sales tax:"))
  End Sub
  Function CostOfItem(pr As Decimal, md As Decimal, st As Decimal) As Decimal
    Dim reducedPrice, cost As Decimal
    reducedPrice = pr - ((md / 100) * pr)
    cost = reducedPrice + ((st / 100) * reducedPrice)
    Return cost
  End Function
  Sub DisplayOutput(amount As Decimal, customerCost As Decimal)
    lstOutput.Items.Add("Original Price: " & amount.ToString("C"))
    lstOutput.Items.Add("Cost: " & customerCost.ToString("C"))
  End Sub
End Class
