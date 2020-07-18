Public Class frmEx5_1_5
  Private Sub btnOutput_Click() Handles btnOutput.Click
    Dim num As Integer = 27
    MessageBox.Show($"{num} is an {If(IsEven(num), "even", "odd")} number.")
  End Sub
  Function IsEven(n As Integer) As Boolean
    Return n Mod 2 = 0
  End Function
End Class
