namespace AutomatedTellerMachine;

public class Bank
{
    public string BankName { get; set; }
    public Address Address { get; set; }

    public Bank(string bankName, Address address)
    {
        BankName = bankName;
        Address = address;
    }
}
