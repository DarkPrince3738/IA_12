using System;

namespace Task1
{
    public class Bicycle : IGroundVehicle
    {
        public VehicleData data;
        public Bicycle()
        {
            data.weigth = Program.rand.Next(10, 20);
            data.maxSpeed = 15;
        }
        public void Drive()
            => Console.WriteLine($"I am driving Bicycle with max speed {data.maxSpeed}/h with weight {data.weigth} kg");
        public override string ToString()
            => $"Bicycle data: \n{data}";
    }
}
