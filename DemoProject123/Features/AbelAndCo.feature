Feature: AbelAndCo
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I navigate to "https://www.abelandcole.co.uk/"
	And I click on Accept cookies
	When I enter my search item in the search "Brownie"
	And I click on Search
	And I click on Add for Brownie Tray
	#Then the result should be 120 on the screen
