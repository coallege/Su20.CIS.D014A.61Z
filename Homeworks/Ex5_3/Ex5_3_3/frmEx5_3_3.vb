Public Class frmEx5_3_3
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim state As String = ""
    Dim flower As String = ""
    GetFacts(state, flower)
    txtOutput.Text = $"The state flower of {state} is the {flower}. "
  End Sub
  Sub GetFacts(ByRef place As String, ByRef plant As String)
    place = "Alaska"
    plant = "Forget Me Not"
  End Sub
End Class
