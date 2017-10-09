using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class ExList
    {
        public static void Example()
        {
            List<int> list = new List<int>();
            IReadOnlyCollection<int> list2 = list.AsReadOnly();

            //list2.Add(2); -- cant do this

            list.Add(1);

            foreach (int i in list)
                Console.WriteLine(i);

            foreach (int i in list2)
                Console.WriteLine(i);
        }

        public static void Example2()
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 134217728; i++)
                list.Add(i);

            Console.WriteLine("ok");

            //list.Add(134217729); -- fail
            //2146435071;            
        }

        public static void Example3()
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(101);
            list.Add(11);
            list.Add(2);
            list.Add(20);
            list.Add(332);
            list.Add(3);

            Console.WriteLine(list.BinarySearch(3)); //returns -5, list should be sorted first      
        }

        public static void Example4()
        {
            List<int> list = new List<int>();//Capacity 0
            list.Add(1); //Capacity 4
            list.Add(101);
            list.Add(11);
            list.Add(2);
            list.Add(20);//Capacity 8
            list.Add(332);
            list.Add(3);
            Console.WriteLine(list.Capacity); //7 elements but capacity 8 !

            list.Add(3);
            list.Add(3);
            Console.WriteLine(list.Capacity); //16 !
        }

        public static void Example5()
        {
            List<int> list = new List<int>();
            list.Add(1);

            int[] mas = list.ToArray();
            list[0] = 2;

            Console.WriteLine(mas[0]); // 1 -list.ToArray() makes deep copy
        }

        public static void Example6()
        {
            List<int> list = new List<int>();
            list.Add(1);

            //list[3] = 4; - Out of range exeption
        }
    }

    class ExArrayList
    {
        public static void Example()
        {
            //capacity changing same as in List
            ArrayList list = new ArrayList();
            Console.WriteLine(list.Capacity);

            list.Add(1);
            Console.WriteLine(list.Capacity);

            list.Add(1);
            list.Add(1);
            list.Add(1);

            list.Add(1);
            Console.WriteLine(list.Capacity);

        }
    }
    }
