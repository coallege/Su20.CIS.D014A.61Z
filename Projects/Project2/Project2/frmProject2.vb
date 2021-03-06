﻿Public Class frmProject2
  '**********************************************
  '*** Program: Project2 - Fast Food Order Menu
  '*** Author : Cole Gannon
  '*** Date   : 07/18/2020
  '**********************************************

  ' An array of all our RadioButtons
  Dim radArray As RadioButton()

  Sub frmProject2_Load() Handles MyBase.Load
    ' Initialize a bunch of variables we're going to be working with the entire lifecycle

    ' Close the form if btnClose is clicked
    AddHandler btnClose.Click, AddressOf Close

    ' Initialize the list of RadioButtons
    ' We have to wait until Load, otherwise these buttons are Nothing
    radArray = {
 _ ' Burger group
      radGrpBurgers_regular,
      radGrpBurgers_cheese,
      radGrpBurgers_bacon,
      radGrpBurgers_cheesebacon,
 _ ' Fries group
      radGrpFries_large,
      radGrpFries_medium,
      radGrpFries_small,
 _ ' Drinks group
      radGrpDrinks_soda,
      radGrpDrinks_water
    }

    ' Add the price display to each RadioButton
    For Each radCurrent As RadioButton In radArray
      radCurrent.Text &= $" ({radCurrent.Tag})"
    Next
  End Sub

  Sub Reset() Handles MyBase.Load, btnReset.Click
    ' Reset the form to it's default state. This is called on form load.
    chkBurgers.Checked = False
    chkFries.Checked = False
    chkDrinks.Checked = False
    lblOutput.Text = "Ready for next meal..."

    ' Uncheck each RadioButton
    For Each radCurrent As RadioButton In radArray
      radCurrent.Checked = False
    Next

    ' Check these three
    radGrpBurgers_regular.Checked = True
    radGrpFries_small.Checked = True
    radGrpDrinks_soda.Checked = True
  End Sub

  Private Sub chkBurgers_CheckedChanged() Handles chkBurgers.CheckedChanged
    ' Controls the visibility of the burgers group
    grpBurgers.Visible = chkBurgers.Checked
  End Sub

  Private Sub chkFries_CheckedChanged() Handles chkFries.CheckedChanged
    ' Controls the visibility of the fries group
    grpFries.Visible = chkFries.Checked
  End Sub

  Private Sub chkDrinks_CheckedChanged() Handles chkDrinks.CheckedChanged
    ' Controls the visibility of the drinks group
    grpDrinks.Visible = chkDrinks.Checked
  End Sub

  Private Sub btnTotal_Click() Handles btnTotal.Click
    ' Display output or errors to the user. If the user has selected items, show the total.
    Dim bolAnythingChecked = chkBurgers.Checked OrElse chkFries.Checked OrElse chkDrinks.Checked
    If bolAnythingChecked Then
      Dim dblTotalCost = calcTotal()
      Dim strTotalCost = $"Total Cost: ${Math.Round(dblTotalCost, 2)}"
      lblOutput.Text = strTotalCost
    Else
      lblOutput.Text = "Must check something..."
    End If
  End Sub

  Private Function calcTotal() As Double
    ' Get the total value of the Tags from each RadioButton that is checked
    Return radArray.Aggregate(0.0, ' Sum it up starting at 0.0
      Function(dblRunningTotal, radCurrent) dblRunningTotal + getFunctionalTotal(radCurrent))
  End Function

  Private Function getFunctionalTotal(radCurrent As RadioButton)
    ' Gets the functional (as in practical) total of the RadioButton
    If radCurrent.Parent.Visible And radCurrent.Checked Then
      Return CDbl(radCurrent.Tag)
    Else
      Return 0.0
    End If
  End Function
End Class
