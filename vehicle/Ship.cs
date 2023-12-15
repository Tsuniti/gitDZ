namespace gitDZ.vehicle;

internal class Ship : IVehicle
{
    public string Model { get; }
    public string Owner { get; set; }
    public double FuelAmmount { get; set; }
    private bool EngineRunning { get; set; }
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
        if (EngineRunning && FuelAmmount >= 0.5)
        {
            FuelAmmount -= 0.5;
        }
    }
}
