@Scientific
Feature: Scientific Calculator
	In order to avoid silly mistakes
	As a math idiot
	I need calculate two numbers

@Scientific
Scenario Outline: X Cube Function
	Given I have entered <number1> into the calculator
	When I press the x cubed function 
	Then the result <result> should be shown on the screen 
Examples: 
| number1 | result |
| 7       |   343  |
| -3      | -27    |
| 0.5     | 0,125  |
| -0.7    | -0,343 | 

@Scientific 
Scenario Outline: Factorial Function 
Given I have entered <number1> into the calculator
When I press the factorial function 
Then the result <result> should be shown on the screen
Examples: 
| number1 | result        |
| 0       | 1             |
| 1       | 1             |
| 2       | 2             |
| 5       | 120           |
| -1      | Invalid input |

