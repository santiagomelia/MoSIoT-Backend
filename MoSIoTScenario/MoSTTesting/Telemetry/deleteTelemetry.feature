Feature: deleteTelemetry
		For eliminate the Telemetry
	As Domain Expert
	I want to delete the Telemetry

@DeleteTelemetryExistente
Scenario: Delete a Telemetry existent
	Given There is Telemetry with its specific id 
	When Remove the Telemetry
	Then The Telemetry was removed

@DeleteTelemetryNonExistente
Scenario: Delete a Telemetry non-existent
	Given There is no Telemetry with its specific id 
	When  Remove the Telemetry non-existent
	Then The Telemetry is not removed