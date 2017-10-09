using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Collections
{
    class LinkedList
    {
        public static void Example()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            LinkedListNode<int> l = list.Find(2);

            Console.WriteLine(l.Value);

            foreach(int i in list)
            Console.WriteLine(i);

            //cant do list.Add(3); 
            //cant do list[3]; 
        }
    }

    class LinkedListNode
    {
        public static void Example()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(21);
            list2.AddLast(22);
            list2.AddLast(23);           
        }        
    }
}
