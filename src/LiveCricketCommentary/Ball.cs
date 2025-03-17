namespace LiveCricketCommentary;

// DeliveryType.cs
public enum DeliveryType
{
    Normal,
    Wide,
    No,
    FreeHit
}
// Ball.cs
public class Ball
{
    public Player Bowler { get; set; }
    public Player Batsman { get; set; }
    public DeliveryType Type { get; set; }
    public Run Run { get; set; }
    public Wicket Wicket { get; set; }
    public Commentary Commentary { get; set; }

    public Ball(Player bowler, Player batsman)
    {
        Bowler = bowler;
        Batsman = batsman;
    }
}
