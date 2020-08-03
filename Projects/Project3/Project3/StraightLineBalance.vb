Public Class StraightLineBalance
  Inherits Depreciation

  Public Sub New(
    asset As String,
    purchaseYear As UShort,
    purchaseAmount As Double,
    estimatedLife As UShort
  )
    Me.Description = asset
    Me.PurchaseYear = purchaseYear
    Me.PurchaseAmount = purchaseAmount
    Me.EstimatedLife = estimatedLife
    Me.MethodName = "straight-line-balance"
  End Sub
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
      DY.TotalDepreciation = PurchaseAmount - currentValue
      fn(DY)
    Next
  End Sub
End Class
