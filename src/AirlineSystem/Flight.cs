namespace AirlineSystem;

public class Flight
{
    public DateTime Departure { get; set; }
    public DateTime Arrival { get; set; }
    public TimeSpan Duration { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }

    public Flight(DateTime departure, DateTime arrival, TimeSpan duration, string destination, string origin)
    {
        Departure = departure;
        Arrival = arrival;
        Duration = duration;
        Origin = origin;
        Destination = destination;
    }
}