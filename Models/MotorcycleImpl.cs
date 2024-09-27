using AvinashChowdaryBodduluri_Assignment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvinashChowdaryBodduluri_Assignment2.Models
{
    internal class MotorcycleImpl : IMotorcycle
    {
        public string EngineType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        private bool Engineon = false;

        public bool IsEngineOn()
        {
            return Engineon;
        }

        public void StartEngine()
        {
            Engineon = true;
            Console.WriteLine("Engine Started.");
        }

        public void StopEngine()
        {
            Engineon = false;
            Console.WriteLine("Engine turned off.");
        }
    }
}
