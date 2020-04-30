using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CarWithParkingSensorsDecorator: CarSpecificationDecorator
    {
        public CarWithParkingSensorsDecorator(CarSpecification car) : base(car)
        {
            Name = car.GetName() + " with parking sensors";
        }

        public override decimal GetPrice()
        {
            return Car.GetPrice() +  550;
        }
    }
}
