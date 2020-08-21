Feature: DataDrivenWithParameters
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameters
	Given I navigate to "https://angularjs.realworld.io/#/register"
	When I enter Username text "learnwithpride"
	And I enter email text "david"
	And I enter password text "PasswordSecure"
	And I click on sign up button
	#Then I am logged in with my username displayed





