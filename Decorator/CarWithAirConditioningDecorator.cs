using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CarWithAirConditioningDecorator: CarSpecificationDecorator
    {
        public CarWithAirConditioningDecorator(CarSpecification car): base(car)
        {
            Name = Car.GetName() + " with air conditioning;";
        }
        
        public override decimal GetPrice()
        {
            return Car.GetPrice() + 1200;
        }
    }
}
