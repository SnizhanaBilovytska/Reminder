using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Patterns.TemplateMethod
{
    //шаблонный метод
    class MessageSearcher
    {
        public void Search()
        {
            DoSomething();
            DoSomething1();
            DoSomething2();
        }

        protected virtual void DoSomething()
        {

        }

        protected virtual void DoSomething1()
        {

        }

        protected virtual void DoSomething2()
        {

        }
    }
}
