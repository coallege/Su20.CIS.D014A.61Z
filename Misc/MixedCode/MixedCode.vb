Imports System.Console

Module MixedCode
  Sub Main()
    WriteLine(Math.Round(4.45, 1))
    WriteLine(5 & 4)
    Dim form = New Form()
    'form.ShowDialog()
    Select Case 1
      Case Is = 1
    End Select
    Dim q As Double = 3
    Dim i As UShort
    Do
      q = 2 * q - 1
      i += 1
    Loop Until (q > 15)
    WriteLine($"Do Loop Ran {i} Times")
    'q38()
    q40()
    'q44()
    Dim ary0(1) As Double
    Dim ary1(1) As Double
    ary0.CopyTo(ary1, 0)
    ReDim Preserve ary0(2)
    WriteLine("Press any key to continue...")
    ReadKey()
  End Sub

  Sub q38()
    Dim flag As Boolean
    Dim a As Integer = 10
    Dim num As Integer
    num = a Mod 5
    Do While flag = False
      a += num
      If a * num <> 0 Then
        flag = True
      End If
    Loop
    WriteLine($"38: {a}")
  End Sub

  Sub q40()
    Dim row As String = ""
    For i As Integer = 1 To 9
      row &= "*"
    Next
    WriteLine($"40: {row}")
  End Sub

  Sub q44()
    Dim a(3) As Integer
    Dim intNumber As Integer = 6
    Dim i As Integer
    Dim bolFound As Boolean

    For i = 0 To 3
      If a(i) = intNumber Then
        bolFound = True
      End If
    Next
    If bolFound = False Then
      MsgBox("Not found this: " & a(i))
    End If
  End Sub
End Module
