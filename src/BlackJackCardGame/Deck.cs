namespace BlackJackCardGame;

// Deck.cs
public class Deck
{
    private readonly List<Card> _cards;
    private int _nextCardIndex;

    public Deck()
    {
        _cards = new List<Card>();
        CreateDeck();
        _nextCardIndex = 0;
    }

    private void CreateDeck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                _cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        var random = new Random();
        _cards.Sort((a, b) => random.Next(-1, 2)); // روش ساده برای شافل
        _nextCardIndex = 0;
    }

    public Card GetCard()
    {
        if (_nextCardIndex >= _cards.Count)
        {
            throw new InvalidOperationException("No more cards in the deck!");
        }
        return _cards[_nextCardIndex++];
    }

    public List<Card> GetCards(int n)
    {
        if (_nextCardIndex + n > _cards.Count)
        {
            Shuffle(); // اگر تعداد کارت کافی نیست، شافل کن
        }
        var sublist = _cards.GetRange(_nextCardIndex, n);
        _nextCardIndex += n;
        return sublist;
    }

    public override string ToString() => $"Deck{{cards={string.Join(", ", _cards)}}}";
}
