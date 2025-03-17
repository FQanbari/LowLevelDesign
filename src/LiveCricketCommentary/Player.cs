namespace LiveCricketCommentary;

// Player.cs
public class Player
{
    public string Name { get; set; }
    public DateTime Dob { get; set; }
    public Team Team { get; set; }
    public PlayerRecord Record { get; set; }

    public Player(string name, DateTime dob, Team team)
    {
        Name = name;
        Dob = dob;
        Team = team;
        Record = new PlayerRecord();
    }
}
// PlayerRecord.cs
public class PlayerRecord
{
    public int MatchesPlayed { get; set; }
    public int TotalRuns { get; set; }
    public double BattingAverage { get; set; }
    public int Centuries { get; set; }
    public int HalfCenturies { get; set; }
    public int HighestScore { get; set; }
    public int TotalWickets { get; set; }
    public int Economy { get; set; }

    public PlayerRecord() { }
}