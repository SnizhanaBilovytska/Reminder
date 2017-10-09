using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting.Immutabl
{
    public class Immutable
    {
        public int i { get; private set; }

        public Immutable(int i)
        {
            this.i = i;
        }

        private int[] arr = new int[100];

        // индексатор
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }        
    }

}
