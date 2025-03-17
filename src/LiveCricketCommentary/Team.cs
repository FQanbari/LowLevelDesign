namespace LiveCricketCommentary;

// Team.cs
public class Team
{
    public string Name { get; set; }
    public List<Player> Players { get; set; }

    public Team(string name)
    {
        Name = name;
        Players = new List<Player>();
    }

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        Players.Remove(player);
    }

    public TournamentSquad SelectTournamentSquad()
    {
        bool conditionForSelection = true;
        TournamentSquad selectedPlayers = new TournamentSquad();

        foreach (var p in Players)
        {
            if (conditionForSelection)
            {
                selectedPlayers.Players.Add(p);
            }
        }
        return selectedPlayers;
    }
}
