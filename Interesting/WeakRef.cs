using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    class WeakRef
    {
        public static void Example()
        {
            object obj = new object();
            WeakReference wr = new WeakReference(obj);
            // obj could be cleaned by GC in any time, but if it do'nt we will able to get strong ref

            if(wr.IsAlive)
                obj = wr.Target;
        }
    }
}
