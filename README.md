# Observer Pattern Example: Weather Monitoring

## Introduction

The Observer Pattern is a behavioral design pattern that establishes a one-to-many relationship between objects, ensuring that when the state of one object (the subject) changes, all its dependents (observers) are notified and updated automatically.

In this scenario, a weather monitoring application serves as the subject, maintaining real-time weather data. Various display devices (observers), such as mobile displays and web displays, subscribe to receive updates from the weather monitoring system whenever there's a change in weather conditions.

## Components

### Subject (WeatherData)

- Represents the weather monitoring system.
- Maintains weather-related data and notifies registered observers when weather conditions change.

### Observer Interface (IObserver)

- Defines the interface for observers to implement an `Update` method.
- Observers implement this interface to receive updates from the subject.

### Concrete Observers (MobileDisplay, WebDisplay)

- Concrete classes implementing the `IObserver` interface.
- Receive updates from the weather monitoring system and update their displays with the latest weather information.

## Usage

1. Instantiate the `WeatherData` subject.
2. Create instances of various observers (`MobileDisplay`, `WebDisplay`).
3. Register observers with the `WeatherData` subject.
4. Simulate changes in weather data using the `SetMeasurements` method in the `WeatherData` subject.

## Implementation Notes

- Ensure proper registration and deregistration of observers with the subject to avoid memory leaks.
- Maintain a clear separation of concerns between subject and observers to facilitate easy addition or removal of observers.