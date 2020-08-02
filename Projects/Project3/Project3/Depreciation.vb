Public MustInherit Class Depreciation
  ' They call these Delegates in .NET land but they're just functions
  ' DepreciatedYearConsumer :: DepreciatedYear -> ()
  Public Delegate Sub DepreciatedYearConsumer(DYVal As DepreciatedYear)

  Public MustOverride Property Asset As String
  Public MustOverride Property PurchaseYear As UShort
  Public MustOverride Property PurchaseAmount As Double
  Public MustOverride Property EstimatedLife As UShort
  Public ReadOnly MethodName As String

  MustOverride Sub ForEachYear(fn As DepreciatedYearConsumer)
End Class
