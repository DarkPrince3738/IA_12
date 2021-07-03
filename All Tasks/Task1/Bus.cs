using System;

namespace Task1
{
    public class Bus : IGroundVehicle
    {
        public VehicleData data;
        public void Drive()
            => Console.WriteLine($"I am driving {GetType()}");
        public override string ToString()
            => $"Bus data: \n{data}";
    }
}
