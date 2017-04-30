<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceRoller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTwoPairPercentage = New System.Windows.Forms.Label()
        Me.lblTotalTwoPairs = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblStraightOfFourPercentage = New System.Windows.Forms.Label()
        Me.lblTotalStraightsOfFour = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStraightOfFivePercentage = New System.Windows.Forms.Label()
        Me.lblTotalStraightsOfFive = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFullHousePercentage = New System.Windows.Forms.Label()
        Me.lblTotalFullHouse = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblThreesPercentage = New System.Windows.Forms.Label()
        Me.lblFivesPercentage = New System.Windows.Forms.Label()
        Me.lblFoursPercentage = New System.Windows.Forms.Label()
        Me.lblPairPercentage = New System.Windows.Forms.Label()
        Me.lblNoMatchPercentage = New System.Windows.Forms.Label()
        Me.lblTotalFiveOfAKind = New System.Windows.Forms.Label()
        Me.lblTotalFourOfAKind = New System.Windows.Forms.Label()
        Me.lblTotalThreeOfAKind = New System.Windows.Forms.Label()
        Me.lblTotalPairs = New System.Windows.Forms.Label()
        Me.lblTotalNoMatches = New System.Windows.Forms.Label()
        Me.lblTotalRolls = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Dice5Display = New System.Windows.Forms.PictureBox()
        Me.Dice4Display = New System.Windows.Forms.PictureBox()
        Me.Dice3Display = New System.Windows.Forms.PictureBox()
        Me.Dice2Display = New System.Windows.Forms.PictureBox()
        Me.Dice1Display = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Dice5Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice4Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice3Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice1Display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRollDice
        '
        Me.btnRollDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollDice.Location = New System.Drawing.Point(12, 132)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(141, 118)
        Me.btnRollDice.TabIndex = 5
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "No Match:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pair:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Three of a kind:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(218, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Five of a kind:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Four of a kind:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTwoPairPercentage)
        Me.Panel1.Controls.Add(Me.lblTotalTwoPairs)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblStraightOfFourPercentage)
        Me.Panel1.Controls.Add(Me.lblTotalStraightsOfFour)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblStraightOfFivePercentage)
        Me.Panel1.Controls.Add(Me.lblTotalStraightsOfFive)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblFullHousePercentage)
        Me.Panel1.Controls.Add(Me.lblTotalFullHouse)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblThreesPercentage)
        Me.Panel1.Controls.Add(Me.lblFivesPercentage)
        Me.Panel1.Controls.Add(Me.lblFoursPercentage)
        Me.Panel1.Controls.Add(Me.lblPairPercentage)
        Me.Panel1.Controls.Add(Me.lblNoMatchPercentage)
        Me.Panel1.Controls.Add(Me.lblTotalFiveOfAKind)
        Me.Panel1.Controls.Add(Me.lblTotalFourOfAKind)
        Me.Panel1.Controls.Add(Me.lblTotalThreeOfAKind)
        Me.Panel1.Controls.Add(Me.lblTotalPairs)
        Me.Panel1.Controls.Add(Me.lblTotalNoMatches)
        Me.Panel1.Controls.Add(Me.lblTotalRolls)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(160, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 198)
        Me.Panel1.TabIndex = 12
        '
        'lblTwoPairPercentage
        '
        Me.lblTwoPairPercentage.AutoSize = True
        Me.lblTwoPairPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwoPairPercentage.Location = New System.Drawing.Point(160, 129)
        Me.lblTwoPairPercentage.Name = "lblTwoPairPercentage"
        Me.lblTwoPairPercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblTwoPairPercentage.TabIndex = 35
        Me.lblTwoPairPercentage.Text = "0.00%"
        '
        'lblTotalTwoPairs
        '
        Me.lblTotalTwoPairs.AutoSize = True
        Me.lblTotalTwoPairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTwoPairs.Location = New System.Drawing.Point(105, 123)
        Me.lblTotalTwoPairs.Name = "lblTotalTwoPairs"
        Me.lblTotalTwoPairs.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalTwoPairs.TabIndex = 34
        Me.lblTotalTwoPairs.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Two Pair:"
        '
        'lblStraightOfFourPercentage
        '
        Me.lblStraightOfFourPercentage.AutoSize = True
        Me.lblStraightOfFourPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraightOfFourPercentage.Location = New System.Drawing.Point(354, 56)
        Me.lblStraightOfFourPercentage.Name = "lblStraightOfFourPercentage"
        Me.lblStraightOfFourPercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblStraightOfFourPercentage.TabIndex = 32
        Me.lblStraightOfFourPercentage.Text = "0.00%"
        '
        'lblTotalStraightsOfFour
        '
        Me.lblTotalStraightsOfFour.AutoSize = True
        Me.lblTotalStraightsOfFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStraightsOfFour.Location = New System.Drawing.Point(306, 50)
        Me.lblTotalStraightsOfFour.Name = "lblTotalStraightsOfFour"
        Me.lblTotalStraightsOfFour.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalStraightsOfFour.TabIndex = 31
        Me.lblTotalStraightsOfFour.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(209, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Straight of Four:"
        '
        'lblStraightOfFivePercentage
        '
        Me.lblStraightOfFivePercentage.AutoSize = True
        Me.lblStraightOfFivePercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraightOfFivePercentage.Location = New System.Drawing.Point(354, 93)
        Me.lblStraightOfFivePercentage.Name = "lblStraightOfFivePercentage"
        Me.lblStraightOfFivePercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblStraightOfFivePercentage.TabIndex = 29
        Me.lblStraightOfFivePercentage.Text = "0.00%"
        '
        'lblTotalStraightsOfFive
        '
        Me.lblTotalStraightsOfFive.AutoSize = True
        Me.lblTotalStraightsOfFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStraightsOfFive.Location = New System.Drawing.Point(306, 87)
        Me.lblTotalStraightsOfFive.Name = "lblTotalStraightsOfFive"
        Me.lblTotalStraightsOfFive.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalStraightsOfFive.TabIndex = 28
        Me.lblTotalStraightsOfFive.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(209, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Straight of Five:"
        '
        'lblFullHousePercentage
        '
        Me.lblFullHousePercentage.AutoSize = True
        Me.lblFullHousePercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullHousePercentage.Location = New System.Drawing.Point(354, 20)
        Me.lblFullHousePercentage.Name = "lblFullHousePercentage"
        Me.lblFullHousePercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblFullHousePercentage.TabIndex = 26
        Me.lblFullHousePercentage.Text = "0.00%"
        '
        'lblTotalFullHouse
        '
        Me.lblTotalFullHouse.AutoSize = True
        Me.lblTotalFullHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFullHouse.Location = New System.Drawing.Point(306, 14)
        Me.lblTotalFullHouse.Name = "lblTotalFullHouse"
        Me.lblTotalFullHouse.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalFullHouse.TabIndex = 25
        Me.lblTotalFullHouse.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(233, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Full House:"
        '
        'lblThreesPercentage
        '
        Me.lblThreesPercentage.AutoSize = True
        Me.lblThreesPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreesPercentage.Location = New System.Drawing.Point(160, 167)
        Me.lblThreesPercentage.Name = "lblThreesPercentage"
        Me.lblThreesPercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblThreesPercentage.TabIndex = 23
        Me.lblThreesPercentage.Text = "0.00%"
        '
        'lblFivesPercentage
        '
        Me.lblFivesPercentage.AutoSize = True
        Me.lblFivesPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFivesPercentage.Location = New System.Drawing.Point(354, 166)
        Me.lblFivesPercentage.Name = "lblFivesPercentage"
        Me.lblFivesPercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblFivesPercentage.TabIndex = 22
        Me.lblFivesPercentage.Text = "0.00%"
        '
        'lblFoursPercentage
        '
        Me.lblFoursPercentage.AutoSize = True
        Me.lblFoursPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoursPercentage.Location = New System.Drawing.Point(354, 129)
        Me.lblFoursPercentage.Name = "lblFoursPercentage"
        Me.lblFoursPercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblFoursPercentage.TabIndex = 21
        Me.lblFoursPercentage.Text = "0.00%"
        '
        'lblPairPercentage
        '
        Me.lblPairPercentage.AutoSize = True
        Me.lblPairPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPairPercentage.Location = New System.Drawing.Point(160, 92)
        Me.lblPairPercentage.Name = "lblPairPercentage"
        Me.lblPairPercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblPairPercentage.TabIndex = 20
        Me.lblPairPercentage.Text = "0.00%"
        '
        'lblNoMatchPercentage
        '
        Me.lblNoMatchPercentage.AutoSize = True
        Me.lblNoMatchPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoMatchPercentage.Location = New System.Drawing.Point(160, 56)
        Me.lblNoMatchPercentage.Name = "lblNoMatchPercentage"
        Me.lblNoMatchPercentage.Size = New System.Drawing.Size(31, 12)
        Me.lblNoMatchPercentage.TabIndex = 19
        Me.lblNoMatchPercentage.Text = "0.00%"
        '
        'lblTotalFiveOfAKind
        '
        Me.lblTotalFiveOfAKind.AutoSize = True
        Me.lblTotalFiveOfAKind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFiveOfAKind.Location = New System.Drawing.Point(306, 160)
        Me.lblTotalFiveOfAKind.Name = "lblTotalFiveOfAKind"
        Me.lblTotalFiveOfAKind.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalFiveOfAKind.TabIndex = 18
        Me.lblTotalFiveOfAKind.Text = "0"
        '
        'lblTotalFourOfAKind
        '
        Me.lblTotalFourOfAKind.AutoSize = True
        Me.lblTotalFourOfAKind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFourOfAKind.Location = New System.Drawing.Point(306, 123)
        Me.lblTotalFourOfAKind.Name = "lblTotalFourOfAKind"
        Me.lblTotalFourOfAKind.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalFourOfAKind.TabIndex = 17
        Me.lblTotalFourOfAKind.Text = "0"
        '
        'lblTotalThreeOfAKind
        '
        Me.lblTotalThreeOfAKind.AutoSize = True
        Me.lblTotalThreeOfAKind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalThreeOfAKind.Location = New System.Drawing.Point(105, 158)
        Me.lblTotalThreeOfAKind.Name = "lblTotalThreeOfAKind"
        Me.lblTotalThreeOfAKind.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalThreeOfAKind.TabIndex = 16
        Me.lblTotalThreeOfAKind.Text = "0"
        '
        'lblTotalPairs
        '
        Me.lblTotalPairs.AutoSize = True
        Me.lblTotalPairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPairs.Location = New System.Drawing.Point(105, 86)
        Me.lblTotalPairs.Name = "lblTotalPairs"
        Me.lblTotalPairs.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalPairs.TabIndex = 15
        Me.lblTotalPairs.Text = "0"
        '
        'lblTotalNoMatches
        '
        Me.lblTotalNoMatches.AutoSize = True
        Me.lblTotalNoMatches.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNoMatches.Location = New System.Drawing.Point(105, 50)
        Me.lblTotalNoMatches.Name = "lblTotalNoMatches"
        Me.lblTotalNoMatches.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalNoMatches.TabIndex = 14
        Me.lblTotalNoMatches.Text = "0"
        '
        'lblTotalRolls
        '
        Me.lblTotalRolls.AutoSize = True
        Me.lblTotalRolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRolls.Location = New System.Drawing.Point(105, 13)
        Me.lblTotalRolls.Name = "lblTotalRolls"
        Me.lblTotalRolls.Size = New System.Drawing.Size(21, 24)
        Me.lblTotalRolls.TabIndex = 13
        Me.lblTotalRolls.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Rolls:"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(12, 256)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(141, 74)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Dice5Display
        '
        Me.Dice5Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dice5Display.Location = New System.Drawing.Point(451, 13)
        Me.Dice5Display.Name = "Dice5Display"
        Me.Dice5Display.Size = New System.Drawing.Size(103, 103)
        Me.Dice5Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice5Display.TabIndex = 4
        Me.Dice5Display.TabStop = False
        '
        'Dice4Display
        '
        Me.Dice4Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dice4Display.Location = New System.Drawing.Point(342, 13)
        Me.Dice4Display.Name = "Dice4Display"
        Me.Dice4Display.Size = New System.Drawing.Size(103, 103)
        Me.Dice4Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice4Display.TabIndex = 3
        Me.Dice4Display.TabStop = False
        '
        'Dice3Display
        '
        Me.Dice3Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dice3Display.Location = New System.Drawing.Point(233, 13)
        Me.Dice3Display.Name = "Dice3Display"
        Me.Dice3Display.Size = New System.Drawing.Size(103, 103)
        Me.Dice3Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice3Display.TabIndex = 2
        Me.Dice3Display.TabStop = False
        '
        'Dice2Display
        '
        Me.Dice2Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dice2Display.Location = New System.Drawing.Point(124, 13)
        Me.Dice2Display.Name = "Dice2Display"
        Me.Dice2Display.Size = New System.Drawing.Size(103, 103)
        Me.Dice2Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2Display.TabIndex = 1
        Me.Dice2Display.TabStop = False
        '
        'Dice1Display
        '
        Me.Dice1Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dice1Display.Location = New System.Drawing.Point(13, 13)
        Me.Dice1Display.Name = "Dice1Display"
        Me.Dice1Display.Size = New System.Drawing.Size(103, 103)
        Me.Dice1Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice1Display.TabIndex = 0
        Me.Dice1Display.TabStop = False
        '
        'frmDiceRoller
        '
        Me.AcceptButton = Me.btnRollDice
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 343)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.Dice5Display)
        Me.Controls.Add(Me.Dice4Display)
        Me.Controls.Add(Me.Dice3Display)
        Me.Controls.Add(Me.Dice2Display)
        Me.Controls.Add(Me.Dice1Display)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDiceRoller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dice Roller"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dice5Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice4Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice3Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice1Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dice1Display As System.Windows.Forms.PictureBox
    Friend WithEvents Dice2Display As System.Windows.Forms.PictureBox
    Friend WithEvents Dice3Display As System.Windows.Forms.PictureBox
    Friend WithEvents Dice4Display As System.Windows.Forms.PictureBox
    Friend WithEvents Dice5Display As System.Windows.Forms.PictureBox
    Friend WithEvents btnRollDice As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblTotalFiveOfAKind As System.Windows.Forms.Label
    Friend WithEvents lblTotalFourOfAKind As System.Windows.Forms.Label
    Friend WithEvents lblTotalThreeOfAKind As System.Windows.Forms.Label
    Friend WithEvents lblTotalPairs As System.Windows.Forms.Label
    Friend WithEvents lblTotalNoMatches As System.Windows.Forms.Label
    Friend WithEvents lblTotalRolls As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblThreesPercentage As System.Windows.Forms.Label
    Friend WithEvents lblFivesPercentage As System.Windows.Forms.Label
    Friend WithEvents lblFoursPercentage As System.Windows.Forms.Label
    Friend WithEvents lblPairPercentage As System.Windows.Forms.Label
    Friend WithEvents lblNoMatchPercentage As System.Windows.Forms.Label
    Friend WithEvents lblFullHousePercentage As System.Windows.Forms.Label
    Friend WithEvents lblTotalFullHouse As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblStraightOfFivePercentage As System.Windows.Forms.Label
    Friend WithEvents lblTotalStraightsOfFive As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTwoPairPercentage As System.Windows.Forms.Label
    Friend WithEvents lblTotalTwoPairs As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblStraightOfFourPercentage As System.Windows.Forms.Label
    Friend WithEvents lblTotalStraightsOfFour As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
