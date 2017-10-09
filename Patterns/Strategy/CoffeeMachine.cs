using ConsoleApplication1.Patterns.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.Strategy
{
    class CoffeeMachine
    {
        ICoffee _coffee;

        public void SetCoffee(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public void MakeCoffee()
        {
            if (_coffee != null)
                _coffee.GetCoffee();
        }
    }
}
