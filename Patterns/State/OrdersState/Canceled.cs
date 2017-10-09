using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.State.OrdersState
{
    class Canceled : OrderState
    {
        public Canceled(Order order) : base(order)
        {
        }

        public override void Cancel()
        {
            Console.WriteLine("Cansel");
        }
    }
}
