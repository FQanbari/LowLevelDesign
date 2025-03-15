using ParkingLotSystem;

DisplayBoard displayBoard = new DisplayBoard();
AutomatedSystem automatedSystem = new AutomatedSystem(1);
ParkingLot myParkingLot = new ParkingLot("MyParkingLot", 100, "Sec-135,Noida", 50, automatedSystem, displayBoard);
 
// Checking the availability of this parking lot
int availability = myParkingLot.GetAvailability();
Console.WriteLine(availability);


// Creating Customer
Customer piyush = new Customer("Piyush", "UP85 AX 5454");

// Automated System Generating Ticket
//Console.WriteLine(myParkingLot.DisplayBoard.Status);
if (myParkingLot.DisplayBoard.Status == Status.Available)
{
    Ticket piyushTicket = myParkingLot.AutomatedSystem.GenerateTicket(piyush);
    Console.WriteLine(myParkingLot.DisplayBoard.Status);
    myParkingLot.AutomatedSystem.OpenEntryBarrier();
    // Printing Ticket Info
    Console.WriteLine(piyushTicket);
    myParkingLot.AutomatedSystem.CloseEntryBarrier();
    double piyushCharges = myParkingLot.AutomatedSystem.CalculateCharges(piyushTicket.Id);
    Console.WriteLine(piyushCharges);

    myParkingLot.AutomatedSystem.OpenExitBarrier();
    myParkingLot.AutomatedSystem.CloseExitBarrier();
}

// Creating Customer
Customer ayush = new Customer("Ayush", "UP86 AB 9999");

if (myParkingLot.DisplayBoard.Status == Status.Available)
{
    // Automated System Generating Ticket
    Ticket ayushTicket = myParkingLot.AutomatedSystem.GenerateTicket(ayush);
    Console.WriteLine(myParkingLot.DisplayBoard.Status);
    myParkingLot.AutomatedSystem.OpenEntryBarrier();
    // Printing Ticket Info
    Console.WriteLine(ayushTicket);
    myParkingLot.AutomatedSystem.CloseEntryBarrier();
    double ayushCharges = myParkingLot.AutomatedSystem.CalculateCharges(ayushTicket.Id);
    Console.WriteLine(ayushCharges);

    // Printing Ticket Info
    Console.WriteLine(ayushTicket);

    myParkingLot.AutomatedSystem.OpenExitBarrier();
    myParkingLot.AutomatedSystem.CloseExitBarrier();
}
