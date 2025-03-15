namespace OnlineMovieTicketBookingSystem;
public class Theater
{
    private static int _counter = 0;
    public int Id { get; }
    public string Name { get; }
    public int Capacity { get; }
    public List<Show> Shows { get; } = new List<Show>();

    public Theater(string name, int capacity)
    {
        _counter++;
        Id = _counter;
        Name = name;
        Capacity = capacity;
    }
}