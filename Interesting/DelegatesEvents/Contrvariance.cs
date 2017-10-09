using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting.DelegatesEvents
{
    class Contrvariance
    {
        public static void Ex()
        {
            Action<string> actString = SetObject;

            actString("");//cannot pass object type -- CONTVARIANCE
        }

        public static void SetObject(object obj)
        {
        }
    }
}
