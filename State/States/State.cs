using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public abstract class State: IState
    {
        protected Car Car;

        protected State(Car car)
        {
            this.Car = car;
        }

        public abstract void FillTank();
        public abstract void TurnKey();
        public abstract void Drive();
        public abstract void Stop();
    }
}
