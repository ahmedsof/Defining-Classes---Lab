using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car("Skoda", "Ostavia", 2012);
            Engine engine = new Engine(104, 1900);
            Tire[] tire = new Tire[]
            {
                new Tire(2008,1500),
                new Tire(2008,1500),
                new Tire(2008,1500),
                new Tire(2008,1500)
            };
            car.FuelConsumption = 5.5;
            car.FuelQuantity = 900;

            car.Drive(100);
            car.Drive(50);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
