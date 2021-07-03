using System;

namespace Task1
{
    public class Car : IGroundVehicle
    {
        public VehicleData data;
        public Car(int maxSpeed)
        {
            data.weigth = Program.rand.Next(10, 20);
            data.maxSpeed = maxSpeed;
        }
        public void Drive()
            => Console.WriteLine($"I am driving Car with max speed {data.maxSpeed}/h with weight {data.weigth} tonns");
        public override string ToString()
            => $"Car data: \n{data}";
    }
}
