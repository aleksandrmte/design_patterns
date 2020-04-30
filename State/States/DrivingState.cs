using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class DrivingState: State
    {
        public DrivingState(Car car) : base(car)
        {
        }
      
        public override void FillTank()
        {
            Console.WriteLine("Ну и как мы будем заправляться на ходу? Успокойся");
        }

        public override void TurnKey()
        {
            Console.WriteLine("На ходу не надо крутить ключ.");
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
            }
            else
            {
                Console.WriteLine("Всё,бензин закончился");
                Car.ChangeState(new EmptyTankState(Car));
            }
        }

        public override void Stop()
        {
            Console.WriteLine("Всё? Хорошо, паркуемся у обочины.");
            Car.ChangeState(new EngineStartedState(Car));
        }
    }
}
