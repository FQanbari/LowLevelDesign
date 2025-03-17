namespace AutomatedTellerMachine;

public enum Status
{
    Active,
    Blocked,
    Banned,
    Closed
}
public class Account
{
    public string AccountNumber { get; set; }
    public int AvailableBalance { get; set; }
    public Bank Bank { get; set; }
    public Status Status { get; set; } = Status.Active;

    public Account(string accountNumber, Bank bank, int availableBalance)
    {
        AccountNumber = accountNumber;
        Bank = bank;
        AvailableBalance = availableBalance;
    }

    public string GetAccountNumber() => AccountNumber;
    public int GetAvailableBalance() => AvailableBalance;
}
public class SavingAccount : Account
{
    public int WithdrawLimit { get; set; }
    public DebitCard Card { get; set; }

    public SavingAccount(string accountNumber, Bank bank, int availableBalance, int withdrawLimit, DebitCard card)
        : base(accountNumber, bank, availableBalance)
    {
        WithdrawLimit = withdrawLimit;
        Card = card;
    }
}

public class CurrentAccount : Account
{
    public int WithdrawLimit { get; set; }
    public DebitCard Card { get; set; }

    public CurrentAccount(string accountNumber, Bank bank, int availableBalance, int withdrawLimit, DebitCard card)
        : base(accountNumber, bank, availableBalance)
    {
        WithdrawLimit = withdrawLimit;
        Card = card;
    }
}