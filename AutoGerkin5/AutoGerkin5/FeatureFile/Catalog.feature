Feature: Catalog

As a user
I want to have a directory
To find the product I need faster

Background: 
	Given User on HomePage

@highpriority
Scenario: User wants to choose a watch as a gift
	When User clicks on the Accessories category
	And User clicks on the Clock subcategory
	Then User on selected page of subcategory
	When User click on filter 
	And User enter on interested page
	Then User on selected watch page


@highpriority
Scenario: The user wants to buy similar LedLamp to replace the old ones
	When User click on the Electronic and Technic category
	And User click on the TV, Audio and Video subcategory
	Then User on selected subcategory
	When User click filter LedLamps
	And User enter in selected product
	Then User on selected page

