using ParkingLotSystem;
using System;
using System.Collections.Generic;

namespace ParkingLotSystem;

public enum Status
{
    Available,
    Full
}
public class ParkingLot
{
    private string name;
    private int capacity;
    private string location;
    private Admin admin;
    private List<ParkingSpot> parkingSpots;
    private List<ParkingSpot> availableSpots;

    public ParkingLot(string name, int capacity, string location, double parkingCharges,
        AutomatedSystem automatedSystem, DisplayBoard displayBoard)
    {
        this.name = name;
        this.capacity = capacity;
        this.location = location;
        ParkingCharges = parkingCharges;
        AutomatedSystem = automatedSystem;
        this.AutomatedSystem.ParkingLot = this; // Set reference back to this ParkingLot
        DisplayBoard = displayBoard;
        this.parkingSpots = CreateParkingSpots(capacity);
        this.availableSpots = new List<ParkingSpot>(parkingSpots); // Clone the list
    }
    public AutomatedSystem AutomatedSystem { get; private set; }
    public double ParkingCharges { get; private set; }
    public DisplayBoard DisplayBoard { get; private set; }

    private List<ParkingSpot> CreateParkingSpots(int capacity)
    {
        List<ParkingSpot> tempList = new List<ParkingSpot>();
        for (int i = 0; i < capacity; i++)
        {
            tempList.Add(new ParkingSpot($"MPL {i}"));
        }
        return tempList;
    }

    public ParkingSpot GetAvailableSpot()
    {
        if (availableSpots.Count == 0) return null; // Handle empty case if needed
        ParkingSpot spot = availableSpots[0];
        availableSpots.RemoveAt(0);
        return spot;
    }

    public int GetAvailability()
    {
        return availableSpots.Count;
    }

    public void UpdateParkingCharges(double newCharges)
    {
        ParkingCharges = newCharges;
    }

    public void SetAdmin(Admin admin)
    {
        this.admin = admin;
    }

}

public class DisplayBoard
{
    public Status Status { get; private set; }

    public DisplayBoard()
    {
        this.Status = Status.Available;
    }

    public void Update(Status newStatus)
    {
        this.Status = newStatus;
    }
}
public class ParkingSpot
{
    public ParkingSpot(string spotNumber)
    {
        SpotNumber = spotNumber;
    }

    public string SpotNumber { get; private set; }
}
