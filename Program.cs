using AvinashChowdaryBodduluri_Assignment2.Factories;

namespace AvinashChowdaryBodduluri_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the specific factories
            CarFactory carFactory = new CarFactory();
            MotorcycleFactory motorcycleFactory = new MotorcycleFactory();

            // Create a car using the CarFactory
            var car = carFactory.CreateCar("Toyota", "Corolla", 2020, 15000, 4);
            Console.WriteLine(car);
            car.StartEngine();
            Console.WriteLine("Car engine status: " + (car.IsEngineOn() ? "On" : "Off"));
            car.StopEngine();
            Console.WriteLine("Car engine status: " + (car.IsEngineOn() ? "On" : "Off"));
            Console.WriteLine("Car doors: " + car.Doors);
            car.Doors = 5;
            Console.WriteLine("Car doors: " + car.Doors);

            // Create a motorcycle using the MotorcycleFactory
            var motorcycle = motorcycleFactory.CreateMotorcycle("Harley Davidson", "Sportster", 2019, 5000, "V-Twin");
            Console.WriteLine(motorcycle);
            motorcycle.StartEngine();
            Console.WriteLine("Motorcycle engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));
            motorcycle.StopEngine();
            Console.WriteLine("Motorcycle engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));
            Console.WriteLine("Motorcycle engine type: " + motorcycle.EngineType);
            motorcycle.EngineType = "Inline-4";
            Console.WriteLine("Motorcycle engine type: " + motorcycle.EngineType);
        }
    }
}
