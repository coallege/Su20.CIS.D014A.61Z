Public Class DoubleDecliningBalance
  Inherits Depreciation

  Public Sub New(
    desc As String,
    purchaseYear As UShort,
    purchaseAmount As Double,
    estimatedLife As UShort
  )
    ' Initialize the DoubleDecliningBalance
    Me.Description = desc
    Me.PurchaseYear = purchaseYear
    Me.PurchaseAmount = purchaseAmount
    Me.EstimatedLife = estimatedLife
    Me.MethodName = "double-declining-balance"
  End Sub

  Public Overrides Sub ForEachYear(fn As DepreciatedYearConsumer)
    ' Go through each year and calculate the DepreciatedYear struct
    Dim currentValue As Double = PurchaseAmount
    For yearsDepreciated As UShort = 0 To (EstimatedLife - 2) ' The last year has a special case
      Dim DY As DepreciatedYear
      DY.MethodName = MethodName
      DY.Year = PurchaseYear + yearsDepreciated
      DY.LifeLeft = EstimatedLife - yearsDepreciated
      DY.ValueAtBeginning = currentValue
      ' This part is different than the StraightLineBalance
      DY.AmountDepreciated = DY.ValueAtBeginning * 2 / EstimatedLife
      currentValue -= DY.AmountDepreciated
      DY.ValueAtEnd = currentValue
      DY.TotalDepreciation = PurchaseAmount - currentValue

      fn(DY)
    Next
    ' Special last case
    fn(New DepreciatedYear With {
        .Year = PurchaseYear + EstimatedLife - 1,
        .LifeLeft = 0,
        .ValueAtBeginning = currentValue,
        .AmountDepreciated = currentValue,
        .ValueAtEnd = 0,
        .TotalDepreciation = PurchaseAmount,
        .MethodName = MethodName
      }
    )
  End Sub
End Class
