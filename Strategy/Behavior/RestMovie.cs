using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Interfaces;

namespace Strategy.Behavior
{
    public class RestMovie: IRest
    {
        public void Rest()
        {
            Console.WriteLine("Вечером смотрю кино.");
        }
    }
}
