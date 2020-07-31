using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25FactoryMethod
{
    class Program25
    {
        static void Main(string[] args)
        {
            var cv = DocumentFactory.CreateCV("Adam");
            var story = DocumentFactory.CreateStory("Adam S.");
            var report = DocumentFactory.CreateReport("aaaa");

            cv.Print();
            story.Print();
            report.Print();
            Console.ReadLine();
        }
    }
}
