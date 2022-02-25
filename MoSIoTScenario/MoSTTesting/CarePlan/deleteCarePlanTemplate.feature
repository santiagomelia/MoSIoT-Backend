Feature: deleteCarePlanTemplate
	For eliminate the Care Plan Template
	As Domain Expert
	I want to delete the Care Plan Template


@DeleteCarePlanTemplate
Scenario: Delete a Care Plan template existent
	Given There is Care Plan Template with its specific id 
	When Remove the Care plan Template
	Then The Care Plan Template was removed

@DeleteCarePlanTemplateNon-existent
Scenario: Delete a Care Plan template non-existent
	Given There is no Care Plan Template with specific id 
	When  Remove the Care plan Template non existent
	Then The Care Plan Template not removed