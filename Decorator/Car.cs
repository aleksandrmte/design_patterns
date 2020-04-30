using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Car: CarSpecification
    {
        protected decimal Price { get; set; }

        public Car(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        
        public override decimal GetPrice()
        {
            return Price;
        }
    }
}
