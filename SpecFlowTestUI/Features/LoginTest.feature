Feature: LoginTest

Scenario: User Try Login
	Given user open login page
	And input user name <userName>
	And input user password <userPassword>
	When click login button
	Then user get message <expectedMessage>
	And user close login page
Examples:
| userName   | userPassword           | expectedMessage                  |
| tomsmith   | SuperSecretPassword!   | You logged into a secure area!   |
| tomsmith   | SecretPassword         | Your password is invalid!        |
| tom        | SecretPassword         | Your username is invalid!        |