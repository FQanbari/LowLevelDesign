namespace Zomato;

public class Address
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Zipcode { get; }
    public string Country { get; }

    public Address(string street, string city, string state, string zipcode, string country)
    {
        Street = street;
        City = city;
        State = state;
        Zipcode = zipcode;
        Country = country;
    }
}
