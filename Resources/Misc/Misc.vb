Module Misc
  Sub DoubleIt(ByRef val As Double)
    val *= 2
  End Sub

  Sub Main()
    Console.ReadKey()
  End Sub

  Function SquareIt(val As Long) As Single
    Return val * val
  End Function
End Module
