using ConsoleApplication1.Patterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.Visitor
{
    class Floor : IElement
    {
        private readonly IList<Room> _rooms = new List<Room>();

        //если нужно будет поменять алгоритм проверки мы изменим ElectricitySystemValidator но не текуший класс
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var room in _rooms)
            {
                room.Accept(visitor);
            }
        }
    }
}
