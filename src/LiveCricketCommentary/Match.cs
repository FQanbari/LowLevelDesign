namespace LiveCricketCommentary;

// MatchType.cs
public enum MatchType
{
    Test,
    Odi,
    T20
}
// Match.cs
public class Match
{
    public PlayingEleven Team1 { get; set; }
    public PlayingEleven Team2 { get; set; }
    public string Venue { get; set; }
    public DateTime DateTime { get; set; }
    public List<Inning> Innings { get; set; }
    public string ResultSummary { get; set; }
    public MatchType Type { get; set; }

    public Match(PlayingEleven team1, PlayingEleven team2, string venue, DateTime dateTime, MatchType type)
    {
        Team1 = team1;
        Team2 = team2;
        Venue = venue;
        DateTime = dateTime;
        Type = type;
        Innings = new List<Inning>();
    }
}
