@highpriority
Feature: Authorization

As a member
I want to be able to login on the site
To have my information filled in automatically when ordering.


Scenario: The user logs in
	Given User on Homepage
	When User click Profile
	And User enter email
	And User submit choice
	And User enter password
	And User click submit button
	Then User is authorized


