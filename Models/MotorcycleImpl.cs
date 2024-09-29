namespace AvinashChowdaryBodduluri_Assignment2.Models
{
    using AvinashChowdaryBodduluri_Assignment2.Interfaces;
    public class MotorcycleImpl : IMotorcycle, IDriveable
    {
        public string EngineType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
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
            Console.WriteLine("Motorcyle Engine Started.");
        }

        public void StopEngine()
        {
            EngineOn = false;
            Console.WriteLine("Motorcycle Engine turned off.");
        }

        public string Drive()
        {
            if (EngineOn)
            {
                //Increase the mileage by 5 miles when called the Drive method.
                Mileage += 5;
                return "Motorcycle is Driveable & Ready for ride. Went on for ride of 5 Miles.";
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
