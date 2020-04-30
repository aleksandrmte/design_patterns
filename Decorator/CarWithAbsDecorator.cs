using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CarWithAbsDecorator: CarSpecificationDecorator
    {
        public CarWithAbsDecorator(CarSpecification car): base(car)
        {
            Name = Car.GetName() + " with abs;";
        }

        public override decimal GetPrice()
        {
            return Car.GetPrice() + 1500;
        }
    }
}
