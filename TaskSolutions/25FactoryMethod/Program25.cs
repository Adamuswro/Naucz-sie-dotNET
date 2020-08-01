using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace _25FactoryMethod
{
    class Program25
    {
        static void Main(string[] args)
        {
            var documents = new List<IDocument>()
            {
                DocumentFactory.CreateCV("Adam"),
                DocumentFactory.CreateStory("Adam S."),
                DocumentFactory.CreateReport("aaaa")
            };

            foreach (var document in documents)
            {
                document.Print();
            }

            ConsoleTools.CloseProgram();
        }
    }
}
