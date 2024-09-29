namespace AvinashChowdaryBodduluri_Assignment2.Factories      
{
    using AvinashChowdaryBodduluri_Assignment2.Interfaces;
    using AvinashChowdaryBodduluri_Assignment2.Models;

    public class CarFactory : IVehicleFactory
    {
        private string brand { get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private double mileage { get; set; }
        private int doors { get; set; }

        public CarFactory(string brand, string model, int year, double mileage, int doors)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.doors = doors;
        }
        //Implementing the CreateVehicle method from the IVehicleFactory interface as required.
        public IVehicle CreateVehicle()
        {
            return CreateCar();
        }
        //Implementing the CreateCar method to create a new CarImpl object as per assignment.
        public CarImpl CreateCar()
        {
            return new CarImpl(brand, model, year, mileage, doors);
        }
    }
}