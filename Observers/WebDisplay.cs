using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers;

// Step 3: Implement Concrete Observer
public class WebDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        Console.WriteLine("Web Display Updated - Temperature: " + temperature + " Humidity: " + humidity + " Pressure: " + pressure);
    }
}