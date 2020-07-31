Public Class frmGrades
  Dim grades(3) As Double
  Private Sub frmGrades_Load() Handles MyBase.Load
    grades(0) = 80
    grades(1) = 90
  End Sub
  Private Sub btnDisplay_Click() Handles btnDisplay.Click
    grades(2) = 70
    grades(3) = 80
    Dim average = grades.Average
    txtOutput.Text = "Your average is " & average
  End Sub
End Class
