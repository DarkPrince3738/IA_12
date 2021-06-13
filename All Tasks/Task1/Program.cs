using System;

namespace Task1
{
    /*Task1​
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application, назвіть його Lesson011_Task1.​
    1) Створіть класи Car, Truck, Bus, Motorcycle, Bicycle, Plane у них створіть ​
    поля weight, height, width, price, maxSpeed,​
    і методи Start, Stop, які просто виводять на екран відповідну інформацію.​
    2)  Створіть базовий клас Vehicle і класи нащадки Car, Truck, Bus, Motorcycle, Bicycle, Plane, ​
    у батьківському класі створіть поля weight, height, width, price, maxSpeed, і методи Start, Stop, які просто виводять на екран відповідну інформацію.​*/
    
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.weigth = int.Parse(Console.ReadLine());
            car.height = int.Parse(Console.ReadLine());
            Console.WriteLine($"{car.weigth}, {car.height}");
        }
    }
}
