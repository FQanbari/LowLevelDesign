namespace LiveCricketCommentary;

// CricLive.cs
public class CricLive
{
    public List<Tournament> Tournaments { get; set; }
    public Admin Admin { get; set; }
    public List<Commentator> Commentators { get; set; }

    public CricLive(Admin admin)
    {
        Admin = admin;
        Tournaments = new List<Tournament>();
        Commentators = new List<Commentator>();
    }

    public void AddTournament(Tournament tournament)
    {
        Tournaments.Add(tournament);
    }

    public void AddCommentator(Commentator commentator)
    {
        Commentators.Add(commentator);
    }
}
