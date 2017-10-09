using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.Visitor.Interfaces
{
    //Однією із переваг патерну є те, що він відоклемлює алгоритм від елементів, до яких він має бути застосований
    interface IVisitor
    {
        void Visit(OfficeBuilding building);
        void Visit(Floor floor);
        void Visit(Room room);
    }
}
