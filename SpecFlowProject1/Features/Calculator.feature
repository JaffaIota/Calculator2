﻿Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
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