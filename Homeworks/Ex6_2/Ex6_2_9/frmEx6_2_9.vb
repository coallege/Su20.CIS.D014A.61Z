Public Class frmEx6_2_9
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    'Note: Chr(65) is A and Chr(90) is Z
    Dim sentence, letter As String
    Dim numCaps As Integer = 0
    sentence = "The United States of America"
    For i As Integer = 0 To (sentence.Length - 1)
      letter = sentence.Substring(i, 1)
      If (Asc(letter) >= 65) And (Asc(letter) <= 90) Then
        numCaps += 1
      End If
    Next
    txtBox.Text = CStr(numCaps)
  End Sub
End Class
