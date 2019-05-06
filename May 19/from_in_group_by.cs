using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// This is a little program about from_in_group_by  keyword..
/// </summary>


namespace From_in_group_by
{

    class Person {
        public string name { get; set; }
        public int age { get; set; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { name = "dengweihao", age = 18 });
            persons.Add(new Person() { name = "huangguobing", age = 18 });
            persons.Add(new Person() { name = "zengmaosheng", age = 19 });
            persons.Add(new Person() { name = "shaziai", age = 19 });

            //get type of IEnumerable<IGrouping<*,*>>
            //in this case groups is IEnumerable<IGrouping<int,string>> 
            var groups = from person in persons group person.name by person.age;

            //Select(format parameter => (some conditionjudgment or operator which returns some value))
            foreach (var group in groups) {
                Console.WriteLine($"{group.Key},{group.Select(id => id).ToList()[0]},{group.Select(id=>id).ToList()[1]}");
            }

            Console.ReadLine();
        }
    }
}
