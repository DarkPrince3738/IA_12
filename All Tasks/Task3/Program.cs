using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new Vehicle [6];
            vehicle[0] = new Bicycle();
            vehicle[1] = new Bus();
            vehicle[2] = new Car();
            vehicle[3] = new Motorcycle();
            vehicle[4] = new Plane();
            vehicle[5] = new Truck();
            for(int i = 0; i < vehicle.Length; i++)
            {
                vehicle[i].Start();
                vehicle[i].Stop();
            }
        }
    }
}
