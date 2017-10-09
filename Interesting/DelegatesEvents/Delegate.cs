using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting.DelegatesEvents
{
    //A delegate is a type that represents references to methods with
    class Delegate0
    {
        //в делегат можно запихнуть ссылку на метод и передать куда угодно, даже ткда где мы не можем вызвать этот метод
        delegate int myDel();

        //static delegate int myDel(); не может быть статическим

        public static void Ex()
        {
            myDel myDel = new myDel(Ex2);
            myDel += new myDel(Ex3);
            myDel += new myDel(Ex4);

            myDel.Invoke();//2 3 4
            Console.WriteLine(myDel.Invoke());// 2 3 4 4
        }

        private static int Ex2()
        {
            Console.WriteLine(2);
            return 2;
        }
        private static int Ex3()
        {
            Console.WriteLine(3);
            return 3;
        }
        private static int Ex4()
        {
            Console.WriteLine(4);
            return 4;
        }
    }
}
