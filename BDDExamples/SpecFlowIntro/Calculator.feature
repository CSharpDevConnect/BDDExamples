Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


#Scenario: Add three numbers
#	Given I have entered 50 into the calculator
#	And I have also entered 70 into the calculator
#	And I have entered 30 into the calculator
#	When I press add
#	Then the result should be 150 on the screen

Scenario Outline: Adding two numbers
	Given I have entered <number1> into the calculator
	And I have also entered <number2> into the calculator
	When I press add
	Then the result should be <expectedResult> on the screen

	Examples: 
	| number1 | number2 | expectedResult |
	| 0       | 0       | 0              |
	| 1       | 1       | 2              |
	| 5       | 5       | 10             |
	| 1234    | 4321    | 5555           |