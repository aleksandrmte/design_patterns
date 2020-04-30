using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Interfaces;

namespace Strategy.Behavior
{
    public class DrinkCoffee: IDrink
    {
        public void Drink()
        {
            Console.WriteLine("Я пью кофе");
        }
    }
}
