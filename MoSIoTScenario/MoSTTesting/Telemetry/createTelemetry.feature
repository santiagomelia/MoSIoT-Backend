Feature: createTelemetry
		For making a new telemetry
		As domain expert
		I want to create new telemetry

@CreateTelemetry
Scenario: Create a new Telemetry
	Given I want to create a new Telemetry with specific device
	When Create telemetry
	Then el telemetry was created