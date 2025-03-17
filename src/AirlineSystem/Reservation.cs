namespace AirlineSystem;

public enum PaymentStatus
{
    Unpaid,
    Pending,
    Completed,
    Declined,
    Cancelled,
    Refunded
}
public class Reservation
{
    public DateTime CreationDate { get; set; }
    public string ReservationNumber { get; set; }
    public Flight Flight { get; set; }
    public Seat Seats { get; set; }
    public Airport DestinationAirport { get; set; }
    public Airport SourceAirport { get; set; }
    public PaymentStatus PaymentStatus { get; set; }

    public Reservation(DateTime creationDate, string reservationNumber, Flight flight, Seat seat, Airport destinationAirport, Airport sourceAirport)
    {
        CreationDate = creationDate;
        ReservationNumber = reservationNumber;
        Flight = flight;
        Seats = seat;
        DestinationAirport = destinationAirport;
        SourceAirport = sourceAirport;
        PaymentStatus = PaymentStatus.Unpaid;
    }

    public string GetReservationNumber() => ReservationNumber;
    public Flight GetFlight() => Flight;
    public Seat GetSeats() => Seats;
    public void UpdatePaymentStatus(PaymentStatus status)
    {
        PaymentStatus = status;
        Console.WriteLine($"Payment status for reservation {ReservationNumber} updated to {status}");
    }
    public bool IsPaymentCompleted() => PaymentStatus == PaymentStatus.Completed;
}
