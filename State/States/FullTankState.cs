using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class FullTankState: State
    {
        public FullTankState(Car car) : base(car)
        {
        }

        public override void FillTank()
        {
            Console.WriteLine("У нас и так полный бак.");
        }

        public override void TurnKey()
        {
            Console.WriteLine("Ок, завожу двигатель");
            Car.ChangeState(new EngineStartedState(Car));
        }

        public override void Drive()
        {
            Console.WriteLine("Для начала надо завести двигатель");
        }

        public override void Stop()
        {
            Console.WriteLine("А мы ведь никуда и не едем.");
        }
    }
}
