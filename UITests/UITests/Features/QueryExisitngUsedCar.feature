Feature: QueryExisitngUsedCar

@UI @UserCar
Scenario: Query Existing User car listing and confirm details
	When I navigate to the TM Sandbox website
	And I search for "Toyota" 
	And I select listing "2" on the page
	Then the following details exist
	| Detail       | Value                    |
	| Number plate | KEL336                   |
	| Kilometres   | 44,191km                 |
	| Body         | White, 4 door, Hatchback |
	| Engine size  | 1798cc                   |