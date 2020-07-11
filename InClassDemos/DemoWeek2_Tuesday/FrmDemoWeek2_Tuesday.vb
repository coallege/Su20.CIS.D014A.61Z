Public Class FrmDemoWeek2_Tuesday
   '*****************************************************
   '*** Program: DemoWeek2_Tuesday - sample start of proj1.
   '*** Author : Art Linn
   '*** Date   : 7/7/2020
   '*****************************************************

   Private Sub FrmDemoWeek2_Tuesday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'Setup program if needed
   End Sub

   Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
      'Calculates the metric lengths from english lengths
      On Error Resume Next
      Dim intMiles As Integer       'Input from user form
      Dim intYards As Integer       'Input from user form
      Dim intFeet As Integer        'Input from user form
      Dim intInches As Integer      'Input from user form
      Dim intTotalInches As Integer 'calculated from input
      Dim DblTotalMeters As Double  'Calculated using TotalInches
      Dim IntKilometers As Integer  'Calculated Klicks
      Dim dblMeters As Double       'Calculated Meters
      Dim DblCentimeters As Double  'Calculated Centimeters

      'Input the data
      intMiles = TxtMiles.Text
      intYards = TxtYards.Text
      intFeet = TxtFeet.Text
      intInches = TxtInches.Text

      'Calculate the lengths in metric values
      intTotalInches = (63360 * intMiles) +
                       (36 * intYards) +
                       (12 * intFeet) +
                       intInches
      DblTotalMeters = intTotalInches / 39.37
      IntKilometers = Int(DblTotalMeters / 1000)
      dblMeters = DblTotalMeters - (IntKilometers * 1000)
      'Calculate the Meters and Centimeters next


      'Output the results
      LstOutput.Items.Add("The metric length is:")
      LstOutput.Items.Add(IntKilometers & " kilometers")
      LstOutput.Items.Add(dblMeters & " meters")

   End Sub
End Class
