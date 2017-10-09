using ConsoleApplication1.Patterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.Visitor
{
    class OfficeBuilding : IElement
    {
        private readonly IList<Floor> _floors = new List<Floor>();

        //если нужно будет поменять алгоритм проверки мы изменим ElectricitySystemValidator но не текуший класс
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (Floor floor in _floors)
            {
                floor.Accept(visitor);
            }
        }
    }
}
