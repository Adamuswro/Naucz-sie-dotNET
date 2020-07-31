using System.Collections.Generic;

namespace _25FactoryMethod
{
    internal class CV : IDocument
    {
        public string Name;
        public List<Page> Pages { get; set; }

        public void Print()
        {
            System.Console.WriteLine("CV");
            foreach (var page in Pages)
            {
                System.Console.WriteLine(page);
            }
        }
    }
}
