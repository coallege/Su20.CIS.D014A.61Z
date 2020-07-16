Imports System.Console
Module Ex4_1_9_15_19
  '***********************************************************
  '*** Program: Exercise 4.1: 9, 15, 19
  '*** Author : Cole Gannon
  '*** Date   : 7/16/2020
  '***********************************************************
  Sub Main()
    Title = "Ex4_1_9_15_19"
    Dim a = 2
    Dim b = 3
    WriteLine("(a) = 2")
    WriteLine("(b) = 3")
    WriteLine(" 9: " & (b <= 3))
    WriteLine("15: " & (Not ((a < b) And (a < (b + a)))))
    WriteLine("19: " & ("9W" <> "9w"))

    ReadLine() ' So the window doesn't close
  End Sub
End Module
