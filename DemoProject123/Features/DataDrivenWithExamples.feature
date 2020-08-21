Feature: DataDrivenWithExamples
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Examples
	Given I navigate to "https://angularjs.realworld.io/#/register"
	When the User enter Username text "<Username>"
	And the user enter email text "<Email>"
	And the user enter password text "<Password>"
	#And I click on sign up button
	#Then I am logged in with my username displayed

	Examples:

	| Username | Email | Password        |
	| Demo3    | Demo  | PasswordSecure  |
	| Demo2    | Demo  | PasswordSecure2 |


	

	