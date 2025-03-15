namespace OnlineMovieTicketBookingSystem;

public class TicketBookingThread
{
    private readonly Show show;
    private readonly RegisteredUser user;
    private readonly int numberOfSeats;
    private Ticket ticket;

    public TicketBookingThread(Show show, RegisteredUser user, int numberOfSeats)
    {
        this.show = show;
        this.user = user;
        this.numberOfSeats = numberOfSeats;
    }

    public void Run()
    {
        this.ticket = show.BookTicket(user, numberOfSeats);
    }

    public Ticket GetTicket() => ticket;
}