using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CarWithSpoilerDecorator: CarSpecificationDecorator
    {
        public CarWithSpoilerDecorator(CarSpecification car) : base(car)
        {
            Name = car.GetName() + " with spoiler;";
        }

        public override decimal GetPrice()
        {
            return Car.GetPrice() + 200;
        }
    }
}
