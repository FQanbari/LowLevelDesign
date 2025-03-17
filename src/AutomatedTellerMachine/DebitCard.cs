namespace AutomatedTellerMachine;

public class DebitCard
{
    public string Name { get; set; }
    public string CardNumber { get; set; }
    public int Cvv { get; set; }
    public DateTime ExpiryDate { get; set; }

    public DebitCard(string name, string cardNumber, int cvv, DateTime expiryDate)
    {
        Name = name;
        CardNumber = cardNumber;
        Cvv = cvv;
        ExpiryDate = expiryDate;
    }
}
