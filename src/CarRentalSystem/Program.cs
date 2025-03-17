using CarRentalSystem;

var address = new Address("street", "city", "state", "zipcode", "country");
var person = new Person("Harsh", "h@g.com", "8758149799", address);
var harsh = new Member("id", "password", person, AccountStatus.Active, 5);

var car = new Vehicle(1001, 4, "BMW", "sportz", DateTime.Now, "none", VehicleCategory.Car);
car.AddLogs("Accident");

var mahindra = new Vehicle(1121, 6, "MAHINDRA", "XUV", DateTime.Now, "none", VehicleCategory.SUV);

// نمایش همه خودروها
foreach (var vehicle in VehicleInventory.GetAllVehicles())
{
    Console.WriteLine(vehicle.Brand);
}