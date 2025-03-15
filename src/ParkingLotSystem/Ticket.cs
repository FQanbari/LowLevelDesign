using System;

namespace ParkingLotSystem;
public class Ticket
{
    private static int idCounter = 0;
    private string vehicleRegistrationNumber;
    private string parkingSpotNumber;

    public Ticket(Vehicle vehicle, ParkingSpot availableSpot)
    {
        Id = ++idCounter;
        this.vehicleRegistrationNumber = vehicle.VehicleNumber;
        this.parkingSpotNumber = availableSpot.SpotNumber;
        ArrivalTime = DateTime.Now.AddHours(-2);
    }

    public int Id { get; private set; }
    public DateTime ArrivalTime { get; private set; }

    public override string ToString()
    {
        return $"Ticket{{id={Id}, vehicleRegistrationNumber='{vehicleRegistrationNumber}', arrivalTime={ArrivalTime}, parkingSpotNumber='{parkingSpotNumber}'}}";
    }
}
