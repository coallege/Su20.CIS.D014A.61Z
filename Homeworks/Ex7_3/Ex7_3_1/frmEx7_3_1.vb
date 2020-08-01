Public Class frmEx7_3_1
  Private Class Rectangle
    Public width As Integer
    Public height As Integer
    Public Function Area() As Integer
      Return width * height
    End Function
  End Class

  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim footballField As Rectangle = New Rectangle
    footballField.height = 120   'yards
    footballField.width = 160    'yards
    txtOutput.Text = $"The area of a football field is {footballField.Area} square yards."
  End Sub
End Class
