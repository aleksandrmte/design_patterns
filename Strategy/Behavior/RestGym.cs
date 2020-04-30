using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Interfaces;

namespace Strategy.Behavior
{
    public class RestGym: IRest
    {
        public void Rest()
        {
            Console.WriteLine("Вечером хожу в спортзал");
        }
    }
}
