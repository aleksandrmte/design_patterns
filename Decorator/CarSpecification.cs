using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CarSpecification
    {
        protected string Name { get; set; }

        public string GetName()
        {
            return Name;
        }
        public abstract decimal GetPrice();
    }
}
