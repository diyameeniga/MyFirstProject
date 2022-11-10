using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    class Person
    {
        public string Name { get; set; }

        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public static List<Person> getNames()
        {
            return new List<Person>
            {
                new Person("Sunday"),
                new Person("Monday"),
                new Person("Toosday"),
                new Person("Wednesday"),
                new Person("Thursday"),
                new Person("Friday"),
                new Person("Saturday"),
                
             /*   new Person("Loks Mareddee"),
                new Person("Ani Vadayar"),
                new Person("Divvy Kotakota"),
                new Person("Illia MyKing"),
                new Person("Justinian Lopato"), */
            };
        }

    }
}
