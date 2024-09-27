using AvinashChowdaryBodduluri_Assignment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AvinashChowdaryBodduluri_Assignment2.Models
{
    internal class CarImpl : ICar, IDriveable
    {
        public int Doors { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        private bool engineOn = false;

        public CarImpl(string brand, string model, int year, double mileage, int doors) 
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Mileage = mileage;
            this.Doors = doors;
        }

        public string Drive()
        {
            if(engineOn)
            {
                return "Car is Driveable & Ready for ride.";
            }
            else
            {
                return "Engine is off, Start the engine first.";
            }
        }

        public bool IsEngineOn()
        {
            return engineOn;
        }

        public void StartEngine()
        {
            engineOn = true;
            Console.WriteLine("Engine Started.");
        }

        public void StopEngine()
        {
            engineOn = false;
            Console.WriteLine("Engine turned off.");

        }
        public override string ToString()
        {
            return $"Car: {Brand} {Model} ({Year}) with {Mileage} km on the clock and had {Doors} doors.";
        }

    }
}
