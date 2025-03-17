namespace AirlineSystem;

public class Aircraft
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string ManufacturingYear { get; set; }
    public int Seats { get; set; }

    public Aircraft(string name, string model, string year, int seats)
    {
        Name = name;
        Model = model;
        ManufacturingYear = year;
        Seats = seats;
    }

    public string GetFlightName() => Name;
}
