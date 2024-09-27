namespace AvinashChowdaryBodduluri_Assignment2.Interfaces   
{
    public interface ICar : IVehicle, IDriveable
    {
        int Doors { get; set; }
    }
}