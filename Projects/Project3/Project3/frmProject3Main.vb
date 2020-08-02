Public Class frmProject3Main
  '****************************************************************
  '*** Program: Project3 - Depreciation to a Salvage Value of Zero
  '*** Author : Cole Gannon
  '*** Date   : 08/01/2020
  '****************************************************************
  Private Sub frmProject3Main_Load() Handles MyBase.Load
    txtDescription.Tag = "<Enter Item Description>"
    txtYearPurchased.Tag = "<Enter Year Purchased>"
    txtAmount.Tag = "<Enter Amount>"
    txtYearsLeft.Tag = "<Enter Number of Years>"
  End Sub

  Private Sub Reset() Handles MyBase.Load, btnRestart.Click
    ' Resets the form to the starting state
    ' This is called on load as well as when the
    ' Restart button is preseed
    txtDescription.Text = txtDescription.Tag
    txtYearPurchased.Text = txtYearPurchased.Tag
    txtAmount.Text = txtAmount.Tag
    txtYearsLeft.Text = txtYearsLeft.Tag

    radStraightLine.Checked = True
    radDoubleDeclining.Checked = False
  End Sub

  Private Sub btnClose_Click() Handles btnClose.Click
    ' Closes the Form
    Close()
  End Sub

  Private Sub btnCalc_Click() Handles btnCalc.Click
    If txtDescription.Text = txtDescription.Tag Then
      MsgBox("Must enter a Description.")
      Return
    End If


    If Not IsNumeric(txtYearPurchased.Text) Then
      MsgBox("Year Purchased is not numeric.")
      Return
    End If

    Dim yearPurchased As Integer
    If Not Integer.TryParse(txtYearPurchased.Text, yearPurchased) Then
      MsgBox("Year Purchased is not an Integer.")
      Return
    End If

    If yearPurchased < 1900.0 Or yearPurchased > 9999.0 Then
      MsgBox("Year Purchased is not between 1900 and 9999.")
      Return
    End If

    If Not IsNumeric(txtAmount.Text) Then
      MsgBox("Purchase Amount is not numeric.")
      Return
    End If

    Dim purchaseAmount = CDbl(txtAmount.Text)
    If purchaseAmount < 0.0 Then
      MsgBox("Purchase Amount must be > zero.")
      Return
    End If

    If Not IsNumeric(txtYearsLeft.Text) Then
      MsgBox("Years to Depreciate is not numeric.")
      Return
    End If

    Dim yearsLeft As Integer
    If Not Integer.TryParse(txtYearsLeft.Text, yearsLeft) Then
      MsgBox("Year to Depreciate is not an Integer.")
      Return
    End If

    If yearsLeft < 1 Or yearsLeft > 999 Then
      MsgBox("Number of years must be between 1 and 999.")
      Return
    End If

    ' verification good
  End Sub
End Class
