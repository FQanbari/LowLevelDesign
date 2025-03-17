namespace AutomatedTellerMachine;

public class Address
{
    public string Apartments { get; set; }
    public string Area { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string apartments, string area, string city, string state, string country)
    {
        Apartments = apartments;
        Area = area;
        City = city;
        State = state;
        Country = country;
    }
}