namespace AirlineSystem;

public enum ClassType
{
    FirstClass,
    BusinessClass,
    EconomyClass
}

public enum SeatCategory
{
    Regular,
    Accessible,
    EmergencyExit
}
public class Seat
{
    public int SeatNumber { get; set; }
    public ClassType Type { get; set; }
    public SeatCategory Category { get; set; }

    public Seat(int seatNumber, ClassType type, SeatCategory category)
    {
        SeatNumber = seatNumber;
        Type = type;
        Category = category;
    }

    public int GetSeatNumber() => SeatNumber;
    public ClassType GetType() => Type;
    public SeatCategory GetCategory() => Category;
}
