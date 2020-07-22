Public Class frmEx6_1_5
  Private Sub btnCompute_Click()
    Dim num As Double
    Dim max As Double = -1
    Dim prompt As String =
      "Enter a nonnegative number. " &
      "Enter −1 to terminate entering numbers."
    num = CDbl(InputBox(prompt))
    Do While num >= 0
      If num > max Then
        max = num
      End If
      num = CDbl(InputBox(prompt))
    Loop
    If max <> -1 Then
      MessageBox.Show("Maximum number: " & max)
    Else
      MessageBox.Show("No numbers were entered.")
    End If
  End Sub

  ' Mine's better
  Private Sub better_btnCompute_Click() Handles btnCompute.Click
    Dim dblList = New List(Of Double)
    Dim prompt =
      "Enter a nonnegative number. " &
      "Enter −1 to terminate entering numbers."
    Do
      Dim inp = InputBox(prompt)
      If inp <> -1 Then
        dblList.Add(inp)
      Else
        Exit Do
      End If
    Loop
    If dblList.Count > 1 Then
      MessageBox.Show("Maximum number: " & dblList.Max)
    Else
      MessageBox.Show("No numbers were entered.")
    End If
  End Sub
End Class
