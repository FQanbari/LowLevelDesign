 namespace CarRentalSystem;

public class CarRentalSystem
{
    public string Name { get; set; }
    public Address Location { get; set; }

    public CarRentalSystem(string name, Address address)
    {
        Name = name;
        Location = address;
    }

    public Address GetLocation() => Location;
}
