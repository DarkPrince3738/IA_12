using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        public int weigth;
        public int height;
        public int width;
        public int price;
        public int maxSpeed;
        public virtual void Start()
        {
            Console.WriteLine("Vehicle Start");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle Stop");
        }
    }
}
