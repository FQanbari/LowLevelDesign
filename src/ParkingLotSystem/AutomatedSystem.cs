using System;
using System.Collections.Generic;

namespace ParkingLotSystem;
public class AutomatedSystem
{
    private int id;
    private Dictionary<int, Ticket> currentTickets;

    public AutomatedSystem(int id)
    {
        this.id = id;
        this.currentTickets = new Dictionary<int, Ticket>();
    }

    public ParkingLot ParkingLot { get; set; }  

    private ParkingSpot FetchAvailableSpot()
    {
        return ParkingLot.GetAvailableSpot();
    }

    public Ticket GenerateTicket(Customer customer)
    {
        ParkingSpot availableSpot = FetchAvailableSpot();
        Vehicle vehicle = customer.Vehicle;
        Ticket ticket = new Ticket(vehicle, availableSpot);
        currentTickets[ticket.Id] = ticket;
        return ticket;
    }

    public Ticket ScanTicket(int id)
    {
        // Assuming scanned ticket ID is 1234 for simplicity
        currentTickets.TryGetValue(id, out Ticket ticket);
        return ticket;
    }

    public double CalculateCharges(int id)
    {
        Ticket ticket = ScanTicket(id);
        if (ticket == null) return 0; // Handle null case
        TimeSpan duration = DateTime.Now - ticket.ArrivalTime;
        double charges = duration.TotalHours * ParkingLot.ParkingCharges;
        return charges;
    }

    public void OpenEntryBarrier()
    {
        Console.WriteLine("Open Entry Barrier");
        // Placeholder for opening entry barrier logic
        ParkingLot.DisplayBoard.Update(Status.Full);
    }

    public void CloseEntryBarrier()
    {
        Console.WriteLine("Close Entry Barrier");
        // Placeholder for closing entry barrier logic
    }

    public void OpenExitBarrier()
    {
        Console.WriteLine("Open Exit Barrier");

        // Placeholder for opening exit barrier logic
        ParkingLot.DisplayBoard.Update(Status.Available);
    }

    public void CloseExitBarrier()
    {
        Console.WriteLine("Close Exit Barrier");
        // Placeholder for closing exit barrier logic
    }
}
