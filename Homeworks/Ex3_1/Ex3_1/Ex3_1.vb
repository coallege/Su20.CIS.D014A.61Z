Imports System.Console

Module Ex3_1
  '*****************************************************
  '*** Program: Ex3_1 - Helper VBProj for Ex3_1
  '*** Author : Cole Gannon
  '*** Date   : 7/12/2020 (m/d/yyy)
  '*** Desc   : 3.1([1,2];[7,8];[11,12];[32,33])
  '*****************************************************
  Sub Main()
    Ex3_1_1_2()
    Pause()
    Ex3_1_7_8()
    Pause()
    Ex3_1_11_12()
    Pause()
    Ex3_1_32_33()
    Pause()
  End Sub
  Sub Pause()
    ' Pause the code by waiting for the user to press a key
    Write("Press any key to continue...")
    ReadKey()
    WriteLine()
    WriteLine()
  End Sub
  Sub Ex3_1_1_2()
    ' Ex3.1 sub exercises 1 and 2
    WriteLine("Ex_1_1_2")
    WriteLine("3 * 4 = " & 3 * 4)
    WriteLine("7 ^ 2 = " & 7 ^ 2)
  End Sub
  Sub Ex3_1_7_8()
    ' Ex3.1 sub exercises 7 and 8
    WriteLine("Ex_1_7_8")
    WriteLine("7 \ 3 = " & 7 \ 3)
    WriteLine("14 Mod 4 = " & 14 Mod 4)
  End Sub
  Sub Ex3_1_11_12()
    ' Ex3.1 sub exercises 11 and 12
    WriteLine("Ex_1_11_12")
    WriteLine("14 \ 4 = " & 14 \ 4)
    ' Including this here for completeness
    ' We already know that n Mod n always is 0
    WriteLine("5 Mod 5 = " & 5 Mod 5)
  End Sub
  Sub Ex3_1_32_33()
    ' Ex3.1 sub exercises 32(2) and 33
    WriteLine("Ex_1_32_33")
    Dim amount As Double = 10
    WriteLine(amount - 4) ' Wasn't sure if the output would be 6 or 6.0
  End Sub
End Module
