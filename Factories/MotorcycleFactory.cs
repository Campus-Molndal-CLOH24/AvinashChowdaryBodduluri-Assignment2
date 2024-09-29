using AvinashChowdaryBodduluri_Assignment2.Interfaces;
using AvinashChowdaryBodduluri_Assignment2.Models;

namespace AvinashChowdaryBodduluri_Assignment2.Factories
{
    public class MotorcycleFactory : IVehicleFactory
    {
        private string brand;
        private string model;
        private int year;
        private double mileage;
        private string engineType;

        public MotorcycleFactory(string brand, string model, int year, double mileage, string engineType)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.engineType = engineType;
        }
        public IVehicle CreateVehicle()
        {
            return new MotorcycleImpl(brand, model, year, mileage, engineType);
        }
    }
}