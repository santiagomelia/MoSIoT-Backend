Feature: deletePatientProfile
	For eliminate the Patient Profile
	As Domain Expert
	I want to delete the Patient profile

@DeletePatientProfileExistente
Scenario: Delete a Patient Profile existent
	Given There is Patient Profile with its specific id 
	When Remove the Patient Profile
	Then The Patient Profile was removed

@DeletePatientProfileNoExiste
Scenario: Delete a Patient Profile non-existent
	Given There is no Patient Profile with its specific id 
	When  Remove the Patient Profile non-existent
	Then The Patient Profile is not removed


