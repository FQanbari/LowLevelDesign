using AirlineSystem;

var address = new Address("apartments", "area", "BLR", "KA", "India");
var harshPassport = new Passport("9148-0934-1142", "25/07/2000", address, "expiryDate");
var passenger = new Customer("id", "pass", "name", "email", "8758149799", harshPassport);

var flight = new Flight(DateTime.Now, DateTime.Now.AddHours(2), TimeSpan.FromHours(2), "BLR", "DEL");
var seat = new Seat(1, ClassType.EconomyClass, SeatCategory.Regular);
var sourceAirport = new Airport("Source", address, 1);
var destAirport = new Airport("Dest", address, 2);

var reservation = new Reservation(DateTime.Now, "RES123", flight, seat, destAirport, sourceAirport);

Console.WriteLine($"Initial payment status: {reservation.PaymentStatus}");
reservation.UpdatePaymentStatus(PaymentStatus.Pending);
reservation.UpdatePaymentStatus(PaymentStatus.Completed);
Console.WriteLine($"Is payment completed? {reservation.IsPaymentCompleted()}");

Console.WriteLine("done");