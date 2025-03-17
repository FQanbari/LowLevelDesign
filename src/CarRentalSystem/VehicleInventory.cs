namespace CarRentalSystem;

public class VehicleInventory
{
    private static readonly Dictionary<VehicleCategory, List<Vehicle>> Inventory = new Dictionary<VehicleCategory, List<Vehicle>>();
    private static readonly List<Vehicle> Database = new List<Vehicle>();

    public static void AddVehicle(VehicleCategory category, Vehicle vehicle)
    {
        if (!Inventory.ContainsKey(category))
        {
            Inventory[category] = new List<Vehicle>();
        }
        Inventory[category].Add(vehicle);
        Database.Add(vehicle);
    }

    public static List<Vehicle> GetVehicleByCategory(VehicleCategory category)
    {
        return Inventory.ContainsKey(category) ? Inventory[category] : new List<Vehicle>();
    }

    public static List<Vehicle> GetAllVehicles() => Database;
}
