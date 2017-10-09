using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.State.OrdersState
{
    class Shipped : OrderState
    {
        public Shipped(Order order) : base(order)
        {
        }        

        public override void Shipping()
        {
            Console.WriteLine("Shipping");
        }
    }
}
