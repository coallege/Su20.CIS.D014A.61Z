Public Class frmProject4
  ReadOnly cards As List(Of Card) = New List(Of Card)

  Private Function getDummy(grpAny As GroupBox) As CheckBox
    Return (
      From ctrl In grpAny.Controls
      Where TypeOf ctrl Is CheckBox
    ).First
  End Function

  Dim intTabIndex = 1
  ReadOnly intSpaceBetweenCheckBoxes = 25
  Private Sub AddCardsTo(grpAny As GroupBox, suit As Suit)
    Dim dummy = getDummy(grpAny)
    grpAny.Controls.Remove(dummy)

    grpAny.TabIndex = intTabIndex
    intTabIndex += 1

    Dim offset = dummy.Location
    Dim constX = offset.X
    Dim currentY = offset.Y

    Dim ranks = [Enum].GetValues(GetType(Rank)).OfType(Of Rank).ToList()
    ranks.Sort()
    ranks.Reverse()
    For Each rank As Rank In ranks
      Dim strRank = rank.Display
      Dim currentCheckBox = New CheckBox With {
        .Text = strRank,
        .AutoSize = True,
        .Left = constX,
        .Top = currentY,
        .TabIndex = intTabIndex,
        .Cursor = Cursors.Hand
      }
      grpAny.Controls.Add(currentCheckBox)

      Dim currentCard = New Card(suit, rank, currentCheckBox)

      cards.Add(currentCard)

      currentY += intSpaceBetweenCheckBoxes
      intTabIndex += 1
    Next
  End Sub

  Private Sub frmProject4_Load() Handles MyBase.Load
    AddHandler btnClose.Click, AddressOf Close
    AddCardsTo(grpClubs, Suit.Clubs)
    AddCardsTo(grpDiamonds, Suit.Diamonds)
    AddCardsTo(grpHearts, Suit.Hearts)
    AddCardsTo(grpSpades, Suit.Spades)
  End Sub

  Private Sub Restart() Handles MyBase.Load, btnRestart.Click
    For Each card As Card In cards
      card.Deselect()
    Next
  End Sub

  Private Function GetSelectedCards() As Card()
    Return cards.Where(Function(card) card.IsSelected).ToArray
  End Function

  Private Function IsInSuccession(ary() As Integer) As Boolean
    For idx = 0 To ary.Length - 2
      Dim currentVal = ary(idx)
      Dim nextVal = ary(idx)
      If currentVal + 1 <> nextVal Then
        Return False
      End If
    Next
    Return True
  End Function

  Private Function IsStraight(hand As Card()) As Boolean

  End Function

  Private Sub btnShow_Click() Handles btnShow.Click
    Dim selectedCards = GetSelectedCards().ToList
    Dim intSelected = selectedCards.Count
    If intSelected <> 5 Then
      Dim strCards = If(intSelected = 1, "card", "cards")
      MsgBox($"You have selected {intSelected} {strCards}.{vbCrLf}Please select 5 cards.")
      Return
    End If

    selectedCards.Sort(Function(cardA As Card, cardB As Card) cardA.Rank < cardB.Rank)

    Console.WriteLine(
      String.Join(", ", selectedCards.Select(Function(card) card.ToString))
    )
  End Sub
End Class
