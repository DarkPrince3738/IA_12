using System;

namespace Task1
{   
    class Program
    {
        public static Random rand = new Random(); //лучше так не делать
        static void Main(string[] args)
        {
            IGroundVehicle[] vehicles = new IGroundVehicle[] {new Motorcycle(100), new Car(20), new Bicycle(), new Bus(), new Truck(), new Plane()};
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                vehicle.Drive();
                (vehicle as IFlyVehicle)?.Fly();
                Console.WriteLine();
            }
        }
    }
}
