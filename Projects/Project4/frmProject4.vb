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

  Private Function IsInSuccession(nums As List(Of Integer)) As Boolean
    For idx = 0 To nums.Count - 2
      Dim currentVal = nums(idx)
      Dim nextVal = nums(idx + 1)
      If currentVal + 1 <> nextVal Then
        Return False
      End If
    Next
    Return True
  End Function

  Private Function IsStraight(hand As List(Of Card)) As Boolean
    Dim rankHand = (From card In hand Select card.Rank).Cast(Of Integer).ToList
    If IsInSuccession(rankHand) Then
      Return True
    End If

    ' Special case if there's an ace high
    If hand(4).Rank = Rank.Ace Then
      rankHand.RemoveAt(4)
      rankHand.Prepend(1) ' Low Ace
      ' Alright short rant time:
      ' I would have used Rank.LowAce but that just creates
      ' So many annoying issues and it's just best to have
      ' one Ace, even if it's a HighAce. I might change it
      ' Later by adding like AceLow and AceHigh and then
      ' branching in the function that makes all of the
      ' checkboxes but for now, I really can't be botherd
      ' and it's not worth replacing 1 with Rank.AceLow
      Return IsInSuccession(rankHand)
    End If
    Return False
  End Function

  Private Function OfAKinds(hand As List(Of Card)) As List(Of OfAKind)
    Dim outList = New List(Of OfAKind)
    Dim currentKind As OfAKind = New OfAKind With {
      .amount = 0,
      .kind = hand(0).Rank
    }
    For Each card In hand
      If card.Rank = currentKind.kind Then
        currentKind.amount += 1
      Else
        outList.Add(currentKind)
        currentKind = New OfAKind With {
          .amount = 1,
          .kind = card.Rank
        }
      End If
    Next
    outList.Add(currentKind) ' gotta add the last one
    Return outList
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

    Console.WriteLine(
      String.Join(", ", OfAKinds(selectedCards).Select(Function(oak) $"{oak.amount}x{oak.kind.Display}"))
    )

    Dim bolStraight = IsStraight(selectedCards)
    Dim bolFlush = selectedCards.TrueForAll(Function(card) card.Suit = selectedCards(0).Suit)
    Console.WriteLine($"Straight: {bolStraight}, Flush: {bolFlush}")
  End Sub
End Class
