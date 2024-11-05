Feature: DragAndDropTest

Scenario: Drag And Drop Element On Page
	Given user open Drag And Drop page
	Then first element name is 'A'
	When user drag first element
	Then first element name is 'B'
	When user drag first element
	Then first element name is 'A'
	And user close Drag And Drop page