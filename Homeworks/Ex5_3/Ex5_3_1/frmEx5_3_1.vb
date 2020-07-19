Public Class frmEx5_3_1
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim name As String = ""
    Dim yob As Integer
    GetVita(name, yob)
    txtOutput.Text = name & " was born in the year " & yob & "."
  End Sub
  Sub GetVita(ByRef name As String, ByRef yob As Integer)
    name = "Gabriel"
    yob = 1980 'year of birth
  End Sub
End Class
