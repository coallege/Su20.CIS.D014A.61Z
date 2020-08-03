Public MustInherit Class Depreciation
  '********************************************************************
  '*** Desc   : Abstracts over the two different types of Depreciation
  '*** Author : Cole Gannon
  '*** Date   : 08/02/2020
  '********************************************************************

  ' All of these are expected to be Not Null
  Public Description As String
  Public PurchaseYear As UShort
  Public PurchaseAmount As Double
  Public EstimatedLife As UShort
  Public MethodName As String

  ' I didn't want to implement IEnumerable so this is the
  ' interface to consume each DepreciatedYear instead
  MustOverride Sub ForEachYear(fn As DepreciatedYearConsumer)
End Class
