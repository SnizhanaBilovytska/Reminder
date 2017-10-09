using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    class GC_
    {
        public static void Example()
        {
            GC.SuppressFinalize(new object());
            GC.ReRegisterForFinalize(new object());
        }
    }
}
