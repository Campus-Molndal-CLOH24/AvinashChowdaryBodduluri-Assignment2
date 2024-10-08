﻿using AvinashChowdaryBodduluri_Assignment2.Interfaces;
using AvinashChowdaryBodduluri_Assignment2.Models;

namespace AvinashChowdaryBodduluri_Assignment2.Factories
{
    public class MotorcycleFactory : IVehicleFactory
    {
        private string brand { get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private double mileage { get; set; }
        private string engineType { get; set; }

        public MotorcycleFactory(string brand, string model, int year, double mileage, string engineType)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.engineType = engineType;
        }
        //Implementing the CreateVehicle method from the IVehicleFactory interface as required.
        public IVehicle CreateVehicle()
        {
            return CreateMotorcycle();
        }
        //Implementing the CreateCar method to create a new CarImpl object as per assignment.
        public MotorcycleImpl CreateMotorcycle()
        {
            return new MotorcycleImpl(brand, model, year, mileage, engineType);
        }
    }
}