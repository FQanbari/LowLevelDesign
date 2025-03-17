namespace LiveCricketCommentary;

// WicketType.cs
public enum WicketType
{
    Bowled,
    Caught,
    Lbw,
    Runout,
    Stumped
}
// Wicket.cs
public class Wicket
{
    public WicketType WicketType { get; set; }
    public Player Batsman { get; set; }
    public Player By { get; set; }
}
