Feature: manage_account_settings
	As a registered user
	I want to manage my account settings
	So that I can do things like change my password or manage my external logins


Background: A user has been registered
	Given A user is registered and logged in

Scenario: Change your password
	Given I have navigated to the change password form
	And I have filled in the Change Password Form correctly
	When I press Change Password
	Then I see the confirmation message 'Your password has been changed.' on the manage account settings screen

Scenario: Manage External Logins
	When I navigate to the manage logins page
	Then I see my list of external logins
