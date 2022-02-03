Feature: Search 
 
As a User 
I want to be able to filter items by brand 
In order to buy products of my favorite brand 
 
As a User 
I want to find products using filters
In order to find the right product with a different requirments

As a User 
I want to have different product categories 
In order to search products in choosen category
  
Background:
	Given User on homepage


@highpriority
Scenario: User looking to actual discount
	When User click on category Обувь in navigation menu
	Then User on page Обувь
	When User click Актуальное in menu of filters
	Then User on the page of the discounts


@highpriority
Scenario: User looking a Nike products
	When User click on Search field
	And User enter 'Nike'
	Then User on the page Nike


@highpriority
Scenario: User looking a Lacoste products
	When User click on Search field
	And User enter 'Lacoste'
	Then User on the page Lacoste


@highpriority
Scenario: User looking a Tommy Hilfiger products
	When User click on Search field
	And User enter 'Tommy Hilfiger'
	Then User on the page Tommy Hilfiger


@highpriority
Scenario: User looking a Reserved products
	When User click on Search field
	And User enter 'Reserved'
	Then User on the page Reserved
