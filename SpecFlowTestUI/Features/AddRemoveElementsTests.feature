Feature: AddRemoveElementsTests
    User able add and remove elements on page

Scenario: Add Elements On Page
	Given user open Add Remove page
	When user add '5' elements on page
	Then '5' elements on page
	And user close Add Remove page
	
Scenario: Delete Elements On Page
	Given user open Add Remove page
	When user add '<addElementsAmount>' elements on page
	Then '<addElementsAmount>' elements on page
	When user delete '<deleteElementsAmount>' elements on page
	Then '<resultsElementsAmount>' elements on page	
	And user close Add Remove page
Examples:
| addElementsAmount | deleteElementsAmount | resultsElementsAmount |
| 3                 | 3                    | 0                     |
| 3                 | 2                    | 1                     |
| 10                | 6                    | 4                     |