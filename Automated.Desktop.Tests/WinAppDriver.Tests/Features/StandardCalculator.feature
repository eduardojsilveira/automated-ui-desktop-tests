@Standard
Feature: Standard Calculator
	In order to avoid silly mistakes
	As a math idiot
	I need calculate two numbers

@Standard
Scenario Outline: Standard Operations
	Given I have entered <number1> into the calculator	 
	When I press the operator <operator>
	And I have entered <number2> into the calculator
	Then the result <result> should be shown on the screen
Examples: 
| number1 | number2 | operator | result |
| 330     | 70      | +        | 400    |
| 100     | 70      | -        | 30     |
| 150     | 10      | *        | 1.500  |
| 440     | 10      | /        | 44     |
| 1.1     | 2.2     | +        | 3,3    |
| 0.91    | 0.89    | -        | 0,02   |
| 0.5     | 2       | *        | 1      |
| 3       | 2       | /        | 1,5    |


@Standard
Scenario Outline: Square Root Function
	Given I have entered <number1> into the calculator
	When I press the square function
	Then the result <result> should be shown on the screen
Examples: 
| number1 | result        |
| 81      | 9             |
| 100     | 10            |
| 289     | 17            |
| -2      | Invalid input | 

@Standard 
Scenario Outline: X Squared Function
	Given I have entered <number1> into the calculator
	When I press the x squared function 
	Then the result <result> should be shown on the screen 
Examples: 
| number1 | result |
| 10      | 100    |
| -3      | 9      |
| 0.5     | 0,25   |
| -0.7    | 0,49   | 