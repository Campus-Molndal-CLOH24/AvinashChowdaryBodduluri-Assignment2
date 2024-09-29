namespace AvinashChowdaryBodduluri_Assignment2
{
    using AvinashChowdaryBodduluri_Assignment2.Interfaces;
    using AvinashChowdaryBodduluri_Assignment2.Factories;
    using AvinashChowdaryBodduluri_Assignment2.Models;
    using System.Security.Cryptography.X509Certificates;

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
            vehicles.Add(carFactory.CreateCar( "Honda", "Civic", 2021, 20000, 4));
            vehicles.Add(motorcycleFactory.CreateMotorcycle("Yamaha", "YZF-R1", 2020, 10000, "Inline-4"));
            vehicles.Add(carFactory.CreateCar("Ford", "Fiesta", 2018, 30000, 4));   
            vehicles.Add(motorcycleFactory.CreateMotorcycle("Kawasaki", "Ninja", 2017, 15000, "Parallel Twin"));

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine(vehicle);
                if(vehicle.IsEngineOn()==false)
                {
                    vehicle.StartEngine();
                }
                if(vehicle is IDriveable driveable)
                {
                    Console.WriteLine(driveable.Drive());
                }
                vehicle.StopEngine();
            }

            Console.ReadKey();
        }
    }
}
