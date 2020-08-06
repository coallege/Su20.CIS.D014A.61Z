Public Class Form
  Private Sub Form_Load() Handles MyBase.Load
    'txtOutput.resize
    txtOutput.Clear()
  End Sub
  Private Sub btnDisplay_Click24() Handles btnDisplay24.Click
    Dim a As Double = 2
    Dim b As Double = 3
    Dim c As Double = 5
    If a * b < c Then
      b = 7
    ElseIf c * a < b Then
      b = 11
    Else
      b = c * a
    End If
    txtOutput.Text = CStr(b)
  End Sub
  Private Sub btnDisplay_Click36() Handles btnDisplay36.Click
    Dim q As Double
    q = 4
    Do While q < 15
      q = 2 * q - 1
    Loop
    txtOutput.Text = CStr(q)
  End Sub
End Class
