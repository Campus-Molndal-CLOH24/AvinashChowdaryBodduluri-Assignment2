using AvinashChowdaryBodduluri_Assignment2.Interfaces;
using AvinashChowdaryBodduluri_Assignment2.Models;

namespace AvinashChowdaryBodduluri_Assignment2.Factories
{
    public class MotorcycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
        {
            string engineType = "unknown";
            return new MotorcycleImpl(brand, model, year, mileage, engineType);
        }

        public MotorcycleImpl CreateMotorcycle(string brand, string model, int year, double mileage, string engineType)
        {
            return new MotorcycleImpl(brand, model, year, mileage, engineType);
        }
    }
}