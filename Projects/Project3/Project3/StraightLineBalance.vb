Public MustInherit Class StraightLineBalance
  Inherits Depreciation

  Public Shadows MethodName As String = "straight-line-balance"
  Public Overrides Sub ForEachYear(fn As DepreciatedYearConsumer)
    Dim currentValue As Double = PurchaseAmount
    Dim yearlyDepreciation As Double = PurchaseAmount / EstimatedLife
    For yearsDepreciated As UShort = 0 To (EstimatedLife - 1)
      Dim DY As DepreciatedYear
      ' Always the same
      DY.MethodName = MethodName
      DY.AmountDepreciated = yearlyDepreciation

      DY.Year = PurchaseYear + yearsDepreciated
      DY.LifeLeft = EstimatedLife - yearsDepreciated
      DY.ValueAtBeginning = currentValue
      currentValue -= yearlyDepreciation
      DY.ValueAtEnd = currentValue

      fn(DY)
    Next
  End Sub
End Class
