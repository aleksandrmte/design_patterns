using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CarSpecificationDecorator: CarSpecification
    {
        protected CarSpecification Car;
        
        public CarSpecificationDecorator(CarSpecification car)
        {
            Car = car;
            Name = car.GetName();
        }
        
        public override decimal GetPrice()
        {
            return Car.GetPrice();
        }
    }
}
