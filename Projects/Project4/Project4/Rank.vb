Imports System.Runtime.CompilerServices

Public Enum Rank
  Ace = 14
  King = 13
  Queen = 12
  Jack = 11
  Ten = 10
  Nine = 9
  Eight = 8
  Seven = 7
  Six = 6
  Five = 5
  Four = 4
  Three = 3
  Two = 2
End Enum

Module RankExtensions
  <Extension()>
  Public Function Display(currentRank As Rank) As String
    ' Extension method so that I can call Rank.*.Display
    ' That way I can keep the logic for rank all in one file
    Select Case currentRank
      Case = Rank.Ace
        Return "Ace"
      Case = Rank.King
        Return "King"
      Case Rank.Queen
        Return "Queen"
      Case Rank.Jack
        Return "Jack"
      Case Rank.Ten
        Return "10"
      Case Rank.Nine
        Return "9"
      Case Rank.Eight
        Return "8"
      Case Rank.Seven
        Return "7"
      Case Rank.Six
        Return "6"
      Case Rank.Five
        Return "5"
      Case Rank.Four
        Return "4"
      Case Rank.Three
        Return "3"
      Case Rank.Two
        Return "2"
      Case Else
        Throw New Exception("This should never happen")
    End Select
  End Function
End Module

