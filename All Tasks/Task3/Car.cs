using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Start");
        }
        public override void Stop()
        {
            Console.WriteLine("Car Stop");
        }
        /*public int weigth;
        public int height;
        public int width;
        public int price;
        public int maxSpeed;
        public void Start()
        {

        }
        public void Stop()
        {

        }*/
    }
}
