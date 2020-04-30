using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Interfaces;

namespace Strategy.Programmers
{
    public abstract class ProgrammerBase
    {
        private IDrink _drink;
        private IRest _rest;

        protected ProgrammerBase(IDrink drink, IRest rest)
        {
            _drink = drink;
            _rest = rest;
        }

        public void SetDrink(IDrink drink)
        {
            _drink = drink;
        }

        public void SetRest(IRest rest)
        {
            _rest = rest;
        }

        public void Drink()
        {
            _drink.Drink();
        }

        public void Rest()
        {
            _rest.Rest();
        }

        public void SpeakEnglish()
        {
            Console.WriteLine("London is the capital of great Britain");
        }

        public abstract void WriteCode();
    }
}
