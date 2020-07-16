Public Class frmEx4_2_9
  Private Sub btnCompute_Click() Handles btnCompute.Click
    Dim msg As String = "You are old enough to vote"
    Dim dateOfBirth As Date = InputBox("Enter your date of birth.")
    If dateOfBirth.AddYears(18) <= Today Then
      txtOutput.Text = msg & "."
    Else
      txtOutput.Text =
        msg &
        " in " &
        DateDiff(DateInterval.Day, Today, dateOfBirth.AddYears(18)) &
        " days."
    End If
  End Sub
End Class
