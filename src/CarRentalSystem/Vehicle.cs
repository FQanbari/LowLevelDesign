using System;

namespace CarRentalSystem;

public enum BillingType
{
    BaseCharge,
    AdditionalService,
    Fine,
    Other
}

public enum VehicleCategory
{
    Car,
    Truck,
    Bus,
    SUV,
    Van,
    Motorcycle
}

public enum VehicleType
{
    Accident,
    Fueling,
    CleaningService,
    OilChange,
    Repair,
    Other
}

public enum CarType
{
    Economy,
    Compact,
    Standard,
    Premium,
    Luxury
}

public enum PaymentStatus
{
    Unpaid,
    Pending,
    Completed,
    Cancelled,
    Refunded
}
public class Vehicle
{
    public int LicenceNumber { get; set; }
    public int Capacity { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateTime ManufacturingYear { get; set; }
    public List<string> Logs { get; set; } = new List<string>();
    public VehicleCategory Category { get; set; }

    public Vehicle(int licenceNumber, int capacity, string brand, string model, DateTime manufacturingYear, string log, VehicleCategory category)
    {
        LicenceNumber = licenceNumber;
        Capacity = capacity;
        Brand = brand;
        Model = model;
        ManufacturingYear = manufacturingYear;
        Logs.Add(log);
        Category = category;

        VehicleInventory.AddVehicle(category, this);
    }

    public void AddLogs(string log)
    {
        Logs.Add(log);
    }

    public List<string> GetLogs() => Logs;
}
public class VehicleLog
{
    public string Id { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public DateTime CreationDate { get; set; }

    public VehicleLog(string id, string description, string type, DateTime creationDate)
    {
        Id = id;
        Description = description;
        Type = type;
        CreationDate = creationDate;
    }

    public void Update(string id, string description, string type, DateTime creationDate)
    {
        Id = id;
        Description = description;
        Type = type;
        CreationDate = creationDate;
    }

    public string SearchByType(string type) => Description;
}