Feature: deleteDeviceTemplate
	For eliminate the Device Template
	As Domain Expert
	I want to delete the Device Template


@DeleteDeviceTemplateExistente
Scenario: Delete a Device Template existent
	Given There is Device Template with its specific id 
	When Remove the Device Template
	Then The Device Template was removed

@DeleteDeviceTemplateNoExiste
Scenario: Delete a Device Template non-existent
	Given There is no Device Template with its specific id 
	When  Remove the Device Template non-existent
	Then The Device Template is not removed