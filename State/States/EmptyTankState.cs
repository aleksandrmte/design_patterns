using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class EmptyTankState: State
    {
        public EmptyTankState(Car car) : base(car)
        {
        }
        
        public override void FillTank()
        {
            Car.SetGasolineValue(70);
            Console.WriteLine("Теперь мы заправились.");
            Car.ChangeState(new FullTankState(Car));
        }

        public override void TurnKey()
        {
            Console.WriteLine("Мы не заведены. Да и бензина нет.");
        }

        public override void Drive()
        {
            Console.WriteLine("Мы не заведены, да и бензина нет, так что не поедем.");
        }

        public override void Stop()
        {
            Console.WriteLine("Мы и так стоим. Да ещё и с пустым баком.");
        }
    }
}
