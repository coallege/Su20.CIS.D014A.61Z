Public Class frmEx7_1_5
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim colors(120) As String
    colors(0) = "Atomic Tangerine"
    colors(100) = "Tan"
    If colors(0).IndexOf(colors(100)) = 1 Then
      txtOutput.Text = "No"
    Else
      txtOutput.Text = "Yes"
    End If
  End Sub
End Class
