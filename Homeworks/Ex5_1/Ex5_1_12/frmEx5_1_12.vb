Public Class frmEx5_1_12
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim word As String
    word = InputBox("What is your favorite word?")
    txtOutput.Text = "When the word is written twice, " &
                  Twice(word) & " letters are used."
  End Sub
  Function Twice(w As String) As Integer
    'Compute twice the length of a string
    Return 2 * w.Length
  End Function
End Class
