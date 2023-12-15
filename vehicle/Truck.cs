namespace gitDZ.vehicle;

public class Truck : IVehicle
{
    public string Model { get; }
    public string Owner { get; set; }
    public double FuelAmmount { get; set; }
    public int NumberOfWheels { get; set; }
    private bool EngineRunning { get; set; }
    public bool IsWithTrailer { get; set; }

    public Truck(string model, string owner, double fuelAmmount, int numberOfWheels)
    {
        Model = model;
        Owner = owner;
        FuelAmmount = fuelAmmount;
        EngineRunning = false;
        NumberOfWheels = numberOfWheels;
        IsWithTrailer = false;
    }

    public void EngineTurnOn()
    {
        if (FuelAmmount > 0)
            EngineRunning = true;
    }

    public void EngineTurnOff()
    {
        EngineRunning = false;
    }

    public void DriveOneKm()
    {
        if (IsWithTrailer) {
            if (EngineRunning && FuelAmmount >= 0.25)
            {
                FuelAmmount -= 0.25;
            }
        } else
        {
            if (EngineRunning && FuelAmmount >= 0.35)
            {
                FuelAmmount -= 0.35;
            }
        }
    }
}
