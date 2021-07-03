using System;
namespace Task1
{
    public class Motorcycle : IGroundVehicle
    {
        public VehicleData data;
        public Motorcycle(int maxSpeed)
        {
            data.maxSpeed = maxSpeed;
        }
        public void Drive()
            =>Console.WriteLine($"I am driving Motorcycle with max speed {data.maxSpeed}/h");
        public override string ToString()
            => $"Motorcycle data: \n{data}";
    }
}
