using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var car = new Car("Nissan p10", 5000);
            var upgradedCar = new CarWithParkingSensorsDecorator(new CarWithAirConditioningDecorator(new CarWithAbsDecorator(car)));
            var fullUpgradedCar = new CarWithSpoilerDecorator(new CarWithParkingSensorsDecorator(new CarWithAirConditioningDecorator(new CarWithAbsDecorator(car))));

            Console.WriteLine($"Simple car: {car.GetName()} {car.GetPrice()}$");
            Console.WriteLine($"Upgraded car: {upgradedCar.GetName()} {upgradedCar.GetPrice()}$");
            Console.WriteLine($"Full upgraded car: {fullUpgradedCar.GetName()} {fullUpgradedCar.GetPrice()}$");

            Console.ReadKey();
        }
    }
}
