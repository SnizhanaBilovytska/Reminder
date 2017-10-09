using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    class StringBuilde
    {
        public static void Ex()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(sb.Capacity);//16

            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");
            sb.Append("1");//17й элемент
            Console.WriteLine(sb.Capacity);//32
        }
    }
}
