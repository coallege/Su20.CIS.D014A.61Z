Public Class FrmDemoWeek2_Thursday
  '**************************************************
  '*** Program: Demo String manipulations
  '*** Author : Art Linn
  '*** Date   : 7/9/2020
  '**************************************************
  'Class level variables
  Dim IntCount As Integer

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Setup program

  End Sub

  Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
    'Closes the window
    Me.Close()

  End Sub

  Private Sub BtClrNames_Click(sender As Object, e As EventArgs) Handles BtClrNames.Click
    'Clear the names

    LstOut.Items.Clear()
    IntCount = 0

  End Sub

  Private Sub BtnAddName_Click(sender As Object, e As EventArgs) Handles BtnAddName.Click
    'Adds name in Formal format
    Dim StrFName As String = TxtFName.Text
    Dim StrLName As String = TxtLName.Text
    Dim StrMI As String = TxtMI.Text
    Dim StrFull As String
    Dim StrTemp As String
    Dim IntPos As Integer

    'Create the Full name using formal formatting
    ' Linn, Arthur J
    StrFull = StrLName & ", " & StrFName & " " & StrMI

    '          1         2         3
    '0123456789012345678901234567890...
    'Linn, Arthur J             'StrFull
    'Arthur J                   'StrTemp

    'Pull out Last Name
    IntPos = StrFull.IndexOf(", ")
    StrLName = StrFull.Substring(0, IntPos)
    StrTemp = StrFull.Substring(IntPos + 2)
    'Pull out First Name from StrTemp
    IntPos = StrTemp.IndexOf(" ")
    StrFName = StrTemp.Substring(0, IntPos)
    StrMI = StrTemp.Substring(IntPos + 1)

    'Display all
    IntCount += 1
    LstOut.Items.Add("Numb : " & IntCount)
    LstOut.Items.Add("Fname: " & StrFName)
    LstOut.Items.Add("Lname: " & StrLName)
    LstOut.Items.Add("MI   : " & StrMI)
    LstOut.Items.Add("Full : " & StrFull)
  End Sub
End Class
