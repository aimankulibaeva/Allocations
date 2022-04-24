Feature: AdventurousTabTests

Scenario Outline: Check Cash Fund Allocations on the Adventurous Tab 
	Given I am logged in
	And I am on the Allocations page
	When I Click Adventurous Tab
	Then I should see Cash Fund Allocation '<percentage>' on the Adventurous Tab

	Examples:
		| percentage |
		| 5          |

Scenario Outline: Check Shares Fund Allocations on the Adventurous Tab 
	Given I am logged in
	And I am on the Allocations page
	When I Click Adventurous Tab
	Then I should see Shares Fund Allocation '<percentage>' on the Adventurous Tab

	Examples:
		| percentage |
		| 60         |

Scenario Outline: Check Property Shares Fund Allocations on the Adventurous Tab
	Given I am logged in
	And I am on the Allocations page
	When I Click Adventurous Tab
	Then I should see Property Shares Fund Allocation '<percentage>' on the Adventurous Tab

	Examples:
		| percentage |
		| 35         |