using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers;

// Step 3: Implement Concrete Observer
public class MobileDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        Console.WriteLine("Mobile Display Updated - Temperature: " + temperature + " Humidity: " + humidity + " Pressure: " + pressure);
    }
}