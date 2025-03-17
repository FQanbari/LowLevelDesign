namespace AirlineSystem;

public class Airport
{
    public string Name { get; set; }
    public Address Address { get; set; }
    public int UniqueId { get; set; }
    public List<Aircraft> Flights { get; set; } = new List<Aircraft>();

    public Airport(string name, Address address, int id)
    {
        Name = name;
        Address = address;
        UniqueId = id;
    }

    public void AddFlight(Aircraft flight)
    {
        Flights.Add(flight);
    }

    public List<Aircraft> GetFlights() => Flights;
}
