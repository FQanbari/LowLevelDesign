namespace BlackJackCardGame;

public class Hand
{
    private readonly List<Card> _cards;

    public Hand()
    {
        _cards = new List<Card>();
    }

    public IReadOnlyList<Card> Cards => _cards.AsReadOnly();

    public int GetValue()
    {
        int tempValue = 0;
        int numOfAces = 0;

        foreach (var card in _cards)
        {
            tempValue += card.GetValue();
            if (card.Rank == Rank.Ace)
            {
                numOfAces++;
            }
        }

        while (numOfAces > 0 && tempValue > 21)
        {
            tempValue -= 10;
            numOfAces--;
        }

        return tempValue;
    }
    public void AddCards(List<Card> cards)
    {
        _cards.AddRange(cards);
    }
    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
    public override string ToString() => $"[{string.Join(", ", _cards)}]";
}
