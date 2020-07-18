Public Class frmEx5_1_1
  Private Sub btnConvert_Click() Handles btnConvert.Click
    'Convert Celsius to Fahrenheit
    Dim temp As Double = 15
    txtOutput.Text = CStr(CtoF(temp))
  End Sub
  Function CtoF(t As Double) As Double
    Return ((9 / 5) * t) + 32
  End Function
End Class
