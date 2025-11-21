[![build and test](https://github.com/BaraaAbuhalima/Real-time-weather-monitoring/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/BaraaAbuhalima/Real-time-weather-monitoring/actions/workflows/build-and-test.yml)

# Real-Time Weather Monitoring Console Application

A C# console application that simulates a real-time weather monitoring and reporting service. It ingests raw weather data in multiple formats (initially JSON and XML), normalizes it, and notifies a set of configurable "weather bots" that react to the data based on thresholds defined in a JSON configuration file. The design emphasizes SOLID principles (especially Open-Closed) and applies the Observer and Strategy design patterns to enable easy extension (new data formats and new bot behaviors) with minimal changes to existing code.

CI workflow (build-and-test) runs on Ubuntu, Windows, and macOS using .NET 9.0.302, restoring, building, and executing the unit test suite. Unit tests cover parsing, bot activation thresholds, and configuration loading.

## 1. Overview

The application prompts the user to enter weather data (JSON or XML). It parses the input, produces a unified `WeatherData` object, and dispatches it to subscribed weather bots. Each bot decides (based on its configuration) whether to activate and output a message. Bots are toggled and parameterized via a single JSON configuration file loaded at startup.

## 2. Features

- Multi-format input parsing (JSON and XML to start).
- Pluggable parser strategy allows adding new formats without modifying existing parsers.
- Observer pattern for pushing updates to registered bots.
- Configurable bot activation (enabled flag + threshold values + custom messages).
- Easily add new bot types by implementing a simple interface.
- Demonstrates SOLID (Open-Closed, Single Responsibility, Interface Segregation).
- Tested using unit tests validating parsers and bot activation logic.

## 3. Architecture & Design Patterns

- **Observer Pattern**: Weather station (or data dispatcher) acts as the subject; bots are observers. When new data arrives, all observers are notified.
- **Strategy Pattern**: Parsing strategies (`IDataParser`) for each input format. Selecting the appropriate strategy based on input pattern keeps parsing logic isolated.
- **Open-Closed Principle**: New parsers or bots added through new classes without modifying core logic.
- **Single Responsibility**: Each class (parser, bot, config loader) has one reason to change.

## 4. Supported Input Formats

### JSON

```json
{
  "Location": "City Name",
  "Temperature": 23.0,
  "Humidity": 85.0
}
```

### XML

```xml
<WeatherData>
	<Location>City Name</Location>
	<Temperature>23.0</Temperature>
	<Humidity>85.0</Humidity>
</WeatherData>
```

Adding a new format (e.g. CSV) would involve creating a new `CsvWeatherDataParser : IWeatherDataParser`.

## 5. Bot Types

- **RainBot**: Activates when `Humidity >= humidityThreshold`.
- **SunBot**: Activates when `Temperature >= temperatureThreshold`.
- **SnowBot**: Activates when `Temperature <= temperatureThreshold`.

Each bot prints its activation message when triggered. More bots (e.g. WindBot, StormBot) can be added by implementing `IWeatherBot`.

## 6. Configuration File

Single JSON file loaded at startup (example):

```json
{
  "RainBot": {
    "enabled": true,
    "humidityThreshold": 70,
    "message": "It looks like it's about to pour down!"
  },
  "SunBot": {
    "enabled": true,
    "temperatureThreshold": 30,
    "message": "Wow, it's a scorcher out there!"
  },
  "SnowBot": {
    "enabled": false,
    "temperatureThreshold": 0,
    "message": "Brrr, it's getting chilly!"
  }
}
```

## 7. Example Interaction

```
Enter weather data:
{"Location": "Amman", "Temperature": 32, "Humidity": 40}

SunBot activated!
SunBot: "Wow, it's a scorcher out there!"
```

If XML is entered:

```
<WeatherData><Location>Amman</Location><Temperature>32</Temperature><Humidity>40</Humidity></WeatherData>
```

Parsing selects XML strategy; activation logic identical.

## 8. Extensibility

### Add a New Bot

1. Create class `WindBot : BaseWeatherBot`.
2. Add config section:

```json
"WindBot": { "enabled": true, "speedThreshold": 50, "message": "Hold onto your hats!" }
```

3. In startup, if config contains `WindBot` and enabled, instantiate and subscribe. No existing bot code changed.

### Add a New Data Format

1. Implement `IDataParser` (e.g. `CsvWeatherDataParser`).

## 9. Quality & Testing

The application has been tested using xUnit
