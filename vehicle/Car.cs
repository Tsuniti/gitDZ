using System.Xml.Schema;

namespace gitDZ.vehicle;

public class Car : IVehicle
{
    public string Model { get; }
    private string Owner { get; set; }
    private double FuelAmmount { get; set; }
    public bool IsEngineRunning { get; set; }

    public Car(string model, string owner, double fuelAmmount)
    {
        Model = model;
        Owner = owner;
        FuelAmmount = fuelAmmount;
        IsEngineRunning = false;
    }

    public void EngineTurnOn()
    {
        if (FuelAmmount > 0)
            IsEngineRunning = true;
    }

    public void EngineTurnOff()
    {
        IsEngineRunning = false;
    }
}
