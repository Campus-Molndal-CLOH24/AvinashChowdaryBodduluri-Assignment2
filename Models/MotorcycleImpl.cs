using AvinashChowdaryBodduluri_Assignment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvinashChowdaryBodduluri_Assignment2.Models
{
    internal class MotorcycleImpl : IMotorcycle, IDriveable
    {
        public required string EngineType { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        private bool EngineOn = false;

        public MotorcycleImpl(string brand, string model, int year, double mileage, string engineType)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Mileage = mileage;
            this.EngineType = engineType;
        }

        public bool IsEngineOn()
        {
            return EngineOn;
        }

        public void StartEngine()
        {
            EngineOn = true;
            Console.WriteLine("Engine Started.");
        }

        public void StopEngine()
        {
            EngineOn = false;
            Console.WriteLine("Engine turned off.");
        }

        public string Drive()
        {
            if (EngineOn)
            {
                return "Motorcycle is Driveable & Ready for ride.";
            }
            else
            {
                return "Engine is off, Start the engine first.";
            }
        }

        public override string ToString()
        {
            return $"Motorcycle: {Brand} {Model}({Year}) has Mileage {Mileage} on the clock and It's EngineType is {EngineType}.";
        }
    }
}
