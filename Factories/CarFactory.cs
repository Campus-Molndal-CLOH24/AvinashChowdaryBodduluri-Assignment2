namespace AvinashChowdaryBodduluri_Assignment2.Factories      
{
    using AvinashChowdaryBodduluri_Assignment2.Interfaces;
    using AvinashChowdaryBodduluri_Assignment2.Models;

    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
        {
            int doors = 4;
            return new CarImpl(brand, model, year, mileage, doors);
        }

        public CarImpl CreateCar(string brand, string model, int year, double mileage, int doors)
        {
            return new CarImpl(brand, model, year, mileage, doors);
        }
    }
}