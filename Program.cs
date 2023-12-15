// See https://aka.ms/new-console-template for more information
using gitDZ.vehicle;


Car car = new Car("Toyota Corolla", "Vasya", 30, 4);

car.EngineTurnOn();
car.DriveOneKm();
car.DriveOneKm();

Console.WriteLine(car.FuelAmmount);