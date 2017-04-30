Public Class frmDiceRoller

    'variables to hold the running total of how many times each combination has been rolled
    Private NumberOfRolls As Integer
    Private NumberOfNoMatches As Integer
    Private NumberOfPairs As Integer
    Private NumberOfTwoPairs As Integer
    Private NumberOfThreeOfAKind As Integer
    Private NumberOfFourOfAKind As Integer
    Private NumberOfFiveOfAKind As Integer
    Private NumberOfFullHouses As Integer
    Private NumberOfStraightsOfFour As Integer
    Private NumberOfStraightsOfFive As Integer

    'variables to hold the running percentage of each type of combination
    Private NoMatchesPercentage As Double
    Private PairsPercentage As Double
    Private TwoPairsPercentage As Double
    Private ThreesPercentage As Double
    Private FoursPercentage As Double
    Private FivesPercentage As Double
    Private FullHousePercentage As Double
    Private StraightOfFourPercentage As Double
    Private StraightOfFivePercentage As Double

    'constants that hold the integer representing the types of combinations
    Private Const NoMatch As Integer = 1
    Private Const Pair As Integer = 2
    Private Const ThreeOfAKind As Integer = 3
    Private Const FourOfAKind As Integer = 4
    Private Const FiveOfAKind As Integer = 5
    Private Const StraightOfFive As Integer = 6
    Private Const FullHouse As Integer = 7
    Private Const TwoPair As Integer = 8
    Private Const StraightOfFour As Integer = 9

    'definition of the two colors for the statistics
    Private Const DefaultColor As KnownColor = KnownColor.Black
    Private Const HighlightColor As KnownColor = KnownColor.Red

    'constants that store the names of each dice image in resources
    Private Const Dice1 As String = "dice1"
    Private Const Dice2 As String = "dice2"
    Private Const Dice3 As String = "dice3"
    Private Const Dice4 As String = "dice4"
    Private Const Dice5 As String = "dice5"
    Private Const Dice6 As String = "dice6"

    ''' <summary>
    ''' Code that runs when the roll dice button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRollDice_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        'random number generator
        Dim random As Random = New Random()

        'variable to store the value for the highest achieved combination on any given roll
        'of the dice
        Dim highestMatch As Integer

        'generate random numbers for each of the dice to simulate rolling
        Dim firstDiceValue As Integer = random.Next(1, 7)
        Dim secondDiceValue As Integer = random.Next(1, 7)
        Dim thirdDiceValue As Integer = random.Next(1, 7)
        Dim fourthDiceValue As Integer = random.Next(1, 7)
        Dim fifthDiceValue As Integer = random.Next(1, 7)

        'display the dice roll in the app
        DisplayDiceRoll(firstDiceValue,
                        secondDiceValue,
                        thirdDiceValue,
                        fourthDiceValue,
                        fifthDiceValue)

        'determine the highest value combination achieved for the roll
        highestMatch = GetHighestCombination(firstDiceValue,
                                             secondDiceValue,
                                             thirdDiceValue,
                                             fourthDiceValue,
                                             fifthDiceValue)

        'update the display statistics to determine the frequency that each combination
        'has been rolled.
        UpdateStats(highestMatch)

        'display the updated statistics to the application display
        DisplayStats(highestMatch)

        'show a little message if the rarest of combinations is achieved.
        If highestMatch = FiveOfAKind Then
            MessageBox.Show("FIVE OF A KIND!!",
                            "Five of a Kind!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End If

    End Sub

    ''' <summary>
    ''' A function that analyzes the 
    ''' </summary>
    ''' <param name="firstDiceValue"></param>
    ''' <param name="secondDiceValue"></param>
    ''' <param name="thirdDiceValue"></param>
    ''' <param name="fourthDiceValue"></param>
    ''' <param name="fifthDiceValue"></param>
    ''' <returns>The numerical value for the highest determined combination for a specific dice roll</returns>
    ''' <remarks></remarks>
    Private Function GetHighestCombination(firstDiceValue As Integer,
                                           secondDiceValue As Integer,
                                           thirdDiceValue As Integer,
                                           fourthDiceValue As Integer,
                                           fifthDiceValue As Integer) As Integer

        'local variable to hold highest combination
        Dim highestCombination As Integer

        'variables to keep track of how many of each number was rolled
        Dim numberOf1s As Integer = 0
        Dim numberOf2s As Integer = 0
        Dim numberOf3s As Integer = 0
        Dim numberOf4s As Integer = 0
        Dim numberOf5s As Integer = 0
        Dim numberOf6s As Integer = 0

        'determine what number dice 1 rolled to add it to totals
        Select Case firstDiceValue
            Case 1
                numberOf1s += 1
            Case 2
                numberOf2s += 1
            Case 3
                numberOf3s += 1
            Case 4
                numberOf4s += 1
            Case 5
                numberOf5s += 1
            Case 6
                numberOf6s += 1
        End Select

        'determine what number dice 2 rolled to add it to totals
        Select Case secondDiceValue
            Case 1
                numberOf1s += 1
            Case 2
                numberOf2s += 1
            Case 3
                numberOf3s += 1
            Case 4
                numberOf4s += 1
            Case 5
                numberOf5s += 1
            Case 6
                numberOf6s += 1
        End Select

        'determine what number dice 3 rolled to add it to totals
        Select Case thirdDiceValue
            Case 1
                numberOf1s += 1
            Case 2
                numberOf2s += 1
            Case 3
                numberOf3s += 1
            Case 4
                numberOf4s += 1
            Case 5
                numberOf5s += 1
            Case 6
                numberOf6s += 1
        End Select

        'determine what number dice 4 rolled to add it to totals
        Select Case fourthDiceValue
            Case 1
                numberOf1s += 1
            Case 2
                numberOf2s += 1
            Case 3
                numberOf3s += 1
            Case 4
                numberOf4s += 1
            Case 5
                numberOf5s += 1
            Case 6
                numberOf6s += 1
        End Select

        'determine what number dice 5 rolled to add it to totals
        Select Case fifthDiceValue
            Case 1
                numberOf1s += 1
            Case 2
                numberOf2s += 1
            Case 3
                numberOf3s += 1
            Case 4
                numberOf4s += 1
            Case 5
                numberOf5s += 1
            Case 6
                numberOf6s += 1
        End Select

        'check what combonation the user got in order from most to least value
        'so as soon as one is true it is the highest

        If (numberOf1s = 2 Or numberOf2s = 2 Or numberOf3s = 2 Or numberOf4s = 2 Or numberOf5s = 2 Or numberOf6s = 2) _
            And (numberOf1s = 3 Or numberOf2s = 3 Or numberOf3s = 3 Or numberOf4s = 3 Or numberOf5s = 3 Or numberOf6s = 3) Then

            highestCombination = FullHouse

        ElseIf (numberOf1s >= 1 And numberOf2s >= 1 And numberOf3s >= 1 And numberOf4s >= 1 And numberOf5s >= 1) _
            Or (numberOf2s >= 1 And numberOf3s >= 1 And numberOf4s >= 1 And numberOf5s >= 1 And numberOf6s >= 1) Then

            highestCombination = StraightOfFive

        ElseIf (numberOf1s >= 1 And numberOf2s >= 1 And numberOf3s >= 1 And numberOf4s >= 1) _
            Or (numberOf2s >= 1 And numberOf3s >= 1 And numberOf4s >= 1 And numberOf5s >= 1) _
            Or (numberOf3s >= 1 And numberOf4s >= 1 And numberOf5s >= 1 And numberOf6s >= 1) Then

            highestCombination = StraightOfFour

        ElseIf (numberOf1s = 5 Or numberOf2s = 5 Or numberOf3s = 5 Or numberOf4s = 5 Or numberOf5s = 5 Or numberOf6s = 5) Then

            highestCombination = FiveOfAKind

        ElseIf (numberOf1s = 4 Or numberOf2s = 4 Or numberOf3s = 4 Or numberOf4s = 4 Or numberOf5s = 4 Or numberOf6s = 4) Then

            highestCombination = FourOfAKind

        ElseIf (numberOf1s = 3 Or numberOf2s = 3 Or numberOf3s = 3 Or numberOf4s = 3 Or numberOf5s = 3 Or numberOf6s = 3) Then

            highestCombination = ThreeOfAKind

        ElseIf (numberOf1s = 2 Or numberOf2s = 2 Or numberOf3s = 2 Or numberOf4s = 2 Or numberOf5s = 2 Or numberOf6s = 2) Then

            'The two pairs combo requires extra work to not get it mixed up with a single pair.
            'two Pair and single Pair are together in this if block

            'keep track of the amount of pairs
            Dim pairCounter As Integer = 0

            'add one to pairCounter for each pair of a different number
            If numberOf1s = 2 Then
                pairCounter += 1
            End If
            If numberOf2s = 2 Then
                pairCounter += 1
            End If
            If numberOf3s = 2 Then
                pairCounter += 1
            End If
            If numberOf4s = 2 Then
                pairCounter += 1
            End If
            If numberOf5s = 2 Then
                pairCounter += 1
            End If
            If numberOf6s = 2 Then
                pairCounter += 1
            End If

            If pairCounter = 2 Then
                highestCombination = TwoPair
            Else
                highestCombination = Pair
            End If

        Else

            highestCombination = NoMatch

        End If

        'returns the determined combination (integer) to the code that called this function
        Return highestCombination

    End Function

    ''' <summary>
    ''' Code that runs when the Reset Button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'make the dice images go away
        Dice1Display.Image = Nothing
        Dice2Display.Image = Nothing
        Dice3Display.Image = Nothing
        Dice4Display.Image = Nothing
        Dice5Display.Image = Nothing

        'reset the global/class level variables that hold the running totals back to zero
        NumberOfRolls = 0
        NumberOfNoMatches = 0
        NumberOfPairs = 0
        NumberOfTwoPairs = 0
        NumberOfThreeOfAKind = 0
        NumberOfFourOfAKind = 0
        NumberOfFiveOfAKind = 0
        NumberOfFullHouses = 0
        NumberOfStraightsOfFour = 0
        NumberOfStraightsOfFive = 0

        'reset the global/class level variables that hold the running percentage totals back to zero
        NoMatchesPercentage = 0
        PairsPercentage = 0
        TwoPairsPercentage = 0
        ThreesPercentage = 0
        FoursPercentage = 0
        FivesPercentage = 0
        FullHousePercentage = 0
        StraightOfFourPercentage = 0
        StraightOfFivePercentage = 0

        'display the new stats to the form
        DisplayStats(0)

    End Sub

    ''' <summary>
    ''' Code that displays the dice images that represent the numbers generated after
    ''' each dice roll.
    ''' </summary>
    ''' <param name="firstDiceValue"></param>
    ''' <param name="secondDiceValue"></param>
    ''' <param name="thirdDiceValue"></param>
    ''' <param name="fourthDiceValue"></param>
    ''' <param name="fifthDiceValue"></param>
    ''' <remarks></remarks>
    Private Sub DisplayDiceRoll(firstDiceValue As Integer,
                                secondDiceValue As Integer,
                                thirdDiceValue As Integer,
                                fourthDiceValue As Integer,
                                fifthDiceValue As Integer)

        Dim resourceName As String = String.Empty

        'Select Image for Dice 1
        Select Case firstDiceValue
            Case 1
                resourceName = Dice1
            Case 2
                resourceName = Dice2
            Case 3
                resourceName = Dice3
            Case 4
                resourceName = Dice4
            Case 5
                resourceName = Dice5
            Case 6
                resourceName = Dice6
        End Select
        Dice1Display.Image = CType(My.Resources.ResourceManager.GetObject(resourceName), Image)

        'Select image for Dice 2
        Select Case secondDiceValue
            Case 1
                resourceName = Dice1
            Case 2
                resourceName = Dice2
            Case 3
                resourceName = Dice3
            Case 4
                resourceName = Dice4
            Case 5
                resourceName = Dice5
            Case 6
                resourceName = Dice6
        End Select
        Dice2Display.Image = CType(My.Resources.ResourceManager.GetObject(resourceName), Image)

        'Select image for Dice 3
        Select Case thirdDiceValue
            Case 1
                resourceName = Dice1
            Case 2
                resourceName = Dice2
            Case 3
                resourceName = Dice3
            Case 4
                resourceName = Dice4
            Case 5
                resourceName = Dice5
            Case 6
                resourceName = Dice6
        End Select
        Dice3Display.Image = CType(My.Resources.ResourceManager.GetObject(resourceName), Image)

        'Select image for Dice 4
        Select Case fourthDiceValue
            Case 1
                resourceName = Dice1
            Case 2
                resourceName = Dice2
            Case 3
                resourceName = Dice3
            Case 4
                resourceName = Dice4
            Case 5
                resourceName = Dice5
            Case 6
                resourceName = Dice6
        End Select
        Dice4Display.Image = CType(My.Resources.ResourceManager.GetObject(resourceName), Image)

        'Select image for Dice 5
        Select Case fifthDiceValue
            Case 1
                resourceName = Dice1
            Case 2
                resourceName = Dice2
            Case 3
                resourceName = Dice3
            Case 4
                resourceName = Dice4
            Case 5
                resourceName = Dice5
            Case 6
                resourceName = Dice6
        End Select
        Dice5Display.Image = CType(My.Resources.ResourceManager.GetObject(resourceName), Image)

    End Sub

    ''' <summary>
    ''' Calculate the current statistics and update class level variables
    ''' </summary>
    ''' <param name="highestMatch"></param>
    ''' <remarks></remarks>
    Private Sub UpdateStats(highestMatch As Integer)

        numberOfRolls += 1

        'increase the appropriate combination by 1
        Select Case highestMatch
            Case NoMatch
                NumberOfNoMatches += 1
            Case Pair
                NumberOfPairs += 1
            Case TwoPair
                NumberOfTwoPairs += 1
            Case ThreeOfAKind
                NumberOfThreeOfAKind += 1
            Case FourOfAKind
                NumberOfFourOfAKind += 1
            Case FiveOfAKind
                NumberOfFiveOfAKind += 1
            Case StraightOfFive
                NumberOfStraightsOfFive += 1
            Case StraightOfFour
                NumberOfStraightsOfFour += 1
            Case FullHouse
                NumberOfFullHouses += 1
        End Select

        'calculate percentages and update global variables that hold
        'running total of percentages
        NoMatchesPercentage = NumberOfNoMatches / NumberOfRolls
        PairsPercentage = NumberOfPairs / NumberOfRolls
        TwoPairsPercentage = NumberOfTwoPairs / NumberOfRolls
        ThreesPercentage = NumberOfThreeOfAKind / NumberOfRolls
        FoursPercentage = NumberOfFourOfAKind / NumberOfRolls
        FivesPercentage = NumberOfFiveOfAKind / NumberOfRolls
        FullHousePercentage = NumberOfFullHouses / NumberOfRolls
        StraightOfFourPercentage = NumberOfStraightsOfFour / NumberOfRolls
        StraightOfFivePercentage = NumberOfStraightsOfFive / NumberOfRolls


    End Sub

    ''' <summary>
    ''' Display Stats to the UI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayStats(highestMatch As Integer)

        lblTotalRolls.Text = NumberOfRolls.ToString
        lblTotalNoMatches.Text = NumberOfNoMatches.ToString
        lblTotalPairs.Text = NumberOfPairs.ToString
        lblTotalTwoPairs.Text = NumberOfTwoPairs.ToString
        lblTotalThreeOfAKind.Text = NumberOfThreeOfAKind.ToString
        lblTotalFourOfAKind.Text = NumberOfFourOfAKind.ToString
        lblTotalFiveOfAKind.Text = NumberOfFiveOfAKind.ToString
        lblTotalFullHouse.Text = NumberOfFullHouses.ToString
        lblTotalStraightsOfFour.Text = NumberOfStraightsOfFour.ToString
        lblTotalStraightsOfFive.Text = NumberOfStraightsOfFive.ToString

        lblNoMatchPercentage.Text = NoMatchesPercentage.ToString("P")
        lblPairPercentage.Text = PairsPercentage.ToString("P")
        lblTwoPairPercentage.Text = TwoPairsPercentage.ToString("P")
        lblThreesPercentage.Text = ThreesPercentage.ToString("P")
        lblFoursPercentage.Text = FoursPercentage.ToString("P")
        lblFivesPercentage.Text = FivesPercentage.ToString("P")
        lblFullHousePercentage.Text = FullHousePercentage.ToString("P")
        lblStraightOfFourPercentage.Text = StraightOfFourPercentage.ToString("P")
        lblStraightOfFivePercentage.Text = StraightOfFivePercentage.ToString("P")

        lblTotalNoMatches.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalPairs.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalTwoPairs.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalThreeOfAKind.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalFourOfAKind.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalFiveOfAKind.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalFullHouse.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalStraightsOfFour.ForeColor = Color.FromKnownColor(DefaultColor)
        lblTotalStraightsOfFive.ForeColor = Color.FromKnownColor(DefaultColor)

        Select Case highestMatch
            Case NoMatch
                lblTotalNoMatches.ForeColor = Color.FromKnownColor(HighlightColor)
            Case Pair
                lblTotalPairs.ForeColor = Color.FromKnownColor(HighlightColor)
            Case TwoPair
                lblTotalTwoPairs.ForeColor = Color.FromKnownColor(HighlightColor)
            Case ThreeOfAKind
                lblTotalThreeOfAKind.ForeColor = Color.FromKnownColor(HighlightColor)
            Case FourOfAKind
                lblTotalFourOfAKind.ForeColor = Color.FromKnownColor(HighlightColor)
            Case FiveOfAKind
                lblTotalFiveOfAKind.ForeColor = Color.FromKnownColor(HighlightColor)
            Case FullHouse
                lblTotalFullHouse.ForeColor = Color.FromKnownColor(HighlightColor)
            Case StraightOfFour
                lblTotalStraightsOfFour.ForeColor = Color.FromKnownColor(HighlightColor)
            Case StraightOfFive
                lblTotalStraightsOfFive.ForeColor = Color.FromKnownColor(HighlightColor)
        End Select

    End Sub

    Private Sub frmDiceRoller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Show()
    End Sub
End Class
