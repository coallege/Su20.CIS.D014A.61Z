Module Misc

  Sub DoubleIt(ByRef val As Double)
    val *= 2
  End Sub
  Sub Main()
    Dim a As Double = 27
    Console.WriteLine(a)
    DoubleIt(a)
    Console.WriteLine(a)
    Console.ReadKey()
  End Sub

End Module
