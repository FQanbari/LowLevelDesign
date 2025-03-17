namespace AutomatedTellerMachine;

public enum TransactionType
{
    None,
    BalanceInquiry,
    DepositCash,
    Withdraw,
    Transfer
}

public enum TransactionStatus
{
    Success,
    Failure,
    Blocked,
    Full,
    Partial,
    None
}
public class Transaction
{
    public string Id { get; set; }
    public DateTime Date { get; set; }
    public TransactionStatus Status { get; set; }
    public TransactionType Type { get; set; }

    public Transaction(string id, TransactionStatus status, TransactionType type, DateTime date)
    {
        Id = id;
        Status = status;
        Type = type;
        Date = date;
    }

    // اصلاح سازنده دوم
    public Transaction(string id, TransactionStatus status, DateTime date)
    {
        Id = id;
        Status = status;
        Date = date;
        Type = TransactionType.None; // مقدار پیش‌فرض
    }

    public virtual void MakeTransaction()
    {
        // پیاده‌سازی پیش‌فرض (قابل بازنویسی در کلاس‌های فرزند)
    }

    public void SaveTransaction()
    {
        // پیاده‌سازی در آینده
    }
}
public class Deposit : Transaction
{
    public int Amount { get; set; }

    public Deposit(string id, TransactionStatus status, DateTime date, int amount)
        : base(id, status, TransactionType.DepositCash, date)
    {
        Amount = amount;
    }

    public void GetTotalBalance()
    {
        // پیاده‌سازی در آینده
    }
}
public class Withdraw : Transaction
{
    public int Amount { get; set; }
    public string AccountNumber { get; set; }

    public Withdraw(string id, TransactionStatus status, DateTime date, int amount, string accountNumber)
        : base(id, status, TransactionType.Withdraw, date)
    {
        Amount = amount;
        AccountNumber = accountNumber;
    }

    public int GetAmount() => Amount;
}
public class BalanceInquiry : Transaction
{
    public string AccountNumber { get; set; }

    public BalanceInquiry(string id, TransactionStatus status, DateTime date, string accountNumber)
        : base(id, status, TransactionType.BalanceInquiry, date)
    {
        AccountNumber = accountNumber;
    }

    public void GetDetails()
    {
        // پیاده‌سازی در آینده
    }
}
public class Transfer : Transaction
{
    public string SourceAccountNumber { get; set; }
    public string DestAccountNumber { get; set; }

    public Transfer(string id, TransactionStatus status, DateTime date, string sourceAccountNumber, string destAccountNumber)
        : base(id, status, TransactionType.Transfer, date)
    {
        SourceAccountNumber = sourceAccountNumber;
        DestAccountNumber = destAccountNumber;
    }

    public void Send(int amount)
    {
        // پیاده‌سازی در آینده
    }
}