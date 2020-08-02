Public MustInherit Class StraightLineBalance
  Inherits Depreciation

  Public Shadows MethodName As String = "straight-line-balance"
  Public Overrides Sub ForEachYear(fn As DepreciatedYearConsumer)
    Dim currentValue As Double = PurchaseAmount
    Dim yearlyDepreciation As Double = PurchaseAmount / EstimatedLife
    For lifeLeft As UShort = 0 To EstimatedLife
      Dim valueAtBeginning = currentValue
      currentValue -= yearlyDepreciation
      Dim valueAtEnd = currentValue
      Dim DY = New DepreciatedYear With {
        .Year = PurchaseYear + lifeLeft,
        .LifeLeft = lifeLeft,
        .ValueAtBeginning = valueAtBeginning,
        .AmountDepreciated = yearlyDepreciation,
        .ValueAtEnd = valueAtEnd,
        .MethodName = MethodName
      }
      fn(DY)
    Next
  End Sub
End Class
