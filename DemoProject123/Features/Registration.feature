Feature: Registration
	In order to use the amazon website
	I will need to register
	So that I can enjoy all the amazing offers

@mytag
Scenario: Valid Registration 
	Given I navigate to Amazon website
	When I click on Hello sign in
	And I click on create your amazon account
	And I enter my name
	And I enter my email
	And I enter my password
	And I re enter my password
	And I create your amazon account on the registration page
	Then my account should be created


	
