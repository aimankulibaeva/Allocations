Feature: CautiousTabTests

Scenario Outline: Check Cash Fund Allocations on the Cautious Tab
	Given I am logged in
	And I am on the Allocations page
	When I Click Cautious Tab
	Then I should see Allocation '<percentage>' in a Cash Fund

	Examples:
		| percentage |
		| 85         |

Scenario Outline: Check Shares Fund Allocations on the Cautious Tab
	Given I am logged in
	And I am on the Allocations page
	When I Click Cautious Tab
	Then I should see Allocation '<percentage>' in a Shares Fund

	Examples:
		| percentage |
		| 10         |

Scenario Outline: Check Property Shares Fund Allocations on the Cautious Tab
	Given I am logged in
	And I am on the Allocations page
	When I Click Cautious Tab
	Then I should see Allocation '<percentage>' in a Property Shares Fund

	Examples:
		| percentage |
		| 5          |