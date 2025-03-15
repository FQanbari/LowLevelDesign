
using OnlineMovieTicketBookingSystem;

public class Ticket
{
    private static int idCounter = 0;
    public int Id { get; }
    public string Owner { get; }
    public DateTime BookingTime { get; } = DateTime.Now;
    public int NumberOfSeats { get; }
    public Show BookedShow { get; }

    public Ticket(string owner, Show bookedShow, int numberOfSeats)
    {
        idCounter++;
        Id = idCounter;
        Owner = owner;
        BookedShow = bookedShow;
        NumberOfSeats = numberOfSeats;
    }

    public override string ToString() =>
        $"Ticket{{Id={Id}, Owner={Owner}, Seats={NumberOfSeats}, Show={BookedShow.Movie.Name}}}";
}