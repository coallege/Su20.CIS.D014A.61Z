Public Class frmProject4
  '************************************************
  '*** Program: Project4 - Poker Hand Determiner
  '*** Author : Cole Gannon
  '*** Date   : 08/04/2020 (mm/dd/yyyy)
  '************************************************

  ReadOnly cards As List(Of Card) = New List(Of Card)

  Private Sub Restart() Handles MyBase.Load, btnRestart.Click
    ' Deselect each card that is on the form
    ' The fist time this runs, there are no cards on the form
    cards.ForEach(Sub(card) card.Deselect())
  End Sub

  Private Sub frmProject4_Load() Handles MyBase.Load
    ' Add all of the checkboxes to the mostly empty form
    AddHandler btnClose.Click, AddressOf Close
    AddCardsTo(grpClubs, Suit.Clubs)
    AddCardsTo(grpDiamonds, Suit.Diamonds)
    AddCardsTo(grpHearts, Suit.Hearts)
    AddCardsTo(grpSpades, Suit.Spades)
  End Sub

  ' Running TabIndex because all of the checkboxes
  ' and GroupBoxes should have different indexes
  Dim intTabIndex = 1

  ReadOnly intSpaceBetweenCheckBoxes = 25

  Private Sub AddCardsTo(grpAny As GroupBox, suit As Suit)
    ' Add the CheckBoxes to grpAny given a Suit

    ' The dummy is only used for the X and Y offsets
    ' of the real checkboxes
    Dim dummy = GetDummy(grpAny)
    ' Remove it because we don't need it anymore
    grpAny.Controls.Remove(dummy)

    grpAny.TabIndex = intTabIndex
    intTabIndex += 1

    ' Even though dummy isn't on the Form anymore,
    ' We can still get it's location
    Dim offset = dummy.Location
    Dim constX = offset.X
    Dim currentY = offset.Y

    ' Get all the ranks
    ' Cast to a List so I can use Sorts and other convenient List things
    Dim ranks = [Enum].GetValues(GetType(Rank)).OfType(Of Rank).ToList()
    ranks.Sort()
    ranks.Reverse() ' Now it's in descending order

    For Each rank As Rank In ranks
      Dim strRank = rank.Display
      Dim currentCheckBox = New CheckBox With {
        .Text = strRank,
        .AutoSize = True, ' Size based on contents
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

  Private Function GetDummy(grpAny As GroupBox) As CheckBox
    ' Gets the dummy checkbox (###) given a GroupBox
    Return (
      From ctrl In grpAny.Controls
      Where TypeOf ctrl Is CheckBox
    ).First
  End Function

  Private Function GetSelectedCards() As Card()
    ' it gets the selected cards
    Return cards.Where(Function(card) card.IsSelected).ToArray
  End Function

  Private Function IsInSuccession(nums As List(Of Integer)) As Boolean
    ' Checks if a List is in integer succession
    ' Used in IsStraight
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

  Private Function IsFlush(hand As List(Of Card)) As Boolean
    ' All cards in the hand are the same suit as the first card
    Return hand.TrueForAll(Function(card) card.Suit = hand(0).Suit)
  End Function

  Private Function OfAKinds(hand As List(Of Card)) As List(Of OfAKind)
    ' Makes a List of OfAKinds given a hand
    ' Examples:
    ' A, A, A, K, K -> 3xA, 2xK
    ' 1, 2, 3, 4, 5 -> 1x1, 1x2, 1x3, 1x4, 1x5
    ' J, J, J, J, 7 -> 4xJ, 1x7
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

  ' OfAKinds :: UShort -> OfAKind -> bool
  Private Function OaKAmount(n As UShort) As Predicate(Of OfAKind)
    ' Curried function used for List methods
    Return Function(oak As OfAKind) oak.amount = n
  End Function

  Private Sub btnShow_Click() Handles btnShow.Click
    ' Find out what type of hand the user has selected
    ' Display it through a MsgBox

    ' Check if the user has selected 5 cards
    Dim selectedCards = GetSelectedCards().ToList
    Dim intSelected = selectedCards.Count
    If intSelected <> 5 Then
      Dim strCards = If(intSelected = 1, "card", "cards")
      MsgBox($"You have selected {intSelected} {strCards}.{vbCrLf}Please select 5 cards.")
      Return
    End If

    selectedCards.Sort() ' Sorts by Card.Rank. See Card.CompareTo

    Dim bolStraight = IsStraight(selectedCards)
    Dim bolFlush = IsFlush(selectedCards)

    If bolStraight AndAlso bolFlush Then
      If selectedCards(0).Rank = Rank.Ten Then
        MsgBox("Royal Flush")
      Else
        MsgBox("Straight Flush")
      End If
      Return
    End If

    Dim OaKs = OfAKinds(selectedCards)

    If OaKs.Exists(OaKAmount(4)) Then
      MsgBox("Four of a Kind")
      Return
    End If

    Dim bol3ofAKind = OaKs.Exists(OaKAmount(3))

    ' Even though I should be able to simplify this,
    ' I can't because in <T> Func<T, Boolean> !== Predicate<T>
    ' Why this doesn't work? No clue.
    Dim int2ofAKindCount = OaKs.Where(Function(v) OaKAmount(2)(v)).Count

    If bol3ofAKind AndAlso int2ofAKindCount = 1 Then
      MsgBox("Full House")
      Return
    End If

    If bolFlush Then
      MsgBox("Flush")
      Return
    End If

    If bolStraight Then
      MsgBox("Straight")
      Return
    End If

    If bol3ofAKind Then
      MsgBox("Three of a Kind")
      Return
    End If

    If int2ofAKindCount = 2 Then
      MsgBox("Two Pair")
      Return
    End If

    If int2ofAKindCount = 1 Then
      MsgBox("One Pair")
      Return
    End If

    MsgBox("Nothing")
  End Sub
End Class
