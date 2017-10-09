using ConsoleApplication1.Patterns.Visitor.Interfaces;
using System;

namespace ConsoleApplication1.Patterns.Visitor
{
    class ElectricitySystemValidator : IVisitor
    {
        public void Visit(OfficeBuilding building)
        {
            //do some algorithm
            Console.WriteLine("OfficeBuilding visit");
        }
        public void Visit(Floor floor)
        {
            //do some algorithm
            Console.WriteLine("Floor visit");
        }
        public void Visit(Room room)
        {
            //do some algorithm
            Console.WriteLine("Room visit");
        }
    }
}
