namespace ParkingLotSystem;


public class Customer
{
    private string name;

    public Customer(string name, string vehicleNumber)
    {
        this.name = name;
        Vehicle = new Vehicle(vehicleNumber);
    }

    public Vehicle Vehicle { get; private set; }
}
