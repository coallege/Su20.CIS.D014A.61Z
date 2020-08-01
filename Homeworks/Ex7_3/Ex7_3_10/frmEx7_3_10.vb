Public Class frmEx7_3_10
  Structure TaxData
    Dim socSecNum As String
    Dim numWithAllow As Integer 'number of withholding allowances
    Dim maritalStatus As String
    Dim hourlyWage As Double
  End Structure

  Structure Employee
    Dim name As String
    Dim hrsWorked As Double
    Dim taxInfo As TaxData
  End Structure

  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim worker As Employee
    worker.name = "Hannah Jones"
    worker.hrsWorked = 40
    worker.taxInfo.hourlyWage = 20
    txtOutput.Text = worker.name & " earned " &
      (worker.hrsWorked * worker.taxInfo.hourlyWage).ToString("C")
  End Sub
End Class
