using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.State
{
    class OrderState
    {
        public Order _order;
        public OrderState(Order order)
        {
            _order = order;
        }
        public virtual void AddProduct()
        {
            OperationIsNotAllowed("AddProduct");
        }

        public virtual void Shipping()
        {
            OperationIsNotAllowed("Shipping");
        }

        public virtual void Cancel()
        {
            OperationIsNotAllowed("Cansel");
        }

        // Наступні методи (Register, Grant, Ship, Invoice, Cancel) виглядають так само
        private void OperationIsNotAllowed(string operationName)
        {
            Console.WriteLine("Operation {0} is not allowed for Order's state {1}",
            operationName, this.GetType().Name);
        }
    }
}
