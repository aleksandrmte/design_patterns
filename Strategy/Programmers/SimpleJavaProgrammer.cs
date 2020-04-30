using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Behavior;
using Strategy.Interfaces;

namespace Strategy.Programmers
{
    public class SimpleJavaProgrammer: ProgrammerBase
    {
        public SimpleJavaProgrammer(IDrink drink, IRest rest) : base(drink, rest)
        {
            
        }

        public override void WriteCode()
        {
            Console.WriteLine("Программирую на Java");
        }
    }
}
