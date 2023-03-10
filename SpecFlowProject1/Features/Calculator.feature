Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@AssignmentOneOfCalculator
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Add two other numbers
	Given the first number is 50
	And the second number is 60
	When the two numbers are added
	Then the result should be 110

Scenario: Subtract a small number from a bigger number
	Given the first number is 100
	And the second number is 75
	When the two numbers are subtracted
	Then the result should be 25

Scenario: Subtract a bigger number from a smaller number
	Given the first number is 10
	And the second number is 75
	When the two numbers are subtracted
	Then the result should be -65

Scenario: Multiply two positive numbers
	Given the first number is 100
	And the second number is 75
	When the two numbers are multiplied
	Then the result should be 7500

Scenario: Multiply pos and neg numbers
    Given the first number is 100
    And the second number is -75
    When the two numbers are multiplied
    Then the result should be -7500

Scenario: Divide 100 by 4
  Given the first number is 100
  And the second number is 4
  When the two numbers are divided
  Then the result should be 25

@AssignmentTwoOfCalculator
#[Next step] (Division by zero, multiply out of range of int, Floating point(Multi/Div)) 

Scenario: Add two massive numbers
	Given the first number is 2147483647
	And the second number is 1
	When the two numbers are added
	Then it will throw an exception

Scenario: Divide by 0 double
  Given the first real number is 100
  And the second real number is 0
  When the two real numbers are divided
  Then it will throw an exception

Scenario: Multiply two massive numbers
	Given the first number is 1000000000
	And the second number is 3
	When the two numbers are multiplied
	Then it will throw an exception

Scenario: Multiply two decimals
	Given the first real number is 6.5
	And the second real number is 3.2
	When the two real numbers are multiplied
	Then the real result should be close to 20.8

Scenario: Divide by 0 int
  Given the first number is 100
  And the second number is 0
  When the two numbers are divided
  Then it will throw an exception