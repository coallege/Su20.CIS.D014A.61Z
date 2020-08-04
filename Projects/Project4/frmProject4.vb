Public Class frmProject4
  ReadOnly cardTypes() As String = {
    "Ace", "King", "Queen", "Jack",
    "10", "9", "8", "7", "6", "5",
    "4", "3", "2"
  }

  ReadOnly cards = New List(Of CheckBox)
  Private Function getDummy(grpAny As GroupBox) As CheckBox
    Return (
      From ctrl In grpAny.Controls.Cast(Of Control)
      Where TypeOf ctrl Is CheckBox
    ).First
  End Function

  Dim intTabIndex = 1
  ReadOnly intSpaceBetweenCheckBoxes = 25
  Private Sub AddCardsTo(grpAny As GroupBox)
    Dim dummy = getDummy(grpAny)
    grpAny.Controls.Remove(dummy)

    grpAny.TabIndex = intTabIndex
    intTabIndex += 1

    Dim offset = dummy.Location
    Dim constX = offset.X
    Dim currentY = offset.Y

    For Each cardType As String In cardTypes
      Dim currentCheckBox = New CheckBox With {
        .AutoSize = True,
        .Left = constX,
        .Top = currentY,
        .TabIndex = intTabIndex,
        .Text = cardType,
        .Name = $"{grpAny.Name}_{cardType}"
      }
      grpAny.Controls.Add(currentCheckBox)
      cards.Add(currentCheckBox)

      currentY += intSpaceBetweenCheckBoxes
      intTabIndex += 1
    Next
  End Sub

  Private Sub frmProject4_Load() Handles MyBase.Load
    AddCardsTo(grpClubs)
    AddCardsTo(grpDiamonds)
    AddCardsTo(grpHearts)
    AddCardsTo(grpSpades)
  End Sub
End Class
