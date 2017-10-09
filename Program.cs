using ConsoleApplication1.Collections;
using ConsoleApplication1.Interesting;
using ConsoleApplication1.Interesting;
using ConsoleApplication1.Interesting.DelegatesEvents;
using ConsoleApplication1.Interesting.Immutabl;
using ConsoleApplication1.Patterns.State;
using ConsoleApplication1.Patterns.Strategy;
using ConsoleApplication1.Patterns.Strategy.Interface;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Security;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {        
        public static void Main(string[] args)
        {
            Delegate0.Ex();

            //Console.WriteLine(int.Parse("1"));
            Console.ReadLine();
        }

        private static void A(Immutable imm)
        {
            imm = new Immutable(2);
            //Console.WriteLine("Task A");
        }
    }
}
