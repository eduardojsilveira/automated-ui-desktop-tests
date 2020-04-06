Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I need calculate two numbers

@Standard
Scenario Outline: Standard Calculator
	Given I have entered <number1> into the calculator	 
	When I press the operator <operator>
	And I have entered <number2> into the calculator
	Then the result <result> should be shown on the screen
Examples: 
| number1 | number2 | operator | result |
| 50      | 70      | +	       | 120    |
| 30      | 20      | -		   | 10     |
| 2       | 25      | *        | 50     |
| 100     | 4       | /        | 25     |

