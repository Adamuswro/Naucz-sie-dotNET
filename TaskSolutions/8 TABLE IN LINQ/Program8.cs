using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _8TableInLINQ
{
    //All classes should be placed in seperated files, but beacouse code is very simple it was decided to keep it in one file.
    class Program8
    {
        static void Main(string[] args)
        {
            var fields = new string[]
            {
                "Nursing", "Psychology", "Biology", "Engineering", "Education", "Communications", "Finance and Accounting", "Criminal Justice", "Anthropology and Sociology"
            };

            var studentsGenerator = new Faker<Student>()
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.LastName, f => f.Name.LastName())
                .RuleFor(o => o.FieldOfStudy, f => f.PickRandom(fields))
                .RuleFor(o => o.SemestrNumber, f => f.Random.Int(1, 10));

            var testStudentsRepository = studentsGenerator.Generate(50);
            Console.WriteLine($"All students({testStudentsRepository.Count()}):{Environment.NewLine}{String.Join($"{Environment.NewLine}", testStudentsRepository)}{Environment.NewLine}");

            var result = new List<Student>();
            try
            {
                result = Paginate<Student>(testStudentsRepository, -4, 0);
                Console.WriteLine($"{Environment.NewLine}Paginated data: {String.Join($"{Environment.NewLine}", result)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public static List<T> Paginate<T>(List<T> source, int pageNumber, int numberOfElements)
        {
            int howManySkip = (pageNumber - 1) * numberOfElements;

            return source.
                Skip(howManySkip)
                .Take(numberOfElements)
                .ToList();
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SemestrNumber { get; set; }
        public string FieldOfStudy { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {FieldOfStudy}, Semestr: {SemestrNumber}";
        }
    }

}
