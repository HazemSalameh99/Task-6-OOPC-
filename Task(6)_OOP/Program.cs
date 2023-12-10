using System;

namespace Task_6__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW",2022,"BMW X5",30000, "Large Comfortable Family SUV","ABC123","Black");
            Console.WriteLine("Car Details:");
            Console.WriteLine(car.FullInformation());
            car.startEngine();
            car.stopEngine();
        }
    }
}
