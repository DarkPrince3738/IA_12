using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle Start");
        }
        public override void Stop()
        {
            Console.WriteLine("Motorcycle Stop");
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
