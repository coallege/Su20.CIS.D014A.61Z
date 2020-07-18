Public Class frmEx5_2_11
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    'The fates of Henry the Eighth's six wives
    CommonFates()
    lstOutput.Items.Add("died")
    CommonFates()
    lstOutput.Items.Add("survived")
  End Sub
  Sub CommonFates()
    'The most common fates
    lstOutput.Items.Add("divorced")
    lstOutput.Items.Add("beheaded")
  End Sub
End Class
