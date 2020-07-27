using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_TABLE_IN_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsRepository = StudentRandomizer.CreateStudents(100);
            Console.WriteLine($"All students: {String.Join($"{Environment.NewLine}", studentsRepository)}{Environment.NewLine}");

            var result = new List<string>();
            try
            {
                result = MakePagination(studentsRepository, 5, 20);
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

        public static List<string> MakePagination(List<Student> source, int pageNumber, int numberOfElements)
        {
            var result = new List<string>();

            if (pageNumber < 1 || numberOfElements < 1)
            {
                throw new ArgumentException("MakePagination: Page number and number of elements should be greater than 0!");
            }
            if (source == null)
            {
                throw new ArgumentException("MakePagination: source shouldn't be null!");
            }

            if (numberOfElements >= source.Count())
            {
                return source.Select(s => s.ToString()).ToList();
            }

            int firstIndex = (pageNumber - 1) * numberOfElements;
            int lastIndex = (pageNumber - 1) * numberOfElements + numberOfElements;

            if (lastIndex > source.Count())
            {
                throw new ArgumentException("MakePagination: Wrong range.");

            }

            for (int i = firstIndex; i < lastIndex; i++)
            {
                result.Add(source[i].ToString());
            }

            return result;
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
            return $"{FirstName} {LastName} {FieldOfStudy} Semestr {SemestrNumber}";
        }
    }

    abstract class StudentRandomizer
    {
        #region Data to randomize
        static private List<string> FirstNames = new List<string>() { "Roman", "Hubert", "Alan", "Anastazy", "Ryszard", "Dominik", "Janusz", "Juliusz", "Eustachy", "Emanuel", "Dawid", "Eustachy", "Czesław", "Alexander", "Leszek", "Dorian", "Maurycy", "Marian", "Filip", "Adam", "Borys", "Konrad", "Anastazy", "Adam", "Martin", "Antoni", "Mariusz", "Bruno", "Remigiusz", "Cyprian", "Fryderyk", "Eugeniusz", "Igor", "Oktawian", "Paweł", "Ryszard", "Kewin", "Ksawery", "Przemysław", "Fryderyk", "Dobromił", "Amadeusz", "Jarosław", "Gniewomir", "Bronisław", "Ksawery", "Mikołaj", "Klaudiusz", "Fabian", "Julian", "Sylwia", "Bogda", "Amelia", "Lucyna", "Aniela", "Małgorzata", "Edyta", "Olimpia", "Bernadetta", "Jola", "Daria", "Oliwia", "Ida", "Pamela", "Wanda", "Ewa", "Paula", "Magdalena", "Bogumiła", "Krystyna", "Angelika", "Łucja", "Patrycja", "Kamila", "Celina", "Aisha", "Joanna", "Katarzyna", "Lara", "Hortensja", "Hortensja", "Liliana", "Lara", "Elżbieta", "Lucyna", "Marcela", "Małgorzata", "Lidia", "Iza", "Mirosława", "Gabriela", "Eliza", "Marta", "Barbara", "Kinga", "Marcela", "Patrycja", "Beata", "Marta", "Amalia" };
        static private List<string> LastNames = new List<string>() { "Przybylska", "Tomaszewska", "Kowalska", "Zakrzewska", "Sikora", "Adamska", "Baranowska", "Kucharska", "Kozłowska", "Walczak", "Mazur", "Sikorska", "Zalewska", "Ziółkowska", "Jasińska", "Witkowska", "Kucharska", "Głowacka", "Laskowska", "Błaszczyk", "Laskowska", "Mróz", "Laskowska", "Wasilewska", "Woźniak", "Sadowska", "Szymańska", "Przybylska", "Duda", "Jasińska", "Wojciechowska", "Zalewska", "Bąk", "Duda", "Adamska", "Mazurek", "Krawczyk", "Wasilewska", "Kowalczyk", "Chmielewska", "Woźniak", "Marciniak", "Przybylska", "Piotrowska", "Baran", "Zakrzewska", "Głowacka", "Baranowska", "Stępień", "Malinowska", "Mazur", "Jasiński", "Sikorska", "Lis", "Tomaszewski", "Borkowski", "Krupa", "Szewczyk", "Kubiak", "Adamska", "Sobczak", "Pawlak", "Kaczmarczyk", "Kamiński", "Zieliński", "Chmielewski", "Sokołowski", "Krupa", "Kucharski", "Mazurek", "Pawlak", "Mazurek", "Maciejewski", "Czarnecki", "Głowacka", "Kubiak", "Urbańska", "Szczepański", "Szczepański", "Jaworski", "Mazurek", "Brzeziński", "Bąk", "Ziółkowska", "Maciejewski", "Malinowski", "Duda", "Zakrzewska", "Jasiński", "Gajewska", "Wiśniewski", "Dąbrowski", "Szulc", "Jaworski", "Szymański", "Marciniak", "Kowalski", "Michalak", "Jaworski", "Wojciechowski" };
        static private List<int> SemestrNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static private List<string> FieldOfStudies = new List<string>() { "Nursing", "Psychology", "Biology", "Engineering", "Education", "Communications", "Finance and Accounting", "Criminal Justice", "Anthropology and Sociology", "Computer Science", "English", "Economics", "Political Science", "History", "Kinesiology and Physical Therapy", "Health Professions", "Art", "Math", "Environmental Science", "Foreign Languages", "Design", "Trades and Personal Services", "International Relations", "Chemistry", "Agricultural Sciences", "Information Technology", "Performing Arts", "Engineering Technicians", "Food and Nutrition" };
        #endregion

        public static List<Student> CreateStudents(int studentsNumber)
        {
            Random rand = new Random();
            var result = new List<Student>();
            for (int i = 0; i < studentsNumber; i++)
            {
                result.Add(new Student()
                {
                    FirstName = FirstNames[rand.Next(FirstNames.Count())],
                    LastName = LastNames[rand.Next(LastNames.Count())],
                    FieldOfStudy = FieldOfStudies[rand.Next(FieldOfStudies.Count())],
                    SemestrNumber = SemestrNumbers[rand.Next(SemestrNumbers.Count())],
                });
            }

            return result;
        }
    }
}
