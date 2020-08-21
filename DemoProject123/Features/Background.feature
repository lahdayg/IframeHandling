Feature: Background
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
Background: 
    Given I navigate to "https://angularjs.realworld.io/#/register"
	When I enter Username text "learnwithpride"
	And I enter email text "david"
	And I enter password text "PasswordSecure"
	And I click on sign up button

 @mytag
    Scenario: Creating New Article
    When I click on New Article
	And I write my Article Title
	And I write what my article is all about
	And I write my Article
	And I enter tags
	And I click on publish Article
    Then my article should be created successfully


 @mytag
    Scenario: Global Feed
    When I click on Global Feed
	Then I should be able to see all global feed
