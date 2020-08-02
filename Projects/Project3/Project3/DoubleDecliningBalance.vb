Public MustInherit Class DoubleDecliningBalance
  Inherits Depreciation

  Public Shadows MethodName As String = "straight-line-balance"
  Public Overrides Sub ForEachYear(fn As DepreciatedYearConsumer)
    Throw New NotImplementedException()
  End Sub
End Class
