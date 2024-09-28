namespace AvinashChowdaryBodduluri_Assignment2.Interfaces
{

    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string brand, string model, int year, double mileage);
    }
}