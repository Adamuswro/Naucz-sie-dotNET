using System;
using System.Collections.Generic;
using System.Linq;
namespace _7LINQ
{
    //All classes should be placed in seperated files, but beacouse code is very simple it was decided to keep it in one file.
    class Program7
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
        {
            new Person("Marek", "Marecki", 41),
            new Person("Wojtek", "Wojciechowski", 22),
            new Person("Maciej", "Maciejewski", 21),
            new Person("Kajetan","Kajetanowicz", 19 ),
            new Person("Darek","Darecki", 49 ),
            new Person("Michał","Michałowski", 51 ),
            new Person("Grzegorz","Grzegorzewski", 19),
            new Person("Andrzej","Andrzejewski", 18),
            new Person("Marcin","Marcinkiewicz", 58 ),
            new Person("Jan","Janowski", 58),
            new Person("Paweł","Pawelski", 84 ),
            new Person("Zbigniew","Hołdys", 19 ),
        };

            //Napisz LINQ które zwróci osoby których nazwisko rozpoczyna się na literę M
            var people1 = people.Where(p => p.LastName.StartsWith("M"));
            Console.WriteLine("Ilość osób których nazwisko rozpoczyna się na literę M wynosi:  " + people1.Count());
            Console.WriteLine($"{String.Join(", ", people1.Select(p=>p.FullName))}");
            
            //Napisz LINQ które zwróci pierwszą osobę starszą niż 40 lat ze zbioru posegregowanego odwrotnie alfabetycznie (Z -> A) wg. imienia

            var person2 = people.Where(p=>p.Age>40).OrderByDescending(p => p.FirstName).FirstOrDefault();

            Console.WriteLine("Pierwsza osoba powyżej 40 lat to: " + person2.ToString());

            Console.ReadLine();
        }

    }
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public int Age { get; set; }

        //nadpisz metodę ToString() dla klasy Person która będzie zwracać Imię.
        public override string ToString()
        {
            return FirstName;
        }
    }
}
