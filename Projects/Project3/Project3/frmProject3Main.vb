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
    ' Performs verification on inputs then
    ' makes a Depreciation to hand off to frmSchedule

    ' Description
    If txtDescription.Text = txtDescription.Tag Then
      MsgBox("Must enter a Description.")
      Return
    End If

    Dim strDescription = txtDescription.Text

    ' Year purchased
    If Not IsNumeric(txtYearPurchased.Text) Then
      MsgBox("Year Purchased is not numeric.")
      Return
    End If

    Dim intYearPurchased As Integer

    If Not Integer.TryParse(txtYearPurchased.Text, intYearPurchased) Then
      MsgBox("Year Purchased is not an Integer.")
      Return
    End If

    If intYearPurchased < 1900.0 Or intYearPurchased > 9999.0 Then
      MsgBox("Year Purchased is not between 1900 and 9999.")
      Return
    End If

    Dim uintYearPurchased As UShort = intYearPurchased

    ' Purchase amount
    If Not IsNumeric(txtAmount.Text) Then
      MsgBox("Purchase Amount is not numeric.")
      Return
    End If

    Dim dblPurchaseAmount = CDbl(txtAmount.Text)
    If dblPurchaseAmount < 0.0 Then
      MsgBox("Purchase Amount must be > zero.")
      Return
    End If

    ' Years to Depreciate
    If Not IsNumeric(txtYearsLeft.Text) Then
      MsgBox("Years to Depreciate is not numeric.")
      Return
    End If

    Dim intYearsLeft As Integer
    If Not Integer.TryParse(txtYearsLeft.Text, intYearsLeft) Then
      MsgBox("Year to Depreciate is not an Integer.")
      Return
    End If

    If intYearsLeft < 1 Or intYearsLeft > 999 Then
      MsgBox("Number of years must be between 1 and 999.")
      Return
    End If

    Dim uintYearsLeft As UShort = intYearsLeft


    Dim dpMethod As Depreciation

    ' Choose which Depreciation to make based on the radio button
    If radStraightLine.Checked Then
      dpMethod = New StraightLineBalance(
        desc:=strDescription,
        purchaseYear:=uintYearPurchased,
        purchaseAmount:=dblPurchaseAmount,
        estimatedLife:=uintYearsLeft
      )
    Else
      dpMethod = New DoubleDecliningBalance(
        desc:=strDescription,
        purchaseYear:=uintYearPurchased,
        purchaseAmount:=dblPurchaseAmount,
        estimatedLife:=uintYearsLeft
      )
    End If
    frmSchedule.DisplayDepreciation(dpMethod)

    ' This wasn't required in the specification document but
    ' the provided example program had it so I'll put one in

    Dim bolStartNew = MsgBox(
      Title:="Start a new one?",          ' Named arguments because I 
      Prompt:="Start a new calculation?", ' forget which order these go in
      Buttons:=MsgBoxStyle.YesNo
    )
    If bolStartNew = MsgBoxResult.Yes Then
      Reset()
    End If
  End Sub
End Class
