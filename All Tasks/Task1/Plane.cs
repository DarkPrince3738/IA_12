using System;

namespace Task1
{
    class Plane : IGroundVehicle, IFlyVehicle
    {
        public VehicleData data;
        public void Drive()
            => Console.WriteLine($"I am driving {GetType()}");

        public void Fly()
            => Console.WriteLine($"I am flying!");

        public override string ToString()
            => $"Plane data: \n{data}";
    }
}
