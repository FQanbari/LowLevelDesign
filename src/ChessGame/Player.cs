
namespace ChessGame;

// Status.cs
public enum Status
{
    Active,
    Saved,
    BlackWin,
    WhiteWin,
    Stalemate
}
// Player.cs
public class Player
{
    public string Name { get; }

    public Player(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public void Join(Game game)
    {
        // Implementation can be added later
    }
}
