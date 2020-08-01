using System;
using System.Collections.Generic;

namespace _25FactoryMethod
{
    class Report : IDocument
    {
        public List<Page> Pages { get; set; }
        public string Title { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"--------Report: {Title}--------");
            foreach (var page in Pages)
            {
                System.Console.WriteLine(page);
            }
            System.Console.WriteLine(Environment.NewLine);
        }
    }
}
