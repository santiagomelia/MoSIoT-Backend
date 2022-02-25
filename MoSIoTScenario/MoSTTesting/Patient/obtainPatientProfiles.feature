Feature: obtainPatientProfiles
	For obtain all Patient Profiles
	As Domain Expert
	Want obtain a list of all Patient Profiles

@ObtainPatientProfiles
Scenario: Existen Patient Profiles
	Given having a list of Patient profiles
	When obtain patient profiles
	Then get a list of available patient profiles
