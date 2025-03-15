namespace OnlineMovieTicketBookingSystem;
public class Show
{
    private static int idCounter = 0;
    public int Id { get; }
    public DateTime ShowTime { get; }
    public Movie Movie { get; }
    public Theater Theater { get; }
    public int AvailableSeats { get; private set; }

    public Show(DateTime showTime, Movie movie, Theater theater)
    {
        idCounter++;
        Id = idCounter;
        ShowTime = showTime;
        Movie = movie;
        Theater = theater;
        AvailableSeats = theater.Capacity;
        theater.Shows.Add(this);
    }

    public Ticket BookTicket(RegisteredUser user, int seats)
    {
        lock (this)
        {
            if (AvailableSeats >= seats && seats > 0)
            {
                AvailableSeats -= seats;
                var ticket = new Ticket(user.Name, this, seats);
                user.BookingHistory.Add(ticket);
                Console.WriteLine("Successfully booked");
                return ticket;
            }
            Console.WriteLine("Seats not available");
            return null;
        }
    }
}
