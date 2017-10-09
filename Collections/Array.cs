using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1.Collections
{
    class Array0
    {
        public static void Example()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int index = Array.BinarySearch(list.ToArray(), 3);
            Console.WriteLine(index);//return 2
        }

        public static void Example2()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int index = Array.BinarySearch(list.ToArray(), 3);
            Console.WriteLine(index);//return 2
        }

        public static void Example3()
        {
            //byte[] list = new byte[1073800000];
            int[] list = new int[260000000]; // array could hol 8 Gigabyte data

            Console.WriteLine("ok");    
        }

        public static void Example4()
        {
            int[][] jagged = new int[1][];
            jagged[0]= new int[4];
            jagged[0][3] = 5;

            Console.WriteLine(jagged[0][3]);
        }

        public static void Example5()
        {
            int[,] dimention2 = new int[1,1];
            dimention2[0,0] = 1;

            Console.WriteLine(dimention2[0, 0]);
        }
    }

    class Array1 : IList
    {
        public int Age { get; set; }
        public string Name { get; set; }
        private int[] _values = { 1 };

        // you may call now  
        //Array p = new Array();
        //Console.WriteLine(p[0]);
        public object this[int index]
        {
            get
            {
                return _values[index];
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsFixedSize
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
