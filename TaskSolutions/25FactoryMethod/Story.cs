using System;
using System.Collections.Generic;

namespace _25FactoryMethod
{
    class Story : IDocument
    {
        public string Author { get; set; }
        public List<Page> Pages { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"--------Story written by: {Author}--------4");
            foreach (var page in Pages)
            {
                System.Console.WriteLine(page);
            }
            System.Console.WriteLine(Environment.NewLine);
        }
    }
}
