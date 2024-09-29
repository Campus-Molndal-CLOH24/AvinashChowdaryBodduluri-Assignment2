namespace AvinashChowdaryBodduluri_Assignment2
{
    using AvinashChowdaryBodduluri_Assignment2.Interfaces;
    using AvinashChowdaryBodduluri_Assignment2.Factories;
    using AvinashChowdaryBodduluri_Assignment2.Models;
    using System.Security.Cryptography.X509Certificates;
    using System.ComponentModel;

    internal class Program
    {
        static void Main()
        {
            // Create a list of IVehicle objects    
            List<IVehicle> vehicles = new List<IVehicle>();

            // Instantiate the specific factories
            CarFactory car1 = new CarFactory("Toyota", "Corolla", 2020, 15000, 4);
            MotorcycleFactory motorcycle1 = new MotorcycleFactory("Harley Davidson", "Sportster", 2019, 5000, "V-Twin");
            CarFactory car2 = new CarFactory("Chevrolet", "Camaro", 2018, 20000, 2);
            MotorcycleFactory motorcycle2 = new MotorcycleFactory("Ducati", "Panigale", 2017, 10000, "V4");
            CarFactory car3 = new CarFactory("Honda", "Civic", 2016, 25000, 4);
            MotorcycleFactory motorcycle3 = new MotorcycleFactory("Suzuki", "GSX-R1000", 2015, 15000, "Inline-4");

            //Adding vehicles to List
            vehicles.Add(car1.CreateCar());
            vehicles.Add(motorcycle1.CreateMotorcycle());
            vehicles.Add(car2.CreateCar());
            vehicles.Add(motorcycle2.CreateMotorcycle());
            vehicles.Add(car3.CreateCar());
            vehicles.Add(motorcycle3.CreateMotorcycle());


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
                    //Execute Drive method based on the vehicle type
                    Console.WriteLine(driveable.Drive());
                }
                vehicle.StopEngine();
                Console.WriteLine();
            }
            //This is to keep the console window open until a key is pressed.
            Console.ReadKey();
        }
    }
}
