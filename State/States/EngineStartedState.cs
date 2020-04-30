using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class EngineStartedState: State
    {
        public EngineStartedState(Car car) : base(car)
        {
        }

        public override void FillTank()
        {
            Console.WriteLine("Куда заправляться? Мы ведь заведены.");
        }

        public override void TurnKey()
        {
            Console.WriteLine("Глушу двигатель.");
            Car.ChangeState(new FullTankState(Car));
        }

        public override void Drive()
        {
            TryDrive();
        }

        private void TryDrive()
        {
            if (Car.Gasoline > 0)
            {
                Console.WriteLine("Да да, мы едем, ты хочешь быстрее?");
                Car.SetGasolineValue(Car.Gasoline - 10);
                Car.ChangeState(new DrivingState(Car));
            }
            else
            {
                Console.WriteLine("Всё,бензин закончился");
                Car.ChangeState(new EmptyTankState(Car));
            }
        }

        public override void Stop()
        {
            Console.WriteLine("Мы и так стоим, хотя заведены.");
        }
    }
}
