using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Collections
{
    class Queue
    {
        public static void Example()
        {
            Queue<int> q = new Queue<int>(4);
            q.Enqueue(1);
            Console.WriteLine(q.Peek());//q.Dequeue() - will read and delete item; Peek only read
        }
    }
}
