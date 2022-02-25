Feature: obtainTelemetries
	For obtain all Telemetries
	As Domain Expert
	Want obtain a list of all telemetries

@ObtainTelemetries
Scenario: Existen telemetries
	Given having a list of telemetries
	When obtain telemetries
	Then get a list of available telemetries