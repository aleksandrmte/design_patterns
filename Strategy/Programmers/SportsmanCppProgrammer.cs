using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Interfaces;

namespace Strategy.Programmers
{
    public class SportsmanCppProgrammer: ProgrammerBase
    {
        public SportsmanCppProgrammer(IDrink drink, IRest rest) : base(drink, rest)
        {
        }

        public override void WriteCode()
        {
            Console.WriteLine("Программирую на C++");
        }
    }
}
