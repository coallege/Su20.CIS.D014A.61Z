Imports System.Runtime.CompilerServices

Public Enum Suit
  Clubs
  Diamonds
  Hearts
  Spades
End Enum

Module SuitExtensions
  <Extension()>
  Public Function toString(currentSuit As Suit)
    Select Case currentSuit
      Case = Suit.Clubs
        Return "Clubs"
      Case = Suit.Diamonds
        Return "Diamonds"
      Case Suit.Hearts
        Return "Hearts"
      Case Suit.Spades
        Return "Spades"
      Case Else
        Throw New Exception("That's not a suit!")
    End Select
  End Function
End Module
