Public Class frmEx7_2_5
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim line As String = "If,you,fail,to,plan,then,you,plan,to,fail"
    Dim words() As String = line.Split(","c)
    'Dim wordQuery = From word In words
    '                Select word
    '                Distinct
    'txtOutput.Text = CStr(wordQuery.Count)
    Dim distinctWords = words.Distinct.Count
    txtOutput.Text = distinctWords
  End Sub
End Class
