namespace LiveCricketCommentary;

// Inning.cs
public class Inning
{
    public int Number { get; set; }
    public List<Over> Overs { get; set; }

    public Inning(int number)
    {
        Number = number;
        Overs = new List<Over>();
    }

    public void AddOver(Over over)
    {
        Overs.Add(over);
    }

    public int GetTotalScore()
    {
        return Overs.Sum(o => o.GetTotalRuns());
    }
}
