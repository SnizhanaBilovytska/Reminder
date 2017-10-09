using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    public class Params
    {
        public static void Example()
        {
            Example2();
            Example2("");
            Example2("1", "2", "3");
        }

        public static void Example2(params string[] a)
        {

        }
    }
}
