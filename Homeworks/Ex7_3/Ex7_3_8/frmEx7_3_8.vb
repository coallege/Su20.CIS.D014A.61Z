Public Class frmEx7_3_8
  Structure Employee
    Dim name As String
    Dim dateHired As Date
    Dim hasDependents As Boolean
  End Structure

  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    Dim worker As Employee
    worker.name = "John Jones"
    worker.dateHired = #9/20/2016#
    worker.hasDependents = True
    If DateDiff(DateInterval.Day, worker.dateHired, #1/1/2017#) < 180 Then
      MessageBox.Show("Not eligible to participate in the health plan.")
    Else
      MessageBox.Show($"The monthly cost of your health plan is {HealthPlanCost(worker.hasDependents)}.")
    End If
  End Sub

  Function HealthPlanCost(hasDependents As Boolean) As String
    Return If(hasDependents, 75, 50).ToString("C")
  End Function
End Class
