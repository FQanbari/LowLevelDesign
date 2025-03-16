
using BlackJackCardGame;

Player piyush = new Player("Piyush", 10000);
string userInput;

do
{
    Console.Write("Enter bet amount: ");
    double.TryParse(Console.ReadLine(), out double betAmount);
    BlackJack game = new BlackJack(piyush, betAmount);
    game.Start();
    Console.WriteLine($"Your Total amount is: {piyush.GetAmount()}");
    Console.Write("Would you like to DEAL? Press Y or N: ");
    userInput = Console.ReadLine()?.ToUpper();
} while (userInput == "Y");