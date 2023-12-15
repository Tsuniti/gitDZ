namespace gitDZ.vehicle;

public class Car : IVehicle
{
    public string Model { get; }
    public string Owner { get; set; }
    public double FuelAmmount { get; set; }
    private int NumberOfWheels { get; set; }
    private bool EngineRunning { get; set; }

    public Car(string model, string owner, double fuelAmmount, int numberOfWheels)
    {
        Model = model;
        Owner = owner;
        FuelAmmount = fuelAmmount;
        EngineRunning = false;
        NumberOfWheels = numberOfWheels;
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
        if (EngineRunning && FuelAmmount >= 0.06)
        {
            FuelAmmount -= 0.06;
        }
    }
}
