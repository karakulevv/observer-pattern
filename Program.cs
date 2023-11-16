using ObserverPattern.Models;
using ObserverPattern.Observers;

namespace ObserverPattern;

class Program
{
    public static void Main(string[] args)
    {
        // Create instances of subject and observers
        WeatherData weatherData = new WeatherData();
        MobileDisplay mobileDisplay = new MobileDisplay();
        WebDisplay webDisplay = new WebDisplay();

        // Register observers with the subject
        weatherData.RegisterObserver(mobileDisplay);
        weatherData.RegisterObserver(webDisplay);

        // Simulate changes in weather data
        weatherData.SetMeasurements(25.5f, 65f, 1020f);
    }
}