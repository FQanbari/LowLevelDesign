namespace LiveCricketCommentary;

// TournamentSquad.cs
public class TournamentSquad
{
    public List<Player> Players { get; set; }

    public TournamentSquad()
    {
        Players = new List<Player>();
    }

    public PlayingEleven SelectPlayingEleven()
    {
        bool conditionForSelection = true;
        PlayingEleven selectedPlayers = new PlayingEleven();

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
// PlayingEleven.cs
public class PlayingEleven
{
    public List<Player> Players { get; set; }
    public Player TwelfthMan { get; set; }

    public PlayingEleven()
    {
        Players = new List<Player>();
    }
}