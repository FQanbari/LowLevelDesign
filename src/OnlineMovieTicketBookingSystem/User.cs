namespace OnlineMovieTicketBookingSystem;

public abstract class User
{
    public string Name { get; }
    public User(string name) => Name = name;
}

public class GuestUser : User
{
    public GuestUser(string name) : base(name) { }
}

public class RegisteredUser : User
{
    public List<Ticket> BookingHistory { get; } = new List<Ticket>();
    public RegisteredUser(string name) : base(name) { }
}