Public MustInherit Class Depreciation
  '********************************************************************
  '*** Desc   : Abstracts over the two different types of Depreciation
  '*** Author : Cole Gannon
  '*** Date   : 08/02/2020
  '********************************************************************

  ' They call these Delegates in .NET land but they're just functions
  ' DepreciatedYearConsumer :: DepreciatedYear -> ()
  Public Delegate Sub DepreciatedYearConsumer(DYVal As DepreciatedYear)

  ' All of these are expected to be Not Null
  Public MustOverride Property Asset As String
  Public MustOverride Property PurchaseYear As UShort
  Public MustOverride Property PurchaseAmount As Double
  Public MustOverride Property EstimatedLife As UShort
  Public ReadOnly MethodName As String

  ' I didn't want to implement IEnumerable so this is the
  ' interface to consume each DepreciatedYear instead
  MustOverride Sub ForEachYear(fn As DepreciatedYearConsumer)
End Class
