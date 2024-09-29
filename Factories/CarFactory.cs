namespace AvinashChowdaryBodduluri_Assignment2.Factories      
{
    using AvinashChowdaryBodduluri_Assignment2.Interfaces;
    using AvinashChowdaryBodduluri_Assignment2.Models;

    public class CarFactory : IVehicleFactory
    {
        private string brand;
        private string model;
        private int year;
        private double mileage;
        private int doors;

        public CarFactory(string brand, string model, int year, double mileage, int doors)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.doors = doors;
        }   

        public IVehicle CreateVehicle()
        {
            return new CarImpl(brand, model, year, mileage, doors);
        }
    }
}