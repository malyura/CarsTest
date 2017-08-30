Feature: CarsTest

@CarsTest
Scenario: CarsTest
	Given Cars main page is open
	When I press tab Read Specs & Reviews
	Then Tab Read Specs & Reviews is open

	When I select in comboboxes random values Make, Model and Year for First car
	And I Save selected values for First car
	And I press button Search
	Then Description page First car is open

	When I press link Trim comparison
	Then Configuration page is open

	When I save Engines and Transmissions configuration for First car
	And I open main page
	Then Main page is open

	When I press tab Read Specs & Reviews
	Then Tab Read Specs & Reviews is open

	When I select in comboboxes random values Make, Model and Year car for Second car
	And I Save selected values for Second car
	And I press button Search
	Then Description page Second car is open

	When I press link Trim comparison
	Then Configuration page is open

	When I save Engines and Transmissions configuration for Second car
	And I press menu Buy -> Research car models
	Then Research page is open

	When I press button Compare cars
	Then Select compare page is open

	When I select First saved model car
	And I press button Start compare now
	Then Compare page is open

	When I press Add another car
	Then Add car page is open

	When I select Second saved model car
	And I press button Done
	Then Compare page is open

	When I check description car on Compare page
	Then Configuration First and Second cars coincides with saved configuration