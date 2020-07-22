Public Class frmEx6_1_21
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    For i = 0 To 2
      lstOutput.Items.Add(InputBox("Enter a name:"))
    Next
  End Sub
End Class
