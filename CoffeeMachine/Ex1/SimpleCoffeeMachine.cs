using ConsoleApplication1.CoffeeMachine.Ex1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.CoffeeMachine.Ex1
{
    class SimpleCoffeeMachine : ICoffemachine
    {
        public void GetCoffee()
        {
            Console.WriteLine("Just cofee");
        }
    }
}
