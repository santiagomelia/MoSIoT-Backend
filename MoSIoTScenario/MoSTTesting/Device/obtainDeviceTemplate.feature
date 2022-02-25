Feature: obtainDeviceTemplate
	For obtain all Device Templates
	As Domain Expert
	Want to obtain a list of all Device Templates

@ObtainDeviceTemplates
Scenario: Existen Device Templates
	Given having a list of Device Templates
	When obtain Device Templates
	Then get a list of available Device Templates

