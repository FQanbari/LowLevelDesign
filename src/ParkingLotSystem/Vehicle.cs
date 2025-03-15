namespace ParkingLotSystem;

public class Vehicle
{
    public Vehicle(string vehicleNumber)
    {
        VehicleNumber = vehicleNumber;
    }

    public string VehicleNumber { get; private set; }
}