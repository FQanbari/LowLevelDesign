namespace BlackJackCardGame;


public class Dealer
{
    public Hand Hand { get; }

    public Dealer()
    {
        Hand = new Hand();
    }

    public Card PrintHand() => Hand.Cards[0];

    public void Hit(Deck deck) => Hand.AddCard(deck.GetCard());

    public void DealCards(Deck deck, Player player)
    {
        player.Hand.AddCards(deck.GetCards(2));
        Hand.AddCards(deck.GetCards(2));
    }
}

public class Player
{
    public string Name { get; }
    private double _amount;
    public Hand Hand { get; }

    public Player(string name, double amount)
    {
        Name = name;
        _amount = amount;
        Hand = new Hand();
    }

    public double GetAmount() => _amount;

    public void Hit(Deck deck) => Hand.AddCard(deck.GetCard());

    public void UpdateAmount(double value) => _amount += value;
}

// BlackJack.cs
public class BlackJack
{
    private readonly Dealer _dealer;
    private readonly Player _player;
    private readonly Deck _deck;
    private readonly double _betAmount;

    public BlackJack(Player player, double betAmount)
    {
        _dealer = new Dealer();
        _deck = new Deck();
        _player = player;
        _betAmount = betAmount;
    }

    public void PrintHandsAndScore()
    {
        Console.WriteLine($"Dealer Cards: {_dealer.PrintHand()}");
        Console.WriteLine($"Your Cards: {_player.Hand}");
        Console.WriteLine($"Your Score: {_player.Hand.GetValue()}");
    }

    public int DealerPlay(int dealerScore, int playerScore)
    {
        Console.WriteLine($"Dealer Hand: {_dealer.Hand}");
        Console.WriteLine($"Dealer Score: {dealerScore}");

        while (dealerScore < 17)
        {
            _dealer.Hit(_deck);
            dealerScore = _dealer.Hand.GetValue();
            Console.WriteLine("Dealer Hit");
            Console.WriteLine($"Dealer Hand: {_dealer.Hand}");
            Console.WriteLine($"Dealer Score: {dealerScore}");
        }

        if (dealerScore > 21)
        {
            Console.WriteLine("Dealer Busted! You Win");
            _player.UpdateAmount(_betAmount);
            return 1;
        }
        else if (dealerScore >= playerScore)
        {
            Console.WriteLine("Dealer Wins");
            _player.UpdateAmount(-1 * _betAmount);
            return 0;
        }
        else
        {
            Console.WriteLine("You Win");
            _player.UpdateAmount(_betAmount);
            return 1;
        }
    }

    public int Start()
    {
        _deck.Shuffle();
        _dealer.DealCards(_deck, _player);

        int playerScore = _player.Hand.GetValue();
        int dealerScore = _dealer.Hand.GetValue();

        while (true)
        {
            PrintHandsAndScore();
            if (playerScore == 21)
            {
                Console.WriteLine("BlackJack! You Win");
                _player.UpdateAmount(_betAmount);
                return 1;
            }
            else if (playerScore > 21)
            {
                Console.WriteLine("Busted! Dealer Wins");
                _player.UpdateAmount(-1 * _betAmount);
                return 0;
            }
            else
            {
                Console.Write("Press 1 to Hit, 0 to Stand: ");
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Invalid Choice! Press 1 to Hit, 0 to Stand");
                    continue;
                }

                if (input == 0)
                {
                    return DealerPlay(dealerScore, playerScore);
                }
                else if (input == 1)
                {
                    _player.Hit(_deck);
                    playerScore = _player.Hand.GetValue();
                    Console.WriteLine("You Hit");
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Press 1 to Hit, 0 to Stand");
                }
            }
        }
    }

}