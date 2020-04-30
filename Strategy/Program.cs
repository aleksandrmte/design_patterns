using System;
using System.Collections.Generic;
using Strategy.Behavior;
using Strategy.Programmers;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProgrammerBase javaProgrammer = new SimpleJavaProgrammer(new DrinkCoffee(), new RestMovie());
            ProgrammerBase cppProgrammer = new SportsmanCppProgrammer(new DrinkCoffee(), new RestGym());

            var programmers = new List<ProgrammerBase>
            {
                javaProgrammer, cppProgrammer
            };

            foreach (var item in programmers)
            {
                item.WriteCode();
                item.SpeakEnglish();
                item.Drink();
                item.Rest();
                Console.WriteLine();
            }

            cppProgrammer.SetDrink(new DrinkTea());

            cppProgrammer.WriteCode();
            cppProgrammer.SpeakEnglish();
            cppProgrammer.Drink();
            cppProgrammer.Rest();
        }
    }
}
