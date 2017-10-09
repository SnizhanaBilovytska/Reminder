using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interesting
{
    class Predicate
    {
        public static void Example()
        {
            Predicate<Person> oscarFinder = (Person p) => { return p.Name == "Oscar"; };
            Predicate<Person> ruthFinder = (Person p) => { return p.Name == "Ruth"; };
            Predicate<Person> seventeenYearOldFinder = (Person p) => { return p.Age == 17; };

            List<Person> people = new List<Person>();
            people.Add(new Person() { Age = 18, Name = "Oscar" });
            people.Add(new Person() { Age = 18, Name = "Ruth" });
            people.Add(new Person() { Age = 17, Name = "Ivan" });
            people.Add(new Person() { Age = 17, Name = "Ivan2" });

            //Person oscar = people.Find(oscarFinder);
            //Console.WriteLine(oscar.Name);

            //Person ruth = people.Find(ruthFinder);
            //Console.WriteLine(ruth.Name);

            Person seventeenYearOld = people.Find(seventeenYearOldFinder);
            Console.WriteLine(seventeenYearOld.Name);// will find only Ivan

        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
