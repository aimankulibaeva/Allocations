Feature: BalancedTabTests

Scenario Outline: Check Cash Fund Allocation on the Balanced Tab
	Given I am logged in
	And I am on the Allocations page
	When I Click Balanced Tab
	Then I should see Cash Fund Allocation '<percentage>' on the Balanced Tab

	Examples:
		| percentage |
		| 30         |

Scenario Outline: Check Shares Fund Allocation on the Balanced Tab
	Given I am logged in
	And I am on the Allocations page
	When I Click Balanced Tab
	Then I should see Shares Fund Allocation '<percentage>' on the Balanced Tab

	Examples:
		| percentage |
		| 45         |

Scenario Outline: Check Property Shares Fund Allocation on the Balanced Tab
	Given I am logged in
	And I am on the Allocations page
	When I Click Balanced Tab
	Then I should see Property Shares Fund Allocation '<percentage>' on the Balanced Tab

	Examples:
		| percentage |
		| 25         |