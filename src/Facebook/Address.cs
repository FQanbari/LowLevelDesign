namespace Facebook;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string zipcode, string country)
    {
        Street = street;
        City = city;
        State = state;
        Zipcode = zipcode;
        Country = country;
    }
}
