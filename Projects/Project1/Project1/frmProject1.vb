Public Class frmProject1
  '******************************************
  '*** Program: Project1 - Metric Conversion
  '*** Author : Cole Gannon
  '*** Date   : 7/15/2020 (late)
  '******************************************
  Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
    ' Converts the input from US distance to Metric distance and displays it
    ResetLstOutput()
    Dim intMiles = GetIntFromTextBox(txtMiles)
    Dim intYards = GetIntFromTextBox(txtYards)
    Dim intFeet = GetIntFromTextBox(txtFeet)
    Dim intInches = GetIntFromTextBox(txtInches)

    Dim dblTotal_Inches = (63360 * intMiles) + (36 * intYards) + (12 * intFeet) + intInches
    Dim dblTotal_meters = dblTotal_Inches / 39.37

    Dim intKilometers = Int(dblTotal_meters / 1000)

    Dim intMeters = Int(dblTotal_meters - (intKilometers * 1000))

    Dim dblCentemeters = (dblTotal_meters - (intKilometers * 1000) - intMeters) * 100.0
    DisplayMetricValues(intKilometers, intMeters, dblCentemeters)
  End Sub

  Private Sub ResetLstOutput()
    ' Reset the output back to it's original state
    lstOutput.Items.Clear() ' Remove the last output
    lstOutput.ForeColor = Color.Black ' Because sometimes it is DarkRed from an error
  End Sub

  Private Function GetIntFromTextBox(txtBox As TextBox) As Integer
    ' Gets an integer from the textbox but returns 0 if there's no integer there
    Dim intOutput As Integer
    Try
      intOutput = CInt(txtBox.Text) ' Sometimes this fails
    Catch ex As Exception
      intOutput = 0 ' CInt didn't work so the output can be 0
    End Try
    Return intOutput
  End Function

  Private Sub DisplayMetricValues(intKilometers As Integer, intMeters As Integer, dblCentemeters As Double)
    ' Display the metric values in the lstOutput
    lstOutput.Items.Add($"The Metric Length is {intKilometers} kilometers,")
    lstOutput.Items.Add(intMeters & " meters, ")
    lstOutput.Items.Add(Math.Round(dblCentemeters, 1) & " centemeters.") ' Round it to 1 decimal place and display
  End Sub
End Class
