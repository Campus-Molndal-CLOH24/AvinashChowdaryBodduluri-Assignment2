namespace AvinashChowdaryBodduluri_Assignment2
{
    using AvinashChowdaryBodduluri_Assignment2.Interfaces;
    using AvinashChowdaryBodduluri_Assignment2.Factories;
    using AvinashChowdaryBodduluri_Assignment2.Models;
    internal class Program
    {
        static void Main()
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            // Instantiate the specific factories
            CarFactory carFactory = new CarFactory();
            MotorcycleFactory motorcycleFactory = new MotorcycleFactory();

            vehicles.Add(carFactory.CreateCar("Toyota", "Corolla", 2020, 15000, 4));
            vehicles.Add(motorcycleFactory.CreateMotorcycle("Harley Davidson", "Sportster", 2019, 5000, "V-Twin"));

            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                if(vehicle.IsEngineOn()==false)
                {
                    vehicle.StartEngine();
                }
                //Console.WriteLine("Vehicle engine status: " + (vehicle.IsEngineOn() ? "On" : "Off"));
                //vehicle.StartEngine();
                if(vehicle is IDriveable driveable)
                {
                    Console.WriteLine(driveable.Drive());
                }
                vehicle.StopEngine();
                //Console.WriteLine("Vehicle engine status: " + (vehicle.IsEngineOn() ? "On" : "Off"));
            }

            Console.ReadKey();
        }
    }
}
