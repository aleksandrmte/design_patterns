using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.States;

namespace State
{
    public class Car
    {
        public int Gasoline { get; private set; }
       

        private IState _state;

        public Car()
        {
            _state = new EmptyTankState(this);
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }

        public void SetGasolineValue(int gasoline)
        {
            Gasoline = gasoline;
        }

        public void FillTank()
        {
            _state.FillTank();
        }

        public void TurnKey()
        {
            _state.TurnKey();
        }

        public void Drive()
        {
            _state.Drive();
        }

        public void Stop()
        {
            _state.Stop();
        }
    }
}
