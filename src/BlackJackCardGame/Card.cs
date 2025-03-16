namespace BlackJackCardGame;
public enum Suit
{
    Heart,
    Club,
    Spade,
    Diamond
}
public enum Rank
{
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 10,
    Queen = 10,
    King = 10,
    Ace = 11
}
public class Card
{
    public Rank Rank { get; }
    public Suit Suit { get; }

    public Card(Suit suit, Rank rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public int GetValue() => (int)Rank;

    //public override string ToString() => $"[{Rank},{Suit}]";
    public override string ToString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string suitSymbol = Suit switch
        {
            Suit.Heart => "\u2665",   // ♥
            Suit.Club => "\u2663",    // ♣
            Suit.Spade => "\u2660",   // ♠
            Suit.Diamond => "\u2666", // ♦
            _ => throw new ArgumentException("Invalid suit")
        };

        

        return $"{Rank} {suitSymbol}"; // مثلاً "A♥" یا "10♠"
    }
}
