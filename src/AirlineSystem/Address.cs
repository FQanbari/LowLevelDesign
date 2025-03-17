namespace AirlineSystem;

public class Address
{
    public string Apartments { get; set; }
    public string Area { get; set; }
    public string Landmark { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string apartments, string area, string city, string state, string country, string landmark = "")
    {
        Apartments = apartments;
        Area = area;
        City = city;
        State = state;
        Country = country;
        Landmark = landmark;
    }

    public Address(string apartments, string area, string city, string state, string country)
        : this(apartments, area, city, state, country, "")
    {
    }
}
