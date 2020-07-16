Public Class frmEx4_2_1
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim num As Double = 4
    If num <= 9 Then
      txtOutput.Text = "Less than ten."
    ElseIf num = 4 Then
      txtOutput.Text = "Equal to four."
    End If
  End Sub
End Class
