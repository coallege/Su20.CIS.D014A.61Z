Public Class frmEx6_2_1_5
  Private Sub frmEx6_2_1_5_Load() Handles MyBase.Load
    AddHandler tabExSelector.SelectedIndexChanged, AddressOf lstBox.Items.Clear
  End Sub

  Private Sub btnDisplay1_Click() Handles btnDisplay1.Click
    For i As Integer = 1 To 4
      lstBox.Items.Add("Pass #" & i)
    Next
  End Sub

  Private Sub btnDisplay5_Click() Handles btnDisplay5.Click
    Dim num As Integer = 5
    For i As Integer = num To (2 * num - 3)
      lstBox.Items.Add(i)
    Next
  End Sub
End Class
