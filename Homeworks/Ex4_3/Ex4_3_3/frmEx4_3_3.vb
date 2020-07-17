Public Class frmEx4_3_3
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim age As Integer
    age = CInt(InputBox("Enter age (in millions of years)"))
    Select Case age
      Case Is < 70
        txtOutput.Text = "Cenozoic Era"
      Case Is < 225
        txtOutput.Text = "Mesozoic Era"
      Case Is <= 600
        txtOutput.Text = "Paleozoic Era"
      Case Else
        txtOutput.Text = "?"
    End Select
  End Sub
End Class
