namespace LiveCricketCommentary;

// Over.cs
public class Over
{
    public int Number { get; set; }
    public List<Ball> Balls { get; set; }

    public Over(int number)
    {
        Number = number;
        Balls = new List<Ball>();
    }

    public void AddBall(Ball ball)
    {
        Balls.Add(ball);
    }

    public int GetTotalRuns()
    {
        return Balls.Sum(b => b.Run?.TotalRuns ?? 0);
    }

    public int GetTotalWickets()
    {
        return Balls.Count(b => b.Wicket != null);
    }
}
