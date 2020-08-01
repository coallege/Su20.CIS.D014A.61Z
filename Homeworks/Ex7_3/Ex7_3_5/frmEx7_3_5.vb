Public Class frmEx7_3_5
  Structure Appearance
    Dim height As Double
    Dim weight As Double
  End Structure
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim person1, person2 As Appearance
    person1.height = 72
    person1.weight = 170
    person2.height = 12 * 6
    If person1.height = person2.height Then
      lstOutput.Items.Add("heights are same")
    End If
    person2 = person1
    lstOutput.Items.Add(person2.weight)
  End Sub
End Class
