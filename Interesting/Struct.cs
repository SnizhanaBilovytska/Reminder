using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    struct Struct: IEnumerable
    {
        public static int A { get; set; }

        public MySuperClass MyClass { get; set; }

        static Struct()
        {
            //компилятор не вызывает статический конструктор в значимых типах
        }

        public Struct(int a)//обязательно должен инициализировать поля значимого типа
        {
            A = a;
            MyClass = new MySuperClass();//нужно инициализировать все поля
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }  
    
    class MySuperClass
    {
        void Ex()
        {
            IEnumerable e = new Struct();// упаковка структурыб переменная интерфейса всегда ссылка
        }
    } 
}
