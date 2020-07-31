using System.Collections.Generic;

namespace _25FactoryMethod
{
    class Story : IDocument
    {
        public string Author { get; set; }
        public List<Page> Pages { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"Story written by: {Author}");
            foreach (var page in Pages)
            {
                System.Console.WriteLine(page);
            }
        }
    }
}
