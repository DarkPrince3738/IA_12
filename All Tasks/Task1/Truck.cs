using System;

namespace Task1
{
    public class Truck : IGroundVehicle
    {
        public VehicleData data;
        public void Drive()
            => Console.WriteLine($"I am driving {GetType()}");
        public override string ToString()
            => $"Truck data: \n{data}";
    }
}
