using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.State
{
    class NewOrder : OrderState
    {
        public NewOrder(Order order) : base(order)
        {
        }

        public override void AddProduct()
        {
            Console.WriteLine("AddProduct");
        }

        public override void Shipping()
        {
            Console.WriteLine("Shipping");
        }

        public override void Cancel()
        {
            Console.WriteLine("Cansel");
        }
    }
}
