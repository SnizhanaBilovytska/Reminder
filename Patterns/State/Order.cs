using ConsoleApplication1.Patterns.State.OrdersState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.State
{
    class Order
    {
        private OrderState _state;
        // private List<Product> _products = new List<Product>();
        public Order()
        {
            _state = new NewOrder(this);
        }

        private void SetOrderState(OrderState state)
        {
            _state = state;
        }

        public void AddProduct()
        {
            //do job
            _state.AddProduct();
        }

        public void Shipping()
        {
            //do job
            _state.Shipping();
            SetOrderState(new Shipped(this));
        }

        public void Cancel()
        {
            //do job
            _state.Cancel();
            SetOrderState(new Canceled(this));
        }

        public void WriteCurrentStateName()
        {
            Console.WriteLine("Current Order's state: {0}", _state.GetType().Name);
        }
    }
}
