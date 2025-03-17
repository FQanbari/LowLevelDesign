namespace LiveCricketCommentary;

// TournamentType.cs
public enum TournamentType
{
    Completed,
    Active,
    Upcoming
}

// Tournament.cs
public class Tournament
{
    public TournamentType Type { get; set; } = TournamentType.Upcoming;
    public List<Match> Matches { get; set; }
    public string Title { get; set; }
    public string Host { get; set; }
    public string Year { get; set; }
    public Team Winner { get; set; }
    public Dictionary<string, Match> Schedule { get; set; }
    public Dictionary<string, int> TeamPoints { get; set; }

    public Tournament(string title, string host, string year)
    {
        Title = title;
        Host = host;
        Year = year;
        Matches = new List<Match>();
        Schedule = new Dictionary<string, Match>();
        TeamPoints = new Dictionary<string, int>();
    }

    public void AddMatch(Match match)
    {
        Matches.Add(match);
        string dateTimeString = match.DateTime.ToString();
        Schedule[dateTimeString] = match;
    }

    public void UpdateTeamPoints(string teamName, int newPoints)
    {
        TeamPoints[teamName] = TeamPoints.GetValueOrDefault(teamName) + newPoints;
    }

    public Dictionary<string, Match> GetTeamSchedule(string teamName)
    {
        return Schedule
            .Where(kvp => kvp.Value.ToString().Contains(teamName))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    public int? GetTeamPoints(string teamName)
    {
        return TeamPoints.TryGetValue(teamName, out int points) ? points : null;
    }
}
