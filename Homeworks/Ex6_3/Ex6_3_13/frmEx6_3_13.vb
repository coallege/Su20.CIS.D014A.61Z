Public Class frmEx6_3_13
  Private Sub btnCount_Click() Handles btnCount.Click
    Dim counter = 0
    For Each team As String In lstRoseBowl.Items
      If team = "USC" Then
        counter += 1
      End If
    Next
    txtOutput.Text = counter
  End Sub
End Class
