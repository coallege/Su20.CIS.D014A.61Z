Imports System.Text

Public Class frmSchedule
  Private Shared Function FmtMoney(money As Double) As String
    ' Static method to just format the money correctly
    Return money.ToString("$#,###,##0.00").PadLeft(15)
  End Function

  Public Shared Sub DisplayDepreciation(dp As Depreciation)
    ' Static method that creates the Text Table
    ' Then makes a new window and shows it
    Dim sb = New StringBuilder(1000)
    sb.AppendLine($"Date/Time of Report   : {Now}")
    sb.AppendLine()
    sb.AppendLine($"Description           : {dp.Description}")
    sb.AppendLine($"Year of purchase      : {dp.PurchaseYear}")
    sb.AppendLine($"Cost                  : {dp.PurchaseAmount:$#,###,##0.00}")
    sb.AppendLine($"Estimated Life        : {dp.EstimatedLife}")
    sb.AppendLine($"Method of depreciation: {dp.MethodName}")
    sb.AppendLine()
    sb.AppendLine($"         Value at      Amount Deprec    Total Depreciation")
    sb.AppendLine($"Year     beg of Yr     During Year      to End of Year")

    dp.ForEachYear(
      Sub(dy)
        Dim strValueAtBeg = FmtMoney(dy.ValueAtBeginning)
        Dim strAmtDepDuringYr = FmtMoney(dy.AmountDepreciated)
        Dim strTotalDepAtEnd = FmtMoney(dy.TotalDepreciation)
        sb.AppendLine(
          $"{dy.Year}{strValueAtBeg}{strAmtDepDuringYr}{strTotalDepAtEnd}"
        )
      End Sub
    )
    ' Make the Window instance, set the text, and display it
    Dim instance = New frmSchedule
    instance.txtDisplay.Text = sb.ToString
    instance.txtDisplay.SelectionStart = 0 ' So the entire thing isn't highlighted
    instance.ShowDialog()
  End Sub

  Private Sub frmSchedule_Resize() Handles Me.Resize
    ' Makes that little drag thing on the bottom right side of the form useable
    tblLayout.Width = Width - 31
    tblLayout.Height = Height - 40
  End Sub

  Private Sub btnClose_Click() Handles btnClose.Click
    ' Close the form
    Close()
  End Sub
End Class
