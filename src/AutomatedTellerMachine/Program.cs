using AutomatedTellerMachine;

var address = new Address("apt", "area", "city", "state", "country");
var bank = new Bank("MyBank", address);
var card = new DebitCard("John", "1234-5678", 123, DateTime.Now.AddYears(5));
var account = new SavingAccount("ACC123", bank, 1000, 500, card);
var atm = new Atm("ATM1", bank, address);

Console.WriteLine(atm.MakeTransaction(account, 200)); // باید true برگردونه
Console.WriteLine(account.GetAvailableBalance()); // باید 800 نشون بده