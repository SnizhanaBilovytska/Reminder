using ConsoleApplication1.Patterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.Visitor
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
