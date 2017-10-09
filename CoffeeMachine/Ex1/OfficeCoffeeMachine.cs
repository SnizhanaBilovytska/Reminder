using ConsoleApplication1.CoffeeMachine.Ex1;
using ConsoleApplication1.CoffeeMachine.Ex1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CoffeeMachine
{
    class OfficeCoffeeMachine : SimpleCoffeeMachine
    {
        public void GetLatte()
        {
            //base.GetCoffee() + GetMilk();
        }

        public void GetAmericano()
        {
           //base.GetCoffee() + GetVater();
        }

        public void GetEspresso()
        {
            base.GetCoffee();
        }

        protected void GetMilk()
        {

        }

        protected void GetVater()
        {

        }
    }
}
