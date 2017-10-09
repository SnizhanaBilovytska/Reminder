using ConsoleApplication1.Patterns.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.Strategy
{
    class Latte : ICoffee
    {
        public void GetCoffee()
        {
            Console.WriteLine("get cofee");
            Console.WriteLine("get milk");
        }
    }
}
