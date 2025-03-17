namespace AutomatedTellerMachine;

public class Atm
{
    public string AtmId { get; set; }
    public Bank Bank { get; set; }
    public Address Address { get; set; }

    public Atm(string atmId, Bank bank, Address address)
    {
        AtmId = atmId;
        Bank = bank;
        Address = address;
    }

    public bool AuthenticateUser(string id, string pass)
    {
        return id == "id" && pass == "password"; // منطق ساده فعلی
    }

    public bool MakeTransaction(Account user, int amount)
    {
        if (user.AvailableBalance < amount)
            return false;

        user.AvailableBalance -= amount;
        return true;
    }
}
